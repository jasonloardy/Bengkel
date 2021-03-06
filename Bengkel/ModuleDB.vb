﻿Imports System.IO
Imports MySql.Data.MySqlClient

Module ModuleDB
    Public conn As New MySqlConnection
    Public trans As MySqlTransaction

    Sub koneksi()
        Try
            If conn.State = ConnectionState.Closed Then
                Dim line As String
                Using reader As StreamReader = New StreamReader("config.ini")
                    line = reader.ReadLine
                End Using
                conn = New MySqlConnection(line)
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Public Sub formatRibuan(ByVal Text As TextBox)
        Try
            If Len(Text.Text) > 0 Then
                Text.Text = FormatNumber(CDbl(Text.Text), 0)
                Dim x As Integer = Text.SelectionStart.ToString
                If x = 0 Then
                    Text.SelectionStart = Len(Text.Text)
                    Text.SelectionLength = 0
                Else
                    Text.SelectionStart = x
                    Text.SelectionLength = 0
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Public Sub formatRibuanMask(ByVal text As MaskedTextBox)
        Try
            If Len(text.Text) > 0 Then
                text.Text = FormatNumber(CDbl(text.Text), 0)
                Dim x As Integer = text.SelectionStart.ToString
                If x = 0 Then
                    text.SelectionStart = Len(text.Text)
                    text.SelectionLength = 0
                Else
                    text.SelectionStart = x
                    text.SelectionLength = 0
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, 16, "Error")
        End Try
    End Sub

    Function query(ByVal sql As String)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = sql
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryUser(ByVal query As String, ByVal username As String, ByVal password As String,
                       ByVal nama As String, ByVal level As String, ByVal status As String)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@level", level)
                cmd.Parameters.AddWithValue("@status", status)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function querySupplier(ByVal query As String, ByVal kode As String, ByVal nama As String,
                            ByVal alamat As String, ByVal telepon As String)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@alamat", alamat)
                cmd.Parameters.AddWithValue("@telepon", telepon)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryPelanggan(ByVal query As String, ByVal kode As String, ByVal nama As String,
                            ByVal alamat As String, ByVal telepon As String, ByVal kategori As String)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@alamat", alamat)
                cmd.Parameters.AddWithValue("@telepon", telepon)
                cmd.Parameters.AddWithValue("@kategori", kategori)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function querySatuan(ByVal query As String, ByVal kode As String, ByVal nama As String)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryBarang(ByVal query As String, ByVal kode As String, ByVal nama As String,
                         ByVal harga_beli As Integer, ByVal harga_jual_u As Integer, ByVal harga_jual_l As Integer,
                         ByVal harga_jual_p As Integer, ByVal stok As Integer, ByVal status As String,
                         ByVal kd_satuan As String, ByVal isi As Integer, ByVal jenis_satuan As String)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@harga_beli", harga_beli)
                cmd.Parameters.AddWithValue("@harga_jual_u", harga_jual_u)
                cmd.Parameters.AddWithValue("@harga_jual_l", harga_jual_l)
                cmd.Parameters.AddWithValue("@harga_jual_p", harga_jual_p)
                cmd.Parameters.AddWithValue("@stok", stok)
                cmd.Parameters.AddWithValue("@status", status)
                cmd.Parameters.AddWithValue("@kd_satuan", kd_satuan)
                cmd.Parameters.AddWithValue("@isi", isi)
                cmd.Parameters.AddWithValue("@jenis_satuan", jenis_satuan)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryBarangStnMulti(ByVal query As String, ByVal kode As String, ByVal kd_satuan As String,
                         ByVal isi As Integer, ByVal jenis_satuan As String, ByVal harga_jual_u As Integer,
                         ByVal harga_jual_l As Integer, ByVal harga_jual_p As Integer)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@kd_satuan", kd_satuan)
                cmd.Parameters.AddWithValue("@isi", isi)
                cmd.Parameters.AddWithValue("@jenis_satuan", jenis_satuan)
                cmd.Parameters.AddWithValue("@harga_jual_u", harga_jual_u)
                cmd.Parameters.AddWithValue("@harga_jual_l", harga_jual_l)
                cmd.Parameters.AddWithValue("@harga_jual_p", harga_jual_p)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryBarangHistory(ByVal query As String, ByVal kode As String, ByVal kd_transaksi As String, ByVal tanggal As String,
                                ByVal harga_beli As Integer, ByVal stok_masuk As Integer, ByVal stok_keluar As Integer)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@kd_transaksi", kd_transaksi)
                cmd.Parameters.AddWithValue("@tanggal", tanggal)
                cmd.Parameters.AddWithValue("@harga_beli", harga_beli)
                cmd.Parameters.AddWithValue("@stok_masuk", stok_masuk)
                cmd.Parameters.AddWithValue("@stok_keluar", stok_keluar)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryPembelian(ByVal query As String, ByVal kd_pembelian As String, ByVal kd_supplier As String, ByVal kd_bukti As String,
                             ByVal sales As String, ByVal diskon As Decimal, ByVal tanggal_jt As String, ByVal tunai As Integer, ByVal sisa As Integer)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kd_pembelian", kd_pembelian)
                cmd.Parameters.AddWithValue("@kd_supplier", kd_supplier)
                cmd.Parameters.AddWithValue("@kd_bukti", kd_bukti)
                cmd.Parameters.AddWithValue("@sales", sales)
                cmd.Parameters.AddWithValue("@diskon", diskon)
                cmd.Parameters.AddWithValue("@tanggal_jt", tanggal_jt)
                cmd.Parameters.AddWithValue("@tunai", tunai)
                cmd.Parameters.AddWithValue("@sisa", sisa)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryPembelianDetail(ByVal query As String, ByVal kd_pembelian As String, ByVal kd_barang As String,
                                  ByVal kd_satuan As String, ByVal qty As Integer, ByVal harga_beli As Integer,
                                  ByVal diskon As Decimal, ByVal unit As Integer)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kd_pembelian", kd_pembelian)
                cmd.Parameters.AddWithValue("@kd_barang", kd_barang)
                cmd.Parameters.AddWithValue("@kd_satuan", kd_satuan)
                cmd.Parameters.AddWithValue("@qty", qty)
                cmd.Parameters.AddWithValue("@harga_beli", harga_beli)
                cmd.Parameters.AddWithValue("@diskon", diskon)
                cmd.Parameters.AddWithValue("@unit", unit)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryPembayaranHutang(ByVal query As String, ByVal kd_pembayaran_hutang As String)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kd_pembayaran_hutang", kd_pembayaran_hutang)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryPembayaranHutangDetail(ByVal query As String, ByVal kd_pembayaran_hutang As String,
                                         ByVal kd_pembelian As String, ByVal bayar As Integer)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kd_pembayaran_hutang", kd_pembayaran_hutang)
                cmd.Parameters.AddWithValue("@kd_pembelian", kd_pembelian)
                cmd.Parameters.AddWithValue("@bayar", bayar)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryPending(ByVal query As String, ByVal kd_pending As String, ByVal kd_pelanggan As String, ByVal diskon As Decimal)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kd_pending", kd_pending)
                cmd.Parameters.AddWithValue("@kd_pelanggan", kd_pelanggan)
                cmd.Parameters.AddWithValue("@diskon", diskon)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryPendingDetail(ByVal query As String, ByVal kd_pending As String, ByVal kd_barang As String, ByVal nama_barang As String,
                                  ByVal kd_satuan As String, ByVal qty As Integer, ByVal harga_jual As Integer,
                                  ByVal diskon As Decimal, ByVal unit As Integer, ByVal harga_beli As Integer)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kd_pending", kd_pending)
                cmd.Parameters.AddWithValue("@kd_barang", kd_barang)
                cmd.Parameters.AddWithValue("@nama_barang", nama_barang)
                cmd.Parameters.AddWithValue("@kd_satuan", kd_satuan)
                cmd.Parameters.AddWithValue("@qty", qty)
                cmd.Parameters.AddWithValue("@harga_jual", harga_jual)
                cmd.Parameters.AddWithValue("@diskon", diskon)
                cmd.Parameters.AddWithValue("@unit", unit)
                cmd.Parameters.AddWithValue("@harga_beli", harga_beli)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryPenjualan(ByVal query As String, ByVal kd_penjualan As String, ByVal kd_pelanggan As String, ByVal diskon As Decimal,
                            ByVal bayar As Integer, ByVal sisa As Integer)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kd_penjualan", kd_penjualan)
                cmd.Parameters.AddWithValue("@kd_pelanggan", kd_pelanggan)
                cmd.Parameters.AddWithValue("@diskon", diskon)
                cmd.Parameters.AddWithValue("@bayar", bayar)
                cmd.Parameters.AddWithValue("@sisa", sisa)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryPenjualanDetail(ByVal query As String, ByVal kd_penjualan As String, ByVal kd_barang As String, ByVal nama_barang As String,
                                  ByVal kd_satuan As String, ByVal qty As Integer, ByVal harga_jual As Integer,
                                  ByVal diskon As Decimal, ByVal unit As Integer, ByVal harga_beli As Integer)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kd_penjualan", kd_penjualan)
                cmd.Parameters.AddWithValue("@kd_barang", kd_barang)
                cmd.Parameters.AddWithValue("@nama_barang", nama_barang)
                cmd.Parameters.AddWithValue("@kd_satuan", kd_satuan)
                cmd.Parameters.AddWithValue("@qty", qty)
                cmd.Parameters.AddWithValue("@harga_jual", harga_jual)
                cmd.Parameters.AddWithValue("@diskon", diskon)
                cmd.Parameters.AddWithValue("@unit", unit)
                cmd.Parameters.AddWithValue("@harga_beli", harga_beli)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryPembayaranPiutang(ByVal query As String, ByVal kd_pembayaran_piutang As String)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kd_pembayaran_piutang", kd_pembayaran_piutang)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryPembayaranPiutangDetail(ByVal query As String, ByVal kd_pembayaran_piutang As String,
                                         ByVal kd_penjualan As String, ByVal bayar As Integer)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kd_pembayaran_piutang", kd_pembayaran_piutang)
                cmd.Parameters.AddWithValue("@kd_penjualan", kd_penjualan)
                cmd.Parameters.AddWithValue("@bayar", bayar)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

    Function queryCb(ByVal query As String)
        Try
            Dim dt As New DataTable()
            Using da = New MySqlDataAdapter(query, conn)
                da.Fill(dt)
            End Using
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

End Module
