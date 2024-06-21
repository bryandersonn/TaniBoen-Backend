using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaniBoen.Migrations
{
    /// <inheritdoc />
    public partial class TaniboenDataModel2tes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginData");
            migrationBuilder.DropTable(
                name: "ProductData");
            migrationBuilder.DropTable(
                name: "RegisData");
        }
    }
}
