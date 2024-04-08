using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class FixedBug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d0778f1-d812-4955-980b-3c7c4470dde4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9adfb245-d5c4-4390-9f52-fe184f80dade");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5ccbc5e-aa23-4f5e-b667-bdcf7b31ee6a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f380175c-ed7e-4287-8589-a0f0e4e60a69");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "018bff8a-5df3-40d8-8a65-e6a5e932f957", 0, "99e696d3-8013-499f-ae74-ac8d129e1edd", new DateTime(2024, 4, 8, 15, 20, 40, 153, DateTimeKind.Local).AddTicks(4235), "AppUser", "martoplays@abv.bg", false, "Martinkata", "Voivodov", false, null, "MARTOPLAYS@ABV.BG", "MARTINCHOTO", "AQAAAAEAACcQAAAAEPkvXdqKQJ5kYh+O/IUiducfz2zIrLh7Lq2+DAkdjL/GLj/KbgjNDeMtSIQ3gbJZDw==", null, false, null, false, "martinchoto" },
                    { "11d42cfa-0eb5-4556-bbee-452d66efacf8", 0, "7def970c-9b33-46c6-952b-b8834bb99886", new DateTime(2024, 4, 8, 15, 20, 40, 149, DateTimeKind.Local).AddTicks(6899), "AppUser", "martoadmin@abv.bg", false, "Martin", "Stalev", false, null, "martoadmin@abv.bg", "admin", "AQAAAAEAACcQAAAAEE93fuK61DCy4yaGaekSvegs9XArtRl7bIA/tawH0Y15JRpYJc1ivYJgU/j3J9t2tg==", null, false, null, false, "admin" },
                    { "ba20f920-1a04-4d5b-8a7f-f0b0a328169d", 0, "b48e58b9-4791-4c6f-a3b6-a53427eb64fc", new DateTime(2024, 4, 8, 15, 20, 40, 150, DateTimeKind.Local).AddTicks(9283), "AppUser", "lidlbg@abv.bg", false, null, null, false, null, "LIDLBG@ABV.BG", "LIDLBG", "AQAAAAEAACcQAAAAEN9bYRjHwDQxpa/wVHmpvCNL2p/QJl6ImpO5PFvSjolXQHb8G5J+4+qXhD5JYyws1w==", null, false, null, false, "lidlbg" },
                    { "ca27630c-7fa9-4d54-b8f1-851252abc519", 0, "471399f4-645b-4e88-a482-752e0cb25b66", new DateTime(2024, 4, 8, 15, 20, 40, 152, DateTimeKind.Local).AddTicks(1396), "AppUser", "boschbg@abv.bg", false, null, null, false, null, "BOSCHBG@ABV.BG", "BOSCHBG", "AQAAAAEAACcQAAAAEHzOmUI/f0YtdG8w43f9eozASuBT0GIXOMNsI0hJSASNn7Ith1VMVTzRhHMOiu5bLA==", null, false, null, false, "boschbg" }
                });
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8d0778f1-d812-4955-980b-3c7c4470dde4", 0, "3457c11b-45d4-49da-b48c-09171de5eebc", new DateTime(2024, 4, 8, 15, 15, 29, 99, DateTimeKind.Local).AddTicks(1583), "AppUser", "boschbg@abv.bg", false, null, null, false, null, "BOSCHBG@ABV.BG", "BOSCHBG", "AQAAAAEAACcQAAAAEK//beHEEsesMjvG+9PATTlThlu2RZ65aIjN/CurCl0HRgy9ZyjI3zsLyEBdpgm/XQ==", null, false, null, false, "boschbg" },
                    { "9adfb245-d5c4-4390-9f52-fe184f80dade", 0, "dc37ebe9-1372-4226-8456-e214715da8b0", new DateTime(2024, 4, 8, 15, 15, 29, 96, DateTimeKind.Local).AddTicks(7010), "AppUser", "martoadmin@abv.bg", false, "Martin", "Stalev", false, null, "martoadmin@abv.bg", "admin", "AQAAAAEAACcQAAAAEMXe8fZ6znQXHn/0F1jS9ZEGJgLLS8eSi8SPFAlPfbwIqtKx0mSrUpHR2ddXSyT3Jg==", null, false, null, false, "admin" },
                    { "b5ccbc5e-aa23-4f5e-b667-bdcf7b31ee6a", 0, "78c7d4e2-3384-4b09-9f2c-dd08bc62be80", new DateTime(2024, 4, 8, 15, 15, 29, 100, DateTimeKind.Local).AddTicks(3836), "AppUser", "martoplays@abv.bg", false, "Martinkata", "Voivodov", false, null, "MARTOPLAYS@ABV.BG", "MARTINCHOTO", "AQAAAAEAACcQAAAAEOEc7tGCGvZvweJuyb5Ljczjm/1dUHy7aHb+D9ItAmOqsb5FlL0Mr/hahSPJkJ27SA==", null, false, null, false, "martinchoto" },
                    { "f380175c-ed7e-4287-8589-a0f0e4e60a69", 0, "b4eb7d5d-7589-426c-802e-96f651f60638", new DateTime(2024, 4, 8, 15, 15, 29, 97, DateTimeKind.Local).AddTicks(9879), "AppUser", "lidlbg@abv.bg", false, null, null, false, null, "LIDLBG@ABV.BG", "LIDLBG", "AQAAAAEAACcQAAAAELhAYGh3Mg61b2e8YJ2DQI3k0/TtgByBB9UfJg82umMIymOkSNNjPLiQWSFqy6TeyA==", null, false, null, false, "lidlbg" }
                });
        }
    }
}
