using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNet_AdoNet_Evaluation.Migrations
{
    public partial class ExpirationDateToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ExpirationDate",
                table: "Users",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
