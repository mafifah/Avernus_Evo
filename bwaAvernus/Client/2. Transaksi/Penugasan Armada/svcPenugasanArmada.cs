using bwaAvernus.Shared._2._Transaksi;
using bwaCrixalis.Client._1._Master;
using Pantheon.Shared.UIModels;
using static bwaAvernus.Shared._2._Transaksi.svpTransaksiPenugasanArmada;

namespace bwaAvernus.Client._2._Transaksi
{
    public class svcPenugasanArmada : pthBaseService
    {
        private svpTransaksiPenugasanArmadaClient _client { get; set; }
        public svcPenugasanArmada()
        {
            _client = new svpTransaksiPenugasanArmadaClient(ClientChannel);
        }

        public async Task<IEnumerable<uimT6PenugasanArmada>> GetDataPenugasanArmada(DateTime? tanggalFilterAwal, DateTime? tanggalFilterAkhir)
        {
            var rqsPenugasanArmada = new RqsPenugasanArmada() { IdKaryawan = IdUser.ToString(), IdForm = 30900020, IdCompany = IdCompany, TanggalFilterAwal = tanggalFilterAwal?.ToString("yyyy-MM-dd") ?? "", TanggalFilterAkhir = tanggalFilterAkhir?.ToString("yyyy-MM-dd") ?? "" };
            var rplPenugasanArmada = await _client.GetPenugasanArmadaAsync(rqsPenugasanArmada, Headers);
            return rplPenugasanArmada.ListT6PenugasanArmada.Adapt<IEnumerable<uimT6PenugasanArmada>>();
        }
        public async Task<uimT6PenugasanArmada> GetDataPenugasanArmadaById(Guid idPenugasanArmada)
        {
            var rplPenugasanArmada = await _client.GetPenugasanArmadaByIdAsync(new RqsPenugasanArmadaById() { IdPenugasanArmada = idPenugasanArmada.ToString() }, Headers);
            return rplPenugasanArmada?.Adapt<uimT6PenugasanArmada>() ?? new uimT6PenugasanArmada();
        }
        public async Task<IList<dynamic>> GetDataT7PenugasanArmadaById(Guid idPenugasanArmada)
        {
            var rplT7PenugasanArmada = await _client.GetT7PenugasanArmadaByIdAsync(new RqsT7PenugasanArmadaById() { IdPenugasanArmada = idPenugasanArmada.ToString() }, Headers);
            return rplT7PenugasanArmada.ListT7PenugasanArmada.Adapt<IList<dynamic>>() ?? new List<dynamic>();
        }

        public async Task<IList<dynamic>> GetDataT7PenugasanArmada_SPBUById(Guid idPenugasanArmada)
        {
            var rplT7PenugasanArmada_SPBU = await _client.GetT7PenugasanArmada_SPBUByIdAsync(new RqsT7PenugasanArmadaById() { IdPenugasanArmada = idPenugasanArmada.ToString() }, Headers);
            return rplT7PenugasanArmada_SPBU.ListT7PenugasanArmadaSPBU.Adapt<IList<dynamic>>() ?? new List<dynamic>();
        }

        public async Task<object> GetValidasiRute(string nopol)
        {
            var rplValidasiRute = await _client.GetValidasiRuteAsync(new RqsValidasiRute() { Nopol = nopol }, Headers);
            return rplValidasiRute.Adapt<object>();
        }
        public async Task<string> InsertPenugasanArmada(uimT6PenugasanArmada drPenugasanArmada)
        {
            drPenugasanArmada.StatusPerjalanan = "Rute 1";
            var dtT7PenugasanArmada = new List<T7PenugasanArmada>();
            dtT7PenugasanArmada.Add(drPenugasanArmada.T7PenugasanArmada);
            drPenugasanArmada.ListT7PenugasanArmada = dtT7PenugasanArmada.Adapt<ICollection<T7PenugasanArmada>>();
            var rqsPenugasanArmada = drPenugasanArmada.Adapt<RqsInsertPenugasanArmada>();
            rqsPenugasanArmada.IdForm = 30701020;
            //rqsPenugasanArmada.ListT5Pembayaran.AddRange(dtT5Pembayaran.Adapt<IEnumerable<PtmT5Pembayaran_T6PenugasanArmada>>());
            var rplPenugasanArmada = await _client.InsertPenugasanArmadaAsync(rqsPenugasanArmada, Headers);
            return rplPenugasanArmada.Result;
        }

        public async Task<string> UpdatePenugasanArmada(uimT6PenugasanArmada drPenugasanArmada)
        {
            
            var dtT7PenugasanArmada = new List<T7PenugasanArmada>();
            drPenugasanArmada.Synchronise = "updated";
            drPenugasanArmada.T7PenugasanArmada.IdOperator = IdUser;
            dtT7PenugasanArmada.Add(drPenugasanArmada.T7PenugasanArmada);
            drPenugasanArmada.ListT7PenugasanArmada = dtT7PenugasanArmada.Adapt<ICollection<T7PenugasanArmada>>();
            if (drPenugasanArmada.WaktuInsert is null && drPenugasanArmada.Synchronise == "inserted")
            {
                return await InsertPenugasanArmada(drPenugasanArmada);
            }
            drPenugasanArmada.Synchronise = "inserted";
            var rqsPenugasanArmada = drPenugasanArmada.Adapt<RqsUpdatePenugasanArmada>();
            rqsPenugasanArmada.IdForm = 30701020;
            //rqsPenugasanArmada.ListT5Pembayaran.AddRange(dtT5Pembayaran.Adapt<IEnumerable<PtmT5Pembayaran_T6PenugasanArmada>>());
            var rplPenugasanArmada = await _client.UpdatePenugasanArmadaAsync(rqsPenugasanArmada, Headers);
            return rplPenugasanArmada.Result;
        }

        public async Task<string> BatalPenugasanArmada(Guid idPenugasanArmada)
        {
            var rqsPenugasanArmada = new RqsBatalPenugasanArmada();
            rqsPenugasanArmada.IdPenugasanArmada = idPenugasanArmada.ToString();
            rqsPenugasanArmada.IdOperator = IdUser.ToString();
            var rplPenugasanArmada = await _client.BatalPenugasanArmadaAsync(rqsPenugasanArmada, Headers);
            return rplPenugasanArmada.Result;
        }

        public async Task<uimT6PenugasanArmada> GetDraftPenugasanArmada(string idPenugasanArmada)
        {
            var request = new RqsGetDraftPenugasanArmada { IdUser = IdUser.ToString(), IdPenugasanArmada = idPenugasanArmada };
            var reply = await _client.GetDraftPenugasanArmadaAsync(request, Headers);
            return reply.Adapt<uimT6PenugasanArmada>();
        }

        public async Task<string> SetDraftPenugasanArmada(uimT6PenugasanArmada drPenugasanArmada)
        {
            var request = drPenugasanArmada.Adapt<RqsSetDraftPenugasanArmada>();
            var reply = await _client.SetDraftPenugasanArmadaAsync(request, Headers);
            return reply.Result;
        }
    }
}
