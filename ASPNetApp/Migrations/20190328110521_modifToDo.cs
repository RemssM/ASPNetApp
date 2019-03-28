using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNetApp.Migrations
{
    public partial class modifToDo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ID_User",
                table: "ToDo",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ID_User",
                table: "ToDo",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
