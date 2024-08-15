using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VconfigDotnet.Migrations
{
    /// <inheritdoc />
    public partial class StarterTemplate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "car_description",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car_description", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "components",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_components", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AltCompId = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    ModelPrice = table.Column<int>(type: "int", nullable: false),
                    OrderedQty = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "segments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SegName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_segments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GstNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PinCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "manufacturers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManuName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SegId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manufacturers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_manufacturers_segments_SegId",
                        column: x => x.SegId,
                        principalTable: "segments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "models",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MinQty = table.Column<int>(type: "int", nullable: false),
                    ModName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    SafetyRating = table.Column<int>(type: "int", nullable: false),
                    ManuId = table.Column<long>(type: "bigint", nullable: false),
                    SegId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_models_manufacturers_ManuId",
                        column: x => x.ManuId,
                        principalTable: "manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_models_segments_SegId",
                        column: x => x.SegId,
                        principalTable: "segments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "alternate_components",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeltaPrice = table.Column<double>(type: "float", nullable: false),
                    CompId = table.Column<long>(type: "bigint", nullable: false),
                    ModId = table.Column<long>(type: "bigint", nullable: false),
                    AltCompId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alternate_components", x => x.Id);
                    table.ForeignKey(
                        name: "FK_alternate_components_components_CompId",
                        column: x => x.CompId,
                        principalTable: "components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_alternate_components_models_ModId",
                        column: x => x.ModId,
                        principalTable: "models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompType = table.Column<string>(type: "enum('A','E','I','S')", nullable: false),
                    IsConfigurable = table.Column<string>(type: "enum('N','Y')", nullable: false),
                    CompId = table.Column<long>(type: "bigint", nullable: false),
                    ModId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vehicles_components_CompId",
                        column: x => x.CompId,
                        principalTable: "components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehicles_models_ModId",
                        column: x => x.ModId,
                        principalTable: "models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_alternate_components_CompId",
                table: "alternate_components",
                column: "CompId");

            migrationBuilder.CreateIndex(
                name: "IX_alternate_components_ModId",
                table: "alternate_components",
                column: "ModId");

            migrationBuilder.CreateIndex(
                name: "IX_manufacturers_SegId",
                table: "manufacturers",
                column: "SegId");

            migrationBuilder.CreateIndex(
                name: "IX_models_ManuId",
                table: "models",
                column: "ManuId");

            migrationBuilder.CreateIndex(
                name: "IX_models_SegId",
                table: "models",
                column: "SegId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_CompId",
                table: "vehicles",
                column: "CompId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_ModId",
                table: "vehicles",
                column: "ModId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alternate_components");

            migrationBuilder.DropTable(
                name: "car_description");

            migrationBuilder.DropTable(
                name: "invoices");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "vehicles");

            migrationBuilder.DropTable(
                name: "components");

            migrationBuilder.DropTable(
                name: "models");

            migrationBuilder.DropTable(
                name: "manufacturers");

            migrationBuilder.DropTable(
                name: "segments");
        }
    }
}
