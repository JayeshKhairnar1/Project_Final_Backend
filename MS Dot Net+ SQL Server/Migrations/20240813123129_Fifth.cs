using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VconfigDotnet.Migrations
{
    /// <inheritdoc />
    public partial class Fifth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarDescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_invoices",
                table: "invoices");

            migrationBuilder.RenameTable(
                name: "invoices",
                newName: "Invoices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.RenameTable(
                name: "Invoices",
                newName: "invoices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_invoices",
                table: "invoices",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CarDescriptions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDescriptions", x => x.Id);
                });
        }
    }
}
