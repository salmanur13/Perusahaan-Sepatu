<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2BOM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2BOM))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpesanan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxJenis = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.hitungbom = New System.Windows.Forms.Button()
        Me.lbltalisnk = New System.Windows.Forms.Label()
        Me.lblossnk = New System.Windows.Forms.Label()
        Me.lblkainsnk = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtissnk = New System.Windows.Forms.TextBox()
        Me.lblissnk = New System.Windows.Forms.Label()
        Me.txtkainsnk = New System.Windows.Forms.TextBox()
        Me.txtossnk = New System.Windows.Forms.TextBox()
        Me.txttalisnk = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtishls = New System.Windows.Forms.TextBox()
        Me.lblishls = New System.Windows.Forms.Label()
        Me.txtreshls = New System.Windows.Forms.TextBox()
        Me.txtkayuhls = New System.Windows.Forms.TextBox()
        Me.txtkulithls = New System.Windows.Forms.TextBox()
        Me.lblkayuhls = New System.Windows.Forms.Label()
        Me.lblkulithls = New System.Windows.Forms.Label()
        Me.lblreshls = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtisfs = New System.Windows.Forms.TextBox()
        Me.lblisfs = New System.Windows.Forms.Label()
        Me.txtbenangfs = New System.Windows.Forms.TextBox()
        Me.txtosfs = New System.Windows.Forms.TextBox()
        Me.txtkainfs = New System.Windows.Forms.TextBox()
        Me.lblosfs = New System.Windows.Forms.Label()
        Me.lblkainfs = New System.Windows.Forms.Label()
        Me.lblbenangfs = New System.Windows.Forms.Label()
        Me.LVBOM = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(325, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bill Of Material"
        Me.Label1.UseMnemonic = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(270, 97)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(200, 31)
        Me.tanggal.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Kode BOM"
        '
        'txtpesanan
        '
        Me.txtpesanan.Location = New System.Drawing.Point(270, 205)
        Me.txtpesanan.Name = "txtpesanan"
        Me.txtpesanan.Size = New System.Drawing.Size(200, 31)
        Me.txtpesanan.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Jumlah Pesanan"
        '
        'txtbom
        '
        Me.txtbom.Location = New System.Drawing.Point(270, 133)
        Me.txtbom.Name = "txtbom"
        Me.txtbom.Size = New System.Drawing.Size(200, 31)
        Me.txtbom.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Jenis Sepatu"
        '
        'ComboBoxJenis
        '
        Me.ComboBoxJenis.FormattingEnabled = True
        Me.ComboBoxJenis.Items.AddRange(New Object() {"Sneakers", "Heels", "Flat Shoes"})
        Me.ComboBoxJenis.Location = New System.Drawing.Point(270, 167)
        Me.ComboBoxJenis.Name = "ComboBoxJenis"
        Me.ComboBoxJenis.Size = New System.Drawing.Size(200, 33)
        Me.ComboBoxJenis.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(529, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 47)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(529, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 47)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 67)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Menu Utama"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(636, 97)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(164, 61)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Form Gudang Bahan Baku"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'hitungbom
        '
        Me.hitungbom.Location = New System.Drawing.Point(529, 205)
        Me.hitungbom.Name = "hitungbom"
        Me.hitungbom.Size = New System.Drawing.Size(83, 47)
        Me.hitungbom.TabIndex = 18
        Me.hitungbom.Text = "Hitung"
        Me.hitungbom.UseVisualStyleBackColor = True
        '
        'lbltalisnk
        '
        Me.lbltalisnk.AutoSize = True
        Me.lbltalisnk.Location = New System.Drawing.Point(24, 31)
        Me.lbltalisnk.Name = "lbltalisnk"
        Me.lbltalisnk.Size = New System.Drawing.Size(36, 25)
        Me.lbltalisnk.TabIndex = 19
        Me.lbltalisnk.Text = "Tali"
        '
        'lblossnk
        '
        Me.lblossnk.AutoSize = True
        Me.lblossnk.Location = New System.Drawing.Point(24, 62)
        Me.lblossnk.Name = "lblossnk"
        Me.lblossnk.Size = New System.Drawing.Size(74, 25)
        Me.lblossnk.TabIndex = 20
        Me.lblossnk.Text = "Outsole"
        '
        'lblkainsnk
        '
        Me.lblkainsnk.AutoSize = True
        Me.lblkainsnk.Location = New System.Drawing.Point(24, 95)
        Me.lblkainsnk.Name = "lblkainsnk"
        Me.lblkainsnk.Size = New System.Drawing.Size(45, 25)
        Me.lblkainsnk.TabIndex = 21
        Me.lblkainsnk.Text = "Kain"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtissnk)
        Me.GroupBox1.Controls.Add(Me.lblissnk)
        Me.GroupBox1.Controls.Add(Me.txtkainsnk)
        Me.GroupBox1.Controls.Add(Me.txtossnk)
        Me.GroupBox1.Controls.Add(Me.txttalisnk)
        Me.GroupBox1.Controls.Add(Me.lblossnk)
        Me.GroupBox1.Controls.Add(Me.lbltalisnk)
        Me.GroupBox1.Controls.Add(Me.lblkainsnk)
        Me.GroupBox1.Location = New System.Drawing.Point(110, 267)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 154)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sneakers"
        '
        'txtissnk
        '
        Me.txtissnk.Location = New System.Drawing.Point(93, 121)
        Me.txtissnk.Name = "txtissnk"
        Me.txtissnk.Size = New System.Drawing.Size(70, 31)
        Me.txtissnk.TabIndex = 27
        '
        'lblissnk
        '
        Me.lblissnk.AutoSize = True
        Me.lblissnk.Location = New System.Drawing.Point(24, 124)
        Me.lblissnk.Name = "lblissnk"
        Me.lblissnk.Size = New System.Drawing.Size(59, 25)
        Me.lblissnk.TabIndex = 26
        Me.lblissnk.Text = "Insole"
        '
        'txtkainsnk
        '
        Me.txtkainsnk.Location = New System.Drawing.Point(93, 88)
        Me.txtkainsnk.Name = "txtkainsnk"
        Me.txtkainsnk.Size = New System.Drawing.Size(70, 31)
        Me.txtkainsnk.TabIndex = 24
        '
        'txtossnk
        '
        Me.txtossnk.Location = New System.Drawing.Point(93, 55)
        Me.txtossnk.Name = "txtossnk"
        Me.txtossnk.Size = New System.Drawing.Size(70, 31)
        Me.txtossnk.TabIndex = 23
        '
        'txttalisnk
        '
        Me.txttalisnk.Location = New System.Drawing.Point(93, 24)
        Me.txttalisnk.Name = "txttalisnk"
        Me.txttalisnk.Size = New System.Drawing.Size(70, 31)
        Me.txttalisnk.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtishls)
        Me.GroupBox2.Controls.Add(Me.lblishls)
        Me.GroupBox2.Controls.Add(Me.txtreshls)
        Me.GroupBox2.Controls.Add(Me.txtkayuhls)
        Me.GroupBox2.Controls.Add(Me.txtkulithls)
        Me.GroupBox2.Controls.Add(Me.lblkayuhls)
        Me.GroupBox2.Controls.Add(Me.lblkulithls)
        Me.GroupBox2.Controls.Add(Me.lblreshls)
        Me.GroupBox2.Location = New System.Drawing.Point(349, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 154)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Heels"
        '
        'txtishls
        '
        Me.txtishls.Location = New System.Drawing.Point(130, 119)
        Me.txtishls.Name = "txtishls"
        Me.txtishls.Size = New System.Drawing.Size(70, 31)
        Me.txtishls.TabIndex = 26
        '
        'lblishls
        '
        Me.lblishls.AutoSize = True
        Me.lblishls.Location = New System.Drawing.Point(24, 124)
        Me.lblishls.Name = "lblishls"
        Me.lblishls.Size = New System.Drawing.Size(59, 25)
        Me.lblishls.TabIndex = 25
        Me.lblishls.Text = "Insole"
        '
        'txtreshls
        '
        Me.txtreshls.Location = New System.Drawing.Point(130, 86)
        Me.txtreshls.Name = "txtreshls"
        Me.txtreshls.Size = New System.Drawing.Size(70, 31)
        Me.txtreshls.TabIndex = 24
        '
        'txtkayuhls
        '
        Me.txtkayuhls.Location = New System.Drawing.Point(130, 53)
        Me.txtkayuhls.Name = "txtkayuhls"
        Me.txtkayuhls.Size = New System.Drawing.Size(70, 31)
        Me.txtkayuhls.TabIndex = 23
        '
        'txtkulithls
        '
        Me.txtkulithls.Location = New System.Drawing.Point(130, 22)
        Me.txtkulithls.Name = "txtkulithls"
        Me.txtkulithls.Size = New System.Drawing.Size(70, 31)
        Me.txtkulithls.TabIndex = 22
        '
        'lblkayuhls
        '
        Me.lblkayuhls.AutoSize = True
        Me.lblkayuhls.Location = New System.Drawing.Point(24, 62)
        Me.lblkayuhls.Name = "lblkayuhls"
        Me.lblkayuhls.Size = New System.Drawing.Size(50, 25)
        Me.lblkayuhls.TabIndex = 20
        Me.lblkayuhls.Text = "Kayu"
        '
        'lblkulithls
        '
        Me.lblkulithls.AutoSize = True
        Me.lblkulithls.Location = New System.Drawing.Point(24, 31)
        Me.lblkulithls.Name = "lblkulithls"
        Me.lblkulithls.Size = New System.Drawing.Size(100, 25)
        Me.lblkulithls.TabIndex = 19
        Me.lblkulithls.Text = "Kulit Suede"
        '
        'lblreshls
        '
        Me.lblreshls.AutoSize = True
        Me.lblreshls.Location = New System.Drawing.Point(24, 95)
        Me.lblreshls.Name = "lblreshls"
        Me.lblreshls.Size = New System.Drawing.Size(83, 25)
        Me.lblreshls.TabIndex = 21
        Me.lblreshls.Text = "Resleting"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtisfs)
        Me.GroupBox3.Controls.Add(Me.lblisfs)
        Me.GroupBox3.Controls.Add(Me.txtbenangfs)
        Me.GroupBox3.Controls.Add(Me.txtosfs)
        Me.GroupBox3.Controls.Add(Me.txtkainfs)
        Me.GroupBox3.Controls.Add(Me.lblosfs)
        Me.GroupBox3.Controls.Add(Me.lblkainfs)
        Me.GroupBox3.Controls.Add(Me.lblbenangfs)
        Me.GroupBox3.Location = New System.Drawing.Point(629, 265)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(171, 154)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Flat Shoes"
        '
        'txtisfs
        '
        Me.txtisfs.Location = New System.Drawing.Point(93, 121)
        Me.txtisfs.Name = "txtisfs"
        Me.txtisfs.Size = New System.Drawing.Size(70, 31)
        Me.txtisfs.TabIndex = 27
        '
        'lblisfs
        '
        Me.lblisfs.AutoSize = True
        Me.lblisfs.Location = New System.Drawing.Point(24, 124)
        Me.lblisfs.Name = "lblisfs"
        Me.lblisfs.Size = New System.Drawing.Size(59, 25)
        Me.lblisfs.TabIndex = 26
        Me.lblisfs.Text = "Insole"
        '
        'txtbenangfs
        '
        Me.txtbenangfs.Location = New System.Drawing.Point(93, 88)
        Me.txtbenangfs.Name = "txtbenangfs"
        Me.txtbenangfs.Size = New System.Drawing.Size(70, 31)
        Me.txtbenangfs.TabIndex = 24
        '
        'txtosfs
        '
        Me.txtosfs.Location = New System.Drawing.Point(93, 55)
        Me.txtosfs.Name = "txtosfs"
        Me.txtosfs.Size = New System.Drawing.Size(70, 31)
        Me.txtosfs.TabIndex = 23
        '
        'txtkainfs
        '
        Me.txtkainfs.Location = New System.Drawing.Point(93, 24)
        Me.txtkainfs.Name = "txtkainfs"
        Me.txtkainfs.Size = New System.Drawing.Size(70, 31)
        Me.txtkainfs.TabIndex = 22
        '
        'lblosfs
        '
        Me.lblosfs.AutoSize = True
        Me.lblosfs.Location = New System.Drawing.Point(24, 62)
        Me.lblosfs.Name = "lblosfs"
        Me.lblosfs.Size = New System.Drawing.Size(74, 25)
        Me.lblosfs.TabIndex = 20
        Me.lblosfs.Text = "Outsole"
        '
        'lblkainfs
        '
        Me.lblkainfs.AutoSize = True
        Me.lblkainfs.Location = New System.Drawing.Point(24, 31)
        Me.lblkainfs.Name = "lblkainfs"
        Me.lblkainfs.Size = New System.Drawing.Size(45, 25)
        Me.lblkainfs.TabIndex = 19
        Me.lblkainfs.Text = "Kain"
        '
        'lblbenangfs
        '
        Me.lblbenangfs.AutoSize = True
        Me.lblbenangfs.Location = New System.Drawing.Point(24, 95)
        Me.lblbenangfs.Name = "lblbenangfs"
        Me.lblbenangfs.Size = New System.Drawing.Size(118, 25)
        Me.lblbenangfs.TabIndex = 21
        Me.lblbenangfs.Text = "Benang Nilon"
        '
        'LVBOM
        '
        Me.LVBOM.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LVBOM.HideSelection = False
        Me.LVBOM.Location = New System.Drawing.Point(110, 432)
        Me.LVBOM.Name = "LVBOM"
        Me.LVBOM.Size = New System.Drawing.Size(685, 146)
        Me.LVBOM.TabIndex = 25
        Me.LVBOM.UseCompatibleStateImageBehavior = False
        Me.LVBOM.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kode BOM"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tanggal"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 140
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jenis Sepatu"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 140
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Jumlah Pesanan"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 140
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Quantity Bahan"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 140
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(636, 190)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(164, 62)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Kembali ke Form Pemesanan"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form2BOM
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(907, 587)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.LVBOM)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.hitungbom)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxJenis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpesanan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2BOM"
        Me.Text = "Bill Of Material"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tanggal As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpesanan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbom As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxJenis As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents hitungbom As Button
    Friend WithEvents lbltalisnk As Label
    Friend WithEvents lblossnk As Label
    Friend WithEvents lblkainsnk As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtissnk As TextBox
    Friend WithEvents lblissnk As Label
    Friend WithEvents txtkainsnk As TextBox
    Friend WithEvents txtossnk As TextBox
    Friend WithEvents txttalisnk As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtishls As TextBox
    Friend WithEvents lblishls As Label
    Friend WithEvents txtreshls As TextBox
    Friend WithEvents txtkayuhls As TextBox
    Friend WithEvents txtkulithls As TextBox
    Friend WithEvents lblkayuhls As Label
    Friend WithEvents lblkulithls As Label
    Friend WithEvents lblreshls As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtisfs As TextBox
    Friend WithEvents lblisfs As Label
    Friend WithEvents txtbenangfs As TextBox
    Friend WithEvents txtosfs As TextBox
    Friend WithEvents txtkainfs As TextBox
    Friend WithEvents lblosfs As Label
    Friend WithEvents lblkainfs As Label
    Friend WithEvents lblbenangfs As Label
    Friend WithEvents LVBOM As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Button5 As Button
End Class
