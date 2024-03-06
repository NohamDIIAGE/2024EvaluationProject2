using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _2024Evaluation.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NewDatasTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Date", "Description", "Location", "Time", "Title" },
                values: new object[,]
                {
                    { 4, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Utc), "I'm the Description of the fourth event", "I'm the location of the fourth event", new TimeSpan(0, 8, 15, 35, 0), "MyFourthEvent" },
                    { 5, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), "I'm the Description of the fifth event", "I'm the location of the fifth event", new TimeSpan(0, 9, 10, 50, 0), "MyFifthEvent" },
                    { 6, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Utc), "I'm the Description of the sixth event", "I'm the location of the sixth event", new TimeSpan(0, 10, 5, 15, 0), "MySixthEvent" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
