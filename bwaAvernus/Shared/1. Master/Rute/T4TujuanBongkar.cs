using bwaCrixalis.Shared._1._Master;

namespace bwaAvernus.Shared._1._Master
{
    public class T4TujuanBongkar : BaseModelMasterDetil
    {
        [Key]
        [PrimaryKey]
        public Guid IdTujuanBongkar { get; set; } = NewId.NextGuid();
        public Guid? IdRute { get; set; }
        public Guid? IdCustomer { get; set; }
        public long? IdKota { get; set; }
        public string? Penerima { get; set; }
        public string? Alamat { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }

        [ForeignKey("IdRute")]
        public T3Rute? T3Rute { get; set; }
        [ForeignKey("IdCustomer")]
        public T1Customer? T1Customer { get; set; }
        [ForeignKey("IdKota")]
        public pthT2Kota? T2Kota { get; set; }
    }
}
