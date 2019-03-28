using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNetApp.Migrations
{
    public partial class AllerOnMetAJour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID_User",
                table: "ToDo",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ToDo",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToDo_UserId",
                table: "ToDo",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDo_AspNetUsers_UserId",
                table: "ToDo",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDo_AspNetUsers_UserId",
                table: "ToDo");

            migrationBuilder.DropIndex(
                name: "IX_ToDo_UserId",
                table: "ToDo");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ToDo",
                newName: "ID_User");

            migrationBuilder.AlterColumn<string>(
                name: "ID_User",
                table: "ToDo",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
