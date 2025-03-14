<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnprocess = New System.Windows.Forms.Button()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.rbL = New System.Windows.Forms.RadioButton()
        Me.rbP = New System.Windows.Forms.RadioButton()
        Me.cbfakultas = New System.Windows.Forms.ComboBox()
        Me.cbjurusan = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTugas = New System.Windows.Forms.TextBox()
        Me.TxtUTS = New System.Windows.Forms.TextBox()
        Me.TxtUAS = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblgrade = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fakultas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jurusan"
        '
        'btnprocess
        '
        Me.btnprocess.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprocess.Location = New System.Drawing.Point(38, 356)
        Me.btnprocess.Name = "btnprocess"
        Me.btnprocess.Size = New System.Drawing.Size(75, 23)
        Me.btnprocess.TabIndex = 5
        Me.btnprocess.Text = "Process"
        Me.btnprocess.UseVisualStyleBackColor = True
        '
        'txtnip
        '
        Me.txtnip.Location = New System.Drawing.Point(141, 40)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(170, 22)
        Me.txtnip.TabIndex = 6
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(141, 94)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(265, 22)
        Me.txtnama.TabIndex = 7
        '
        'rbL
        '
        Me.rbL.AutoSize = True
        Me.rbL.Location = New System.Drawing.Point(141, 147)
        Me.rbL.Name = "rbL"
        Me.rbL.Size = New System.Drawing.Size(86, 21)
        Me.rbL.TabIndex = 8
        Me.rbL.TabStop = True
        Me.rbL.Text = "Laki-Laki"
        Me.rbL.UseVisualStyleBackColor = True
        '
        'rbP
        '
        Me.rbP.AutoSize = True
        Me.rbP.Location = New System.Drawing.Point(260, 147)
        Me.rbP.Name = "rbP"
        Me.rbP.Size = New System.Drawing.Size(102, 21)
        Me.rbP.TabIndex = 9
        Me.rbP.TabStop = True
        Me.rbP.Text = "Perempuan"
        Me.rbP.UseVisualStyleBackColor = True
        '
        'cbfakultas
        '
        Me.cbfakultas.FormattingEnabled = True
        Me.cbfakultas.Items.AddRange(New Object() {"FMIPA", "FKIP", "FEB"})
        Me.cbfakultas.Location = New System.Drawing.Point(141, 198)
        Me.cbfakultas.Name = "cbfakultas"
        Me.cbfakultas.Size = New System.Drawing.Size(365, 24)
        Me.cbfakultas.TabIndex = 10
        '
        'cbjurusan
        '
        Me.cbjurusan.FormattingEnabled = True
        Me.cbjurusan.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.cbjurusan.Location = New System.Drawing.Point(141, 256)
        Me.cbjurusan.Name = "cbjurusan"
        Me.cbjurusan.Size = New System.Drawing.Size(365, 24)
        Me.cbjurusan.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nilai"
        '
        'TxtTugas
        '
        Me.TxtTugas.Location = New System.Drawing.Point(185, 302)
        Me.TxtTugas.Name = "TxtTugas"
        Me.TxtTugas.Size = New System.Drawing.Size(62, 22)
        Me.TxtTugas.TabIndex = 13
        '
        'TxtUTS
        '
        Me.TxtUTS.Location = New System.Drawing.Point(316, 302)
        Me.TxtUTS.Name = "TxtUTS"
        Me.TxtUTS.Size = New System.Drawing.Size(62, 22)
        Me.TxtUTS.TabIndex = 14
        '
        'TxtUAS
        '
        Me.TxtUAS.Location = New System.Drawing.Point(444, 302)
        Me.TxtUAS.Name = "TxtUAS"
        Me.TxtUAS.Size = New System.Drawing.Size(62, 22)
        Me.TxtUAS.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(138, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Tugas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(274, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "UTS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(402, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "UAS"
        '
        'lblgrade
        '
        Me.lblgrade.AutoSize = True
        Me.lblgrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrade.Location = New System.Drawing.Point(533, 307)
        Me.lblgrade.Name = "lblgrade"
        Me.lblgrade.Size = New System.Drawing.Size(74, 17)
        Me.lblgrade.TabIndex = 19
        Me.lblgrade.Text = "-GRADE-"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 407)
        Me.Controls.Add(Me.lblgrade)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtUAS)
        Me.Controls.Add(Me.TxtUTS)
        Me.Controls.Add(Me.TxtTugas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbjurusan)
        Me.Controls.Add(Me.cbfakultas)
        Me.Controls.Add(Me.rbP)
        Me.Controls.Add(Me.rbL)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnip)
        Me.Controls.Add(Me.btnprocess)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnprocess As System.Windows.Forms.Button
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents rbL As System.Windows.Forms.RadioButton
    Friend WithEvents rbP As System.Windows.Forms.RadioButton
    Friend WithEvents cbfakultas As System.Windows.Forms.ComboBox
    Friend WithEvents cbjurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTugas As System.Windows.Forms.TextBox
    Friend WithEvents TxtUTS As System.Windows.Forms.TextBox
    Friend WithEvents TxtUAS As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblgrade As System.Windows.Forms.Label
End Class
