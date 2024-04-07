using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "68d6168e-4e02-4521-b6ea-8c4cb3e792c7", 0, "6ef29879-ff0f-46e9-b2bc-0d5dffa9016e", new DateTime(2024, 4, 7, 19, 26, 3, 589, DateTimeKind.Local).AddTicks(4276), "martoadmin@abv.bg", false, "Martin", "Stalev", false, null, "martoadmin@abv.bg", "admin", "AQAAAAEAACcQAAAAEI2zYlo/R/sD1IGzFdM1Qucw3gbVm26p4YN0rAdlJc/ArrK8ezPpT2+vAxNYrmkcDA==", null, false, "3e7acaef-0071-4c7b-8700-8e8c765c88a0", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68d6168e-4e02-4521-b6ea-8c4cb3e792c7");
        }
    }
}
