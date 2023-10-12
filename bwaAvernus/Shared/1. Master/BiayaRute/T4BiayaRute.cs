using bwaCrixalis.Shared._1._Master;

namespace bwaAvernus.Shared._1._Master
{
    public class T4BiayaRute : BaseModelMasterDetil
    {
        public ICollection<T4BiayaRuteTonase>? ListT4BiayaRuteTonase { get; set; }
        public ICollection<T4HargaRuteTonase>? ListT4HargaRuteTonase { get; set; }

        [Key]
        [PrimaryKey]
        public Guid IdBiayaRute { get; set; } = NewId.NextGuid();
        public string? IdCompany { get; set; } = "GMA";
        public Guid? IdRute { get; set; }
        public Guid? IdJenisArmada { get; set; } //Perlu add FK, saat ini belum ada modelnya. Nanti ambil dari Crixalis.
        public int? Tonase { get; set; } = 0;
        public long? IdSPBU { get; set; }
        public int? BBMVolume { get; set; } = 0;
        public string? BBMMetode { get; set; } = "Cash";
        public decimal? SanguTonase { get; set; } = 0;
        public decimal? SanguRitase { get; set; } = 0;
        public decimal? Deposit { get; set; } = 0;
        public decimal? Komisi { get; set; } = 0; 
        public decimal? BiayaLain { get; set; } = 0;
        public decimal? Bonus { get; set; } = 0;
        public string? ProsentaseDeposit { get; set; }
        public string? ProsentaseSanguTonase { get; set; }
        public decimal? HargaTonase { get; set; } = 0;
        public decimal? HargaRitase { get; set; } = 0;
        public string? JenisHargaDefault { get; set; } = "Tonase";

        [ForeignKey("IdRute")]
        public T3Rute? T3Rute { get; set; }

        [ForeignKey("IdCompany")]
        public pthT0Company? T0Company { get; set; }

        [ForeignKey("IdJenisArmada")]
        public T0JenisArmada? T0JenisArmada { get; set; }
    }

}
