global using ColumnAttribute = System.ComponentModel.DataAnnotations.Schema.ColumnAttribute;
using bwaCrixalis.Shared._1._Master;
using bwaCrixalis.Shared._2._Transaksi;

namespace bwaAvernus.Shared._2._Transaksi
{
    public class T6PenugasanArmada : BaseModelTransaksiHeader
    {
        [Key]
        [PrimaryKey]
        [Column(Order = 0)]
        public Guid IdPenugasanArmada { get; set; }
        public string? IdRekening { get; set; }
        public Guid? IdArmada { get; set; }
        public Guid? IdJenisArmada { get; set; }
        public Guid? IdBBM { get; set; }
        public Guid? IdKaryawan_Sopir { get; set; }
        public Guid? IdPiutangKaryawan { get; set; } //Perlu relasi ke T6PiutangKaryawan, belum dibuatkan di Crixalis
        public string? Nopol { get; set; }
        public decimal? Potongan { get; set; }
        public bool? StatusPotongan { get; set; }
        public string? StatusPerjalanan { get; set; }
        public string? StatusDeposit { get; set; }
        public string? Rekening_Rekening { get; set; }
        public string? Armada_Inisial { get; set; }
        public string? Armada_Nopol { get; set; }
        public string? Armada_Merk { get; set; }
        public string? JenisArmada_Jenis { get; set; }
        public string? JenisArmada_Alias { get; set; }
        public string? BBM_BBM { get; set; }
        public string? Karyawan_Sopir_NamaPanggilan { get; set; }
        public string? Karyawan_Sopir_AlamatTinggal { get; set; }
        public string? Karyawan_Sopir_KodePosTinggal { get; set; }
        public string? Karyawan_Sopir_KotaTinggal { get; set; }
        public string? Karyawan_Sopir_Email { get; set; }
        public string? Karyawan_Sopir_Seluler1 { get; set; }
        public string? Karyawan_Sopir_Rekening { get; set; }
        public decimal? Referensi_NominalSaldoAwal { get; set; }
        public string? Referensi_IdTransaksi { get; set; }
        public DateTimeOffset? Referensi_WaktuProses { get; set; }
        public string? Referensi_Keterangan { get; set; }
        public string? Pembayaran_Keterangan { get; set; }
        public string? Pembayaran_Via { get; set; }
        public bool? Pembayaran_StatusTerbayar { get; set; }
        public decimal? Pembayaran_Total { get; set; }
        public string? PKLink1 { get; set; }
        public string? PKLink2 { get; set; }

        [ForeignKey("IdRekening")]
        public pthT0Rekening? T0Rekening { get; set; }

        [ForeignKey("IdArmada")]
        public T1Armada? T1Armada { get; set; }

        [ForeignKey("IdJenisArmada")]
        public T0JenisArmada? T0JenisArmada { get; set; }

        [ForeignKey("IdBBM")]
        public T0BBM? T0BBM { get; set; }

        [ForeignKey("IdKaryawan_Sopir")]
        public pthT1Karyawan? T1Karyawan_Sopir { get; set; }

        public ICollection<T7PenugasanArmada>? ListT7PenugasanArmada { get; set; }
        public ICollection<T7PenugasanArmada_SPBU>? ListT7PenugasanArmada_SPBU { get; set; }

        public static T6PenugasanArmada BuatBaru(T6PenugasanArmada t6PA)
        {
            var t6PenugasanArmada = t6PA;
            t6PenugasanArmada.IdPenugasanArmada = NewId.NextGuid();
            t6PenugasanArmada.Synchronise = "inserted";
            t6PenugasanArmada.WaktuInsert = DateTimeOffset.UtcNow;

            return t6PenugasanArmada;
        }

        public static T6PenugasanArmada Perbarui(T6PenugasanArmada? t6PA)
        {
            if (t6PA is null)
            {
                throw new Exception("Transaksi Order Pembelian yang ingin Anda edit tidak ditemukan");
            }
            /*if (idTransaksiPelunasanPiutangUsaha is not null)
            {
                throw new Exception($"Transaksi ini tidak dapat diedit karena telah diinput pada Transaksi Pelunasan Piutang Usaha: {idTransaksiPelunasanPiutangUsaha}");
            }*/
            var t6OrderPembelianUpdate = t6PA;
            t6OrderPembelianUpdate.Synchronise = "updated";
            t6OrderPembelianUpdate.WaktuInsert = t6PA.WaktuInsert;
            t6OrderPembelianUpdate.WaktuUpdate = DateTimeOffset.UtcNow;

            return t6OrderPembelianUpdate;
        }
    }
}
