@Html.DevExpress().DocumentViewer( _
    Sub(settings)
            ' The following settings are required for a Report Viewer. 
            settings.Name = "documentViewer1"
            ' Callback and export route values specify corresponding controllers and their actions. 
            ' These settings are required as well. 
            settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "DocumentViewerPartial"}
            settings.ExportRouteValues = New With {Key .Controller = "Home", Key .Action = "ExportDocumentViewer"}
            ' Specify the report service URI and the name of the report to display.
              
            settings.SetRemoteSourceSettings( _
                            Sub(s)
                                    s.ServerUri = "http://localhost:53296//ReportService1.svc"
                                    s.ReportTypeName = "WebApplication1.XtraReport1, WebApplication1"
                            End Sub)
    End Sub).GetHtml()
    
    
    
    
    
