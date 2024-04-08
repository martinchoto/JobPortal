using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class fixeditagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "018bff8a-5df3-40d8-8a65-e6a5e932f957",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c45b277-bd01-4596-ac86-91a88cc3032a", new DateTime(2024, 4, 8, 16, 3, 47, 892, DateTimeKind.Local).AddTicks(5169), "AQAAAAEAACcQAAAAEHc5daYpckvDaocq5nh+Xuv5IvGZivdSYPPivgt8dR9zeqM+K4CjBNnmErivj7rGBA==", "c7d5c393-57d1-4cb5-aaa2-46c14d6205ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11d42cfa-0eb5-4556-bbee-452d66efacf8",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "175431af-ed22-4017-9c10-ac70d9e19343", new DateTime(2024, 4, 8, 16, 3, 47, 888, DateTimeKind.Local).AddTicks(6859), "AQAAAAEAACcQAAAAEDWvrfhTMNC3RT9Htz/Qv+Decgci4zHS/n5uykjcGIZP/SWea8JJRTCSI1Hask99AA==", "8618223f-baf0-4b9f-b670-b05e441a6740" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba20f920-1a04-4d5b-8a7f-f0b0a328169d",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "216b3e46-cb56-459e-becc-cf2345bc8bdf", new DateTime(2024, 4, 8, 16, 3, 47, 889, DateTimeKind.Local).AddTicks(9268), "AQAAAAEAACcQAAAAEIb+0gbmSJMAmwWqbKO/i445pDJ7Dqc0NrpXvaw7QEOJBQ3K6nc779Cm/q3FbeZYkg==", "63766dc9-f52c-4d0e-be02-969a2e773948" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca27630c-7fa9-4d54-b8f1-851252abc519",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31bc1246-8823-4023-9b42-ec78ed4246f1", new DateTime(2024, 4, 8, 16, 3, 47, 891, DateTimeKind.Local).AddTicks(1585), "AQAAAAEAACcQAAAAEHlZTwHXi8D3K4jdOP/eehHWFGZ+BU5SlrIecNxROZjhbFdA3PDgfnArwN+XD6E2DQ==", "f87a80f6-21b2-4b24-837b-9cee2d19556f" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/9/91/Lidl-Logo.svg/150px-Lidl-Logo.svg.png");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "LogoUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/1/16/Bosch-logo.svg/1920px-Bosch-logo.svg.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
