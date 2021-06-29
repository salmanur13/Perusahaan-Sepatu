<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProduction))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Date1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxJenis = New System.Windows.Forms.ComboBox()
        Me.btngudangbahanbaku = New System.Windows.Forms.Button()
        Me.btngudangbahanjadi = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.btnlihatdata = New System.Windows.Forms.Button()
        Me.Talisn = New System.Windows.Forms.TextBox()
        Me.Insolesn = New System.Windows.Forms.TextBox()
        Me.Outsolesn = New System.Windows.Forms.TextBox()
        Me.Kainsn = New System.Windows.Forms.TextBox()
        Me.Benangfs = New System.Windows.Forms.TextBox()
        Me.Outsolefs = New System.Windows.Forms.TextBox()
        Me.Insolefs = New System.Windows.Forms.TextBox()
        Me.Kainfs = New System.Windows.Forms.TextBox()
        Me.Resletinghl = New System.Windows.Forms.TextBox()
        Me.Kayuhl = New System.Windows.Forms.TextBox()
        Me.Insolehl = New System.Windows.Forms.TextBox()
        Me.KulitSuedehl = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LvDisplay = New System.Windows.Forms.ListView()
        Me.Tanggal = New System.Windows.Forms.ColumnHeader()
        Me.Jenis = New System.Windows.Forms.ColumnHeader()
        Me.Jumlah = New System.Windows.Forms.ColumnHeader()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(437, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRODUCTION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 179)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Produksi"
        '
        'Date1
        '
        Me.Date1.Location = New System.Drawing.Point(288, 179)
        Me.Date1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Date1.Name = "Date1"
        Me.Date1.Size = New System.Drawing.Size(212, 31)
        Me.Date1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 244)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jenis Produk"
        '
        'cbxJenis
        '
        Me.cbxJenis.FormattingEnabled = True
        Me.cbxJenis.Items.AddRange(New Object() {"Sneakers", "Flat Shoes", "Heels"})
        Me.cbxJenis.Location = New System.Drawing.Point(288, 244)
        Me.cbxJenis.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cbxJenis.Name = "cbxJenis"
        Me.cbxJenis.Size = New System.Drawing.Size(212, 33)
        Me.cbxJenis.TabIndex = 5
        '
        'btngudangbahanbaku
        '
        Me.btngudangbahanbaku.Location = New System.Drawing.Point(60, 681)
        Me.btngudangbahanbaku.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btngudangbahanbaku.Name = "btngudangbahanbaku"
        Me.btngudangbahanbaku.Size = New System.Drawing.Size(213, 75)
        Me.btngudangbahanbaku.TabIndex = 10
        Me.btngudangbahanbaku.Text = "gudang bahan baku"
        Me.btngudangbahanbaku.UseVisualStyleBackColor = True
        '
        'btngudangbahanjadi
        '
        Me.btngudangbahanjadi.Location = New System.Drawing.Point(784, 681)
        Me.btngudangbahanjadi.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btngudangbahanjadi.Name = "btngudangbahanjadi"
        Me.btngudangbahanjadi.Size = New System.Drawing.Size(213, 75)
        Me.btngudangbahanjadi.TabIndex = 11
        Me.btngudangbahanjadi.Text = "gudang jadi"
        Me.btngudangbahanjadi.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 325)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Jumlah"
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(288, 325)
        Me.txtJumlah.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(212, 31)
        Me.txtJumlah.TabIndex = 13
        '
        'btnhitung
        '
        Me.btnhitung.Location = New System.Drawing.Point(366, 374)
        Me.btnhitung.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(140, 54)
        Me.btnhitung.TabIndex = 14
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'btnlihatdata
        '
        Me.btnlihatdata.Location = New System.Drawing.Point(744, 376)
        Me.btnlihatdata.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnlihatdata.Name = "btnlihatdata"
        Me.btnlihatdata.Size = New System.Drawing.Size(140, 46)
        Me.btnlihatdata.TabIndex = 15
        Me.btnlihatdata.Text = "Produksi"
        Me.btnlihatdata.UseVisualStyleBackColor = True
        '
        'Talisn
        '
        Me.Talisn.Location = New System.Drawing.Point(163, 466)
        Me.Talisn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Talisn.Name = "Talisn"
        Me.Talisn.Size = New System.Drawing.Size(130, 31)
        Me.Talisn.TabIndex = 17
        '
        'Insolesn
        '
        Me.Insolesn.Location = New System.Drawing.Point(163, 617)
        Me.Insolesn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Insolesn.Name = "Insolesn"
        Me.Insolesn.Size = New System.Drawing.Size(130, 31)
        Me.Insolesn.TabIndex = 18
        '
        'Outsolesn
        '
        Me.Outsolesn.Location = New System.Drawing.Point(163, 517)
        Me.Outsolesn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Outsolesn.Name = "Outsolesn"
        Me.Outsolesn.Size = New System.Drawing.Size(130, 31)
        Me.Outsolesn.TabIndex = 19
        '
        'Kainsn
        '
        Me.Kainsn.Location = New System.Drawing.Point(163, 567)
        Me.Kainsn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Kainsn.Name = "Kainsn"
        Me.Kainsn.Size = New System.Drawing.Size(130, 31)
        Me.Kainsn.TabIndex = 20
        '
        'Benangfs
        '
        Me.Benangfs.Location = New System.Drawing.Point(867, 558)
        Me.Benangfs.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Benangfs.Name = "Benangfs"
        Me.Benangfs.Size = New System.Drawing.Size(130, 31)
        Me.Benangfs.TabIndex = 24
        '
        'Outsolefs
        '
        Me.Outsolefs.Location = New System.Drawing.Point(867, 508)
        Me.Outsolefs.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Outsolefs.Name = "Outsolefs"
        Me.Outsolefs.Size = New System.Drawing.Size(130, 31)
        Me.Outsolefs.TabIndex = 23
        '
        'Insolefs
        '
        Me.Insolefs.Location = New System.Drawing.Point(867, 608)
        Me.Insolefs.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Insolefs.Name = "Insolefs"
        Me.Insolefs.Size = New System.Drawing.Size(130, 31)
        Me.Insolefs.TabIndex = 22
        '
        'Kainfs
        '
        Me.Kainfs.Location = New System.Drawing.Point(867, 457)
        Me.Kainfs.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Kainfs.Name = "Kainfs"
        Me.Kainfs.Size = New System.Drawing.Size(130, 31)
        Me.Kainfs.TabIndex = 21
        '
        'Resletinghl
        '
        Me.Resletinghl.Location = New System.Drawing.Point(526, 567)
        Me.Resletinghl.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Resletinghl.Name = "Resletinghl"
        Me.Resletinghl.Size = New System.Drawing.Size(130, 31)
        Me.Resletinghl.TabIndex = 28
        '
        'Kayuhl
        '
        Me.Kayuhl.Location = New System.Drawing.Point(526, 517)
        Me.Kayuhl.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Kayuhl.Name = "Kayuhl"
        Me.Kayuhl.Size = New System.Drawing.Size(130, 31)
        Me.Kayuhl.TabIndex = 27
        '
        'Insolehl
        '
        Me.Insolehl.Location = New System.Drawing.Point(526, 617)
        Me.Insolehl.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Insolehl.Name = "Insolehl"
        Me.Insolehl.Size = New System.Drawing.Size(130, 31)
        Me.Insolehl.TabIndex = 26
        '
        'KulitSuedehl
        '
        Me.KulitSuedehl.Location = New System.Drawing.Point(526, 466)
        Me.KulitSuedehl.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.KulitSuedehl.Name = "KulitSuedehl"
        Me.KulitSuedehl.Size = New System.Drawing.Size(130, 31)
        Me.KulitSuedehl.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 466)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 25)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Tali"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 616)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 25)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Insole"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(55, 566)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 25)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Kain"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(55, 516)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 25)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Outsole"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(353, 466)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 25)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Kulit Suede"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(353, 516)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 25)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Kayu"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(353, 566)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 25)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Resleting"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(744, 522)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 25)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Outsole"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(353, 616)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 25)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Insole"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(744, 466)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 25)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Kain"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(744, 572)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 25)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Benang nilon"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(744, 622)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 25)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Insole"
        '
        'LvDisplay
        '
        Me.LvDisplay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Tanggal, Me.Jenis, Me.Jumlah})
        Me.LvDisplay.FullRowSelect = True
        Me.LvDisplay.GridLines = True
        Me.LvDisplay.HideSelection = False
        Me.LvDisplay.Location = New System.Drawing.Point(572, 179)
        Me.LvDisplay.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.LvDisplay.Name = "LvDisplay"
        Me.LvDisplay.Size = New System.Drawing.Size(409, 185)
        Me.LvDisplay.TabIndex = 43
        Me.LvDisplay.UseCompatibleStateImageBehavior = False
        Me.LvDisplay.View = System.Windows.Forms.View.Details
        '
        'Tanggal
        '
        Me.Tanggal.Text = "Tanggal"
        Me.Tanggal.Width = 150
        '
        'Jenis
        '
        Me.Jenis.Text = "Jenis"
        Me.Jenis.Width = 150
        '
        'Jumlah
        '
        Me.Jumlah.Text = "Jumlah"
        Me.Jumlah.Width = 100
        '
        'FormProduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1049, 783)
        Me.Controls.Add(Me.LvDisplay)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Resletinghl)
        Me.Controls.Add(Me.Kayuhl)
        Me.Controls.Add(Me.Insolehl)
        Me.Controls.Add(Me.KulitSuedehl)
        Me.Controls.Add(Me.Benangfs)
        Me.Controls.Add(Me.Outsolefs)
        Me.Controls.Add(Me.Insolefs)
        Me.Controls.Add(Me.Kainfs)
        Me.Controls.Add(Me.Kainsn)
        Me.Controls.Add(Me.Outsolesn)
        Me.Controls.Add(Me.Insolesn)
        Me.Controls.Add(Me.Talisn)
        Me.Controls.Add(Me.btnlihatdata)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btngudangbahanjadi)
        Me.Controls.Add(Me.btngudangbahanbaku)
        Me.Controls.Add(Me.cbxJenis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Date1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "FormProduction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Date1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxJenis As ComboBox
    Friend WithEvents btngudangbahanbaku As Button
    Friend WithEvents btngudangbahanjadi As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents btnhitung As Button
    Friend WithEvents btnlihatdata As Button
    Friend WithEvents Talisn As TextBox
    Friend WithEvents Insolesn As TextBox
    Friend WithEvents Outsolesn As TextBox
    Friend WithEvents Kainsn As TextBox
    Friend WithEvents Benangfs As TextBox
    Friend WithEvents Outsolefs As TextBox
    Friend WithEvents Insolefs As TextBox
    Friend WithEvents Kainfs As TextBox
    Friend WithEvents Resletinghl As TextBox
    Friend WithEvents Kayuhl As TextBox
    Friend WithEvents Insolehl As TextBox
    Friend WithEvents KulitSuedehl As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents LvDisplay As ListView
    Friend WithEvents Tanggal As ColumnHeader
    Friend WithEvents Jenis As ColumnHeader
    Friend WithEvents Jumlah As ColumnHeader
End Class
