using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DutyDbLibrary.Migrations
{
    public partial class updatedRelationshipBetweenTeamAndProjectToSetDeleteBehaviorToSetNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Teams_AssignedId",
                table: "Projects");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Teams_AssignedId",
                table: "Projects",
                column: "AssignedId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Teams_AssignedId",
                table: "Projects");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Teams_AssignedId",
                table: "Projects",
                column: "AssignedId",
                principalTable: "Teams",
                principalColumn: "Id");
        }
    }
}
