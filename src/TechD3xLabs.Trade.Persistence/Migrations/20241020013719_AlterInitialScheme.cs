using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechD3xLabs.Trade.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AlterInitialScheme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "TransactTime" },
                values: new object[] { new DateTime(2024, 10, 19, 19, 37, 18, 782, DateTimeKind.Local).AddTicks(7810), new DateTime(2024, 10, 19, 19, 37, 18, 782, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "TransactTime" },
                values: new object[] { new DateTime(2024, 10, 19, 19, 37, 18, 782, DateTimeKind.Local).AddTicks(7816), new DateTime(2024, 10, 19, 19, 37, 18, 782, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "TransactTime" },
                values: new object[] { new DateTime(2024, 10, 19, 19, 37, 18, 782, DateTimeKind.Local).AddTicks(7819), new DateTime(2024, 10, 19, 19, 37, 18, 782, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "TransactTime" },
                values: new object[] { new DateTime(2024, 10, 19, 19, 37, 18, 782, DateTimeKind.Local).AddTicks(7821), new DateTime(2024, 10, 19, 19, 37, 18, 782, DateTimeKind.Local).AddTicks(7820) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "Orders",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "TransactTime" },
                values: new object[] { new DateTime(2024, 10, 19, 18, 55, 32, 978, DateTimeKind.Local).AddTicks(9089), new DateTime(2024, 10, 19, 18, 55, 32, 978, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "TransactTime" },
                values: new object[] { new DateTime(2024, 10, 19, 18, 55, 32, 978, DateTimeKind.Local).AddTicks(9093), new DateTime(2024, 10, 19, 18, 55, 32, 978, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "TransactTime" },
                values: new object[] { new DateTime(2024, 10, 19, 18, 55, 32, 978, DateTimeKind.Local).AddTicks(9097), new DateTime(2024, 10, 19, 18, 55, 32, 978, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "TransactTime" },
                values: new object[] { new DateTime(2024, 10, 19, 18, 55, 32, 978, DateTimeKind.Local).AddTicks(9099), new DateTime(2024, 10, 19, 18, 55, 32, 978, DateTimeKind.Local).AddTicks(9098) });
        }
    }
}
