using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class SeededTheDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "CreatedOn", "Description", "Email", "FullName", "Name", "Reason", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 8, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6856), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.", "martoplays@abv.bg", "Martin Stalev", "Application for Cashier", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus auctor.", "018bff8a-5df3-40d8-8a65-e6a5e932f957" },
                    { 2, new DateTime(2024, 4, 8, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6859), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.", "martoplays@abv.bg", "Martin Stalev", "Application for Web Dev", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus auctor.", "018bff8a-5df3-40d8-8a65-e6a5e932f957" }
                });

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

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CompanyId", "Date", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 7, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6831), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "https://espnpressroom.com/us/files/2023/06/Hot-Dog-Eating-Contest.png", "Eating Contest" },
                    { 2, 1, new DateTime(2024, 5, 18, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6834), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "https://img.olympics.com/images/image/private/t_s_pog_staticContent_hero_sm/f_auto/primary/qpudtgofz5sw2ffcpz4j", "Shooting" },
                    { 3, 2, new DateTime(2024, 4, 28, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6836), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "https://t4.ftcdn.net/jpg/02/50/25/97/360_F_250259727_nY20L3aqydok59WVUbouUjw4wnAgJOix.jpg", "Day of the open doors" },
                    { 4, 2, new DateTime(2024, 4, 28, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6838), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "https://post.healthline.com/wp-content/uploads/2021/09/reading-book-1296x728-header.jpg", "Reading" },
                    { 5, 3, new DateTime(2024, 4, 12, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6839), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "https://t4.ftcdn.net/jpg/02/50/25/97/360_F_250259727_nY20L3aqydok59WVUbouUjw4wnAgJOix.jpg", "Day of the open doors" },
                    { 6, 3, new DateTime(2024, 5, 23, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6841), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "https://www.classcentral.com/report/wp-content/uploads/2022/03/Frame-3.png", "Programming course" }
                });

            migrationBuilder.InsertData(
                table: "JobOffers",
                columns: new[] { "Id", "Bonus", "CompanyId", "Description", "Position", "PostedDate", "Salary", "Status", "TypeId", "VacationDays" },
                values: new object[,]
                {
                    { 1, "Whole a lot of benefits working for a big company", 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Warehouse worker", new DateTime(2023, 5, 11, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6876), 1000m, "fulltime 8hrs/day", 1, 22 },
                    { 2, "Whole a lot of benefits working for a big company", 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Cashier", new DateTime(2023, 5, 11, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6880), 1200m, "fulltime 8hrs/day", 6, 22 },
                    { 3, "Whole a lot of benefits working for a big company", 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Cleaner", new DateTime(2023, 5, 11, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6882), 1400m, "fulltime 8hrs/day", 6, 22 },
                    { 4, "Whole a lot of benefits working for a big company", 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Cleaner", new DateTime(2024, 3, 6, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6884), 1400m, "fulltime 8hrs/day", 6, 22 },
                    { 5, "Whole a lot of benefits working for a big company", 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Cleaner", new DateTime(2024, 3, 6, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6885), 1400m, "fulltime 8hrs/day", 6, 22 },
                    { 6, "Whole a lot of benefits working for a big company", 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Cleaner", new DateTime(2024, 3, 6, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6887), 1400m, "fulltime 8hrs/day", 6, 22 },
                    { 7, "Whole a lot of benefits working for a big company", 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Web Designer", new DateTime(2024, 4, 5, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6890), 2200m, "fulltime 8hrs/day", 1, 32 },
                    { 8, "Whole a lot of benefits working for a big company", 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Web Dev", new DateTime(2024, 4, 5, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6891), 1400m, "fulltime 8hrs/day", 1, 32 },
                    { 9, "Whole a lot of benefits working for a big company", 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Web Dev", new DateTime(2024, 4, 5, 16, 41, 42, 993, DateTimeKind.Local).AddTicks(6893), 1400m, "fulltime 4hrs/day intern", 1, 30 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 9);

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
        }
    }
}
