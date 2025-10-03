using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace food_asp.Migrations
{
    /// <inheritdoc />
    public partial class addShopDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Admin",
                columns: table => new
                {
                    Admin_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Admin_Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admin_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admin_Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admin_Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admin_Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Admin", x => x.Admin_Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Customers",
                columns: table => new
                {
                    Cus_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cus_Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cus_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cus_Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cus_Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cus_Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Customers", x => x.Cus_Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Order",
                columns: table => new
                {
                    Order_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Price_Total = table.Column<int>(type: "int", nullable: false),
                    Order_Cus_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Order", x => x.Order_Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_OrderDetail",
                columns: table => new
                {
                    Order_Id_Detail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_Id = table.Column<int>(type: "int", nullable: false),
                    Pro_Id = table.Column<int>(type: "int", nullable: false),
                    Pro_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pro_Price = table.Column<int>(type: "int", nullable: false),
                    Order_Quantity = table.Column<int>(type: "int", nullable: false),
                    Order_Price_Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_OrderDetail", x => x.Order_Id_Detail);
                });

            migrationBuilder.CreateTable(
                name: "tb_Product",
                columns: table => new
                {
                    Pro_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pro_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pro_Price = table.Column<int>(type: "int", nullable: false),
                    Pro_Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pro_Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pro_Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Product", x => x.Pro_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Admin");

            migrationBuilder.DropTable(
                name: "tb_Customers");

            migrationBuilder.DropTable(
                name: "tb_Order");

            migrationBuilder.DropTable(
                name: "tb_OrderDetail");

            migrationBuilder.DropTable(
                name: "tb_Product");
        }
    }
}
