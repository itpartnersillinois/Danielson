using Danielson.Data.DataModels;

namespace Danielson.Data.EditingRules {

    public static class ReadOnlyGenerator {

        public static bool IsReadOnly(Form form, RoleEnum role) {
            if (role == RoleEnum.CoteStaff || role == RoleEnum.ProgramStaff) {
                return false;
            }
            if (form.DateEvaluated == null) {
                return false;
            }
            return true;
        }
    }
}