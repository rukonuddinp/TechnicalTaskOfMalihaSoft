using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Technical_Task.Migrations
{
    public partial class addcheckbox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "Step2s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "Step1s",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "Step2s");

            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "Step1s");
        }
    }
}
