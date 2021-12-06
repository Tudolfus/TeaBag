using FluentMigrator.Runner;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace TeaBag.Configuration
{
    public static class RunSqlScriptsExtension
    {
        public static IApplicationBuilder RunSqlScripts(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();
            IMigrationRunner runner = scope.ServiceProvider.GetService<IMigrationRunner>();

            runner.MigrateUp(20211206202400);

            return app;
        }
    }
}
