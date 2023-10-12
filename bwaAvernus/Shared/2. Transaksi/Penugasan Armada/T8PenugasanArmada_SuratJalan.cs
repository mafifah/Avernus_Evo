using bwaAvernus.Shared._1._Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bwaAvernus.Shared._2._Transaksi
{
    public class T8PenugasanArmada_SuratJalan : BaseModelTransaksiDetil
    {
        [Key]
        [PrimaryKey]
        [Column(Order = 0)]
        public Guid IdDetilDetilPenugasanArmada { get; set; }
        public Guid? IdDetilPenugasanArmada { get; set; }
        public Guid? IdTujuanBongkar { get; set; }
        public long? IdKota { get; set; }
        public string? NomorSuratJalan { get; set; }
        public string? JenisBarang { get; set; }
        public decimal? JumlahMuatan { get; set; }
        public decimal? JumlahKlaim { get; set; }
        public string? Satuan { get; set; }
        public int? TonaseMuatan { get; set; }
        public int? TonaseKlaim { get; set; }
        public decimal? NominalMuatan { get; set; }
        public decimal? NominalKlaim { get; set; }
        public DateTime? TanggalMuat { get; set; }
        public DateTime? TanggalBongkar { get; set; }
        public string? Keterangan { get; set; }
        public string? TujuanBongkar_Penerima { get; set; }
        public string? TujuanBongkar_Alamat { get; set; }
        public string? TujuanBongkar_Phone1 { get; set; }
        public string? TujuanBongkar_Kota { get; set; }
        public string? DokumenRute_Rute { get; set; }

        [ForeignKey(nameof(T8PenugasanArmada_SuratJalan.IdDetilPenugasanArmada))]
        public T7PenugasanArmada? T7PenugasanArmada { get; set; }

        [ForeignKey(nameof(T8PenugasanArmada_SuratJalan.IdTujuanBongkar))]
        public T4TujuanBongkar? T4TujuanBongkar { get; set; }

        [ForeignKey(nameof(T8PenugasanArmada_SuratJalan.IdKota))]
        public pthT2Kota? T2Kota { get; set; }
    }
}
