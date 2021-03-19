using Microsoft.EntityFrameworkCore.Migrations;

namespace YCReservations.Migrations
{
    public partial class addedrescounter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResCounter",
                table: "ReservationType",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResCounter",
                table: "ReservationType");
        }
    }
}
