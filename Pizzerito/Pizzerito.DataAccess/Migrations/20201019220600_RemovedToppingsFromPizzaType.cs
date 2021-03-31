﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzerito.DataAccess.Migrations
{
    public partial class RemovedToppingsFromPizzaType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaType_Toppings_ToppingsId",
                table: "PizzaType");

            migrationBuilder.DropIndex(
                name: "IX_PizzaType_ToppingsId",
                table: "PizzaType");

            migrationBuilder.DropColumn(
                name: "ToppingsId",
                table: "PizzaType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ToppingsId",
                table: "PizzaType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PizzaType_ToppingsId",
                table: "PizzaType",
                column: "ToppingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaType_Toppings_ToppingsId",
                table: "PizzaType",
                column: "ToppingsId",
                principalTable: "Toppings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}