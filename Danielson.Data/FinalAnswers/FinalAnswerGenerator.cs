using Danielson.Data.DataModels;

namespace Danielson.Data.FinalAnswers {

    public static class FinalAnswerGenerator {

        public static List<string> GetFinalAnswers(Form form) {

            // Options for Summary Rating were revised on 2026-09. The previous options are commented out below for reference.

            //if (form.Position == "C" && form.IsMidterm)
            //{
            //    return [
            //        "Unsatisfactory", "Continue Placement with Reservation", "Satisfactory"
            //    ];
            //}
            //else if (form.Position == "U" && form.IsMidterm)
            //{
            //    return [
            //        "Unsatisfactory", "Continue Placement with Remediation", "Continue Placement with Reservation", "Satisfactory"
            //    ];
            //}
            //else if (form.PlacementType == "EFE" && form.Position == "C")
            //{
            //    return [
            //        "Unsatisfactory", "Continue Program with Reservation", "Satisfactory"
            //    ];
            //}
            //else if (form.PlacementType == "EFE" && form.Position == "U")
            //{
            //    return [
            //        "Unsatisfactory", "Continue Program with Remediation", "Satisfactory"
            //    ];
            //}
            //else if (form.PlacementType == "ST" && (form.Position == "C" || form.Position == "U"))
            //{
            //    return [
            //        "Unsatisfactory", "Satisfactory"
            //    ];
            //}


            // Change implemented on 2026-09 after revision of Summary Rating options for Midterm and Final Evaluations.
            // The new options are as follows:

            if (form.Position == "C" && form.IsMidterm) {
                return [
                    "Recommend Unsatisfactory", "Concerns Noted", "Recommend Satisfactory"
                ];
            } else if (form.Position == "U" && form.IsMidterm) {
                return [
                    "Unsatisfactory", "Continue with Remediation", "Satisfactory"
                ];
            } else if (form.PlacementType == "EFE" && form.Position == "C") {
                return [
                    "Recommend Unsatisfactory", "Concerns Noted", "Recommend Satisfactory"
                ];
            } else if (form.PlacementType == "EFE" && form.Position == "U") {
                return [
                    "Unsatisfactory", "Satisfactory"
                ];
            } else if (form.PlacementType == "ST" && form.Position == "C") {
                return [
                    "Unsatisfactory", "Concerns Noted", "Satisfactory"
                ];
            } else if (form.PlacementType == "ST" && form.Position == "U") {
                return [
                    "Unsatisfactory","Satisfactory"
                ];
            }

            return [];
        }
    }
}