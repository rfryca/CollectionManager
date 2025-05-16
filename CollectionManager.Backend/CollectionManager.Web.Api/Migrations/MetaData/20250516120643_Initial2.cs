using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollectionManager.Web.Api.Migrations.MetaData
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemType_ApplicationUser_ApplicationUserId",
                table: "ItemType");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemType_CollectionTypes_CollectionTypeId",
                table: "ItemType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemType",
                table: "ItemType");

            migrationBuilder.RenameTable(
                name: "ItemType",
                newName: "ItemTypes");

            migrationBuilder.RenameIndex(
                name: "IX_ItemType_CollectionTypeId",
                table: "ItemTypes",
                newName: "IX_ItemTypes_CollectionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemType_ApplicationUserId",
                table: "ItemTypes",
                newName: "IX_ItemTypes_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemTypes",
                table: "ItemTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemTypes_ApplicationUser_ApplicationUserId",
                table: "ItemTypes",
                column: "ApplicationUserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemTypes_CollectionTypes_CollectionTypeId",
                table: "ItemTypes",
                column: "CollectionTypeId",
                principalTable: "CollectionTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemTypes_ApplicationUser_ApplicationUserId",
                table: "ItemTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemTypes_CollectionTypes_CollectionTypeId",
                table: "ItemTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemTypes",
                table: "ItemTypes");

            migrationBuilder.RenameTable(
                name: "ItemTypes",
                newName: "ItemType");

            migrationBuilder.RenameIndex(
                name: "IX_ItemTypes_CollectionTypeId",
                table: "ItemType",
                newName: "IX_ItemType_CollectionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemTypes_ApplicationUserId",
                table: "ItemType",
                newName: "IX_ItemType_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemType",
                table: "ItemType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemType_ApplicationUser_ApplicationUserId",
                table: "ItemType",
                column: "ApplicationUserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemType_CollectionTypes_CollectionTypeId",
                table: "ItemType",
                column: "CollectionTypeId",
                principalTable: "CollectionTypes",
                principalColumn: "Id");
        }
    }
}
