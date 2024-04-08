using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class FixedImageUrls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "018bff8a-5df3-40d8-8a65-e6a5e932f957",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16194d8d-bec1-4ec5-b7f5-bd9a1f8c6da4", new DateTime(2024, 4, 8, 16, 0, 54, 947, DateTimeKind.Local).AddTicks(82), "AQAAAAEAACcQAAAAEPaUFuFE6EII3MkdYHESazoRenb0xhyIyxiGGKsWOEWipi735zgGS3cDYD6WXGFptQ==", "594c2f7f-af9c-49a7-9408-4562f4c7d94a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11d42cfa-0eb5-4556-bbee-452d66efacf8",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a9dfb4c-32d0-4ade-9b29-c8b59524b78a", new DateTime(2024, 4, 8, 16, 0, 54, 943, DateTimeKind.Local).AddTicks(2134), "AQAAAAEAACcQAAAAEHppYVyxBxgi6QFTbLeVOYFpqDfOFbG4fCRggD8vkoFV9z93dGQNj0RRU1/K4VNm2Q==", "6cc7b43b-b65c-4b67-a4a5-773d3852bf0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba20f920-1a04-4d5b-8a7f-f0b0a328169d",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e743d38d-eb3b-4948-9fd4-b4b3f07c8256", new DateTime(2024, 4, 8, 16, 0, 54, 944, DateTimeKind.Local).AddTicks(4634), "AQAAAAEAACcQAAAAEJBeJyz5pZuUAx4Zx5Xs7Bbb3mDsQxrqx9tfSwM1VQR8Pxz64sn9KLNAnsH3MAHi3g==", "2e2665c5-50d8-4280-bc5a-8231b81219fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca27630c-7fa9-4d54-b8f1-851252abc519",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72f59421-3369-493a-a34a-cc9b5eb7014f", new DateTime(2024, 4, 8, 16, 0, 54, 945, DateTimeKind.Local).AddTicks(7885), "AQAAAAEAACcQAAAAENOZDuzwLUB+DUGer7T0AL/0r+vTMxTSriUL0yKNm4teqQtzpKNyBOsucfAxBYJdZg==", "998aede0-399e-4c8f-bbfa-33b95886ec09" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoUrl",
                value: "https://p7.hiclipart.com/preview/727/982/370/ireland-logo-lidl-symbols-lidl-logo.jpg");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "LogoUrl",
                value: "https://w7.pngwing.com/pngs/300/955/png-transparent-bosch-logo-robert-bosch-gmbh-arvato-company-automotive-industry-kitchen-tools-miscellaneous-text-trademark-thumbnail.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "018bff8a-5df3-40d8-8a65-e6a5e932f957");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11d42cfa-0eb5-4556-bbee-452d66efacf8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba20f920-1a04-4d5b-8a7f-f0b0a328169d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca27630c-7fa9-4d54-b8f1-851252abc519");

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
                    { "018bff8a-5df3-40d8-8a65-e6a5e932f957", 0, "86df21de-a7bc-4370-b6a8-1ae7e8ed428f", new DateTime(2024, 4, 8, 15, 23, 32, 396, DateTimeKind.Local).AddTicks(4179), "AppUser", "martoplays@abv.bg", false, "Martinkata", "Voivodov", false, null, "MARTOPLAYS@ABV.BG", "MARTINCHOTO", "AQAAAAEAACcQAAAAEDJZR0sWoPlWHAKdfwtyqDydPu8H/c9KcyhHFlYjfWEu3EA8WHZUUhXZ0YyuJf8e4w==", null, false, null, false, "martinchoto" },
                    { "11d42cfa-0eb5-4556-bbee-452d66efacf8", 0, "d98bcaac-4e3f-453e-82b8-a687b2b65008", new DateTime(2024, 4, 8, 15, 23, 32, 392, DateTimeKind.Local).AddTicks(2698), "AppUser", "martoadmin@abv.bg", false, "Martin", "Stalev", false, null, "martoadmin@abv.bg", "admin", "AQAAAAEAACcQAAAAEMyDYyUo0nuUu5oAFGZqhWB0gdhIYM2HX/VEBDN8atT0tec0RgyMOwfsii9X5gmYaw==", null, false, null, false, "admin" },
                    { "ba20f920-1a04-4d5b-8a7f-f0b0a328169d", 0, "239a0862-70b6-4b87-b470-7d076a28c4d0", new DateTime(2024, 4, 8, 15, 23, 32, 393, DateTimeKind.Local).AddTicks(6797), "AppUser", "lidlbg@abv.bg", false, null, null, false, null, "LIDLBG@ABV.BG", "LIDLBG", "AQAAAAEAACcQAAAAEF+22ejI+C/hA6kFtQFJ7+fq93V+FaNGXXgpFS2xfDoPQ1JmjKQLcEZYh2aRwL8tfA==", null, false, null, false, "lidlbg" },
                    { "ca27630c-7fa9-4d54-b8f1-851252abc519", 0, "f4e756fa-1805-4ff3-8c08-a6fd11217454", new DateTime(2024, 4, 8, 15, 23, 32, 395, DateTimeKind.Local).AddTicks(933), "AppUser", "boschbg@abv.bg", false, null, null, false, null, "BOSCHBG@ABV.BG", "BOSCHBG", "AQAAAAEAACcQAAAAEMECG3AtT1pqzRZ+hJCrG3SO8AWCXXdAAvQIBOxyugugFNLzWRikxPFTjzV57E7lhg==", null, false, null, false, "boschbg" }
                });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoUrl",
                value: "https://w7.pngwing.com/pngs/106/455/png-transparent-yellow-red-and-blue-lidl-logo-lidl-logo-retail-supermarket-toru%C5%84-lidl-food-text-business.png");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "LogoUrl",
                value: "https://banner2.cleanpng.com/20180804/loj/kisspng-logo-robert-bosch-gmbh-alternator-product-electric-adelaide-laser-calibration-service-repair-amp-5b659ac12b5114.3730089015333854091774.jpg");
        }
    }
}
