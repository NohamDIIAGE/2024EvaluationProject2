using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _2024Evaluation.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NewDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Date", "Description", "Location", "Time", "Title" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Utc), "I'm the Description of the second event", "I'm the location of the second event", new TimeSpan(0, 6, 30, 45, 0), "MySecondEvent" },
                    { 3, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), "I'm the Description of the third event", "I'm the location of the third event", new TimeSpan(0, 7, 20, 10, 0), "MyThirdEvent" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
