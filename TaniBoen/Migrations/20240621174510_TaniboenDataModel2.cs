using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaniBoen.Migrations
{
    /// <inheritdoc />
    public partial class TaniboenDataModel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegisData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductData",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductRating = table.Column<int>(type: "int", nullable: false),
                    ProductTotalReview = table.Column<int>(type: "int", nullable: false),
                    ProductSold = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal", nullable: false),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductData", x => x.ProductId);
                });
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
