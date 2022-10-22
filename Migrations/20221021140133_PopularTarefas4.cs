using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_API.Migrations
{
    public partial class PopularTarefas4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Tarefas(Name, Description)" +
                "VALUES ('Lavar Louça', 'Devo lavar a louça antes das 14h')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Tarefas");
        }
    }
}
