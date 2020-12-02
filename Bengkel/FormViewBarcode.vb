Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormViewBarcode
    Public tmpKdBarang As String = ""
    Public cryReport As New ReportDocument

    Sub viewBarcode(ByVal kd_barang As String, ByVal urutan As String)
        Try
            tmpKdBarang = kd_barang
            Dim RepLocation = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\"))
            cryReport.Load(RepLocation & "CRBarcodeNew.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("kd_barang", kd_barang)
            cryReport.SetParameterValue("urutan", urutan)

            CRViewer.ReportSource = cryReport

            Dim doctoprint As New System.Drawing.Printing.PrintDocument()
            'doctoprint.PrinterSettings.PrinterName = "EPSON L3110 Series"
            For i = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
                Dim rawKind As Integer
                If doctoprint.PrinterSettings.PaperSizes(i).PaperName = "Label No. 108" Then
                    rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(i).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(i)))
                    cryReport.PrintOptions.PaperSize = rawKind
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        cryReport.PrintToPrinter(1, False, 0, 0)
    End Sub

    Private Sub FormViewBarcode_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cryReport.Close()
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            For Each chk In GroupBox1.Controls.OfType(Of CheckBox)()
                chk.Checked = True
            Next
        Else
            For Each chk In GroupBox1.Controls.OfType(Of CheckBox)()
                chk.Checked = False
            Next
        End If

    End Sub

    Private Sub FormViewBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox9.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim urutan As String = ""
        For Each chk In GroupBox1.Controls.OfType(Of CheckBox)()
            If chk.Checked = True Then
                urutan += "1"
            Else
                urutan += "0"
            End If
        Next
        viewBarcode(tmpKdBarang, urutan)
    End Sub
End Class