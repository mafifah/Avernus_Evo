namespace bwaCrixalis.Server._1._Master;
public class svsKaryawan : svpMasterKaryawan.svpMasterKaryawanBase
{
    private readonly ILogger<svsKaryawan> _logger;
    private readonly pthISvdMaster _svd;
    public svsKaryawan(ILogger<svsKaryawan> logger, pthISvdMaster svd)
    {
        _logger = logger;
        _svd = svd;
    }

    #region 'Views'
    public override async Task<RplKaryawanById> GetKaryawanById(RqsKaryawanById request, ServerCallContext context)
    {
        var karyawan = await _svd.GetEntityById<pthT1Karyawan>(request.IdKaryawan);
        return karyawan.Adapt<RplKaryawanById>();
    }
    public override async Task<RplKaryawan> GetKaryawan(RqsKaryawan request, ServerCallContext context)
    {

        var data = await _svd.GetEntities<pthT1Karyawan>();
        var reply = new RplKaryawan();
        reply.ListT1Karyawan.AddRange(data.Adapt<IEnumerable<RplKaryawanById>>());
        return reply;

        //pthIRepoGeneric<pthT1Karyawan> repo = _svd.Uow.GetRepository<pthRepoGeneric<pthT1Karyawan>>();
        //pthIRepoGeneric<pthT5JabatanKaryawan> repopthT5JabatanKaryawan = _svd.Uow.GetRepository<pthRepoGeneric<pthT5JabatanKaryawan>>();
        //var dtKaryawan = await _svd.RedisCache.GetDataRedis<IEnumerable<pthT1Karyawan>>($"{NamaDatabase}~{typeof(pthT1Karyawan).Name}");
        //if (dtKaryawan is null)
        //{
        //	dtKaryawan = await repo.CariDenganPredicate(x => x.IdKaryawan != Auto);
        //	foreach (var item in dtKaryawan)
        //	{
        //		var listpthT5JabatanKaryawan = await repopthT5JabatanKaryawan.CariDenganPredicate(x => x.IdKaryawan == item.IdKaryawan);
        //		if (listpthT5JabatanKaryawan is not null) item.ListT5JabatanKaryawan = listpthT5JabatanKaryawan.ToList();
        //	}
        //	await _svd.RedisCache.SetDataRedis($"{NamaDatabase}~{typeof(pthT1Karyawan).Name}", dtKaryawan);
        //}
        //dtKaryawan = _svd.GetListDataById(dtKaryawan.ToList(), "Synchronise", "deleted", "!=");
        //var rplKaryawan = new RplKaryawan();
        //rplKaryawan.ListT1Karyawan.AddRange(dtKaryawan.Adapt<IList<RplKaryawanById>>());
        //foreach (var item in rplKaryawan.ListT1Karyawan)
        //{
        //	var listpthT5JabatanKaryawan = new List<PtmJabatanKaryawan>();
        //	listpthT5JabatanKaryawan = dtKaryawan.FirstOrDefault(x => x.IdKaryawan == Guid.Parse(item.IdKaryawan))?.ListT5JabatanKaryawan?.Adapt<List<PtmJabatanKaryawan>>();
        //	if (listpthT5JabatanKaryawan is not null) item.ListT5JabatanKaryawan.AddRange(listpthT5JabatanKaryawan);
        //}
        //return rplKaryawan;
    }

    public override async Task<RplKaryawan> Get_Karyawan(RqsKaryawan request, ServerCallContext context)
    {
        var data = await _svd.GetEntities<pthT1Karyawan>();
        var reply = new RplKaryawan();
        reply.ListT1Karyawan.AddRange(data.Adapt<IEnumerable<RplKaryawanById>>());
        return data.Adapt<RplKaryawan>();
    }
    public override async Task<RplJabatanKaryawanByIdKaryawan> GetJabatanKaryawanByIdKaryawan(RqsJabatanKaryawanByIdKaryawan request, ServerCallContext context)
    {
        var listJabatanKaryawan = await _svd.GetEntitiesDenganSpec<pthT5JabatanKaryawan>(
                        x => x.IdJabatan != null,
                        $"T1Karyawan.T0Jabatan");
        var reply = new RplJabatanKaryawanByIdKaryawan();
        reply.ListT5JabatanKaryawan.AddRange(listJabatanKaryawan.Adapt<IEnumerable<PtmJabatanKaryawan>>());
        return reply;
        //pthIRepoGeneric<pthT5JabatanKaryawan> repo = _svd.Uow.GetRepository<pthRepoGeneric<pthT5JabatanKaryawan>>();
        //var listJabatanKaryawan = await repo.CariDenganPredicate(x => x.IdKaryawan == Guid.Parse(request.IdKaryawan));
        //var rplJabatanKaryawan = new RplJabatanKaryawanByIdKaryawan();
        //rplJabatanKaryawan.ListT5JabatanKaryawan.AddRange(listJabatanKaryawan.Adapt<IEnumerable<PtmJabatanKaryawan>>());
        //return rplJabatanKaryawan;
    }
    #endregion

    #region 'Procedure'
    public override async Task<RplWriteKaryawan> InsertKaryawan(RqsInsertKaryawan request, ServerCallContext context)
    {
        var hasil = await _svd.InsertMasterHeader<pthT1Karyawan, string, string, string, string, string>(request.Adapt<pthT1Karyawan>(), "IdKaryawan");
        return new RplWriteKaryawan { IsOK = true, Result = hasil };
    }
    public override async Task<RplWriteKaryawan> UpdateKaryawan(RqsUpdateKaryawan request, ServerCallContext context)
    {
        var hasil = await _svd.UpdateMasterHeader<pthT1Karyawan, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil>(request.Adapt<pthT1Karyawan>(), "IdKaryawan");
        return new RplWriteKaryawan { IsOK = true, Result = hasil };
    }
    public override async Task<RplWriteKaryawan> DeleteKaryawan(RqsDeleteKaryawan request, ServerCallContext context)
    {
        var hasil = await _svd.DeleteMasterHeader<pthT1Karyawan>(request.Adapt<pthT1Karyawan>(), "IdKaryawan");
        return new RplWriteKaryawan { IsOK = true, Result = hasil };
    }
    #endregion
}