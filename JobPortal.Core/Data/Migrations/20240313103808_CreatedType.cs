using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class CreatedType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_TypeId",
                table: "Companies",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Type_TypeId",
                table: "Companies",
                column: "TypeId",
                principalTable: "Type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Type_TypeId",
                table: "Companies");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropIndex(
                name: "IX_Companies_TypeId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Companies");
        }
    }
}
