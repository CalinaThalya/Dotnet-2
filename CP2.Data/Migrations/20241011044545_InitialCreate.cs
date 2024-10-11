using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CP2.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_fonecedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_vedendor",
                table: "tb_vedendor");

            migrationBuilder.RenameTable(
                name: "tb_vedendor",
                newName: "tb_vendedores");

            migrationBuilder.AddColumn<decimal>(
                name: "ComissaoPercentual",
                table: "tb_vendedores",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "CriadoEm",
                table: "tb_vendedores",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataContratacao",
                table: "tb_vendedores",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "tb_vendedores",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "tb_vendedores",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "tb_vendedores",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "MetaMensal",
                table: "tb_vendedores",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "tb_vendedores",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_vendedores",
                table: "tb_vendedores",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "tb_fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(14)", nullable: false),
                    Endereco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Telefone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_fornecedores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_fornecedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_vendedores",
                table: "tb_vendedores");

            migrationBuilder.DropColumn(
                name: "ComissaoPercentual",
                table: "tb_vendedores");

            migrationBuilder.DropColumn(
                name: "CriadoEm",
                table: "tb_vendedores");

            migrationBuilder.DropColumn(
                name: "DataContratacao",
                table: "tb_vendedores");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "tb_vendedores");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "tb_vendedores");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "tb_vendedores");

            migrationBuilder.DropColumn(
                name: "MetaMensal",
                table: "tb_vendedores");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "tb_vendedores");

            migrationBuilder.RenameTable(
                name: "tb_vendedores",
                newName: "tb_vedendor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_vedendor",
                table: "tb_vedendor",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "tb_fonecedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Endereco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_fonecedor", x => x.Id);
                });
        }
    }
}
