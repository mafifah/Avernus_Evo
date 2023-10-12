using bwaAvernus.Shared._2._Transaksi;
using bwaCrixalis.Shared._1._Master;

namespace bwaAvernus.Shared._1._Master
{
    public class T3Rute : BaseModelMasterHeader_2
    {
        public ICollection<T4TujuanBongkar>? ListT4TujuanBongkar { get; set; }
        public ICollection<T5DokumenRute>? ListT5DokumenRute { get; set; }
        public ICollection<T4BiayaRute>? ListT4BiayaRute { get; set; }
        public ICollection<T7PenugasanArmada>? ListT7PenugasanArmada { get; set; }

        [Key]
        [PrimaryKey]
        [Column(Order = 0)]
        public Guid IdRute { get; set; }
        public Guid? IdAlamatCustomer { get; set; }
        public Guid? IdPenyeliaCustomer { get; set; }
        public string? Rute { get; set; }
        public string? Alias { get; set; }
        public string? Jenis { get; set; }
        public int? EstimasiWaktu { get; set; }
        public int? EstimasiJarak { get; set; }
        public string? Muatan { get; set; }
        public bool? StatusRutePaket { get; set; }

        [ForeignKey("IdAlamatCustomer")]
        public T2AlamatCustomer? T2AlamatCustomer { get; set; }
        [ForeignKey("IdPenyeliaCustomer")]
        public T2PenyeliaCustomer? T2PenyeliaCustomer { get; set; }
    }
}
