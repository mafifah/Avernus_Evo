using bwaCrixalis.Shared._1._Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bwaAvernus.Shared._2._Transaksi
{
    public class T7PenugasanArmada_SPBU : BaseModelTransaksiDetil
    {
        [Key]
        [PrimaryKey]
        [Column(Order = 0)]
        public Guid IdDetilPenugasanArmada { get; set; }
        public Guid? IdPenugasanArmada { get; set; }
        public Guid? IdSupplier_SPBU { get; set; }
        public Guid? IdBBM { get; set; }
        public string? Kode1 { get; set; }
        public string? Kode2 { get; set; }
        public int? BBMVolume { get; set; }
        public decimal? BBMVolumeSisa { get; set; }
        public decimal? BBMHarga { get; set; }
        public decimal? BBMTotal { get; set; }
        public DateTimeOffset? TanggalPengisian { get; set; }
        public string? Referensi_Form { get; set; }
        public string? Supplier_SPBU_Nama { get; set; }
        public string? Supplier_SPBU_Inisial { get; set; }
        public string? Supplier_SPBU_Alamat { get; set; }
        public string? Supplier_SPBU_Kota { get; set; }
        public string? Supplier_SPBU_Email1 { get; set; }
        public string? Supplier_SPBU_Phone1 { get; set; }
        public string? Supplier_SPBU_FaxPhone1 { get; set; }
        public string? JenisSupplier_Jenis { get; set; }
        public string? BBM_BBM { get; set; }

        [ForeignKey(nameof(T7PenugasanArmada_SPBU.IdPenugasanArmada))]
        public T6PenugasanArmada? T6PenugasanArmada { get; set; }

        [ForeignKey(nameof(T7PenugasanArmada_SPBU.IdSupplier_SPBU))]
        public T1Supplier? T1Supplier { get; set; }

        [ForeignKey(nameof(T7PenugasanArmada_SPBU.IdBBM))]
        public T0BBM? T0BBM { get; set; }
    }
}
