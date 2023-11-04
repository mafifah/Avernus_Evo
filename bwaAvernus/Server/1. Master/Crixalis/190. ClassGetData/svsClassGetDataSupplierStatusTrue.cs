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
public class svsClassGetDataSupplierStatusTrue : svpClassGetDataSupplierStatusTrue.svpClassGetDataSupplierStatusTrueBase
{
    private readonly AvernusDbContext _dbContext;
    private readonly ILogger<svsClassGetDataSupplierStatusTrue> _logger;
    private readonly pthIServiceDomain _svd;
    public svsClassGetDataSupplierStatusTrue(AvernusDbContext dbContext, ILogger<svsClassGetDataSupplierStatusTrue> logger, pthIServiceDomain svd)
    {
        _dbContext = dbContext;
        _logger = logger;
        _svd = svd;
    }

    #region 'Views'
    private IQueryable<object> GetQuerySupplier(RqsClassGetDataSupplierStatusTrue request)
    {
        Expression<Func<T1Supplier, object>> selector;
        selector = t => new
        {
            t.IdSupplier,
            t.IdJenisSupplier,
            t.Prefix,
            t.Nama,
            Supplier = $"{t.Nama}" +
                       $"{(t.Prefix != "" ? $" | {t.Prefix}" : "")}" +
                       $"{(t.T0JenisSupplier.Jenis != "" ? $" | {t.T0JenisSupplier.Jenis}" : "")}",
            t.Kode,
            t.Inisial,
            t.Alamat,
            Kota = $"{t.T2Kota.Jenis ?? ""} {t.T2Kota.Kota}",
            t.KodePos,
            t.Website1,
            t.Email1,
            t.Phone1,
            t.Phone2,
            t.FaxPhone1,
            t.JenisPPN,
            t.JenisPembelian,
            t.JenisReturPembelian,
            t.Termin,
            t.BatasHutangGiro,
            t.BatasHutangUsaha,
            t.PersyaratanDokumen1,
            t.PersyaratanDokumen2,
            t.PersyaratanDokumen3,
            t.Koordinat,
            t.FreightOnBoard,
            t.PortOfCharge,
            t.PersentasePerjanjianUangMuka,
            t.PersentaseBatasUangMuka,
            t.Tag,
            t.T0Negara.Negara,
            t.T0Negara.Country,
            t.T0Negara.KodeISO2,
            t.T0Negara.KodeISO3,
            JenisSupplier = t.T0JenisSupplier.Jenis
        };
        Expression<Func<T1Supplier, bool>>? predicate;
        predicate = t =>
                    t.Status == true &&
                    t.IsDVisible == true;

        var query = _dbContext.Set<T1Supplier>().Where(predicate).Select(selector);
        return query;
    }
    public override async Task GetStreamClassGetDataSupplierStatusTrue(RqsClassGetDataSupplierStatusTrue request, IServerStreamWriter<PtmClassGetDataSupplierStatusTrue> responseStream, ServerCallContext context)
    {
        var query = GetQuerySupplier(request);
        foreach (var obj in query)
        {
            if (context.CancellationToken.IsCancellationRequested)
            {
                // Cek apakah ada permintaan pembatalan dari klien
                break; // Hentikan streaming jika permintaan pembatalan diterima
            }
            var dr = obj.Adapt<PtmClassGetDataSupplierStatusTrue>();
            await responseStream.WriteAsync(dr);
        }
    }

    public override async Task<RplClassGetDataSupplierStatusTrue> GetClassGetDataSupplierStatusTrue(RqsClassGetDataSupplierStatusTrue request, ServerCallContext context)
    {
        var query = GetQuerySupplier(request);
        var listCariData = query.Adapt<IEnumerable<PtmClassGetDataSupplierStatusTrue>>();

        var rpl = new RplClassGetDataSupplierStatusTrue();
        rpl.ListClassGetDataSupplierStatusTrue.AddRange(listCariData);
        return rpl;
    }
    #endregion

}
