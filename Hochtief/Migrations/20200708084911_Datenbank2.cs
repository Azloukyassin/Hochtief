using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hochtief.Migrations
{
    public partial class Datenbank2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Source_Companies",
                table: "Source_Companies");

            migrationBuilder.RenameTable(
                name: "Source_Companies",
                newName: "sourceCompanies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sourceCompanies",
                table: "sourceCompanies",
                column: "id");

            migrationBuilder.CreateTable(
                name: "definitionPDSLevels",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pds = table.Column<string>(nullable: true),
                    pdsName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_definitionPDSLevels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MainActivities",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemno = table.Column<int>(nullable: false),
                    rowid = table.Column<int>(nullable: false),
                    formversion = table.Column<int>(nullable: false),
                    pds01 = table.Column<string>(nullable: true),
                    pds02 = table.Column<string>(nullable: true),
                    pds03 = table.Column<string>(nullable: true),
                    pds04 = table.Column<string>(nullable: true),
                    pds05 = table.Column<string>(nullable: true),
                    pds06 = table.Column<string>(nullable: true),
                    activity = table.Column<string>(nullable: true),
                    activitytype = table.Column<string>(nullable: true),
                    activitytypedetail = table.Column<string>(nullable: true),
                    kolonnenae = table.Column<string>(nullable: true),
                    contractor = table.Column<string>(nullable: true),
                    hours_activity = table.Column<string>(nullable: true),
                    activity_status = table.Column<string>(nullable: true),
                    activityInternExtern = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainActivities", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mainActivitySubTasks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemno = table.Column<int>(nullable: false),
                    rowid = table.Column<int>(nullable: false),
                    formversion = table.Column<int>(nullable: false),
                    activitySubTask = table.Column<string>(nullable: true),
                    activity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainActivitySubTasks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mainAdditionalWorks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemno = table.Column<int>(nullable: false),
                    rowid = table.Column<int>(nullable: false),
                    eventCategory = table.Column<int>(nullable: false),
                    pds01 = table.Column<string>(nullable: true),
                    pds02 = table.Column<string>(nullable: true),
                    additionalWorksPds04 = table.Column<string>(nullable: true),
                    additionalWorksPds05 = table.Column<string>(nullable: true),
                    additionalWorksPds06 = table.Column<string>(nullable: true),
                    additionalWorksActivity = table.Column<string>(nullable: true),
                    eventHours = table.Column<string>(nullable: true),
                    additionalWorksTxt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainAdditionalWorks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MainEquipment",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemno = table.Column<int>(nullable: false),
                    rowid = table.Column<int>(nullable: false),
                    formversion = table.Column<int>(nullable: false),
                    activity = table.Column<double>(nullable: false),
                    equipment01 = table.Column<string>(nullable: true),
                    equipment01Contractor = table.Column<string>(nullable: true),
                    equipment01Num = table.Column<double>(nullable: false),
                    equipment01Hours = table.Column<double>(nullable: false),
                    equipment02 = table.Column<string>(nullable: true),
                    equipment02Contractor = table.Column<string>(nullable: true),
                    equipment02Num = table.Column<string>(nullable: true),
                    equipment02Hours = table.Column<string>(nullable: true),
                    equipment03 = table.Column<string>(nullable: true),
                    equipment03Contractor = table.Column<string>(nullable: true),
                    equipment03Num = table.Column<string>(nullable: true),
                    equipment03Hours = table.Column<string>(nullable: true),
                    equipment04 = table.Column<string>(nullable: true),
                    equipment04Contractor = table.Column<string>(nullable: true),
                    equipment04Num = table.Column<string>(nullable: true),
                    equipment04Hours = table.Column<string>(nullable: true),
                    equipment05 = table.Column<string>(nullable: true),
                    equipment05Contractor = table.Column<string>(nullable: true),
                    equipment05Num = table.Column<string>(nullable: true),
                    equipment05Hours = table.Column<string>(nullable: true),
                    equipment06 = table.Column<string>(nullable: true),
                    equipment06Contractor = table.Column<string>(nullable: true),
                    equipment06Num = table.Column<string>(nullable: true),
                    equipment06Hours = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainEquipment", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mainField2BIMs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemno = table.Column<int>(nullable: false),
                    formversion = table.Column<int>(nullable: false),
                    latitude = table.Column<double>(nullable: false),
                    longitude = table.Column<double>(nullable: false),
                    starttime = table.Column<string>(nullable: true),
                    completetime = table.Column<string>(nullable: true),
                    userfirstname = table.Column<string>(nullable: true),
                    userlastname = table.Column<string>(nullable: true),
                    projectDef = table.Column<string>(nullable: true),
                    headerPds01 = table.Column<string>(nullable: true),
                    headerPds02 = table.Column<string>(nullable: true),
                    headerPds03 = table.Column<string>(nullable: true),
                    headerPds04 = table.Column<string>(nullable: true),
                    reportID = table.Column<string>(nullable: true),
                    ReportDate = table.Column<string>(nullable: true),
                    ReportStartTime = table.Column<string>(nullable: true),
                    ReportEndTime = table.Column<string>(nullable: true),
                    ReportBreakTimeNumeric = table.Column<double>(nullable: false),
                    timeRang = table.Column<string>(nullable: true),
                    TimeHours = table.Column<int>(nullable: false),
                    ReportHours = table.Column<int>(nullable: false),
                    pds01 = table.Column<string>(nullable: true),
                    pds01Desc = table.Column<string>(nullable: true),
                    TempTime = table.Column<string>(nullable: true),
                    ApiKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainField2BIMs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mainGenerals",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemno = table.Column<int>(nullable: false),
                    rowid = table.Column<int>(nullable: false),
                    formversion = table.Column<int>(nullable: false),
                    taskname = table.Column<string>(nullable: true),
                    usemail = table.Column<string>(nullable: true),
                    bautagebuchAutoPolier = table.Column<string>(nullable: true),
                    reportID = table.Column<string>(nullable: true),
                    ReportDate = table.Column<string>(nullable: true),
                    ReportStartTime = table.Column<string>(nullable: true),
                    ReportEndTime = table.Column<string>(nullable: true),
                    ReportBreakTimeNum = table.Column<double>(nullable: false),
                    ReportHours = table.Column<double>(nullable: false),
                    FreigabeDate = table.Column<string>(nullable: true),
                    FreigabeAutor = table.Column<string>(nullable: true),
                    FreigabeDate1 = table.Column<string>(nullable: true),
                    genehmigungAutor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainGenerals", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mainPhotos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemno = table.Column<int>(nullable: false),
                    taskname = table.Column<string>(nullable: true),
                    reportID = table.Column<string>(nullable: true),
                    ReportDate = table.Column<DateTime>(nullable: false),
                    fotosActivitySelection = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainPhotos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mainSignaturePhotos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportID = table.Column<int>(nullable: false),
                    SignaturePhoto = table.Column<string>(nullable: true),
                    SignedDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainSignaturePhotos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pds",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocL1 = table.Column<string>(nullable: true),
                    LocL2 = table.Column<string>(nullable: true),
                    LocL3 = table.Column<string>(nullable: true),
                    pdsL1 = table.Column<string>(nullable: true),
                    pdsL2 = table.Column<string>(nullable: true),
                    pdsL3 = table.Column<string>(nullable: true),
                    pdsL4 = table.Column<string>(nullable: true),
                    pdsL5 = table.Column<string>(nullable: true),
                    Descr = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Resp = table.Column<string>(nullable: true),
                    path = table.Column<string>(nullable: true),
                    Master = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pds", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "schedules",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDTask = table.Column<int>(nullable: false),
                    TaskName = table.Column<string>(nullable: true),
                    LocL1 = table.Column<string>(nullable: true),
                    LocL2 = table.Column<string>(nullable: true),
                    LocL3 = table.Column<string>(nullable: true),
                    pdsL1 = table.Column<string>(nullable: true),
                    pdsL2 = table.Column<string>(nullable: true),
                    pdsL3 = table.Column<string>(nullable: true),
                    pdsL4 = table.Column<string>(nullable: true),
                    pdsL5 = table.Column<string>(nullable: true),
                    Descr = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Resp = table.Column<string>(nullable: true),
                    path = table.Column<string>(nullable: true),
                    Master = table.Column<string>(nullable: true),
                    PdsID = table.Column<string>(nullable: true),
                    TaskOriginal = table.Column<string>(nullable: true),
                    pds02Descr = table.Column<string>(nullable: true),
                    FullDescr = table.Column<string>(nullable: true),
                    Bautagesbericht = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedules", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "definitionPDSLevels");

            migrationBuilder.DropTable(
                name: "MainActivities");

            migrationBuilder.DropTable(
                name: "mainActivitySubTasks");

            migrationBuilder.DropTable(
                name: "mainAdditionalWorks");

            migrationBuilder.DropTable(
                name: "MainEquipment");

            migrationBuilder.DropTable(
                name: "mainField2BIMs");

            migrationBuilder.DropTable(
                name: "mainGenerals");

            migrationBuilder.DropTable(
                name: "mainPhotos");

            migrationBuilder.DropTable(
                name: "mainSignaturePhotos");

            migrationBuilder.DropTable(
                name: "pds");

            migrationBuilder.DropTable(
                name: "schedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sourceCompanies",
                table: "sourceCompanies");

            migrationBuilder.RenameTable(
                name: "sourceCompanies",
                newName: "Source_Companies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Source_Companies",
                table: "Source_Companies",
                column: "id");
        }
    }
}
