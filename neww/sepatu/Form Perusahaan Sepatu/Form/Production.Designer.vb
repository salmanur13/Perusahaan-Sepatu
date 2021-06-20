<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productionn
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
        Me.Date1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxJenis = New System.Windows.Forms.ComboBox()
        Me.btngudangbahanbaku = New System.Windows.Forms.Button()
        Me.btngudangbahanjadi = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.btnlihatdata = New System.Windows.Forms.Button()
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
        Me.cbxJenis.Location = New System.Drawing.Point(288, 244)
        Me.cbxJenis.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cbxJenis.Name = "cbxJenis"
        Me.cbxJenis.Size = New System.Drawing.Size(212, 33)
        Me.cbxJenis.TabIndex = 5
        '
        'btngudangbahanbaku
        '
        Me.btngudangbahanbaku.Location = New System.Drawing.Point(60, 480)
        Me.btngudangbahanbaku.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btngudangbahanbaku.Name = "btngudangbahanbaku"
        Me.btngudangbahanbaku.Size = New System.Drawing.Size(213, 75)
        Me.btngudangbahanbaku.TabIndex = 10
        Me.btngudangbahanbaku.Text = "gudang bahan baku"
        Me.btngudangbahanbaku.UseVisualStyleBackColor = True
        '
        'btngudangbahanjadi
        '
        Me.btngudangbahanjadi.Location = New System.Drawing.Point(717, 480)
        Me.btngudangbahanjadi.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btngudangbahanjadi.Name = "btngudangbahanjadi"
        Me.btngudangbahanjadi.Size = New System.Drawing.Size(213, 75)
        Me.btngudangbahanjadi.TabIndex = 11
        Me.btngudangbahanjadi.Text = "gudang barang jadi"
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
        Me.btnhitung.Location = New System.Drawing.Point(360, 389)
        Me.btnhitung.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(140, 46)
        Me.btnhitung.TabIndex = 14
        Me.btnhitung.Text = "Produksi"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'btnlihatdata
        '
        Me.btnlihatdata.Location = New System.Drawing.Point(790, 389)
        Me.btnlihatdata.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnlihatdata.Name = "btnlihatdata"
        Me.btnlihatdata.Size = New System.Drawing.Size(140, 46)
        Me.btnlihatdata.TabIndex = 15
        Me.btnlihatdata.Text = "View Data"
        Me.btnlihatdata.UseVisualStyleBackColor = True
        '
        'LvDisplay
        '
        Me.LvDisplay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Tanggal, Me.Jenis, Me.Jumlah})
        Me.LvDisplay.FullRowSelect = True
        Me.LvDisplay.GridLines = True
        Me.LvDisplay.HideSelection = False
        Me.LvDisplay.Location = New System.Drawing.Point(624, 179)
        Me.LvDisplay.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.LvDisplay.Name = "LvDisplay"
        Me.LvDisplay.Size = New System.Drawing.Size(306, 185)
        Me.LvDisplay.TabIndex = 43
        Me.LvDisplay.UseCompatibleStateImageBehavior = False
        Me.LvDisplay.View = System.Windows.Forms.View.Details
        '
        'Tanggal
        '
        Me.Tanggal.Text = "Tanggal"
        Me.Tanggal.Width = 100
        '
        'Jenis
        '
        Me.Jenis.Text = "Jenis"
        Me.Jenis.Width = 100
        '
        'Jumlah
        '
        Me.Jumlah.Text = "Jumlah"
        Me.Jumlah.Width = 100
        '
        'Production
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 603)
        Me.Controls.Add(Me.LvDisplay)
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
        Me.Name = "Production"
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
    Friend WithEvents LvDisplay As ListView
    Friend WithEvents Tanggal As ColumnHeader
    Friend WithEvents Jenis As ColumnHeader
    Friend WithEvents Jumlah As ColumnHeader
End Class
