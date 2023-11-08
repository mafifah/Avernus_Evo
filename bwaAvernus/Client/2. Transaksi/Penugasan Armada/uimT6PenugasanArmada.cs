using bwaAvernus._1._Master;
using bwaAvernus.Shared._2._Transaksi;
using bwaCrixalis.Client._1._Master;

namespace bwaAvernus.Client._2._Transaksi
{
    public class uimT6PenugasanArmada : T6PenugasanArmada
    {
        public string? Customer => T7PenugasanArmada?.Customer_Nama ?? "";
        public string AlamatCustomer => T7PenugasanArmada?.Customer_Alamat ?? "";
        public string Rute => T7PenugasanArmada?.Rute_Rute ?? "";
        public T7PenugasanArmada? T7PenugasanArmada { get; set; } = new();


        //Modifikasi agar tidak error di Pantheon
        public Guid? IdCustomer { get; set; }
        public Guid? IdAlamatCustomer { get; set; }
        public Guid? IdRute { get; set; }
        public string? IdBBMMetode { get; set; }
    }
}
