using Microsoft.EntityFrameworkCore.Migrations;

namespace TranslateBot.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phrases",
                columns: table => new
                {
                    PhraseId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    src = table.Column<string>(nullable: true),
                    dst = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phrases", x => x.PhraseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phrases");
        }
    }
}
