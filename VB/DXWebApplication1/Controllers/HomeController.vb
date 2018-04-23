Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
'...


Namespace DXWebApplication1.Controllers
    Public Class HomeController
        Inherits AsyncController

        Public Function Index() As ActionResult
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"
            Return View()
        End Function


        Public Function DocumentViewerPartial() As ActionResult
            Return PartialView("DocumentViewerPartial")
        End Function


        Public Function ExportDocumentViewer() As ActionResult
            ' Specify the report service URI and the name of the remote report to export.     
            Dim settings As New MVCxDocumentViewerRemoteSourceSettings()
            settings.ServerUri = "http://localhost:52511/ReportService1.svc"
            settings.ReportTypeName = "WebApplication1.XtraReport1, WebApplication1"

            Return DocumentViewerExtension.ExportTo(settings, HttpContext.Request)
        End Function
    End Class
End Namespace