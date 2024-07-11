using Dapper;
using Microsoft.Data.SqlClient;

namespace Danielson.Data.PortalTranslator {

    public class FormExport {
        private readonly string _connectionString;

        public FormExport(string? connectionString) {
            _connectionString = connectionString ?? "";
        }

        public FormExportInformation Get(int id) {
            using var connection = new SqlConnection(_connectionString);
            return connection.QuerySingle<FormExportInformation>("[danielson].usp_get_evaluation @evaluation_id", new { evaluation_id = id });
        }
    }
}