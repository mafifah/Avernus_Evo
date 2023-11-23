using bwaAvernus.Shared._2._Transaksi;
using MassTransit;
using static bwaAvernus.Shared._2._Transaksi.svpTransaksiPenambahanPenugasanArmada;
using static bwaAvernus.Shared._2._Transaksi.svpTransaksiPenugasanArmada;

namespace bwaAvernus.Client._2._Transaksi;
public class svcPenambahanPenugasan: pthBaseService
{
	private svpTransaksiPenambahanPenugasanArmadaClient _client { get; set; }
	public svcPenambahanPenugasan()
	{
		_client = new svpTransaksiPenambahanPenugasanArmadaClient(ClientChannel);
	}

	public async Task<IEnumerable<uimT6PenugasanArmada>> GetDataPenambahanPenugasan(DateTime? tanggalFilterAwal, DateTime? tanggalFilterAkhir)
	{
		var rqsPenambahanPenugasanArmada = new RqsPenambahanPenugasanArmada() { IdKaryawan = IdUser.ToString(), IdForm = 30900020, IdCompany = IdCompany};
		var rplPenambahanPenugasanArmada = await _client.GetPenambahanPenugasanArmadaAsync(rqsPenambahanPenugasanArmada, Headers);
		return rplPenambahanPenugasanArmada.ListT6PenugasanArmada.Adapt<IEnumerable<uimT6PenugasanArmada>>();
	}
	public async Task<uimT6PenugasanArmada> GetDataPenambahanPenugasanById(Guid idPenugasanArmada)
	{
		var rplPenambahanPenugasanArmada = await _client.GetPenambahanPenugasanArmadaByIdAsync(new RqsPenambahanPenugasanArmadaById() { IdPenugasanArmada = idPenugasanArmada.ToString() }, Headers);
		return rplPenambahanPenugasanArmada?.Adapt<uimT6PenugasanArmada>() ?? new uimT6PenugasanArmada();
	}
	public async Task<IList<dynamic>> GetDataT7PenugasanArmadaById(Guid idPenugasanArmada)
	{
		var rplT7PenambahanPenugasanArmada = await _client.GetT7PenambahanPenugasanArmadaByIdAsync(new RqsT7PenambahanPenugasanArmadaById() { IdPenugasanArmada = idPenugasanArmada.ToString() }, Headers);
		return rplT7PenambahanPenugasanArmada.ListT7PenugasanArmada.Adapt<IList<dynamic>>() ?? new List<dynamic>();
	}

	public async Task<IList<dynamic>> GetDataT7PenugasanArmada_SPBUById(Guid idPenugasanArmada)
	{
		var rplT7PenambahanPenugasanArmada_SPBU = await _client.GetT7PenambahanPenugasanArmada_SPBUByIdAsync(new RqsT7PenambahanPenugasanArmadaById() { IdPenugasanArmada = idPenugasanArmada.ToString() }, Headers);
		return rplT7PenambahanPenugasanArmada_SPBU.ListT7PenugasanArmadaSPBU.Adapt<IList<dynamic>>() ?? new List<dynamic>();
	}

	public async Task<string> UpdatePenambahanPenugasan(uimT6PenugasanArmada drPenugasanArmada)
	{
        drPenugasanArmada.Synchronise = "updated";
		if(drPenugasanArmada.T7PenugasanArmada.IdDetilPenugasanArmada == Guid.Parse("00000000-0000-0000-0000-000000000000"))
		{
            drPenugasanArmada.T7PenugasanArmada.Synchronise = "inserted";
            drPenugasanArmada.T7PenugasanArmada.IdPenugasanArmada = drPenugasanArmada.IdPenugasanArmada;
            drPenugasanArmada.T7PenugasanArmada.Urutan = drPenugasanArmada.ListT7PenugasanArmada.Count + 1;
            drPenugasanArmada.T7PenugasanArmada.IdOperator = IdUser;
            drPenugasanArmada.ListT7PenugasanArmada.Add(drPenugasanArmada.T7PenugasanArmada);
		}
		else
		{
			var drLama = drPenugasanArmada.ListT7PenugasanArmada.FirstOrDefault(x => x.IdDetilPenugasanArmada == drPenugasanArmada.T7PenugasanArmada.IdDetilPenugasanArmada);
			drPenugasanArmada.ListT7PenugasanArmada.Remove(drLama);
			drPenugasanArmada.T7PenugasanArmada.IdDetilPenugasanArmada = drLama.IdDetilPenugasanArmada;
            drPenugasanArmada.T7PenugasanArmada.Synchronise = "updated";
            drPenugasanArmada.ListT7PenugasanArmada.Add(drPenugasanArmada.T7PenugasanArmada);

        }

        var rqsPenugasanArmada = drPenugasanArmada.Adapt<RqsUpdatePenambahanPenugasanArmada>();
		rqsPenugasanArmada.IdForm = 30701020;
		var rplPenugasanArmada = await _client.UpdatePenambahanPenugasanArmadaAsync(rqsPenugasanArmada, Headers);
		return rplPenugasanArmada.Result;
	}

	public async Task<uimT6PenugasanArmada> GetDraftPenambahanPenugasan(string idPenugasanArmada)
	{
		var request = new RqsGetDraftPenambahanPenugasanArmada { IdUser = IdUser.ToString(), IdPenugasanArmada = idPenugasanArmada };
		var reply = await _client.GetDraftPenambahanPenugasanArmadaAsync(request, Headers);
		return reply.Adapt<uimT6PenugasanArmada>();
	}

	public async Task<string> SetDraftPenambahanPenugasan(uimT6PenugasanArmada drPenugasanArmada)
	{
		var request = drPenugasanArmada.Adapt<RqsSetDraftPenambahanPenugasanArmada>();
		var reply = await _client.SetDraftPenambahanPenugasanArmadaAsync(request, Headers);
		return reply.Result;
	}

}

