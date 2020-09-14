Public Class FormInputBox

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

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Try
            If from = "hutang" Then
                bayarHutang()
            ElseIf from = "trx" Then
                updateTrx()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub tbValue_TextChanged(sender As Object, e As EventArgs) Handles tbValue.TextChanged
        formatRibuanMask(tbValue)
    End Sub
End Class