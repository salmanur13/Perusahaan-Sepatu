Public Class Form_Utama
Private Sub btnGudangBarangJadi_Click(sender As Object, e As EventArgs) Handles btnGudangBarangJadi.Click
        Gudangbarangjadi.Show()
    End Sub

    Private Sub btnLogistik_Click(sender As Object, e As EventArgs) Handles btnLogistik.Click
        Form_Logistik.Show()
    End Sub

    Private Sub btnPemesanan_Click(sender As Object, e As EventArgs) Handles btnPemesanan.Click
        Form1Pemesan.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Gudangbahanbaku.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormBOM.Show()
    End Sub
  
End Class
