using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebMisRecetas.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recetas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Categoria = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Ingredientes = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Instrucciones = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Apellido = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Edad = table.Column<int>(nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recetas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recetas");
        }
    }
}
