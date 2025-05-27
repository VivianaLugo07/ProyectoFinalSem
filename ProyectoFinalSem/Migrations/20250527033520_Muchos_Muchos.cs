using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinalSem.Migrations
{
    /// <inheritdoc />
    public partial class Muchos_Muchos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Editoriales",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoriales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutorEditorial",
                columns: table => new
                {
                    AutoresId = table.Column<int>(type: "int", nullable: false),
                    EditorialesId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorEditorial", x => new { x.AutoresId, x.EditorialesId });
                    table.ForeignKey(
                        name: "FK_AutorEditorial_Autores_AutoresId",
                        column: x => x.AutoresId,
                        principalTable: "Autores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorEditorial_Editoriales_EditorialesId",
                        column: x => x.EditorialesId,
                        principalTable: "Editoriales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutorEditorial_EditorialesId",
                table: "AutorEditorial",
                column: "EditorialesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorEditorial");

            migrationBuilder.DropTable(
                name: "Editoriales");
        }
    }
}
