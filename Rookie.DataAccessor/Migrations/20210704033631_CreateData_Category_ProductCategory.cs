using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookie.DataAccessor.Migrations
{
    public partial class CreateData_Category_ProductCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("e1d33fda-2fa3-4927-a07a-2bfc243df88f"), new DateTime(2021, 7, 4, 10, 36, 30, 495, DateTimeKind.Local).AddTicks(1840), "Mua ban cac loai thu cung", "Thu cung", null },
                    { new Guid("de876948-cbe2-4740-b944-030ef8e40c28"), new DateTime(2021, 7, 4, 10, 36, 30, 495, DateTimeKind.Local).AddTicks(1861), "Cac loai thuc an danh cho thu cung", "Thuc an cho Pet", null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a742eec4-a3a1-4623-b146-97f21d227080"),
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 10, 36, 30, 493, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6c40780-01ef-466e-8ae0-0b3c51d62285"),
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 10, 36, 30, 492, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e044de2d-2183-445c-a821-0b06fec05cd4"),
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 10, 36, 30, 493, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "Images", "Name", "Price", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("290d1a74-0839-4919-a2b2-6a5bcf097757"), new DateTime(2021, 7, 4, 10, 36, 30, 493, DateTimeKind.Local).AddTicks(6333), "Thuc an loai tot nhat", "/loaiA.png", "Thuc an loai A", 3000000m, null },
                    { new Guid("e3bc0d45-6f0e-4e04-b06f-9dd6ba0190f9"), new DateTime(2021, 7, 4, 10, 36, 30, 493, DateTimeKind.Local).AddTicks(6337), "Thuc an loai vua", "/loaiB.png", "Thuc an loai B", 2000000m, null },
                    { new Guid("5c6ece7a-4bcc-4690-bb51-c42034178db0"), new DateTime(2021, 7, 4, 10, 36, 30, 493, DateTimeKind.Local).AddTicks(6340), "Thuc an loai binh thuong", "/loaiC.png", "Thuc an loai C", 1000000m, null }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("e1d33fda-2fa3-4927-a07a-2bfc243df88f"), new Guid("d6c40780-01ef-466e-8ae0-0b3c51d62285") },
                    { new Guid("e1d33fda-2fa3-4927-a07a-2bfc243df88f"), new Guid("e044de2d-2183-445c-a821-0b06fec05cd4") },
                    { new Guid("e1d33fda-2fa3-4927-a07a-2bfc243df88f"), new Guid("a742eec4-a3a1-4623-b146-97f21d227080") },
                    { new Guid("de876948-cbe2-4740-b944-030ef8e40c28"), new Guid("290d1a74-0839-4919-a2b2-6a5bcf097757") },
                    { new Guid("de876948-cbe2-4740-b944-030ef8e40c28"), new Guid("e3bc0d45-6f0e-4e04-b06f-9dd6ba0190f9") },
                    { new Guid("de876948-cbe2-4740-b944-030ef8e40c28"), new Guid("5c6ece7a-4bcc-4690-bb51-c42034178db0") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("de876948-cbe2-4740-b944-030ef8e40c28"), new Guid("290d1a74-0839-4919-a2b2-6a5bcf097757") });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("de876948-cbe2-4740-b944-030ef8e40c28"), new Guid("5c6ece7a-4bcc-4690-bb51-c42034178db0") });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("de876948-cbe2-4740-b944-030ef8e40c28"), new Guid("e3bc0d45-6f0e-4e04-b06f-9dd6ba0190f9") });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e1d33fda-2fa3-4927-a07a-2bfc243df88f"), new Guid("a742eec4-a3a1-4623-b146-97f21d227080") });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e1d33fda-2fa3-4927-a07a-2bfc243df88f"), new Guid("d6c40780-01ef-466e-8ae0-0b3c51d62285") });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e1d33fda-2fa3-4927-a07a-2bfc243df88f"), new Guid("e044de2d-2183-445c-a821-0b06fec05cd4") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("de876948-cbe2-4740-b944-030ef8e40c28"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1d33fda-2fa3-4927-a07a-2bfc243df88f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("290d1a74-0839-4919-a2b2-6a5bcf097757"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c6ece7a-4bcc-4690-bb51-c42034178db0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3bc0d45-6f0e-4e04-b06f-9dd6ba0190f9"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a742eec4-a3a1-4623-b146-97f21d227080"),
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 10, 16, 29, 69, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6c40780-01ef-466e-8ae0-0b3c51d62285"),
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 10, 16, 29, 68, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e044de2d-2183-445c-a821-0b06fec05cd4"),
                column: "CreatedDate",
                value: new DateTime(2021, 7, 4, 10, 16, 29, 69, DateTimeKind.Local).AddTicks(9187));
        }
    }
}
