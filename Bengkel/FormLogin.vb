Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Sub clear()
        tbUsername.Clear()
        tbPassword.Clear()
        tbUsername.Focus()
    End Sub

    Sub login()
        Try
            If tbUsername.Text = "" Or tbPassword.Text = "" Then
                MsgBox("Username / Password masih kosong!", 16, "Perhatian")
            Else
                Dim sql As String = "SELECT * FROM tb_user
                                WHERE username = '" & tbUsername.Text.ToLower & "' AND PASSWORD = '" & tbPassword.Text & "'"
                Using cmd As New MySqlCommand(sql, conn)
                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            While dr.Read
                                If dr.Item("status") = "A" Then
                                    FormUtama.user = dr.Item("username").ToString.ToUpper
                                    FormUtama.level = dr.Item("level")
                                    If dr.Item("level") = "A" Then
                                        FormUtama.DataMasterToolStripMenuItem.Visible = True
                                        FormUtama.PembelianToolStripMenuItem.Visible = True
                                        FormUtama.DaftarTransaksiToolStripMenuItem.Visible = True
                                        FormUtama.LaporanToolStripMenuItem.Visible = True
                                    ElseIf dr.Item("level") = "K" Then
                                        FormUtama.DataMasterToolStripMenuItem.Visible = False
                                        FormUtama.PembelianToolStripMenuItem.Visible = False
                                        FormUtama.DaftarTransaksiToolStripMenuItem.Visible = False
                                        FormUtama.LaporanToolStripMenuItem.Visible = False
                                    End If
                                    clear()
                                    Me.Hide()
                                    FormUtama.Text = "Bengkel Cahaya Motor Bantaeng (User : " & FormUtama.user & ")"
                                    FormUtama.Show()
                                ElseIf dr.Item("status") = "N" Then
                                    MsgBox("User Non Aktif!", 16, "Perhatian")
                                End If
                            End While
                        Else
                            MsgBox("Username / Password salah!", 16, "Perhatian")
                        End If
                    End Using
                End Using
            End If
        Catch ex As Exception
            MsgBox("Error", 16, "Error")
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        login()
    End Sub

    Private Sub tbUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbUsername.KeyPress
        If (e.KeyChar = Chr(13)) Then
            login()
        End If
    End Sub

    Private Sub tbPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPassword.KeyPress
        If (e.KeyChar = Chr(13)) Then
            login()
        End If
    End Sub
End Class