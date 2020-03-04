using Microsoft.EntityFrameworkCore.Migrations;

namespace motoGP.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Race_Country_CountryID",
                table: "Race");

            migrationBuilder.DropIndex(
                name: "IX_Race_CountryID",
                table: "Race");

            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "Race");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryID",
                table: "Race",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Race_CountryID",
                table: "Race",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Race_Country_CountryID",
                table: "Race",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
