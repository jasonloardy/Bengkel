Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormViewBarcode
    Public tmpKdBarang As String = ""
    Public cryReport As New ReportDocument

    Sub viewBarcode(ByVal kd_barang As String, ByVal baris1 As String, ByVal baris2 As String, ByVal baris3 As String, ByVal baris4 As String,
                    ByVal baris5 As String, ByVal baris6 As String, ByVal baris7 As String, ByVal baris8 As String)
        Try
            tmpKdBarang = kd_barang
            Dim RepLocation = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\"))
            cryReport.Load(RepLocation & "CRBarcodeNew.rpt")
            cryReport.Refresh()
            cryReport.SetParameterValue("kd_barang", kd_barang)
            cryReport.SetParameterValue("baris1", baris1)
            cryReport.SetParameterValue("baris2", baris2)
            cryReport.SetParameterValue("baris3", baris3)
            cryReport.SetParameterValue("baris4", baris4)
            cryReport.SetParameterValue("baris5", baris5)
            cryReport.SetParameterValue("baris6", baris6)
            cryReport.SetParameterValue("baris7", baris7)
            cryReport.SetParameterValue("baris8", baris8)

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
        Dim baris1 = ""
        Dim baris2 = ""
        Dim baris3 = ""
        Dim baris4 = ""
        Dim baris5 = ""
        Dim baris6 = ""
        Dim baris7 = ""
        Dim baris8 = ""
        'For Each chk In GroupBox1.Controls.OfType(Of CheckBox)()
        'If chk.Checked = True Then
        'urutan += "1"
        'Else
        'urutan += "0"
        'End If
        'Next
        For i As Integer = 1 To 5
            If CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True Then
                baris1 += "1"
            Else
                baris1 += "0"
            End If
        Next
        For i As Integer = 6 To 10
            If CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True Then
                baris2 += "1"
            Else
                baris2 += "0"
            End If
        Next
        For i As Integer = 11 To 15
            If CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True Then
                baris3 += "1"
            Else
                baris3 += "0"
            End If
        Next
        For i As Integer = 16 To 20
            If CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True Then
                baris4 += "1"
            Else
                baris4 += "0"
            End If
        Next
        For i As Integer = 21 To 25
            If CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True Then
                baris5 += "1"
            Else
                baris5 += "0"
            End If
        Next
        For i As Integer = 26 To 30
            If CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True Then
                baris6 += "1"
            Else
                baris6 += "0"
            End If
        Next
        For i As Integer = 31 To 35
            If CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True Then
                baris7 += "1"
            Else
                baris7 += "0"
            End If
        Next
        For i As Integer = 36 To 40
            If CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True Then
                baris8 += "1"
            Else
                baris8 += "0"
            End If
        Next
        viewBarcode(tmpKdBarang, baris1, baris2, baris3, baris4, baris5, baris6, baris7, baris8)
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            For i As Integer = 1 To 5
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True
            Next
        Else
            For i As Integer = 1 To 5
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = False
            Next
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            For i As Integer = 6 To 10
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True
            Next
        Else
            For i As Integer = 6 To 10
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = False
            Next
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            For i As Integer = 11 To 15
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True
            Next
        Else
            For i As Integer = 11 To 15
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = False
            Next
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            For i As Integer = 16 To 20
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True
            Next
        Else
            For i As Integer = 16 To 20
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = False
            Next
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            For i As Integer = 21 To 25
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True
            Next
        Else
            For i As Integer = 21 To 25
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = False
            Next
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            For i As Integer = 26 To 30
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True
            Next
        Else
            For i As Integer = 26 To 30
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = False
            Next
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            For i As Integer = 31 To 35
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True
            Next
        Else
            For i As Integer = 31 To 35
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = False
            Next
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            For i As Integer = 36 To 40
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = True
            Next
        Else
            For i As Integer = 36 To 40
                CType(Me.Controls("chk" + i.ToString()), CheckBox).Checked = False
            Next
        End If
    End Sub
End Class