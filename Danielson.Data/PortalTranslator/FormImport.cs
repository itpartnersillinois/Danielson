using Danielson.Data.DataModels;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Danielson.Data.PortalTranslator {

    public class FormImport {
        private readonly string _connectionString;

        public FormImport(string? connectionString) {
            _connectionString = connectionString ?? "";
        }

        public FormImportInformation Get(int id) {
            using var connection = new SqlConnection(_connectionString);
            return connection.QuerySingle<FormImportInformation>("[danielson].usp_get_evaluation @evaluation_id", new { evaluation_id = id });
        }

        public async Task<int> Save(Form form, string username) {
            using var connection = new SqlConnection(_connectionString);
            return await connection.ExecuteAsync("[danielson].[usp_update_evaluation] @evaluation_id, @evaluation_cte_stu_id, @modified_by, @evaluator_netid, @isMidterm, @domain1_a, @domain1_b, @domain1_c, @domain1_d, @domain1_e, @domain1_f, @domain1_strengths, @domain1_next_steps, @domain2_a, @domain2_b, @domain2_c, @domain2_d, @domain2_e, @domain2_strengths, @domain2_next_steps, @domain3_a, @domain3_b, @domain3_c, @domain3_d, @domain3_e, @domain3_strengths, @domain3_next_steps, @domain4_a, @domain4_b, @domain4_c, @domain4_d, @domain4_e, @domain4_f, @domain4_strengths, @domain4_next_steps, @summary, @signature",
                    new {
                        evaluation_id = form.StudentEvaluationId,
                        evaluation_cte_stu_id = form.StudentId,
                        modified_by = username,
                        evaluator_netid = form.Email, // TODO change to username when we get this
                        isMidterm = form.IsMidterm,
                        domain1_a = GetFormDomainValue(form, DomainEnum.One, 1),
                        domain1_b = GetFormDomainValue(form, DomainEnum.One, 2),
                        domain1_c = GetFormDomainValue(form, DomainEnum.One, 3),
                        domain1_d = GetFormDomainValue(form, DomainEnum.One, 4),
                        domain1_e = GetFormDomainValue(form, DomainEnum.One, 5),
                        domain1_f = GetFormDomainValue(form, DomainEnum.One, 6),
                        domain2_a = GetFormDomainValue(form, DomainEnum.Two, 1),
                        domain2_b = GetFormDomainValue(form, DomainEnum.Two, 2),
                        domain2_c = GetFormDomainValue(form, DomainEnum.Two, 3),
                        domain2_d = GetFormDomainValue(form, DomainEnum.Two, 4),
                        domain2_e = GetFormDomainValue(form, DomainEnum.Two, 5),
                        domain3_a = GetFormDomainValue(form, DomainEnum.Three, 1),
                        domain3_b = GetFormDomainValue(form, DomainEnum.Three, 2),
                        domain3_c = GetFormDomainValue(form, DomainEnum.Three, 3),
                        domain3_d = GetFormDomainValue(form, DomainEnum.Three, 4),
                        domain3_e = GetFormDomainValue(form, DomainEnum.Three, 5),
                        domain4_a = GetFormDomainValue(form, DomainEnum.Four, 1),
                        domain4_b = GetFormDomainValue(form, DomainEnum.Four, 2),
                        domain4_c = GetFormDomainValue(form, DomainEnum.Four, 3),
                        domain4_d = GetFormDomainValue(form, DomainEnum.Four, 4),
                        domain4_e = GetFormDomainValue(form, DomainEnum.Four, 5),
                        domain4_f = GetFormDomainValue(form, DomainEnum.Four, 6),
                        domain1_strengths = GetFormDomainStrengths(form, DomainEnum.One),
                        domain1_next_steps = GetFormDomainNextSteps(form, DomainEnum.One),
                        domain2_strengths = GetFormDomainStrengths(form, DomainEnum.Two),
                        domain2_next_steps = GetFormDomainNextSteps(form, DomainEnum.Two),
                        domain3_strengths = GetFormDomainStrengths(form, DomainEnum.Three),
                        domain3_next_steps = GetFormDomainNextSteps(form, DomainEnum.Three),
                        domain4_strengths = GetFormDomainStrengths(form, DomainEnum.Four),
                        domain4_next_steps = GetFormDomainNextSteps(form, DomainEnum.Four),
                        summary = form.FinalSummary,
                        signature = form.IsSigned
                    });
        }

        private static string GetFormDomainNextSteps(Form form, DomainEnum domain) => form.DomainAnswers.Where(da => da.IsActive).FirstOrDefault(da => da.DomainItem == domain)?.NextSteps ?? "";

        private static string GetFormDomainStrengths(Form form, DomainEnum domain) => form.DomainAnswers.Where(da => da.IsActive).FirstOrDefault(da => da.DomainItem == domain)?.Strengths ?? "";

        private static int GetFormDomainValue(Form form, DomainEnum domain, int order) => form.ComponentAnswers.Where(da => da.IsActive).FirstOrDefault(ca => ca.DomainItem == domain && ca.ComponentOrder == order)?.QuantitativeScore ?? 0;
    }
}