using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Data.Migrations
{
    public partial class fixer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ranking",
                table: "Movie");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Movie",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ranking",
                table: "Movie",
                nullable: false,
                defaultValue: 0);
        }
    }
}
