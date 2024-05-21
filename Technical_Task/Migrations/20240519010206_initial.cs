using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Technical_Task.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Step1s",
                columns: table => new
                {
                    Step1Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Step1Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step1s", x => x.Step1Id);
                });

            migrationBuilder.CreateTable(
                name: "Step2s",
                columns: table => new
                {
                    Step2Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Step2Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step2s", x => x.Step2Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Step1s");

            migrationBuilder.DropTable(
                name: "Step2s");
        }
    }
}
