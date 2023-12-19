using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dave_E_commerce_website.Data.Migrations
{
    /// <inheritdoc />
    public partial class Populatecategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO category (Id) VALUES (1);");
            migrationBuilder.Sql("INSERT INTO category (Id) VALUES (2);");
            migrationBuilder.Sql("INSERT INTO category (Id) VALUES (3);");
            migrationBuilder.Sql("INSERT INTO category (Id) VALUES (4);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM category WHERE Id IN (1,2,3,4);");
        }
    }
}
