using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortal.Core.Migrations
{
    public partial class SeedTheNewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobOffers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VacationDays = table.Column<int>(type: "int", nullable: false),
                    Bonus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobOffers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobOffers_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventsParticipants",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false),
                    ParticipantId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsParticipants", x => new { x.EventId, x.ParticipantId });
                    table.ForeignKey(
                        name: "FK_EventsParticipants_AspNetUsers_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventsParticipants_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobOffersApplications",
                columns: table => new
                {
                    JobOfferId = table.Column<int>(type: "int", nullable: false),
                    ApplicationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobOffersApplications", x => new { x.JobOfferId, x.ApplicationId });
                    table.ForeignKey(
                        name: "FK_JobOffersApplications_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobOffersApplications_JobOffers_JobOfferId",
                        column: x => x.JobOfferId,
                        principalTable: "JobOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7b282415-4ca5-4752-b0fb-04b62bf6c13c", "aafad84e-85ed-4559-92ef-e516353422ab", "Applicant", "APPLICANT" },
                    { "9c91b32e-802c-4a53-bdcd-05876a361ac8", "76b4de66-7d22-4df6-b4d1-c1c288ad1123", "Company", "COMPANY" },
                    { "f770a115-fc1f-4951-bd22-e4a9421e6160", "ef66342d-7521-4dfd-a4f9-e9366747908c", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "018bff8a-5df3-40d8-8a65-e6a5e932f957", 0, "61169627-f76d-402c-bc2e-6991c2d18c42", new DateTime(2024, 4, 11, 17, 54, 42, 819, DateTimeKind.Local).AddTicks(7144), "martoplays@abv.bg", false, "Martinkata", "Voivodov", false, null, "MARTOPLAYS@ABV.BG", "MARTINCHOTO", "AQAAAAEAACcQAAAAEE/naP9z2mB5W/JTIvyRHyuuzYOBtrjKPGqCnYX6TQMMQBg82l5KyqXnVCTECqhDhQ==", null, false, "c022e2b1-6323-4a7b-8af5-fdd04b32dace", false, "martinchoto" },
                    { "11d42cfa-0eb5-4556-bbee-452d66efacf8", 0, "a84be25b-c222-45e7-8487-e85d569e3b1e", new DateTime(2024, 4, 11, 17, 54, 42, 816, DateTimeKind.Local).AddTicks(1791), "martoadmin@abv.bg", false, "Martin", "Stalev", false, null, "martoadmin@abv.bg", "admin", "AQAAAAEAACcQAAAAEGQv3S1HLzo4x+FnGxcboqEd0K8a7uHV5NOP4btdR+khGOEt2pKcaUcgQq5Xj4kXRA==", null, false, "d30eef3c-1674-4f78-adbd-25fc626fe7d7", false, "admin" },
                    { "ba20f920-1a04-4d5b-8a7f-f0b0a328169d", 0, "8b813935-3a03-43cb-9574-5d18d74d6340", new DateTime(2024, 4, 11, 17, 54, 42, 817, DateTimeKind.Local).AddTicks(3834), "lidlbg@abv.bg", false, null, null, false, null, "LIDLBG@ABV.BG", "LIDLBG", "AQAAAAEAACcQAAAAEPpVKU1TQJ0jKWrXaN8fhi+sWGe6GDWTXbSiP/AyImYSLlNPQ8efxq6Ypk+kSfkyiw==", null, false, "6f5adff8-d8ab-452f-a9c1-8b9824082d6b", false, "lidlbg" },
                    { "ca27630c-7fa9-4d54-b8f1-851252abc519", 0, "512231e1-19a0-41a7-b3f6-bdba1dc852fc", new DateTime(2024, 4, 11, 17, 54, 42, 818, DateTimeKind.Local).AddTicks(5509), "boschbg@abv.bg", false, null, null, false, null, "BOSCHBG@ABV.BG", "BOSCHBG", "AQAAAAEAACcQAAAAEGCZkbXARe7d1pkTWbBtRee/G1xhDDtAabBBrenFxP0m/20ualo/QW8zHewicVIO4A==", null, false, "ab6ba448-a04e-42ea-a063-17a300228792", false, "boschbg" },
                    { "d79e6d15-bed9-45f6-8d00-6a506474f385", 0, "93571c64-c6da-4d79-aafb-8b67defc1069", new DateTime(2024, 4, 11, 17, 54, 42, 820, DateTimeKind.Local).AddTicks(8774), "billabg@abv.bg", false, null, null, false, null, "BILLABG@ABV.BG", "BILLABG", "AQAAAAEAACcQAAAAEAIgbxficXgg1D4CMOZNzFPiz8ZaMXMBGf3Z3zgJFhyhxr4jJpBZkNVFesSzqKcUfA==", null, false, "e17346f1-77e2-4ceb-9b59-2ac993bef8fb", false, "billabg" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Technical" },
                    { 2, "Business" },
                    { 3, "Healthcare" },
                    { 4, "Creative" },
                    { 5, "Education" },
                    { 6, "Customer Service" }
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "CreatedOn", "Description", "Email", "FullName", "Name", "Reason", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 11, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(478), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.", "martoplays@abv.bg", "Martin Stalev", "Application for Cashier", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus auctor.", "018bff8a-5df3-40d8-8a65-e6a5e932f957" },
                    { 2, new DateTime(2024, 4, 11, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(482), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.", "martoplays@abv.bg", "Martin Stalev", "Application for Web Dev", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus auctor.", "018bff8a-5df3-40d8-8a65-e6a5e932f957" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7b282415-4ca5-4752-b0fb-04b62bf6c13c", "018bff8a-5df3-40d8-8a65-e6a5e932f957" },
                    { "f770a115-fc1f-4951-bd22-e4a9421e6160", "11d42cfa-0eb5-4556-bbee-452d66efacf8" },
                    { "9c91b32e-802c-4a53-bdcd-05876a361ac8", "ba20f920-1a04-4d5b-8a7f-f0b0a328169d" },
                    { "9c91b32e-802c-4a53-bdcd-05876a361ac8", "ca27630c-7fa9-4d54-b8f1-851252abc519" },
                    { "9c91b32e-802c-4a53-bdcd-05876a361ac8", "d79e6d15-bed9-45f6-8d00-6a506474f385" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CompanyName", "Location", "LogoUrl", "UserId" },
                values: new object[,]
                {
                    { 1, "ul. Aleksander Stamboliiski", "Billa", "Pazardjik", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d8/Billa-Logo.svg/2560px-Billa-Logo.svg.png", "d79e6d15-bed9-45f6-8d00-6a506474f385" },
                    { 2, "ul. Iordan Iosifov", "Lidl", "Sofia", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/91/Lidl-Logo.svg/150px-Lidl-Logo.svg.png", "ba20f920-1a04-4d5b-8a7f-f0b0a328169d" },
                    { 3, "bul. Tsarigradsko Shose", "Bosch", "Sofia", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/16/Bosch-logo.svg/1920px-Bosch-logo.svg.png", "ca27630c-7fa9-4d54-b8f1-851252abc519" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CompanyId", "Date", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 10, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(440), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "https://espnpressroom.com/us/files/2023/06/Hot-Dog-Eating-Contest.png", "Eating Contest" },
                    { 2, 1, new DateTime(2024, 5, 21, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(442), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "https://img.olympics.com/images/image/private/t_s_pog_staticContent_hero_sm/f_auto/primary/qpudtgofz5sw2ffcpz4j", "Shooting" },
                    { 3, 2, new DateTime(2024, 5, 1, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(444), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "https://t4.ftcdn.net/jpg/02/50/25/97/360_F_250259727_nY20L3aqydok59WVUbouUjw4wnAgJOix.jpg", "Day of the open doors" },
                    { 4, 2, new DateTime(2024, 5, 1, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(446), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "https://post.healthline.com/wp-content/uploads/2021/09/reading-book-1296x728-header.jpg", "Reading" },
                    { 5, 3, new DateTime(2024, 4, 15, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(447), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "https://t4.ftcdn.net/jpg/02/50/25/97/360_F_250259727_nY20L3aqydok59WVUbouUjw4wnAgJOix.jpg", "Day of the open doors" },
                    { 6, 3, new DateTime(2024, 5, 26, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(449), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "https://www.classcentral.com/report/wp-content/uploads/2022/03/Frame-3.png", "Programming course" }
                });

            migrationBuilder.InsertData(
                table: "JobOffers",
                columns: new[] { "Id", "Bonus", "CompanyId", "Description", "Position", "PostedDate", "Salary", "Status", "TypeId", "VacationDays" },
                values: new object[,]
                {
                    { 1, "Whole a lot of benefits working for a big company", 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Warehouse worker", new DateTime(2023, 5, 14, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(505), 1000m, "fulltime 8hrs/day", 1, 22 },
                    { 2, "Whole a lot of benefits working for a big company", 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Cashier", new DateTime(2023, 5, 14, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(509), 1200m, "fulltime 8hrs/day", 6, 22 },
                    { 3, "Whole a lot of benefits working for a big company", 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Cleaner", new DateTime(2023, 5, 14, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(511), 1400m, "fulltime 8hrs/day", 6, 22 },
                    { 4, "Whole a lot of benefits working for a big company", 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Cashier", new DateTime(2024, 3, 9, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(513), 1400m, "fulltime 8hrs/day", 6, 22 },
                    { 5, "Whole a lot of benefits working for a big company", 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Cleaner for tiles", new DateTime(2024, 3, 9, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(514), 1400m, "fulltime 8hrs/day", 6, 22 },
                    { 6, "Whole a lot of benefits working for a big company", 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Cleaner for toilets", new DateTime(2024, 3, 9, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(516), 1400m, "fulltime 8hrs/day", 6, 22 },
                    { 7, "Whole a lot of benefits working for a big company", 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Web Designer", new DateTime(2024, 4, 8, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(518), 2200m, "fulltime 8hrs/day", 1, 32 },
                    { 8, "Whole a lot of benefits working for a big company", 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Web Eng", new DateTime(2024, 4, 8, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(558), 1400m, "fulltime 8hrs/day", 1, 32 },
                    { 9, "Whole a lot of benefits working for a big company", 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper neque vel ligula dictum, vitae convallis justo gravida. Nulla facilisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris consequat nisi et neque dapibus, sed vestibulum sapien fermentum. Fusce id justo euismod, posuere eros ac, suscipit felis. Sed consectetur enim id purus finibus.\r\n\r\n\r\n\r\n\r\n", "Web Dev", new DateTime(2024, 4, 8, 17, 54, 42, 834, DateTimeKind.Local).AddTicks(561), 1400m, "fulltime 4hrs/day intern", 1, 30 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_UserId",
                table: "Applications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_UserId",
                table: "Companies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CompanyId",
                table: "Events",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_EventsParticipants_ParticipantId",
                table: "EventsParticipants",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOffers_CompanyId",
                table: "JobOffers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOffers_TypeId",
                table: "JobOffers",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOffersApplications_ApplicationId",
                table: "JobOffersApplications",
                column: "ApplicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EventsParticipants");

            migrationBuilder.DropTable(
                name: "JobOffersApplications");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "JobOffers");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
