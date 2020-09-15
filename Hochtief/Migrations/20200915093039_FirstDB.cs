using Microsoft.EntityFrameworkCore.Migrations;

namespace Hochtief.Migrations
{
    public partial class FirstDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LabourInt",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemno = table.Column<int>(nullable: false),
                    rowid = table.Column<int>(nullable: false),
                    formversion = table.Column<int>(nullable: false),
                    activity = table.Column<string>(nullable: true),
                    hoursActivity = table.Column<double>(nullable: false),
                    posht = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabourInt", x => x.id);
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
                name: "sourceCompanies",
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
                    table.PrimaryKey("PK_sourceCompanies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sourceEquipment",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    En_equipment = table.Column<string>(nullable: true),
                    De_equipment = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true),
                    code_Company = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sourceEquipment", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "testTabelle",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testTabelle", x => x.id);
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
                name: "LabourInt");

            migrationBuilder.DropTable(
                name: "Source_Roles");

            migrationBuilder.DropTable(
                name: "sourceCompanies");

            migrationBuilder.DropTable(
                name: "sourceEquipment");

            migrationBuilder.DropTable(
                name: "testTabelle");

            migrationBuilder.DropTable(
                name: "Weather");
        }
    }
}
