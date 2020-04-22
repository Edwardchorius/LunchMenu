using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LunchMenu.Persistence.Migrations
{
    public partial class InitalSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "EntityFrameworkHiLoSequence",
                incrementBy: 10);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    OrdersInDays = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeastOrders",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    CustomerId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeastOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeastOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feasts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    FeastOrderId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feasts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feasts_FeastOrders_FeastOrderId",
                        column: x => x.FeastOrderId,
                        principalTable: "FeastOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeastOrders_CustomerId",
                table: "FeastOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Feasts_FeastOrderId",
                table: "Feasts",
                column: "FeastOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Feasts_Name",
                table: "Feasts",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feasts");

            migrationBuilder.DropTable(
                name: "FeastOrders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropSequence(
                name: "EntityFrameworkHiLoSequence");
        }
    }
}
