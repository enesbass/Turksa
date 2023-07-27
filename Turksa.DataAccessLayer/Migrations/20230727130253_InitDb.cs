using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turksa.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirimAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birimler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UrunAgaclari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunAgaclari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vergiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VergiAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Oran = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vergiler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stoklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StokKodu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StokAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirimId = table.Column<int>(type: "int", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Adet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VergiOraniId = table.Column<int>(type: "int", nullable: true),
                    Stoktipi = table.Column<byte>(type: "tinyint", nullable: false),
                    UstUrunId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stoklar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stoklar_Birimler_BirimId",
                        column: x => x.BirimId,
                        principalTable: "Birimler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stoklar_Stoklar_UstUrunId",
                        column: x => x.UstUrunId,
                        principalTable: "Stoklar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stoklar_Vergiler_VergiOraniId",
                        column: x => x.VergiOraniId,
                        principalTable: "Vergiler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UstKategoriId = table.Column<int>(type: "int", nullable: true),
                    StokId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kategoriler_Kategoriler_UstKategoriId",
                        column: x => x.UstKategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kategoriler_Stoklar_StokId",
                        column: x => x.StokId,
                        principalTable: "Stoklar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_StokId",
                table: "Kategoriler",
                column: "StokId");

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_UstKategoriId",
                table: "Kategoriler",
                column: "UstKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Stoklar_BirimId",
                table: "Stoklar",
                column: "BirimId");

            migrationBuilder.CreateIndex(
                name: "IX_Stoklar_StokKodu",
                table: "Stoklar",
                column: "StokKodu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stoklar_UstUrunId",
                table: "Stoklar",
                column: "UstUrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Stoklar_VergiOraniId",
                table: "Stoklar",
                column: "VergiOraniId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "UrunAgaclari");

            migrationBuilder.DropTable(
                name: "Stoklar");

            migrationBuilder.DropTable(
                name: "Birimler");

            migrationBuilder.DropTable(
                name: "Vergiler");
        }
    }
}
