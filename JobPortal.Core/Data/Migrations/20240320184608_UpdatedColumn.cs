using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class UpdatedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOffers_AspNetUsers_UserId",
                table: "JobOffers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "JobOffers",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_JobOffers_UserId",
                table: "JobOffers",
                newName: "IX_JobOffers_CompanyId");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "JobOffers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "JobOffers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Bonus",
                table: "JobOffers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffers_AspNetUsers_CompanyId",
                table: "JobOffers",
                column: "CompanyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOffers_AspNetUsers_CompanyId",
                table: "JobOffers");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "JobOffers",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobOffers_CompanyId",
                table: "JobOffers",
                newName: "IX_JobOffers_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "JobOffers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "JobOffers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Bonus",
                table: "JobOffers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffers_AspNetUsers_UserId",
                table: "JobOffers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
