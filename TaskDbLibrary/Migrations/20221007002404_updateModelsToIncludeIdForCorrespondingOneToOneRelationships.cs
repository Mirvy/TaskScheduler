using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DutyDbLibrary.Migrations
{
    public partial class updateModelsToIncludeIdForCorrespondingOneToOneRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Duties_Employees_AssignedId",
                table: "Duties");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Teams_AssignedId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "AssignedId",
                table: "Projects",
                newName: "TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_AssignedId",
                table: "Projects",
                newName: "IX_Projects_TeamId");

            migrationBuilder.RenameColumn(
                name: "AssignedId",
                table: "Duties",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Duties_AssignedId",
                table: "Duties",
                newName: "IX_Duties_EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Duties_Employees_EmployeeId",
                table: "Duties",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Teams_TeamId",
                table: "Projects",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Duties_Employees_EmployeeId",
                table: "Duties");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Teams_TeamId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Projects",
                newName: "AssignedId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_TeamId",
                table: "Projects",
                newName: "IX_Projects_AssignedId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Duties",
                newName: "AssignedId");

            migrationBuilder.RenameIndex(
                name: "IX_Duties_EmployeeId",
                table: "Duties",
                newName: "IX_Duties_AssignedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Duties_Employees_AssignedId",
                table: "Duties",
                column: "AssignedId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Teams_AssignedId",
                table: "Projects",
                column: "AssignedId",
                principalTable: "Teams",
                principalColumn: "Id");
        }
    }
}
