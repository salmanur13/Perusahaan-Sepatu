<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Logistik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Logistik))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbjenissepatu = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtongkir = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbtujuan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbpesanan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnlihatdata = New System.Windows.Forms.Button()
        Me.btnKirimBarang = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader()
        Me.btnMenuutama = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.cmbjenissepatu)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtongkir)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtjumlah)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbtujuan)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbpesanan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 357)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rincian Pengiriman"
        '
        'cmbjenissepatu
        '
        Me.cmbjenissepatu.FormattingEnabled = True
        Me.cmbjenissepatu.Items.AddRange(New Object() {"Flat Shoes", "Sneakers", "Heels"})
        Me.cmbjenissepatu.Location = New System.Drawing.Point(165, 77)
        Me.cmbjenissepatu.Name = "cmbjenissepatu"
        Me.cmbjenissepatu.Size = New System.Drawing.Size(136, 23)
        Me.cmbjenissepatu.TabIndex = 7
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(165, 264)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(136, 23)
        Me.DateTimePicker2.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(165, 225)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(136, 23)
        Me.DateTimePicker1.TabIndex = 7
        '
        'txtongkir
        '
        Me.txtongkir.Location = New System.Drawing.Point(165, 183)
        Me.txtongkir.Name = "txtongkir"
        Me.txtongkir.Size = New System.Drawing.Size(136, 23)
        Me.txtongkir.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Ongkir"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(165, 114)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(136, 23)
        Me.txtjumlah.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Jumlah"
        '
        'cmbtujuan
        '
        Me.cmbtujuan.FormattingEnabled = True
        Me.cmbtujuan.Items.AddRange(New Object() {"DKI JAKARTA", "JAWA BARAT", "JAWA TENGAH", "JAWA TIMUR", "DIY", "KEPULAUAN RIAU", "SUMATRA"})
        Me.cmbtujuan.Location = New System.Drawing.Point(165, 153)
        Me.cmbtujuan.Name = "cmbtujuan"
        Me.cmbtujuan.Size = New System.Drawing.Size(136, 23)
        Me.cmbtujuan.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tanggal Sampai Pengiriman"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tujuan Pengiriman"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal Pengiriman"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jenis Sepatu"
        '
        'cmbpesanan
        '
        Me.cmbpesanan.FormattingEnabled = True
        Me.cmbpesanan.Location = New System.Drawing.Point(165, 37)
        Me.cmbpesanan.Name = "cmbpesanan"
        Me.cmbpesanan.Size = New System.Drawing.Size(136, 23)
        Me.cmbpesanan.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pesanan Atas Nama"
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(190, 426)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 23)
        Me.btnHitung.TabIndex = 1
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnlihatdata
        '
        Me.btnlihatdata.Location = New System.Drawing.Point(281, 426)
        Me.btnlihatdata.Name = "btnlihatdata"
        Me.btnlihatdata.Size = New System.Drawing.Size(75, 24)
        Me.btnlihatdata.TabIndex = 2
        Me.btnlihatdata.Text = "Lihat Data"
        Me.btnlihatdata.UseVisualStyleBackColor = True
        '
        'btnKirimBarang
        '
        Me.btnKirimBarang.Location = New System.Drawing.Point(571, 427)
        Me.btnKirimBarang.Name = "btnKirimBarang"
        Me.btnKirimBarang.Size = New System.Drawing.Size(156, 23)
        Me.btnKirimBarang.TabIndex = 3
        Me.btnKirimBarang.Text = "Kirim Barang"
        Me.btnKirimBarang.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(438, 63)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(519, 358)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Pesanan"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Jenis Sepatu"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jumlah"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tujuan"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Ongkir"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tanggal Pengiriman"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tanggal Sampai"
        Me.ColumnHeader7.Width = 100
        '
        'btnMenuutama
        '
        Me.btnMenuutama.Location = New System.Drawing.Point(753, 427)
        Me.btnMenuutama.Name = "btnMenuutama"
        Me.btnMenuutama.Size = New System.Drawing.Size(188, 23)
        Me.btnMenuutama.TabIndex = 5
        Me.btnMenuutama.Text = "Menu Utama"
        Me.btnMenuutama.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(85, 426)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Image = Global.Form_Perusahaan_Sepatu.My.Resources.Resources.download__1_
        Me.Label8.Location = New System.Drawing.Point(401, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 46)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Logistik"
        '
        'Form_Logistik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(969, 493)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnMenuutama)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnKirimBarang)
        Me.Controls.Add(Me.btnlihatdata)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Logistik"
        Me.Text = "Logistik"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbtujuan As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbpesanan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtongkir As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnlihatdata As Button
    Friend WithEvents btnKirimBarang As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents btnMenuutama As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents cmbjenissepatu As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label8 As Label
End Class
