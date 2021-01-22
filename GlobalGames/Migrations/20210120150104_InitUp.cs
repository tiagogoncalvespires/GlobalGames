using Microsoft.EntityFrameworkCore.Migrations;

namespace GlobalGames.Migrations
{
    public partial class InitUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Inscricoes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Inscricoes");
        }
    }
}
