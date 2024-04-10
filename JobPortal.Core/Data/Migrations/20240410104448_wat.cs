using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class wat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "018bff8a-5df3-40d8-8a65-e6a5e932f957",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2f5feca-18c7-4b4d-b4c5-d88d66838dba", new DateTime(2024, 4, 10, 13, 44, 47, 892, DateTimeKind.Local).AddTicks(7322), "AQAAAAEAACcQAAAAEEZYO+kgwcxhUElrXUj+0/pEXKeK9fC9QRYdNx54p1oXM0iS4pIupDH2IpLObGTJow==", "ecdb954d-dbc2-480b-a077-a618147459b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11d42cfa-0eb5-4556-bbee-452d66efacf8",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "235f9f09-12ae-4048-bddc-ec7e19257b9c", new DateTime(2024, 4, 10, 13, 44, 47, 888, DateTimeKind.Local).AddTicks(8559), "AQAAAAEAACcQAAAAENUrsTRBR+yBhnd69UzybzUfkjVL3R3AwK0ib1sDwaRQhM/jqYBRcAoKbgbHkvsOAg==", "6a91762a-448c-4ac3-94e3-ad56a479fc0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba20f920-1a04-4d5b-8a7f-f0b0a328169d",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a93be47-ea31-42c9-9d8c-c91b954cf7c2", new DateTime(2024, 4, 10, 13, 44, 47, 890, DateTimeKind.Local).AddTicks(1564), "AQAAAAEAACcQAAAAEFV62lTzsJ9kI25O6l42awahz6CLLshi/uOJ8PQhRbdGSPlNhzKSNpUp2XpuLShS8Q==", "c1624e79-3068-432c-9564-4888d191ef9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca27630c-7fa9-4d54-b8f1-851252abc519",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e25cfcee-c09c-4578-aabb-bc060a83cca4", new DateTime(2024, 4, 10, 13, 44, 47, 891, DateTimeKind.Local).AddTicks(4452), "AQAAAAEAACcQAAAAEEo3SODEcI7Jc/9nqBijqgrVUISk3zhIEhaCN7np6PH7U7Kdt5AplY8J3xjcS76i9g==", "69e29369-43c0-4697-9f75-43f4023ea55f" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 9, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 5, 20, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 30, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 30, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 4, 14, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 5, 25, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2023, 5, 13, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedDate",
                value: new DateTime(2023, 5, 13, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedDate",
                value: new DateTime(2023, 5, 13, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedDate",
                value: new DateTime(2024, 3, 8, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedDate",
                value: new DateTime(2024, 3, 8, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedDate",
                value: new DateTime(2024, 3, 8, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedDate",
                value: new DateTime(2024, 4, 7, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 8,
                column: "PostedDate",
                value: new DateTime(2024, 4, 7, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedDate",
                value: new DateTime(2024, 4, 7, 13, 44, 47, 894, DateTimeKind.Local).AddTicks(216));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "018bff8a-5df3-40d8-8a65-e6a5e932f957",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "804cb93c-7282-4159-a9a4-45174e670bbe", new DateTime(2024, 4, 8, 16, 59, 54, 377, DateTimeKind.Local).AddTicks(3180), "AQAAAAEAACcQAAAAEO/HwwiCJP6Xk9EIMBBwUA75Dwhw9+g1zSCoUbbH2hCxovx8AR/DRYs4P6lsHCQhVw==", "3dfebfbb-8ab7-4d70-b81f-01a5cdaf5017" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11d42cfa-0eb5-4556-bbee-452d66efacf8",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4aac6842-aac7-4ae6-9ed9-6817e3dc9378", new DateTime(2024, 4, 8, 16, 59, 54, 373, DateTimeKind.Local).AddTicks(4401), "AQAAAAEAACcQAAAAEOdB9Bg8vYS+vwD6nE4itfJMgfccVgPT6gI8AxQLTTtGhuIVEvRsHhHaGhbmqBV6cA==", "1e2b955e-a43b-42c3-87d1-ad61146c6943" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba20f920-1a04-4d5b-8a7f-f0b0a328169d",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "400d2743-2e32-4749-9c7a-1208fdccd4e6", new DateTime(2024, 4, 8, 16, 59, 54, 374, DateTimeKind.Local).AddTicks(7667), "AQAAAAEAACcQAAAAEOihl7yFhtI2zhEvFYAqTH8dBk9epC3ydubxwlEVzU8RceMmsf1JycKu+Y3Z8zYPIA==", "a7350806-b06e-4ac8-9d70-a5519a4d2517" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca27630c-7fa9-4d54-b8f1-851252abc519",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1242bf20-8885-4550-b8e9-2dca4a6a0e3c", new DateTime(2024, 4, 8, 16, 59, 54, 376, DateTimeKind.Local).AddTicks(581), "AQAAAAEAACcQAAAAEPBfymmbMmjGugoD4mx5kEMAcI0ilFJrsSlJj1aikZr9QXLFW5xvawjBqOB/uo8EeQ==", "3758163f-4a63-4152-8f51-b169bd7d1626" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 7, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 5, 18, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 28, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 28, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 4, 12, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 5, 23, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2023, 5, 11, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedDate",
                value: new DateTime(2023, 5, 11, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedDate",
                value: new DateTime(2023, 5, 11, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedDate",
                value: new DateTime(2024, 3, 6, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedDate",
                value: new DateTime(2024, 3, 6, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedDate",
                value: new DateTime(2024, 3, 6, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedDate",
                value: new DateTime(2024, 4, 5, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 8,
                column: "PostedDate",
                value: new DateTime(2024, 4, 5, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedDate",
                value: new DateTime(2024, 4, 5, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5922));
        }
    }
}
