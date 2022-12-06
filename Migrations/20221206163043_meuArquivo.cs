using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace houseofCrimes.Migrations
{
    /// <inheritdoc />
    public partial class meuArquivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastros",
                columns: table => new
                {
                    CadastroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CadastroNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CadastroSobrenome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CadastroDtNascimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CadastroEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CadastroTelefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CadastroTipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastros", x => x.CadastroId);
                });

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    FilmeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmeTitulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmeDescricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmeClassificacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmeTipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmeDuracao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.FilmeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastros");

            migrationBuilder.DropTable(
                name: "Filmes");
        }
    }
}
