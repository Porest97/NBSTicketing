using Microsoft.EntityFrameworkCore.Migrations;

namespace NBSTicketing.Data.Migrations
{
    public partial class Adde_SiteId2Ticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Ticket",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_SiteId",
                table: "Ticket",
                column: "SiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Site_SiteId",
                table: "Ticket",
                column: "SiteId",
                principalTable: "Site",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Site_SiteId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_SiteId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Ticket");
        }
    }
}
