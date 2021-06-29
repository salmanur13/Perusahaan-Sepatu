Public Class Form1Pemesan 'class public Form1Pemesan
    Dim i As Integer = 1 'mendeklarasikan i sebagai integer = 1
    Dim penyimpanan As New Penyimpanan 'mendeklarasikan penyimpanan sebagai new penyimpanan
    'Flat shoes = vans
    'Sneakers = adidas
    'Heels = nike
    Private Sub BtnFormUtama_Click(sender As Object, e As EventArgs) Handles BtnFormUtama.Click 'menjalankan fungsi BtnFormUtama
        Me.Hide() 'menyembunyikan form pemesanan
        Form_Utama.Show() 'menampilkan form utama
    End Sub 'mengakhiri fungsi sub
    Private Sub Form1Pemesan_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'menjalankan fungsi ketika form1pemesan load
        txtKode.Text = "PO00" & i 'menginiasi txtkode.text = "P0OO" & i
    End Sub 'mengakhiri fungsi sub
    Private Sub BtnSelesai_Click(sender As Object, e As EventArgs) Handles BtnSelesai.Click 'menjalankan fungsi BtnSelesai
        Form2BOM.Show() 'menampilkan form2BOM
        Me.Hide() 'menyembunyikan form pemesanan
    End Sub 'mengakhiri fungsi sub
    Private Sub BtnInput_Click_1(sender As Object, e As EventArgs) Handles BtnInput.Click 'menjalankan fungsi BtnSelesai
        If txtV.Text = "" Then 'jika txtV.Text = "" maka
            txtV.Text = 0 'txtV.Text = 0
        End If 'mengakhiri fungsi if
        If ComboBoxMerk1.Text = "Flat shoes" Then 'jika ComboBoxMerk1.Text = "Flat shoes" maka
            txtV.Text = Convert.ToInt32(txtJ1.Text) + Convert.ToInt32(txtV.Text) 'menginisialisasi txtV.Text = Convert.ToInt32(txtJ1.Text) + Convert.ToInt32(txtV.Text)
        End If ''mengakhiri fungsi if

        If txtA.Text = "" Then 'jika txtA.Text = "" maka
            txtA.Text = 0 'txtA.Text = 0
        End If 'mengakhiri fungsi if
        If ComboBoxMerk1.Text = "Sneakers" Then 'jika ComboBoxMerk1.Text = "Sneakers" maka
            txtA.Text = Convert.ToInt32(txtJ1.Text) + Convert.ToInt32(txtA.Text) 'menginisialisasi txtA.Text = Convert.ToInt32(txtJ1.Text) + Convert.ToInt32(txtA.Text)
        End If 'mengakhiri fungsi if

        If txtN.Text = "" Then 'jika txtN.Text = "" maka
            txtN.Text = 0 'txtN.Text = 0
        End If 'mengakhiri fungsi if
        If ComboBoxMerk1.Text = "Heels" Then 'Jika ComboBoxMerk1.Text = "Heels" maka
            txtN.Text = Convert.ToInt32(txtJ1.Text) + Convert.ToInt32(txtN.Text) 'menginisialisasi txtN.Text = Convert.ToInt32(txtJ1.Text) + Convert.ToInt32(txtN.Text)
        End If 'mengakhiri fungsi if

        Dim pesanan As New Pesanan(txtKode.Text, TxtNama.Text, DateTimePicker1.Text, DateTimePicker2.Text, TxtNo.Text, TxtAlamat.Text, ComboBoxMerk1.Text, ComboBoxWarna1.Text, ComboBoxUk1.Text, txtJ1.Text, txtV.Text, txtA.Text, txtN.Text) 'mendeklarasikan pesanan sebagai new pesanan
        penyimpanan.savePesanan(pesanan) 'simpan data ke class penyimpanan
        pesanan.savedata() 'simpan data ke class pesanan
        ListView1.Items.Clear() 'membersihkan ListView1.Items
        For Each pesan In Penyimpanan.dataPesanan 'memulai struktur pengulangan untuk setiap pesan Di penyimpanan.datapesanan
            ListView1.Items.Add(New ListViewItem(New String() {pesan.Kode, pesan.Nama, pesan.Tanggal, pesan.Deadline, pesan.No, pesan.Alamat, pesan.ItemPesanan, pesan.Jumlah})) 'menampilkan data pada listview
        Next 'selanjutnya
        'kode pesanan
        If i >= 1 Then 'jika i lebih besar sama dengan 1 maka
            i = i + 1 'menginisialisasi i = i + 1
        End If 'mengakhiri fungsi if
        txtKode.Text = "PO00" & i 'menginisialisasi txtKode.Text = "PO00" & i
        If i >= 10 Then 'jika i lebih besar sama dengan 10 maka
            txtKode.Text = "PO0" & i 'menginisialisasi txtKode.Text = "PO0" & i
        End If 'mengakhiri fungsi if
        If i >= 100 Then 'jika i lebih besar sama dengan 100 maka
            txtKode.Text = "PO" & i 'menginisialisasi txtKode.Text = "PO" & i
        End If 'mengakhiri fungsi if
        TxtNama.Clear() 'menghapus TxtNama.Text
        DateTimePicker1.Text = "" 'membersihkan DateTimePicker1.Text
        TxtAlamat.Clear() 'menghapus TxtAlamat.Text
        TxtNo.Clear() 'menghapus TxtNo.Text
        txtJ1.Clear() 'menghapus txtJ1.Text
        '  txtTotal.Clear() 'menghapus txtTotal.Text
        ComboBoxWarna1.Text = "" 'membersihkan ComboBoxWarna1.Text
        ComboBoxUk1.Text = "" 'membersihkan ComboBoxUk1.Text
        ComboBoxMerk1.Text = "" 'membersihkan ComboBoxMerk1.Text
    End Sub 'mengakhiri fungsi sub
End Class 'mengakhiri class public Form1Pemesan