Public Class Form1

    Private Sub btnprocess_Click(sender As Object, e As EventArgs) Handles btnprocess.Click
        Dim nip As Long
        If Not Long.TryParse(txtnip.Text, nip) Then
            MessageBox.Show("NIP harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim nama As String = txtnama.Text
        Dim fakultas As String = cbfakultas.Text
        Dim jurusan As String = cbjurusan.Text

        MessageBox.Show("Hai : " & nama & vbCrLf &
                        "NIP : " & nip & vbCrLf &
                        "Fakultas : " & fakultas & vbCrLf &
                        "Jurusan : " & jurusan,
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub
End Class
