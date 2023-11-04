using bwaAvernus.Server.Data;
using bwaCrixalis.Server._1._Master;
using bwaCrixalis.Server.Data;
using bwaCrixalis.Shared._1._Master;
using bwaCrixalis.Shared._2._Transaksi;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.CodeParser;
using Grpc.Core;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.StackExchangeRedis;
using Pantheon.Server.ServiceDomains;
using Pantheon.Shared.BaseEntityModels;
using Pantheon.Shared.Protos;
using Radzen;
using StackExchange.Redis;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using static Pantheon.Server.Utility.modExtensions;

namespace bwaCrixalis.Server._1._Master;
//[Authorize]
public class svsClassGetDataAlamatSupplierStatusTrue : svpClassGetDataAlamatSupplierStatusTrue.svpClassGetDataAlamatSupplierStatusTrueBase
{
    private readonly AvernusDbContext _dbContext;
    private readonly ILogger<svsClassGetDataAlamatSupplierStatusTrue> _logger;
    private readonly pthIServiceDomain _svd;
    public svsClassGetDataAlamatSupplierStatusTrue(AvernusDbContext dbContext, ILogger<svsClassGetDataAlamatSupplierStatusTrue> logger, pthIServiceDomain svd)
    {
        _dbContext = dbContext;
        _logger = logger;
        _svd = svd;
    }

    #region 'Views'
    public override async Task<RplClassGetDataAlamatSupplierStatusTrue> GetClassGetDataAlamatSupplierStatusTrue(RqsClassGetDataAlamatSupplierStatusTrue request, ServerCallContext context)
    {
        Expression<Func<T2AlamatSupplier, object>> selector;
        selector = t => new
        {
            t.IdAlamatSupplier,
            t.IdSupplier,
            t.IdKota,
            t.IdKecamatan,
            t.IdKelurahan,
            t.JenisAlamat,
            t.Alamat,
            t.KodePos,
            t.Koordinat,
            t.Phone1,
            t.Phone2,
            t.FaxPhone1,
            t.FaxPhone2,
            t.StatusUtama,
            t.Status,
            t.Synchronise,
            Kota = (t.T2Kota == null ? "" : t.T2Kota.Kota)
        };
        Expression<Func<T2AlamatSupplier, bool>>? predicate;
        predicate = t =>
                    t.Status == true;

        var query = _dbContext.Set<T2AlamatSupplier>().Where(predicate).Select(selector);

        var listCariData = query.Adapt<IEnumerable<PtmClassGetDataAlamatSupplierStatusTrue>>();

        var rpl = new RplClassGetDataAlamatSupplierStatusTrue();
        rpl.ListClassGetDataAlamatSupplierStatusTrue.AddRange(listCariData);
        return rpl;
    }
    #endregion

}
