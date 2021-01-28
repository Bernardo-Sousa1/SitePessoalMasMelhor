using Microsoft.EntityFrameworkCore.Migrations;

namespace SitePessoalMasMelhor.Migrations
{
    public partial class SobreMim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SobreMim",
                columns: table => new
                {
                    SobreMimId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sobre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SobreMim", x => x.SobreMimId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SobreMim");
        }
    }
}
