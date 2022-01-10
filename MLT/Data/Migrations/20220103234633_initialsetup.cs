using Microsoft.EntityFrameworkCore.Migrations;

namespace MLT.Data.Migrations
{
    public partial class Initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aircraft",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AircraftType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AircraftIdent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AircraftState = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircraft", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aircraft");
        }
    }
}
