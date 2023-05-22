using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProject.Migrations
{
    public partial class miDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_categories_CategoryIDCategory",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "IX_categories_CategoryIDCategory",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "CategoryIDCategory",
                table: "categories");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeCreated",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeCreated",
                table: "News");

            migrationBuilder.AddColumn<int>(
                name: "CategoryIDCategory",
                table: "categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_categories_CategoryIDCategory",
                table: "categories",
                column: "CategoryIDCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_categories_CategoryIDCategory",
                table: "categories",
                column: "CategoryIDCategory",
                principalTable: "categories",
                principalColumn: "IDCategory",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
