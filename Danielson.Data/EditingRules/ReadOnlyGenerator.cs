using Danielson.Data.DataModels;

namespace Danielson.Data.EditingRules {

    public static class ReadOnlyGenerator {

        public static bool IsReadOnly(Form form, RoleEnum role) {
            if (role == RoleEnum.CoteStaff || role == RoleEnum.ProgramStaff) {
                return false;
            }
            if (role == RoleEnum.Supervisor && form.FormType.Contains("Cooperating")) {
                return true;
            }
            if (form.DateEvaluated == null) {
                return false;
            }
            return true;
        }
    }
}