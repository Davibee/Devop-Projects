using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dave_E_commerce_website.Data.Migrations
{
    /// <inheritdoc />
    public partial class changepicturepropertytostring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_picture_pictureId",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_pictureId",
                table: "product");

            migrationBuilder.DropColumn(
                name: "pictureId",
                table: "product");

            migrationBuilder.AddColumn<string>(
                name: "picture",
                table: "product",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "picture",
                table: "product");

            migrationBuilder.AddColumn<int>(
                name: "pictureId",
                table: "product",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_product_pictureId",
                table: "product",
                column: "pictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_product_picture_pictureId",
                table: "product",
                column: "pictureId",
                principalTable: "picture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
