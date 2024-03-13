using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class FixedId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicants_AspNetUsers_UserId1",
                table: "Applicants");

            migrationBuilder.DropIndex(
                name: "IX_Applicants_UserId1",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Applicants");

            migrationBuilder.AddForeignKey(
                name: "FK_Applicants_AspNetUsers_UserId",
                table: "Applicants",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicants_AspNetUsers_UserId",
                table: "Applicants");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Applicants",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_UserId1",
                table: "Applicants",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Applicants_AspNetUsers_UserId1",
                table: "Applicants",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
