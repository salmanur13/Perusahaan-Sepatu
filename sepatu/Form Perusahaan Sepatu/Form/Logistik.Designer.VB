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
        Me.GroupBox1.Location = New System.Drawing.Point(36, 105)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(473, 595)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rincian Pengiriman"
        '
        'cmbjenissepatu
        '
        Me.cmbjenissepatu.FormattingEnabled = True
        Me.cmbjenissepatu.Items.AddRange(New Object() {"Flat Shoes", "Sneakers", "Heels"})
        Me.cmbjenissepatu.Location = New System.Drawing.Point(236, 128)
        Me.cmbjenissepatu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbjenissepatu.Name = "cmbjenissepatu"
        Me.cmbjenissepatu.Size = New System.Drawing.Size(193, 33)
        Me.cmbjenissepatu.TabIndex = 7
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(236, 440)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(193, 31)
        Me.DateTimePicker2.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(236, 375)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(193, 31)
        Me.DateTimePicker1.TabIndex = 7
        '
        'txtongkir
        '
        Me.txtongkir.Location = New System.Drawing.Point(236, 305)
        Me.txtongkir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtongkir.Name = "txtongkir"
        Me.txtongkir.Size = New System.Drawing.Size(193, 31)
        Me.txtongkir.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 318)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Ongkir"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(236, 190)
        Me.txtjumlah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(193, 31)
        Me.txtjumlah.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 190)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Jumlah"
        '
        'cmbtujuan
        '
        Me.cmbtujuan.FormattingEnabled = True
        Me.cmbtujuan.Items.AddRange(New Object() {"DKI JAKARTA", "JAWA BARAT", "JAWA TENGAH", "JAWA TIMUR", "DIY", "KEPULAUAN RIAU", "SUMATRA"})
        Me.cmbtujuan.Location = New System.Drawing.Point(236, 255)
        Me.cmbtujuan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbtujuan.Name = "cmbtujuan"
        Me.cmbtujuan.Size = New System.Drawing.Size(193, 33)
        Me.cmbtujuan.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 440)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(230, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tanggal Sampai Pengiriman"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 255)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tujuan Pengiriman"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 375)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal Pengiriman"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jenis Sepatu"
        '
        'cmbpesanan
        '
        Me.cmbpesanan.FormattingEnabled = True
        Me.cmbpesanan.Location = New System.Drawing.Point(236, 59)
        Me.cmbpesanan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbpesanan.Name = "cmbpesanan"
        Me.cmbpesanan.Size = New System.Drawing.Size(193, 33)
        Me.cmbpesanan.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pesanan Atas Nama"
        '
        'btnlihatdata
        '
        Me.btnlihatdata.Location = New System.Drawing.Point(401, 710)
        Me.btnlihatdata.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnlihatdata.Name = "btnlihatdata"
        Me.btnlihatdata.Size = New System.Drawing.Size(107, 40)
        Me.btnlihatdata.TabIndex = 2
        Me.btnlihatdata.Text = "Lihat Data"
        Me.btnlihatdata.UseVisualStyleBackColor = True
        '
        'btnKirimBarang
        '
        Me.btnKirimBarang.Location = New System.Drawing.Point(816, 712)
        Me.btnKirimBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnKirimBarang.Name = "btnKirimBarang"
        Me.btnKirimBarang.Size = New System.Drawing.Size(223, 38)
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
        Me.ListView1.Location = New System.Drawing.Point(626, 105)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(740, 594)
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
        Me.btnMenuutama.Location = New System.Drawing.Point(1076, 712)
        Me.btnMenuutama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMenuutama.Name = "btnMenuutama"
        Me.btnMenuutama.Size = New System.Drawing.Size(269, 38)
        Me.btnMenuutama.TabIndex = 5
        Me.btnMenuutama.Text = "Menu Utama"
        Me.btnMenuutama.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(121, 710)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(107, 38)
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
        Me.Label8.Location = New System.Drawing.Point(573, 15)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(256, 68)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Logistik"
        '
        'Form_Logistik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1384, 822)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnMenuutama)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnKirimBarang)
        Me.Controls.Add(Me.btnlihatdata)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
