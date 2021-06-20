Public Class Form_Logistik
    Dim Penyimpanan As New Penyimpanan
    Private Sub Form_Logistik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each entry In Pesanan.dataPesanan
            cmbpesanan.Items.Add(entry.Nama)
        Next
    End Sub
    Private Sub btnMenuutama_Click(sender As Object, e As EventArgs) Handles btnMenuutama.Click
        Me.Hide()
        Form_Utama.Show()
    End Sub
    Private Sub cmbtujuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtujuan.SelectedIndexChanged
        'Dim tujuan As DataLogistik
        Logistik.tujuan = cmbtujuan.Text
        Logistik.ongkoskirim()
        txtongkir.Text = Logistik.biaya
    End Sub
    Private Sub comboNameChanged(sender As Object, e As EventArgs) Handles cmbpesanan.SelectedValueChanged
        Dim pesanan As Pesanan = Penyimpanan.getPesananByName(cmbpesanan.SelectedItem.ToString())
        cmbjenissepatu.Text = pesanan.MerkPesanan
        txtjumlah.Text = pesanan.Jumlah
    End Sub
    Private Sub btnlihatdata_Click(sender As Object, e As EventArgs) Handles btnlihatdata.Click
        ListView1.Items.Add(New ListViewItem(New String() {cmbpesanan.Text, cmbjenissepatu.Text, txtjumlah.Text, cmbtujuan.Text, txtongkir.Text, DateTimePicker1.Text, DateTimePicker2.Text}))
    End Sub
    Private Sub btnKirimBarang_Click(sender As Object, e As EventArgs) Handles btnKirimBarang.Click
        MessageBox.Show("Barang sukses terkirim")
        Dim logistik As New Logistik(cmbjenissepatu.Text, txtjumlah.Text, cmbtujuan.Text, txtongkir.Text, DateTimePicker1.Text, DateTimePicker2.Text)
        Penyimpanan.saveLogistik(logistik)
        'kurangi barang jadi
        Dim Sneakers As New Barangjadi(DateTimePicker1.Text, cmbjenissepatu.Text, -Convert.ToInt32(txtjumlah.Text))
        Dim Heels As New Barangjadi(DateTimePicker1.Text, cmbjenissepatu.Text, -Convert.ToInt32(txtjumlah.Text))
        Penyimpanan.saveBarangJadi(Sneakers)
        Penyimpanan.saveBarangJadi(Heels)
        cmbjenissepatu.Text = ""
        txtjumlah.Clear()
        cmbtujuan.Text = ""
        txtongkir.Clear()
        DateTimePicker1.Text = ""
        DateTimePicker2.Text = ""
    End Sub
End Class