using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DutyDbLibrary.Migrations
{
    public partial class updateRelationshipBetweenProjectAndDutyToAddBackRefFromDutyToProjectAndSetNullOnDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Duties_Projects_ProjectId",
                table: "Duties");

            migrationBuilder.AddForeignKey(
                name: "FK_Duties_Projects_ProjectId",
                table: "Duties",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Duties_Projects_ProjectId",
                table: "Duties");

            migrationBuilder.AddForeignKey(
                name: "FK_Duties_Projects_ProjectId",
                table: "Duties",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }
    }
}
