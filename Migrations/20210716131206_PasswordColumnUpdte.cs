using Microsoft.EntityFrameworkCore.Migrations;

namespace WishList.Migrations
{
    public partial class PasswordColumnUpdte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)dcda
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Companies",
                newName: "UserPassword");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserPassword",
                table: "Companies",
                newName: "Password");
        }
    }
}
