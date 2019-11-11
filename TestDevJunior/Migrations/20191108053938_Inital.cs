using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestDevJunior.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    razao_social = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    cnpj = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    data_fundacao = table.Column<DateTime>(nullable: false),
                    capital = table.Column<decimal>(nullable: false),
                    quarentena = table.Column<bool>(nullable: false),
                    status_cliente = table.Column<bool>(nullable: false),
                    classificacao = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
