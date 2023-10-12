global using bwaAvernus.Shared._1._Master;
global using bwaCrixalis.Shared._1._Master;
using static bwaAvernus.Shared._1._Master.svpMasterBBM;

namespace bwaAvernus._1._Master
{
    public class svcBBM : pthBaseService
    {
        private svpMasterBBMClient _client { get; set; }
        public svcBBM()
        {
            _client = new svpMasterBBMClient(ClientChannel);
        }

        public async Task<IEnumerable<uimT0BBM>> GetDataBBM()
        {
            var rplBBM = await _client.GetBBMAsync(new Shared._1._Master.RqsDataBBM(), Headers);
            return rplBBM.RpfBBM.Adapt<IEnumerable<uimT0BBM>>();
        }
        public async Task<IList<dynamic>> GetDataHargaBBMById(Guid idBBM)
        {
            IList<dynamic> hargaBBM;
            var reply = await _client.GetHargaBBMAsync(new RqsBBMById { IdBBM = idBBM.ToString() }, Headers);
            hargaBBM = reply?.RpfHargaBBM?.Adapt<IList<dynamic>>() ?? new List<dynamic>();
            return hargaBBM;

        }
        public async Task<uimT0BBM> GetDataBBMById(Guid idBBM)
        {
            if (idBBM == Guid.Empty) return new();
            var rplBBM = await _client.GetBBMByIdAsync(new RqsBBMById() { IdBBM = idBBM.ToString() }, Headers);
            if (!string.IsNullOrEmpty(rplBBM.IdBBM)) return rplBBM.Adapt<uimT0BBM>();
            return new();
        }
        public async Task<string> InsertBBM(uimT0BBM BBM)
        {
            var rqsBBM = BBM.Adapt<RqsInsertBBM>();
            rqsBBM.IdOperator = Auto.ToString();
            var rplBBM = await _client.InsertBBMAsync(rqsBBM, Headers);
            return rplBBM.Result;
        }

        public async Task<string> UpdateBBM(uimT0BBM BBM)
        {
            var rqsBBM = BBM.Adapt<RqsUpdateBBM>();
            rqsBBM.IdOperator = Auto.ToString();
            var rplBBM = await _client.UpdateBBMAsync(rqsBBM, Headers);
            return rplBBM.Result;
        }
        public async Task<string> DeleteBBM(Guid idBBM)
        {
            var rqsBBM = new RqsDeleteBBM { IdBBM = idBBM.ToString() };
            var rplBBM = await _client.DeleteBBMAsync(rqsBBM, Headers);
            return rplBBM.Result;
        }

        public async Task<uimT0BBM> GetDraftBBM(string idBBM)
        {
            var request = new RqsGetDraftBBM { IdUser = IdUser.ToString(), IdBBM = idBBM };
            var reply = await _client.GetDraftBBMAsync(request, Headers);
            return reply.Adapt<uimT0BBM>();
        }

        public async Task<string> SetDraftBBM(uimT0BBM bbm)
        {
            var request = bbm.Adapt<RqsSetDraftBBM>();
            var reply = await _client.SetDraftBBMAsync(request, Headers);
            return reply.Result;
        }

    }
}
