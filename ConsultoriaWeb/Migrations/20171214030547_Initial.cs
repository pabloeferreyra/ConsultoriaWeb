using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ConsultoriaWeb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    celular = table.Column<long>(nullable: false),
                    certPime = table.Column<bool>(nullable: false),
                    ciudad = table.Column<string>(nullable: true),
                    claveFiscal = table.Column<string>(nullable: true),
                    contacto = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true),
                    cuit = table.Column<int>(nullable: false),
                    domicilio = table.Column<string>(nullable: true),
                    idReferente = table.Column<int>(nullable: false),
                    provincia = table.Column<string>(nullable: true),
                    razonSocial = table.Column<string>(nullable: true),
                    registroAfip = table.Column<int>(nullable: false),
                    telefono = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
