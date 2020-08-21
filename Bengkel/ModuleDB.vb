Imports System.IO
Imports MySql.Data.MySqlClient

Module ModuleDB
    Public conn As MySqlConnection
    Public trans As MySqlTransaction

    Function koneksi()
        Try
            Dim line As String
            Using reader As StreamReader = New StreamReader("config.ini")
                line = reader.ReadLine
            End Using
            conn = New MySqlConnection(line)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            Else
                conn.Close()
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Error")
            Return False
        End Try
    End Function

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
                         ByVal harga_jual_b As Integer, ByVal stok As Integer, ByVal status As String,
                         ByVal kd_satuan As String, ByVal isi As Integer, ByVal jenis_satuan As String)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@harga_beli", harga_beli)
                cmd.Parameters.AddWithValue("@harga_jual_u", harga_jual_u)
                cmd.Parameters.AddWithValue("@harga_jual_l", harga_jual_l)
                cmd.Parameters.AddWithValue("@harga_jual_b", harga_jual_b)
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
                         ByVal isi As Integer, ByVal jenis_satuan As String)
        Try
            Using cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@kode", kode)
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

    Function queryCb(ByVal query As String)
        Dim dt As New DataTable()
        Using da = New MySqlDataAdapter(query, conn)
            da.Fill(dt)
        End Using
        Return dt
    End Function

End Module
