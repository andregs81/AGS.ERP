using Microsoft.EntityFrameworkCore.Migrations;

namespace AGS.ERP.Infra.Data.Migrations
{
    public partial class PopularDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"INSERT INTO ESTADOS(Nome, UF) values('SÃO PAULO', 'SP');
                       INSERT INTO ESTADOS(Nome, UF) values('RIO DE JANEIRO', 'RJ');
                       INSERT INTO ESTADOS(Nome, UF) values('SANTA CATARINA', 'Sc');
                       INSERT INTO ESTADOS(Nome, UF) values('PORTO ALEGRE', 'RS');";

            migrationBuilder.Sql(sql);

            sql = @"INSERT INTO Cidades(Nome, UF) values('SÃO JOSÉ DO RIO PRETO', 'SP');
                    INSERT INTO Cidades(Nome, UF) values('SÃO FRANCISCO DO SUL',  'SC');
                    INSERT INTO Cidades(Nome, UF) values('GRAVATAÍ', 'RS');
                    INSERT INTO Cidades(Nome, UF) values('PETROPOLIS', 'RJ');";

            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
