using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VconfigDotnet.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
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
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AltCompId = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    OrderedQty = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ModelPrice = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "segments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SegName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_segments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Userid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GstNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PinCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Userid);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manufacturers_segments_SegId",
                        column: x => x.SegId,
                        principalTable: "segments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinQty = table.Column<int>(type: "int", nullable: false),
                    ModName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    SafetyRating = table.Column<int>(type: "int", nullable: true),
                    ManuId = table.Column<long>(type: "bigint", nullable: false),
                    SegId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Manufacturers_ManuId",
                        column: x => x.ManuId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Models_segments_SegId",
                        column: x => x.SegId,
                        principalTable: "segments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlternateComponents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeltaPrice = table.Column<double>(type: "float", nullable: false),
                    CompId = table.Column<long>(type: "bigint", nullable: false),
                    ModId = table.Column<long>(type: "bigint", nullable: false),
                    AltCompId = table.Column<long>(type: "bigint", nullable: true),
                    ModelId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlternateComponents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlternateComponents_Components_AltCompId",
                        column: x => x.AltCompId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AlternateComponents_Components_CompId",
                        column: x => x.CompId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AlternateComponents_Models_ModId",
                        column: x => x.ModId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AlternateComponents_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsConfigurable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompId = table.Column<long>(type: "bigint", nullable: false),
                    ModId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Components_CompId",
                        column: x => x.CompId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_Models_ModId",
                        column: x => x.ModId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlternateComponents_AltCompId",
                table: "AlternateComponents",
                column: "AltCompId");

            migrationBuilder.CreateIndex(
                name: "IX_AlternateComponents_CompId",
                table: "AlternateComponents",
                column: "CompId");

            migrationBuilder.CreateIndex(
                name: "IX_AlternateComponents_ModelId",
                table: "AlternateComponents",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AlternateComponents_ModId",
                table: "AlternateComponents",
                column: "ModId");

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_SegId",
                table: "Manufacturers",
                column: "SegId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_ManuId",
                table: "Models",
                column: "ManuId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_SegId",
                table: "Models",
                column: "SegId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CompId",
                table: "Vehicles",
                column: "CompId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ModId",
                table: "Vehicles",
                column: "ModId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlternateComponents");

            migrationBuilder.DropTable(
                name: "car_description");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "segments");
        }
    }
}
