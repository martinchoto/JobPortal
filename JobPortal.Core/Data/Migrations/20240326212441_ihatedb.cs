using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Portal.Data.Migrations
{
    public partial class ihatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOffersApplications_Applications_ApplicationId",
                table: "JobOffersApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobOffersApplications_JobOffers_JobOfferId",
                table: "JobOffersApplications");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffersApplications_Applications_ApplicationId",
                table: "JobOffersApplications",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffersApplications_JobOffers_JobOfferId",
                table: "JobOffersApplications",
                column: "JobOfferId",
                principalTable: "JobOffers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOffersApplications_Applications_ApplicationId",
                table: "JobOffersApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobOffersApplications_JobOffers_JobOfferId",
                table: "JobOffersApplications");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffersApplications_Applications_ApplicationId",
                table: "JobOffersApplications",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffersApplications_JobOffers_JobOfferId",
                table: "JobOffersApplications",
                column: "JobOfferId",
                principalTable: "JobOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
