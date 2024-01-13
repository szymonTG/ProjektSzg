using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektSzg.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TableBooks",
                columns: table => new
                {
                    bookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    author = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    isbn = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableBooks", x => x.bookId);
                });

            migrationBuilder.CreateTable(
                name: "TableEmployees",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employeeSurname = table.Column<int>(type: "int", nullable: false),
                    telNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableEmployees", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TableUsers",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    telNumber = table.Column<int>(type: "int", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableUsers", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "TableBookRentals",
                columns: table => new
                {
                    rentalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: false),
                    UsersuserId = table.Column<int>(type: "int", nullable: true),
                    bookId = table.Column<int>(type: "int", nullable: false),
                    BooksbookId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableBookRentals", x => x.rentalId);
                    table.ForeignKey(
                        name: "FK_TableBookRentals_TableBooks_BooksbookId",
                        column: x => x.BooksbookId,
                        principalTable: "TableBooks",
                        principalColumn: "bookId");
                    table.ForeignKey(
                        name: "FK_TableBookRentals_TableUsers_UsersuserId",
                        column: x => x.UsersuserId,
                        principalTable: "TableUsers",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TableBookRentals_BooksbookId",
                table: "TableBookRentals",
                column: "BooksbookId");

            migrationBuilder.CreateIndex(
                name: "IX_TableBookRentals_UsersuserId",
                table: "TableBookRentals",
                column: "UsersuserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TableBookRentals");

            migrationBuilder.DropTable(
                name: "TableEmployees");

            migrationBuilder.DropTable(
                name: "TableBooks");

            migrationBuilder.DropTable(
                name: "TableUsers");
        }
    }
}
