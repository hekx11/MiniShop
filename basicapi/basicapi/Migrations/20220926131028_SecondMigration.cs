using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace basicapi.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "EndPoints",
                newName: "Type");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "EndPoints",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Filename",
                table: "EndPoints",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "EndPoints",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "EndPoints",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "EndPoints",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "EndPoints");

            migrationBuilder.DropColumn(
                name: "Filename",
                table: "EndPoints");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "EndPoints");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "EndPoints");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "EndPoints");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "EndPoints",
                newName: "Name");
        }
    }
}
