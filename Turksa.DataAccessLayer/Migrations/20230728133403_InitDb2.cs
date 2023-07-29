using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turksa.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitDb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategoriler_Stoklar_StokId",
                table: "Kategoriler");

            migrationBuilder.DropIndex(
                name: "IX_Kategoriler_StokId",
                table: "Kategoriler");

            migrationBuilder.DropColumn(
                name: "StokId",
                table: "Kategoriler");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Vergiler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 28, 16, 34, 3, 757, DateTimeKind.Local).AddTicks(1545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "UrunAgaclari",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 28, 16, 34, 3, 757, DateTimeKind.Local).AddTicks(237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Stoklar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 28, 16, 34, 3, 756, DateTimeKind.Local).AddTicks(7987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "UrunAgaciId",
                table: "Stoklar",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kategoriler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 28, 16, 34, 3, 756, DateTimeKind.Local).AddTicks(6530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Birimler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 28, 16, 34, 3, 756, DateTimeKind.Local).AddTicks(3094),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "Cari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CariKod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CariAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiDairesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VergiNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 28, 16, 34, 3, 756, DateTimeKind.Local).AddTicks(4785))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KategoriStok",
                columns: table => new
                {
                    KategorilerId = table.Column<int>(type: "int", nullable: false),
                    StoklarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriStok", x => new { x.KategorilerId, x.StoklarId });
                    table.ForeignKey(
                        name: "FK_KategoriStok_Kategoriler_KategorilerId",
                        column: x => x.KategorilerId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KategoriStok_Stoklar_StoklarId",
                        column: x => x.StoklarId,
                        principalTable: "Stoklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: true),
                    Gsm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kisi_Cari_CariId",
                        column: x => x.CariId,
                        principalTable: "Cari",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdresTipi = table.Column<byte>(type: "tinyint", nullable: true),
                    Sehir = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CaddeSokak = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CariId = table.Column<int>(type: "int", nullable: false),
                    KisiId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 28, 16, 34, 3, 755, DateTimeKind.Local).AddTicks(9979))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adres_Cari_CariId",
                        column: x => x.CariId,
                        principalTable: "Cari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adres_Kisi_KisiId",
                        column: x => x.KisiId,
                        principalTable: "Kisi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stoklar_UrunAgaciId",
                table: "Stoklar",
                column: "UrunAgaciId");

            migrationBuilder.CreateIndex(
                name: "IX_Adres_CariId",
                table: "Adres",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Adres_KisiId",
                table: "Adres",
                column: "KisiId");

            migrationBuilder.CreateIndex(
                name: "IX_KategoriStok_StoklarId",
                table: "KategoriStok",
                column: "StoklarId");

            migrationBuilder.CreateIndex(
                name: "IX_Kisi_CariId",
                table: "Kisi",
                column: "CariId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stoklar_UrunAgaclari_UrunAgaciId",
                table: "Stoklar",
                column: "UrunAgaciId",
                principalTable: "UrunAgaclari",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stoklar_UrunAgaclari_UrunAgaciId",
                table: "Stoklar");

            migrationBuilder.DropTable(
                name: "Adres");

            migrationBuilder.DropTable(
                name: "KategoriStok");

            migrationBuilder.DropTable(
                name: "Kisi");

            migrationBuilder.DropTable(
                name: "Cari");

            migrationBuilder.DropIndex(
                name: "IX_Stoklar_UrunAgaciId",
                table: "Stoklar");

            migrationBuilder.DropColumn(
                name: "UrunAgaciId",
                table: "Stoklar");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Vergiler",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 28, 16, 34, 3, 757, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "UrunAgaclari",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 28, 16, 34, 3, 757, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Stoklar",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 28, 16, 34, 3, 756, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kategoriler",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 28, 16, 34, 3, 756, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.AddColumn<int>(
                name: "StokId",
                table: "Kategoriler",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Birimler",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 28, 16, 34, 3, 756, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_StokId",
                table: "Kategoriler",
                column: "StokId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kategoriler_Stoklar_StokId",
                table: "Kategoriler",
                column: "StokId",
                principalTable: "Stoklar",
                principalColumn: "Id");
        }
    }
}
