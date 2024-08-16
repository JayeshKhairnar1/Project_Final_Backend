using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VconfigDotnet.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlternateComponents_Models_ModelId",
                table: "AlternateComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Manufacturers_ManuId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_segments_SegId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_AlternateComponents_ModelId",
                table: "AlternateComponents");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "AlternateComponents");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Manufacturers_ManuId",
                table: "Models",
                column: "ManuId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_segments_SegId",
                table: "Models",
                column: "SegId",
                principalTable: "segments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Manufacturers_ManuId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_segments_SegId",
                table: "Models");

            migrationBuilder.AddColumn<long>(
                name: "ModelId",
                table: "AlternateComponents",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AlternateComponents_ModelId",
                table: "AlternateComponents",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlternateComponents_Models_ModelId",
                table: "AlternateComponents",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Manufacturers_ManuId",
                table: "Models",
                column: "ManuId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_segments_SegId",
                table: "Models",
                column: "SegId",
                principalTable: "segments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
