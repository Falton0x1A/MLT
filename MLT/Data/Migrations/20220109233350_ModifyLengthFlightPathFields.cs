using Microsoft.EntityFrameworkCore.Migrations;

namespace MLT.Data.Migrations
{
    public partial class ModifyLengthFlightPathFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightPath");

            migrationBuilder.CreateTable(
                name: "FlightPath",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightID = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(56)", maxLength: 56, nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(56)", maxLength: 56, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightPath", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightPath");

            migrationBuilder.CreateTable(
                name: "FlightPath",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.Id);
                });
        }
    }
}
