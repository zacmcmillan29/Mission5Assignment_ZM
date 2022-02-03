using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4Assignment_ZM.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "Responses",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Title",
                keyValue: "Inception",
                column: "Year",
                value: 2010);

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Title",
                keyValue: "Rudy",
                column: "Year",
                value: 1993);

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Title",
                keyValue: "The Lion King",
                column: "Year",
                value: 1994);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "Responses",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Title",
                keyValue: "Inception",
                column: "Year",
                value: "2010");

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Title",
                keyValue: "Rudy",
                column: "Year",
                value: "1993");

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Title",
                keyValue: "The Lion King",
                column: "Year",
                value: "1994");
        }
    }
}
