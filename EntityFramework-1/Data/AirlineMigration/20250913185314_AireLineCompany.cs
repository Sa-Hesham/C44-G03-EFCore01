using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_1.Data.AirlineMigration
{
    /// <inheritdoc />
    public partial class AireLineCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aircraft_routes",
                columns: table => new
                {
                    AC_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Route_Id = table.Column<int>(type: "int", nullable: false),
                    Departure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Num_Of_Pass = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Arrival = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aircraft_routes", x => x.AC_Id);
                });

            migrationBuilder.CreateTable(
                name: "AireCrafts",
                columns: table => new
                {
                    CraftId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapacityOfCraft = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<int>(type: "int", nullable: false),
                    MajPilot = table.Column<int>(type: "int", nullable: false),
                    AssitantName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Host1 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Host2 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    AireLineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AireCrafts", x => x.CraftId);
                });

            migrationBuilder.CreateTable(
                name: "AireLine_Company",
                columns: table => new
                {
                    Aire_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contatct_Person = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AireLine_Company", x => x.Aire_Id);
                });

            migrationBuilder.CreateTable(
                name: "AireLine_Phones",
                columns: table => new
                {
                    AireLine_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phones = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AireLine_Phones", x => x.AireLine_Id);
                });

            migrationBuilder.CreateTable(
                name: "Emp_Cualifications",
                columns: table => new
                {
                    Emp_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qualifications = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emp_Cualifications", x => x.Emp_Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gendar = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    BirthMonth = table.Column<int>(type: "int", nullable: false),
                    BirthDay = table.Column<int>(type: "int", nullable: false),
                    AireLinesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "routes",
                columns: table => new
                {
                    RouteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Distance = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_routes", x => x.RouteID);
                });

            migrationBuilder.CreateTable(
                name: "transactions",
                columns: table => new
                {
                    TransactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AireLineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transactions", x => x.TransactId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aircraft_routes");

            migrationBuilder.DropTable(
                name: "AireCrafts");

            migrationBuilder.DropTable(
                name: "AireLine_Company");

            migrationBuilder.DropTable(
                name: "AireLine_Phones");

            migrationBuilder.DropTable(
                name: "Emp_Cualifications");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "routes");

            migrationBuilder.DropTable(
                name: "transactions");
        }
    }
}
