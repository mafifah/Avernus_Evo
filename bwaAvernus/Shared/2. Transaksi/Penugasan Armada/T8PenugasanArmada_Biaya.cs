using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bwaAvernus.Shared._2._Transaksi
{
    public class T8PenugasanArmada_Biaya : BaseModelTransaksiDetil
    {
        [Key]
        [PrimaryKey]
        [Column(Order = 0)]
        public Guid IdDetilDetilPenugasanArmada { get; set; }
        public Guid? IdDetilPenugasanArmada { get; set; }
        public string? IdAkun { get; set; }
        public DateTimeOffset? WaktuProses { get; set; }
        public decimal? Nominal { get; set; }
        public string? Akun_Kode { get; set; }
        public string? Akun_Akun { get; set; }
        public string? Akun_Alias { get; set; }
        public string? Keterangan { get; set; }
        public string? Referensi_Form { get; set; }
        public long? Referensi_Id { get; set; }
        public string? Referensi_NoTransaksi { get; set; }
        public string? Referensi_IdTransaksi { get; set; }
        public DateTimeOffset? Referensi_WaktuProses { get; set; }
        public string? Referensi_Rantai { get; set; }

        [ForeignKey(nameof(T8PenugasanArmada_Biaya.IdDetilPenugasanArmada))]
        public T7PenugasanArmada? T7PenugasanArmada { get; set; }

        [ForeignKey(nameof(T8PenugasanArmada_Biaya.IdAkun))]
        public pthT0Akun? T0Akun { get; set; }
        
    }
}
