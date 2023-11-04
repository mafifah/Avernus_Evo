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
public class svsClassGetDataJenisSupplierStatusTrue : svpClassGetDataJenisSupplierStatusTrue.svpClassGetDataJenisSupplierStatusTrueBase
{
    private readonly AvernusDbContext _dbContext;
    private readonly ILogger<svsClassGetDataJenisSupplierStatusTrue> _logger;
    private readonly pthIServiceDomain _svd;
    public svsClassGetDataJenisSupplierStatusTrue(AvernusDbContext dbContext, ILogger<svsClassGetDataJenisSupplierStatusTrue> logger, pthIServiceDomain svd)
    {
        _dbContext = dbContext;
        _logger = logger;
        _svd = svd;
    }

    #region 'Views'
    private IQueryable<object> GetQueryJenisSupplier(RqsClassGetDataJenisSupplierStatusTrue request)
    {
        Expression<Func<T0JenisSupplier, object>> selector;
        selector = t => new
        {
            t.IdJenisSupplier,
            t.Jenis,
            t.Definisi
        };
        Expression<Func<T0JenisSupplier, bool>>? predicate = t => t.Status == true;

        var query = _dbContext.Set<T0JenisSupplier>().Where(predicate).Select(selector);
        return query;
    }
    public override async Task<RplClassGetDataJenisSupplierStatusTrue> GetClassGetDataJenisSupplierStatusTrue(RqsClassGetDataJenisSupplierStatusTrue request, ServerCallContext context)
    {
        var query = GetQueryJenisSupplier(request);
        var listCariData = query.Adapt<IEnumerable<PtmClassGetDataJenisSupplierStatusTrue>>();

        var rpl = new RplClassGetDataJenisSupplierStatusTrue();
        rpl.ListClassGetDataJenisSupplierStatusTrue.AddRange(listCariData);
        return rpl;
    }
    #endregion

}
