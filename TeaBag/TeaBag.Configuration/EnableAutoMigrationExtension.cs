using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using TeaBag.Configuration.Migrations;

namespace TeaBag.Configuration
{
    public static class EnableAutoMigrationExtension
    {
        public static IServiceCollection EnableAutoMigration(this IServiceCollection services)
        {
            services.AddFluentMigratorCore()
                .ConfigureRunner(c => c.AddSqlServer2012()
                .WithGlobalConnectionString("Server=DESKTOP-13N0LON;Database=TeaBag;Integrated Security=True;")
                .ScanIn(typeof(Create_Product_Table_Migration_2021_12_06_20_24_00).Assembly).For.All());

            return services;
        }
    }
}
