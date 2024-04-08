using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class SeedCompanies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "018bff8a-5df3-40d8-8a65-e6a5e932f957",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "86df21de-a7bc-4370-b6a8-1ae7e8ed428f", new DateTime(2024, 4, 8, 15, 23, 32, 396, DateTimeKind.Local).AddTicks(4179), "AQAAAAEAACcQAAAAEDJZR0sWoPlWHAKdfwtyqDydPu8H/c9KcyhHFlYjfWEu3EA8WHZUUhXZ0YyuJf8e4w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11d42cfa-0eb5-4556-bbee-452d66efacf8",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "d98bcaac-4e3f-453e-82b8-a687b2b65008", new DateTime(2024, 4, 8, 15, 23, 32, 392, DateTimeKind.Local).AddTicks(2698), "AQAAAAEAACcQAAAAEMyDYyUo0nuUu5oAFGZqhWB0gdhIYM2HX/VEBDN8atT0tec0RgyMOwfsii9X5gmYaw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba20f920-1a04-4d5b-8a7f-f0b0a328169d",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "239a0862-70b6-4b87-b470-7d076a28c4d0", new DateTime(2024, 4, 8, 15, 23, 32, 393, DateTimeKind.Local).AddTicks(6797), "AQAAAAEAACcQAAAAEF+22ejI+C/hA6kFtQFJ7+fq93V+FaNGXXgpFS2xfDoPQ1JmjKQLcEZYh2aRwL8tfA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca27630c-7fa9-4d54-b8f1-851252abc519",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "f4e756fa-1805-4ff3-8c08-a6fd11217454", new DateTime(2024, 4, 8, 15, 23, 32, 395, DateTimeKind.Local).AddTicks(933), "AQAAAAEAACcQAAAAEMECG3AtT1pqzRZ+hJCrG3SO8AWCXXdAAvQIBOxyugugFNLzWRikxPFTjzV57E7lhg==" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CompanyName", "Location", "LogoUrl", "UserId" },
                values: new object[,]
                {
                    { 2, "ul. Iordan Iosifov", "Lidl", "Sofia", "https://w7.pngwing.com/pngs/106/455/png-transparent-yellow-red-and-blue-lidl-logo-lidl-logo-retail-supermarket-toru%C5%84-lidl-food-text-business.png", "ba20f920-1a04-4d5b-8a7f-f0b0a328169d" },
                    { 3, "bul. Tsarigradsko Shose", "Bosch", "Sofia", "https://banner2.cleanpng.com/20180804/loj/kisspng-logo-robert-bosch-gmbh-alternator-product-electric-adelaide-laser-calibration-service-repair-amp-5b659ac12b5114.3730089015333854091774.jpg", "ca27630c-7fa9-4d54-b8f1-851252abc519" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "018bff8a-5df3-40d8-8a65-e6a5e932f957",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "99e696d3-8013-499f-ae74-ac8d129e1edd", new DateTime(2024, 4, 8, 15, 20, 40, 153, DateTimeKind.Local).AddTicks(4235), "AQAAAAEAACcQAAAAEPkvXdqKQJ5kYh+O/IUiducfz2zIrLh7Lq2+DAkdjL/GLj/KbgjNDeMtSIQ3gbJZDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11d42cfa-0eb5-4556-bbee-452d66efacf8",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "7def970c-9b33-46c6-952b-b8834bb99886", new DateTime(2024, 4, 8, 15, 20, 40, 149, DateTimeKind.Local).AddTicks(6899), "AQAAAAEAACcQAAAAEE93fuK61DCy4yaGaekSvegs9XArtRl7bIA/tawH0Y15JRpYJc1ivYJgU/j3J9t2tg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba20f920-1a04-4d5b-8a7f-f0b0a328169d",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "b48e58b9-4791-4c6f-a3b6-a53427eb64fc", new DateTime(2024, 4, 8, 15, 20, 40, 150, DateTimeKind.Local).AddTicks(9283), "AQAAAAEAACcQAAAAEN9bYRjHwDQxpa/wVHmpvCNL2p/QJl6ImpO5PFvSjolXQHb8G5J+4+qXhD5JYyws1w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca27630c-7fa9-4d54-b8f1-851252abc519",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash" },
                values: new object[] { "471399f4-645b-4e88-a482-752e0cb25b66", new DateTime(2024, 4, 8, 15, 20, 40, 152, DateTimeKind.Local).AddTicks(1396), "AQAAAAEAACcQAAAAEHzOmUI/f0YtdG8w43f9eozASuBT0GIXOMNsI0hJSASNn7Ith1VMVTzRhHMOiu5bLA==" });
        }
    }
}
