using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dave_E_commerce_website.Data.Migrations
{
    /// <inheritdoc />
    public partial class Populatecategoryname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO category (Id) VALUES (5);");
            migrationBuilder.Sql("UPDATE category SET Name = 'Men' WHERE Id = 1;");
            migrationBuilder.Sql("UPDATE category SET Name = 'Women' WHERE Id = 2;");
            migrationBuilder.Sql("UPDATE category SET Name = 'Kids' WHERE Id = 3;");
            migrationBuilder.Sql("UPDATE category SET Name = 'Shoes and Accessories' WHERE Id = 4;");
            migrationBuilder.Sql("UPDATE category SET Name = 'Trending' WHERE Id = 5;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM category WHERE Id IN (1,2,3,4,5);");
        }
    }
}
