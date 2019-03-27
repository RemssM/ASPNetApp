using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNetApp.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Deadline",
                table: "ToDo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deadline",
                table: "ToDo");
        }
    }
}
