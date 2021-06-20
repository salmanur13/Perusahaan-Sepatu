Public Class Productionn
    'Flat shoes = vans
    'Sneakers = adidas
    'Heels = nike
    Dim Penyimpanan As New Penyimpanan
    Private Sub btngudangbahanjadi_Click(sender As Object, e As EventArgs) Handles btngudangbahanjadi.Click
        Me.Hide()
        Gudangbarangjadi.Show()
    End Sub
    Private Sub btngudangbahanbaku_Click(sender As Object, e As EventArgs) Handles btngudangbahanbaku.Click
        Me.Hide()
        Form3Gudangbahanbaku.Show()
    End Sub
    Private Sub Production_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each entry In Pesanan.dataPesanan
            cbxJenis.Items.Add(entry.MerkPesanan)
        Next
    End Sub
    Private Sub comboNameChanged(sender As Object, e As EventArgs) Handles cbxJenis.SelectedValueChanged
        Dim pesanan As Pesanan = Penyimpanan.getPesananByMerk(cbxJenis.SelectedItem.ToString())
        txtJumlah.Text = pesanan.Jumlah
    End Sub
    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click 'produksi
        Dim barang As New Barangjadi(Date1.Text, cbxJenis.Text, Convert.ToInt32(txtJumlah.Text))
        Penyimpanan.saveBarangJadi(barang)
        If cbxJenis.Text = "Sneakers" Then
            MessageBox.Show("Sneakers sukses di produksi")
        ElseIf cbxJenis.Text = "Heels" Then
            MessageBox.Show("Heels sukses di produksi")
        ElseIf cbxJenis.Text = "Flat Shoes" Then
            MessageBox.Show("Flat Shoes sukses di produksi")
        End If
        cbxJenis.Text = ""
        txtJumlah.Clear()
    End Sub
    Private Sub btnlihatdata_Click(sender As Object, e As EventArgs) Handles btnlihatdata.Click
        LvDisplay.Items.Clear()
        For Each barang In Penyimpanan.dataJadi
            LvDisplay.Items.Add(New ListViewItem(New String() {Date1.Text, barang.jenprod, barang.jumlprod}))
        Next
    End Sub
End Class