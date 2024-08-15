using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VconfigDotnet.Migrations
{
    /// <inheritdoc />
    public partial class one : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_components_CompId",
                table: "alternate_components");

            migrationBuilder.DropForeignKey(
                name: "FK_alternate_components_models_ModId",
                table: "alternate_components");

            migrationBuilder.DropForeignKey(
                name: "FK_manufacturers_segments_SegId",
                table: "manufacturers");

            migrationBuilder.DropForeignKey(
                name: "FK_models_manufacturers_ManuId",
                table: "models");

            migrationBuilder.DropForeignKey(
                name: "FK_models_segments_SegId",
                table: "models");

            migrationBuilder.DropForeignKey(
                name: "FK_vehicles_components_CompId",
                table: "vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_vehicles_models_ModId",
                table: "vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vehicles",
                table: "vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_models",
                table: "models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_manufacturers",
                table: "manufacturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_invoices",
                table: "invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_components",
                table: "components");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_alternate_components",
                table: "alternate_components");

            migrationBuilder.RenameTable(
                name: "vehicles",
                newName: "Vehicles");

            migrationBuilder.RenameTable(
                name: "models",
                newName: "Models");

            migrationBuilder.RenameTable(
                name: "manufacturers",
                newName: "Manufacturers");

            migrationBuilder.RenameTable(
                name: "invoices",
                newName: "Invoices");

            migrationBuilder.RenameTable(
                name: "components",
                newName: "Components");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "alternate_components",
                newName: "AlternateComponents");

            migrationBuilder.RenameIndex(
                name: "IX_vehicles_ModId",
                table: "Vehicles",
                newName: "IX_Vehicles_ModId");

            migrationBuilder.RenameIndex(
                name: "IX_vehicles_CompId",
                table: "Vehicles",
                newName: "IX_Vehicles_CompId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "segments",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_models_SegId",
                table: "Models",
                newName: "IX_Models_SegId");

            migrationBuilder.RenameIndex(
                name: "IX_models_ManuId",
                table: "Models",
                newName: "IX_Models_ManuId");

            migrationBuilder.RenameIndex(
                name: "IX_manufacturers_SegId",
                table: "Manufacturers",
                newName: "IX_Manufacturers_SegId");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Userid");

            migrationBuilder.RenameIndex(
                name: "IX_alternate_components_ModId",
                table: "AlternateComponents",
                newName: "IX_AlternateComponents_ModId");

            migrationBuilder.RenameIndex(
                name: "IX_alternate_components_CompId",
                table: "AlternateComponents",
                newName: "IX_AlternateComponents_CompId");

            migrationBuilder.AlterColumn<string>(
                name: "IsConfigurable",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "enum('N','Y')");

            migrationBuilder.AlterColumn<string>(
                name: "CompType",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "enum('A','E','I','S')");

            migrationBuilder.AlterColumn<string>(
                name: "SegName",
                table: "segments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "SafetyRating",
                table: "Models",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModName",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "ManuName",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<byte[]>(
                name: "AltCompId",
                table: "Invoices",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompName",
                table: "Components",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "PinCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "GstNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "Userid",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "ModelId",
                table: "AlternateComponents",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Components",
                table: "Components",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Userid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlternateComponents",
                table: "AlternateComponents",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AlternateComponents_AltCompId",
                table: "AlternateComponents",
                column: "AltCompId");

            migrationBuilder.CreateIndex(
                name: "IX_AlternateComponents_ModelId",
                table: "AlternateComponents",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlternateComponents_Components_AltCompId",
                table: "AlternateComponents",
                column: "AltCompId",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_AlternateComponents_Models_ModelId",
                table: "AlternateComponents",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Manufacturers_segments_SegId",
                table: "Manufacturers",
                column: "SegId",
                principalTable: "segments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlternateComponents_Components_AltCompId",
                table: "AlternateComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_AlternateComponents_Components_CompId",
                table: "AlternateComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_AlternateComponents_Models_ModId",
                table: "AlternateComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_AlternateComponents_Models_ModelId",
                table: "AlternateComponents");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Components",
                table: "Components");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlternateComponents",
                table: "AlternateComponents");

            migrationBuilder.DropIndex(
                name: "IX_AlternateComponents_AltCompId",
                table: "AlternateComponents");

            migrationBuilder.DropIndex(
                name: "IX_AlternateComponents_ModelId",
                table: "AlternateComponents");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "AlternateComponents");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "vehicles");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "models");

            migrationBuilder.RenameTable(
                name: "Manufacturers",
                newName: "manufacturers");

            migrationBuilder.RenameTable(
                name: "Invoices",
                newName: "invoices");

            migrationBuilder.RenameTable(
                name: "Components",
                newName: "components");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "user");

            migrationBuilder.RenameTable(
                name: "AlternateComponents",
                newName: "alternate_components");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_ModId",
                table: "vehicles",
                newName: "IX_vehicles_ModId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_CompId",
                table: "vehicles",
                newName: "IX_vehicles_CompId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "segments",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Models_SegId",
                table: "models",
                newName: "IX_models_SegId");

            migrationBuilder.RenameIndex(
                name: "IX_Models_ManuId",
                table: "models",
                newName: "IX_models_ManuId");

            migrationBuilder.RenameIndex(
                name: "IX_Manufacturers_SegId",
                table: "manufacturers",
                newName: "IX_manufacturers_SegId");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "user",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Userid",
                table: "user",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AlternateComponents_ModId",
                table: "alternate_components",
                newName: "IX_alternate_components_ModId");

            migrationBuilder.RenameIndex(
                name: "IX_AlternateComponents_CompId",
                table: "alternate_components",
                newName: "IX_alternate_components_CompId");

            migrationBuilder.AlterColumn<string>(
                name: "IsConfigurable",
                table: "vehicles",
                type: "enum('N','Y')",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompType",
                table: "vehicles",
                type: "enum('A','E','I','S')",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SegName",
                table: "segments",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SafetyRating",
                table: "models",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModName",
                table: "models",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "models",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ManuName",
                table: "manufacturers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "AltCompId",
                table: "invoices",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompName",
                table: "components",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "user",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "user",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "user",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "user",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PinCode",
                table: "user",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GstNumber",
                table: "user",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "user",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "user",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "user",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "user",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "user",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "user",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vehicles",
                table: "vehicles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_models",
                table: "models",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_manufacturers",
                table: "manufacturers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_invoices",
                table: "invoices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_components",
                table: "components",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_alternate_components",
                table: "alternate_components",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_components_CompId",
                table: "alternate_components",
                column: "CompId",
                principalTable: "components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_alternate_components_models_ModId",
                table: "alternate_components",
                column: "ModId",
                principalTable: "models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_manufacturers_segments_SegId",
                table: "manufacturers",
                column: "SegId",
                principalTable: "segments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_models_manufacturers_ManuId",
                table: "models",
                column: "ManuId",
                principalTable: "manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_models_segments_SegId",
                table: "models",
                column: "SegId",
                principalTable: "segments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vehicles_components_CompId",
                table: "vehicles",
                column: "CompId",
                principalTable: "components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vehicles_models_ModId",
                table: "vehicles",
                column: "ModId",
                principalTable: "models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
