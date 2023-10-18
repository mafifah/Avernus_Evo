using bwaAvernus.Client._4._Dokumen;
using bwaCrixalis.Client._4._Dokumen;
using DevExpress.Xpo.DB;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.WebDocumentViewer;

namespace bwaCrixalis.Server.Controllers;
public class CustomWebDocumentViewerReportResolver : IWebDocumentViewerReportResolver
{
    public CustomWebDocumentViewerReportResolver() { }
    string reportName;
    string idPrimaryKey;
    public XtraReport? Resolve(string reportUniqueName)
		{
        //var typeReport = AssemblyProject.ExportedTypes.Where(t => t.IsSubclassOf(typeof(XtraReport))).ToList().FirstOrDefault(c => c.Name == reportUniqueName);
        //if (typeReport is null) return null;
        //return (XtraReport?)Activator.CreateInstance(typeReport);
        string[] parts = reportUniqueName.Split('?');
        if (parts.Length == 2)
        {
            reportName = parts[0];
            idPrimaryKey = parts[1].Split('=')[1];
        }
        switch (reportName)
        {
            case "rptDivisiBarang":
                return new rptDivisiBarang();
            case "TestReport":
                return new rptDivisiBarang();
            case "rptPenugasanArmada_1":
                return new rptPenugasanArmada_1(idPrimaryKey);
            default:
                //Try to create a report using the fully qualified type name.
               Type? t = Type.GetType(reportUniqueName);
                return typeof(XtraReport).IsAssignableFrom(t) ?
                    (XtraReport?)Activator.CreateInstance(t) :
                    null;
        }
    }
}
