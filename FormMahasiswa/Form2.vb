Public Class Form2
    Private Sub btnprocess_Click(sender As Object, e As EventArgs) Handles btnprocess.Click
        ' Validasi NIP harus angka
        Dim nip As Long
        If Not Long.TryParse(txtnip.Text.Trim(), nip) Then
            MessageBox.Show("NIP harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Ambil data dari form
        Dim nama As String = txtnama.Text.Trim()
        Dim fakultas As String = cbfakultas.Text.Trim()
        Dim jurusan As String = cbjurusan.Text.Trim()

        ' Validasi Jenis Kelamin
        Dim jenisKelamin As String = ""
        If rbL.Checked Then
            jenisKelamin = "Laki-Laki"
        ElseIf rbP.Checked Then
            jenisKelamin = "Perempuan"
        Else
            MessageBox.Show("Silakan pilih jenis kelamin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validasi dan Ambil Nilai Tugas, UTS, dan UAS
        Dim tugas, uts, uas As Double

        If Not Double.TryParse(txtTugas.Text.Trim(), tugas) Then
            MessageBox.Show("Nilai Tugas harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not Double.TryParse(txtUTS.Text.Trim(), uts) Then
            MessageBox.Show("Nilai UTS harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not Double.TryParse(txtUAS.Text.Trim(), uas) Then
            MessageBox.Show("Nilai UAS harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Hitung nilai akhir dengan bobot
        Dim nilaiAkhir As Double = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)

        ' Tentukan Grade berdasarkan nilai akhir
        Dim grade As String
        If nilaiAkhir >= 78 And nilaiAkhir <= 90 Then
            grade = "A"
        ElseIf nilaiAkhir >= 65 And nilaiAkhir < 78 Then
            grade = "B"
        ElseIf nilaiAkhir >= 50 And nilaiAkhir < 65 Then
            grade = "C"
        ElseIf nilaiAkhir >= 40 And nilaiAkhir < 50 Then
            grade = "D"
        Else
            grade = "E"
        End If

        ' Tampilkan hasil di MessageBox
        MessageBox.Show("Hai : " & nama & vbCrLf &
                        "NIP : " & nip & vbCrLf &
                        "Jenis Kelamin : " & jenisKelamin & vbCrLf &
                        "Fakultas : " & fakultas & vbCrLf &
                        "Jurusan : " & jurusan & vbCrLf &
                        "Nilai Akhir : " & nilaiAkhir.ToString("F2") & vbCrLf &
                        "GRADE : " & grade,
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        ' Tampilkan Grade di Label
        lblGrade.Text = "GRADE: " & grade
    End Sub
End Class
