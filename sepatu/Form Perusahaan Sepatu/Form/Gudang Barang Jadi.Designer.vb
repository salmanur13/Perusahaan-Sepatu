﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gudangbarangjadi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gudangbarangjadi))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.btnRefrsh = New System.Windows.Forms.Button()
        Me.btnLogistik = New System.Windows.Forms.Button()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(302, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GUDANG BARANG JADI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(63, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Barang Masuk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(630, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Barang Keluar"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(45, 129)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(221, 247)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Jenis Produk"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Jumlah Produk"
        Me.ColumnHeader2.Width = 120
        '
        'btnRefrsh
        '
        Me.btnRefrsh.BackgroundImage = Global.Form_Perusahaan_Sepatu.My.Resources.Resources.download__1_
        Me.btnRefrsh.Location = New System.Drawing.Point(496, 441)
        Me.btnRefrsh.Name = "btnRefrsh"
        Me.btnRefrsh.Size = New System.Drawing.Size(111, 37)
        Me.btnRefrsh.TabIndex = 5
        Me.btnRefrsh.Text = "Refresh"
        Me.btnRefrsh.UseVisualStyleBackColor = True
        '
        'btnLogistik
        '
        Me.btnLogistik.BackgroundImage = Global.Form_Perusahaan_Sepatu.My.Resources.Resources.download__1_
        Me.btnLogistik.Location = New System.Drawing.Point(647, 441)
        Me.btnLogistik.Name = "btnLogistik"
        Me.btnLogistik.Size = New System.Drawing.Size(160, 37)
        Me.btnLogistik.TabIndex = 7
        Me.btnLogistik.Text = "Logistik"
        Me.btnLogistik.UseVisualStyleBackColor = True
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(630, 129)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(237, 247)
        Me.ListView2.TabIndex = 4
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Jenis Produk"
        Me.ColumnHeader9.Width = 120
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Jumlah Produk"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 120
        '
        'Gudangbarangjadi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(932, 547)
        Me.Controls.Add(Me.btnLogistik)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.btnRefrsh)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Gudangbarangjadi"
        Me.Text = "Gudang Barang Jadi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnRefrsh As Button
    Friend WithEvents btnLogistik As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents t As Button
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
End Class
