using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSQL.Infrastructure.Migrations
{
    public partial class GetAllCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW GetAllCustomer as" +
                                "SELECT Customers.Id, Customers.Name" +
                                "FROM dbo.Customers;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW GetAllCustomer;");
        }
    }
}
