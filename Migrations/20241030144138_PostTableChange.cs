using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace swsec_intro_backend_dotnet.Migrations
{
    public partial class PostTableChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Messages",
                newName: "Message");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Message",
                table: "Messages",
                newName: "Text");
        }
    }
}
