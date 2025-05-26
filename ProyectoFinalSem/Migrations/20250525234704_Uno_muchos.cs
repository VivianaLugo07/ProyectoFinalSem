using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinalSem.Migrations
{
    /// <inheritdoc />
    public partial class Uno_muchos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Libro",
                table: "Autores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClasificacionId",
                table: "Autores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Clasificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clasificaciones", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autores_ClasificacionId",
                table: "Autores",
                column: "ClasificacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Autores_Clasificaciones_ClasificacionId",
                table: "Autores",
                column: "ClasificacionId",
                principalTable: "Clasificaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autores_Clasificaciones_ClasificacionId",
                table: "Autores");

            migrationBuilder.DropTable(
                name: "Clasificaciones");

            migrationBuilder.DropIndex(
                name: "IX_Autores_ClasificacionId",
                table: "Autores");

            migrationBuilder.DropColumn(
                name: "ClasificacionId",
                table: "Autores");

            migrationBuilder.AlterColumn<string>(
                name: "Libro",
                table: "Autores",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
