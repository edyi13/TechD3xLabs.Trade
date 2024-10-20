using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechD3xLabs.Trade.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AlterInitialScheme2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "TransactTime" },
                values: new object[] { new DateTime(2024, 10, 19, 19, 44, 54, 665, DateTimeKind.Local).AddTicks(6739), new DateTime(2024, 10, 19, 19, 44, 54, 665, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "TransactTime" },
                values: new object[] { new DateTime(2024, 10, 19, 19, 44, 54, 665, DateTimeKind.Local).AddTicks(6744), new DateTime(2024, 10, 19, 19, 44, 54, 665, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "TransactTime" },
                values: new object[] { new DateTime(2024, 10, 19, 19, 44, 54, 665, DateTimeKind.Local).AddTicks(6746), new DateTime(2024, 10, 19, 19, 44, 54, 665, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "TransactTime" },
                values: new object[] { new DateTime(2024, 10, 19, 19, 44, 54, 665, DateTimeKind.Local).AddTicks(6748), new DateTime(2024, 10, 19, 19, 44, 54, 665, DateTimeKind.Local).AddTicks(6747) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
