using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class FixedMistake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CompanyId", "PostedDate" },
                values: new object[] { 1, new DateTime(2023, 5, 11, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedDate",
                value: new DateTime(2024, 3, 6, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedDate",
                value: new DateTime(2024, 3, 6, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedDate",
                value: new DateTime(2024, 3, 6, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7217));

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
                column: "PostedDate",
                value: new DateTime(2024, 4, 5, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedDate",
                value: new DateTime(2024, 4, 5, 16, 43, 30, 877, DateTimeKind.Local).AddTicks(7223));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "018bff8a-5df3-40d8-8a65-e6a5e932f957",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f02bae3-0afb-46fd-9487-cfd10236816d", new DateTime(2024, 4, 8, 16, 41, 42, 992, DateTimeKind.Local).AddTicks(4200), "AQAAAAEAACcQAAAAEPofJMvlFS5bT6X1sYvms4+IogxuYHChlTfSF77wifOgO0K+qGp07lXBWbfI37F5/g==", "6fdbc56c-d00f-4d0c-8745-ae430122462e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11d42cfa-0eb5-4556-bbee-452d66efacf8",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71339e33-782e-4bb0-8a83-11e56d9e486b", new DateTime(2024, 4, 8, 16, 41, 42, 988, DateTimeKind.Local).AddTicks(6430), "AQAAAAEAACcQAAAAEGqsATNpL83XCc2VetOqdjexGcsSlWO2WUl5JcpMhFiWlZ1lfIYiHQP4xZwOauuA0g==", "a7886813-4b29-455d-9a4b-eda28988194a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba20f920-1a04-4d5b-8a7f-f0b0a328169d",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbce5d30-89f6-4c2e-9c68-f82a23dd0671", new DateTime(2024, 4, 8, 16, 41, 42, 989, DateTimeKind.Local).AddTicks(9170), "AQAAAAEAACcQAAAAEOvi7e904qEaVWPw1RM8DfwHWjt4gpsabb/Kvw+VsZcBZZTQG2CQoyuBvGPyX62vTA==", "74764aad-7bb9-4cba-bccd-eb349bf3927a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca27630c-7fa9-4d54-b8f1-851252abc519",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0dce8cf-1eb2-4d5c-a18d-f2b1e4839035", new DateTime(2024, 4, 8, 16, 41, 42, 991, DateTimeKind.Local).AddTicks(1671), "AQAAAAEAACcQAAAAEBKgFO8oHXtoVr86rsFfxrDjSj5JwrZzIDBHrQUXeldZ2GxuGZl6MpZ2djjOBttJWA==", "1c44c04c-f5d2-4d22-a46e-a343df00c5da" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 7, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 5, 18, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 28, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 4, 28, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 4, 12, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 5, 23, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2023, 5, 11, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedDate",
                value: new DateTime(2023, 5, 11, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompanyId", "PostedDate" },
                values: new object[] { 2, new DateTime(2023, 5, 11, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedDate",
                value: new DateTime(2024, 3, 6, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedDate",
                value: new DateTime(2024, 3, 6, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedDate",
                value: new DateTime(2024, 3, 6, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedDate",
                value: new DateTime(2024, 4, 5, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 8,
                column: "PostedDate",
                value: new DateTime(2024, 4, 5, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedDate",
                value: new DateTime(2024, 4, 5, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6893));
        }
    }
}
