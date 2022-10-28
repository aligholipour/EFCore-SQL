﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSQL.Infrastructure.Migrations
{
    public partial class CreateScalarFunction_NumberOFCustomerOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE FUNCTION dbo.NumberOFCustomerOrder (@customerId INT)
                                    RETURNS INT
                                    AS
                                    BEGIN  
	                                    DECLARE @OrderCount INT;
	                                    SELECT @OrderCount = COUNT(*)
	                                    FROM Orders
	                                    LEFT JOIN Customers
		                                    ON Orders.CustomerId = @customerId
	                                    GROUP BY Customers.Name
	                                    ORDER BY COUNT(*) DESC

	                                    RETURN(@OrderCount);
                                    END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP FUNCTION dbo.NumberOFCustomerOrder");
        }
    }
}
