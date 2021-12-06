using FluentMigrator;
using FluentMigrator.SqlServer;

namespace TeaBag.Configuration.Migrations
{
    [Migration(20211206202400)]
    public class Create_Product_Table_Migration_2021_12_06_20_24_00 : Migration
    {
        public override void Down()
        {
            Delete.Table("Products");
        }

        public override void Up()
        {
            Create.Table("Products")
                .WithDescription("Список продуктов")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity(1, 1)
                .WithColumn("ProductId").AsGuid().NotNullable().Unique()
                .WithColumn("ProductName").AsString(150).NotNullable().Unique();
        }
    }
}
