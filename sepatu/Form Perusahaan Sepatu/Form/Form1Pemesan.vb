Public Class Form1Pemesan
    Dim i As Integer = 1
    'Flat shoes = vans
    'Sneakers = adidas
    'Heels = nike
    Private Sub BtnFormUtama_Click(sender As Object, e As EventArgs) Handles BtnFormUtama.Click 'otw ke utama
        Me.Hide()
        Form_Utama.Show()
    End Sub
    Private Sub BtnSelesai_Click(sender As Object, e As EventArgs) Handles BtnSelesai.Click 'otw ke BOM
        FormBOM.Show()
        Me.Hide()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If txtV.Text = "" Then
            txtV.Text = 0
        End If
        If ComboBoxMerk1.Text = "Flat shoes" Then
            txtV.Text = Convert.ToInt32(txtJ1.Text) + Convert.ToInt32(txtV.Text)
        End If

        If txtA.Text = "" Then
            txtA.Text = 0
        End If
        If ComboBoxMerk1.Text = "Sneakers" Then
            txtA.Text = Convert.ToInt32(txtJ1.Text) + Convert.ToInt32(txtA.Text)
        End If

        If txtN.Text = "" Then
            txtN.Text = 0
        End If
        If ComboBoxMerk1.Text = "Heels" Then
            txtN.Text = Convert.ToInt32(txtJ1.Text) + Convert.ToInt32(txtN.Text)
        End If


    End Sub
    Private Sub BtnInput_Click_1(sender As Object, e As EventArgs) Handles BtnInput.Click 'input
        Dim pesan As New CPesanan(txtKode.Text, TxtNama.Text, DateTimePicker1.Text, TxtNo.Text, TxtAlamat.Text, ComboBoxMerk1.Text, ComboBoxWarna1.Text, ComboBoxUk1.Text, txtJ1.Text, txtV.Text, txtA.Text, txtN.Text)
        pesan.savedata()
        ListView1.Items.Clear()
        For Each pesan In CPesanan.dataPesanan
            ListView1.Items.Add(New ListViewItem(New String() {pesan.Kode, pesan.Nama, pesan.Tanggal, pesan.No, pesan.Alamat, pesan.ItemPesanan, pesan.JumlahPesanan}))
        Next

    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        'hapus ganti new
        If i >= 1 Then
            i = i + 1
        End If
        txtKode.Text = "PO00" & i
        If i >= 10 Then
            txtKode.Text = "PO0" & i
        End If
        If i >= 100 Then
            txtKode.Text = "PO" & i
        End If
        TxtNama.Clear()
        DateTimePicker1.Text = ""
        TxtAlamat.Clear()
        TxtNo.Clear()
        txtJ1.Clear()
        txtTotal.Clear()
        ComboBoxWarna1.Text = ""
        ComboBoxUk1.Text = ""
        ComboBoxMerk1.Text = ""
    End Sub
    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        Dim Harga As Integer
        Select Case ComboBoxMerk1.Text
            Case "Flat shoes"
                Harga = "Rp" & 100000
            Case "Sneakers"
                Harga = "Rp" & 150000
            Case "Heels"
                Harga = "Rp" & 125000
        End Select
        txtTotal.Text = Harga * txtJ1.Text
    End Sub

    Private Sub Form1Pemesan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtKode.Text = "PO00" & i
    End Sub
End Class