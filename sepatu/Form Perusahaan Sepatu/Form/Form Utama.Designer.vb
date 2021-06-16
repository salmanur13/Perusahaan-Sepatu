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
        Me.btnPemesanan = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnGudangBarangJadi = New System.Windows.Forms.Button()
        Me.btnLogistik = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPemesanan
        '
        Me.btnPemesanan.Location = New System.Drawing.Point(78, 118)
        Me.btnPemesanan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPemesanan.Name = "btnPemesanan"
        Me.btnPemesanan.Size = New System.Drawing.Size(149, 38)
        Me.btnPemesanan.TabIndex = 0
        Me.btnPemesanan.Text = "Pemesanan"
        Me.btnPemesanan.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(411, 163)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 38)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "BOM"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(411, 83)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(219, 38)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Gudang Bahan Baku"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnGudangBarangJadi
        '
        Me.btnGudangBarangJadi.Location = New System.Drawing.Point(50, 40)
        Me.btnGudangBarangJadi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGudangBarangJadi.Name = "btnGudangBarangJadi"
        Me.btnGudangBarangJadi.Size = New System.Drawing.Size(219, 38)
        Me.btnGudangBarangJadi.TabIndex = 3
        Me.btnGudangBarangJadi.Text = "Gudang Barang Jadi"
        Me.btnGudangBarangJadi.UseVisualStyleBackColor = True
        '
        'btnLogistik
        '
        Me.btnLogistik.Location = New System.Drawing.Point(93, 204)
        Me.btnLogistik.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogistik.Name = "btnLogistik"
        Me.btnLogistik.Size = New System.Drawing.Size(107, 38)
        Me.btnLogistik.TabIndex = 4
        Me.btnLogistik.Text = "Logistik"
        Me.btnLogistik.UseVisualStyleBackColor = True
        '
        'Form_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 370)
        Me.Controls.Add(Me.btnLogistik)
        Me.Controls.Add(Me.btnGudangBarangJadi)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnPemesanan)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_Utama"
        Me.Text = "Form_Utama"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPemesanan As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnGudangBarangJadi As Button
    Friend WithEvents btnLogistik As Button
End Class
