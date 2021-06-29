Imports Logistic_and_gudang_jadi

Public Class Form_Utama
    '   Dim Pemesanan As Form1Pemesan = New Form1Pemesan
    '  Dim BOM As Form2BOM = New Form2BOM
    ' Dim BahanBaku As Form3Gudangbahanbaku = New Form3Gudangbahanbaku
    '  Dim Purchasing As FormPurchasing = New FormPurchasing
    ' Dim Produksi As Production = New Production
    '   Dim BarangJadi As Barangjadi = New Barangjadi
    'Dim Logistik As Form_Logistik = New Form_Logistik

    Private Sub btn_pesan_Click(sender As Object, e As EventArgs) Handles btn_pesan.Click
        Form1Pemesan.Show()
    End Sub

    Private Sub btn_bom_Click(sender As Object, e As EventArgs) Handles btn_bom.Click
        Form2BOM.Show()
    End Sub

    Private Sub btn_bahan_Click(sender As Object, e As EventArgs) Handles btn_bahan.Click
        Form3Gudangbahanbaku.Show()
    End Sub

    Private Sub btn_purchasing_Click(sender As Object, e As EventArgs) Handles btn_purchasing.Click
        Form4Purchasing.Show()
    End Sub

    Private Sub btn_produksi_Click(sender As Object, e As EventArgs) Handles btn_produksi.Click
        FormProduction.Show()
    End Sub

    Private Sub btn_finishing_Click(sender As Object, e As EventArgs) Handles btn_finishing.Click
        Gudangbarangjadi.Show()
    End Sub

    Private Sub btn_logistik_Click(sender As Object, e As EventArgs) Handles btn_logistik.Click
        Form_Logistik.Show()
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Close()
    End Sub
End Class