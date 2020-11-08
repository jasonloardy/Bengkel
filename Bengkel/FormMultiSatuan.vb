Public Class FormMultiSatuan

    Public from As String
    Public editRow As Integer

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            If cbStnMulti.SelectedIndex = -1 Or tbIsiStn.Text = "" Or tbHrgJualU.Text = "" Or tbHrgJualL.Text = "" Or tbHrgJualP.Text = "" Then
                MsgBox("Masukkan Kolom Yang Masih Kosong!", 16, "Perhatian")
            Else
                If FormBarang.dgvSatuan.ColumnCount = 0 Then
                    FormBarang.isiColStn()
                    FormBarang.judulGridSatuan()
                End If
                With FormBarang.dgvSatuan
                    Dim baris As Integer
                    If from = "tambah" Then
                        baris = .Rows.Add()
                    Else
                        baris = editRow
                    End If
                    .Rows.Item(baris).Cells(0).Value = cbStnMulti.Text
                    .Rows.Item(baris).Cells(1).Value = tbIsiStn.Text
                    .Rows.Item(baris).Cells(2).Value = FormatCurrency(tbHrgJualU.Text)
                    .Rows.Item(baris).Cells(3).Value = FormatCurrency(tbHrgJualL.Text)
                    .Rows.Item(baris).Cells(4).Value = FormatCurrency(tbHrgJualP.Text)
                End With
                reset()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub reset()
        cbStnMulti.SelectedIndex = -1
        tbIsiStn.Clear()
        tbHrgJualU.Clear()
        tbHrgJualL.Clear()
        tbHrgJualP.Clear()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub tbHrgJualU_TextChanged(sender As Object, e As EventArgs) Handles tbHrgJualU.TextChanged
        formatRibuan(tbHrgJualU)
    End Sub

    Private Sub tbHrgJualL_TextChanged(sender As Object, e As EventArgs) Handles tbHrgJualL.TextChanged
        formatRibuan(tbHrgJualL)
    End Sub

    Private Sub tbHrgJualP_TextChanged(sender As Object, e As EventArgs) Handles tbHrgJualP.TextChanged
        formatRibuan(tbHrgJualP)
    End Sub

    Private Sub tbIsiStn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbIsiStn.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbHrgJualU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbHrgJualU.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbHrgJualL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbHrgJualL.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbHrgJualP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbHrgJualP.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cbStnMulti_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStnMulti.SelectedIndexChanged
        Dim stnDasar As String = "/ " & cbStnMulti.Text
        lblStnJualU.Text = stnDasar
        lblStnJualL.Text = stnDasar
        lblStnJualB.Text = stnDasar
    End Sub
End Class