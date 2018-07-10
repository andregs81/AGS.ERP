using Microsoft.EntityFrameworkCore.Migrations;

namespace AGS.ERP.Infra.Data.Migrations
{
    public partial class AlteracaoFornecedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Fornecedor_FornecedorId",
                table: "Endereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor");

            migrationBuilder.RenameTable(
                name: "Fornecedor",
                newName: "Fornecedores");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Fornecedores",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Fornecedores",
                type: "varchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "Fornecedores",
                type: "varchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fornecedores",
                table: "Fornecedores",
                column: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Fornecedores_FornecedorId",
                table: "Endereco",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "FornecedorId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Fornecedores_FornecedorId",
                table: "Endereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fornecedores",
                table: "Fornecedores");

            migrationBuilder.RenameTable(
                name: "Fornecedores",
                newName: "Fornecedor");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Fornecedor",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Fornecedor",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "Fornecedor",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(14)",
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor",
                column: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Fornecedor_FornecedorId",
                table: "Endereco",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "FornecedorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
