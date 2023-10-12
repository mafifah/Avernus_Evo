
using bwaAvernus.Shared._1._Master;

namespace bwaAvernus._1._Master
{
    public class uimT4BiayaRute : T4BiayaRute
    {
        public string? Rute => T3Rute?.Rute;
        public string? JenisArmada => T0JenisArmada?.Jenis;
        public string? JenisArmadaAlias => T0JenisArmada?.Alias;
    }
}
