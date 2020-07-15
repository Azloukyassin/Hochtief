using Microsoft.EntityFrameworkCore.Migrations;

namespace Hochtief.Migrations
{
    public partial class Datenbank1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Source_Companies",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    En_company = table.Column<string>(nullable: true),
                    De_firma = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true),
                    Company_type = table.Column<string>(nullable: true),
                    pds01 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source_Companies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Source_Roles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    En_role = table.Column<string>(nullable: true),
                    De_role = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source_Roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    temp_time = table.Column<string>(nullable: true),
                    temp = table.Column<string>(nullable: true),
                    temp_condition = table.Column<string>(nullable: true),
                    datum = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Source_Companies");

            migrationBuilder.DropTable(
                name: "Source_Roles");

            migrationBuilder.DropTable(
                name: "Weather");
        }
    }
}
