using Microsoft.EntityFrameworkCore.Migrations;

namespace Citizens.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CitizenEducationDetails",
                columns: table => new
                {
                    CitizenID = table.Column<int>(nullable: false),
                    EducationBoard = table.Column<string>(nullable: false),
                    EducationLevel = table.Column<string>(nullable: false),
                    EducationSpecialization = table.Column<string>(nullable: false),
                    YearOfPassing = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitizenEducationDetails", x => x.CitizenID);
                });

            migrationBuilder.CreateTable(
                name: "CitizenMedicalHistory",
                columns: table => new
                {
                    CitizenID = table.Column<int>(nullable: false),
                    MedicalCenterID = table.Column<int>(nullable: false),
                    MedDeptID = table.Column<int>(nullable: false),
                    DateOfVisit = table.Column<string>(nullable: false),
                    CauseOfVisit = table.Column<string>(nullable: false),
                    Prescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitizenMedicalHistory", x => x.CitizenID);
                });

            migrationBuilder.CreateTable(
                name: "CitizenPersonalDetail",
                columns: table => new
                {
                    AADHARID = table.Column<int>(maxLength: 16, nullable: false),
                    DateOfBirth = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Pincode = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    EMail = table.Column<string>(nullable: false),
                    PrimaryPhone = table.Column<int>(nullable: false),
                    OtherPhone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitizenPersonalDetail", x => x.AADHARID);
                });

            migrationBuilder.CreateTable(
                name: "CountryMedicalCenters",
                columns: table => new
                {
                    MedicalCenterID = table.Column<int>(nullable: false),
                    StateID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryMedicalCenters", x => x.MedicalCenterID);
                });

            migrationBuilder.CreateTable(
                name: "CountryMedicalDepartments",
                columns: table => new
                {
                    MedicalDeptID = table.Column<int>(nullable: false),
                    DepatmentName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryMedicalDepartments", x => x.MedicalDeptID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitizenEducationDetails");

            migrationBuilder.DropTable(
                name: "CitizenMedicalHistory");

            migrationBuilder.DropTable(
                name: "CitizenPersonalDetail");

            migrationBuilder.DropTable(
                name: "CountryMedicalCenters");

            migrationBuilder.DropTable(
                name: "CountryMedicalDepartments");
        }
    }
}
