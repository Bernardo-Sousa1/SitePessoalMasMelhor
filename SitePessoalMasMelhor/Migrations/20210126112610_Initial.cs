using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SitePessoalMasMelhor.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpProfissional",
                columns: table => new
                {
                    ExpProfissionalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresa = table.Column<string>(nullable: true),
                    Funcao = table.Column<string>(nullable: true),
                    Detalhes = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpProfissional", x => x.ExpProfissionalId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpProfissional");
        }
    }
}
