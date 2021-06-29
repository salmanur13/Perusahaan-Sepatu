Public Class Form2BOM
    Public Shared kode, BOM As String
    '  Public bahanbaku As New bahanbaku
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form_Utama.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form3Gudangbahanbaku.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtpesanan.Clear()
        txtbom.Clear()
        ComboBoxJenis.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBoxJenis.Text = "Sneakers" Then
            LVBOM.Items.Add(New ListViewItem(New String() {Bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txttalisnk.Text, lbltalisnk.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {Bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtossnk.Text, lblossnk.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {Bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtkainsnk.Text, lblkainsnk.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {Bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtissnk.Text, lblissnk.Text}))
        ElseIf ComboBoxJenis.Text = "Heels" Then
            LVBOM.Items.Add(New ListViewItem(New String() {Bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtkulithls.Text, lblkulithls.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {Bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtkayuhls.Text, lblkayuhls.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {Bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtreshls.Text, lblreshls.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {Bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtishls.Text, lblishls.Text}))
        ElseIf ComboBoxJenis.Text = "Flat Shoes" Then
            LVBOM.Items.Add(New ListViewItem(New String() {Bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtkainfs.Text, lblkainfs.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {Bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtosfs.Text, lblosfs.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {Bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtbenangfs.Text, lblbenangfs.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {Bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtisfs.Text, lblisfs.Text}))
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1Pemesan.Show()
    End Sub
    Private Sub comboNameChanged(sender As Object, e As EventArgs) Handles ComboBoxJenis.SelectedValueChanged
        '   Dim pesanan As Pesanan = Penyimpanan.getPesananByMerk(cbxJenis.SelectedItem.ToString())
        'Flat shoes = vans
        'Sneakers = adidas
        'Heels = nike
        If Form1Pemesan.txtA.Text = "" Then
            Form1Pemesan.txtA.Text = 0
        End If
        If ComboBoxJenis.Text = "Sneakers" Then
            txtpesanan.Text = Form1Pemesan.txtA.Text
        End If

        If Form1Pemesan.txtV.Text = "" Then
            Form1Pemesan.txtV.Text = 0
        End If
        If ComboBoxJenis.Text = "Flat Shoes" Then
            txtpesanan.Text = Form1Pemesan.txtV.Text
        End If

        If Form1Pemesan.txtN.Text = "" Then
            Form1Pemesan.txtN.Text = 0
        End If
        If ComboBoxJenis.Text = "Heels" Then
            txtpesanan.Text = Form1Pemesan.txtN.Text
        End If
    End Sub
    Private Sub hitungbom_Click(sender As Object, e As EventArgs) Handles hitungbom.Click
        Bahanbaku.jenis = ComboBoxJenis.Text
        Bahanbaku.model()
        txtbom.Text = Bahanbaku.kode
        txtpesanan.Text = Bahanbaku.jml
        'Sneakers
        If ComboBoxJenis.Text = "Sneakers" Then
            txttalisnk.Text = Bahanbaku.talisnk
            txtossnk.Text = Bahanbaku.ossnk
            txtkainsnk.Text = Bahanbaku.kainsnk
            txtissnk.Text = Bahanbaku.issnk

        ElseIf ComboBoxJenis.Text = "Heels" Then
            'Heels
            txtkulithls.Text = Bahanbaku.kulithls
            txtkayuhls.Text = Bahanbaku.kayuhls
            txtreshls.Text = Bahanbaku.reshls
            txtishls.Text = Bahanbaku.ishls

        ElseIf ComboBoxJenis.Text = "Flat Shoes" Then
            'Flat Shoes
            txtkainfs.Text = Bahanbaku.kainfs
            txtosfs.Text = Bahanbaku.osfs
            txtbenangfs.Text = Bahanbaku.benangfs
            txtisfs.Text = Bahanbaku.isfs
        End If

    End Sub
End Class
