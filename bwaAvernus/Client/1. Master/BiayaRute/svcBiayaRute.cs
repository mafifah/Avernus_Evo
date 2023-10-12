using bwaAvernus.Shared._1._Master;
using Mapster;
using Pantheon.Services;
using static bwaAvernus.Shared._1._Master.svpMasterBiayaRute;
namespace bwaAvernus._1._Master
{
    public class svcBiayaRute : pthBaseService
    {
        private svpMasterBiayaRuteClient _client { get; set; }

        public svcBiayaRute()
        {
            _client = new svpMasterBiayaRuteClient(ClientChannel);
        }

        public async Task<IEnumerable<uimT3Rute>> GetDataBiayaRute()
        {
            var rplRute = await _client.GetRuteAsync(new RqsPtmRute(), Headers);
            return rplRute.RpfRute.Adapt<IEnumerable<uimT3Rute>>();
        }

        public async Task<IList<dynamic>> GetDataBiayaRuteById(Guid idRute)
        {
            IList<dynamic> dtBiayaRute;
            var reply = await _client.GetRute_BiayaRuteAsync(new RqsBiayaRute { IdRute = idRute.ToString() }, Headers);
            var biayaRute = reply?.RpfBiayaRute?.Adapt<IList<uimT4BiayaRute>>() ?? new List<uimT4BiayaRute>();
            dtBiayaRute = biayaRute.Where(x => x.T0JenisArmada.Status == true).ToList().Adapt<IList<dynamic>>();
            return dtBiayaRute;
        }

        public async Task<string> UpdateBiayaRute(uimT3Rute Rute)
        {
            var rqsRute = Rute.Adapt<RqsUpdateBiayaRute>();
            rqsRute.IdOperator = Auto.ToString();
            var rplRute = await _client.UpdateBiayaRuteAsync(rqsRute, Headers);
            return rplRute.Result;
        }
       

        public async Task<uimT3Rute> GetDraftRute(string idRute)
        {
            var request = new RqsGetDraftBiayaRute { IdUser = IdUser.ToString(), IdRute = idRute };
            var reply = await _client.GetDraftBiayaRuteAsync(request, Headers);
            return reply.Adapt<uimT3Rute>();
        }

        public async Task<string> SetDraftRute(uimT3Rute Rute)
        {
            var request = Rute.Adapt<RqsSetDraftBiayaRute>();
            var reply = await _client.SetDraftBiayaRuteAsync(request, Headers);
            return reply.Result;
        }

    }
}
