using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SpecialLibrary.Context.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    SecurityLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    IsAwarded = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IsLibraryWorker = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderInfoUsers",
                columns: table => new
                {
                    OrderInfoId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderInfoUsers", x => new { x.OrderInfoId, x.UserId });
                    table.ForeignKey(
                        name: "FK_OrderInfoUsers_Orders_OrderInfoId",
                        column: x => x.OrderInfoId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderInfoUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreateDate", "IsAwarded", "Location", "SecurityLevel", "Title", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2380), false, "Order Location 1", 1, "Order1", 1 },
                    { 2, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2395), false, "Order Location 2", 1, "Order2", 1 },
                    { 3, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2398), false, "Order Location 3", 0, "Order3", 0 },
                    { 4, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2400), false, "Order Location 4", 1, "Order4", 0 },
                    { 5, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2402), false, "Order Location 5", 0, "Order5", 0 },
                    { 6, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2405), false, "Order Location 6", 1, "Order6", 1 },
                    { 7, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2407), false, "Order Location 7", 0, "Order7", 0 },
                    { 8, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2409), false, "Order Location 8", 1, "Order8", 0 },
                    { 9, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2434), false, "Order Location 9", 0, "Order9", 1 },
                    { 10, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2438), false, "Order Location 10", 0, "Order10", 0 },
                    { 11, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2440), false, "Order Location 11", 0, "Order11", 0 },
                    { 12, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2442), false, "Order Location 12", 0, "Order12", 1 },
                    { 13, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2444), false, "Order Location 13", 0, "Order13", 1 },
                    { 14, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2445), false, "Order Location 14", 1, "Order14", 0 },
                    { 15, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2447), false, "Order Location 15", 0, "Order15", 0 },
                    { 16, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2449), false, "Order Location 16", 0, "Order16", 1 },
                    { 17, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2451), false, "Order Location 17", 0, "Order17", 0 },
                    { 18, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2454), false, "Order Location 18", 1, "Order18", 0 },
                    { 19, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2456), false, "Order Location 19", 1, "Order19", 1 },
                    { 20, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2458), false, "Order Location 20", 1, "Order20", 0 },
                    { 21, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2459), false, "Order Location 21", 1, "Order21", 1 },
                    { 22, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2461), false, "Order Location 22", 1, "Order22", 0 },
                    { 23, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2462), false, "Order Location 23", 1, "Order23", 1 },
                    { 24, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2465), false, "Order Location 24", 0, "Order24", 1 },
                    { 25, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2467), false, "Order Location 25", 1, "Order25", 0 },
                    { 26, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2468), false, "Order Location 26", 0, "Order26", 0 },
                    { 27, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2470), false, "Order Location 27", 1, "Order27", 0 },
                    { 28, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2472), false, "Order Location 28", 0, "Order28", 1 },
                    { 29, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2474), false, "Order Location 29", 1, "Order29", 1 },
                    { 30, new DateTime(2023, 4, 2, 13, 35, 14, 737, DateTimeKind.Local).AddTicks(2476), false, "Order Location 30", 0, "Order30", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsLibraryWorker", "Name" },
                values: new object[,]
                {
                    { 1, false, "User1" },
                    { 2, true, "User2" },
                    { 3, false, "User3" },
                    { 4, true, "User4" },
                    { 5, false, "User5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderInfoUsers_UserId",
                table: "OrderInfoUsers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderInfoUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
