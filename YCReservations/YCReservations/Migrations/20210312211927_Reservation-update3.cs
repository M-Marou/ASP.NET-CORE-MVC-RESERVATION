using Microsoft.EntityFrameworkCore.Migrations;

namespace YCReservations.Migrations
{
    public partial class Reservationupdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ReservationType_ReservationTypeTypeId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReservationTypeTypeId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationTypeTypeId",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "ReservationTypeId",
                table: "Reservations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationTypeId",
                table: "Reservations",
                column: "ReservationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ReservationType_ReservationTypeId",
                table: "Reservations",
                column: "ReservationTypeId",
                principalTable: "ReservationType",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ReservationType_ReservationTypeId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReservationTypeId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationTypeId",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "ReservationTypeTypeId",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationTypeTypeId",
                table: "Reservations",
                column: "ReservationTypeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ReservationType_ReservationTypeTypeId",
                table: "Reservations",
                column: "ReservationTypeTypeId",
                principalTable: "ReservationType",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
