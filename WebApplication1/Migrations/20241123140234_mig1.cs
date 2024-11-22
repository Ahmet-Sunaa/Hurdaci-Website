using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ScrapImgs_ScrapId",
                table: "ScrapImgs",
                column: "ScrapId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScrapImgs_Scraps_ScrapId",
                table: "ScrapImgs",
                column: "ScrapId",
                principalTable: "Scraps",
                principalColumn: "ScrapId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScrapImgs_Scraps_ScrapId",
                table: "ScrapImgs");

            migrationBuilder.DropIndex(
                name: "IX_ScrapImgs_ScrapId",
                table: "ScrapImgs");
        }
    }
}
