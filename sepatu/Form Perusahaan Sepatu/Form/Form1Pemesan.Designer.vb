<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1Pemesan
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnFormUtama = New System.Windows.Forms.Button()
        Me.BtnSelesai = New System.Windows.Forms.Button()
        Me.BtnInput = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtNo = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Merk = New System.Windows.Forms.Label()
        Me.ComboBoxMerk1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBoxWarna1 = New System.Windows.Forms.ComboBox()
        Me.M = New System.Windows.Forms.Label()
        Me.ComboBoxUk1 = New System.Windows.Forms.ComboBox()
        Me.txtJ1 = New System.Windows.Forms.TextBox()
        Me.txtV = New System.Windows.Forms.TextBox()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Flatshoes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 25)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Kode Pemesanan"
        '
        'BtnFormUtama
        '
        Me.BtnFormUtama.BackColor = System.Drawing.Color.Transparent
        Me.BtnFormUtama.Location = New System.Drawing.Point(11, 12)
        Me.BtnFormUtama.Name = "BtnFormUtama"
        Me.BtnFormUtama.Size = New System.Drawing.Size(101, 67)
        Me.BtnFormUtama.TabIndex = 155
        Me.BtnFormUtama.Text = "Form Utama"
        Me.BtnFormUtama.UseVisualStyleBackColor = False
        '
        'BtnSelesai
        '
        Me.BtnSelesai.Location = New System.Drawing.Point(854, 319)
        Me.BtnSelesai.Name = "BtnSelesai"
        Me.BtnSelesai.Size = New System.Drawing.Size(111, 33)
        Me.BtnSelesai.TabIndex = 153
        Me.BtnSelesai.Text = "Selesai"
        Me.BtnSelesai.UseVisualStyleBackColor = True
        '
        'BtnInput
        '
        Me.BtnInput.Location = New System.Drawing.Point(173, 206)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(111, 33)
        Me.BtnInput.TabIndex = 151
        Me.BtnInput.Text = "Input Data"
        Me.BtnInput.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.LightGray
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader4, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(34, 383)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1040, 211)
        Me.ListView1.TabIndex = 147
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kode"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Nama"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Tanggal Pemesanan"
        Me.ColumnHeader11.Width = 180
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "No HP"
        Me.ColumnHeader12.Width = 150
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Alamat"
        Me.ColumnHeader13.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item Pesanan"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jumlah"
        Me.ColumnHeader3.Width = 100
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(273, 173)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(194, 31)
        Me.DateTimePicker1.TabIndex = 146
        Me.DateTimePicker1.Value = New Date(2021, 4, 5, 0, 0, 0, 0)
        '
        'TxtNo
        '
        Me.TxtNo.Location = New System.Drawing.Point(273, 247)
        Me.TxtNo.Name = "TxtNo"
        Me.TxtNo.Size = New System.Drawing.Size(194, 31)
        Me.TxtNo.TabIndex = 145
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(273, 284)
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(194, 81)
        Me.TxtAlamat.TabIndex = 144
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(273, 132)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(194, 31)
        Me.TxtNama.TabIndex = 143
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(49, 253)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 25)
        Me.Label14.TabIndex = 142
        Me.Label14.Text = "No Telp./HP"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(49, 287)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 25)
        Me.Label15.TabIndex = 141
        Me.Label15.Text = "Alamat Pemesan"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(51, 173)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(167, 25)
        Me.Label16.TabIndex = 140
        Me.Label16.Text = "Tanggal Pemesanan"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(49, 132)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(134, 25)
        Me.Label17.TabIndex = 139
        Me.Label17.Text = "Nama Pemesan"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(291, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(446, 45)
        Me.Label18.TabIndex = 138
        Me.Label18.Text = "FORM PEMESANAN SEPATU"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Merk)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMerk1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ComboBoxWarna1)
        Me.GroupBox1.Controls.Add(Me.M)
        Me.GroupBox1.Controls.Add(Me.ComboBoxUk1)
        Me.GroupBox1.Controls.Add(Me.txtJ1)
        Me.GroupBox1.Controls.Add(Me.BtnInput)
        Me.GroupBox1.Location = New System.Drawing.Point(494, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 245)
        Me.GroupBox1.TabIndex = 167
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Pesanan"
        '
        'Merk
        '
        Me.Merk.AutoSize = True
        Me.Merk.Location = New System.Drawing.Point(13, 38)
        Me.Merk.Name = "Merk"
        Me.Merk.Size = New System.Drawing.Size(49, 25)
        Me.Merk.TabIndex = 174
        Me.Merk.Text = "Jenis"
        '
        'ComboBoxMerk1
        '
        Me.ComboBoxMerk1.FormattingEnabled = True
        Me.ComboBoxMerk1.Items.AddRange(New Object() {"Flat shoes", "Sneakers", "Heels"})
        Me.ComboBoxMerk1.Location = New System.Drawing.Point(154, 30)
        Me.ComboBoxMerk1.Name = "ComboBoxMerk1"
        Me.ComboBoxMerk1.Size = New System.Drawing.Size(130, 33)
        Me.ComboBoxMerk1.TabIndex = 170
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "Jumlah"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 25)
        Me.Label8.TabIndex = 166
        Me.Label8.Text = "Ukuran"
        '
        'ComboBoxWarna1
        '
        Me.ComboBoxWarna1.FormattingEnabled = True
        Me.ComboBoxWarna1.Items.AddRange(New Object() {"Putih", "Hitam", "Coklat"})
        Me.ComboBoxWarna1.Location = New System.Drawing.Point(154, 68)
        Me.ComboBoxWarna1.Name = "ComboBoxWarna1"
        Me.ComboBoxWarna1.Size = New System.Drawing.Size(130, 33)
        Me.ComboBoxWarna1.TabIndex = 158
        '
        'M
        '
        Me.M.AutoSize = True
        Me.M.Location = New System.Drawing.Point(13, 72)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(62, 25)
        Me.M.TabIndex = 165
        Me.M.Text = "Warna"
        '
        'ComboBoxUk1
        '
        Me.ComboBoxUk1.FormattingEnabled = True
        Me.ComboBoxUk1.Items.AddRange(New Object() {"36", "37", "38", "39", "40", "41", "42"})
        Me.ComboBoxUk1.Location = New System.Drawing.Point(154, 113)
        Me.ComboBoxUk1.Name = "ComboBoxUk1"
        Me.ComboBoxUk1.Size = New System.Drawing.Size(130, 33)
        Me.ComboBoxUk1.TabIndex = 161
        '
        'txtJ1
        '
        Me.txtJ1.Location = New System.Drawing.Point(154, 157)
        Me.txtJ1.Name = "txtJ1"
        Me.txtJ1.Size = New System.Drawing.Size(63, 31)
        Me.txtJ1.TabIndex = 162
        '
        'txtV
        '
        Me.txtV.Location = New System.Drawing.Point(156, 37)
        Me.txtV.Name = "txtV"
        Me.txtV.Size = New System.Drawing.Size(83, 31)
        Me.txtV.TabIndex = 168
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(273, 93)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(194, 31)
        Me.txtKode.TabIndex = 169
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(156, 112)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(83, 31)
        Me.txtN.TabIndex = 171
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 25)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "Sneakers"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(156, 75)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(83, 31)
        Me.txtA.TabIndex = 173
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 25)
        Me.Label5.TabIndex = 172
        Me.Label5.Text = "Heels"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtV)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtN)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtA)
        Me.GroupBox2.Location = New System.Drawing.Point(811, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 167)
        Me.GroupBox2.TabIndex = 175
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 25)
        Me.Label6.TabIndex = 178
        Me.Label6.Text = "Deadline"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(273, 210)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(194, 31)
        Me.DateTimePicker2.TabIndex = 179
        Me.DateTimePicker2.Value = New Date(2021, 4, 5, 0, 0, 0, 0)
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Deadline"
        Me.ColumnHeader4.Width = 100
        '
        'Form1Pemesan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Form_Perusahaan_Sepatu.My.Resources.Resources.download__1_
        Me.ClientSize = New System.Drawing.Size(1086, 595)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnFormUtama)
        Me.Controls.Add(Me.BtnSelesai)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtNo)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Name = "Form1Pemesan"
        Me.Text = "Form1Pemesanan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnFormUtama As Button
    Friend WithEvents BtnSelesai As Button
    Friend WithEvents BtnInput As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TxtNo As TextBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBoxMerk1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBoxWarna1 As ComboBox
    Friend WithEvents M As Label
    Friend WithEvents ComboBoxUk1 As ComboBox
    Friend WithEvents txtJ1 As TextBox
    Friend WithEvents txtV As TextBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Merk As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
