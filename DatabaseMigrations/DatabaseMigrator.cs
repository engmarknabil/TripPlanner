using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Web;
using DbUp;

namespace DatabaseMigrations
{
    public class DatabaseMigrator
    {
        private const string MasterConnectionString = @"Data Source=.;Initial Catalog=master;Integrated Security=True";
        private const string ItineraryPlannerConnectionString = @"Data Source=.;Initial Catalog=ItineraryPlanner;Integrated Security=True";

        public void Migrate()
        {
            PrepareDatabase();
            UpgradeDatabase();
        }

        private static void PrepareDatabase()
        {
            var filePath = HttpContext.Current.Server.MapPath(@"~\bin\CreateDatabase.sql");
            var createDatabaseSql = File.ReadAllText(filePath);

            using (var connection = new SqlConnection(MasterConnectionString))
            {
                using (var command = new SqlCommand(createDatabaseSql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void UpgradeDatabase()
        {
            var upgradeEngine = DeployChanges.To.SqlDatabase(ItineraryPlannerConnectionString)
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                .LogToConsole()
                .Build();

            var result = upgradeEngine.PerformUpgrade();

            if (!result.Successful)
            {
                throw new DatabaseUpgradeFailedException(result);
            }
        }
    }
}
