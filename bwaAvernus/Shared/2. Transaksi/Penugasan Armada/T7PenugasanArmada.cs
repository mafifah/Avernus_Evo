using bwaAvernus.Shared._1._Master;
using bwaCrixalis.Shared._1._Master;

namespace bwaAvernus.Shared._2._Transaksi
{
    public class T7PenugasanArmada : BaseModelTransaksiDetil
    {
        [Key]
        [PrimaryKey]
        [Column(Order = 0)]
        public Guid IdDetilPenugasanArmada { get; set; }
        public Guid? IdPenugasanArmada { get; set; }
        public Guid? IdRute { get; set; }
        public Guid? IdCustomer { get; set; }
        public Guid? IdJenisCustomer { get; set; }
        public Guid? IdPenyeliaCustomer { get; set; }
        public Guid? IdAlamatCustomer { get; set; }
        public DateTimeOffset? WaktuPenugasan { get; set; }
        public int? Urutan { get; set; }
        public int? TonaseAwal { get; set; }
        public int? TonaseRealisasi { get; set; }
        public string? Muatan { get; set; }
        public int? BBMVolume { get; set; }
        public string? BBMMetode { get; set; }
        public decimal? BBMHarga { get; set; }
        public decimal? SanguTonase { get; set; }
        public decimal? SanguRitase { get; set; }
        public decimal? SanguSementara { get; set; }
        public string? ProsentaseSanguTonase { get; set; }
        public decimal? Deposit { get; set; }
        public string? ProsentaseDeposit { get; set; }
        public decimal? BonSopir { get; set; }
        public decimal? Komisi { get; set; }
        public decimal? HargaTonase { get; set; }
        public decimal? HargaRitase { get; set; }
        public string? JenisHarga { get; set; }
        public decimal? TotalHarga { get; set; }
        public decimal? TotalAkhir { get; set; }
        public decimal? KelebihanSanguSementara { get; set; }
        public decimal? SisaSangu { get; set; }
        public bool? StatusSuratJalan { get; set; }
        public bool? StatusPenagihan { get; set; }
        public string? KeteranganRute { get; set; }
        public string? Rute_Rute { get; set; }
        public string? Rute_Jenis { get; set; }
        public string? Customer_Nama { get; set; }
        public string? Customer_Inisial { get; set; }
        public string? Customer_Alamat { get; set; }
        public string? Customer_Kota { get; set; }
        public string? Customer_Email1 { get; set; }
        public string? Customer_Phone1 { get; set; }
        public string? Customer_FaxPhone1 { get; set; }
        public string? JenisCustomer_Jenis { get; set; }
        public string? PenyeliaCustomer_Nama { get; set; }
        public string? PenyeliaCustomer_JenisKelamin { get; set; }
        public string? PenyeliaCustomer_Jabatan { get; set; }
        public string? AlamatCustomer_Alamat { get; set; }
        public string? AlamatCustomer_KodePos { get; set; }
        public string? AlamatCustomer_Kota { get; set; }
        public DateTimeOffset? WaktuProses_Pembayaran { get; set; }
        public int? CetakFaktur { get; set; }
        public string? NoPenugasan { get; set; }
        public string? IdCompany { get; set; }

        [ForeignKey(nameof(T7PenugasanArmada.IdPenugasanArmada))]
        public T6PenugasanArmada? T6PenugasanArmada { get; set; }

        [ForeignKey(nameof(T7PenugasanArmada.IdRute))]
        public T3Rute? T3Rute { get; set; }

        [ForeignKey(nameof(T7PenugasanArmada.IdCustomer))]
        public T1Customer? T1Customer { get; set; }

        [ForeignKey(nameof(T7PenugasanArmada.IdPenyeliaCustomer))]
        public T2PenyeliaCustomer? T2PenyeliaCustomer { get; set; }

        [ForeignKey(nameof(T7PenugasanArmada.IdAlamatCustomer))]
        public T2AlamatCustomer? T2AlamatCustomer { get; set; }

        [ForeignKey(nameof(T7PenugasanArmada.IdCompany))]
        public pthT0Company? T0Company { get; set; }

        public ICollection<T8PenugasanArmada_Biaya>? ListT8PenugasanArmada_Biaya { get; }
        public ICollection<T8PenugasanArmada_SuratJalan>? ListT8PenugasanArmada_SuratJalan { get; }

        public static T7PenugasanArmada BuatBaru(T7PenugasanArmada t7PA, string idTransaksiGenerated)
        {
            var t7PenugasanArmada = t7PA;
            t7PenugasanArmada.IdPenugasanArmada = NewId.NextGuid();
            t7PenugasanArmada.NoPenugasan = idTransaksiGenerated;
            t7PenugasanArmada.Synchronise = "inserted";
            t7PenugasanArmada.WaktuInsert = DateTimeOffset.UtcNow;

            return t7PenugasanArmada;
        }
    }
}
