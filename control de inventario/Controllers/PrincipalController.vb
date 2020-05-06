Imports System.Web.Mvc

Namespace Controllers
    Public Class PrincipalController
        Inherits Controller

        ' GET: Principal
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace