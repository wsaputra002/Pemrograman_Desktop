Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbfakultas.Items.Add("FMIPA")
        cbfakultas.Items.Add("FKIP")
        cbfakultas.Items.Add("FEB")
    End Sub

    Private Sub txtnip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnip.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnprocess_Click(sender As Object, e As EventArgs) Handles btnprocess.Click
        Dim nip As Long
        If Not Long.TryParse(txtnip.Text.Trim(), nip) Then
            Exit Sub
        End If
        Dim nama As String = txtnama.Text.Trim()
        Dim fakultas As String = cbfakultas.Text.Trim()
        Dim jurusan As String = cbjurusan.Text.Trim()
        Dim tugas As Double = Double.Parse(txttugas.Text)
        Dim uts As Double = Double.Parse(txtuts.Text)
        Dim uas As Double = Double.Parse(txtuas.Text)

        Dim total As Double = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)

        Dim grade As String
        Select Case total
            Case Is >= 78
                grade = "A"
            Case Is >= 65
                grade = "B"
            Case Is >= 50
                grade = "C"
            Case Is >= 40
                grade = "D"
            Case Else
                grade = "E"
        End Select

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
                        "Jurusan : " & jurusan & vbCrLf &
                        "Nilai Akhir: " & total.ToString("F2") & vbCrLf &
                        "GRADE: " & grade,
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub cbfakultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbfakultas.SelectedIndexChanged
        Dim fakultas As String = cbfakultas.SelectedItem
        cbjurusan.Items.Clear()
        Select Case (fakultas)
            Case "FMIPA"
                cbjurusan.Items.Add("Sistem Informasi")
                cbjurusan.Items.Add("Manajemen Informatika")
                cbjurusan.Items.Add("Ilmu Komputer")
            Case "FKIP"
                cbjurusan.Items.Add("Pendidikan Teknologi Informasi")
                cbjurusan.Items.Add("Pendidikan Jasmani")
            Case "FEB"
                cbjurusan.Items.Add("Manajemen")
                cbjurusan.Items.Add("Perbankan")
                cbjurusan.Items.Add("Akuntansi")
        End Select
    End Sub
End Class
