<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Utama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Utama))
        Me.btn_pesan = New System.Windows.Forms.Button()
        Me.btn_bom = New System.Windows.Forms.Button()
        Me.btn_bahan = New System.Windows.Forms.Button()
        Me.btn_purchasing = New System.Windows.Forms.Button()
        Me.btn_produksi = New System.Windows.Forms.Button()
        Me.btn_finishing = New System.Windows.Forms.Button()
        Me.btn_logistik = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_pesan
        '
        Me.btn_pesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pesan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_pesan.Location = New System.Drawing.Point(96, 100)
        Me.btn_pesan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_pesan.Name = "btn_pesan"
        Me.btn_pesan.Size = New System.Drawing.Size(253, 67)
        Me.btn_pesan.TabIndex = 0
        Me.btn_pesan.Text = "Pemesanan"
        Me.btn_pesan.UseVisualStyleBackColor = True
        '
        'btn_bom
        '
        Me.btn_bom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_bom.Location = New System.Drawing.Point(437, 100)
        Me.btn_bom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_bom.Name = "btn_bom"
        Me.btn_bom.Size = New System.Drawing.Size(253, 67)
        Me.btn_bom.TabIndex = 1
        Me.btn_bom.Text = "Bill Of Material"
        Me.btn_bom.UseVisualStyleBackColor = True
        '
        'btn_bahan
        '
        Me.btn_bahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bahan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_bahan.Location = New System.Drawing.Point(96, 227)
        Me.btn_bahan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_bahan.Name = "btn_bahan"
        Me.btn_bahan.Size = New System.Drawing.Size(253, 67)
        Me.btn_bahan.TabIndex = 2
        Me.btn_bahan.Text = "Bahan Baku"
        Me.btn_bahan.UseVisualStyleBackColor = True
        '
        'btn_purchasing
        '
        Me.btn_purchasing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_purchasing.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_purchasing.Location = New System.Drawing.Point(437, 227)
        Me.btn_purchasing.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_purchasing.Name = "btn_purchasing"
        Me.btn_purchasing.Size = New System.Drawing.Size(253, 67)
        Me.btn_purchasing.TabIndex = 3
        Me.btn_purchasing.Text = "Purchasing"
        Me.btn_purchasing.UseVisualStyleBackColor = True
        '
        'btn_produksi
        '
        Me.btn_produksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_produksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_produksi.Location = New System.Drawing.Point(96, 353)
        Me.btn_produksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_produksi.Name = "btn_produksi"
        Me.btn_produksi.Size = New System.Drawing.Size(253, 67)
        Me.btn_produksi.TabIndex = 4
        Me.btn_produksi.Text = "Produksi"
        Me.btn_produksi.UseVisualStyleBackColor = True
        '
        'btn_finishing
        '
        Me.btn_finishing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_finishing.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_finishing.Location = New System.Drawing.Point(437, 353)
        Me.btn_finishing.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_finishing.Name = "btn_finishing"
        Me.btn_finishing.Size = New System.Drawing.Size(253, 67)
        Me.btn_finishing.TabIndex = 5
        Me.btn_finishing.Text = "Finishing Goods"
        Me.btn_finishing.UseVisualStyleBackColor = True
        '
        'btn_logistik
        '
        Me.btn_logistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logistik.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_logistik.Location = New System.Drawing.Point(96, 482)
        Me.btn_logistik.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_logistik.Name = "btn_logistik"
        Me.btn_logistik.Size = New System.Drawing.Size(253, 67)
        Me.btn_logistik.TabIndex = 6
        Me.btn_logistik.Text = "Logistik"
        Me.btn_logistik.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_keluar.Location = New System.Drawing.Point(437, 482)
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(253, 67)
        Me.btn_keluar.TabIndex = 7
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(269, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 54)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "MAIN MENU"
        '
        'Form_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 647)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_logistik)
        Me.Controls.Add(Me.btn_finishing)
        Me.Controls.Add(Me.btn_produksi)
        Me.Controls.Add(Me.btn_purchasing)
        Me.Controls.Add(Me.btn_bahan)
        Me.Controls.Add(Me.btn_bom)
        Me.Controls.Add(Me.btn_pesan)
        Me.Name = "Form_Utama"
        Me.Text = "Form_Utama"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_pesan As Button
    Friend WithEvents btn_bom As Button
    Friend WithEvents btn_bahan As Button
    Friend WithEvents btn_purchasing As Button
    Friend WithEvents btn_produksi As Button
    Friend WithEvents btn_finishing As Button
    Friend WithEvents btn_logistik As Button
    Friend WithEvents btn_keluar As Button
    Friend WithEvents Label1 As Label
End Class
