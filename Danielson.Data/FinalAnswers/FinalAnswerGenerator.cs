using Danielson.Data.DataModels;

namespace Danielson.Data.FinalAnswers {

    public static class FinalAnswerGenerator {

        public static List<string> GetFinalAnswers(Form form) {
            if (form.Position == "C" && form.IsMidterm) {
                return [
                    "Unsatisfactory", "Continue Placement with Reservation", "Satisfactory"
                ];
            } else if (form.Position == "U" && form.IsMidterm) {
                return [
                    "Unsatisfactory", "Continue Placement with Remediation", "Continue Placement with Reservation", "Satisfactory"
                ];
            } else if (form.PlacementType == "EFE" && form.Position == "C") {
                return [
                    "Unsatisfactory", "Continue Program with Reservation", "Satisfactory"
                ];
            } else if (form.PlacementType == "EFE" && form.Position == "U") {
                return [
                    "Unsatisfactory", "Continue Program with Remediation", "Satisfactory"
                ];
            } else if (form.PlacementType == "ST" && (form.Position == "C" || form.Position == "U")) {
                return [
                    "Unsatisfactory", "Satisfactory"
                ];
            }
            return [];
        }
    }
}