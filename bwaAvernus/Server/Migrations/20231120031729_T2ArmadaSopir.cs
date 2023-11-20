using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bwaAvernus.Server.Migrations
{
    /// <inheritdoc />
    public partial class T2ArmadaSopir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JenisHargaDiskon",
                table: "T7OrderPembelian",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Kuantum_DiskonBarang_WaktuInsert",
                table: "T7OrderPembelian",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Kuantum_HargaBarang_WaktuInsert",
                table: "T7OrderPembelian",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Kuantum_IdDiskonBarang",
                table: "T7OrderPembelian",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Kuantum_IdHargaBarang",
                table: "T7OrderPembelian",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kuantum_JenisHargaDiskon",
                table: "T7OrderPembelian",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true);


            migrationBuilder.CreateTable(
                name: "T2ArmadaSopir",
                columns: table => new
                {
                    IdArmadaSopir = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKaryawan_Sopir = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T2ArmadaSopir", x => x.IdArmadaSopir);
                    table.ForeignKey(
                        name: "FK_T2ArmadaSopir_T1Armada_IdArmada",
                        column: x => x.IdArmada,
                        principalTable: "T1Armada",
                        principalColumn: "IdArmada");
                    table.ForeignKey(
                        name: "FK_T2ArmadaSopir_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2ArmadaSopir_T1Karyawan_IdKaryawan_Sopir",
                        column: x => x.IdKaryawan_Sopir,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2ArmadaSopir_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2ArmadaSopir_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateIndex(
                name: "IX_T1Supplier_IdKecamatan",
                table: "T1Supplier",
                column: "IdKecamatan");

            migrationBuilder.CreateIndex(
                name: "IX_T1Supplier_IdKelurahan",
                table: "T1Supplier",
                column: "IdKelurahan");

            migrationBuilder.CreateIndex(
                name: "IX_T1Supplier_IdNegara",
                table: "T1Supplier",
                column: "IdNegara");

            migrationBuilder.CreateIndex(
                name: "IX_T1Supplier_IdSektorNegara",
                table: "T1Supplier",
                column: "IdSektorNegara");

            migrationBuilder.CreateIndex(
                name: "IX_T2ArmadaSopir_IdArmada",
                table: "T2ArmadaSopir",
                column: "IdArmada");

            migrationBuilder.CreateIndex(
                name: "IX_T2ArmadaSopir_IdCreator",
                table: "T2ArmadaSopir",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T2ArmadaSopir_IdKaryawan_Sopir",
                table: "T2ArmadaSopir",
                column: "IdKaryawan_Sopir");

            migrationBuilder.CreateIndex(
                name: "IX_T2ArmadaSopir_IdOperator",
                table: "T2ArmadaSopir",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T2ArmadaSopir_IdValidator",
                table: "T2ArmadaSopir",
                column: "IdValidator");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Supplier_T0Negara_IdNegara",
                table: "T1Supplier",
                column: "IdNegara",
                principalTable: "T0Negara",
                principalColumn: "IdNegara");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Supplier_T0SektorNegara_IdSektorNegara",
                table: "T1Supplier",
                column: "IdSektorNegara",
                principalTable: "T0SektorNegara",
                principalColumn: "IdSektorKota");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Supplier_T3Kecamatan_IdKecamatan",
                table: "T1Supplier",
                column: "IdKecamatan",
                principalTable: "T3Kecamatan",
                principalColumn: "IdKecamatan");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Supplier_T4Kelurahan_IdKelurahan",
                table: "T1Supplier",
                column: "IdKelurahan",
                principalTable: "T4Kelurahan",
                principalColumn: "IdKelurahan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T1Supplier_T0Negara_IdNegara",
                table: "T1Supplier");

            migrationBuilder.DropForeignKey(
                name: "FK_T1Supplier_T0SektorNegara_IdSektorNegara",
                table: "T1Supplier");

            migrationBuilder.DropForeignKey(
                name: "FK_T1Supplier_T3Kecamatan_IdKecamatan",
                table: "T1Supplier");

            migrationBuilder.DropForeignKey(
                name: "FK_T1Supplier_T4Kelurahan_IdKelurahan",
                table: "T1Supplier");

            migrationBuilder.DropTable(
                name: "T2ArmadaSopir");

            migrationBuilder.DropIndex(
                name: "IX_T1Supplier_IdKecamatan",
                table: "T1Supplier");

            migrationBuilder.DropIndex(
                name: "IX_T1Supplier_IdKelurahan",
                table: "T1Supplier");

            migrationBuilder.DropIndex(
                name: "IX_T1Supplier_IdNegara",
                table: "T1Supplier");

            migrationBuilder.DropIndex(
                name: "IX_T1Supplier_IdSektorNegara",
                table: "T1Supplier");

            migrationBuilder.DropColumn(
                name: "JenisHargaDiskon",
                table: "T7OrderPembelian");

            migrationBuilder.DropColumn(
                name: "Kuantum_DiskonBarang_WaktuInsert",
                table: "T7OrderPembelian");

            migrationBuilder.DropColumn(
                name: "Kuantum_HargaBarang_WaktuInsert",
                table: "T7OrderPembelian");

            migrationBuilder.DropColumn(
                name: "Kuantum_IdDiskonBarang",
                table: "T7OrderPembelian");

            migrationBuilder.DropColumn(
                name: "Kuantum_IdHargaBarang",
                table: "T7OrderPembelian");

            migrationBuilder.DropColumn(
                name: "Kuantum_JenisHargaDiskon",
                table: "T7OrderPembelian");

            migrationBuilder.DropColumn(
                name: "IdJadwalKerjaKaryawan",
                table: "T1Karyawan");
        }
    }
}
