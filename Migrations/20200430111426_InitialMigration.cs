using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlleFotballKamper",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lag1id = table.Column<int>(nullable: false),
                    Lag2id = table.Column<int>(nullable: false),
                    VinnerLagId = table.Column<int>(nullable: false),
                    KampLand = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlleFotballKamper", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlleFotballLag",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Land = table.Column<string>(maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlleFotballLag", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlleFotballKamper");

            migrationBuilder.DropTable(
                name: "AlleFotballLag");
        }
    }
}
