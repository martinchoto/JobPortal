using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class fixedbugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Position", "PostedDate" },
                values: new object[] { "Cashier", new DateTime(2024, 3, 6, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Position", "PostedDate" },
                values: new object[] { "Cleaner for tiles", new DateTime(2024, 3, 6, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Position", "PostedDate" },
                values: new object[] { "Cleaner for toilets", new DateTime(2024, 3, 6, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5916) });

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
                columns: new[] { "Position", "PostedDate" },
                values: new object[] { "Web Eng", new DateTime(2024, 4, 5, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedDate",
                value: new DateTime(2024, 4, 5, 16, 59, 54, 378, DateTimeKind.Local).AddTicks(5922));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "018bff8a-5df3-40d8-8a65-e6a5e932f957",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c88199f7-724f-414b-b4ba-4b06f4c30253", new DateTime(2024, 4, 8, 16, 43, 30, 876, DateTimeKind.Local).AddTicks(4176), "AQAAAAEAACcQAAAAEI0CJ7HCTKj9B/GvBDkUXXw1v4BzX3HM19DJk9k+e++5f4gh00FBWKc+CTLiHAlBCw==", "459bc415-85c1-47c8-ab3b-dca3a3e8089f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11d42cfa-0eb5-4556-bbee-452d66efacf8",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "645a15c4-a361-46ff-9b86-f4937bd38364", new DateTime(2024, 4, 8, 16, 43, 30, 872, DateTimeKind.Local).AddTicks(4460), "AQAAAAEAACcQAAAAEAZCPaaYzUqvyvO2zPsT6dfb1huPVxSOmyLIznaMHnA6jw8uspPYZWC0cD8rPgwzFw==", "a79fb23e-1d4b-4796-abac-0d73238c3e29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba20f920-1a04-4d5b-8a7f-f0b0a328169d",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fa4ed2c-ea7e-4fa5-9f66-7f71078aa440", new DateTime(2024, 4, 8, 16, 43, 30, 873, DateTimeKind.Local).AddTicks(8027), "AQAAAAEAACcQAAAAENxzhGNLzsRA5r554m/i/Ld1c8OibPqoEOi4oI7Ebdw9qjIAGs6NEl5MdDKd9Y+mGQ==", "62a4061b-f210-4f4f-90c0-4c4149dbf6c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca27630c-7fa9-4d54-b8f1-851252abc519",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed5af41b-047d-4db8-8aa3-833d39aac53a", new DateTime(2024, 4, 8, 16, 43, 30, 875, DateTimeKind.Local).AddTicks(1082), "AQAAAAEAACcQAAAAECYpIhFzQCIg33FLs2UFX2pZV3CdkkEtB2iEpSkbuzK34GCYnJ+vs55teyS1qzKBBg==", "c7f8451a-fba4-4e09-b04f-db006152d847" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 7, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 5, 18, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 28, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 28, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 4, 12, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 5, 23, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2023, 5, 11, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedDate",
                value: new DateTime(2023, 5, 11, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedDate",
                value: new DateTime(2023, 5, 11, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Position", "PostedDate" },
                values: new object[] { "Cleaner", new DateTime(2024, 3, 6, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Position", "PostedDate" },
                values: new object[] { "Cleaner", new DateTime(2024, 3, 6, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Position", "PostedDate" },
                values: new object[] { "Cleaner", new DateTime(2024, 3, 6, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedDate",
                value: new DateTime(2024, 4, 5, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Position", "PostedDate" },
                values: new object[] { "Web Dev", new DateTime(2024, 4, 5, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedDate",
                value: new DateTime(2024, 4, 5, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7223));
        }
    }
}
