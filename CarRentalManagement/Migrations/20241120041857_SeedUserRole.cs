using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "ca2b6c8b-913c-4864-a433-ddb11ca46ff3", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOT4uNfO4EgH5iVAv2LzI+0Do+ELVlHc2n0bfXry80+Th9gMTlEHqBi+W9NUyFTQcg==", null, false, "3ceee1f3-da18-4cfa-9d31-4f92f4090877", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(3714), new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(3729), new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(3918), new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(3920), new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(4003), new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(4005), new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(4006), new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(4008), new DateTime(2024, 11, 20, 12, 18, 56, 465, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5138), new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5151), new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5309), new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5311), new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5375), new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5377), new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5378), new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5380), new DateTime(2024, 11, 20, 12, 9, 31, 431, DateTimeKind.Local).AddTicks(5380) });
        }
    }
}
