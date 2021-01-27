using Microsoft.EntityFrameworkCore.Migrations;

namespace SitePessoalMasMelhor.Migrations
{
    public partial class FormAcademica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormAcademica");
        }
    }
}
