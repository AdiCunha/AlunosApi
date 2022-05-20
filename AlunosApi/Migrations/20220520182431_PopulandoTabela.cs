using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlunosApi.Migrations
{
    public partial class PopulandoTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Crud_Alunos",
                columns: new[] { "AlunoId", "Email", "Idade", "Nome" },
                values: new object[] { 1, "adi.kauan02@gmail.com", 24, "Adí Kauan da Cunha dos Santos" });

            migrationBuilder.InsertData(
                table: "Crud_Alunos",
                columns: new[] { "AlunoId", "Email", "Idade", "Nome" },
                values: new object[] { 2, "pispispaulinha@gmail.com", 22, "Paula Silva Pereira" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crud_Alunos",
                keyColumn: "AlunoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Crud_Alunos",
                keyColumn: "AlunoId",
                keyValue: 2);
        }
    }
}
