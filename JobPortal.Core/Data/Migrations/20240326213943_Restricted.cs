using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class Restricted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOffersApplications_JobOffers_JobOfferId",
                table: "JobOffersApplications");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffersApplications_JobOffers_JobOfferId",
                table: "JobOffersApplications",
                column: "JobOfferId",
                principalTable: "JobOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOffersApplications_JobOffers_JobOfferId",
                table: "JobOffersApplications");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffersApplications_JobOffers_JobOfferId",
                table: "JobOffersApplications",
                column: "JobOfferId",
                principalTable: "JobOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
