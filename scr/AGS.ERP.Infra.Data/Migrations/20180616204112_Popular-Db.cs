using Microsoft.EntityFrameworkCore.Migrations;

namespace AGS.ERP.Infra.Data.Migrations
{
    public partial class PopularDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql =
            "insert into ESTADOS(UF, NOME) VALUES('AC', 'Acre');" + "\n\r" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('AL', 'Alagoas');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('AM', 'Amazonas');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('AP', 'Amapá');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('BA', 'Bahia');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('CE', 'Ceará');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('DF', 'Distrito Federal');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('ES', 'Espírito Santo');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('GO', 'Goiás');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('MA', 'Maranhão');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('MG', 'Minas Gerais');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('MS', 'Mato Grosso do Sul');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('MT', 'Mato Grosso');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('PA', 'Pará');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('PB', 'Paraíba');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('PE', 'Pernambuco');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('PI', 'Piauí');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('PR', 'Paraná');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('RJ', 'Rio de Janeiro');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('RN', 'Rio Grande do Norte');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('RO', 'Rondônia');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('RR', 'Roraima');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('RS', 'Rio Grande do Sul');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('SC', 'Santa Catarina');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('SE', 'Sergipe');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('SP', 'São Paulo');" + "\n\r" +
            "insert into ESTADOS(UF, NOME) VALUES('TO', 'Tocantins');";

            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
