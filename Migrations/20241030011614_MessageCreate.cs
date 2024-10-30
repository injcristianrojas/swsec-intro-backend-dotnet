using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace swsec_intro_backend_dotnet.Migrations
{
    public partial class MessageCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Text" },
                values: new object[] { 1, "Bienvenidos al foro de Fans de las Aves Chilenas. Soy el Administrador." });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Text" },
                values: new object[] { 2, "Se informa que la API se encuentra deshabilitada hasta nuevo aviso." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
