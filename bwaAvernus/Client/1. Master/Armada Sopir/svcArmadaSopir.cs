
using bwaCrixalis.Client._1._Master;
using static bwaAvernus.Shared._1._Master.svpArmadaSopir;

namespace bwaAvernus._1._Master
{
    public class svcArmadaSopir
    {
        private svpArmadaSopirClient _client { get; set; }
        public svcArmadaSopir()
        {
            _client = new svpArmadaSopirClient(ClientChannel);
        }

        public async Task<IList<dynamic>> GetDataArmadaSopirById(Guid idArmada)
        {
            var dataKosong = new uimT5ArmadaSopir();
            IList<dynamic> armadaSopir;
            var reply = await _client.GetDataArmadaSopirAsync(new RqsArmadaSopir() { IdArmada = idArmada.ToString() }, Headers);
            armadaSopir = reply?.ListT5ArmadaSopir?.Adapt<IList<dynamic>>() ?? new List<dynamic>();
            return armadaSopir;
        }
    }
}
