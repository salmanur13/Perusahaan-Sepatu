Public Class Form1
    'Flat shoes = vans
    'Sneakers = adidas
    'Heels = nike
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'misal stok 10
        If Form1Pemesan.txtV.Text < 10 Then
            Label1.Text = "Stok Flat Shoes Tersedia"
        Else Label1.Text = "Stok Flat Shoes Tidak Mencukupi"
        End If
        If Form1Pemesan.txtV.Text = 0 Then
            Label1.Text = "Flat Shoes tidak ada pesanan"
        End If

        If Form1Pemesan.txtA.Text < 10 Then
            Label2.Text = "Stok Sneakers Tersedia"
        Else Label2.Text = "Stok Sneakers Tidak Mencukupi"
        End If
        If Form1Pemesan.txtA.Text = 0 Then
            Label2.Text = "Sneakers tidak ada pesanan"
        End If

        If Form1Pemesan.txtN.Text < 10 Then
            Label3.Text = "Stok Heels Tersedia"
        Else Label3.Text = "Stok Heels Tidak Mencukupi"
        End If
        If Form1Pemesan.txtN.Text = 0 Then
            Label3.Text = "Heels tidak ada pesanan"
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_Logistik.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2BOM.Show()
    End Sub
End Class