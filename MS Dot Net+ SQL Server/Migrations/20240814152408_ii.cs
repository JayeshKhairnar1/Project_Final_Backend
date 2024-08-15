using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VconfigDotnet.Migrations
{
    /// <inheritdoc />
    public partial class ii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Segments_SegId",
                table: "Models");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Segments_SegId",
                table: "Models",
                column: "SegId",
                principalTable: "Segments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Segments_SegId",
                table: "Models");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Segments_SegId",
                table: "Models",
                column: "SegId",
                principalTable: "Segments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
