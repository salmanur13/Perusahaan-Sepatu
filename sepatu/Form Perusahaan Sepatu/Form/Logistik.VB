Public Class Form_Logistik
    Dim Penyimpanan As New Penyimpanan
    Private Sub btnMenuutama_Click(sender As Object, e As EventArgs) Handles btnMenuutama.Click
        Me.Hide()
        Form_Utama.Show()
    End Sub
    Private Sub Logistik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each entry In Pesanan.dataPesanan
            cmbpesanan.Items.Add(entry.Nama)
        Next
    End Sub
    Private Sub cmbtujuan_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbtujuan.SelectedIndexChanged
        Logistikk.Tujuan = cmbtujuan.Text
        Logistikk.ONGKIRR()
        If cmbtujuan.Text = "DKI JAKARTA" Then
            txtongkir.Text = Logistikk.rega
        End If
        If cmbtujuan.Text = "JAWA BARAT" Then
            txtongkir.Text = Logistikk.rega
        End If
        If cmbtujuan.Text = "JAWA TENGAH" Then
            txtongkir.Text = Logistikk.rega
        End If
        If cmbtujuan.Text = "JAWA TIMUR" Then
            txtongkir.Text = Logistikk.rega
        End If
        If cmbtujuan.Text = "DIY" Then
            txtongkir.Text = Logistikk.rega
        End If
        If cmbtujuan.Text = "KEPULAUAN RIAU" Then
            txtongkir.Text = Logistikk.rega
        End If
        If cmbtujuan.Text = "SUMATRA" Then
            txtongkir.Text = Logistikk.rega
        End If
    End Sub
    Private Sub comboNameChanged(sender As Object, e As EventArgs) Handles cmbpesanan.SelectedValueChanged
        Dim pesanan As Pesanan = Penyimpanan.getPesananByName(cmbpesanan.SelectedItem.ToString())
        cmbjenissepatu.Text = pesanan.MerkPesanan
        txtjumlah.Text = pesanan.Jumlah
    End Sub
    Private Sub btnHapus_Click_1(sender As Object, e As EventArgs) Handles btnHapus.Click
        cmbpesanan.Items.Clear()
        cmbjenissepatu.Items.Clear()
        cmbtujuan.Items.Clear()
        txtjumlah.Clear()
        txtongkir.Clear()
    End Sub
    Private Sub btnKirimBarang_Click(sender As Object, e As EventArgs) Handles btnKirimBarang.Click
        MessageBox.Show("Barang telah dikirim")
        Dim logistik As New Logistikk(cmbjenissepatu.Text, txtjumlah.Text, cmbtujuan.Text, txtongkir.Text, DateTimePicker1.Text, DateTimePicker2.Text)
        Penyimpanan.saveLogistik(logistik)
    End Sub

    Private Sub btnlihatdata_Click(sender As Object, e As EventArgs) Handles btnlihatdata.Click
        ListView1.Items.Add(New ListViewItem(New String() {cmbpesanan.Text, cmbjenissepatu.Text, txtjumlah.Text, cmbtujuan.Text, txtongkir.Text, DateTimePicker1.Text, DateTimePicker2.Text}))
    End Sub
End Class