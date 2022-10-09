using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DutyDbLibrary.Migrations
{
    public partial class updateDBConectedToSetCascadeDeleteSetToNullForEmployeeToDutiesRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Duties_Employees_AssignedId",
                table: "Duties");

            migrationBuilder.AddForeignKey(
                name: "FK_Duties_Employees_AssignedId",
                table: "Duties",
                column: "AssignedId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Duties_Employees_AssignedId",
                table: "Duties");

            migrationBuilder.AddForeignKey(
                name: "FK_Duties_Employees_AssignedId",
                table: "Duties",
                column: "AssignedId",
                principalTable: "Employees",
                principalColumn: "Id");
        }
    }
}
