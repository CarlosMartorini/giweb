using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GIWEB.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "Owners",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertieId",
                table: "Owners",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateIni = table.Column<DateTime>(nullable: false),
                    DateTer = table.Column<DateTime>(nullable: false),
                    PercCommission = table.Column<double>(nullable: false),
                    Commission = table.Column<double>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guarantor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    Cel = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Profession = table.Column<string>(nullable: true),
                    Employer = table.Column<string>(nullable: true),
                    TelEmployer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarantor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plots",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DatePlots = table.Column<DateTime>(nullable: false),
                    PlotsValue = table.Column<double>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Propertie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    N = table.Column<string>(nullable: true),
                    Neighborhood = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true),
                    RentValue = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propertie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spouse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    Cel = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Profession = table.Column<string>(nullable: true),
                    Employer = table.Column<string>(nullable: true),
                    TelEmployer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tenant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    Cel = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Profession = table.Column<string>(nullable: true),
                    Employer = table.Column<string>(nullable: true),
                    TelEmployer = table.Column<string>(nullable: true),
                    ContractId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tenant_Contract_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Owners_ContractId",
                table: "Owners",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_PropertieId",
                table: "Owners",
                column: "PropertieId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenant_ContractId",
                table: "Tenant",
                column: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Contract_ContractId",
                table: "Owners",
                column: "ContractId",
                principalTable: "Contract",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Propertie_PropertieId",
                table: "Owners",
                column: "PropertieId",
                principalTable: "Propertie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Contract_ContractId",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Propertie_PropertieId",
                table: "Owners");

            migrationBuilder.DropTable(
                name: "Guarantor");

            migrationBuilder.DropTable(
                name: "Plots");

            migrationBuilder.DropTable(
                name: "Propertie");

            migrationBuilder.DropTable(
                name: "Spouse");

            migrationBuilder.DropTable(
                name: "Tenant");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropIndex(
                name: "IX_Owners_ContractId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Owners_PropertieId",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "PropertieId",
                table: "Owners");
        }
    }
}
