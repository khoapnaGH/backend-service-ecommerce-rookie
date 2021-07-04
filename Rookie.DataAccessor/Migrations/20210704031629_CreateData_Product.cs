using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookie.DataAccessor.Migrations
{
    public partial class CreateData_Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "Images", "Name", "Price", "UpdatedDate" },
                values: new object[] { new Guid("d6c40780-01ef-466e-8ae0-0b3c51d62285"), new DateTime(2021, 7, 4, 10, 16, 29, 68, DateTimeKind.Local).AddTicks(9236), "Giong cho tu Chau Au", "/alaska.png", "Alaska", 12000000m, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "Images", "Name", "Price", "UpdatedDate" },
                values: new object[] { new Guid("e044de2d-2183-445c-a821-0b06fec05cd4"), new DateTime(2021, 7, 4, 10, 16, 29, 69, DateTimeKind.Local).AddTicks(9187), "Giong cho tu Viet Nam", "/phuquoc.png", "Cho Phu Quoc", 8000000m, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "Images", "Name", "Price", "UpdatedDate" },
                values: new object[] { new Guid("a742eec4-a3a1-4623-b146-97f21d227080"), new DateTime(2021, 7, 4, 10, 16, 29, 69, DateTimeKind.Local).AddTicks(9207), "Giong cho tu Nhat Ban", "/shiba.png", "shiba", 35000000m, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a742eec4-a3a1-4623-b146-97f21d227080"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6c40780-01ef-466e-8ae0-0b3c51d62285"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e044de2d-2183-445c-a821-0b06fec05cd4"));
        }
    }
}
