using Danielson.Data.Data;
using Danielson.Data.DataModels;

namespace Danielson.Data.Login {

    public class UserAccess(FormRepository? testRepository, string? testingString) {
        private readonly bool _testing = (testingString ?? "") == "testing";
        private readonly FormRepository _testRepository = testRepository ?? throw new ArgumentNullException("testRepository");
        private string TargetBaseUrl => IsTesting ? "https://cte-s-test.education.illinois.edu/dotnet/" : "https://cte-s.education.illinois.edu/dotnet/";
        public bool IsTesting => _testing;

        public Dictionary<RoleEnum, string> TargetUrl => new Dictionary<RoleEnum, string> {

                { RoleEnum.Student, TargetBaseUrl + "portals/studentportal.aspx/checklist" },
                { RoleEnum.Supervisor, TargetBaseUrl + "portals/supervisorportal.aspx/checklist" },
                { RoleEnum.CooperatingTeacher, TargetBaseUrl + "portals/coopportal.aspx/checklist" },
                { RoleEnum.Admin, TargetBaseUrl + "portals/programportal.aspx" },
                { RoleEnum.CoteStaff, TargetBaseUrl + "portals/programportal.aspx" },
                { RoleEnum.ProgramStaff, TargetBaseUrl + "portals/programportal.aspx" },
                { RoleEnum.None, "" }
            };

        public async Task<(string email, string username, RoleEnum role, string studentEvaluationId)> Get(Guid guid) {
            
            var user = await _testRepository.ReadAsync(r => r.Users.FirstOrDefault(u => u.Guid == guid && (_testing || u.IsActive)));
            if (user == null) {

                return ("", "", RoleEnum.None, "");
            } 
            _ = await _testRepository.ChangeActiveAsync(user, false);
            return (user.Email, user.Username, user.Role, user.StudentEvaluationId.ToString());
        }

        public async Task<(string email, string username, RoleEnum role)> GetByName(string username) {
            var user = await _testRepository.ReadAsync(r => r.Users.FirstOrDefault(u => u.Username == username));
            return user == null ? ((string email, string username, RoleEnum role)) ("", "", RoleEnum.None) : ((string email, string username, RoleEnum role)) (user.Email, user.Username, user.Role);
        }
       
    }
}