using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace swsec_intro_backend_dotnet.Migrations
{
    public partial class adminChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "2mns8uu5w3vnut");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "123");
        }
    }
}
