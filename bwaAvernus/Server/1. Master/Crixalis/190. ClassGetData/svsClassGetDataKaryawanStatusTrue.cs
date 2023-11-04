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
public class svsClassGetDataKaryawanStatusTrue : svpClassGetDataKaryawanStatusTrue.svpClassGetDataKaryawanStatusTrueBase
{
    private readonly AvernusDbContext _dbContext;
    private readonly ILogger<svsClassGetDataKaryawanStatusTrue> _logger;
    private readonly pthIServiceDomain _svd;
    public svsClassGetDataKaryawanStatusTrue(AvernusDbContext dbContext, ILogger<svsClassGetDataKaryawanStatusTrue> logger, pthIServiceDomain svd)
    {
        _dbContext = dbContext;
        _logger = logger;
        _svd = svd;
    }

    #region 'Views'
    private IQueryable<object> GetQueryKaryawan(RqsClassGetDataKaryawanStatusTrue request)
    {
        Expression<Func<pthT1Karyawan, object>> selector;
        selector = t => new
        {
            t.IdKaryawan,
            t.IdDivisiPerusahaan,
            t.IdJabatan,
            t.NamaLengkap,
            t.NamaPanggilan,
            t.JenisKelamin,
            t.AlamatTinggal,
            t.KodePosTinggal,
            //KotaTinggal = $"{(t.T2KotaTinggal.Jenis == null ? "" : $"{t.T2KotaTinggal.Jenis} ")}{t.T2KotaTinggal.Kota ?? ""}",
            t.Seluler1,
            t.Seluler2,
            t.Email,
            t.UserName,
            t.UserPassword,
            t.PasswordHint,
            t.StatusLogin,
            t.NIK,
            Termin = 0,
            BatasPiutangKaryawan = 0,
            t.IsDVisible,
            t.Status,
            t.Tag,
            t.T0Jabatan.Jabatan,
            t.T0Jabatan.Grade,
            //t.T0DivisiPerusahaan.Divisi
        };
        Expression<Func<pthT1Karyawan, bool>>? predicate;
            predicate = t =>
                        t.Status == true;

        var query = _dbContext.Set<pthT1Karyawan>().Where(predicate).Select(selector);
        return query;
    }

    public override async Task<RplClassGetDataKaryawanStatusTrue> GetClassGetDataKaryawanStatusTrue(RqsClassGetDataKaryawanStatusTrue request, ServerCallContext context)
    {
        var query = GetQueryKaryawan(request);
        var listCariData = query.Adapt<IEnumerable<PtmClassGetDataKaryawanStatusTrue>>();

        var rpl = new RplClassGetDataKaryawanStatusTrue();
        rpl.ListClassGetDataKaryawanStatusTrue.AddRange(listCariData);
        return rpl;
    }
    #endregion

}
