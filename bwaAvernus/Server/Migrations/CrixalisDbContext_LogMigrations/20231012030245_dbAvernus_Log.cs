using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bwaAvernus.Server.Migrations.CrixalisDbContext_LogMigrations
{
    /// <inheritdoc />
    public partial class dbAvernus_Log : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T9Log",
                columns: table => new
                {
                    IdLog = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdApplication = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdForm = table.Column<long>(type: "bigint", nullable: true),
                    IdPrimaryKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IPv4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPv6 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KodeInstruksi = table.Column<long>(type: "bigint", nullable: true),
                    JenisAktivitas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tabel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TabelDetil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PKDetil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Kolom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Aktivitas = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T9Log", x => x.IdLog);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T9Log");
        }
    }
}
