Public Class FormProduction
    Dim Penyimpanan As New Penyimpanan
    Dim pesanan As Pesanan
    Dim Ptali, PInsole, PRes, PKain, PKayu, PBen, PKul, POutsole As Double
    Private Sub btngudangbahanjadi_Click(sender As Object, e As EventArgs) Handles btngudangbahanjadi.Click
        Me.Hide()
        Gudangbarangjadi.Show()
    End Sub
    Private Sub btngudangbahanbaku_Click(sender As Object, e As EventArgs) Handles btngudangbahanbaku.Click
        Me.Hide()
        Form3Gudangbahanbaku.Show()
    End Sub

    Private Sub FormProduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  For Each entry In Pesanan.dataPesanan
        ' cbxJenis.Items.Add(entry.MerkPesanan)
        'Next
    End Sub
    Private Sub comboNameChanged(sender As Object, e As EventArgs) Handles cbxJenis.SelectedValueChanged
        '   Dim pesanan As Pesanan = Penyimpanan.getPesananByMerk(cbxJenis.SelectedItem.ToString())
        'Flat shoes = vans
        'Sneakers = adidas
        'Heels = nike
        If Form1Pemesan.txtA.Text = "" Then
            Form1Pemesan.txtA.Text = 0
        End If
        If cbxJenis.Text = "Sneakers" Then
            txtJumlah.Text = Form1Pemesan.txtA.Text
        End If

        If Form1Pemesan.txtV.Text = "" Then
            Form1Pemesan.txtV.Text = 0
        End If
        If cbxJenis.Text = "Flat Shoes" Then
            txtJumlah.Text = Form1Pemesan.txtV.Text
        End If

        If Form1Pemesan.txtN.Text = "" Then
            Form1Pemesan.txtN.Text = 0
        End If
        If cbxJenis.Text = "Heels" Then
            txtJumlah.Text = Form1Pemesan.txtN.Text
        End If
    End Sub
    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        '  Bahanbaku.jenis = cbxJenis.Text
        ' Bahanbaku.model()
        '  Bahanbaku.jml
        '   Bahanbaku.jml = txtJumlah.Text
        'Sneakers
        If cbxJenis.Text = "Sneakers" Then
            Talisn.Text = Bahanbaku.talisnk
            Outsolesn.Text = Bahanbaku.ossnk
            Kainsn.Text = Bahanbaku.kainsnk
            Insolesn.Text = Bahanbaku.issnk
            KulitSuedehl.Text = 0
            Kayuhl.Text = 0
            Resletinghl.Text = 0
            Insolehl.Text = 0
            Kainfs.Text = 0
            Outsolefs.Text = 0
            Benangfs.Text = 0
            Insolefs.Text = 0
        ElseIf cbxJenis.Text = "Heels" Then
            'Heels
            Talisn.Text = 0
            Outsolesn.Text = 0
            Kainsn.Text = 0
            Insolesn.Text = 0
            KulitSuedehl.Text = Bahanbaku.kulithls
            Kayuhl.Text = Bahanbaku.kayuhls
            Resletinghl.Text = Bahanbaku.reshls
            Insolehl.Text = Bahanbaku.ishls
            Kainfs.Text = 0
            Outsolefs.Text = 0
            Benangfs.Text = 0
            Insolefs.Text = 0

        ElseIf cbxJenis.Text = "Flat Shoes" Then
            'Flat Shoes
            Talisn.Text = 0
            Outsolesn.Text = 0
            Kainsn.Text = 0
            Insolesn.Text = 0
            Kainfs.Text = Bahanbaku.kainfs
            Outsolefs.Text = Bahanbaku.osfs
            Benangfs.Text = Bahanbaku.benangfs
            Insolefs.Text = Bahanbaku.isfs
            KulitSuedehl.Text = 0
            Kayuhl.Text = 0
            Resletinghl.Text = 0
            Insolehl.Text = 0
        End If
    End Sub
    Private Sub btnlihatdata_Click(sender As Object, e As EventArgs) Handles btnlihatdata.Click
        Dim barang As New Barangjadi(Date1.Text, cbxJenis.Text, Convert.ToInt32(txtJumlah.Text))
        Penyimpanan.saveBarangJadi(barang)
        Penyimpanan.saveProduksi(barang)

        Ptali = Convert.ToInt32(Talisn.Text)
        POutsole = -Convert.ToInt32(Outsolesn.Text) + (-Convert.ToInt32(Outsolefs.Text))
        PInsole = -CInt(Insolesn.Text) + -CInt(Insolehl.Text) + -CInt(Insolefs.Text)
        PKain = -CInt(Kainfs.Text) + -CInt(Kainsn.Text)
        PBen = -CInt(Benangfs.Text)
        PKayu = -CInt(Kayuhl.Text)
        PKul = -CInt(KulitSuedehl.Text)
        PRes = -CInt(Resletinghl.Text)
        Dim kurangbahan As New BahanKeluar(Ptali, POutsole, PInsole, PKain, PBen, PKayu, PKul, PRes)
        kurangbahan.savedata()
        For Each barang In Penyimpanan.dataJadi
            LvDisplay.Items.Add(New ListViewItem(New String() {Date1.Text, barang.jenprod, barang.jumlprod}))
        Next

        If cbxJenis.Text = "Sneakers" Then
            MessageBox.Show("Sneakers berhasil di produksi")
        ElseIf cbxJenis.Text = "Heels" Then
            MessageBox.Show("Heels berhasil di produksi")
        ElseIf cbxJenis.Text = "Flat Shoes" Then
            MessageBox.Show("Flat Shoes berhasil di produksi")
        End If


        cbxJenis.Text = ""
        txtJumlah.Clear()
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
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) 
        ' Penyimpanan.savebahanproduksi(kurangbahan)
    End Sub
End Class