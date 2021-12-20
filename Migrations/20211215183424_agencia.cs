using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgenciaComBack.Migrations
{
    public partial class agencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_destino_DestinoId",
                table: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "cliente");

            migrationBuilder.RenameIndex(
                name: "IX_Cliente_DestinoId",
                table: "cliente",
                newName: "IX_cliente_DestinoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cliente",
                table: "cliente",
                column: "IdCliente");

            migrationBuilder.CreateTable(
                name: "contato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mensagem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contato", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_destino_DestinoId",
                table: "cliente",
                column: "DestinoId",
                principalTable: "destino",
                principalColumn: "IdDestino",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cliente_destino_DestinoId",
                table: "cliente");

            migrationBuilder.DropTable(
                name: "contato");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cliente",
                table: "cliente");

            migrationBuilder.RenameTable(
                name: "cliente",
                newName: "Cliente");

            migrationBuilder.RenameIndex(
                name: "IX_cliente_DestinoId",
                table: "Cliente",
                newName: "IX_Cliente_DestinoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_destino_DestinoId",
                table: "Cliente",
                column: "DestinoId",
                principalTable: "destino",
                principalColumn: "IdDestino",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
