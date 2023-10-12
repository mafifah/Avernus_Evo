using bwaAvernus._1._Master;
using bwaAvernus.Shared._2._Transaksi;
using bwaCrixalis.Client._1._Master;

namespace bwaAvernus.Client._2._Transaksi
{
    public class uimT6PenugasanArmada : T6PenugasanArmada
    {
        public uimT1CustomerInstansi? T1Customer { get; set; }
        public uimT2AlamatCustomer? T2AlamatCustomer { get; set; }
        public string? Customer => T2AlamatCustomer?.T1Customer?.Nama;
        public string AlamatCustomer => T2AlamatCustomer?.Alamat;
        public Guid? IdCustomer { get; set; }
        public Guid? IdAlamatCustomer { get; set; }
        public T7PenugasanArmada? T7PenugasanArmada { get; set; } = new();
        //public uimT3Rute T3Rute { get; set; }
    }
}
