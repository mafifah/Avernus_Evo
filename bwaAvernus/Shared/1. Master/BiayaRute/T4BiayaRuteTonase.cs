using bwaCrixalis.Shared._1._Master;

namespace bwaAvernus.Shared._1._Master
{
    public class T4BiayaRuteTonase : BaseModelMasterDetil
    {
        [Key]
        [PrimaryKey]
        public Guid IdBiayaRuteTonase { get; set; } = NewId.NextGuid();
        public Guid? IdBiayaRute { get; set; }
        public string? IdCompany { get; set; }
        public Guid? IdJenisArmada { get; set; } //Perlu add FK, saat ini belum ada modelnya. Nanti ambil dari Crixalis.
        public Guid? IdRute { get; set; }
        public int? BatasAwal { get; set; }
        public int? BatasAkhir { get; set; }
        public decimal? Harga { get; set; }
        public bool? Status { get; set; }

        [ForeignKey("IdBiayaRute")]
        public T4BiayaRute? T4BiayaRute { get; set; }

        [ForeignKey("IdRute")]
        public T3Rute? T3Rute { get; set; }

        [ForeignKey("IdCompany")]
        public pthT0Company? T0Company { get; set; }

        [ForeignKey("IdJenisArmada")]
        public T0JenisArmada? T0JenisArmada { get; set; }
    }

}
