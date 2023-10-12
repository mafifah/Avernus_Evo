using static bwaAvernus.Shared._1._Master.svpMasterRute;
using static bwaCrixalis.Shared._1._Master.svpMasterArmada;

namespace bwaAvernus._1._Master
{
    public class svcRute : pthBaseService
    {
        private svpMasterRuteClient _client { get; set; }
        private svpMasterArmadaClient _clientArmada { get; set; } //Sementara

        public svcRute()
        {
            _client = new svpMasterRuteClient(ClientChannel);
            _clientArmada = new svpMasterArmadaClient(ClientChannel);

        }

        #region 'Rute'
        public async Task<IEnumerable<uimT3Rute>> GetDataRute()
        {
            var rplRute = await _client.GetRuteAsync(new RqsRute(), Headers);
            return rplRute.RpfRute.Adapt<IEnumerable<uimT3Rute>>();
        }
        public async Task<uimT3Rute> GetDataRuteById(Guid idRute)
        {
            if (idRute == Guid.Empty) return new();
            var rplRute = await _client.GetRuteByIdAsync(new RqsRuteById() { IdRute = idRute.ToString() }, Headers);
            if (!string.IsNullOrEmpty(rplRute.IdRute)) return rplRute.Adapt<uimT3Rute>();
            return new();
        }

        public async Task<IEnumerable<uimT3Rute>> GetDataRuteByIdAlamatCustomer(Guid idAlamatCustomer)
        {
            var rplRute = await _client.GetRuteByIdAlamatCustomerAsync(new RqsRuteByIdAlamatCustomer() { IdAlamatCustomer = idAlamatCustomer.ToString() }, Headers);
            return rplRute.RpfRute.Adapt<IEnumerable<uimT3Rute>>();
        }

        public async Task<IList<dynamic>> GetDataTujuanBongkarById(Guid idRute)
        {
            IList<dynamic> ruteTujuanBongkar;
            var reply = await _client.GetRute_TujuanBongkarAsync(new RqsRuteById { IdRute = idRute.ToString() }, Headers);
            ruteTujuanBongkar = reply?.RpfRuteTujuanBongkar?.Adapt<IList<dynamic>>() ?? new List<dynamic>();
            return ruteTujuanBongkar;
        }
        public async Task<IList<dynamic>> GetDataDokumenRuteById(Guid idRute)
        {
            IList<dynamic> ruteDokumen;
            var reply = await _client.GetRute_DokumenRuteAsync(new RqsRuteById { IdRute = idRute.ToString() }, Headers);
            ruteDokumen = reply?.RpfRuteDokumenRute?.Adapt<IList<dynamic>>() ?? new List<dynamic>();
            return ruteDokumen;
        }
        public async Task<string> InsertRute(uimT3Rute Rute)
        {
            var rqsRute = Rute.Adapt<RqsInsertRute>();
            rqsRute.IdCreator = Auto.ToString();
            var rplRute = await _client.InsertRuteAsync(rqsRute, Headers);
            return rplRute.Result;
        }
        public async Task<string> UpdateRute(uimT3Rute Rute)
        {
            var rqsRute = Rute.Adapt<RqsUpdateRute>();
            rqsRute.IdOperator = Auto.ToString();
            var rplRute = await _client.UpdateRuteAsync(rqsRute, Headers);
            return rplRute.Result;
        }
        public async Task<string> DeleteRute(Guid idRute)
        {
            var rqsRute = new RqsDeleteRute { IdCreator = IdUser.ToString(), IdApplication = IdApplication.ToString(), IdRute = idRute.ToString() };
            var rplRute = await _client.DeleteRuteAsync(rqsRute, Headers);
            return rplRute.Result;
        }

        public async Task<uimT3Rute> GetDraftRute(string idRute)
        {
            var request = new RqsGetDraftRute { IdUser = IdUser.ToString(), IdRute = idRute };
            var reply = await _client.GetDraftRuteAsync(request, Headers);
            return reply.Adapt<uimT3Rute>();
        }

        public async Task<string> SetDraftRute(uimT3Rute Rute)
        {
            var request = Rute.Adapt<RqsSetDraftRute>();
            var reply = await _client.SetDraftRuteAsync(request, Headers);
            return reply.Result;
        }
        #endregion

        public async Task<IEnumerable<T0JenisArmada>> GetDataJenisArmada()
        {
            var rplJenisArmada = await _clientArmada.GetJenisArmadaAsync(new RqsJenisArmada(), Headers);
            return rplJenisArmada.ListT0JenisArmada.Adapt<IEnumerable<T0JenisArmada>>();
        }

    }
}
