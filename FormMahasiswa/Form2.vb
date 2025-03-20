Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbfakultas.Items.Add("FMIPA")
        cbfakultas.Items.Add("FKIP")
        cbfakultas.Items.Add("FEB")
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

    Private Sub txtnip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnip.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub UpdateGrade()
        Dim tugas, uts, uas As Double
        If Double.TryParse(txttugas.Text, tugas) AndAlso Double.TryParse(txtuts.Text, uts) AndAlso Double.TryParse(txtuas.Text, uas) Then
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

            lblgrade.Text = " " & grade
        Else
            lblgrade.Text = " ... "
        End If
    End Sub

    Private Sub txttugas_TextChanged(sender As Object, e As EventArgs) Handles txttugas.TextChanged
        UpdateGrade()
    End Sub

    Private Sub txtuts_TextChanged(sender As Object, e As EventArgs) Handles txtuts.TextChanged
        UpdateGrade()
    End Sub

    Private Sub txtuas_TextChanged(sender As Object, e As EventArgs) Handles txtuas.TextChanged
        UpdateGrade()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtnip.Clear()
        txtnama.Clear()
        cbfakultas.SelectedIndex = -1
        cbjurusan.SelectedIndex = -1
        txttugas.Clear()
        txtuts.Clear()
        txtuas.Clear()
        lblgrade.Text = " -GRADE- "
        txtnip.Enabled = True
        txtnip.Focus()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtnip.Text = "" Or txtnama.Text = "" Or cbjurusan.Text = "" Then
            MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim rowIndex As Integer = -1
        For Each row As DataGridViewRow In dgvdata.Rows
            If row.Cells("dgnip").Value IsNot Nothing AndAlso row.Cells("dgnip").Value.ToString() = txtnip.Text Then
                rowIndex = row.Index
                Exit For
            End If
        Next

        If rowIndex = -1 Then
            dgvdata.Rows.Add(txtnip.Text, txtnama.Text, If(rbL.Checked, "Laki-Laki", "Perempuan"), cbjurusan.Text, "Mata Kuliah", lblgrade.Text)
        Else
            dgvdata.Rows(rowIndex).SetValues(txtnip.Text, txtnama.Text, If(rbL.Checked, "Laki-Laki", "Perempuan"), cbjurusan.Text, "Mata Kuliah", lblgrade.Text)
        End If

        btnnew.PerformClick()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If dgvdata.SelectedRows.Count > 0 Then
            Dim confirm As DialogResult = MessageBox.Show("Apakah yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.Yes Then
                dgvdata.Rows.RemoveAt(dgvdata.SelectedRows(0).Index)
                btnnew.PerformClick()
            End If
        Else
            MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub dgvdata_SelectionChanged(sender As Object, e As EventArgs) Handles dgvdata.SelectionChanged
        If dgvdata.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvdata.SelectedRows(0)
            txtnip.Text = row.Cells("dgnip").Value.ToString()
            txtnama.Text = row.Cells("dgnama").Value.ToString()
            If row.Cells("dgjeniskelamin").Value.ToString() = "Laki-Laki" Then
                rbL.Checked = True
            Else
                rbP.Checked = True
            End If
            cbjurusan.Text = row.Cells("dgjurusan").Value.ToString()
            lblgrade.Text = row.Cells("dggrade").Value.ToString()
            txtnip.Enabled = False
        End If
    End Sub

End Class