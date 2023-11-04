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
public class svsClassGetDataJenisCustomerStatusTrue : svpClassGetDataJenisCustomerStatusTrue.svpClassGetDataJenisCustomerStatusTrueBase
{
    private readonly AvernusDbContext _dbContext;
    private readonly ILogger<svsClassGetDataJenisCustomerStatusTrue> _logger;
    private readonly pthIServiceDomain _svd;
    public svsClassGetDataJenisCustomerStatusTrue(AvernusDbContext dbContext, ILogger<svsClassGetDataJenisCustomerStatusTrue> logger, pthIServiceDomain svd)
    {
        _dbContext = dbContext;
        _logger = logger;
        _svd = svd;
    }

    #region 'Views'
    private IQueryable<object> GetQueryJenisCustomer(RqsClassGetDataJenisCustomerStatusTrue request)
    {
        Expression<Func<T0JenisCustomer, object>> selector;
        selector = t => new
        {
            t.IdJenisCustomer,
            t.Jenis,
            t.Definisi
        };
        Expression<Func<T0JenisCustomer, bool>>? predicate = t => t.Status == true;

        var query = _dbContext.Set<T0JenisCustomer>().Where(predicate).Select(selector);
        return query;
    }
    public override async Task<RplClassGetDataJenisCustomerStatusTrue> GetClassGetDataJenisCustomerStatusTrue(RqsClassGetDataJenisCustomerStatusTrue request, ServerCallContext context)
    {
        var query = GetQueryJenisCustomer(request);
        var listCariData = query.Adapt<IEnumerable<PtmClassGetDataJenisCustomerStatusTrue>>();

        var rpl = new RplClassGetDataJenisCustomerStatusTrue();
        rpl.ListClassGetDataJenisCustomerStatusTrue.AddRange(listCariData);
        return rpl;
    }
    #endregion

}
