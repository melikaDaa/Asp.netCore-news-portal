using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProject.Migrations
{
    public partial class CreatDatabae : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "News",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorID",
                table: "News",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_News_authors_AuthorID",
                table: "News",
                column: "AuthorID",
                principalTable: "authors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_authors_AuthorID",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_AuthorID",
                table: "News");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "News");
        }
    }
}
