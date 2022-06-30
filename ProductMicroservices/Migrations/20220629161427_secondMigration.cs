using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductMicroservices.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image_Name", "Name", "Price" },
                values: new object[] { "APPLE iPhone 13 pro Max(Graphite 128 GB)", "Iphone.jpg", "iPhone 13 Pro Max", 129999.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image_Name", "Name", "Price" },
                values: new object[] { "Brass Diamond bracelet with crystal clear finish", "bracelet.jpg", "Brass Diamond Bracelet", 2490.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image_Name", "Name", "Price", "Rating" },
                values: new object[,]
                {
                    { 3, "Men Slim Fit check slim collar casual shirt", "shirt.jpg", "Shirt", 999.0, 3 },
                    { 4, "Blue Star Comvertible 4-in-1 Cooling 1.5 Ton 5 Star AC", "ac.jpg", "Blue Star Inverter AC", 20999.0, 3 },
                    { 5, "SAMSUNG 192L Direct Cool Single Door 2 Star Refrigerator", "refri.jpg", "SAMSUNG Refrigerator", 13190.0, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image_Name", "Name", "Price" },
                values: new object[] { "Some example text.", "1.jfif", "Iphone", 20000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image_Name", "Name", "Price" },
                values: new object[] { "Some example text.", "1.jfif", "Bracelet", 2000.0 });
        }
    }
}
