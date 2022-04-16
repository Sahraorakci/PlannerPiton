using Microsoft.EntityFrameworkCore.Migrations;

namespace PlannerPiton.DataAccessLayer.Migrations
{
    public partial class mig_deletetitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Titles_TitleID",
                table: "Events");

            migrationBuilder.AlterColumn<int>(
                name: "TitleID",
                table: "Events",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Titles_TitleID",
                table: "Events",
                column: "TitleID",
                principalTable: "Titles",
                principalColumn: "TitleID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Titles_TitleID",
                table: "Events");

            migrationBuilder.AlterColumn<int>(
                name: "TitleID",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Titles_TitleID",
                table: "Events",
                column: "TitleID",
                principalTable: "Titles",
                principalColumn: "TitleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
