using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechD3xLabs.Trade.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AlterInitialScheme3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Orders",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Orders",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "USD");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Orders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Currency", "Text", "TransactTime" },
                values: new object[] { new DateTime(2024, 5, 24, 6, 48, 43, 407, DateTimeKind.Local).AddTicks(9076), "system", "USD", "", new DateTime(2024, 5, 24, 6, 48, 43, 407, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Currency", "Text", "TransactTime" },
                values: new object[] { new DateTime(2024, 5, 24, 6, 48, 43, 407, DateTimeKind.Local).AddTicks(9083), "system", "USD", "", new DateTime(2024, 5, 24, 6, 48, 43, 407, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Currency", "Text", "TransactTime" },
                values: new object[] { new DateTime(2024, 5, 24, 6, 48, 43, 407, DateTimeKind.Local).AddTicks(9089), "system", "USD", "", new DateTime(2024, 5, 24, 6, 48, 43, 407, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Currency", "Text", "TransactTime" },
                values: new object[] { new DateTime(2024, 5, 24, 6, 48, 43, 407, DateTimeKind.Local).AddTicks(9093), "system", "USD", "", new DateTime(2024, 5, 24, 6, 48, 43, 407, DateTimeKind.Local).AddTicks(9091) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "TransactTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 22, 0, 37, 24, 562, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "TransactTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 22, 0, 37, 24, 562, DateTimeKind.Local).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "TransactTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 22, 0, 37, 24, 562, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "TransactTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 22, 0, 37, 24, 562, DateTimeKind.Local).AddTicks(1034) });
        }
    }
}
