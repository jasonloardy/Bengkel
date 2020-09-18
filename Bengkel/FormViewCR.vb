Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormViewCR
    Public cryReport As New ReportDocument

    Sub viewBuktiPembelian(ByVal kd_pembelian As String)
        Try
            Dim RepLocation = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\"))
            cryReport.Load(RepLocation & "CRBuktiPembelian.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("kd_pembelian", kd_pembelian)
            CRViewer.ReportSource = cryReport
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub printNotaPenjualan(ByVal kd_penjualan As String)
        Try
            Dim RepLocation = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\"))
            cryReport.Load(RepLocation & "CRNotaPenjualan.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("kd_penjualan", kd_penjualan)
            cryReport.PrintToPrinter(1, False, 0, 0)
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub FormViewCR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cryReport.Close()
    End Sub
End Class