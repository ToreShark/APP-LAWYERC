using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APP_LAWYER.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedSubcategoryRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Subcategories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        
            migrationBuilder.Sql("UPDATE Subcategories SET RoleId = 4 WHERE RoleId = 0");

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_RoleId",
                table: "Subcategories",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subcategories_Roles_RoleId",
                table: "Subcategories",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subcategories_Roles_RoleId",
                table: "Subcategories");

            migrationBuilder.DropIndex(
                name: "IX_Subcategories_RoleId",
                table: "Subcategories");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Subcategories");
        }
    }
}
