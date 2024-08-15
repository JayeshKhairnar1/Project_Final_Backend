using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VconfigDotnet.Migrations
{
    /// <inheritdoc />
    public partial class i : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manufacturers_segments_SegId",
                table: "Manufacturers");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Manufacturers_ManuId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_segments_SegId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Components_CompId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Models_ModId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_segments",
                table: "segments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_car_description",
                table: "car_description");

            migrationBuilder.RenameTable(
                name: "segments",
                newName: "Segments");

            migrationBuilder.RenameTable(
                name: "car_description",
                newName: "CarDescriptions");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Userid",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Segments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LogicKey",
                table: "AlternateComponents",
                newName: "AltCompId");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PinCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GstNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "SegName",
                table: "Segments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SafetyRating",
                table: "Models",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Models",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "SegId",
                table: "Manufacturers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ManuName",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompName",
                table: "Components",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "CarDescriptions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CarName",
                table: "CarDescriptions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Segments",
                table: "Segments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarDescriptions",
                table: "CarDescriptions",
                column: "Id");

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
                name: "FK_Manufacturers_Segments_SegId",
                table: "Manufacturers",
                column: "SegId",
                principalTable: "Segments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_CarDescriptions_Id",
                table: "Models",
                column: "Id",
                principalTable: "CarDescriptions",
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
                name: "FK_Models_Segments_SegId",
                table: "Models",
                column: "SegId",
                principalTable: "Segments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Components_CompId",
                table: "Vehicles",
                column: "CompId",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Models_ModId",
                table: "Vehicles",
                column: "ModId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlternateComponents_Components_AltCompId",
                table: "AlternateComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_Manufacturers_Segments_SegId",
                table: "Manufacturers");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_CarDescriptions_Id",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Manufacturers_ManuId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Segments_SegId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Components_CompId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Models_ModId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Segments",
                table: "Segments");

            migrationBuilder.DropIndex(
                name: "IX_AlternateComponents_AltCompId",
                table: "AlternateComponents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarDescriptions",
                table: "CarDescriptions");

            migrationBuilder.RenameTable(
                name: "Segments",
                newName: "segments");

            migrationBuilder.RenameTable(
                name: "CarDescriptions",
                newName: "car_description");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Userid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "segments",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "AltCompId",
                table: "AlternateComponents",
                newName: "LogicKey");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PinCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GstNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Userid",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "SegName",
                table: "segments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SafetyRating",
                table: "Models",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Models",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "SegId",
                table: "Manufacturers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ManuName",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompName",
                table: "Components",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "car_description",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CarName",
                table: "car_description",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_segments",
                table: "segments",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_car_description",
                table: "car_description",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AltCompId = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    ModelPrice = table.Column<int>(type: "int", nullable: false),
                    OrderedQty = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Manufacturers_segments_SegId",
                table: "Manufacturers",
                column: "SegId",
                principalTable: "segments",
                principalColumn: "id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Components_CompId",
                table: "Vehicles",
                column: "CompId",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Models_ModId",
                table: "Vehicles",
                column: "ModId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
