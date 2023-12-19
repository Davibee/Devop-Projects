using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dave_E_commerce_website.Data.Migrations
{
    /// <inheritdoc />
    public partial class categoryidnotnullable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_category_CategoryId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_size_SizeId",
                table: "product");

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "product",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "product",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_product_category_CategoryId",
                table: "product",
                column: "CategoryId",
                principalTable: "category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_size_SizeId",
                table: "product",
                column: "SizeId",
                principalTable: "size",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_category_CategoryId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_size_SizeId",
                table: "product");

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "product",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "product",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_product_category_CategoryId",
                table: "product",
                column: "CategoryId",
                principalTable: "category",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_product_size_SizeId",
                table: "product",
                column: "SizeId",
                principalTable: "size",
                principalColumn: "Id");
        }
    }
}
