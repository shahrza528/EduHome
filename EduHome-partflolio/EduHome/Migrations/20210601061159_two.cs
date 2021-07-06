using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Assesment",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Assesment",
                table: "Courses",
                column: "Assesment");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Assesments_Assesment",
                table: "Courses",
                column: "Assesment",
                principalTable: "Assesments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Assesments_Assesment",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Assesment",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Assesment",
                table: "Courses");
        }
    }
}
