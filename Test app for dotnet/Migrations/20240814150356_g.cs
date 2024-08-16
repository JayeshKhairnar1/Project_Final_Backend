using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VconfigDotnet.Migrations
{
    /// <inheritdoc />
    public partial class g : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlternateComponents_Components_AltCompId",
                table: "AlternateComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Manufacturers_ManuId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_segments_SegId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_AlternateComponents_AltCompId",
                table: "AlternateComponents");

            migrationBuilder.RenameColumn(
                name: "AltCompId",
                table: "AlternateComponents",
                newName: "LogicKey");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Manufacturers_ManuId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_segments_SegId",
                table: "Models");

            migrationBuilder.RenameColumn(
                name: "LogicKey",
                table: "AlternateComponents",
                newName: "AltCompId");

            migrationBuilder.CreateIndex(
                name: "IX_AlternateComponents_AltCompId",
                table: "AlternateComponents",
                column: "AltCompId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlternateComponents_Components_AltCompId",
                table: "AlternateComponents",
                column: "AltCompId",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
    }
}
