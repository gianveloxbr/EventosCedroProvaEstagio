using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Eventos.DAL.Migrations
{
    public partial class AdicionandoTabelaEvento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    IdEvento = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    FaixaEtaria = table.Column<string>(nullable: false),
                    HoraFim = table.Column<TimeSpan>(nullable: false),
                    HoraInicio = table.Column<TimeSpan>(nullable: false),
                    Local = table.Column<string>(maxLength: 100, nullable: false),
                    NomeEvento = table.Column<string>(maxLength: 50, nullable: false),
                    OpenBar = table.Column<bool>(nullable: false),
                    QuantidadeDeAmbientes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.IdEvento);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
