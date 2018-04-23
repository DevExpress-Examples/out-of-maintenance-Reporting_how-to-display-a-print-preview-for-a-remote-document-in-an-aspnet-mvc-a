using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
//...


namespace DXWebApplication1.Controllers {
    public class HomeController : AsyncController {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";
            return View();
        }


        public ActionResult DocumentViewerPartial() {
            return PartialView("DocumentViewerPartial");
        }


        public ActionResult ExportDocumentViewer() {
            // Specify the report service URI and the name of the remote report to export.     
            MVCxDocumentViewerRemoteSourceSettings settings =
                new MVCxDocumentViewerRemoteSourceSettings();
            settings.ServerUri = @"http://localhost:52511/ReportService1.svc";
            settings.ReportTypeName = "WebApplication1.XtraReport1, WebApplication1";

            return DocumentViewerExtension.ExportTo(settings, HttpContext.Request);
        }
    }
}