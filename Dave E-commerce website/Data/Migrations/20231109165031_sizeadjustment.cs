using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dave_E_commerce_website.Data.Migrations
{
    /// <inheritdoc />
    public partial class sizeadjustment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_size_SizeId",
                table: "product");

            migrationBuilder.DropTable(
                name: "size");

            migrationBuilder.DropIndex(
                name: "IX_product_SizeId",
                table: "product");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "product");

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "product",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "product");

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "product",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "size",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_size", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_product_SizeId",
                table: "product",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_product_size_SizeId",
                table: "product",
                column: "SizeId",
                principalTable: "size",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
