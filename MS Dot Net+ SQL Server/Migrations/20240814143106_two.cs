using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VconfigDotnet.Migrations
{
    /// <inheritdoc />
    public partial class two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlternateComponents_Components_CompId",
                table: "AlternateComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_AlternateComponents_Models_ModId",
                table: "AlternateComponents");

            migrationBuilder.AddForeignKey(
                name: "FK_AlternateComponents_Components_CompId",
                table: "AlternateComponents",
                column: "CompId",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AlternateComponents_Models_ModId",
                table: "AlternateComponents",
                column: "ModId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlternateComponents_Components_CompId",
                table: "AlternateComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_AlternateComponents_Models_ModId",
                table: "AlternateComponents");

            migrationBuilder.AddForeignKey(
                name: "FK_AlternateComponents_Components_CompId",
                table: "AlternateComponents",
                column: "CompId",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlternateComponents_Models_ModId",
                table: "AlternateComponents",
                column: "ModId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
