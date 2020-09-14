Imports MySql.Data.MySqlClient

Public Class FormListPending
    Private Sub FormListPending_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiGrid()
    End Sub

    Sub isiGrid()
        Try
            Dim sql As String = "SELECT *
                                 FROM tb_pending tp
                                 JOIN tb_pelanggan tpl ON tp.kd_pelanggan = tpl.kd_pelanggan
                                 ORDER BY tp.tanggal DESC"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                dgvPending.DataSource = ds.Tables(0)
                judulGrid()
            Else
                dgvPending.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Sub judulGrid()
        With dgvPending
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            .AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = .Columns(0).DefaultCellStyle
            .Columns(0).HeaderText = "Kode Pending"
            .Columns(1).Visible = False
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).HeaderText = "Nama Pelanggan"
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(0).Width = 100
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            objAlternatingCellStyle.BackColor = Color.AliceBlue
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    Private Sub dgvPending_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPending.CellDoubleClick
        Try
            FormPenjualan.reset()
            With dgvPending
                Dim baris As Integer = .CurrentRow.Index
                FormPenjualan.tbKodePending.Text = .Item(0, baris).Value
                FormPenjualan.tbDiskonAll.Text = .Item(3, baris).Value.ToString.Replace(",", ".")
                FormPenjualan.tbKodePlg.Text = .Item(4, baris).Value
                FormPenjualan.tbNamaPlg.Text = .Item(5, baris).Value
                FormPenjualan.tbAlamat.Text = .Item(6, baris).Value
                FormPenjualan.tbNoTelepon.Text = .Item(7, baris).Value
                FormPenjualan.tbKatPlg.Text = .Item(8, baris).Value
            End With
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        isiGrid()
    End Sub
End Class