Public Class Form2

    Private Sub btnprocess_Click(sender As Object, e As EventArgs) Handles btnprocess.Click
        Dim nip As Long
        If Not Long.TryParse(txtnip.Text.Trim(), nip) Then
            Exit Sub
        End If
        Dim nama As String = txtnama.Text.Trim()
        Dim fakultas As String = cbfakultas.Text.Trim()
        Dim jurusan As String = cbjurusan.Text.Trim()

        Dim jenisKelamin As String = ""
        If rbL.Checked Then
            jenisKelamin = "Laki-Laki"
        ElseIf rbP.Checked Then
            jenisKelamin = "Perempuan"
        Else
            MessageBox.Show("Silakan pilih jenis kelamin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        MessageBox.Show("Hai : " & nama & vbCrLf &
                        "NIP : " & nip & vbCrLf &
                        "Jenis Kelamin : " & jenisKelamin & vbCrLf &
                        "Fakultas : " & fakultas & vbCrLf &
                        "Jurusan : " & jurusan,
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub txtnip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnip.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
