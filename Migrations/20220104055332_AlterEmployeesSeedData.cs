﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Migrations
{
    public partial class AlterEmployeesSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Email", "Name" },
                values: new object[] { "mary@gmail.com", "Mary" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Department", "Email", "Name" },
                values: new object[] { 2, 1, "john@gmail.com", "John" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Email", "Name" },
                values: new object[] { "mark@gmail.com", "Mark" });
        }
    }
}
