using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dave_E_commerce_website.Data.Migrations
{
    /// <inheritdoc />
    public partial class colorconstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "picture",
                table: "product");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "picture",
                table: "product",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
