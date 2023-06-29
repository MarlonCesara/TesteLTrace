using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCRUDMVCSQL.Migrations
{
    public partial class Criacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    High_Pass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Low_Pass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dados_Sismicos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dados_Sismicos_Padrao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Taxa_Amostragem_Padrao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dados", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dados");
        }
    }
}
