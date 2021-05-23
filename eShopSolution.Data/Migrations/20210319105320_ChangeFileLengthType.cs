using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileImage",
                table: "ProductImages");

            migrationBuilder.AddColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "17aa1867-f69a-4b1d-8728-c36bba13dbc6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5719a3c2-81fd-492f-b0f5-6a2dbcdc2b89", "AQAAAAEAACcQAAAAEJnMJJKQqpPRL4f16aeP59g7kiZfIoKBfRURBRsb1NWFYknQFx/YA0NW7QcnsRkacw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 19, 17, 53, 19, 178, DateTimeKind.Local).AddTicks(8493));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "ProductImages");

            migrationBuilder.AddColumn<int>(
                name: "FileImage",
                table: "ProductImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "37b073af-5211-43e0-955b-a1a5c48f7917");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fbc5f593-a8dd-4c69-91e9-e3ad8e2dce87", "AQAAAAEAACcQAAAAEEKIpcCgLUD/8JNq3E+smirkQd8Jc+R/ha+7Qkmqk1YwTg7/sVKw9ClIJjrdTx/ltQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 18, 23, 50, 38, 686, DateTimeKind.Local).AddTicks(7487));
        }
    }
}
