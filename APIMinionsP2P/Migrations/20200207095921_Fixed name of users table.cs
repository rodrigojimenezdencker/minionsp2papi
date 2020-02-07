using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIMinionsP2P.Migrations
{
    public partial class Fixednameofuserstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loan");

            migrationBuilder.DropTable(
                name: "Deudor");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(nullable: true),
                    DNI = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeudorId = table.Column<int>(nullable: false),
                    LenderId = table.Column<int>(nullable: false),
                    Tae = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    LeaseInception = table.Column<DateTime>(nullable: false),
                    ContractPeriod = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_Users_DeudorId",
                        column: x => x.DeudorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_Users_LenderId",
                        column: x => x.LenderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loans_DeudorId",
                table: "Loans",
                column: "DeudorId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LenderId",
                table: "Loans",
                column: "LenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.CreateTable(
                name: "Deudor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deudor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ContractPeriod = table.Column<int>(type: "int", nullable: false),
                    DeudorId = table.Column<int>(type: "int", nullable: false),
                    LeaseInception = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LenderId = table.Column<int>(type: "int", nullable: false),
                    Tae = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loan_Deudor_DeudorId",
                        column: x => x.DeudorId,
                        principalTable: "Deudor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loan_Deudor_LenderId",
                        column: x => x.LenderId,
                        principalTable: "Deudor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loan_DeudorId",
                table: "Loan",
                column: "DeudorId");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_LenderId",
                table: "Loan",
                column: "LenderId");
        }
    }
}
