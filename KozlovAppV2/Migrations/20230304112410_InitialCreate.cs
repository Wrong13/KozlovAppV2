using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KozlovAppV2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDeliveryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrderPickupPoint = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Order__C3905BAF09CA5FBE", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductArticleNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPhoto = table.Column<byte[]>(type: "image", nullable: true),
                    ProductManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCost = table.Column<decimal>(type: "decimal(19,4)", nullable: true),
                    ProductDiscountAmount = table.Column<byte>(type: "tinyint", nullable: true),
                    ProductQuantityInStock = table.Column<int>(type: "int", nullable: true),
                    ProductStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Product__2EA7DCD514801448", x => x.ProductArticleNumber);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Role__8AFACE3A0CB3FCDB", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductArticleNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OrderPro__817A26626B9A4E27", x => new { x.OrderID, x.ProductArticleNumber });
                    table.ForeignKey(
                        name: "FK__OrderProd__Order__403A8C7D",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID");
                    table.ForeignKey(
                        name: "FK__OrderProd__Produ__412EB0B6",
                        column: x => x.ProductArticleNumber,
                        principalTable: "Product",
                        principalColumn: "ProductArticleNumber");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserSurname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserPatronymic = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserLogin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User__1788CCAC4D8C8B63", x => x.UserID);
                    table.ForeignKey(
                        name: "FK__User__UserRole__398D8EEE",
                        column: x => x.UserRole,
                        principalTable: "Role",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductArticleNumber",
                table: "OrderProduct",
                column: "ProductArticleNumber");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserRole",
                table: "User",
                column: "UserRole");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
