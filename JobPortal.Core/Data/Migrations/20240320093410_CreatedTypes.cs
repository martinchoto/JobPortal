using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class CreatedTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "JobOffers",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Requirements",
                table: "JobOffers",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "JobOffers",
                newName: "Bonus");

            migrationBuilder.AddColumn<DateTime>(
                name: "PostedDate",
                table: "JobOffers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "JobOffers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "JobOffers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "VacationDays",
                table: "JobOffers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_JobOffers_TypeId",
                table: "JobOffers",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOffers_UserId",
                table: "JobOffers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffers_AspNetUsers_UserId",
                table: "JobOffers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffers_Types_TypeId",
                table: "JobOffers",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOffers_AspNetUsers_UserId",
                table: "JobOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_JobOffers_Types_TypeId",
                table: "JobOffers");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropIndex(
                name: "IX_JobOffers_TypeId",
                table: "JobOffers");

            migrationBuilder.DropIndex(
                name: "IX_JobOffers_UserId",
                table: "JobOffers");

            migrationBuilder.DropColumn(
                name: "PostedDate",
                table: "JobOffers");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "JobOffers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "JobOffers");

            migrationBuilder.DropColumn(
                name: "VacationDays",
                table: "JobOffers");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "JobOffers",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "JobOffers",
                newName: "Requirements");

            migrationBuilder.RenameColumn(
                name: "Bonus",
                table: "JobOffers",
                newName: "Location");
        }
    }
}
