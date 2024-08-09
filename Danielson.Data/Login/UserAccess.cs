using Danielson.Data.Data;
using Danielson.Data.DataModels;

namespace Danielson.Data.Login {

    public class UserAccess(FormRepository? testRepository, string? testingString) {
        private readonly bool _testing = (testingString ?? "") == "testing";
        private readonly FormRepository _testRepository = testRepository ?? throw new ArgumentNullException("testRepository");
        public bool IsTesting => _testing;

        public string TargetUrl => IsTesting ? "https://cte-s-test.education.illinois.edu/dotnet/portals/programportal.aspx" : "https://cte-s.education.illinois.edu/dotnet/portals/programportal.aspx";

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