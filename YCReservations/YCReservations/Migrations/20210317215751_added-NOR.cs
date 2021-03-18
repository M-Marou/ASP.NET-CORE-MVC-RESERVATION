using Microsoft.EntityFrameworkCore.Migrations;

namespace YCReservations.Migrations
{
    public partial class addedNOR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "NOR",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NOR",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Reservations",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
