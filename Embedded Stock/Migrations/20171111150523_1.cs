using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EmbeddedStock.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryComponentType_Categories_CategoryId",
                table: "CategoryComponentType");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryComponentType_ComponentTypes_ComponentTypeId",
                table: "CategoryComponentType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryComponentType",
                table: "CategoryComponentType");

            migrationBuilder.RenameTable(
                name: "CategoryComponentType",
                newName: "CategoryComponentTypes");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryComponentType_ComponentTypeId",
                table: "CategoryComponentTypes",
                newName: "IX_CategoryComponentTypes_ComponentTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryComponentTypes",
                table: "CategoryComponentTypes",
                columns: new[] { "CategoryId", "ComponentTypeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryComponentTypes_Categories_CategoryId",
                table: "CategoryComponentTypes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryComponentTypes_ComponentTypes_ComponentTypeId",
                table: "CategoryComponentTypes",
                column: "ComponentTypeId",
                principalTable: "ComponentTypes",
                principalColumn: "ComponentTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryComponentTypes_Categories_CategoryId",
                table: "CategoryComponentTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryComponentTypes_ComponentTypes_ComponentTypeId",
                table: "CategoryComponentTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryComponentTypes",
                table: "CategoryComponentTypes");

            migrationBuilder.RenameTable(
                name: "CategoryComponentTypes",
                newName: "CategoryComponentType");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryComponentTypes_ComponentTypeId",
                table: "CategoryComponentType",
                newName: "IX_CategoryComponentType_ComponentTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryComponentType",
                table: "CategoryComponentType",
                columns: new[] { "CategoryId", "ComponentTypeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryComponentType_Categories_CategoryId",
                table: "CategoryComponentType",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryComponentType_ComponentTypes_ComponentTypeId",
                table: "CategoryComponentType",
                column: "ComponentTypeId",
                principalTable: "ComponentTypes",
                principalColumn: "ComponentTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
