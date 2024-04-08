using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68d6168e-4e02-4521-b6ea-8c4cb3e792c7");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07da9f74-ea66-4909-8374-fb770efb383b", 0, "25781a97-d718-4258-9d9a-23c41a5f9a1b", new DateTime(2024, 4, 8, 15, 15, 7, 376, DateTimeKind.Local).AddTicks(1884), "AppUser", "martoplays@abv.bg", false, "Martinkata", "Voivodov", false, null, "MARTOPLAYS@ABV.BG", "MARTINCHOTO", "AQAAAAEAACcQAAAAEK0JSf3bHn/m4rSKD7sNdVJDKvEtddfmbN8qQFjsQUA6yyyxSI+axp6wUfLS7Ld7NQ==", null, false, null, false, "martinchoto" },
                    { "5f9799fb-f83d-442c-8af4-833b0858b628", 0, "7d95b18c-1b40-495e-9516-76baa71392b4", new DateTime(2024, 4, 8, 15, 15, 7, 372, DateTimeKind.Local).AddTicks(5746), "AppUser", "martoadmin@abv.bg", false, "Martin", "Stalev", false, null, "martoadmin@abv.bg", "admin", "AQAAAAEAACcQAAAAEMihDMCquX4Eh097cAigApx+dUv7xqVh5+ZhzUg6HTNBdbSt+C+PQbIxrvweyQQDUg==", null, false, null, false, "admin" },
                    { "67664bad-6599-4849-8666-bed16a8eb7b8", 0, "65af57a7-5820-4100-8aee-d5cc3eb7a616", new DateTime(2024, 4, 8, 15, 15, 7, 373, DateTimeKind.Local).AddTicks(8155), "AppUser", "lidlbg@abv.bg", false, null, null, false, null, "LIDLBG@ABV.BG", "LIDLBG", "AQAAAAEAACcQAAAAECOx7qmEPZU1eLAnKIewjRye+QagPZqNKEEzmfkRFl+KTRJXDAIqspVEKsDf9HgKcA==", null, false, null, false, "lidlbg" },
                    { "8190d96f-16a5-447d-ad93-cddcbe8ae5f0", 0, "9b971e98-a6db-40b3-a8c3-04f87927fd2c", new DateTime(2024, 4, 8, 15, 15, 7, 375, DateTimeKind.Local).AddTicks(54), "AppUser", "boschbg@abv.bg", false, null, null, false, null, "BOSCHBG@ABV.BG", "BOSCHBG", "AQAAAAEAACcQAAAAEDprYX9tJ+dG9JUng3Xb3AA5JPW1I7+UQ5t4GW8RKV5jlxLBlC8By3q3TsliLn/z5g==", null, false, null, false, "boschbg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07da9f74-ea66-4909-8374-fb770efb383b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f9799fb-f83d-442c-8af4-833b0858b628");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67664bad-6599-4849-8666-bed16a8eb7b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8190d96f-16a5-447d-ad93-cddcbe8ae5f0");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "68d6168e-4e02-4521-b6ea-8c4cb3e792c7", 0, "6ef29879-ff0f-46e9-b2bc-0d5dffa9016e", new DateTime(2024, 4, 7, 19, 26, 3, 589, DateTimeKind.Local).AddTicks(4276), "martoadmin@abv.bg", false, "Martin", "Stalev", false, null, "martoadmin@abv.bg", "admin", "AQAAAAEAACcQAAAAEI2zYlo/R/sD1IGzFdM1Qucw3gbVm26p4YN0rAdlJc/ArrK8ezPpT2+vAxNYrmkcDA==", null, false, "3e7acaef-0071-4c7b-8700-8e8c765c88a0", false, "admin" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CompanyName", "Location", "LogoUrl", "UserId" },
                values: new object[] { 1, "ul. Aleksander Stamboliiski", "Billa", "Pazardjik", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d8/Billa-Logo.svg/2560px-Billa-Logo.svg.png", "b5b0f315-98eb-4078-bf80-a329869ad392" });
        }
    }
}
