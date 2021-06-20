Public Class FormProduction
    Dim Penyimpanan As New Penyimpanan
    Private Sub btngudangbahanjadi_Click(sender As Object, e As EventArgs) Handles btngudangbahanjadi.Click
        Me.Hide()
        Gudangbarangjadi.Show()
    End Sub
    Private Sub btngudangbahanbaku_Click(sender As Object, e As EventArgs) Handles btngudangbahanbaku.Click
        Me.Hide()
        Form3Gudangbahanbaku.Show()
    End Sub

    Private Sub FormProduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each entry In Pesanan.dataPesanan
            cbxJenis.Items.Add(entry.MerkPesanan)
        Next
    End Sub
    Private Sub comboNameChanged(sender As Object, e As EventArgs) Handles cbxJenis.SelectedValueChanged
        Dim pesanan As Pesanan = Penyimpanan.getPesananByMerk(cbxJenis.SelectedItem.ToString())
        txtJumlah.Text = pesanan.Jumlah
    End Sub
    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Bahanbaku.jenis = cbxJenis.Text
        Bahanbaku.model()
        'Sneakers
        If cbxJenis.Text = "Sneakers" Then
            Talisn.Text = Bahanbaku.talisnk
            Outsolesn.Text = Bahanbaku.ossnk
            Kainsn.Text = Bahanbaku.kainsnk
            Insolesn.Text = Bahanbaku.issnk

        ElseIf cbxJenis.Text = "Heels" Then
            'Heels
            KulitSuedehl.Text = Bahanbaku.kulithls
            Kayuhl.Text = Bahanbaku.kayuhls
            Resletinghl.Text = Bahanbaku.reshls
            Insolehl.Text = Bahanbaku.ishls

        ElseIf cbxJenis.Text = "Flat Shoes" Then
            'Flat Shoes
            Kainfs.Text = Bahanbaku.kainfs
            Outsolefs.Text = Bahanbaku.osfs
            Benangfs.Text = Bahanbaku.benangfs
            Insolefs.Text = Bahanbaku.isfs
        End If
    End Sub
    Private Sub btnlihatdata_Click(sender As Object, e As EventArgs) Handles btnlihatdata.Click
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
        LvDisplay.Items.Clear()
        For Each barang In Penyimpanan.dataJadi
            LvDisplay.Items.Add(New ListViewItem(New String() {Date1.Text, barang.jenprod, barang.jumlprod}))
        Next

        Dim J As Integer
        J = Convert.ToInt32(txtJumlah.Text)
        Dim Ptali, PInsole, PRes, PKain, PKayu, PBen, PKul, POutsole As Integer
        Ptali = J * -CInt(Talisn.Text)
        PInsole = J * -CInt(Insolesn.Text) + J * -CInt(Insolehl.Text) + J * -CInt(Insolefs.Text)
        POutsole = J * -CInt(Outsolesn.Text) + J * -CInt(Outsolefs.Text)
        PKayu = J * -CInt(Kayuhl.Text)
        PRes = J * -CInt(Resletinghl.Text)
        PKain = J * -CInt(Kainfs.Text) + J * -CInt(Kainsn.Text)
        PBen = J * -CInt(Benangfs.Text)
        PKul = J * -CInt(KulitSuedehl.Text)
        '    (J * -CInt(Talisn.Text), J * -CInt(Outsolesn.Text), J * -CInt(Kainsn.Text), J * -CInt(Insolesn.Text), J * -CInt(KulitSuedehl.Text), J * -CInt(Kayuhl.Text), J * -CInt(Insolehl.Text), J * -CInt(Resletinghl.Text), J * -CInt(Kainfs.Text), J * -CInt(Outsolefs.Text), J * -CInt(Benangfs.Text), J * -CInt(Insolefs.Text))
        Dim kurangbahan As New Bahanbaku(Ptali, POutsole, PInsole, PKain, PBen, PKayu, PKul, PRes)
        kurangbahan.savedata()
    End Sub
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Talisn.Clear()
        Outsolesn.Clear()
        Kainsn.Clear()
        Insolesn.Clear()
        KulitSuedehl.Clear()
        Kayuhl.Clear()
        Insolehl.Clear()
        Resletinghl.Clear()
        Kainfs.Clear()
        Outsolefs.Clear()
        Benangfs.Clear()
        Insolefs.Clear()
        txtJumlah.Clear()
    End Sub
End Class