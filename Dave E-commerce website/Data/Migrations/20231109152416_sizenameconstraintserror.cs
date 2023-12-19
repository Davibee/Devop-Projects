using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dave_E_commerce_website.Data.Migrations
{
    /// <inheritdoc />
    public partial class sizenameconstraintserror : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_category_categoryId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_size_sizeId",
                table: "product");

            migrationBuilder.RenameColumn(
                name: "sizeId",
                table: "product",
                newName: "SizeId");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "product",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_product_sizeId",
                table: "product",
                newName: "IX_product_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_product_categoryId",
                table: "product",
                newName: "IX_product_CategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "size",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_category_CategoryId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_size_SizeId",
                table: "product");

            migrationBuilder.RenameColumn(
                name: "SizeId",
                table: "product",
                newName: "sizeId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "product",
                newName: "categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_product_SizeId",
                table: "product",
                newName: "IX_product_sizeId");

            migrationBuilder.RenameIndex(
                name: "IX_product_CategoryId",
                table: "product",
                newName: "IX_product_categoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "size",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "sizeId",
                table: "product",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "categoryId",
                table: "product",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_product_category_categoryId",
                table: "product",
                column: "categoryId",
                principalTable: "category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_size_sizeId",
                table: "product",
                column: "sizeId",
                principalTable: "size",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
