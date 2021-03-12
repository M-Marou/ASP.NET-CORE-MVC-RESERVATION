using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YCReservations.Migrations
{
    public partial class ReservationType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationDate",
                table: "Reservations");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Reservations",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservationTypeTypeId",
                table: "Reservations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Reservations",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ReservationType",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ResType = table.Column<string>(nullable: true),
                    NumberOfPeople = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationType", x => x.TypeId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ReservationType_ReservationTypeTypeId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "ReservationType");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReservationTypeTypeId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationTypeTypeId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reservations");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Reservations",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "ReservationDate",
                table: "Reservations",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
