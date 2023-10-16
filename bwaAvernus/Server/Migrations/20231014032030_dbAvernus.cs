using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bwaAvernus.Server.Migrations
{
    /// <inheritdoc />
    public partial class dbAvernus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T0Client",
                columns: table => new
                {
                    IdClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCompany = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Client = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Lokasi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SNHarddisk = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SNMainBoard = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SNProcessor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MacAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OSVersion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ComputerName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserAccount = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Spesifikasi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RemoteDesktop = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CloudStorage = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VPN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<long>(type: "bigint", nullable: true),
                    IdCreator = table.Column<long>(type: "bigint", nullable: true),
                    IdOperator = table.Column<long>(type: "bigint", nullable: true),
                    IdValidator = table.Column<long>(type: "bigint", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0Client", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "T0Form",
                columns: table => new
                {
                    IdForm = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdParent = table.Column<long>(type: "bigint", nullable: true),
                    Kategori = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Kode = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NamaTabel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NamaPK = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    NamaKolomUtama = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Icon = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CanLihatData = table.Column<bool>(type: "bit", nullable: true),
                    CanBatasLihatData = table.Column<bool>(type: "bit", nullable: true),
                    CanDataBaru = table.Column<bool>(type: "bit", nullable: true),
                    CanBatasDataBaru = table.Column<bool>(type: "bit", nullable: true),
                    CanUbahData = table.Column<bool>(type: "bit", nullable: true),
                    CanHapus = table.Column<bool>(type: "bit", nullable: true),
                    CanBatal = table.Column<bool>(type: "bit", nullable: true),
                    CanCetak = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CanSupervisi = table.Column<bool>(type: "bit", nullable: true),
                    CanInspeksi = table.Column<bool>(type: "bit", nullable: true),
                    CanLihatRekamanAktivitas = table.Column<bool>(type: "bit", nullable: true),
                    CanValidasi = table.Column<bool>(type: "bit", nullable: true),
                    Setting1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Setting2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Setting3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Setting4 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Setting5 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Setting6 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Setting21 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Setting22 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Setting23 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Setting24 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Setting25 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Setting26 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Setting31 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting32 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting33 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting34 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting35 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting36 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0Form", x => x.IdForm);
                });

            migrationBuilder.CreateTable(
                name: "T1Application",
                columns: table => new
                {
                    IdApplication = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdClient = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdServer = table.Column<long>(type: "bigint", nullable: true),
                    IdCompany = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ExecutablePath = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1Application", x => x.IdApplication);
                });

            migrationBuilder.CreateTable(
                name: "T9DataOption",
                columns: table => new
                {
                    IdDataOption = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataOption = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Parameter = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Entity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T9DataOption", x => x.IdDataOption);
                });

            migrationBuilder.CreateTable(
                name: "T9Privileges",
                columns: table => new
                {
                    IdKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdForm = table.Column<long>(type: "bigint", nullable: false),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: false),
                    Urutan = table.Column<byte>(type: "tinyint", nullable: true),
                    Grup = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BatasLihatData = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataBaru = table.Column<byte>(type: "tinyint", nullable: true),
                    BatasDataBaru = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Cetak = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Supervisi = table.Column<bool>(type: "bit", nullable: true),
                    Inspeksi = table.Column<bool>(type: "bit", nullable: true),
                    LihatRekamanAktivitas = table.Column<bool>(type: "bit", nullable: true),
                    ValidasiPassword = table.Column<bool>(type: "bit", nullable: true),
                    PoinApprove = table.Column<short>(type: "smallint", nullable: true),
                    PoinDecline = table.Column<short>(type: "smallint", nullable: true),
                    Setting1 = table.Column<bool>(type: "bit", nullable: true),
                    Setting2 = table.Column<bool>(type: "bit", nullable: true),
                    Setting3 = table.Column<bool>(type: "bit", nullable: true),
                    Setting4 = table.Column<bool>(type: "bit", nullable: true),
                    Setting5 = table.Column<bool>(type: "bit", nullable: true),
                    Setting6 = table.Column<bool>(type: "bit", nullable: true),
                    Setting21 = table.Column<byte>(type: "tinyint", nullable: true),
                    Setting22 = table.Column<byte>(type: "tinyint", nullable: true),
                    Setting23 = table.Column<byte>(type: "tinyint", nullable: true),
                    Setting24 = table.Column<byte>(type: "tinyint", nullable: true),
                    Setting25 = table.Column<byte>(type: "tinyint", nullable: true),
                    Setting26 = table.Column<byte>(type: "tinyint", nullable: true),
                    Setting31 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting32 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting33 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting34 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting35 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting36 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T9Privileges", x => new { x.IdKaryawan, x.IdForm, x.IdCompany });
                });

            migrationBuilder.CreateTable(
                name: "T9PrivilegesAksesData",
                columns: table => new
                {
                    IdKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdForm = table.Column<long>(type: "bigint", nullable: false),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: false),
                    IdAkses = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKaryawan_Tertentu = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCompany_Tertentu = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    Ubah = table.Column<byte>(type: "tinyint", nullable: true),
                    Hapus = table.Column<byte>(type: "tinyint", nullable: true),
                    Batal = table.Column<byte>(type: "tinyint", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T9PrivilegesAksesData", x => new { x.IdKaryawan, x.IdForm, x.IdCompany, x.IdAkses });
                });

            migrationBuilder.CreateTable(
                name: "T9SettingSystem",
                columns: table => new
                {
                    Setting = table.Column<string>(type: "varchar(900)", unicode: false, nullable: false),
                    Value = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BinaryValue = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IdOperator = table.Column<long>(type: "bigint", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T9SettingSystem", x => x.Setting);
                });

            migrationBuilder.CreateTable(
                name: "T9SettingUser",
                columns: table => new
                {
                    Setting = table.Column<string>(type: "varchar(900)", unicode: false, nullable: false),
                    IdCompany = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    IdKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BinaryValue = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Conditional = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T9SettingUser", x => new { x.Setting, x.IdCompany, x.IdKaryawan });
                });

            migrationBuilder.CreateTable(
                name: "T1DetilForm",
                columns: table => new
                {
                    IdDetilForm = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdForm = table.Column<long>(type: "bigint", nullable: false),
                    NamaTabelDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NamaKolomUtamaDetil = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1DetilForm", x => x.IdDetilForm);
                    table.ForeignKey(
                        name: "FK_T1DetilForm_T0Form_IdForm",
                        column: x => x.IdForm,
                        principalTable: "T0Form",
                        principalColumn: "IdForm",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T0Akun",
                columns: table => new
                {
                    IdAkun = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    IdParent = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdKurs = table.Column<long>(type: "bigint", nullable: true),
                    Kode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Akun = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Alias = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Pos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StatusResetSaatClosing = table.Column<bool>(type: "bit", nullable: true),
                    StatusNeracaPercobaan_Layar = table.Column<bool>(type: "bit", nullable: true),
                    StatusNeracaPercobaan_Cetak = table.Column<bool>(type: "bit", nullable: true),
                    StatusNeracaSaldo_Layar = table.Column<bool>(type: "bit", nullable: true),
                    StatusNeracaSaldo_Cetak = table.Column<bool>(type: "bit", nullable: true),
                    StatusLabaRugi_Layar = table.Column<bool>(type: "bit", nullable: true),
                    StatusLabaRugi_Cetak = table.Column<bool>(type: "bit", nullable: true),
                    StatusPerubahanModal = table.Column<bool>(type: "bit", nullable: true),
                    StatusArusKas = table.Column<bool>(type: "bit", nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0Akun", x => x.IdAkun);
                });

            migrationBuilder.CreateTable(
                name: "T0BBM",
                columns: table => new
                {
                    IdBBM = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BBM = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0BBM", x => x.IdBBM);
                });

            migrationBuilder.CreateTable(
                name: "T0Company",
                columns: table => new
                {
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: false),
                    IdKota = table.Column<long>(type: "bigint", nullable: true),
                    IdKaryawan_Direktur = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdVendor_KPP = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Prefix = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Nama = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Inisial = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Departemen = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Slogan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KotakPos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Website1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Website2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LogoPath = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StatusPKP = table.Column<bool>(type: "bit", nullable: true),
                    NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0Company", x => x.IdCompany);
                });

            migrationBuilder.CreateTable(
                name: "T0DivisiBarang",
                columns: table => new
                {
                    IdDivisiBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Divisi = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true),
                    Kode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0DivisiBarang", x => x.IdDivisiBarang);
                });

            migrationBuilder.CreateTable(
                name: "T0DivisiPerusahaan",
                columns: table => new
                {
                    IdDivisiPerusahaan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Divisi = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0DivisiPerusahaan", x => x.IdDivisiPerusahaan);
                });

            migrationBuilder.CreateTable(
                name: "T0DivisiServis",
                columns: table => new
                {
                    IdDivisiServis = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Divisi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Kode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0DivisiServis", x => x.IdDivisiServis);
                });

            migrationBuilder.CreateTable(
                name: "T0Gudang",
                columns: table => new
                {
                    IdGudang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gudang = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Lokasi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0Gudang", x => x.IdGudang);
                });

            migrationBuilder.CreateTable(
                name: "T0Jabatan",
                columns: table => new
                {
                    IdJabatan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKategoriJadwalKerjaKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Jabatan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Kode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0Jabatan", x => x.IdJabatan);
                });

            migrationBuilder.CreateTable(
                name: "T0JenisArmada",
                columns: table => new
                {
                    IdJenisArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Alias = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TonaseMinimal = table.Column<int>(type: "int", nullable: true),
                    TonaseStandar = table.Column<int>(type: "int", nullable: true),
                    Definisi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    KodeSplit = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    StatusOperasional = table.Column<bool>(type: "bit", nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0JenisArmada", x => x.IdJenisArmada);
                });

            migrationBuilder.CreateTable(
                name: "T0JenisAset",
                columns: table => new
                {
                    IdJenisAset = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Jenis = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JenisAset = table.Column<string>(type: "nvarchar(50)", unicode: false, nullable: true),
                    MetodePenyusutan = table.Column<string>(type: "nvarchar(500)", unicode: false, nullable: true),
                    MasaPakai = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0JenisAset", x => x.IdJenisAset);
                });

            migrationBuilder.CreateTable(
                name: "T0JenisCustomer",
                columns: table => new
                {
                    IdJenisCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true),
                    Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Definisi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0JenisCustomer", x => x.IdJenisCustomer);
                });

            migrationBuilder.CreateTable(
                name: "T0JenisSupplier",
                columns: table => new
                {
                    IdJenisSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Definisi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0JenisSupplier", x => x.IdJenisSupplier);
                });

            migrationBuilder.CreateTable(
                name: "T0JenisTransaksi",
                columns: table => new
                {
                    IdJenisTransaksi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true),
                    IdJenisCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Transaksi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Definisi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Setting = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0JenisTransaksi", x => x.IdJenisTransaksi);
                });

            migrationBuilder.CreateTable(
                name: "T0JenisVendor",
                columns: table => new
                {
                    IdJenisVendor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Definisi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0JenisVendor", x => x.IdJenisVendor);
                });

            migrationBuilder.CreateTable(
                name: "T0JenisWarna",
                columns: table => new
                {
                    IdJenisWarna = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0JenisWarna", x => x.IdJenisWarna);
                });

            migrationBuilder.CreateTable(
                name: "T0KategoriBarang",
                columns: table => new
                {
                    IdKategoriBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kategori = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true),
                    Kode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0KategoriBarang", x => x.IdKategoriBarang);
                });

            migrationBuilder.CreateTable(
                name: "T0KategoriJadwalKerjaKaryawan",
                columns: table => new
                {
                    IdKategoriJadwalKerjaKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true),
                    Kategori = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0KategoriJadwalKerjaKaryawan", x => x.IdKategoriJadwalKerjaKaryawan);
                });

            migrationBuilder.CreateTable(
                name: "T0KategoriServis",
                columns: table => new
                {
                    IdKategoriServis = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kategori = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Kode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0KategoriServis", x => x.IdKategoriServis);
                });

            migrationBuilder.CreateTable(
                name: "T0Kurs",
                columns: table => new
                {
                    IdKurs = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdNegara = table.Column<long>(type: "bigint", nullable: true),
                    Kurs = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Simbol = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    StatusUtama = table.Column<bool>(type: "bit", nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0Kurs", x => x.IdKurs);
                });

            migrationBuilder.CreateTable(
                name: "T0Negara",
                columns: table => new
                {
                    IdNegara = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdNegara_Induk = table.Column<long>(type: "bigint", nullable: true),
                    IdSektorNegara = table.Column<long>(type: "bigint", nullable: true),
                    KodeAngka = table.Column<int>(type: "int", nullable: true),
                    KodeTelepon = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    KodeISO2 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    KodeISO3 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Negara = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Country = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Bendera = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Region = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Continent = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0Negara", x => x.IdNegara);
                });

            migrationBuilder.CreateTable(
                name: "T0Rekening",
                columns: table => new
                {
                    IdRekening = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Inisial = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Jenis = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Rekening = table.Column<string>(type: "nvarchar(100)", unicode: false, nullable: true),
                    Pemilik = table.Column<string>(type: "nvarchar(500)", unicode: false, nullable: true),
                    Bank = table.Column<string>(type: "nvarchar(500)", unicode: false, nullable: true),
                    KodeSwift = table.Column<string>(type: "nvarchar(50)", unicode: false, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StatusKartuKredit = table.Column<bool>(type: "bit", nullable: false),
                    StatusGiro = table.Column<bool>(type: "bit", nullable: false),
                    StatusHakAksesBebas = table.Column<bool>(type: "bit", nullable: false),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0Rekening", x => x.IdRekening);
                });

            migrationBuilder.CreateTable(
                name: "T0SektorKota",
                columns: table => new
                {
                    IdSektorKota = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SektorKota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0SektorKota", x => x.IdSektorKota);
                });

            migrationBuilder.CreateTable(
                name: "T0SektorNegara",
                columns: table => new
                {
                    IdSektorKota = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SektorKota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0SektorNegara", x => x.IdSektorKota);
                });

            migrationBuilder.CreateTable(
                name: "T0SetJurnal",
                columns: table => new
                {
                    IdSetJurnal = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdFormTransaksi = table.Column<long>(type: "bigint", nullable: true),
                    SetJurnal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    WhereClauseField = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WhereClauseValue = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0SetJurnal", x => x.IdSetJurnal);
                    table.ForeignKey(
                        name: "FK_T0SetJurnal_T0Form_IdFormTransaksi",
                        column: x => x.IdFormTransaksi,
                        principalTable: "T0Form",
                        principalColumn: "IdForm");
                });

            migrationBuilder.CreateTable(
                name: "T1Armada",
                columns: table => new
                {
                    IdArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdJenisArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdBBM = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSplitArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupplier_Pemilik = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCompany_Pemilik = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    Inisial = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    JenisPengunaan = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NamaPemilikBPKB = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatPemilikBPKB = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PemegangnBPKB = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NomorBPKB = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Merk = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tipe = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Model = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TahunPembuatan = table.Column<int>(type: "int", nullable: true),
                    TahunPerakitan = table.Column<int>(type: "int", nullable: true),
                    IsiSilinder = table.Column<int>(type: "int", nullable: true),
                    IsiTangkiBBM = table.Column<int>(type: "int", nullable: true),
                    Warna = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NomorRangka = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NomorMesin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NomorSTNK = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WarnaTNKB = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BahanBakar = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KodeLokasi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BeratMaksimumSTNK = table.Column<int>(type: "int", nullable: true),
                    NomorUrutPendaftaran = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TanggalSTNK = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    TanggalTNKB = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    TanggalUjiKir = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GPSTipe = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GPSProvider = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GPSNomorKartu = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GPSVendorKartu = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GPSTanggalExpired = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    StatusSopirBebas = table.Column<bool>(type: "bit", nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1Armada", x => x.IdArmada);
                    table.ForeignKey(
                        name: "FK_T1Armada_T0BBM_IdBBM",
                        column: x => x.IdBBM,
                        principalTable: "T0BBM",
                        principalColumn: "IdBBM");
                    table.ForeignKey(
                        name: "FK_T1Armada_T0Company_IdCompany_Pemilik",
                        column: x => x.IdCompany_Pemilik,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T1Armada_T0JenisArmada_IdJenisArmada",
                        column: x => x.IdJenisArmada,
                        principalTable: "T0JenisArmada",
                        principalColumn: "IdJenisArmada");
                });

            migrationBuilder.CreateTable(
                name: "T1Aset",
                columns: table => new
                {
                    IdAset = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdJenisAset = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Aset = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Kode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    HargaPerolehan = table.Column<decimal>(type: "money", nullable: true),
                    TanggalPerolehan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1Aset", x => x.IdAset);
                    table.ForeignKey(
                        name: "FK_T1Aset_T0JenisAset_IdJenisAset",
                        column: x => x.IdJenisAset,
                        principalTable: "T0JenisAset",
                        principalColumn: "IdJenisAset");
                });

            migrationBuilder.CreateTable(
                name: "T1Customer",
                columns: table => new
                {
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true),
                    IdJenisCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdNegara = table.Column<long>(type: "bigint", nullable: true),
                    IdSektorNegara = table.Column<long>(type: "bigint", nullable: true),
                    IdKota = table.Column<long>(type: "bigint", nullable: true),
                    IdKecamatan = table.Column<long>(type: "bigint", nullable: true),
                    IdKelurahan = table.Column<long>(type: "bigint", nullable: true),
                    IdRekening = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Prefix = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Nama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Kode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    JenisDistribusi = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KotakPos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Perumahan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NoIdentitas = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TanggalKedaluwarsaKeanggotaan = table.Column<DateTime>(type: "date", nullable: true),
                    TempatLahir = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TanggalLahir = table.Column<DateTime>(type: "date", nullable: true),
                    JenisKelamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    StatusPerkawinan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Agama = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pekerjaan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Website1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Website2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone4 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone5 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone4 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone5 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Rekening = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JenisPenjualan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    JenisReturPenjualan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    StatusVIP = table.Column<bool>(type: "bit", nullable: true),
                    VIPLevel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VIPNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StatusPKP = table.Column<bool>(type: "bit", nullable: true),
                    NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    JenisHarga = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    JenisDiskon = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    JenisPPN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PersentasePerjanjianUangMuka = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    PersentaseBatasUangMuka = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    JadwalPenagihan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Termin = table.Column<int>(type: "int", nullable: true),
                    BatasPiutangGiro = table.Column<decimal>(type: "money", nullable: true),
                    BatasPiutangUsaha = table.Column<decimal>(type: "money", nullable: true),
                    StatusFumigasi = table.Column<bool>(type: "bit", nullable: true),
                    StatusInspeksiCustomer = table.Column<bool>(type: "bit", nullable: true),
                    StatusCARB = table.Column<bool>(type: "bit", nullable: true),
                    PersyaratanDokumen1 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PersyaratanDokumen2 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PersyaratanDokumen3 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PortOfCharge = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FreightOnBoard = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Atribut01 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Atribut02 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Atribut03 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Atribut04 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Atribut05 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Atribut06 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Atribut07 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Atribut08 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Atribut09 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Atribut10 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsMarked = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1Customer", x => x.IdCustomer);
                    table.ForeignKey(
                        name: "FK_T1Customer_T0JenisCustomer_IdJenisCustomer",
                        column: x => x.IdJenisCustomer,
                        principalTable: "T0JenisCustomer",
                        principalColumn: "IdJenisCustomer");
                    table.ForeignKey(
                        name: "FK_T1Customer_T0Negara_IdNegara",
                        column: x => x.IdNegara,
                        principalTable: "T0Negara",
                        principalColumn: "IdNegara");
                    table.ForeignKey(
                        name: "FK_T1Customer_T0Rekening_IdRekening",
                        column: x => x.IdRekening,
                        principalTable: "T0Rekening",
                        principalColumn: "IdRekening");
                    table.ForeignKey(
                        name: "FK_T1Customer_T0SektorNegara_IdSektorNegara",
                        column: x => x.IdSektorNegara,
                        principalTable: "T0SektorNegara",
                        principalColumn: "IdSektorKota");
                });

            migrationBuilder.CreateTable(
                name: "T1JadwalKerjaKaryawan",
                columns: table => new
                {
                    IdJadwalKerjaKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true),
                    IdKategoriJadwalKerjaKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JadwalKerja = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    HariMulai = table.Column<int>(type: "int", nullable: true),
                    JamMulai = table.Column<TimeSpan>(type: "time", nullable: true),
                    HariSelesai = table.Column<int>(type: "int", nullable: true),
                    JamSelesai = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1JadwalKerjaKaryawan", x => x.IdJadwalKerjaKaryawan);
                    table.ForeignKey(
                        name: "FK_T1JadwalKerjaKaryawan_T0KategoriJadwalKerjaKaryawan_IdKategoriJadwalKerjaKaryawan",
                        column: x => x.IdKategoriJadwalKerjaKaryawan,
                        principalTable: "T0KategoriJadwalKerjaKaryawan",
                        principalColumn: "IdKategoriJadwalKerjaKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T1Karyawan",
                columns: table => new
                {
                    IdKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdJabatan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdDivisiPerusahaan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NamaLengkap = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NamaPanggilan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NomorIdentitas1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NomorIdentitas2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    JenisKelamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TempatLahir = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TanggalLahir = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TanggalRekrut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TanggalBerhenti = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AlamatAsal = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IdKotaAsal = table.Column<long>(type: "bigint", nullable: true),
                    IdKecamatanAsal = table.Column<long>(type: "bigint", nullable: true),
                    IdKelurahanAsal = table.Column<long>(type: "bigint", nullable: true),
                    KodePosAsal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatTinggal = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IdKotaTinggal = table.Column<long>(type: "bigint", nullable: true),
                    IdKecamatanTinggal = table.Column<long>(type: "bigint", nullable: true),
                    IdKelurahanTinggal = table.Column<long>(type: "bigint", nullable: true),
                    KodePosTinggal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Telepon = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Seluler1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Seluler2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KomunikasiLain = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NamaKerabat = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    HubunganKerabat = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatKerabat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TeleponKerabat = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Rekening = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    BPJS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DokumenJaminan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserPassword = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordHint = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    StatusLogin = table.Column<bool>(type: "bit", nullable: true),
                    NIK = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FingerPrint0 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FingerPrint1 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FingerPrint2 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FingerPrint3 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FingerPrint4 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FingerPrint5 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FingerPrint6 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FingerPrint7 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FingerPrint8 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FingerPrint9 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CardIdNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CardIdPin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    T1JadwalKerjaKaryawanIdJadwalKerjaKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1Karyawan", x => x.IdKaryawan);
                    table.ForeignKey(
                        name: "FK_T1Karyawan_T0Jabatan_IdJabatan",
                        column: x => x.IdJabatan,
                        principalTable: "T0Jabatan",
                        principalColumn: "IdJabatan");
                    table.ForeignKey(
                        name: "FK_T1Karyawan_T1JadwalKerjaKaryawan_T1JadwalKerjaKaryawanIdJadwalKerjaKaryawan",
                        column: x => x.T1JadwalKerjaKaryawanIdJadwalKerjaKaryawan,
                        principalTable: "T1JadwalKerjaKaryawan",
                        principalColumn: "IdJadwalKerjaKaryawan");
                    table.ForeignKey(
                        name: "FK_T1Karyawan_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1Karyawan_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1Karyawan_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T1Provinsi",
                columns: table => new
                {
                    IdProvinsi = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdNegara = table.Column<long>(type: "bigint", nullable: true),
                    KodeBPS = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    KodeISO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Lambang = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Provinsi = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IbuKota = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Populasi = table.Column<int>(type: "int", nullable: true),
                    Luas = table.Column<decimal>(type: "money", nullable: true),
                    StatusKhusus = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pulau = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MayoritasAgama = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1Provinsi", x => x.IdProvinsi);
                    table.ForeignKey(
                        name: "FK_T1Provinsi_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1Provinsi_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1Provinsi_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T1SetJurnal",
                columns: table => new
                {
                    IdDetilSetJurnal = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSetJurnal = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAkun = table.Column<string>(type: "varchar(20)", unicode: false, nullable: true),
                    Nominal = table.Column<decimal>(type: "money", nullable: true),
                    Pos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Urutan = table.Column<int>(type: "int", nullable: true),
                    Pasangan = table.Column<int>(type: "int", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1SetJurnal", x => x.IdDetilSetJurnal);
                    table.ForeignKey(
                        name: "FK_T1SetJurnal_T0Akun_IdAkun",
                        column: x => x.IdAkun,
                        principalTable: "T0Akun",
                        principalColumn: "IdAkun");
                    table.ForeignKey(
                        name: "FK_T1SetJurnal_T0SetJurnal_IdSetJurnal",
                        column: x => x.IdSetJurnal,
                        principalTable: "T0SetJurnal",
                        principalColumn: "IdSetJurnal");
                    table.ForeignKey(
                        name: "FK_T1SetJurnal_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1SetJurnal_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1SetJurnal_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T1SubDivisiBarang",
                columns: table => new
                {
                    IdSubDivisiBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDivisiBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SubDivisi = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Kode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1SubDivisiBarang", x => x.IdSubDivisiBarang);
                    table.ForeignKey(
                        name: "FK_T1SubDivisiBarang_T0DivisiBarang_IdDivisiBarang",
                        column: x => x.IdDivisiBarang,
                        principalTable: "T0DivisiBarang",
                        principalColumn: "IdDivisiBarang");
                    table.ForeignKey(
                        name: "FK_T1SubDivisiBarang_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1SubDivisiBarang_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1SubDivisiBarang_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T1SubDivisiServis",
                columns: table => new
                {
                    IdSubDivisiServis = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDivisiServis = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubDivisi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Kode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1SubDivisiServis", x => x.IdSubDivisiServis);
                    table.ForeignKey(
                        name: "FK_T1SubDivisiServis_T0DivisiServis_IdDivisiServis",
                        column: x => x.IdDivisiServis,
                        principalTable: "T0DivisiServis",
                        principalColumn: "IdDivisiServis");
                    table.ForeignKey(
                        name: "FK_T1SubDivisiServis_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1SubDivisiServis_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1SubDivisiServis_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T1SubKategoriBarang",
                columns: table => new
                {
                    IdSubKategoriBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKategoriBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SubKategori = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Kode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1SubKategoriBarang", x => x.IdSubKategoriBarang);
                    table.ForeignKey(
                        name: "FK_T1SubKategoriBarang_T0KategoriBarang_IdKategoriBarang",
                        column: x => x.IdKategoriBarang,
                        principalTable: "T0KategoriBarang",
                        principalColumn: "IdKategoriBarang");
                    table.ForeignKey(
                        name: "FK_T1SubKategoriBarang_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1SubKategoriBarang_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1SubKategoriBarang_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T1SubKategoriServis",
                columns: table => new
                {
                    IdSubKategoriServis = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKategoriServis = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubKategori = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Kode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1SubKategoriServis", x => x.IdSubKategoriServis);
                    table.ForeignKey(
                        name: "FK_T1SubKategoriServis_T0KategoriServis_IdKategoriServis",
                        column: x => x.IdKategoriServis,
                        principalTable: "T0KategoriServis",
                        principalColumn: "IdKategoriServis");
                    table.ForeignKey(
                        name: "FK_T1SubKategoriServis_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1SubKategoriServis_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1SubKategoriServis_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T1Warna",
                columns: table => new
                {
                    IdWarna = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdJenisWarna = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Warna = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Kode1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kode2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1Warna", x => x.IdWarna);
                    table.ForeignKey(
                        name: "FK_T1Warna_T0JenisWarna_IdJenisWarna",
                        column: x => x.IdJenisWarna,
                        principalTable: "T0JenisWarna",
                        principalColumn: "IdJenisWarna");
                    table.ForeignKey(
                        name: "FK_T1Warna_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1Warna_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1Warna_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T2Kota",
                columns: table => new
                {
                    IdKota = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProvinsi = table.Column<long>(type: "bigint", nullable: true),
                    IdSektorKota = table.Column<long>(type: "bigint", nullable: true),
                    KodeBPS = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Lambang = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Inisial = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T2Kota", x => x.IdKota);
                    table.ForeignKey(
                        name: "FK_T2Kota_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2Kota_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2Kota_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T2PenyeliaCustomer",
                columns: table => new
                {
                    IdPenyeliaCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nama = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Prefix = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    JenisKelamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Jabatan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NIP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Messenger = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Rekening = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StatusUtama = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T2PenyeliaCustomer", x => x.IdPenyeliaCustomer);
                    table.ForeignKey(
                        name: "FK_T2PenyeliaCustomer_T1Customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "T1Customer",
                        principalColumn: "IdCustomer");
                    table.ForeignKey(
                        name: "FK_T2PenyeliaCustomer_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2PenyeliaCustomer_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2PenyeliaCustomer_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T3Kecamatan",
                columns: table => new
                {
                    IdKecamatan = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKota = table.Column<long>(type: "bigint", nullable: true),
                    KodeBPS = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Kecamatan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Inisial = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T3Kecamatan", x => x.IdKecamatan);
                    table.ForeignKey(
                        name: "FK_T3Kecamatan_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T3Kecamatan_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T3Kecamatan_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T3Pelabuhan",
                columns: table => new
                {
                    IdPelabuhan = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdNegara = table.Column<long>(type: "bigint", nullable: true),
                    IdProvinsi = table.Column<long>(type: "bigint", nullable: true),
                    IdKota = table.Column<long>(type: "bigint", nullable: true),
                    Pelabuhan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T3Pelabuhan", x => x.IdPelabuhan);
                    table.ForeignKey(
                        name: "FK_T3Pelabuhan_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T3Pelabuhan_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T3Pelabuhan_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T4HargaBBM",
                columns: table => new
                {
                    IdHargaBBM = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBBM = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Harga = table.Column<decimal>(type: "money", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T4HargaBBM", x => x.IdHargaBBM);
                    table.ForeignKey(
                        name: "FK_T4HargaBBM_T0BBM_IdBBM",
                        column: x => x.IdBBM,
                        principalTable: "T0BBM",
                        principalColumn: "IdBBM");
                    table.ForeignKey(
                        name: "FK_T4HargaBBM_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4HargaBBM_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4HargaBBM_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T4Kelurahan",
                columns: table => new
                {
                    IdKelurahan = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKecamatan = table.Column<long>(type: "bigint", nullable: true),
                    Kelurahan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T4Kelurahan", x => x.IdKelurahan);
                    table.ForeignKey(
                        name: "FK_T4Kelurahan_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4Kelurahan_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4Kelurahan_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T4NopolArmada",
                columns: table => new
                {
                    IdArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nopol = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T4NopolArmada", x => x.IdArmada);
                    table.ForeignKey(
                        name: "FK_T4NopolArmada_T1Armada_IdArmada",
                        column: x => x.IdArmada,
                        principalTable: "T1Armada",
                        principalColumn: "IdArmada",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T4NopolArmada_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4NopolArmada_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4NopolArmada_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T5ArmadaCustomer",
                columns: table => new
                {
                    IdArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Panjang = table.Column<int>(type: "int", nullable: true),
                    Lebar = table.Column<int>(type: "int", nullable: true),
                    Tinggi = table.Column<int>(type: "int", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T5ArmadaCustomer", x => new { x.IdArmada, x.IdCustomer });
                    table.ForeignKey(
                        name: "FK_T5ArmadaCustomer_T1Armada_IdArmada",
                        column: x => x.IdArmada,
                        principalTable: "T1Armada",
                        principalColumn: "IdArmada",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T5ArmadaCustomer_T1Customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "T1Customer",
                        principalColumn: "IdCustomer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T5ArmadaCustomer_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5ArmadaCustomer_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5ArmadaCustomer_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T5ArmadaSopir",
                columns: table => new
                {
                    IdArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKaryawan_Sopir = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_T5ArmadaSopir", x => new { x.IdArmada, x.IdKaryawan_Sopir });
                    table.ForeignKey(
                        name: "FK_T5ArmadaSopir_T1Armada_IdArmada",
                        column: x => x.IdArmada,
                        principalTable: "T1Armada",
                        principalColumn: "IdArmada",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T5ArmadaSopir_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5ArmadaSopir_T1Karyawan_IdKaryawan_Sopir",
                        column: x => x.IdKaryawan_Sopir,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T5ArmadaSopir_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5ArmadaSopir_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T5CompanyGudang",
                columns: table => new
                {
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: false),
                    IdGudang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_T5CompanyGudang", x => new { x.IdCompany, x.IdGudang });
                    table.ForeignKey(
                        name: "FK_T5CompanyGudang_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T5CompanyGudang_T0Gudang_IdGudang",
                        column: x => x.IdGudang,
                        principalTable: "T0Gudang",
                        principalColumn: "IdGudang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T5CompanyGudang_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5CompanyGudang_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5CompanyGudang_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T5JabatanKaryawan",
                columns: table => new
                {
                    IdJabatan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_T5JabatanKaryawan", x => new { x.IdJabatan, x.IdKaryawan });
                    table.ForeignKey(
                        name: "FK_T5JabatanKaryawan_T0Jabatan_IdJabatan",
                        column: x => x.IdJabatan,
                        principalTable: "T0Jabatan",
                        principalColumn: "IdJabatan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T5JabatanKaryawan_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5JabatanKaryawan_T1Karyawan_IdKaryawan",
                        column: x => x.IdKaryawan,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T5JabatanKaryawan_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5JabatanKaryawan_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T5KaryawanCustomer",
                columns: table => new
                {
                    IdKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusUtama = table.Column<bool>(type: "bit", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T5KaryawanCustomer", x => new { x.IdCustomer, x.IdKaryawan });
                    table.ForeignKey(
                        name: "FK_T5KaryawanCustomer_T1Customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "T1Customer",
                        principalColumn: "IdCustomer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T5KaryawanCustomer_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5KaryawanCustomer_T1Karyawan_IdKaryawan",
                        column: x => x.IdKaryawan,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T5KaryawanCustomer_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5KaryawanCustomer_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T5Pembayaran",
                columns: table => new
                {
                    IdPembayaran = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTransaksi = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JenisTransaksi = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IdAkun = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdKurs = table.Column<long>(type: "bigint", nullable: true),
                    Pembayaran = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Referensi_Form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Referensi_NoTransaksi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Referensi_WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Nomor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nominal = table.Column<decimal>(type: "money", nullable: true),
                    Pos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Administrasi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Biaya = table.Column<decimal>(type: "money", nullable: true),
                    NilaiKurs = table.Column<decimal>(type: "money", nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Akun_Kode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Akun_Akun = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Akun_Alias = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Kurs_Kurs = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kurs_Simbol = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T5Pembayaran", x => x.IdPembayaran);
                    table.ForeignKey(
                        name: "FK_T5Pembayaran_T0Akun_IdAkun",
                        column: x => x.IdAkun,
                        principalTable: "T0Akun",
                        principalColumn: "IdAkun");
                    table.ForeignKey(
                        name: "FK_T5Pembayaran_T0Kurs_IdKurs",
                        column: x => x.IdKurs,
                        principalTable: "T0Kurs",
                        principalColumn: "IdKurs");
                    table.ForeignKey(
                        name: "FK_T5Pembayaran_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5Pembayaran_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5Pembayaran_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T6Jurnal",
                columns: table => new
                {
                    IdJurnal = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdForm = table.Column<long>(type: "bigint", nullable: true),
                    Jenis = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Referensi_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Referensi_IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NoBukti = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GrandTotal = table.Column<decimal>(type: "money", nullable: false),
                    Form_Form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6Jurnal", x => x.IdJurnal);
                    table.ForeignKey(
                        name: "FK_T6Jurnal_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6Jurnal_T0Form_IdForm",
                        column: x => x.IdForm,
                        principalTable: "T0Form",
                        principalColumn: "IdForm");
                    table.ForeignKey(
                        name: "FK_T6Jurnal_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6Jurnal_T1Karyawan_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6Jurnal_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6Jurnal_T1Karyawan_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6Jurnal_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T6PelunasanPiutangKaryawan",
                columns: table => new
                {
                    IdPelunasanPiutangKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdJabatan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DiskonDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonNominal = table.Column<decimal>(type: "money", nullable: true),
                    SubTotal_PiutangKaryawan = table.Column<decimal>(type: "money", nullable: true),
                    SubTotal_AkunPotongan = table.Column<decimal>(type: "money", nullable: true),
                    GrandTotal = table.Column<decimal>(type: "money", nullable: true),
                    Karyawan_NamaLengkap = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_NamaPanggilan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_AlamatTinggal = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Karyawan_KodePosTinggal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_KotaTinggal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Seluler1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Seluler2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Jabatan_Jabatan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pembayaran_Total = table.Column<decimal>(type: "money", nullable: true),
                    Pembayaran_Keterangan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Pembayaran_Via = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pembayaran_StatusTerbayar = table.Column<bool>(type: "bit", nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6PelunasanPiutangKaryawan", x => x.IdPelunasanPiutangKaryawan);
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangKaryawan_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangKaryawan_T0Jabatan_IdJabatan",
                        column: x => x.IdJabatan,
                        principalTable: "T0Jabatan",
                        principalColumn: "IdJabatan");
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangKaryawan_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangKaryawan_T1Karyawan_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangKaryawan_T1Karyawan_IdKaryawan",
                        column: x => x.IdKaryawan,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangKaryawan_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangKaryawan_T1Karyawan_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangKaryawan_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T6PelunasanPiutangUsaha",
                columns: table => new
                {
                    IdPelunasanPiutangUsaha = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdJenisCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DiskonDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonNominal = table.Column<decimal>(type: "money", nullable: true),
                    SubTotal_PiutangUsaha = table.Column<decimal>(type: "money", nullable: true),
                    SubTotal_AkunPotongan = table.Column<decimal>(type: "money", nullable: true),
                    GrandTotal = table.Column<decimal>(type: "money", nullable: true),
                    Customer_Nama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Customer_Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Kode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Customer_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_StatusPKP = table.Column<bool>(type: "bit", nullable: true),
                    Customer_NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Customer = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    JenisCustomer_Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pembayaran_Total = table.Column<decimal>(type: "money", nullable: true),
                    Pembayaran_Keterangan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Pembayaran_Via = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pembayaran_StatusTerbayar = table.Column<bool>(type: "bit", nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6PelunasanPiutangUsaha", x => x.IdPelunasanPiutangUsaha);
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangUsaha_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangUsaha_T0JenisCustomer_IdJenisCustomer",
                        column: x => x.IdJenisCustomer,
                        principalTable: "T0JenisCustomer",
                        principalColumn: "IdJenisCustomer");
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangUsaha_T1Customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "T1Customer",
                        principalColumn: "IdCustomer");
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangUsaha_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangUsaha_T1Karyawan_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangUsaha_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangUsaha_T1Karyawan_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PelunasanPiutangUsaha_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T6PencairanHutangGiro",
                columns: table => new
                {
                    IdPencairanHutangGiro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdRekening = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    GrandTotal = table.Column<decimal>(type: "money", nullable: true),
                    Rekening_Rekening = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6PencairanHutangGiro", x => x.IdPencairanHutangGiro);
                    table.ForeignKey(
                        name: "FK_T6PencairanHutangGiro_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6PencairanHutangGiro_T0Rekening_IdRekening",
                        column: x => x.IdRekening,
                        principalTable: "T0Rekening",
                        principalColumn: "IdRekening");
                    table.ForeignKey(
                        name: "FK_T6PencairanHutangGiro_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PencairanHutangGiro_T1Karyawan_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PencairanHutangGiro_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PencairanHutangGiro_T1Karyawan_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PencairanHutangGiro_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T6PencairanPiutangGiro",
                columns: table => new
                {
                    IdPencairanPiutangGiro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdRekening = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    GrandTotal = table.Column<decimal>(type: "money", nullable: true),
                    Rekening_Rekening = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6PencairanPiutangGiro", x => x.IdPencairanPiutangGiro);
                    table.ForeignKey(
                        name: "FK_T6PencairanPiutangGiro_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6PencairanPiutangGiro_T0Rekening_IdRekening",
                        column: x => x.IdRekening,
                        principalTable: "T0Rekening",
                        principalColumn: "IdRekening");
                    table.ForeignKey(
                        name: "FK_T6PencairanPiutangGiro_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PencairanPiutangGiro_T1Karyawan_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PencairanPiutangGiro_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PencairanPiutangGiro_T1Karyawan_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PencairanPiutangGiro_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T6PenugasanArmada",
                columns: table => new
                {
                    IdPenugasanArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdRekening = table.Column<string>(type: "varchar(20)", unicode: false, nullable: true),
                    IdArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdJenisArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdBBM = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKaryawan_Sopir = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPiutangKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nopol = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Potongan = table.Column<decimal>(type: "money", nullable: true),
                    StatusPotongan = table.Column<bool>(type: "bit", nullable: true),
                    StatusPerjalanan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StatusDeposit = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Rekening_Rekening = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Armada_Inisial = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Armada_Nopol = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Armada_Merk = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JenisArmada_Jenis = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JenisArmada_Alias = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BBM_BBM = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Karyawan_Sopir_NamaPanggilan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Karyawan_Sopir_AlamatTinggal = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Karyawan_Sopir_KodePosTinggal = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Karyawan_Sopir_KotaTinggal = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Karyawan_Sopir_Email = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Karyawan_Sopir_Seluler1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Karyawan_Sopir_Rekening = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Referensi_NominalSaldoAwal = table.Column<decimal>(type: "money", nullable: true),
                    Referensi_IdTransaksi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Referensi_WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Referensi_Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Pembayaran_Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Pembayaran_Via = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Pembayaran_StatusTerbayar = table.Column<bool>(type: "bit", nullable: true),
                    Pembayaran_Total = table.Column<decimal>(type: "money", nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6PenugasanArmada", x => x.IdPenugasanArmada);
                    table.ForeignKey(
                        name: "FK_T6PenugasanArmada_T0BBM_IdBBM",
                        column: x => x.IdBBM,
                        principalTable: "T0BBM",
                        principalColumn: "IdBBM");
                    table.ForeignKey(
                        name: "FK_T6PenugasanArmada_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6PenugasanArmada_T0JenisArmada_IdJenisArmada",
                        column: x => x.IdJenisArmada,
                        principalTable: "T0JenisArmada",
                        principalColumn: "IdJenisArmada");
                    table.ForeignKey(
                        name: "FK_T6PenugasanArmada_T0Rekening_IdRekening",
                        column: x => x.IdRekening,
                        principalTable: "T0Rekening",
                        principalColumn: "IdRekening");
                    table.ForeignKey(
                        name: "FK_T6PenugasanArmada_T1Armada_IdArmada",
                        column: x => x.IdArmada,
                        principalTable: "T1Armada",
                        principalColumn: "IdArmada");
                    table.ForeignKey(
                        name: "FK_T6PenugasanArmada_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PenugasanArmada_T1Karyawan_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PenugasanArmada_T1Karyawan_IdKaryawan_Sopir",
                        column: x => x.IdKaryawan_Sopir,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PenugasanArmada_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PenugasanArmada_T1Karyawan_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PenugasanArmada_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T6PiutangKaryawan",
                columns: table => new
                {
                    IdPiutangKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdJabatan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdRekening = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdForm = table.Column<long>(type: "bigint", nullable: true),
                    Referensi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Atribut01 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut02 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut03 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut04 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut05 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut06 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut07 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut08 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut09 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut10 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Nominal = table.Column<decimal>(type: "money", nullable: true),
                    TanggalJatuhTempo = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Angsuran = table.Column<decimal>(type: "money", nullable: true),
                    StatusPelunasan = table.Column<bool>(type: "bit", nullable: true),
                    Jabatan_Jabatan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Karyawan_NamaLengkap = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Karyawan_NamaPanggilan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Karyawan_AlamatTinggal = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Karyawan_KodePosTinggal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_KotaTinggal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Seluler1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Seluler2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Rekening_Rekening = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Form_Form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6PiutangKaryawan", x => x.IdPiutangKaryawan);
                    table.ForeignKey(
                        name: "FK_T6PiutangKaryawan_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6PiutangKaryawan_T0Form_IdForm",
                        column: x => x.IdForm,
                        principalTable: "T0Form",
                        principalColumn: "IdForm");
                    table.ForeignKey(
                        name: "FK_T6PiutangKaryawan_T0Jabatan_IdJabatan",
                        column: x => x.IdJabatan,
                        principalTable: "T0Jabatan",
                        principalColumn: "IdJabatan");
                    table.ForeignKey(
                        name: "FK_T6PiutangKaryawan_T0Rekening_IdRekening",
                        column: x => x.IdRekening,
                        principalTable: "T0Rekening",
                        principalColumn: "IdRekening");
                    table.ForeignKey(
                        name: "FK_T6PiutangKaryawan_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PiutangKaryawan_T1Karyawan_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PiutangKaryawan_T1Karyawan_IdKaryawan",
                        column: x => x.IdKaryawan,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PiutangKaryawan_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PiutangKaryawan_T1Karyawan_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PiutangKaryawan_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T9Filter",
                columns: table => new
                {
                    IdFilter = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdForm = table.Column<long>(type: "bigint", nullable: true),
                    GridView = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FilterName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    FilterString = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T9Filter", x => x.IdFilter);
                    table.ForeignKey(
                        name: "FK_T9Filter_T0Form_IdForm",
                        column: x => x.IdForm,
                        principalTable: "T0Form",
                        principalColumn: "IdForm");
                    table.ForeignKey(
                        name: "FK_T9Filter_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T9Filter_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T9Filter_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T9Tag",
                columns: table => new
                {
                    IdTag = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdForm = table.Column<long>(type: "bigint", nullable: true),
                    TagString = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T9Tag", x => x.IdTag);
                    table.ForeignKey(
                        name: "FK_T9Tag_T0Form_IdForm",
                        column: x => x.IdForm,
                        principalTable: "T0Form",
                        principalColumn: "IdForm");
                    table.ForeignKey(
                        name: "FK_T9Tag_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T9Tag_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T9Tag_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T2Barang",
                columns: table => new
                {
                    IdBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSubDivisiBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSubKategoriBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true),
                    Barang = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Kode1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Kode2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Merk = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ukuran = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Warna = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Umur = table.Column<int>(type: "int", nullable: false),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T2Barang", x => x.IdBarang);
                    table.ForeignKey(
                        name: "FK_T2Barang_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2Barang_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2Barang_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2Barang_T1SubDivisiBarang_IdSubDivisiBarang",
                        column: x => x.IdSubDivisiBarang,
                        principalTable: "T1SubDivisiBarang",
                        principalColumn: "IdSubDivisiBarang");
                    table.ForeignKey(
                        name: "FK_T2Barang_T1SubKategoriBarang_IdSubKategoriBarang",
                        column: x => x.IdSubKategoriBarang,
                        principalTable: "T1SubKategoriBarang",
                        principalColumn: "IdSubKategoriBarang");
                });

            migrationBuilder.CreateTable(
                name: "T2Servis",
                columns: table => new
                {
                    IdServis = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSubDivisiServis = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSubKategoriServis = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Servis = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Kode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Definisi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Reminder = table.Column<bool>(type: "bit", nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T2Servis", x => x.IdServis);
                    table.ForeignKey(
                        name: "FK_T2Servis_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2Servis_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2Servis_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2Servis_T1SubDivisiServis_IdSubDivisiServis",
                        column: x => x.IdSubDivisiServis,
                        principalTable: "T1SubDivisiServis",
                        principalColumn: "IdSubDivisiServis");
                    table.ForeignKey(
                        name: "FK_T2Servis_T1SubKategoriServis_IdSubKategoriServis",
                        column: x => x.IdSubKategoriServis,
                        principalTable: "T1SubKategoriServis",
                        principalColumn: "IdSubKategoriServis");
                });

            migrationBuilder.CreateTable(
                name: "T1Supplier",
                columns: table => new
                {
                    IdSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdJenisSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdNegara = table.Column<long>(type: "bigint", nullable: true),
                    IdSektorNegara = table.Column<long>(type: "bigint", nullable: true),
                    IdKota = table.Column<long>(type: "bigint", nullable: true),
                    IdKecamatan = table.Column<long>(type: "bigint", nullable: true),
                    IdKelurahan = table.Column<long>(type: "bigint", nullable: true),
                    Prefix = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Nama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Kode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PortOfCharge = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FreightOnBoard = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Website1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Website2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone4 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone5 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone4 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone5 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Rekening = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JenisPPN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PersentasePerjanjianUangMuka = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    PersentaseBatasUangMuka = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    JenisPembelian = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    JenisReturPembelian = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JadwalPenagihan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Termin = table.Column<int>(type: "int", nullable: true),
                    BatasHutangGiro = table.Column<decimal>(type: "money", nullable: true),
                    BatasHutangUsaha = table.Column<decimal>(type: "money", nullable: true),
                    PersyaratanDokumen1 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PersyaratanDokumen2 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PersyaratanDokumen3 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1Supplier", x => x.IdSupplier);
                    table.ForeignKey(
                        name: "FK_T1Supplier_T0JenisSupplier_IdJenisSupplier",
                        column: x => x.IdJenisSupplier,
                        principalTable: "T0JenisSupplier",
                        principalColumn: "IdJenisSupplier");
                    table.ForeignKey(
                        name: "FK_T1Supplier_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1Supplier_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1Supplier_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1Supplier_T2Kota_IdKota",
                        column: x => x.IdKota,
                        principalTable: "T2Kota",
                        principalColumn: "IdKota");
                });

            migrationBuilder.CreateTable(
                name: "T1Vendor",
                columns: table => new
                {
                    IdVendor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdJenisVendor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdNegara = table.Column<long>(type: "bigint", nullable: true),
                    IdSektorNegara = table.Column<long>(type: "bigint", nullable: true),
                    IdKota = table.Column<long>(type: "bigint", nullable: true),
                    IdKecamatan = table.Column<long>(type: "bigint", nullable: true),
                    IdKelurahan = table.Column<long>(type: "bigint", nullable: true),
                    Prefix = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Nama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Kode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PortOfCharge = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FreightOnBoard = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Website1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Website2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone4 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone5 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone4 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone5 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Rekening = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JenisPPN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    JenisPembelian = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JenisReturPembelian = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Termin = table.Column<int>(type: "int", nullable: true),
                    BatasHutangGiro = table.Column<decimal>(type: "money", nullable: true),
                    BatasHutangUsaha = table.Column<decimal>(type: "money", nullable: true),
                    JadwalPenagihan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1Vendor", x => x.IdVendor);
                    table.ForeignKey(
                        name: "FK_T1Vendor_T0JenisVendor_IdJenisVendor",
                        column: x => x.IdJenisVendor,
                        principalTable: "T0JenisVendor",
                        principalColumn: "IdJenisVendor");
                    table.ForeignKey(
                        name: "FK_T1Vendor_T0Negara_IdNegara",
                        column: x => x.IdNegara,
                        principalTable: "T0Negara",
                        principalColumn: "IdNegara");
                    table.ForeignKey(
                        name: "FK_T1Vendor_T0SektorNegara_IdSektorNegara",
                        column: x => x.IdSektorNegara,
                        principalTable: "T0SektorNegara",
                        principalColumn: "IdSektorKota");
                    table.ForeignKey(
                        name: "FK_T1Vendor_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1Vendor_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1Vendor_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T1Vendor_T2Kota_IdKota",
                        column: x => x.IdKota,
                        principalTable: "T2Kota",
                        principalColumn: "IdKota");
                    table.ForeignKey(
                        name: "FK_T1Vendor_T3Kecamatan_IdKecamatan",
                        column: x => x.IdKecamatan,
                        principalTable: "T3Kecamatan",
                        principalColumn: "IdKecamatan");
                    table.ForeignKey(
                        name: "FK_T1Vendor_T4Kelurahan_IdKelurahan",
                        column: x => x.IdKelurahan,
                        principalTable: "T4Kelurahan",
                        principalColumn: "IdKelurahan");
                });

            migrationBuilder.CreateTable(
                name: "T2AlamatCustomer",
                columns: table => new
                {
                    IdAlamatCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdNegara = table.Column<long>(type: "bigint", nullable: true),
                    IdKota = table.Column<long>(type: "bigint", nullable: true),
                    IdPelabuhan = table.Column<long>(type: "bigint", nullable: true),
                    IdKecamatan = table.Column<long>(type: "bigint", nullable: true),
                    IdKelurahan = table.Column<long>(type: "bigint", nullable: true),
                    JenisAlamat = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Consignee = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NotifyParty = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    KTP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StatusUtama = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T2AlamatCustomer", x => x.IdAlamatCustomer);
                    table.ForeignKey(
                        name: "FK_T2AlamatCustomer_T0Negara_IdNegara",
                        column: x => x.IdNegara,
                        principalTable: "T0Negara",
                        principalColumn: "IdNegara");
                    table.ForeignKey(
                        name: "FK_T2AlamatCustomer_T1Customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "T1Customer",
                        principalColumn: "IdCustomer");
                    table.ForeignKey(
                        name: "FK_T2AlamatCustomer_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2AlamatCustomer_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2AlamatCustomer_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2AlamatCustomer_T2Kota_IdKota",
                        column: x => x.IdKota,
                        principalTable: "T2Kota",
                        principalColumn: "IdKota");
                    table.ForeignKey(
                        name: "FK_T2AlamatCustomer_T3Kecamatan_IdKecamatan",
                        column: x => x.IdKecamatan,
                        principalTable: "T3Kecamatan",
                        principalColumn: "IdKecamatan");
                    table.ForeignKey(
                        name: "FK_T2AlamatCustomer_T4Kelurahan_IdKelurahan",
                        column: x => x.IdKelurahan,
                        principalTable: "T4Kelurahan",
                        principalColumn: "IdKelurahan");
                });

            migrationBuilder.CreateTable(
                name: "T7Jurnal",
                columns: table => new
                {
                    IdDetilJurnal = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdJurnal = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAkun = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdKurs = table.Column<long>(type: "bigint", nullable: true),
                    Deskripsi = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Pos = table.Column<string>(type: "char(1)", unicode: false, nullable: true),
                    NilaiKurs = table.Column<decimal>(type: "decimal(16,8)", nullable: true),
                    NominalTransaksi = table.Column<decimal>(type: "money", nullable: true),
                    NominalAkuntansi = table.Column<decimal>(type: "money", nullable: true),
                    Pasangan = table.Column<byte>(type: "tinyint", nullable: false),
                    Akun_Kode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Akun_Akun = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Akun_Alias = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T7Jurnal", x => x.IdDetilJurnal);
                    table.ForeignKey(
                        name: "FK_T7Jurnal_T0Akun_IdAkun",
                        column: x => x.IdAkun,
                        principalTable: "T0Akun",
                        principalColumn: "IdAkun");
                    table.ForeignKey(
                        name: "FK_T7Jurnal_T0Kurs_IdKurs",
                        column: x => x.IdKurs,
                        principalTable: "T0Kurs",
                        principalColumn: "IdKurs");
                    table.ForeignKey(
                        name: "FK_T7Jurnal_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7Jurnal_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7Jurnal_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7Jurnal_T6Jurnal_IdJurnal",
                        column: x => x.IdJurnal,
                        principalTable: "T6Jurnal",
                        principalColumn: "IdJurnal");
                });

            migrationBuilder.CreateTable(
                name: "T7PelunasanPiutangKaryawan",
                columns: table => new
                {
                    IdDetilPelunasanPiutangKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPelunasanPiutangKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPiutangKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TambahJatuhTempo = table.Column<int>(type: "int", nullable: true),
                    Nominal = table.Column<decimal>(type: "money", nullable: true),
                    Referensi_TanggalJatuhTempo = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Referensi_NominalSaldoAwal = table.Column<decimal>(type: "money", nullable: true),
                    Referensi_NominalSaldoBerjalan = table.Column<decimal>(type: "money", nullable: true),
                    Referensi_IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Referensi_WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Referensi_Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Referensi_Referensi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Referensi_Faktur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_Form_Form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T7PelunasanPiutangKaryawan", x => x.IdDetilPelunasanPiutangKaryawan);
                    table.ForeignKey(
                        name: "FK_T7PelunasanPiutangKaryawan_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PelunasanPiutangKaryawan_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PelunasanPiutangKaryawan_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PelunasanPiutangKaryawan_T6PelunasanPiutangKaryawan_IdPelunasanPiutangKaryawan",
                        column: x => x.IdPelunasanPiutangKaryawan,
                        principalTable: "T6PelunasanPiutangKaryawan",
                        principalColumn: "IdPelunasanPiutangKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PelunasanPiutangKaryawan_T6PiutangKaryawan_IdPiutangKaryawan",
                        column: x => x.IdPiutangKaryawan,
                        principalTable: "T6PiutangKaryawan",
                        principalColumn: "IdPiutangKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T3Satuan",
                columns: table => new
                {
                    IdSatuan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Satuan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SKUKode1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SKUKode2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SKULevel = table.Column<byte>(type: "tinyint", nullable: false),
                    SKUGrup = table.Column<byte>(type: "tinyint", nullable: false),
                    SKURasio = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    UseSerialNumber = table.Column<bool>(type: "bit", nullable: true),
                    UseGenerateSerialNumber = table.Column<bool>(type: "bit", nullable: true),
                    UsePriceList = table.Column<bool>(type: "bit", nullable: true),
                    UseKuantum = table.Column<bool>(type: "bit", nullable: true),
                    UseBeliMinimum = table.Column<bool>(type: "bit", nullable: true),
                    BeliMinimum = table.Column<decimal>(type: "money", nullable: true),
                    UseBeliA = table.Column<bool>(type: "bit", nullable: true),
                    BeliA = table.Column<decimal>(type: "money", nullable: true),
                    UseBeliB = table.Column<bool>(type: "bit", nullable: true),
                    BeliB = table.Column<decimal>(type: "money", nullable: true),
                    UseBeliC = table.Column<bool>(type: "bit", nullable: true),
                    BeliC = table.Column<decimal>(type: "money", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    StatusFalseOtomatis = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T3Satuan", x => x.IdSatuan);
                    table.ForeignKey(
                        name: "FK_T3Satuan_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T3Satuan_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T3Satuan_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T3Satuan_T2Barang_IdBarang",
                        column: x => x.IdBarang,
                        principalTable: "T2Barang",
                        principalColumn: "IdBarang");
                });

            migrationBuilder.CreateTable(
                name: "T5Gambar",
                columns: table => new
                {
                    IdGambar = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdReferensi = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Jenis = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Gambar = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Urutan = table.Column<int>(type: "int", nullable: true),
                    Kategori = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    T2BarangIdBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T5Gambar", x => x.IdGambar);
                    table.ForeignKey(
                        name: "FK_T5Gambar_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5Gambar_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5Gambar_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5Gambar_T2Barang_T2BarangIdBarang",
                        column: x => x.T2BarangIdBarang,
                        principalTable: "T2Barang",
                        principalColumn: "IdBarang");
                });

            migrationBuilder.CreateTable(
                name: "T5SupplierSatuan",
                columns: table => new
                {
                    IdSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSatuan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    T2BarangIdBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T5SupplierSatuan", x => new { x.IdSupplier, x.IdSatuan });
                    table.ForeignKey(
                        name: "FK_T5SupplierSatuan_T2Barang_T2BarangIdBarang",
                        column: x => x.T2BarangIdBarang,
                        principalTable: "T2Barang",
                        principalColumn: "IdBarang");
                });

            migrationBuilder.CreateTable(
                name: "T2AlamatSupplier",
                columns: table => new
                {
                    IdAlamatSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKota = table.Column<long>(type: "bigint", nullable: true),
                    IdKecamatan = table.Column<long>(type: "bigint", nullable: true),
                    IdKelurahan = table.Column<long>(type: "bigint", nullable: true),
                    JenisAlamat = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StatusUtama = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T2AlamatSupplier", x => x.IdAlamatSupplier);
                    table.ForeignKey(
                        name: "FK_T2AlamatSupplier_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2AlamatSupplier_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2AlamatSupplier_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2AlamatSupplier_T1Supplier_IdSupplier",
                        column: x => x.IdSupplier,
                        principalTable: "T1Supplier",
                        principalColumn: "IdSupplier");
                    table.ForeignKey(
                        name: "FK_T2AlamatSupplier_T2Kota_IdKota",
                        column: x => x.IdKota,
                        principalTable: "T2Kota",
                        principalColumn: "IdKota");
                    table.ForeignKey(
                        name: "FK_T2AlamatSupplier_T3Kecamatan_IdKecamatan",
                        column: x => x.IdKecamatan,
                        principalTable: "T3Kecamatan",
                        principalColumn: "IdKecamatan");
                    table.ForeignKey(
                        name: "FK_T2AlamatSupplier_T4Kelurahan_IdKelurahan",
                        column: x => x.IdKelurahan,
                        principalTable: "T4Kelurahan",
                        principalColumn: "IdKelurahan");
                });

            migrationBuilder.CreateTable(
                name: "T2PenyeliaSupplier",
                columns: table => new
                {
                    IdPenyeliaSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nama = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Prefix = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    JenisKelamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Jabatan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NIP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Messenger = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Rekening = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StatusUtama = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T2PenyeliaSupplier", x => x.IdPenyeliaSupplier);
                    table.ForeignKey(
                        name: "FK_T2PenyeliaSupplier_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2PenyeliaSupplier_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2PenyeliaSupplier_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2PenyeliaSupplier_T1Supplier_IdSupplier",
                        column: x => x.IdSupplier,
                        principalTable: "T1Supplier",
                        principalColumn: "IdSupplier");
                });

            migrationBuilder.CreateTable(
                name: "T5VendorSupplier",
                columns: table => new
                {
                    IdVendor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServisVendorSupplier = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StatusUtama = table.Column<bool>(type: "bit", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T5VendorSupplier", x => new { x.IdVendor, x.IdSupplier });
                    table.ForeignKey(
                        name: "FK_T5VendorSupplier_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5VendorSupplier_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5VendorSupplier_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5VendorSupplier_T1Supplier_IdSupplier",
                        column: x => x.IdSupplier,
                        principalTable: "T1Supplier",
                        principalColumn: "IdSupplier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T6HutangUsaha",
                columns: table => new
                {
                    IdHutangUsaha = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdJenisSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdForm = table.Column<long>(type: "bigint", nullable: true),
                    Referensi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Atribut01 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut02 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut03 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut04 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut05 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut06 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut07 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut08 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut09 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut10 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Nominal = table.Column<decimal>(type: "money", nullable: true),
                    TanggalJatuhTempo = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StatusPelunasan = table.Column<bool>(type: "bit", nullable: true),
                    Supplier_Nama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Supplier_Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Supplier_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Supplier = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    JenisSupplier_Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Form_Form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6HutangUsaha", x => x.IdHutangUsaha);
                    table.ForeignKey(
                        name: "FK_T6HutangUsaha_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6HutangUsaha_T0Form_IdForm",
                        column: x => x.IdForm,
                        principalTable: "T0Form",
                        principalColumn: "IdForm");
                    table.ForeignKey(
                        name: "FK_T6HutangUsaha_T0JenisSupplier_IdJenisSupplier",
                        column: x => x.IdJenisSupplier,
                        principalTable: "T0JenisSupplier",
                        principalColumn: "IdJenisSupplier");
                    table.ForeignKey(
                        name: "FK_T6HutangUsaha_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6HutangUsaha_T1Karyawan_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6HutangUsaha_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6HutangUsaha_T1Karyawan_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6HutangUsaha_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6HutangUsaha_T1Supplier_IdSupplier",
                        column: x => x.IdSupplier,
                        principalTable: "T1Supplier",
                        principalColumn: "IdSupplier");
                });

            migrationBuilder.CreateTable(
                name: "T6OrderPembelian",
                columns: table => new
                {
                    IdOrderPembelian = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdJenisSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCompany_Penerima = table.Column<string>(type: "char(3)", unicode: false, maxLength: 3, nullable: true),
                    WaktuKirim = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    KodePOSupplier = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Attn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DeliveryBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DiskonDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonNominal = table.Column<decimal>(type: "money", nullable: true),
                    PPNDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PPNNominal = table.Column<decimal>(type: "money", nullable: true),
                    GrandTotal = table.Column<decimal>(type: "money", nullable: true),
                    Supplier_Nama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Supplier_Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Supplier_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Supplier = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    JenisSupplier_Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pembayaran_Total = table.Column<decimal>(type: "money", nullable: true),
                    Pembayaran_Keterangan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Pembayaran_Via = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pembayaran_StatusTerbayar = table.Column<bool>(type: "bit", nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6OrderPembelian", x => x.IdOrderPembelian);
                    table.ForeignKey(
                        name: "FK_T6OrderPembelian_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6OrderPembelian_T0Company_IdCompany_Penerima",
                        column: x => x.IdCompany_Penerima,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6OrderPembelian_T0JenisSupplier_IdJenisSupplier",
                        column: x => x.IdJenisSupplier,
                        principalTable: "T0JenisSupplier",
                        principalColumn: "IdJenisSupplier");
                    table.ForeignKey(
                        name: "FK_T6OrderPembelian_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6OrderPembelian_T1Karyawan_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6OrderPembelian_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6OrderPembelian_T1Karyawan_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6OrderPembelian_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6OrderPembelian_T1Supplier_IdSupplier",
                        column: x => x.IdSupplier,
                        principalTable: "T1Supplier",
                        principalColumn: "IdSupplier");
                });

            migrationBuilder.CreateTable(
                name: "T6PelunasanHutangUsaha",
                columns: table => new
                {
                    IdPelunasanHutangUsaha = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdJenisSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DiskonDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonNominal = table.Column<decimal>(type: "money", nullable: true),
                    SubTotal_HutangUsaha = table.Column<decimal>(type: "money", nullable: true),
                    SubTotal_AkunPotongan = table.Column<decimal>(type: "money", nullable: true),
                    GrandTotal = table.Column<decimal>(type: "money", nullable: true),
                    Supplier_Nama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Supplier_Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Supplier_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Supplier = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    JenisSupplier_Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pembayaran_Total = table.Column<decimal>(type: "money", nullable: true),
                    Pembayaran_Keterangan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Pembayaran_Via = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pembayaran_StatusTerbayar = table.Column<bool>(type: "bit", nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6PelunasanHutangUsaha", x => x.IdPelunasanHutangUsaha);
                    table.ForeignKey(
                        name: "FK_T6PelunasanHutangUsaha_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6PelunasanHutangUsaha_T0JenisSupplier_IdJenisSupplier",
                        column: x => x.IdJenisSupplier,
                        principalTable: "T0JenisSupplier",
                        principalColumn: "IdJenisSupplier");
                    table.ForeignKey(
                        name: "FK_T6PelunasanHutangUsaha_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PelunasanHutangUsaha_T1Karyawan_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PelunasanHutangUsaha_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PelunasanHutangUsaha_T1Karyawan_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PelunasanHutangUsaha_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PelunasanHutangUsaha_T1Supplier_IdSupplier",
                        column: x => x.IdSupplier,
                        principalTable: "T1Supplier",
                        principalColumn: "IdSupplier");
                });

            migrationBuilder.CreateTable(
                name: "T6PembelianAset",
                columns: table => new
                {
                    IdPembelianAset = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdJenisSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Faktur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonNominal = table.Column<decimal>(type: "money", nullable: true),
                    PPNDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PPNNominal = table.Column<decimal>(type: "money", nullable: true),
                    GrandTotal = table.Column<decimal>(type: "money", nullable: true),
                    Supplier_Nama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Supplier_Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Supplier_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Supplier = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    JenisSupplier_Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pembayaran_Keterangan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Pembayaran_Via = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pembayaran_StatusTerbayar = table.Column<bool>(type: "bit", nullable: true),
                    Pembayaran_Total = table.Column<decimal>(type: "money", nullable: true),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6PembelianAset", x => x.IdPembelianAset);
                    table.ForeignKey(
                        name: "FK_T6PembelianAset_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6PembelianAset_T0JenisSupplier_IdJenisSupplier",
                        column: x => x.IdJenisSupplier,
                        principalTable: "T0JenisSupplier",
                        principalColumn: "IdJenisSupplier");
                    table.ForeignKey(
                        name: "FK_T6PembelianAset_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PembelianAset_T1Karyawan_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PembelianAset_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PembelianAset_T1Karyawan_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PembelianAset_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PembelianAset_T1Supplier_IdSupplier",
                        column: x => x.IdSupplier,
                        principalTable: "T1Supplier",
                        principalColumn: "IdSupplier");
                });

            migrationBuilder.CreateTable(
                name: "T6PHutangGiro",
                columns: table => new
                {
                    IdHutangGiro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdJenisSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdRekening = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdForm = table.Column<long>(type: "bigint", nullable: true),
                    Referensi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Nomor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BankEntitas = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    AtasNama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut01 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut02 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut03 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut04 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut05 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut06 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut07 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut08 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut09 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut10 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Nominal = table.Column<decimal>(type: "money", nullable: true),
                    TanggalJatuhTempo = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Foto = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StatusPencairan = table.Column<bool>(type: "bit", nullable: true),
                    Supplier_Nama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Supplier_Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Supplier_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplier_Supplier = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    JenisSupplier_Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Rekening_Rekening = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Form_Form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6PHutangGiro", x => x.IdHutangGiro);
                    table.ForeignKey(
                        name: "FK_T6PHutangGiro_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6PHutangGiro_T0Form_IdForm",
                        column: x => x.IdForm,
                        principalTable: "T0Form",
                        principalColumn: "IdForm");
                    table.ForeignKey(
                        name: "FK_T6PHutangGiro_T0JenisSupplier_IdJenisSupplier",
                        column: x => x.IdJenisSupplier,
                        principalTable: "T0JenisSupplier",
                        principalColumn: "IdJenisSupplier");
                    table.ForeignKey(
                        name: "FK_T6PHutangGiro_T0Rekening_IdRekening",
                        column: x => x.IdRekening,
                        principalTable: "T0Rekening",
                        principalColumn: "IdRekening");
                    table.ForeignKey(
                        name: "FK_T6PHutangGiro_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PHutangGiro_T1Karyawan_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PHutangGiro_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PHutangGiro_T1Karyawan_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PHutangGiro_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PHutangGiro_T1Supplier_IdSupplier",
                        column: x => x.IdSupplier,
                        principalTable: "T1Supplier",
                        principalColumn: "IdSupplier");
                });

            migrationBuilder.CreateTable(
                name: "T7PenugasanArmada_SPBU",
                columns: table => new
                {
                    IdDetilPenugasanArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPenugasanArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupplier_SPBU = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdBBM = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Kode1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Kode2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BBMVolume = table.Column<int>(type: "int", nullable: true),
                    BBMVolumeSisa = table.Column<decimal>(type: "money", nullable: true),
                    BBMHarga = table.Column<decimal>(type: "money", nullable: true),
                    BBMTotal = table.Column<decimal>(type: "money", nullable: true),
                    TanggalPengisian = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Referensi_Form = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Supplier_SPBU_Nama = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Supplier_SPBU_Inisial = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Supplier_SPBU_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Supplier_SPBU_Kota = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Supplier_SPBU_Email1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Supplier_SPBU_Phone1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Supplier_SPBU_FaxPhone1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JenisSupplier_Jenis = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BBM_BBM = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T7PenugasanArmada_SPBU", x => x.IdDetilPenugasanArmada);
                    table.ForeignKey(
                        name: "FK_T7PenugasanArmada_SPBU_T0BBM_IdBBM",
                        column: x => x.IdBBM,
                        principalTable: "T0BBM",
                        principalColumn: "IdBBM");
                    table.ForeignKey(
                        name: "FK_T7PenugasanArmada_SPBU_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PenugasanArmada_SPBU_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PenugasanArmada_SPBU_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PenugasanArmada_SPBU_T1Supplier_IdSupplier_SPBU",
                        column: x => x.IdSupplier_SPBU,
                        principalTable: "T1Supplier",
                        principalColumn: "IdSupplier");
                    table.ForeignKey(
                        name: "FK_T7PenugasanArmada_SPBU_T6PenugasanArmada_IdPenugasanArmada",
                        column: x => x.IdPenugasanArmada,
                        principalTable: "T6PenugasanArmada",
                        principalColumn: "IdPenugasanArmada");
                });

            migrationBuilder.CreateTable(
                name: "T2AlamatVendor",
                columns: table => new
                {
                    IdAlamatVendor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdVendor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKota = table.Column<long>(type: "bigint", nullable: true),
                    IdKecamatan = table.Column<long>(type: "bigint", nullable: true),
                    IdKelurahan = table.Column<long>(type: "bigint", nullable: true),
                    JenisAlamat = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StatusUtama = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T2AlamatVendor", x => x.IdAlamatVendor);
                    table.ForeignKey(
                        name: "FK_T2AlamatVendor_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2AlamatVendor_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2AlamatVendor_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2AlamatVendor_T1Vendor_IdVendor",
                        column: x => x.IdVendor,
                        principalTable: "T1Vendor",
                        principalColumn: "IdVendor");
                    table.ForeignKey(
                        name: "FK_T2AlamatVendor_T2Kota_IdKota",
                        column: x => x.IdKota,
                        principalTable: "T2Kota",
                        principalColumn: "IdKota");
                    table.ForeignKey(
                        name: "FK_T2AlamatVendor_T3Kecamatan_IdKecamatan",
                        column: x => x.IdKecamatan,
                        principalTable: "T3Kecamatan",
                        principalColumn: "IdKecamatan");
                    table.ForeignKey(
                        name: "FK_T2AlamatVendor_T4Kelurahan_IdKelurahan",
                        column: x => x.IdKelurahan,
                        principalTable: "T4Kelurahan",
                        principalColumn: "IdKelurahan");
                });

            migrationBuilder.CreateTable(
                name: "T2PenyeliaVendor",
                columns: table => new
                {
                    IdPenyeliaVendor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdVendor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nama = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Prefix = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    JenisKelamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Jabatan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NIP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Messenger = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Rekening = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StatusUtama = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T2PenyeliaVendor", x => x.IdPenyeliaVendor);
                    table.ForeignKey(
                        name: "FK_T2PenyeliaVendor_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2PenyeliaVendor_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2PenyeliaVendor_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T2PenyeliaVendor_T1Vendor_IdVendor",
                        column: x => x.IdVendor,
                        principalTable: "T1Vendor",
                        principalColumn: "IdVendor");
                });

            migrationBuilder.CreateTable(
                name: "T3Rute",
                columns: table => new
                {
                    IdRute = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAlamatCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPenyeliaCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Rute = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Alias = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Jenis = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstimasiWaktu = table.Column<int>(type: "int", nullable: true),
                    EstimasiJarak = table.Column<int>(type: "int", nullable: true),
                    Muatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StatusRutePaket = table.Column<bool>(type: "bit", nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T3Rute", x => x.IdRute);
                    table.ForeignKey(
                        name: "FK_T3Rute_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T3Rute_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T3Rute_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T3Rute_T2AlamatCustomer_IdAlamatCustomer",
                        column: x => x.IdAlamatCustomer,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T3Rute_T2PenyeliaCustomer_IdPenyeliaCustomer",
                        column: x => x.IdPenyeliaCustomer,
                        principalTable: "T2PenyeliaCustomer",
                        principalColumn: "IdPenyeliaCustomer");
                });

            migrationBuilder.CreateTable(
                name: "T6OrderPenjualan",
                columns: table => new
                {
                    IdOrderPenjualan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdJenisTransaksi = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdJenisCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_KirimBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_KirimDokumen = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_Legal = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPenyeliaCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCompany_Pengirim = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdKaryawan_Salesman = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuKirim = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    KodePOCustomer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Attn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DeliveryBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DiskonDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonNominal = table.Column<decimal>(type: "money", nullable: true),
                    PPNDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PPNNominal = table.Column<decimal>(type: "money", nullable: true),
                    GrandTotal = table.Column<decimal>(type: "money", nullable: true),
                    JenisTransaksi_Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    JenisCustomer_Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Nama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Customer_Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Customer_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_StatusPKP = table.Column<bool>(type: "bit", nullable: true),
                    Customer_NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Customer = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    AlamatCustomer_KirimBarang_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimBarang_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_KirimBarang_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimBarang_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimBarang_Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimDokumen_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimDokumen_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_KirimDokumen_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimDokumen_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimDokumen_Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_Legal_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_Legal_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_Legal_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_Legal_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_Legal_KTP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_Legal_NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Nama = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PenyeliaCustomer_Prefix = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PenyeliaCustomer_JenisKelamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PenyeliaCustomer_Jabatan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Salesman_NamaPanggilan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pembayaran_Total = table.Column<decimal>(type: "money", nullable: true),
                    Pembayaran_Keterangan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Pembayaran_Via = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pembayaran_StatusTerbayar = table.Column<bool>(type: "bit", nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6OrderPenjualan", x => x.IdOrderPenjualan);
                    table.ForeignKey(
                        name: "FK_T6OrderPenjualan_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6OrderPenjualan_T0Company_IdCompany_Pengirim",
                        column: x => x.IdCompany_Pengirim,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6OrderPenjualan_T0JenisCustomer_IdJenisCustomer",
                        column: x => x.IdJenisCustomer,
                        principalTable: "T0JenisCustomer",
                        principalColumn: "IdJenisCustomer");
                    table.ForeignKey(
                        name: "FK_T6OrderPenjualan_T0JenisTransaksi_IdJenisTransaksi",
                        column: x => x.IdJenisTransaksi,
                        principalTable: "T0JenisTransaksi",
                        principalColumn: "IdJenisTransaksi");
                    table.ForeignKey(
                        name: "FK_T6OrderPenjualan_T1Customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "T1Customer",
                        principalColumn: "IdCustomer");
                    table.ForeignKey(
                        name: "FK_T6OrderPenjualan_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6OrderPenjualan_T1Karyawan_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6OrderPenjualan_T1Karyawan_IdKaryawan_Salesman",
                        column: x => x.IdKaryawan_Salesman,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6OrderPenjualan_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6OrderPenjualan_T1Karyawan_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6OrderPenjualan_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6OrderPenjualan_T2AlamatCustomer_IdAlamatCustomer_KirimBarang",
                        column: x => x.IdAlamatCustomer_KirimBarang,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T6OrderPenjualan_T2AlamatCustomer_IdAlamatCustomer_KirimDokumen",
                        column: x => x.IdAlamatCustomer_KirimDokumen,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T6OrderPenjualan_T2AlamatCustomer_IdAlamatCustomer_Legal",
                        column: x => x.IdAlamatCustomer_Legal,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T6OrderPenjualan_T2PenyeliaCustomer_IdPenyeliaCustomer",
                        column: x => x.IdPenyeliaCustomer,
                        principalTable: "T2PenyeliaCustomer",
                        principalColumn: "IdPenyeliaCustomer");
                });

            migrationBuilder.CreateTable(
                name: "T6PiutangUsaha",
                columns: table => new
                {
                    IdPiutangUsaha = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdJenisCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_KirimBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_KirimDokumen = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_Legal = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPenyeliaCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdForm = table.Column<long>(type: "bigint", nullable: true),
                    Referensi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Atribut01 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut02 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut03 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut04 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut05 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut06 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut07 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut08 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut09 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut10 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Nominal = table.Column<decimal>(type: "money", nullable: true),
                    TanggalJatuhTempo = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StatusPelunasan = table.Column<bool>(type: "bit", nullable: true),
                    JenisCustomer_Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Nama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Customer_Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Customer_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_StatusPKP = table.Column<bool>(type: "bit", nullable: true),
                    Customer_NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Customer = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    AlamatCustomer_KirimBarang_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimBarang_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_KirimBarang_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimBarang_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimBarang_Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimDokumen_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimDokumen_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_KirimDokumen_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimDokumen_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimDokumen_Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_Legal_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_Legal_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_Legal_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_Legal_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_Legal_KTP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_Legal_NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Nama = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PenyeliaCustomer_Prefix = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PenyeliaCustomer_JenisKelamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PenyeliaCustomer_Jabatan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Form_Form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6PiutangUsaha", x => x.IdPiutangUsaha);
                    table.ForeignKey(
                        name: "FK_T6PiutangUsaha_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6PiutangUsaha_T0Form_IdForm",
                        column: x => x.IdForm,
                        principalTable: "T0Form",
                        principalColumn: "IdForm");
                    table.ForeignKey(
                        name: "FK_T6PiutangUsaha_T0JenisCustomer_IdJenisCustomer",
                        column: x => x.IdJenisCustomer,
                        principalTable: "T0JenisCustomer",
                        principalColumn: "IdJenisCustomer");
                    table.ForeignKey(
                        name: "FK_T6PiutangUsaha_T1Customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "T1Customer",
                        principalColumn: "IdCustomer");
                    table.ForeignKey(
                        name: "FK_T6PiutangUsaha_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PiutangUsaha_T1Karyawan_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PiutangUsaha_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PiutangUsaha_T1Karyawan_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PiutangUsaha_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PiutangUsaha_T2AlamatCustomer_IdAlamatCustomer_KirimBarang",
                        column: x => x.IdAlamatCustomer_KirimBarang,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T6PiutangUsaha_T2AlamatCustomer_IdAlamatCustomer_KirimDokumen",
                        column: x => x.IdAlamatCustomer_KirimDokumen,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T6PiutangUsaha_T2AlamatCustomer_IdAlamatCustomer_Legal",
                        column: x => x.IdAlamatCustomer_Legal,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T6PiutangUsaha_T2PenyeliaCustomer_IdPenyeliaCustomer",
                        column: x => x.IdPenyeliaCustomer,
                        principalTable: "T2PenyeliaCustomer",
                        principalColumn: "IdPenyeliaCustomer");
                });

            migrationBuilder.CreateTable(
                name: "T6PPiutangGiro",
                columns: table => new
                {
                    IdPiutangGiro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdJenisCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_KirimBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_KirimDokumen = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_Legal = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPenyeliaCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdRekening = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdForm = table.Column<long>(type: "bigint", nullable: true),
                    Referensi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Nomor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BankEntitas = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    AtasNama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut01 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut02 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut03 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut04 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut05 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut06 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut07 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut08 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut09 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Atribut10 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Nominal = table.Column<decimal>(type: "money", nullable: true),
                    TanggalJatuhTempo = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Foto = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StatusPencairan = table.Column<bool>(type: "bit", nullable: true),
                    JenisCustomer_Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Nama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Customer_Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Customer_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_StatusPKP = table.Column<bool>(type: "bit", nullable: true),
                    Customer_NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Customer = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    AlamatCustomer_KirimBarang_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimBarang_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_KirimBarang_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimBarang_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimBarang_Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimDokumen_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimDokumen_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_KirimDokumen_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimDokumen_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimDokumen_Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_Legal_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_Legal_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_Legal_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_Legal_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_Legal_KTP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_Legal_NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Nama = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PenyeliaCustomer_Prefix = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PenyeliaCustomer_JenisKelamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PenyeliaCustomer_Jabatan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Rekening_Rekening = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Form_Form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6PPiutangGiro", x => x.IdPiutangGiro);
                    table.ForeignKey(
                        name: "FK_T6PPiutangGiro_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T6PPiutangGiro_T0JenisCustomer_IdJenisCustomer",
                        column: x => x.IdJenisCustomer,
                        principalTable: "T0JenisCustomer",
                        principalColumn: "IdJenisCustomer");
                    table.ForeignKey(
                        name: "FK_T6PPiutangGiro_T0Rekening_IdRekening",
                        column: x => x.IdRekening,
                        principalTable: "T0Rekening",
                        principalColumn: "IdRekening");
                    table.ForeignKey(
                        name: "FK_T6PPiutangGiro_T1Customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "T1Customer",
                        principalColumn: "IdCustomer");
                    table.ForeignKey(
                        name: "FK_T6PPiutangGiro_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PPiutangGiro_T1Karyawan_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PPiutangGiro_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PPiutangGiro_T1Karyawan_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PPiutangGiro_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T6PPiutangGiro_T2AlamatCustomer_IdAlamatCustomer_KirimBarang",
                        column: x => x.IdAlamatCustomer_KirimBarang,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T6PPiutangGiro_T2AlamatCustomer_IdAlamatCustomer_KirimDokumen",
                        column: x => x.IdAlamatCustomer_KirimDokumen,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T6PPiutangGiro_T2AlamatCustomer_IdAlamatCustomer_Legal",
                        column: x => x.IdAlamatCustomer_Legal,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T6PPiutangGiro_T2PenyeliaCustomer_IdPenyeliaCustomer",
                        column: x => x.IdPenyeliaCustomer,
                        principalTable: "T2PenyeliaCustomer",
                        principalColumn: "IdPenyeliaCustomer");
                });

            migrationBuilder.CreateTable(
                name: "T4DiskonBarang",
                columns: table => new
                {
                    IdDiskonBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdSatuan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiskonA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonB = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonD = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonF = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonH = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonI = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonJ = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonK = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonM = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonQ = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T4DiskonBarang", x => x.IdDiskonBarang);
                    table.ForeignKey(
                        name: "FK_T4DiskonBarang_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T4DiskonBarang_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4DiskonBarang_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4DiskonBarang_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4DiskonBarang_T3Satuan_IdSatuan",
                        column: x => x.IdSatuan,
                        principalTable: "T3Satuan",
                        principalColumn: "IdSatuan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T4HargaBarang",
                columns: table => new
                {
                    IdHargaBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: false),
                    IdSatuan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HargaTradeIn = table.Column<decimal>(type: "money", nullable: true),
                    HargaMinimum = table.Column<decimal>(type: "money", nullable: true),
                    HargaA = table.Column<decimal>(type: "money", nullable: true),
                    HargaB = table.Column<decimal>(type: "money", nullable: true),
                    HargaC = table.Column<decimal>(type: "money", nullable: true),
                    HargaD = table.Column<decimal>(type: "money", nullable: true),
                    HargaE = table.Column<decimal>(type: "money", nullable: true),
                    HargaF = table.Column<decimal>(type: "money", nullable: true),
                    HargaG = table.Column<decimal>(type: "money", nullable: true),
                    HargaH = table.Column<decimal>(type: "money", nullable: true),
                    HargaI = table.Column<decimal>(type: "money", nullable: true),
                    HargaJ = table.Column<decimal>(type: "money", nullable: true),
                    HargaK = table.Column<decimal>(type: "money", nullable: true),
                    HargaL = table.Column<decimal>(type: "money", nullable: true),
                    HargaM = table.Column<decimal>(type: "money", nullable: true),
                    HargaN = table.Column<decimal>(type: "money", nullable: true),
                    HargaO = table.Column<decimal>(type: "money", nullable: true),
                    HargaP = table.Column<decimal>(type: "money", nullable: true),
                    HargaQ = table.Column<decimal>(type: "money", nullable: true),
                    HargaR = table.Column<decimal>(type: "money", nullable: true),
                    HargaS = table.Column<decimal>(type: "money", nullable: true),
                    HargaT = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T4HargaBarang", x => x.IdHargaBarang);
                    table.ForeignKey(
                        name: "FK_T4HargaBarang_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T4HargaBarang_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4HargaBarang_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4HargaBarang_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4HargaBarang_T3Satuan_IdSatuan",
                        column: x => x.IdSatuan,
                        principalTable: "T3Satuan",
                        principalColumn: "IdSatuan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T5CompanySatuan",
                columns: table => new
                {
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: false),
                    IdSatuan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Minimum = table.Column<long>(type: "bigint", nullable: true),
                    Maksimum = table.Column<long>(type: "bigint", nullable: true),
                    GaransiGanti = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GaransiParts = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GaransiServis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GaransiKetentuan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T5CompanySatuan", x => new { x.IdCompany, x.IdSatuan });
                    table.ForeignKey(
                        name: "FK_T5CompanySatuan_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T5CompanySatuan_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5CompanySatuan_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5CompanySatuan_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5CompanySatuan_T3Satuan_IdSatuan",
                        column: x => x.IdSatuan,
                        principalTable: "T3Satuan",
                        principalColumn: "IdSatuan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T5StokGudang",
                columns: table => new
                {
                    IdSatuan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGudang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StokBaru = table.Column<decimal>(type: "money", nullable: true),
                    StokBaruNominal = table.Column<decimal>(type: "money", nullable: true),
                    StokBaruLokasi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StokBekas = table.Column<decimal>(type: "money", nullable: true),
                    StokBekasNominal = table.Column<decimal>(type: "money", nullable: true),
                    StokBekasLokasi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StokRusak = table.Column<decimal>(type: "money", nullable: true),
                    StokRusakNominal = table.Column<decimal>(type: "money", nullable: true),
                    StokRusakLokasi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T5StokGudang", x => new { x.IdSatuan, x.IdGudang });
                    table.ForeignKey(
                        name: "FK_T5StokGudang_T0Gudang_IdGudang",
                        column: x => x.IdGudang,
                        principalTable: "T0Gudang",
                        principalColumn: "IdGudang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T5StokGudang_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5StokGudang_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5StokGudang_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5StokGudang_T3Satuan_IdSatuan",
                        column: x => x.IdSatuan,
                        principalTable: "T3Satuan",
                        principalColumn: "IdSatuan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T7OrderPembelian",
                columns: table => new
                {
                    IdDetilOrderPembelian = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdOrderPembelian = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdDetilPermintaanPembelian = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKurs = table.Column<long>(type: "bigint", nullable: true),
                    IdSatuan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSubDivisiBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSubKategoriBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdDivisiBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKategoriBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JenisBarang = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Jumlah = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Berat = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Harga = table.Column<decimal>(type: "money", nullable: true),
                    NilaiKurs = table.Column<decimal>(type: "money", nullable: true),
                    DiskonDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonNominal = table.Column<decimal>(type: "money", nullable: true),
                    CatatanOrder = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Persetujuan = table.Column<bool>(type: "bit", nullable: true),
                    WaktuPersetujuan = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CatatanPersetujuan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Pemutihan = table.Column<bool>(type: "bit", nullable: true),
                    JumlahRealisasi = table.Column<long>(type: "bigint", nullable: true),
                    StatusTerealisasi = table.Column<bool>(type: "bit", nullable: true),
                    Total = table.Column<decimal>(type: "money", nullable: true),
                    Referensi_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Referensi_IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Referensi_WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Kurs_Kurs = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kurs_Simbol = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Satuan_Satuan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Satuan_SKUKode1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Satuan_SKUKode2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Satuan_SKULevel = table.Column<byte>(type: "tinyint", nullable: true),
                    Satuan_SKUGrup = table.Column<byte>(type: "tinyint", nullable: true),
                    Satuan_SKURasio = table.Column<decimal>(type: "money", nullable: true),
                    Satuan_UseSerialNumber = table.Column<bool>(type: "bit", nullable: true),
                    Barang_Barang = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Barang_Kode1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Barang_Kode2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Barang_Merk = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Barang_Ukuran = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Barang_Warna = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Barang_Umur = table.Column<int>(type: "int", nullable: true),
                    SubDivisiBarang_SubDivisi = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SubKategoriBarang_SubKategori = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DivisiBarang_Divisi = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    KategoriBarang_Kategori = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Kuantum_IdSatuan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Kuantum_Kuantum = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Kuantum_Jumlah = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Kuantum_Harga = table.Column<decimal>(type: "money", nullable: true),
                    Kuantum_DiskonDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Kuantum_DiskonNominal = table.Column<decimal>(type: "money", nullable: true),
                    Kuantum_Total = table.Column<decimal>(type: "money", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T7OrderPembelian", x => x.IdDetilOrderPembelian);
                    table.ForeignKey(
                        name: "FK_T7OrderPembelian_T0DivisiBarang_IdDivisiBarang",
                        column: x => x.IdDivisiBarang,
                        principalTable: "T0DivisiBarang",
                        principalColumn: "IdDivisiBarang");
                    table.ForeignKey(
                        name: "FK_T7OrderPembelian_T0KategoriBarang_IdKategoriBarang",
                        column: x => x.IdKategoriBarang,
                        principalTable: "T0KategoriBarang",
                        principalColumn: "IdKategoriBarang");
                    table.ForeignKey(
                        name: "FK_T7OrderPembelian_T0Kurs_IdKurs",
                        column: x => x.IdKurs,
                        principalTable: "T0Kurs",
                        principalColumn: "IdKurs");
                    table.ForeignKey(
                        name: "FK_T7OrderPembelian_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7OrderPembelian_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7OrderPembelian_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7OrderPembelian_T1SubDivisiBarang_IdSubDivisiBarang",
                        column: x => x.IdSubDivisiBarang,
                        principalTable: "T1SubDivisiBarang",
                        principalColumn: "IdSubDivisiBarang");
                    table.ForeignKey(
                        name: "FK_T7OrderPembelian_T1SubKategoriBarang_IdSubKategoriBarang",
                        column: x => x.IdSubKategoriBarang,
                        principalTable: "T1SubKategoriBarang",
                        principalColumn: "IdSubKategoriBarang");
                    table.ForeignKey(
                        name: "FK_T7OrderPembelian_T2Barang_IdBarang",
                        column: x => x.IdBarang,
                        principalTable: "T2Barang",
                        principalColumn: "IdBarang");
                    table.ForeignKey(
                        name: "FK_T7OrderPembelian_T3Satuan_IdSatuan",
                        column: x => x.IdSatuan,
                        principalTable: "T3Satuan",
                        principalColumn: "IdSatuan");
                    table.ForeignKey(
                        name: "FK_T7OrderPembelian_T6OrderPembelian_IdOrderPembelian",
                        column: x => x.IdOrderPembelian,
                        principalTable: "T6OrderPembelian",
                        principalColumn: "IdOrderPembelian");
                });

            migrationBuilder.CreateTable(
                name: "T7PelunasanHutangUsaha",
                columns: table => new
                {
                    IdDetilPelunasanHutangUsaha = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPelunasanHutangUsaha = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdHutangUsaha = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TambahJatuhTempo = table.Column<int>(type: "int", nullable: true),
                    Nominal = table.Column<decimal>(type: "money", nullable: true),
                    Referensi_TanggalJatuhTempo = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Referensi_NominalSaldoAwal = table.Column<decimal>(type: "money", nullable: true),
                    Referensi_NominalSaldoBerjalan = table.Column<decimal>(type: "money", nullable: true),
                    Referensi_IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Referensi_WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Referensi_Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Referensi_Referensi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Referensi_Faktur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_Form_Form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T7PelunasanHutangUsaha", x => x.IdDetilPelunasanHutangUsaha);
                    table.ForeignKey(
                        name: "FK_T7PelunasanHutangUsaha_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PelunasanHutangUsaha_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PelunasanHutangUsaha_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PelunasanHutangUsaha_T6HutangUsaha_IdHutangUsaha",
                        column: x => x.IdHutangUsaha,
                        principalTable: "T6HutangUsaha",
                        principalColumn: "IdHutangUsaha");
                    table.ForeignKey(
                        name: "FK_T7PelunasanHutangUsaha_T6PelunasanHutangUsaha_IdPelunasanHutangUsaha",
                        column: x => x.IdPelunasanHutangUsaha,
                        principalTable: "T6PelunasanHutangUsaha",
                        principalColumn: "IdPelunasanHutangUsaha");
                });

            migrationBuilder.CreateTable(
                name: "T7PembelianAset",
                columns: table => new
                {
                    IdDetilPembelianAset = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPembelianAset = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAkun_AkumulasiPenyusutan = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdAkun_BiayaPenyusutan = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdJenisAset = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAset = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Jumlah = table.Column<decimal>(type: "money", nullable: false),
                    Berat = table.Column<decimal>(type: "money", nullable: false),
                    Harga = table.Column<decimal>(type: "money", nullable: true),
                    DiskonDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonNominal = table.Column<decimal>(type: "money", nullable: true),
                    Total = table.Column<decimal>(type: "money", nullable: true),
                    Akun_AkumulasiPenyusutan_Kode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Akun_AkumulasiPenyusutan_Akun = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Akun_AkumulasiPenyusutan_Alias = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Akun_BiayaPenyusutan_Kode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Akun_BiayaPenyusutan_Akun = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Akun_BiayaPenyusutan_Alias = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    JenisAset_Jenis = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Aset_Aset = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Armada_Inisial = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Armada_Nopol = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T7PembelianAset", x => x.IdDetilPembelianAset);
                    table.ForeignKey(
                        name: "FK_T7PembelianAset_T0Akun_IdAkun_AkumulasiPenyusutan",
                        column: x => x.IdAkun_AkumulasiPenyusutan,
                        principalTable: "T0Akun",
                        principalColumn: "IdAkun");
                    table.ForeignKey(
                        name: "FK_T7PembelianAset_T0Akun_IdAkun_BiayaPenyusutan",
                        column: x => x.IdAkun_BiayaPenyusutan,
                        principalTable: "T0Akun",
                        principalColumn: "IdAkun");
                    table.ForeignKey(
                        name: "FK_T7PembelianAset_T0JenisAset_IdJenisAset",
                        column: x => x.IdJenisAset,
                        principalTable: "T0JenisAset",
                        principalColumn: "IdJenisAset",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T7PembelianAset_T1Armada_IdArmada",
                        column: x => x.IdArmada,
                        principalTable: "T1Armada",
                        principalColumn: "IdArmada",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T7PembelianAset_T1Aset_IdAset",
                        column: x => x.IdAset,
                        principalTable: "T1Aset",
                        principalColumn: "IdAset",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T7PembelianAset_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PembelianAset_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PembelianAset_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PembelianAset_T6PembelianAset_IdPembelianAset",
                        column: x => x.IdPembelianAset,
                        principalTable: "T6PembelianAset",
                        principalColumn: "IdPembelianAset",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T7PencairanHutangGiro",
                columns: table => new
                {
                    IdDetilPencairanHutangGiro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPencairanHutangGiro = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdHutangGiro = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nominal = table.Column<decimal>(type: "money", nullable: true),
                    Supplier_Supplier = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Supplier_Alamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Referensi_Referensi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Referensi_IdForm = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Referensi_IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Referensi_WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Form_Form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T7PencairanHutangGiro", x => x.IdDetilPencairanHutangGiro);
                    table.ForeignKey(
                        name: "FK_T7PencairanHutangGiro_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PencairanHutangGiro_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PencairanHutangGiro_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PencairanHutangGiro_T6PHutangGiro_IdHutangGiro",
                        column: x => x.IdHutangGiro,
                        principalTable: "T6PHutangGiro",
                        principalColumn: "IdHutangGiro");
                    table.ForeignKey(
                        name: "FK_T7PencairanHutangGiro_T6PencairanHutangGiro_IdPencairanHutangGiro",
                        column: x => x.IdPencairanHutangGiro,
                        principalTable: "T6PencairanHutangGiro",
                        principalColumn: "IdPencairanHutangGiro");
                });

            migrationBuilder.CreateTable(
                name: "T4BiayaRute",
                columns: table => new
                {
                    IdBiayaRute = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdRute = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdJenisArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tonase = table.Column<int>(type: "int", nullable: true),
                    IdSPBU = table.Column<long>(type: "bigint", nullable: true),
                    BBMVolume = table.Column<int>(type: "int", nullable: true),
                    BBMMetode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SanguTonase = table.Column<decimal>(type: "money", nullable: true),
                    SanguRitase = table.Column<decimal>(type: "money", nullable: true),
                    Deposit = table.Column<decimal>(type: "money", nullable: true),
                    Komisi = table.Column<decimal>(type: "money", nullable: true),
                    BiayaLain = table.Column<decimal>(type: "money", nullable: true),
                    Bonus = table.Column<decimal>(type: "money", nullable: true),
                    ProsentaseDeposit = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProsentaseSanguTonase = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    HargaTonase = table.Column<decimal>(type: "money", nullable: true),
                    HargaRitase = table.Column<decimal>(type: "money", nullable: true),
                    JenisHargaDefault = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T4BiayaRute", x => x.IdBiayaRute);
                    table.ForeignKey(
                        name: "FK_T4BiayaRute_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T4BiayaRute_T0JenisArmada_IdJenisArmada",
                        column: x => x.IdJenisArmada,
                        principalTable: "T0JenisArmada",
                        principalColumn: "IdJenisArmada");
                    table.ForeignKey(
                        name: "FK_T4BiayaRute_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4BiayaRute_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4BiayaRute_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4BiayaRute_T3Rute_IdRute",
                        column: x => x.IdRute,
                        principalTable: "T3Rute",
                        principalColumn: "IdRute");
                });

            migrationBuilder.CreateTable(
                name: "T4TujuanBongkar",
                columns: table => new
                {
                    IdTujuanBongkar = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdRute = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKota = table.Column<long>(type: "bigint", nullable: true),
                    Penerima = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Phone1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Phone2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T4TujuanBongkar", x => x.IdTujuanBongkar);
                    table.ForeignKey(
                        name: "FK_T4TujuanBongkar_T1Customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "T1Customer",
                        principalColumn: "IdCustomer");
                    table.ForeignKey(
                        name: "FK_T4TujuanBongkar_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4TujuanBongkar_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4TujuanBongkar_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4TujuanBongkar_T2Kota_IdKota",
                        column: x => x.IdKota,
                        principalTable: "T2Kota",
                        principalColumn: "IdKota");
                    table.ForeignKey(
                        name: "FK_T4TujuanBongkar_T3Rute_IdRute",
                        column: x => x.IdRute,
                        principalTable: "T3Rute",
                        principalColumn: "IdRute");
                });

            migrationBuilder.CreateTable(
                name: "T5DokumenRute",
                columns: table => new
                {
                    JenisDokumen = table.Column<string>(type: "varchar(900)", unicode: false, nullable: false),
                    IdRute = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T5DokumenRute", x => new { x.JenisDokumen, x.IdRute });
                    table.ForeignKey(
                        name: "FK_T5DokumenRute_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5DokumenRute_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5DokumenRute_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T5DokumenRute_T3Rute_IdRute",
                        column: x => x.IdRute,
                        principalTable: "T3Rute",
                        principalColumn: "IdRute",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T7PenugasanArmada",
                columns: table => new
                {
                    IdDetilPenugasanArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPenugasanArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdRute = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdJenisCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPenyeliaCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuPenugasan = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Urutan = table.Column<int>(type: "int", nullable: true),
                    TonaseAwal = table.Column<int>(type: "int", nullable: true),
                    TonaseRealisasi = table.Column<int>(type: "int", nullable: true),
                    Muatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BBMVolume = table.Column<int>(type: "int", nullable: true),
                    BBMMetode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BBMHarga = table.Column<decimal>(type: "money", nullable: true),
                    SanguTonase = table.Column<decimal>(type: "money", nullable: true),
                    SanguRitase = table.Column<decimal>(type: "money", nullable: true),
                    SanguSementara = table.Column<decimal>(type: "money", nullable: true),
                    ProsentaseSanguTonase = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Deposit = table.Column<decimal>(type: "money", nullable: true),
                    ProsentaseDeposit = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BonSopir = table.Column<decimal>(type: "money", nullable: true),
                    Komisi = table.Column<decimal>(type: "money", nullable: true),
                    HargaTonase = table.Column<decimal>(type: "money", nullable: true),
                    HargaRitase = table.Column<decimal>(type: "money", nullable: true),
                    JenisHarga = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TotalHarga = table.Column<decimal>(type: "money", nullable: true),
                    TotalAkhir = table.Column<decimal>(type: "money", nullable: true),
                    KelebihanSanguSementara = table.Column<decimal>(type: "money", nullable: true),
                    SisaSangu = table.Column<decimal>(type: "money", nullable: true),
                    StatusSuratJalan = table.Column<bool>(type: "bit", nullable: true),
                    StatusPenagihan = table.Column<bool>(type: "bit", nullable: true),
                    KeteranganRute = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Rute_Rute = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Rute_Jenis = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Customer_Nama = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Customer_Inisial = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Customer_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Customer_Kota = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Customer_Email1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Customer_Phone1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Customer_FaxPhone1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JenisCustomer_Jenis = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PenyeliaCustomer_Nama = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PenyeliaCustomer_JenisKelamin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PenyeliaCustomer_Jabatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_KodePos = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_Kota = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    WaktuProses_Pembayaran = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoPenugasan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T7PenugasanArmada", x => x.IdDetilPenugasanArmada);
                    table.ForeignKey(
                        name: "FK_T7PenugasanArmada_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T7PenugasanArmada_T1Customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "T1Customer",
                        principalColumn: "IdCustomer");
                    table.ForeignKey(
                        name: "FK_T7PenugasanArmada_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PenugasanArmada_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PenugasanArmada_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PenugasanArmada_T2AlamatCustomer_IdAlamatCustomer",
                        column: x => x.IdAlamatCustomer,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T7PenugasanArmada_T2PenyeliaCustomer_IdPenyeliaCustomer",
                        column: x => x.IdPenyeliaCustomer,
                        principalTable: "T2PenyeliaCustomer",
                        principalColumn: "IdPenyeliaCustomer");
                    table.ForeignKey(
                        name: "FK_T7PenugasanArmada_T3Rute_IdRute",
                        column: x => x.IdRute,
                        principalTable: "T3Rute",
                        principalColumn: "IdRute");
                    table.ForeignKey(
                        name: "FK_T7PenugasanArmada_T6PenugasanArmada_IdPenugasanArmada",
                        column: x => x.IdPenugasanArmada,
                        principalTable: "T6PenugasanArmada",
                        principalColumn: "IdPenugasanArmada");
                });

            migrationBuilder.CreateTable(
                name: "T7PelunasanPiutangUsaha",
                columns: table => new
                {
                    IdDetilPelunasanPiutangUsaha = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPelunasanPiutangUsaha = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPiutangUsaha = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_KirimBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_KirimDokumen = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_Legal = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPenyeliaCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TambahJatuhTempo = table.Column<int>(type: "int", nullable: true),
                    Nominal = table.Column<decimal>(type: "money", nullable: true),
                    PiutangUsaha_TanggalJatuhTempo = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    PiutangUsaha_NominalSaldoAwal = table.Column<decimal>(type: "money", nullable: true),
                    PiutangUsaha_NominalSaldoBerjalan = table.Column<decimal>(type: "money", nullable: true),
                    PiutangUsaha_Keterangan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PiutangUsaha_Referensi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PiutangUsaha_Atribut01 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PiutangUsaha_Atribut02 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PiutangUsaha_Atribut03 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PiutangUsaha_Atribut04 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PiutangUsaha_Atribut05 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PiutangUsaha_Atribut06 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PiutangUsaha_Atribut07 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PiutangUsaha_Atribut08 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PiutangUsaha_Atribut09 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PiutangUsaha_Atribut10 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PiutangUsaha_Form_Form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Referensi_NoFakturPajak = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_AlamatCustomer_KirimBarang_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Referensi_AlamatCustomer_KirimBarang_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Referensi_AlamatCustomer_KirimBarang_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_AlamatCustomer_KirimBarang_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_AlamatCustomer_KirimBarang_Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Referensi_AlamatCustomer_KirimDokumen_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Referensi_AlamatCustomer_KirimDokumen_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Referensi_AlamatCustomer_KirimDokumen_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_AlamatCustomer_KirimDokumen_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_AlamatCustomer_KirimDokumen_Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Referensi_AlamatCustomer_Legal_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Referensi_AlamatCustomer_Legal_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Referensi_AlamatCustomer_Legal_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_AlamatCustomer_Legal_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_AlamatCustomer_Legal_KTP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_AlamatCustomer_Legal_NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_PenyeliaCustomer_Nama = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Referensi_PenyeliaCustomer_Prefix = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Referensi_PenyeliaCustomer_JenisKelamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Referensi_PenyeliaCustomer_Jabatan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_PenyeliaCustomer_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_PenyeliaCustomer_Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_PenyeliaCustomer_Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_Karyawan_Salesman_NamaPanggilan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Referensi_NoTransaksi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T7PelunasanPiutangUsaha", x => x.IdDetilPelunasanPiutangUsaha);
                    table.ForeignKey(
                        name: "FK_T7PelunasanPiutangUsaha_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PelunasanPiutangUsaha_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PelunasanPiutangUsaha_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PelunasanPiutangUsaha_T2AlamatCustomer_IdAlamatCustomer_KirimBarang",
                        column: x => x.IdAlamatCustomer_KirimBarang,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T7PelunasanPiutangUsaha_T2AlamatCustomer_IdAlamatCustomer_KirimDokumen",
                        column: x => x.IdAlamatCustomer_KirimDokumen,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T7PelunasanPiutangUsaha_T2AlamatCustomer_IdAlamatCustomer_Legal",
                        column: x => x.IdAlamatCustomer_Legal,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T7PelunasanPiutangUsaha_T2PenyeliaCustomer_IdPenyeliaCustomer",
                        column: x => x.IdPenyeliaCustomer,
                        principalTable: "T2PenyeliaCustomer",
                        principalColumn: "IdPenyeliaCustomer");
                    table.ForeignKey(
                        name: "FK_T7PelunasanPiutangUsaha_T6PelunasanPiutangUsaha_IdPelunasanPiutangUsaha",
                        column: x => x.IdPelunasanPiutangUsaha,
                        principalTable: "T6PelunasanPiutangUsaha",
                        principalColumn: "IdPelunasanPiutangUsaha");
                    table.ForeignKey(
                        name: "FK_T7PelunasanPiutangUsaha_T6PiutangUsaha_IdPiutangUsaha",
                        column: x => x.IdPiutangUsaha,
                        principalTable: "T6PiutangUsaha",
                        principalColumn: "IdPiutangUsaha");
                });

            migrationBuilder.CreateTable(
                name: "T7PencairanPiutangGiro",
                columns: table => new
                {
                    IdDetilPencairanPiutangGiro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPencairanPiutangGiro = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPiutangGiro = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdJenisCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_KirimBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_KirimDokumen = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_Legal = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPenyeliaCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nominal = table.Column<decimal>(type: "money", nullable: true),
                    Referensi_Keterangan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_Referensi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Referensi_Faktur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_Form_Form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Referensi_NoTransaksi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Referensi_IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    JenisCustomer_Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Nama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Customer_Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Alamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Customer_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_StatusPKP = table.Column<bool>(type: "bit", nullable: true),
                    Customer_NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Customer = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimBarang_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimBarang_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_KirimBarang_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimBarang_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimBarang_Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimDokumen_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimDokumen_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_KirimDokumen_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimDokumen_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimDokumen_Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_Legal_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_Legal_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_Legal_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_Legal_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_Legal_KTP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_Legal_NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Nama = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PenyeliaCustomer_Prefix = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PenyeliaCustomer_JenisKelamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PenyeliaCustomer_Jabatan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T7PencairanPiutangGiro", x => x.IdDetilPencairanPiutangGiro);
                    table.ForeignKey(
                        name: "FK_T7PencairanPiutangGiro_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PencairanPiutangGiro_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PencairanPiutangGiro_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7PencairanPiutangGiro_T2AlamatCustomer_IdAlamatCustomer_KirimBarang",
                        column: x => x.IdAlamatCustomer_KirimBarang,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T7PencairanPiutangGiro_T2AlamatCustomer_IdAlamatCustomer_KirimDokumen",
                        column: x => x.IdAlamatCustomer_KirimDokumen,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T7PencairanPiutangGiro_T2AlamatCustomer_IdAlamatCustomer_Legal",
                        column: x => x.IdAlamatCustomer_Legal,
                        principalTable: "T2AlamatCustomer",
                        principalColumn: "IdAlamatCustomer");
                    table.ForeignKey(
                        name: "FK_T7PencairanPiutangGiro_T2PenyeliaCustomer_IdPenyeliaCustomer",
                        column: x => x.IdPenyeliaCustomer,
                        principalTable: "T2PenyeliaCustomer",
                        principalColumn: "IdPenyeliaCustomer");
                    table.ForeignKey(
                        name: "FK_T7PencairanPiutangGiro_T6PPiutangGiro_IdPiutangGiro",
                        column: x => x.IdPiutangGiro,
                        principalTable: "T6PPiutangGiro",
                        principalColumn: "IdPiutangGiro");
                    table.ForeignKey(
                        name: "FK_T7PencairanPiutangGiro_T6PencairanPiutangGiro_IdPencairanPiutangGiro",
                        column: x => x.IdPencairanPiutangGiro,
                        principalTable: "T6PencairanPiutangGiro",
                        principalColumn: "IdPencairanPiutangGiro");
                });

            migrationBuilder.CreateTable(
                name: "T7OrderPenjualan",
                columns: table => new
                {
                    IdDetilOrderPenjualan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdOrderPenjualan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdDetilKontrakPenjualan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKurs = table.Column<long>(type: "bigint", nullable: true),
                    IdSatuan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSubDivisiBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSubKategoriBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdDivisiBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKategoriBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdDiskonBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdHargaBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JenisBarang = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Jumlah = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Berat = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Harga = table.Column<decimal>(type: "money", nullable: true),
                    NilaiKurs = table.Column<decimal>(type: "money", nullable: true),
                    DiskonDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonNominal = table.Column<decimal>(type: "money", nullable: true),
                    JenisHargaDiskon = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CatatanOrder = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Persetujuan = table.Column<bool>(type: "bit", nullable: true),
                    WaktuPersetujuan = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CatatanPersetujuan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Pemutihan = table.Column<bool>(type: "bit", nullable: true),
                    JumlahRealisasi = table.Column<long>(type: "bigint", nullable: true),
                    StatusTerealisasi = table.Column<bool>(type: "bit", nullable: true),
                    Total = table.Column<decimal>(type: "money", nullable: true),
                    Referensi_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Referensi_IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Referensi_WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Kurs_Kurs = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kurs_Simbol = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Satuan_Satuan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Satuan_SKUKode1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Satuan_SKUKode2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Satuan_SKULevel = table.Column<byte>(type: "tinyint", nullable: true),
                    Satuan_SKUGrup = table.Column<byte>(type: "tinyint", nullable: true),
                    Satuan_SKURasio = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Satuan_UseSerialNumber = table.Column<bool>(type: "bit", nullable: true),
                    Barang_Barang = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Barang_Kode1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Barang_Kode2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Barang_Merk = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Barang_Ukuran = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Barang_Warna = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Barang_Umur = table.Column<int>(type: "int", nullable: true),
                    SubDivisiBarang_SubDivisi = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SubKategoriBarang_SubKategori = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DivisiBarang_Divisi = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    KategoriBarang_Kategori = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DiskonBarang_WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    HargaBarang_WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Kuantum_IdSatuan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Kuantum_IdDiskonBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Kuantum_IdHargaBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Kuantum_Kuantum = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Kuantum_Jumlah = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Kuantum_Harga = table.Column<decimal>(type: "money", nullable: true),
                    Kuantum_DiskonDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Kuantum_DiskonNominal = table.Column<decimal>(type: "money", nullable: true),
                    Kuantum_JenisHargaDiskon = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Kuantum_DiskonBarang_WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Kuantum_HargaBarang_WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Kuantum_Total = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T7OrderPenjualan", x => x.IdDetilOrderPenjualan);
                    table.ForeignKey(
                        name: "FK_T7OrderPenjualan_T0DivisiBarang_IdDivisiBarang",
                        column: x => x.IdDivisiBarang,
                        principalTable: "T0DivisiBarang",
                        principalColumn: "IdDivisiBarang");
                    table.ForeignKey(
                        name: "FK_T7OrderPenjualan_T0KategoriBarang_IdKategoriBarang",
                        column: x => x.IdKategoriBarang,
                        principalTable: "T0KategoriBarang",
                        principalColumn: "IdKategoriBarang");
                    table.ForeignKey(
                        name: "FK_T7OrderPenjualan_T0Kurs_IdKurs",
                        column: x => x.IdKurs,
                        principalTable: "T0Kurs",
                        principalColumn: "IdKurs");
                    table.ForeignKey(
                        name: "FK_T7OrderPenjualan_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7OrderPenjualan_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7OrderPenjualan_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T7OrderPenjualan_T1SubDivisiBarang_IdSubDivisiBarang",
                        column: x => x.IdSubDivisiBarang,
                        principalTable: "T1SubDivisiBarang",
                        principalColumn: "IdSubDivisiBarang");
                    table.ForeignKey(
                        name: "FK_T7OrderPenjualan_T1SubKategoriBarang_IdSubKategoriBarang",
                        column: x => x.IdSubKategoriBarang,
                        principalTable: "T1SubKategoriBarang",
                        principalColumn: "IdSubKategoriBarang");
                    table.ForeignKey(
                        name: "FK_T7OrderPenjualan_T2Barang_IdBarang",
                        column: x => x.IdBarang,
                        principalTable: "T2Barang",
                        principalColumn: "IdBarang");
                    table.ForeignKey(
                        name: "FK_T7OrderPenjualan_T3Satuan_IdSatuan",
                        column: x => x.IdSatuan,
                        principalTable: "T3Satuan",
                        principalColumn: "IdSatuan");
                    table.ForeignKey(
                        name: "FK_T7OrderPenjualan_T4DiskonBarang_IdDiskonBarang",
                        column: x => x.IdDiskonBarang,
                        principalTable: "T4DiskonBarang",
                        principalColumn: "IdDiskonBarang");
                    table.ForeignKey(
                        name: "FK_T7OrderPenjualan_T4HargaBarang_IdHargaBarang",
                        column: x => x.IdHargaBarang,
                        principalTable: "T4HargaBarang",
                        principalColumn: "IdHargaBarang");
                    table.ForeignKey(
                        name: "FK_T7OrderPenjualan_T6OrderPenjualan_IdOrderPenjualan",
                        column: x => x.IdOrderPenjualan,
                        principalTable: "T6OrderPenjualan",
                        principalColumn: "IdOrderPenjualan");
                });

            migrationBuilder.CreateTable(
                name: "T4BiayaRuteTonase",
                columns: table => new
                {
                    IdBiayaRuteTonase = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBiayaRute = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdJenisArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdRute = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BatasAwal = table.Column<int>(type: "int", nullable: true),
                    BatasAkhir = table.Column<int>(type: "int", nullable: true),
                    Harga = table.Column<decimal>(type: "money", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T4BiayaRuteTonase", x => x.IdBiayaRuteTonase);
                    table.ForeignKey(
                        name: "FK_T4BiayaRuteTonase_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T4BiayaRuteTonase_T0JenisArmada_IdJenisArmada",
                        column: x => x.IdJenisArmada,
                        principalTable: "T0JenisArmada",
                        principalColumn: "IdJenisArmada");
                    table.ForeignKey(
                        name: "FK_T4BiayaRuteTonase_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4BiayaRuteTonase_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4BiayaRuteTonase_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4BiayaRuteTonase_T3Rute_IdRute",
                        column: x => x.IdRute,
                        principalTable: "T3Rute",
                        principalColumn: "IdRute");
                    table.ForeignKey(
                        name: "FK_T4BiayaRuteTonase_T4BiayaRute_IdBiayaRute",
                        column: x => x.IdBiayaRute,
                        principalTable: "T4BiayaRute",
                        principalColumn: "IdBiayaRute");
                });

            migrationBuilder.CreateTable(
                name: "T4HargaRuteTonase",
                columns: table => new
                {
                    IdHargaRuteTonase = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBiayaRute = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdJenisArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdRute = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BatasAwal = table.Column<int>(type: "int", nullable: true),
                    BatasAkhir = table.Column<int>(type: "int", nullable: true),
                    Harga = table.Column<decimal>(type: "money", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T4HargaRuteTonase", x => x.IdHargaRuteTonase);
                    table.ForeignKey(
                        name: "FK_T4HargaRuteTonase_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany");
                    table.ForeignKey(
                        name: "FK_T4HargaRuteTonase_T0JenisArmada_IdJenisArmada",
                        column: x => x.IdJenisArmada,
                        principalTable: "T0JenisArmada",
                        principalColumn: "IdJenisArmada");
                    table.ForeignKey(
                        name: "FK_T4HargaRuteTonase_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4HargaRuteTonase_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4HargaRuteTonase_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T4HargaRuteTonase_T3Rute_IdRute",
                        column: x => x.IdRute,
                        principalTable: "T3Rute",
                        principalColumn: "IdRute");
                    table.ForeignKey(
                        name: "FK_T4HargaRuteTonase_T4BiayaRute_IdBiayaRute",
                        column: x => x.IdBiayaRute,
                        principalTable: "T4BiayaRute",
                        principalColumn: "IdBiayaRute");
                });

            migrationBuilder.CreateTable(
                name: "T8PenugasanArmada_Biaya",
                columns: table => new
                {
                    IdDetilDetilPenugasanArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDetilPenugasanArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAkun = table.Column<string>(type: "varchar(20)", unicode: false, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Nominal = table.Column<decimal>(type: "money", nullable: true),
                    Akun_Kode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Akun_Akun = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Akun_Alias = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Referensi_Form = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Referensi_Id = table.Column<long>(type: "bigint", nullable: true),
                    Referensi_NoTransaksi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Referensi_IdTransaksi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Referensi_WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Referensi_Rantai = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T8PenugasanArmada_Biaya", x => x.IdDetilDetilPenugasanArmada);
                    table.ForeignKey(
                        name: "FK_T8PenugasanArmada_Biaya_T0Akun_IdAkun",
                        column: x => x.IdAkun,
                        principalTable: "T0Akun",
                        principalColumn: "IdAkun");
                    table.ForeignKey(
                        name: "FK_T8PenugasanArmada_Biaya_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T8PenugasanArmada_Biaya_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T8PenugasanArmada_Biaya_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T8PenugasanArmada_Biaya_T7PenugasanArmada_IdDetilPenugasanArmada",
                        column: x => x.IdDetilPenugasanArmada,
                        principalTable: "T7PenugasanArmada",
                        principalColumn: "IdDetilPenugasanArmada");
                });

            migrationBuilder.CreateTable(
                name: "T8PenugasanArmada_SuratJalan",
                columns: table => new
                {
                    IdDetilDetilPenugasanArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDetilPenugasanArmada = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdTujuanBongkar = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKota = table.Column<long>(type: "bigint", nullable: true),
                    NomorSuratJalan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JenisBarang = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JumlahMuatan = table.Column<decimal>(type: "money", nullable: true),
                    JumlahKlaim = table.Column<decimal>(type: "money", nullable: true),
                    Satuan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TonaseMuatan = table.Column<int>(type: "int", nullable: true),
                    TonaseKlaim = table.Column<int>(type: "int", nullable: true),
                    NominalMuatan = table.Column<decimal>(type: "money", nullable: true),
                    NominalKlaim = table.Column<decimal>(type: "money", nullable: true),
                    TanggalMuat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TanggalBongkar = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TujuanBongkar_Penerima = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TujuanBongkar_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TujuanBongkar_Phone1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TujuanBongkar_Kota = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DokumenRute_Rute = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T8PenugasanArmada_SuratJalan", x => x.IdDetilDetilPenugasanArmada);
                    table.ForeignKey(
                        name: "FK_T8PenugasanArmada_SuratJalan_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T8PenugasanArmada_SuratJalan_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T8PenugasanArmada_SuratJalan_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T8PenugasanArmada_SuratJalan_T2Kota_IdKota",
                        column: x => x.IdKota,
                        principalTable: "T2Kota",
                        principalColumn: "IdKota");
                    table.ForeignKey(
                        name: "FK_T8PenugasanArmada_SuratJalan_T4TujuanBongkar_IdTujuanBongkar",
                        column: x => x.IdTujuanBongkar,
                        principalTable: "T4TujuanBongkar",
                        principalColumn: "IdTujuanBongkar");
                    table.ForeignKey(
                        name: "FK_T8PenugasanArmada_SuratJalan_T7PenugasanArmada_IdDetilPenugasanArmada",
                        column: x => x.IdDetilPenugasanArmada,
                        principalTable: "T7PenugasanArmada",
                        principalColumn: "IdDetilPenugasanArmada");
                });

            migrationBuilder.CreateIndex(
                name: "IX_T0Akun_IdCreator",
                table: "T0Akun",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Akun_IdKurs",
                table: "T0Akun",
                column: "IdKurs");

            migrationBuilder.CreateIndex(
                name: "IX_T0Akun_IdOperator",
                table: "T0Akun",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Akun_IdValidator",
                table: "T0Akun",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0BBM_IdCreator",
                table: "T0BBM",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0BBM_IdOperator",
                table: "T0BBM",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0BBM_IdValidator",
                table: "T0BBM",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Company_IdCreator",
                table: "T0Company",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Company_IdOperator",
                table: "T0Company",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Company_IdValidator",
                table: "T0Company",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0DivisiBarang_IdCreator",
                table: "T0DivisiBarang",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0DivisiBarang_IdOperator",
                table: "T0DivisiBarang",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0DivisiBarang_IdValidator",
                table: "T0DivisiBarang",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0DivisiPerusahaan_IdCreator",
                table: "T0DivisiPerusahaan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0DivisiPerusahaan_IdOperator",
                table: "T0DivisiPerusahaan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0DivisiPerusahaan_IdValidator",
                table: "T0DivisiPerusahaan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0DivisiServis_IdCreator",
                table: "T0DivisiServis",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0DivisiServis_IdOperator",
                table: "T0DivisiServis",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0DivisiServis_IdValidator",
                table: "T0DivisiServis",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Gudang_IdCreator",
                table: "T0Gudang",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Gudang_IdOperator",
                table: "T0Gudang",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Gudang_IdValidator",
                table: "T0Gudang",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Jabatan_IdCreator",
                table: "T0Jabatan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Jabatan_IdOperator",
                table: "T0Jabatan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Jabatan_IdValidator",
                table: "T0Jabatan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisArmada_IdCreator",
                table: "T0JenisArmada",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisArmada_IdOperator",
                table: "T0JenisArmada",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisArmada_IdValidator",
                table: "T0JenisArmada",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisAset_IdCreator",
                table: "T0JenisAset",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisAset_IdOperator",
                table: "T0JenisAset",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisAset_IdValidator",
                table: "T0JenisAset",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisCustomer_IdCreator",
                table: "T0JenisCustomer",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisCustomer_IdOperator",
                table: "T0JenisCustomer",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisCustomer_IdValidator",
                table: "T0JenisCustomer",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisSupplier_IdCreator",
                table: "T0JenisSupplier",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisSupplier_IdOperator",
                table: "T0JenisSupplier",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisSupplier_IdValidator",
                table: "T0JenisSupplier",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisTransaksi_IdCreator",
                table: "T0JenisTransaksi",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisTransaksi_IdOperator",
                table: "T0JenisTransaksi",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisTransaksi_IdValidator",
                table: "T0JenisTransaksi",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisVendor_IdCreator",
                table: "T0JenisVendor",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisVendor_IdOperator",
                table: "T0JenisVendor",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisVendor_IdValidator",
                table: "T0JenisVendor",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisWarna_IdCreator",
                table: "T0JenisWarna",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisWarna_IdOperator",
                table: "T0JenisWarna",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0JenisWarna_IdValidator",
                table: "T0JenisWarna",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0KategoriBarang_IdCreator",
                table: "T0KategoriBarang",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0KategoriBarang_IdOperator",
                table: "T0KategoriBarang",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0KategoriBarang_IdValidator",
                table: "T0KategoriBarang",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0KategoriJadwalKerjaKaryawan_IdCreator",
                table: "T0KategoriJadwalKerjaKaryawan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0KategoriJadwalKerjaKaryawan_IdOperator",
                table: "T0KategoriJadwalKerjaKaryawan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0KategoriJadwalKerjaKaryawan_IdValidator",
                table: "T0KategoriJadwalKerjaKaryawan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0KategoriServis_IdCreator",
                table: "T0KategoriServis",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0KategoriServis_IdOperator",
                table: "T0KategoriServis",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0KategoriServis_IdValidator",
                table: "T0KategoriServis",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Kurs_IdCreator",
                table: "T0Kurs",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Kurs_IdNegara",
                table: "T0Kurs",
                column: "IdNegara");

            migrationBuilder.CreateIndex(
                name: "IX_T0Kurs_IdOperator",
                table: "T0Kurs",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Kurs_IdValidator",
                table: "T0Kurs",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Negara_IdCreator",
                table: "T0Negara",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Negara_IdOperator",
                table: "T0Negara",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Negara_IdValidator",
                table: "T0Negara",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Rekening_IdCreator",
                table: "T0Rekening",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Rekening_IdOperator",
                table: "T0Rekening",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Rekening_IdValidator",
                table: "T0Rekening",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0SektorKota_IdCreator",
                table: "T0SektorKota",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0SektorKota_IdOperator",
                table: "T0SektorKota",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0SektorKota_IdValidator",
                table: "T0SektorKota",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0SektorNegara_IdCreator",
                table: "T0SektorNegara",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0SektorNegara_IdOperator",
                table: "T0SektorNegara",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0SektorNegara_IdValidator",
                table: "T0SektorNegara",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0SetJurnal_IdCreator",
                table: "T0SetJurnal",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0SetJurnal_IdFormTransaksi",
                table: "T0SetJurnal",
                column: "IdFormTransaksi");

            migrationBuilder.CreateIndex(
                name: "IX_T0SetJurnal_IdOperator",
                table: "T0SetJurnal",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0SetJurnal_IdValidator",
                table: "T0SetJurnal",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Armada_IdBBM",
                table: "T1Armada",
                column: "IdBBM");

            migrationBuilder.CreateIndex(
                name: "IX_T1Armada_IdCompany_Pemilik",
                table: "T1Armada",
                column: "IdCompany_Pemilik");

            migrationBuilder.CreateIndex(
                name: "IX_T1Armada_IdCreator",
                table: "T1Armada",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Armada_IdJenisArmada",
                table: "T1Armada",
                column: "IdJenisArmada");

            migrationBuilder.CreateIndex(
                name: "IX_T1Armada_IdOperator",
                table: "T1Armada",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Armada_IdSupplier_Pemilik",
                table: "T1Armada",
                column: "IdSupplier_Pemilik");

            migrationBuilder.CreateIndex(
                name: "IX_T1Armada_IdValidator",
                table: "T1Armada",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Aset_IdCreator",
                table: "T1Aset",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Aset_IdJenisAset",
                table: "T1Aset",
                column: "IdJenisAset");

            migrationBuilder.CreateIndex(
                name: "IX_T1Aset_IdOperator",
                table: "T1Aset",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Aset_IdValidator",
                table: "T1Aset",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Customer_IdCreator",
                table: "T1Customer",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Customer_IdJenisCustomer",
                table: "T1Customer",
                column: "IdJenisCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T1Customer_IdKecamatan",
                table: "T1Customer",
                column: "IdKecamatan");

            migrationBuilder.CreateIndex(
                name: "IX_T1Customer_IdKelurahan",
                table: "T1Customer",
                column: "IdKelurahan");

            migrationBuilder.CreateIndex(
                name: "IX_T1Customer_IdKota",
                table: "T1Customer",
                column: "IdKota");

            migrationBuilder.CreateIndex(
                name: "IX_T1Customer_IdNegara",
                table: "T1Customer",
                column: "IdNegara");

            migrationBuilder.CreateIndex(
                name: "IX_T1Customer_IdOperator",
                table: "T1Customer",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Customer_IdRekening",
                table: "T1Customer",
                column: "IdRekening");

            migrationBuilder.CreateIndex(
                name: "IX_T1Customer_IdSektorNegara",
                table: "T1Customer",
                column: "IdSektorNegara");

            migrationBuilder.CreateIndex(
                name: "IX_T1Customer_IdValidator",
                table: "T1Customer",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T1DetilForm_IdForm",
                table: "T1DetilForm",
                column: "IdForm");

            migrationBuilder.CreateIndex(
                name: "IX_T1JadwalKerjaKaryawan_IdCreator",
                table: "T1JadwalKerjaKaryawan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T1JadwalKerjaKaryawan_IdKategoriJadwalKerjaKaryawan",
                table: "T1JadwalKerjaKaryawan",
                column: "IdKategoriJadwalKerjaKaryawan");

            migrationBuilder.CreateIndex(
                name: "IX_T1JadwalKerjaKaryawan_IdOperator",
                table: "T1JadwalKerjaKaryawan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T1JadwalKerjaKaryawan_IdValidator",
                table: "T1JadwalKerjaKaryawan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Karyawan_IdCreator",
                table: "T1Karyawan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Karyawan_IdJabatan",
                table: "T1Karyawan",
                column: "IdJabatan");

            migrationBuilder.CreateIndex(
                name: "IX_T1Karyawan_IdOperator",
                table: "T1Karyawan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Karyawan_IdValidator",
                table: "T1Karyawan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Karyawan_T1JadwalKerjaKaryawanIdJadwalKerjaKaryawan",
                table: "T1Karyawan",
                column: "T1JadwalKerjaKaryawanIdJadwalKerjaKaryawan");

            migrationBuilder.CreateIndex(
                name: "IX_T1Provinsi_IdCreator",
                table: "T1Provinsi",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Provinsi_IdOperator",
                table: "T1Provinsi",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Provinsi_IdValidator",
                table: "T1Provinsi",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T1SetJurnal_IdAkun",
                table: "T1SetJurnal",
                column: "IdAkun");

            migrationBuilder.CreateIndex(
                name: "IX_T1SetJurnal_IdCreator",
                table: "T1SetJurnal",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T1SetJurnal_IdOperator",
                table: "T1SetJurnal",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T1SetJurnal_IdSetJurnal",
                table: "T1SetJurnal",
                column: "IdSetJurnal");

            migrationBuilder.CreateIndex(
                name: "IX_T1SetJurnal_IdValidator",
                table: "T1SetJurnal",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubDivisiBarang_IdCreator",
                table: "T1SubDivisiBarang",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubDivisiBarang_IdDivisiBarang",
                table: "T1SubDivisiBarang",
                column: "IdDivisiBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubDivisiBarang_IdOperator",
                table: "T1SubDivisiBarang",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubDivisiBarang_IdValidator",
                table: "T1SubDivisiBarang",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubDivisiServis_IdCreator",
                table: "T1SubDivisiServis",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubDivisiServis_IdDivisiServis",
                table: "T1SubDivisiServis",
                column: "IdDivisiServis");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubDivisiServis_IdOperator",
                table: "T1SubDivisiServis",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubDivisiServis_IdValidator",
                table: "T1SubDivisiServis",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubKategoriBarang_IdCreator",
                table: "T1SubKategoriBarang",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubKategoriBarang_IdKategoriBarang",
                table: "T1SubKategoriBarang",
                column: "IdKategoriBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubKategoriBarang_IdOperator",
                table: "T1SubKategoriBarang",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubKategoriBarang_IdValidator",
                table: "T1SubKategoriBarang",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubKategoriServis_IdCreator",
                table: "T1SubKategoriServis",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubKategoriServis_IdKategoriServis",
                table: "T1SubKategoriServis",
                column: "IdKategoriServis");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubKategoriServis_IdOperator",
                table: "T1SubKategoriServis",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T1SubKategoriServis_IdValidator",
                table: "T1SubKategoriServis",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Supplier_IdCreator",
                table: "T1Supplier",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Supplier_IdJenisSupplier",
                table: "T1Supplier",
                column: "IdJenisSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_T1Supplier_IdKota",
                table: "T1Supplier",
                column: "IdKota");

            migrationBuilder.CreateIndex(
                name: "IX_T1Supplier_IdOperator",
                table: "T1Supplier",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Supplier_IdValidator",
                table: "T1Supplier",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Vendor_IdCreator",
                table: "T1Vendor",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Vendor_IdJenisVendor",
                table: "T1Vendor",
                column: "IdJenisVendor");

            migrationBuilder.CreateIndex(
                name: "IX_T1Vendor_IdKecamatan",
                table: "T1Vendor",
                column: "IdKecamatan");

            migrationBuilder.CreateIndex(
                name: "IX_T1Vendor_IdKelurahan",
                table: "T1Vendor",
                column: "IdKelurahan");

            migrationBuilder.CreateIndex(
                name: "IX_T1Vendor_IdKota",
                table: "T1Vendor",
                column: "IdKota");

            migrationBuilder.CreateIndex(
                name: "IX_T1Vendor_IdNegara",
                table: "T1Vendor",
                column: "IdNegara");

            migrationBuilder.CreateIndex(
                name: "IX_T1Vendor_IdOperator",
                table: "T1Vendor",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Vendor_IdSektorNegara",
                table: "T1Vendor",
                column: "IdSektorNegara");

            migrationBuilder.CreateIndex(
                name: "IX_T1Vendor_IdValidator",
                table: "T1Vendor",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Warna_IdCreator",
                table: "T1Warna",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Warna_IdJenisWarna",
                table: "T1Warna",
                column: "IdJenisWarna");

            migrationBuilder.CreateIndex(
                name: "IX_T1Warna_IdOperator",
                table: "T1Warna",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T1Warna_IdValidator",
                table: "T1Warna",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatCustomer_IdCreator",
                table: "T2AlamatCustomer",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatCustomer_IdCustomer",
                table: "T2AlamatCustomer",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatCustomer_IdKecamatan",
                table: "T2AlamatCustomer",
                column: "IdKecamatan");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatCustomer_IdKelurahan",
                table: "T2AlamatCustomer",
                column: "IdKelurahan");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatCustomer_IdKota",
                table: "T2AlamatCustomer",
                column: "IdKota");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatCustomer_IdNegara",
                table: "T2AlamatCustomer",
                column: "IdNegara");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatCustomer_IdOperator",
                table: "T2AlamatCustomer",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatCustomer_IdValidator",
                table: "T2AlamatCustomer",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatSupplier_IdCreator",
                table: "T2AlamatSupplier",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatSupplier_IdKecamatan",
                table: "T2AlamatSupplier",
                column: "IdKecamatan");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatSupplier_IdKelurahan",
                table: "T2AlamatSupplier",
                column: "IdKelurahan");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatSupplier_IdKota",
                table: "T2AlamatSupplier",
                column: "IdKota");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatSupplier_IdOperator",
                table: "T2AlamatSupplier",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatSupplier_IdSupplier",
                table: "T2AlamatSupplier",
                column: "IdSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatSupplier_IdValidator",
                table: "T2AlamatSupplier",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatVendor_IdCreator",
                table: "T2AlamatVendor",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatVendor_IdKecamatan",
                table: "T2AlamatVendor",
                column: "IdKecamatan");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatVendor_IdKelurahan",
                table: "T2AlamatVendor",
                column: "IdKelurahan");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatVendor_IdKota",
                table: "T2AlamatVendor",
                column: "IdKota");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatVendor_IdOperator",
                table: "T2AlamatVendor",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatVendor_IdValidator",
                table: "T2AlamatVendor",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T2AlamatVendor_IdVendor",
                table: "T2AlamatVendor",
                column: "IdVendor");

            migrationBuilder.CreateIndex(
                name: "IX_T2Barang_IdCreator",
                table: "T2Barang",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T2Barang_IdOperator",
                table: "T2Barang",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T2Barang_IdSubDivisiBarang",
                table: "T2Barang",
                column: "IdSubDivisiBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T2Barang_IdSubKategoriBarang",
                table: "T2Barang",
                column: "IdSubKategoriBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T2Barang_IdValidator",
                table: "T2Barang",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T2Kota_IdCreator",
                table: "T2Kota",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T2Kota_IdOperator",
                table: "T2Kota",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T2Kota_IdValidator",
                table: "T2Kota",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T2PenyeliaCustomer_IdCreator",
                table: "T2PenyeliaCustomer",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T2PenyeliaCustomer_IdCustomer",
                table: "T2PenyeliaCustomer",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T2PenyeliaCustomer_IdOperator",
                table: "T2PenyeliaCustomer",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T2PenyeliaCustomer_IdValidator",
                table: "T2PenyeliaCustomer",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T2PenyeliaSupplier_IdCreator",
                table: "T2PenyeliaSupplier",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T2PenyeliaSupplier_IdOperator",
                table: "T2PenyeliaSupplier",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T2PenyeliaSupplier_IdSupplier",
                table: "T2PenyeliaSupplier",
                column: "IdSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_T2PenyeliaSupplier_IdValidator",
                table: "T2PenyeliaSupplier",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T2PenyeliaVendor_IdCreator",
                table: "T2PenyeliaVendor",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T2PenyeliaVendor_IdOperator",
                table: "T2PenyeliaVendor",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T2PenyeliaVendor_IdValidator",
                table: "T2PenyeliaVendor",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T2PenyeliaVendor_IdVendor",
                table: "T2PenyeliaVendor",
                column: "IdVendor");

            migrationBuilder.CreateIndex(
                name: "IX_T2Servis_IdCreator",
                table: "T2Servis",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T2Servis_IdOperator",
                table: "T2Servis",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T2Servis_IdSubDivisiServis",
                table: "T2Servis",
                column: "IdSubDivisiServis");

            migrationBuilder.CreateIndex(
                name: "IX_T2Servis_IdSubKategoriServis",
                table: "T2Servis",
                column: "IdSubKategoriServis");

            migrationBuilder.CreateIndex(
                name: "IX_T2Servis_IdValidator",
                table: "T2Servis",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T3Kecamatan_IdCreator",
                table: "T3Kecamatan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T3Kecamatan_IdOperator",
                table: "T3Kecamatan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T3Kecamatan_IdValidator",
                table: "T3Kecamatan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T3Pelabuhan_IdCreator",
                table: "T3Pelabuhan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T3Pelabuhan_IdOperator",
                table: "T3Pelabuhan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T3Pelabuhan_IdValidator",
                table: "T3Pelabuhan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T3Rute_IdAlamatCustomer",
                table: "T3Rute",
                column: "IdAlamatCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T3Rute_IdCreator",
                table: "T3Rute",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T3Rute_IdOperator",
                table: "T3Rute",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T3Rute_IdPenyeliaCustomer",
                table: "T3Rute",
                column: "IdPenyeliaCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T3Rute_IdValidator",
                table: "T3Rute",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T3Satuan_IdBarang",
                table: "T3Satuan",
                column: "IdBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T3Satuan_IdCreator",
                table: "T3Satuan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T3Satuan_IdOperator",
                table: "T3Satuan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T3Satuan_IdValidator",
                table: "T3Satuan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T4BiayaRute_IdCompany",
                table: "T4BiayaRute",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T4BiayaRute_IdCreator",
                table: "T4BiayaRute",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T4BiayaRute_IdJenisArmada",
                table: "T4BiayaRute",
                column: "IdJenisArmada");

            migrationBuilder.CreateIndex(
                name: "IX_T4BiayaRute_IdOperator",
                table: "T4BiayaRute",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T4BiayaRute_IdRute",
                table: "T4BiayaRute",
                column: "IdRute");

            migrationBuilder.CreateIndex(
                name: "IX_T4BiayaRute_IdValidator",
                table: "T4BiayaRute",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T4BiayaRuteTonase_IdBiayaRute",
                table: "T4BiayaRuteTonase",
                column: "IdBiayaRute");

            migrationBuilder.CreateIndex(
                name: "IX_T4BiayaRuteTonase_IdCompany",
                table: "T4BiayaRuteTonase",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T4BiayaRuteTonase_IdCreator",
                table: "T4BiayaRuteTonase",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T4BiayaRuteTonase_IdJenisArmada",
                table: "T4BiayaRuteTonase",
                column: "IdJenisArmada");

            migrationBuilder.CreateIndex(
                name: "IX_T4BiayaRuteTonase_IdOperator",
                table: "T4BiayaRuteTonase",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T4BiayaRuteTonase_IdRute",
                table: "T4BiayaRuteTonase",
                column: "IdRute");

            migrationBuilder.CreateIndex(
                name: "IX_T4BiayaRuteTonase_IdValidator",
                table: "T4BiayaRuteTonase",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T4DiskonBarang_IdCompany",
                table: "T4DiskonBarang",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T4DiskonBarang_IdCreator",
                table: "T4DiskonBarang",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T4DiskonBarang_IdOperator",
                table: "T4DiskonBarang",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T4DiskonBarang_IdSatuan",
                table: "T4DiskonBarang",
                column: "IdSatuan");

            migrationBuilder.CreateIndex(
                name: "IX_T4DiskonBarang_IdValidator",
                table: "T4DiskonBarang",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaBarang_IdCompany",
                table: "T4HargaBarang",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaBarang_IdCreator",
                table: "T4HargaBarang",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaBarang_IdOperator",
                table: "T4HargaBarang",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaBarang_IdSatuan",
                table: "T4HargaBarang",
                column: "IdSatuan");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaBarang_IdValidator",
                table: "T4HargaBarang",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaBBM_IdBBM",
                table: "T4HargaBBM",
                column: "IdBBM");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaBBM_IdCreator",
                table: "T4HargaBBM",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaBBM_IdOperator",
                table: "T4HargaBBM",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaBBM_IdValidator",
                table: "T4HargaBBM",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaRuteTonase_IdBiayaRute",
                table: "T4HargaRuteTonase",
                column: "IdBiayaRute");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaRuteTonase_IdCompany",
                table: "T4HargaRuteTonase",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaRuteTonase_IdCreator",
                table: "T4HargaRuteTonase",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaRuteTonase_IdJenisArmada",
                table: "T4HargaRuteTonase",
                column: "IdJenisArmada");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaRuteTonase_IdOperator",
                table: "T4HargaRuteTonase",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaRuteTonase_IdRute",
                table: "T4HargaRuteTonase",
                column: "IdRute");

            migrationBuilder.CreateIndex(
                name: "IX_T4HargaRuteTonase_IdValidator",
                table: "T4HargaRuteTonase",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T4Kelurahan_IdCreator",
                table: "T4Kelurahan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T4Kelurahan_IdOperator",
                table: "T4Kelurahan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T4Kelurahan_IdValidator",
                table: "T4Kelurahan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T4NopolArmada_IdCreator",
                table: "T4NopolArmada",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T4NopolArmada_IdOperator",
                table: "T4NopolArmada",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T4NopolArmada_IdValidator",
                table: "T4NopolArmada",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T4TujuanBongkar_IdCreator",
                table: "T4TujuanBongkar",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T4TujuanBongkar_IdCustomer",
                table: "T4TujuanBongkar",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T4TujuanBongkar_IdKota",
                table: "T4TujuanBongkar",
                column: "IdKota");

            migrationBuilder.CreateIndex(
                name: "IX_T4TujuanBongkar_IdOperator",
                table: "T4TujuanBongkar",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T4TujuanBongkar_IdRute",
                table: "T4TujuanBongkar",
                column: "IdRute");

            migrationBuilder.CreateIndex(
                name: "IX_T4TujuanBongkar_IdValidator",
                table: "T4TujuanBongkar",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T5ArmadaCustomer_IdCreator",
                table: "T5ArmadaCustomer",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T5ArmadaCustomer_IdCustomer",
                table: "T5ArmadaCustomer",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T5ArmadaCustomer_IdOperator",
                table: "T5ArmadaCustomer",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T5ArmadaCustomer_IdValidator",
                table: "T5ArmadaCustomer",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T5ArmadaSopir_IdCreator",
                table: "T5ArmadaSopir",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T5ArmadaSopir_IdKaryawan_Sopir",
                table: "T5ArmadaSopir",
                column: "IdKaryawan_Sopir");

            migrationBuilder.CreateIndex(
                name: "IX_T5ArmadaSopir_IdOperator",
                table: "T5ArmadaSopir",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T5ArmadaSopir_IdValidator",
                table: "T5ArmadaSopir",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T5CompanyGudang_IdCreator",
                table: "T5CompanyGudang",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T5CompanyGudang_IdGudang",
                table: "T5CompanyGudang",
                column: "IdGudang");

            migrationBuilder.CreateIndex(
                name: "IX_T5CompanyGudang_IdOperator",
                table: "T5CompanyGudang",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T5CompanyGudang_IdValidator",
                table: "T5CompanyGudang",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T5CompanySatuan_IdCreator",
                table: "T5CompanySatuan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T5CompanySatuan_IdOperator",
                table: "T5CompanySatuan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T5CompanySatuan_IdSatuan",
                table: "T5CompanySatuan",
                column: "IdSatuan");

            migrationBuilder.CreateIndex(
                name: "IX_T5CompanySatuan_IdValidator",
                table: "T5CompanySatuan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T5DokumenRute_IdCreator",
                table: "T5DokumenRute",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T5DokumenRute_IdOperator",
                table: "T5DokumenRute",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T5DokumenRute_IdRute",
                table: "T5DokumenRute",
                column: "IdRute");

            migrationBuilder.CreateIndex(
                name: "IX_T5DokumenRute_IdValidator",
                table: "T5DokumenRute",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T5Gambar_IdCreator",
                table: "T5Gambar",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T5Gambar_IdOperator",
                table: "T5Gambar",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T5Gambar_IdValidator",
                table: "T5Gambar",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T5Gambar_T2BarangIdBarang",
                table: "T5Gambar",
                column: "T2BarangIdBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T5JabatanKaryawan_IdCreator",
                table: "T5JabatanKaryawan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T5JabatanKaryawan_IdKaryawan",
                table: "T5JabatanKaryawan",
                column: "IdKaryawan");

            migrationBuilder.CreateIndex(
                name: "IX_T5JabatanKaryawan_IdOperator",
                table: "T5JabatanKaryawan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T5JabatanKaryawan_IdValidator",
                table: "T5JabatanKaryawan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T5KaryawanCustomer_IdCreator",
                table: "T5KaryawanCustomer",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T5KaryawanCustomer_IdKaryawan",
                table: "T5KaryawanCustomer",
                column: "IdKaryawan");

            migrationBuilder.CreateIndex(
                name: "IX_T5KaryawanCustomer_IdOperator",
                table: "T5KaryawanCustomer",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T5KaryawanCustomer_IdValidator",
                table: "T5KaryawanCustomer",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T5Pembayaran_IdAkun",
                table: "T5Pembayaran",
                column: "IdAkun");

            migrationBuilder.CreateIndex(
                name: "IX_T5Pembayaran_IdCreator",
                table: "T5Pembayaran",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T5Pembayaran_IdKurs",
                table: "T5Pembayaran",
                column: "IdKurs");

            migrationBuilder.CreateIndex(
                name: "IX_T5Pembayaran_IdOperator",
                table: "T5Pembayaran",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T5Pembayaran_IdValidator",
                table: "T5Pembayaran",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T5StokGudang_IdCreator",
                table: "T5StokGudang",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T5StokGudang_IdGudang",
                table: "T5StokGudang",
                column: "IdGudang");

            migrationBuilder.CreateIndex(
                name: "IX_T5StokGudang_IdOperator",
                table: "T5StokGudang",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T5StokGudang_IdValidator",
                table: "T5StokGudang",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T5SupplierSatuan_T2BarangIdBarang",
                table: "T5SupplierSatuan",
                column: "T2BarangIdBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T5VendorSupplier_IdCreator",
                table: "T5VendorSupplier",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T5VendorSupplier_IdOperator",
                table: "T5VendorSupplier",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T5VendorSupplier_IdSupplier",
                table: "T5VendorSupplier",
                column: "IdSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_T5VendorSupplier_IdValidator",
                table: "T5VendorSupplier",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T6HutangUsaha_IdCompany",
                table: "T6HutangUsaha",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T6HutangUsaha_IdCreator",
                table: "T6HutangUsaha",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T6HutangUsaha_IdForm",
                table: "T6HutangUsaha",
                column: "IdForm");

            migrationBuilder.CreateIndex(
                name: "IX_T6HutangUsaha_IdInspector",
                table: "T6HutangUsaha",
                column: "IdInspector");

            migrationBuilder.CreateIndex(
                name: "IX_T6HutangUsaha_IdJenisSupplier",
                table: "T6HutangUsaha",
                column: "IdJenisSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_T6HutangUsaha_IdOperator",
                table: "T6HutangUsaha",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6HutangUsaha_IdSupervisor",
                table: "T6HutangUsaha",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_T6HutangUsaha_IdSupplier",
                table: "T6HutangUsaha",
                column: "IdSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_T6HutangUsaha_IdValidator",
                table: "T6HutangUsaha",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T6Jurnal_IdCompany",
                table: "T6Jurnal",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T6Jurnal_IdCreator",
                table: "T6Jurnal",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T6Jurnal_IdForm",
                table: "T6Jurnal",
                column: "IdForm");

            migrationBuilder.CreateIndex(
                name: "IX_T6Jurnal_IdInspector",
                table: "T6Jurnal",
                column: "IdInspector");

            migrationBuilder.CreateIndex(
                name: "IX_T6Jurnal_IdOperator",
                table: "T6Jurnal",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6Jurnal_IdSupervisor",
                table: "T6Jurnal",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_T6Jurnal_IdValidator",
                table: "T6Jurnal",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPembelian_IdCompany",
                table: "T6OrderPembelian",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPembelian_IdCompany_Penerima",
                table: "T6OrderPembelian",
                column: "IdCompany_Penerima");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPembelian_IdCreator",
                table: "T6OrderPembelian",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPembelian_IdInspector",
                table: "T6OrderPembelian",
                column: "IdInspector");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPembelian_IdJenisSupplier",
                table: "T6OrderPembelian",
                column: "IdJenisSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPembelian_IdOperator",
                table: "T6OrderPembelian",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPembelian_IdSupervisor",
                table: "T6OrderPembelian",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPembelian_IdSupplier",
                table: "T6OrderPembelian",
                column: "IdSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPembelian_IdValidator",
                table: "T6OrderPembelian",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_IdAlamatCustomer_KirimBarang",
                table: "T6OrderPenjualan",
                column: "IdAlamatCustomer_KirimBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_IdAlamatCustomer_KirimDokumen",
                table: "T6OrderPenjualan",
                column: "IdAlamatCustomer_KirimDokumen");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_IdAlamatCustomer_Legal",
                table: "T6OrderPenjualan",
                column: "IdAlamatCustomer_Legal");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_IdCompany",
                table: "T6OrderPenjualan",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_IdCompany_Pengirim",
                table: "T6OrderPenjualan",
                column: "IdCompany_Pengirim");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_IdCreator",
                table: "T6OrderPenjualan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_IdCustomer",
                table: "T6OrderPenjualan",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_IdInspector",
                table: "T6OrderPenjualan",
                column: "IdInspector");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_IdJenisCustomer",
                table: "T6OrderPenjualan",
                column: "IdJenisCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_IdJenisTransaksi",
                table: "T6OrderPenjualan",
                column: "IdJenisTransaksi");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_IdKaryawan_Salesman",
                table: "T6OrderPenjualan",
                column: "IdKaryawan_Salesman");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_IdOperator",
                table: "T6OrderPenjualan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_IdPenyeliaCustomer",
                table: "T6OrderPenjualan",
                column: "IdPenyeliaCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_IdSupervisor",
                table: "T6OrderPenjualan",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_IdValidator",
                table: "T6OrderPenjualan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanHutangUsaha_IdCompany",
                table: "T6PelunasanHutangUsaha",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanHutangUsaha_IdCreator",
                table: "T6PelunasanHutangUsaha",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanHutangUsaha_IdInspector",
                table: "T6PelunasanHutangUsaha",
                column: "IdInspector");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanHutangUsaha_IdJenisSupplier",
                table: "T6PelunasanHutangUsaha",
                column: "IdJenisSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanHutangUsaha_IdOperator",
                table: "T6PelunasanHutangUsaha",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanHutangUsaha_IdSupervisor",
                table: "T6PelunasanHutangUsaha",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanHutangUsaha_IdSupplier",
                table: "T6PelunasanHutangUsaha",
                column: "IdSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanHutangUsaha_IdValidator",
                table: "T6PelunasanHutangUsaha",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangKaryawan_IdCompany",
                table: "T6PelunasanPiutangKaryawan",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangKaryawan_IdCreator",
                table: "T6PelunasanPiutangKaryawan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangKaryawan_IdInspector",
                table: "T6PelunasanPiutangKaryawan",
                column: "IdInspector");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangKaryawan_IdJabatan",
                table: "T6PelunasanPiutangKaryawan",
                column: "IdJabatan");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangKaryawan_IdKaryawan",
                table: "T6PelunasanPiutangKaryawan",
                column: "IdKaryawan");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangKaryawan_IdOperator",
                table: "T6PelunasanPiutangKaryawan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangKaryawan_IdSupervisor",
                table: "T6PelunasanPiutangKaryawan",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangKaryawan_IdValidator",
                table: "T6PelunasanPiutangKaryawan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangUsaha_IdCompany",
                table: "T6PelunasanPiutangUsaha",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangUsaha_IdCreator",
                table: "T6PelunasanPiutangUsaha",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangUsaha_IdCustomer",
                table: "T6PelunasanPiutangUsaha",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangUsaha_IdInspector",
                table: "T6PelunasanPiutangUsaha",
                column: "IdInspector");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangUsaha_IdJenisCustomer",
                table: "T6PelunasanPiutangUsaha",
                column: "IdJenisCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangUsaha_IdOperator",
                table: "T6PelunasanPiutangUsaha",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangUsaha_IdSupervisor",
                table: "T6PelunasanPiutangUsaha",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_T6PelunasanPiutangUsaha_IdValidator",
                table: "T6PelunasanPiutangUsaha",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PembelianAset_IdCompany",
                table: "T6PembelianAset",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T6PembelianAset_IdCreator",
                table: "T6PembelianAset",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PembelianAset_IdInspector",
                table: "T6PembelianAset",
                column: "IdInspector");

            migrationBuilder.CreateIndex(
                name: "IX_T6PembelianAset_IdJenisSupplier",
                table: "T6PembelianAset",
                column: "IdJenisSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_T6PembelianAset_IdOperator",
                table: "T6PembelianAset",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PembelianAset_IdSupervisor",
                table: "T6PembelianAset",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_T6PembelianAset_IdSupplier",
                table: "T6PembelianAset",
                column: "IdSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_T6PembelianAset_IdValidator",
                table: "T6PembelianAset",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PencairanHutangGiro_IdCompany",
                table: "T6PencairanHutangGiro",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T6PencairanHutangGiro_IdCreator",
                table: "T6PencairanHutangGiro",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PencairanHutangGiro_IdInspector",
                table: "T6PencairanHutangGiro",
                column: "IdInspector");

            migrationBuilder.CreateIndex(
                name: "IX_T6PencairanHutangGiro_IdOperator",
                table: "T6PencairanHutangGiro",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PencairanHutangGiro_IdRekening",
                table: "T6PencairanHutangGiro",
                column: "IdRekening");

            migrationBuilder.CreateIndex(
                name: "IX_T6PencairanHutangGiro_IdSupervisor",
                table: "T6PencairanHutangGiro",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_T6PencairanHutangGiro_IdValidator",
                table: "T6PencairanHutangGiro",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PencairanPiutangGiro_IdCompany",
                table: "T6PencairanPiutangGiro",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T6PencairanPiutangGiro_IdCreator",
                table: "T6PencairanPiutangGiro",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PencairanPiutangGiro_IdInspector",
                table: "T6PencairanPiutangGiro",
                column: "IdInspector");

            migrationBuilder.CreateIndex(
                name: "IX_T6PencairanPiutangGiro_IdOperator",
                table: "T6PencairanPiutangGiro",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PencairanPiutangGiro_IdRekening",
                table: "T6PencairanPiutangGiro",
                column: "IdRekening");

            migrationBuilder.CreateIndex(
                name: "IX_T6PencairanPiutangGiro_IdSupervisor",
                table: "T6PencairanPiutangGiro",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_T6PencairanPiutangGiro_IdValidator",
                table: "T6PencairanPiutangGiro",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PenugasanArmada_IdArmada",
                table: "T6PenugasanArmada",
                column: "IdArmada");

            migrationBuilder.CreateIndex(
                name: "IX_T6PenugasanArmada_IdBBM",
                table: "T6PenugasanArmada",
                column: "IdBBM");

            migrationBuilder.CreateIndex(
                name: "IX_T6PenugasanArmada_IdCompany",
                table: "T6PenugasanArmada",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T6PenugasanArmada_IdCreator",
                table: "T6PenugasanArmada",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PenugasanArmada_IdInspector",
                table: "T6PenugasanArmada",
                column: "IdInspector");

            migrationBuilder.CreateIndex(
                name: "IX_T6PenugasanArmada_IdJenisArmada",
                table: "T6PenugasanArmada",
                column: "IdJenisArmada");

            migrationBuilder.CreateIndex(
                name: "IX_T6PenugasanArmada_IdKaryawan_Sopir",
                table: "T6PenugasanArmada",
                column: "IdKaryawan_Sopir");

            migrationBuilder.CreateIndex(
                name: "IX_T6PenugasanArmada_IdOperator",
                table: "T6PenugasanArmada",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PenugasanArmada_IdRekening",
                table: "T6PenugasanArmada",
                column: "IdRekening");

            migrationBuilder.CreateIndex(
                name: "IX_T6PenugasanArmada_IdSupervisor",
                table: "T6PenugasanArmada",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_T6PenugasanArmada_IdValidator",
                table: "T6PenugasanArmada",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PHutangGiro_IdCompany",
                table: "T6PHutangGiro",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T6PHutangGiro_IdCreator",
                table: "T6PHutangGiro",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PHutangGiro_IdForm",
                table: "T6PHutangGiro",
                column: "IdForm");

            migrationBuilder.CreateIndex(
                name: "IX_T6PHutangGiro_IdInspector",
                table: "T6PHutangGiro",
                column: "IdInspector");

            migrationBuilder.CreateIndex(
                name: "IX_T6PHutangGiro_IdJenisSupplier",
                table: "T6PHutangGiro",
                column: "IdJenisSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_T6PHutangGiro_IdOperator",
                table: "T6PHutangGiro",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PHutangGiro_IdRekening",
                table: "T6PHutangGiro",
                column: "IdRekening");

            migrationBuilder.CreateIndex(
                name: "IX_T6PHutangGiro_IdSupervisor",
                table: "T6PHutangGiro",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_T6PHutangGiro_IdSupplier",
                table: "T6PHutangGiro",
                column: "IdSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_T6PHutangGiro_IdValidator",
                table: "T6PHutangGiro",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangKaryawan_IdCompany",
                table: "T6PiutangKaryawan",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangKaryawan_IdCreator",
                table: "T6PiutangKaryawan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangKaryawan_IdForm",
                table: "T6PiutangKaryawan",
                column: "IdForm");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangKaryawan_IdInspector",
                table: "T6PiutangKaryawan",
                column: "IdInspector");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangKaryawan_IdJabatan",
                table: "T6PiutangKaryawan",
                column: "IdJabatan");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangKaryawan_IdKaryawan",
                table: "T6PiutangKaryawan",
                column: "IdKaryawan");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangKaryawan_IdOperator",
                table: "T6PiutangKaryawan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangKaryawan_IdRekening",
                table: "T6PiutangKaryawan",
                column: "IdRekening");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangKaryawan_IdSupervisor",
                table: "T6PiutangKaryawan",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangKaryawan_IdValidator",
                table: "T6PiutangKaryawan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangUsaha_IdAlamatCustomer_KirimBarang",
                table: "T6PiutangUsaha",
                column: "IdAlamatCustomer_KirimBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangUsaha_IdAlamatCustomer_KirimDokumen",
                table: "T6PiutangUsaha",
                column: "IdAlamatCustomer_KirimDokumen");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangUsaha_IdAlamatCustomer_Legal",
                table: "T6PiutangUsaha",
                column: "IdAlamatCustomer_Legal");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangUsaha_IdCompany",
                table: "T6PiutangUsaha",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangUsaha_IdCreator",
                table: "T6PiutangUsaha",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangUsaha_IdCustomer",
                table: "T6PiutangUsaha",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangUsaha_IdForm",
                table: "T6PiutangUsaha",
                column: "IdForm");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangUsaha_IdInspector",
                table: "T6PiutangUsaha",
                column: "IdInspector");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangUsaha_IdJenisCustomer",
                table: "T6PiutangUsaha",
                column: "IdJenisCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangUsaha_IdOperator",
                table: "T6PiutangUsaha",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangUsaha_IdPenyeliaCustomer",
                table: "T6PiutangUsaha",
                column: "IdPenyeliaCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangUsaha_IdSupervisor",
                table: "T6PiutangUsaha",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_T6PiutangUsaha_IdValidator",
                table: "T6PiutangUsaha",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PPiutangGiro_IdAlamatCustomer_KirimBarang",
                table: "T6PPiutangGiro",
                column: "IdAlamatCustomer_KirimBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T6PPiutangGiro_IdAlamatCustomer_KirimDokumen",
                table: "T6PPiutangGiro",
                column: "IdAlamatCustomer_KirimDokumen");

            migrationBuilder.CreateIndex(
                name: "IX_T6PPiutangGiro_IdAlamatCustomer_Legal",
                table: "T6PPiutangGiro",
                column: "IdAlamatCustomer_Legal");

            migrationBuilder.CreateIndex(
                name: "IX_T6PPiutangGiro_IdCompany",
                table: "T6PPiutangGiro",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T6PPiutangGiro_IdCreator",
                table: "T6PPiutangGiro",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PPiutangGiro_IdCustomer",
                table: "T6PPiutangGiro",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T6PPiutangGiro_IdInspector",
                table: "T6PPiutangGiro",
                column: "IdInspector");

            migrationBuilder.CreateIndex(
                name: "IX_T6PPiutangGiro_IdJenisCustomer",
                table: "T6PPiutangGiro",
                column: "IdJenisCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T6PPiutangGiro_IdOperator",
                table: "T6PPiutangGiro",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6PPiutangGiro_IdPenyeliaCustomer",
                table: "T6PPiutangGiro",
                column: "IdPenyeliaCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T6PPiutangGiro_IdRekening",
                table: "T6PPiutangGiro",
                column: "IdRekening");

            migrationBuilder.CreateIndex(
                name: "IX_T6PPiutangGiro_IdSupervisor",
                table: "T6PPiutangGiro",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_T6PPiutangGiro_IdValidator",
                table: "T6PPiutangGiro",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T7Jurnal_IdAkun",
                table: "T7Jurnal",
                column: "IdAkun");

            migrationBuilder.CreateIndex(
                name: "IX_T7Jurnal_IdCreator",
                table: "T7Jurnal",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T7Jurnal_IdJurnal",
                table: "T7Jurnal",
                column: "IdJurnal");

            migrationBuilder.CreateIndex(
                name: "IX_T7Jurnal_IdKurs",
                table: "T7Jurnal",
                column: "IdKurs");

            migrationBuilder.CreateIndex(
                name: "IX_T7Jurnal_IdOperator",
                table: "T7Jurnal",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T7Jurnal_IdValidator",
                table: "T7Jurnal",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPembelian_IdBarang",
                table: "T7OrderPembelian",
                column: "IdBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPembelian_IdCreator",
                table: "T7OrderPembelian",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPembelian_IdDivisiBarang",
                table: "T7OrderPembelian",
                column: "IdDivisiBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPembelian_IdKategoriBarang",
                table: "T7OrderPembelian",
                column: "IdKategoriBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPembelian_IdKurs",
                table: "T7OrderPembelian",
                column: "IdKurs");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPembelian_IdOperator",
                table: "T7OrderPembelian",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPembelian_IdOrderPembelian",
                table: "T7OrderPembelian",
                column: "IdOrderPembelian");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPembelian_IdSatuan",
                table: "T7OrderPembelian",
                column: "IdSatuan");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPembelian_IdSubDivisiBarang",
                table: "T7OrderPembelian",
                column: "IdSubDivisiBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPembelian_IdSubKategoriBarang",
                table: "T7OrderPembelian",
                column: "IdSubKategoriBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPembelian_IdValidator",
                table: "T7OrderPembelian",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPenjualan_IdBarang",
                table: "T7OrderPenjualan",
                column: "IdBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPenjualan_IdCreator",
                table: "T7OrderPenjualan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPenjualan_IdDiskonBarang",
                table: "T7OrderPenjualan",
                column: "IdDiskonBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPenjualan_IdDivisiBarang",
                table: "T7OrderPenjualan",
                column: "IdDivisiBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPenjualan_IdHargaBarang",
                table: "T7OrderPenjualan",
                column: "IdHargaBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPenjualan_IdKategoriBarang",
                table: "T7OrderPenjualan",
                column: "IdKategoriBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPenjualan_IdKurs",
                table: "T7OrderPenjualan",
                column: "IdKurs");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPenjualan_IdOperator",
                table: "T7OrderPenjualan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPenjualan_IdOrderPenjualan",
                table: "T7OrderPenjualan",
                column: "IdOrderPenjualan");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPenjualan_IdSatuan",
                table: "T7OrderPenjualan",
                column: "IdSatuan");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPenjualan_IdSubDivisiBarang",
                table: "T7OrderPenjualan",
                column: "IdSubDivisiBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPenjualan_IdSubKategoriBarang",
                table: "T7OrderPenjualan",
                column: "IdSubKategoriBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPenjualan_IdValidator",
                table: "T7OrderPenjualan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanHutangUsaha_IdCreator",
                table: "T7PelunasanHutangUsaha",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanHutangUsaha_IdHutangUsaha",
                table: "T7PelunasanHutangUsaha",
                column: "IdHutangUsaha");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanHutangUsaha_IdOperator",
                table: "T7PelunasanHutangUsaha",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanHutangUsaha_IdPelunasanHutangUsaha",
                table: "T7PelunasanHutangUsaha",
                column: "IdPelunasanHutangUsaha");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanHutangUsaha_IdValidator",
                table: "T7PelunasanHutangUsaha",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanPiutangKaryawan_IdCreator",
                table: "T7PelunasanPiutangKaryawan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanPiutangKaryawan_IdOperator",
                table: "T7PelunasanPiutangKaryawan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanPiutangKaryawan_IdPelunasanPiutangKaryawan",
                table: "T7PelunasanPiutangKaryawan",
                column: "IdPelunasanPiutangKaryawan");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanPiutangKaryawan_IdPiutangKaryawan",
                table: "T7PelunasanPiutangKaryawan",
                column: "IdPiutangKaryawan");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanPiutangKaryawan_IdValidator",
                table: "T7PelunasanPiutangKaryawan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanPiutangUsaha_IdAlamatCustomer_KirimBarang",
                table: "T7PelunasanPiutangUsaha",
                column: "IdAlamatCustomer_KirimBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanPiutangUsaha_IdAlamatCustomer_KirimDokumen",
                table: "T7PelunasanPiutangUsaha",
                column: "IdAlamatCustomer_KirimDokumen");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanPiutangUsaha_IdAlamatCustomer_Legal",
                table: "T7PelunasanPiutangUsaha",
                column: "IdAlamatCustomer_Legal");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanPiutangUsaha_IdCreator",
                table: "T7PelunasanPiutangUsaha",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanPiutangUsaha_IdOperator",
                table: "T7PelunasanPiutangUsaha",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanPiutangUsaha_IdPelunasanPiutangUsaha",
                table: "T7PelunasanPiutangUsaha",
                column: "IdPelunasanPiutangUsaha");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanPiutangUsaha_IdPenyeliaCustomer",
                table: "T7PelunasanPiutangUsaha",
                column: "IdPenyeliaCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanPiutangUsaha_IdPiutangUsaha",
                table: "T7PelunasanPiutangUsaha",
                column: "IdPiutangUsaha");

            migrationBuilder.CreateIndex(
                name: "IX_T7PelunasanPiutangUsaha_IdValidator",
                table: "T7PelunasanPiutangUsaha",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PembelianAset_IdAkun_AkumulasiPenyusutan",
                table: "T7PembelianAset",
                column: "IdAkun_AkumulasiPenyusutan");

            migrationBuilder.CreateIndex(
                name: "IX_T7PembelianAset_IdAkun_BiayaPenyusutan",
                table: "T7PembelianAset",
                column: "IdAkun_BiayaPenyusutan");

            migrationBuilder.CreateIndex(
                name: "IX_T7PembelianAset_IdArmada",
                table: "T7PembelianAset",
                column: "IdArmada");

            migrationBuilder.CreateIndex(
                name: "IX_T7PembelianAset_IdAset",
                table: "T7PembelianAset",
                column: "IdAset");

            migrationBuilder.CreateIndex(
                name: "IX_T7PembelianAset_IdCreator",
                table: "T7PembelianAset",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PembelianAset_IdJenisAset",
                table: "T7PembelianAset",
                column: "IdJenisAset");

            migrationBuilder.CreateIndex(
                name: "IX_T7PembelianAset_IdOperator",
                table: "T7PembelianAset",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PembelianAset_IdPembelianAset",
                table: "T7PembelianAset",
                column: "IdPembelianAset");

            migrationBuilder.CreateIndex(
                name: "IX_T7PembelianAset_IdValidator",
                table: "T7PembelianAset",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PencairanHutangGiro_IdCreator",
                table: "T7PencairanHutangGiro",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PencairanHutangGiro_IdHutangGiro",
                table: "T7PencairanHutangGiro",
                column: "IdHutangGiro");

            migrationBuilder.CreateIndex(
                name: "IX_T7PencairanHutangGiro_IdOperator",
                table: "T7PencairanHutangGiro",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PencairanHutangGiro_IdPencairanHutangGiro",
                table: "T7PencairanHutangGiro",
                column: "IdPencairanHutangGiro");

            migrationBuilder.CreateIndex(
                name: "IX_T7PencairanHutangGiro_IdValidator",
                table: "T7PencairanHutangGiro",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PencairanPiutangGiro_IdAlamatCustomer_KirimBarang",
                table: "T7PencairanPiutangGiro",
                column: "IdAlamatCustomer_KirimBarang");

            migrationBuilder.CreateIndex(
                name: "IX_T7PencairanPiutangGiro_IdAlamatCustomer_KirimDokumen",
                table: "T7PencairanPiutangGiro",
                column: "IdAlamatCustomer_KirimDokumen");

            migrationBuilder.CreateIndex(
                name: "IX_T7PencairanPiutangGiro_IdAlamatCustomer_Legal",
                table: "T7PencairanPiutangGiro",
                column: "IdAlamatCustomer_Legal");

            migrationBuilder.CreateIndex(
                name: "IX_T7PencairanPiutangGiro_IdCreator",
                table: "T7PencairanPiutangGiro",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PencairanPiutangGiro_IdOperator",
                table: "T7PencairanPiutangGiro",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PencairanPiutangGiro_IdPencairanPiutangGiro",
                table: "T7PencairanPiutangGiro",
                column: "IdPencairanPiutangGiro");

            migrationBuilder.CreateIndex(
                name: "IX_T7PencairanPiutangGiro_IdPenyeliaCustomer",
                table: "T7PencairanPiutangGiro",
                column: "IdPenyeliaCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T7PencairanPiutangGiro_IdPiutangGiro",
                table: "T7PencairanPiutangGiro",
                column: "IdPiutangGiro");

            migrationBuilder.CreateIndex(
                name: "IX_T7PencairanPiutangGiro_IdValidator",
                table: "T7PencairanPiutangGiro",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PenugasanArmada_IdAlamatCustomer",
                table: "T7PenugasanArmada",
                column: "IdAlamatCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T7PenugasanArmada_IdCompany",
                table: "T7PenugasanArmada",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T7PenugasanArmada_IdCreator",
                table: "T7PenugasanArmada",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PenugasanArmada_IdCustomer",
                table: "T7PenugasanArmada",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T7PenugasanArmada_IdOperator",
                table: "T7PenugasanArmada",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PenugasanArmada_IdPenugasanArmada",
                table: "T7PenugasanArmada",
                column: "IdPenugasanArmada");

            migrationBuilder.CreateIndex(
                name: "IX_T7PenugasanArmada_IdPenyeliaCustomer",
                table: "T7PenugasanArmada",
                column: "IdPenyeliaCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_T7PenugasanArmada_IdRute",
                table: "T7PenugasanArmada",
                column: "IdRute");

            migrationBuilder.CreateIndex(
                name: "IX_T7PenugasanArmada_IdValidator",
                table: "T7PenugasanArmada",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PenugasanArmada_SPBU_IdBBM",
                table: "T7PenugasanArmada_SPBU",
                column: "IdBBM");

            migrationBuilder.CreateIndex(
                name: "IX_T7PenugasanArmada_SPBU_IdCreator",
                table: "T7PenugasanArmada_SPBU",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PenugasanArmada_SPBU_IdOperator",
                table: "T7PenugasanArmada_SPBU",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T7PenugasanArmada_SPBU_IdPenugasanArmada",
                table: "T7PenugasanArmada_SPBU",
                column: "IdPenugasanArmada");

            migrationBuilder.CreateIndex(
                name: "IX_T7PenugasanArmada_SPBU_IdSupplier_SPBU",
                table: "T7PenugasanArmada_SPBU",
                column: "IdSupplier_SPBU");

            migrationBuilder.CreateIndex(
                name: "IX_T7PenugasanArmada_SPBU_IdValidator",
                table: "T7PenugasanArmada_SPBU",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T8PenugasanArmada_Biaya_IdAkun",
                table: "T8PenugasanArmada_Biaya",
                column: "IdAkun");

            migrationBuilder.CreateIndex(
                name: "IX_T8PenugasanArmada_Biaya_IdCreator",
                table: "T8PenugasanArmada_Biaya",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T8PenugasanArmada_Biaya_IdDetilPenugasanArmada",
                table: "T8PenugasanArmada_Biaya",
                column: "IdDetilPenugasanArmada");

            migrationBuilder.CreateIndex(
                name: "IX_T8PenugasanArmada_Biaya_IdOperator",
                table: "T8PenugasanArmada_Biaya",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T8PenugasanArmada_Biaya_IdValidator",
                table: "T8PenugasanArmada_Biaya",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T8PenugasanArmada_SuratJalan_IdCreator",
                table: "T8PenugasanArmada_SuratJalan",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T8PenugasanArmada_SuratJalan_IdDetilPenugasanArmada",
                table: "T8PenugasanArmada_SuratJalan",
                column: "IdDetilPenugasanArmada");

            migrationBuilder.CreateIndex(
                name: "IX_T8PenugasanArmada_SuratJalan_IdKota",
                table: "T8PenugasanArmada_SuratJalan",
                column: "IdKota");

            migrationBuilder.CreateIndex(
                name: "IX_T8PenugasanArmada_SuratJalan_IdOperator",
                table: "T8PenugasanArmada_SuratJalan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T8PenugasanArmada_SuratJalan_IdTujuanBongkar",
                table: "T8PenugasanArmada_SuratJalan",
                column: "IdTujuanBongkar");

            migrationBuilder.CreateIndex(
                name: "IX_T8PenugasanArmada_SuratJalan_IdValidator",
                table: "T8PenugasanArmada_SuratJalan",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T9Filter_IdCreator",
                table: "T9Filter",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T9Filter_IdForm",
                table: "T9Filter",
                column: "IdForm");

            migrationBuilder.CreateIndex(
                name: "IX_T9Filter_IdOperator",
                table: "T9Filter",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T9Filter_IdValidator",
                table: "T9Filter",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T9Tag_IdCreator",
                table: "T9Tag",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T9Tag_IdForm",
                table: "T9Tag",
                column: "IdForm");

            migrationBuilder.CreateIndex(
                name: "IX_T9Tag_IdOperator",
                table: "T9Tag",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T9Tag_IdValidator",
                table: "T9Tag",
                column: "IdValidator");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Akun_T0Kurs_IdKurs",
                table: "T0Akun",
                column: "IdKurs",
                principalTable: "T0Kurs",
                principalColumn: "IdKurs");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Akun_T1Karyawan_IdCreator",
                table: "T0Akun",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Akun_T1Karyawan_IdOperator",
                table: "T0Akun",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Akun_T1Karyawan_IdValidator",
                table: "T0Akun",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0BBM_T1Karyawan_IdCreator",
                table: "T0BBM",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0BBM_T1Karyawan_IdOperator",
                table: "T0BBM",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0BBM_T1Karyawan_IdValidator",
                table: "T0BBM",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Company_T1Karyawan_IdCreator",
                table: "T0Company",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Company_T1Karyawan_IdOperator",
                table: "T0Company",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Company_T1Karyawan_IdValidator",
                table: "T0Company",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0DivisiBarang_T1Karyawan_IdCreator",
                table: "T0DivisiBarang",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0DivisiBarang_T1Karyawan_IdOperator",
                table: "T0DivisiBarang",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0DivisiBarang_T1Karyawan_IdValidator",
                table: "T0DivisiBarang",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0DivisiPerusahaan_T1Karyawan_IdCreator",
                table: "T0DivisiPerusahaan",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0DivisiPerusahaan_T1Karyawan_IdOperator",
                table: "T0DivisiPerusahaan",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0DivisiPerusahaan_T1Karyawan_IdValidator",
                table: "T0DivisiPerusahaan",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0DivisiServis_T1Karyawan_IdCreator",
                table: "T0DivisiServis",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0DivisiServis_T1Karyawan_IdOperator",
                table: "T0DivisiServis",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0DivisiServis_T1Karyawan_IdValidator",
                table: "T0DivisiServis",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Gudang_T1Karyawan_IdCreator",
                table: "T0Gudang",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Gudang_T1Karyawan_IdOperator",
                table: "T0Gudang",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Gudang_T1Karyawan_IdValidator",
                table: "T0Gudang",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Jabatan_T1Karyawan_IdCreator",
                table: "T0Jabatan",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Jabatan_T1Karyawan_IdOperator",
                table: "T0Jabatan",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Jabatan_T1Karyawan_IdValidator",
                table: "T0Jabatan",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisArmada_T1Karyawan_IdCreator",
                table: "T0JenisArmada",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisArmada_T1Karyawan_IdOperator",
                table: "T0JenisArmada",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisArmada_T1Karyawan_IdValidator",
                table: "T0JenisArmada",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisAset_T1Karyawan_IdCreator",
                table: "T0JenisAset",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisAset_T1Karyawan_IdOperator",
                table: "T0JenisAset",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisAset_T1Karyawan_IdValidator",
                table: "T0JenisAset",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisCustomer_T1Karyawan_IdCreator",
                table: "T0JenisCustomer",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisCustomer_T1Karyawan_IdOperator",
                table: "T0JenisCustomer",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisCustomer_T1Karyawan_IdValidator",
                table: "T0JenisCustomer",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisSupplier_T1Karyawan_IdCreator",
                table: "T0JenisSupplier",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisSupplier_T1Karyawan_IdOperator",
                table: "T0JenisSupplier",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisSupplier_T1Karyawan_IdValidator",
                table: "T0JenisSupplier",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisTransaksi_T1Karyawan_IdCreator",
                table: "T0JenisTransaksi",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisTransaksi_T1Karyawan_IdOperator",
                table: "T0JenisTransaksi",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisTransaksi_T1Karyawan_IdValidator",
                table: "T0JenisTransaksi",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisVendor_T1Karyawan_IdCreator",
                table: "T0JenisVendor",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisVendor_T1Karyawan_IdOperator",
                table: "T0JenisVendor",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisVendor_T1Karyawan_IdValidator",
                table: "T0JenisVendor",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisWarna_T1Karyawan_IdCreator",
                table: "T0JenisWarna",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisWarna_T1Karyawan_IdOperator",
                table: "T0JenisWarna",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0JenisWarna_T1Karyawan_IdValidator",
                table: "T0JenisWarna",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0KategoriBarang_T1Karyawan_IdCreator",
                table: "T0KategoriBarang",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0KategoriBarang_T1Karyawan_IdOperator",
                table: "T0KategoriBarang",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0KategoriBarang_T1Karyawan_IdValidator",
                table: "T0KategoriBarang",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0KategoriJadwalKerjaKaryawan_T1Karyawan_IdCreator",
                table: "T0KategoriJadwalKerjaKaryawan",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0KategoriJadwalKerjaKaryawan_T1Karyawan_IdOperator",
                table: "T0KategoriJadwalKerjaKaryawan",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0KategoriJadwalKerjaKaryawan_T1Karyawan_IdValidator",
                table: "T0KategoriJadwalKerjaKaryawan",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0KategoriServis_T1Karyawan_IdCreator",
                table: "T0KategoriServis",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0KategoriServis_T1Karyawan_IdOperator",
                table: "T0KategoriServis",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0KategoriServis_T1Karyawan_IdValidator",
                table: "T0KategoriServis",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Kurs_T0Negara_IdNegara",
                table: "T0Kurs",
                column: "IdNegara",
                principalTable: "T0Negara",
                principalColumn: "IdNegara");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Kurs_T1Karyawan_IdCreator",
                table: "T0Kurs",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Kurs_T1Karyawan_IdOperator",
                table: "T0Kurs",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Kurs_T1Karyawan_IdValidator",
                table: "T0Kurs",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Negara_T1Karyawan_IdCreator",
                table: "T0Negara",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Negara_T1Karyawan_IdOperator",
                table: "T0Negara",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Negara_T1Karyawan_IdValidator",
                table: "T0Negara",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Rekening_T1Karyawan_IdCreator",
                table: "T0Rekening",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Rekening_T1Karyawan_IdOperator",
                table: "T0Rekening",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0Rekening_T1Karyawan_IdValidator",
                table: "T0Rekening",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0SektorKota_T1Karyawan_IdCreator",
                table: "T0SektorKota",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0SektorKota_T1Karyawan_IdOperator",
                table: "T0SektorKota",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0SektorKota_T1Karyawan_IdValidator",
                table: "T0SektorKota",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0SektorNegara_T1Karyawan_IdCreator",
                table: "T0SektorNegara",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0SektorNegara_T1Karyawan_IdOperator",
                table: "T0SektorNegara",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0SektorNegara_T1Karyawan_IdValidator",
                table: "T0SektorNegara",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0SetJurnal_T1Karyawan_IdCreator",
                table: "T0SetJurnal",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0SetJurnal_T1Karyawan_IdOperator",
                table: "T0SetJurnal",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T0SetJurnal_T1Karyawan_IdValidator",
                table: "T0SetJurnal",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Armada_T1Karyawan_IdCreator",
                table: "T1Armada",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Armada_T1Karyawan_IdOperator",
                table: "T1Armada",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Armada_T1Karyawan_IdValidator",
                table: "T1Armada",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Armada_T1Supplier_IdSupplier_Pemilik",
                table: "T1Armada",
                column: "IdSupplier_Pemilik",
                principalTable: "T1Supplier",
                principalColumn: "IdSupplier");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Aset_T1Karyawan_IdCreator",
                table: "T1Aset",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Aset_T1Karyawan_IdOperator",
                table: "T1Aset",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Aset_T1Karyawan_IdValidator",
                table: "T1Aset",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Customer_T1Karyawan_IdCreator",
                table: "T1Customer",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Customer_T1Karyawan_IdOperator",
                table: "T1Customer",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Customer_T1Karyawan_IdValidator",
                table: "T1Customer",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Customer_T2Kota_IdKota",
                table: "T1Customer",
                column: "IdKota",
                principalTable: "T2Kota",
                principalColumn: "IdKota");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Customer_T3Kecamatan_IdKecamatan",
                table: "T1Customer",
                column: "IdKecamatan",
                principalTable: "T3Kecamatan",
                principalColumn: "IdKecamatan");

            migrationBuilder.AddForeignKey(
                name: "FK_T1Customer_T4Kelurahan_IdKelurahan",
                table: "T1Customer",
                column: "IdKelurahan",
                principalTable: "T4Kelurahan",
                principalColumn: "IdKelurahan");

            migrationBuilder.AddForeignKey(
                name: "FK_T1JadwalKerjaKaryawan_T1Karyawan_IdCreator",
                table: "T1JadwalKerjaKaryawan",
                column: "IdCreator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T1JadwalKerjaKaryawan_T1Karyawan_IdOperator",
                table: "T1JadwalKerjaKaryawan",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T1JadwalKerjaKaryawan_T1Karyawan_IdValidator",
                table: "T1JadwalKerjaKaryawan",
                column: "IdValidator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T0Jabatan_T1Karyawan_IdCreator",
                table: "T0Jabatan");

            migrationBuilder.DropForeignKey(
                name: "FK_T0Jabatan_T1Karyawan_IdOperator",
                table: "T0Jabatan");

            migrationBuilder.DropForeignKey(
                name: "FK_T0Jabatan_T1Karyawan_IdValidator",
                table: "T0Jabatan");

            migrationBuilder.DropForeignKey(
                name: "FK_T0KategoriJadwalKerjaKaryawan_T1Karyawan_IdCreator",
                table: "T0KategoriJadwalKerjaKaryawan");

            migrationBuilder.DropForeignKey(
                name: "FK_T0KategoriJadwalKerjaKaryawan_T1Karyawan_IdOperator",
                table: "T0KategoriJadwalKerjaKaryawan");

            migrationBuilder.DropForeignKey(
                name: "FK_T0KategoriJadwalKerjaKaryawan_T1Karyawan_IdValidator",
                table: "T0KategoriJadwalKerjaKaryawan");

            migrationBuilder.DropForeignKey(
                name: "FK_T1JadwalKerjaKaryawan_T1Karyawan_IdCreator",
                table: "T1JadwalKerjaKaryawan");

            migrationBuilder.DropForeignKey(
                name: "FK_T1JadwalKerjaKaryawan_T1Karyawan_IdOperator",
                table: "T1JadwalKerjaKaryawan");

            migrationBuilder.DropForeignKey(
                name: "FK_T1JadwalKerjaKaryawan_T1Karyawan_IdValidator",
                table: "T1JadwalKerjaKaryawan");

            migrationBuilder.DropTable(
                name: "T0Client");

            migrationBuilder.DropTable(
                name: "T0DivisiPerusahaan");

            migrationBuilder.DropTable(
                name: "T0SektorKota");

            migrationBuilder.DropTable(
                name: "T1Application");

            migrationBuilder.DropTable(
                name: "T1DetilForm");

            migrationBuilder.DropTable(
                name: "T1Provinsi");

            migrationBuilder.DropTable(
                name: "T1SetJurnal");

            migrationBuilder.DropTable(
                name: "T1Warna");

            migrationBuilder.DropTable(
                name: "T2AlamatSupplier");

            migrationBuilder.DropTable(
                name: "T2AlamatVendor");

            migrationBuilder.DropTable(
                name: "T2PenyeliaSupplier");

            migrationBuilder.DropTable(
                name: "T2PenyeliaVendor");

            migrationBuilder.DropTable(
                name: "T2Servis");

            migrationBuilder.DropTable(
                name: "T3Pelabuhan");

            migrationBuilder.DropTable(
                name: "T4BiayaRuteTonase");

            migrationBuilder.DropTable(
                name: "T4HargaBBM");

            migrationBuilder.DropTable(
                name: "T4HargaRuteTonase");

            migrationBuilder.DropTable(
                name: "T4NopolArmada");

            migrationBuilder.DropTable(
                name: "T5ArmadaCustomer");

            migrationBuilder.DropTable(
                name: "T5ArmadaSopir");

            migrationBuilder.DropTable(
                name: "T5CompanyGudang");

            migrationBuilder.DropTable(
                name: "T5CompanySatuan");

            migrationBuilder.DropTable(
                name: "T5DokumenRute");

            migrationBuilder.DropTable(
                name: "T5Gambar");

            migrationBuilder.DropTable(
                name: "T5JabatanKaryawan");

            migrationBuilder.DropTable(
                name: "T5KaryawanCustomer");

            migrationBuilder.DropTable(
                name: "T5Pembayaran");

            migrationBuilder.DropTable(
                name: "T5StokGudang");

            migrationBuilder.DropTable(
                name: "T5SupplierSatuan");

            migrationBuilder.DropTable(
                name: "T5VendorSupplier");

            migrationBuilder.DropTable(
                name: "T7Jurnal");

            migrationBuilder.DropTable(
                name: "T7OrderPembelian");

            migrationBuilder.DropTable(
                name: "T7OrderPenjualan");

            migrationBuilder.DropTable(
                name: "T7PelunasanHutangUsaha");

            migrationBuilder.DropTable(
                name: "T7PelunasanPiutangKaryawan");

            migrationBuilder.DropTable(
                name: "T7PelunasanPiutangUsaha");

            migrationBuilder.DropTable(
                name: "T7PembelianAset");

            migrationBuilder.DropTable(
                name: "T7PencairanHutangGiro");

            migrationBuilder.DropTable(
                name: "T7PencairanPiutangGiro");

            migrationBuilder.DropTable(
                name: "T7PenugasanArmada_SPBU");

            migrationBuilder.DropTable(
                name: "T8PenugasanArmada_Biaya");

            migrationBuilder.DropTable(
                name: "T8PenugasanArmada_SuratJalan");

            migrationBuilder.DropTable(
                name: "T9DataOption");

            migrationBuilder.DropTable(
                name: "T9Filter");

            migrationBuilder.DropTable(
                name: "T9Privileges");

            migrationBuilder.DropTable(
                name: "T9PrivilegesAksesData");

            migrationBuilder.DropTable(
                name: "T9SettingSystem");

            migrationBuilder.DropTable(
                name: "T9SettingUser");

            migrationBuilder.DropTable(
                name: "T9Tag");

            migrationBuilder.DropTable(
                name: "T0SetJurnal");

            migrationBuilder.DropTable(
                name: "T0JenisWarna");

            migrationBuilder.DropTable(
                name: "T1Vendor");

            migrationBuilder.DropTable(
                name: "T1SubDivisiServis");

            migrationBuilder.DropTable(
                name: "T1SubKategoriServis");

            migrationBuilder.DropTable(
                name: "T4BiayaRute");

            migrationBuilder.DropTable(
                name: "T0Gudang");

            migrationBuilder.DropTable(
                name: "T6Jurnal");

            migrationBuilder.DropTable(
                name: "T6OrderPembelian");

            migrationBuilder.DropTable(
                name: "T4DiskonBarang");

            migrationBuilder.DropTable(
                name: "T4HargaBarang");

            migrationBuilder.DropTable(
                name: "T6OrderPenjualan");

            migrationBuilder.DropTable(
                name: "T6HutangUsaha");

            migrationBuilder.DropTable(
                name: "T6PelunasanHutangUsaha");

            migrationBuilder.DropTable(
                name: "T6PelunasanPiutangKaryawan");

            migrationBuilder.DropTable(
                name: "T6PiutangKaryawan");

            migrationBuilder.DropTable(
                name: "T6PelunasanPiutangUsaha");

            migrationBuilder.DropTable(
                name: "T6PiutangUsaha");

            migrationBuilder.DropTable(
                name: "T1Aset");

            migrationBuilder.DropTable(
                name: "T6PembelianAset");

            migrationBuilder.DropTable(
                name: "T6PHutangGiro");

            migrationBuilder.DropTable(
                name: "T6PencairanHutangGiro");

            migrationBuilder.DropTable(
                name: "T6PPiutangGiro");

            migrationBuilder.DropTable(
                name: "T6PencairanPiutangGiro");

            migrationBuilder.DropTable(
                name: "T0Akun");

            migrationBuilder.DropTable(
                name: "T4TujuanBongkar");

            migrationBuilder.DropTable(
                name: "T7PenugasanArmada");

            migrationBuilder.DropTable(
                name: "T0JenisVendor");

            migrationBuilder.DropTable(
                name: "T0DivisiServis");

            migrationBuilder.DropTable(
                name: "T0KategoriServis");

            migrationBuilder.DropTable(
                name: "T3Satuan");

            migrationBuilder.DropTable(
                name: "T0JenisTransaksi");

            migrationBuilder.DropTable(
                name: "T0JenisAset");

            migrationBuilder.DropTable(
                name: "T0Form");

            migrationBuilder.DropTable(
                name: "T0Kurs");

            migrationBuilder.DropTable(
                name: "T3Rute");

            migrationBuilder.DropTable(
                name: "T6PenugasanArmada");

            migrationBuilder.DropTable(
                name: "T2Barang");

            migrationBuilder.DropTable(
                name: "T2AlamatCustomer");

            migrationBuilder.DropTable(
                name: "T2PenyeliaCustomer");

            migrationBuilder.DropTable(
                name: "T1Armada");

            migrationBuilder.DropTable(
                name: "T1SubDivisiBarang");

            migrationBuilder.DropTable(
                name: "T1SubKategoriBarang");

            migrationBuilder.DropTable(
                name: "T1Customer");

            migrationBuilder.DropTable(
                name: "T0BBM");

            migrationBuilder.DropTable(
                name: "T0Company");

            migrationBuilder.DropTable(
                name: "T0JenisArmada");

            migrationBuilder.DropTable(
                name: "T1Supplier");

            migrationBuilder.DropTable(
                name: "T0DivisiBarang");

            migrationBuilder.DropTable(
                name: "T0KategoriBarang");

            migrationBuilder.DropTable(
                name: "T0JenisCustomer");

            migrationBuilder.DropTable(
                name: "T0Negara");

            migrationBuilder.DropTable(
                name: "T0Rekening");

            migrationBuilder.DropTable(
                name: "T0SektorNegara");

            migrationBuilder.DropTable(
                name: "T3Kecamatan");

            migrationBuilder.DropTable(
                name: "T4Kelurahan");

            migrationBuilder.DropTable(
                name: "T0JenisSupplier");

            migrationBuilder.DropTable(
                name: "T2Kota");

            migrationBuilder.DropTable(
                name: "T1Karyawan");

            migrationBuilder.DropTable(
                name: "T0Jabatan");

            migrationBuilder.DropTable(
                name: "T1JadwalKerjaKaryawan");

            migrationBuilder.DropTable(
                name: "T0KategoriJadwalKerjaKaryawan");
        }
    }
}
