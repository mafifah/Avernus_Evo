global using bwaAvernus.Server.Data;
using bwaCrixalis.Server._1._Master;
using bwaCrixalis.Server.Data;
using bwaCrixalis.Shared._1._Master;
using bwaCrixalis.Shared._2._Transaksi;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.CodeParser;
using Grpc.Core;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.StackExchangeRedis;
using Pantheon.Server.ServiceDomains;
using Pantheon.Shared.BaseEntityModels;
using Pantheon.Shared.Protos;
using Radzen;
using StackExchange.Redis;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using static Pantheon.Server.Utility.modExtensions;

namespace bwaCrixalis.Server._1._Master;
//[Authorize]
public class svsClassGetDataCompanyStatusTrue : svpClassGetDataCompanyStatusTrue.svpClassGetDataCompanyStatusTrueBase
{
    private readonly AvernusDbContext _dbContext;
    private readonly ILogger<svsClassGetDataCompanyStatusTrue> _logger;
    private readonly pthIServiceDomain _svd;
    public svsClassGetDataCompanyStatusTrue(AvernusDbContext dbContext, ILogger<svsClassGetDataCompanyStatusTrue> logger, pthIServiceDomain svd)
    {
        _dbContext = dbContext;
        _logger = logger;
        _svd = svd;
    }

    #region 'Views'
    public override async Task<RplClassGetDataCompanyStatusTrue> GetClassGetDataCompanyStatusTrue(RqsClassGetDataCompanyStatusTrue request, ServerCallContext context)
    {
        var query = _dbContext.T0Company
            .Where(c => c.Status == true)
            .Select(c => new
            {
                IdCompany = "0",
                IdKaryawan_Direktur = (Guid?)null,
                IdVendor_KPP = (Guid?)null,
                Prefix = "",
                Nama = "",
                Inisial = "",
                Departemen = "",
                Slogan = "",
                Alamat = "",
                KodePos = "",
                KotakPos = "",
                Website1 = "",
                Email1 = "",
                Phone1 = "",
                FaxPhone1 = "",
                NPWP = "",
                Keterangan = "",
                LogoPath = "",
                Tag = "",
                IdJabatan_Direktur = (Guid?)null,
                Karyawan_Direktur_NamaLengkap = "",
                Jabatan_Direktur_Jabatan = "",
                IdJenisVendor_KPP = (Guid?)null,
                Vendor_KPP_Nama = "",
                Vendor_KPP_Alamat = "",
                JenisVendor_Jenis = "",
                Kota = "",
                KodeISO2 = "",
                KodeISO3 = "",
                Country = ""
            })
            .Concat(
                from company in _dbContext.T0Company
                join karyawan in _dbContext.T1Karyawan on company.IdKaryawan_Direktur equals karyawan.IdKaryawan into karyawanGroup
                from karyawan in karyawanGroup.DefaultIfEmpty()
                join jabatan in _dbContext.T0Jabatan on karyawan.IdJabatan equals jabatan.IdJabatan into jabatanGroup
                from jabatan in jabatanGroup.DefaultIfEmpty()
                join vendor in _dbContext.T1Vendor on company.IdVendor_KPP equals vendor.IdVendor into vendorGroup
                from vendor in vendorGroup.DefaultIfEmpty()
                join jenisVendor in _dbContext.T0JenisVendor on vendor.IdJenisVendor equals jenisVendor.IdJenisVendor into jenisVendorGroup
                from jenisVendor in jenisVendorGroup.DefaultIfEmpty()
                join kota in _dbContext.T2Kota on company.IdKota equals kota.IdKota
                join provinsi in _dbContext.T1Provinsi on kota.IdProvinsi equals provinsi.IdProvinsi
                join negara in _dbContext.T0Negara on provinsi.IdNegara equals negara.IdNegara
                where company.Status == true
                select new
                {
                    IdCompany = company.IdCompany.ToString(),
                    IdKaryawan_Direktur = company.IdKaryawan_Direktur,
                    IdVendor_KPP = company.IdVendor_KPP,
                    Prefix = company.Prefix,
                    Nama = company.Nama,
                    Inisial = company.Inisial,
                    Departemen = company.Departemen,
                    Slogan = company.Slogan,
                    Alamat = company.Alamat,
                    KodePos = company.KodePos,
                    KotakPos = company.KotakPos,
                    Website1 = company.Website1,
                    Email1 = company.Email1,
                    Phone1 = company.Phone1,
                    FaxPhone1 = company.FaxPhone1,
                    NPWP = company.NPWP,
                    Keterangan = company.Keterangan,
                    LogoPath = company.LogoPath,
                    Tag = company.Tag,
                    IdJabatan_Direktur = karyawan.IdJabatan,
                    Karyawan_Direktur_NamaLengkap = karyawan.NamaLengkap ?? "",
                    Jabatan_Direktur_Jabatan = jabatan.Jabatan ?? "",
                    IdJenisVendor_KPP = vendor.IdJenisVendor,
                    Vendor_KPP_Nama = vendor.Nama ?? "",
                    Vendor_KPP_Alamat = vendor.Alamat ?? "",
                    JenisVendor_Jenis = jenisVendor.Jenis ?? "",
                    Kota = kota.Jenis + " " + kota.Kota,
                    KodeISO2 = negara.KodeISO2,
                    KodeISO3 = negara.KodeISO3,
                    Country = negara.Country
                }
            );

        var listCariData = query.Adapt<IEnumerable<PtmClassGetDataCompanyStatusTrue>>();

        var rpl = new RplClassGetDataCompanyStatusTrue();
        rpl.ListClassGetDataCompanyStatusTrue.AddRange(listCariData);
        return rpl;
    }
    #endregion

}
