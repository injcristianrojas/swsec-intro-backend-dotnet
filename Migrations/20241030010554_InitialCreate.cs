using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace swsec_intro_backend_dotnet.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Type", "Username" },
                values: new object[] { 1, "fio", 2, "zorzal" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Type", "Username" },
                values: new object[] { 2, "123", 1, "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Type", "Username" },
                values: new object[] { 3, "fiofio", 2, "chincol" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Type", "Username" },
                values: new object[] { 4, "pah", 2, "tiuque" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Type", "Username" },
                values: new object[] { 5, "roji", 2, "loica" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
