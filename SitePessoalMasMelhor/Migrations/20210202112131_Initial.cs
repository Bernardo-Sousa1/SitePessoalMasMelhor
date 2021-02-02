using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SitePessoalMasMelhor.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacto",
                columns: table => new
                {
                    ContactoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Mensagem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacto", x => x.ContactoId);
                });

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

            migrationBuilder.CreateTable(
                name: "FormAcademica",
                columns: table => new
                {
                    FormAcademicaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Instituição = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Duração = table.Column<string>(nullable: true),
                    DataDeConclusão = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormAcademica", x => x.FormAcademicaId);
                });

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
                name: "Contacto");

            migrationBuilder.DropTable(
                name: "ExpProfissional");

            migrationBuilder.DropTable(
                name: "FormAcademica");

            migrationBuilder.DropTable(
                name: "SobreMim");
        }
    }
}
