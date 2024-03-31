using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalaxyApp.Ef.Migrations
{
    public partial class SetProductNameUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Puroducts_Name",
                table: "Puroducts");

            migrationBuilder.CreateIndex(
                name: "IX_Puroducts_Name",
                table: "Puroducts",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Puroducts_Name",
                table: "Puroducts");

            migrationBuilder.CreateIndex(
                name: "IX_Puroducts_Name",
                table: "Puroducts",
                column: "Name");
        }
    }
}
