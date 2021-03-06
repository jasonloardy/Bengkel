﻿Public Class FormInputBox

    Public dgv As DataGridView
    Public columnSisa As Integer
    Public columnKredit As Integer
    Public columnValue As Integer
    Public row As Integer
    Public from As String

    Private Sub FormInputBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbValue.Select()
    End Sub

    Sub bayarHutang()
        Try
            Dim sisa As Integer = dgv.Item(columnSisa, row).Value
            Dim bayar As Integer = tbValue.Text
            If bayar >= sisa Then
                dgv.Item(columnValue, row).Value = FormatCurrency(sisa)
            Else
                dgv.Item(columnValue, row).Value = FormatCurrency(bayar)
            End If
            dgv.Item(columnKredit, row).Value = dgv.Item(columnSisa, row).Value - dgv.Item(columnValue, row).Value
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub updateTrx()
        Try
            dgv.Item(columnValue, row).Value = Val(tbValue.Text)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub updateNamaBarang()
        Try
            dgv.Item(columnValue, row).Value = tbValue.Text
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub updateHargaJual()
        Try
            dgv.Item(columnValue, row).Value = tbValue.Text
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Try
            If from = "hutang" Then
                bayarHutang()
            ElseIf from = "trx" Then
                updateTrx()
            ElseIf from = "namaBarang" Then
                updateNamaBarang()
            ElseIf from = "hargaJual" Then
                updateHargaJual
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub tbValue_TextChanged(sender As Object, e As EventArgs) Handles tbValue.TextChanged
        formatRibuanMask(tbValue)
    End Sub

    Private Sub tbValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbValue.KeyPress
        If Not from = "namaBarang" Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class