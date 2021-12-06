using Microsoft.AspNetCore.Builder;
using System.Data.SqlClient;
using Dapper;

namespace TeaBag.Configuration
{
    public static class CreateDatabaseExtension
    {
        public static IApplicationBuilder EnsureDatabase(this IApplicationBuilder app, string connectionString, string databaseName)
        {
            using SqlConnection connection = new(connectionString);

            dynamic record = connection.QueryFirstOrDefault("SELECT * FROM sys.databases WHERE name = @name", new { name = databaseName });

            if (record == null)
            {
                connection.Execute($"CREATE DATABASE {databaseName}");
            }

            return app;
        }
    }
}
