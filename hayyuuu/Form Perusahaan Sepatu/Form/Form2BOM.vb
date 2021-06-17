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
            LVBOM.Items.Add(New ListViewItem(New String() {bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txttalisnk.Text, lbltalisnk.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtossnk.Text, lblossnk.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtkainsnk.Text, lblkainsnk.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtissnk.Text, lblissnk.Text}))
        ElseIf ComboBoxJenis.Text = "Heels" Then
            LVBOM.Items.Add(New ListViewItem(New String() {bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtkulithls.Text, lblkulithls.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtkayuhls.Text, lblkayuhls.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtreshls.Text, lblreshls.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtishls.Text, lblishls.Text}))
        ElseIf ComboBoxJenis.Text = "Flat Shoes" Then
            LVBOM.Items.Add(New ListViewItem(New String() {bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtkainfs.Text, lblkainfs.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtosfs.Text, lblosfs.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtbenangfs.Text, lblbenangfs.Text}))
            LVBOM.Items.Add(New ListViewItem(New String() {bahanbaku.kode, tanggal.Text, ComboBoxJenis.Text, txtisfs.Text, lblisfs.Text}))
        End If
    End Sub
    '  Private Sub Form2BOM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '     bahanbaku.jenis = ComboBoxJenis.Text
    '    bahanbaku.model()
    '   txtbom.Text = bahanbaku.kode
    '  txtpesanan.Text = bahanbaku.jml
    '    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1Pemesan.Show()
    End Sub
    Private Sub hitungbom_Click(sender As Object, e As EventArgs) Handles hitungbom.Click
        bahanbaku.jenis = ComboBoxJenis.Text
        bahanbaku.model()
        txtbom.Text = bahanbaku.kode
        txtpesanan.Text = bahanbaku.jml
        'Sneakers
        If ComboBoxJenis.Text = "Sneakers" Then
            txttalisnk.Text = bahanbaku.talisnk
            txtossnk.Text = bahanbaku.ossnk
            txtkainsnk.Text = bahanbaku.kainsnk
            txtissnk.Text = bahanbaku.issnk

        ElseIf ComboBoxJenis.Text = "Heels" Then
            'Heels
            txtkulithls.Text = bahanbaku.kulithls
            txtkayuhls.Text = bahanbaku.kayuhls
            txtreshls.Text = bahanbaku.reshls
            txtishls.Text = bahanbaku.ishls

        ElseIf ComboBoxJenis.Text = "Flat Shoes" Then
            'Flat Shoes
            txtkainfs.Text = bahanbaku.kainfs
            txtosfs.Text = bahanbaku.osfs
            txtbenangfs.Text = bahanbaku.benangfs
            txtisfs.Text = bahanbaku.isfs

        End If
    End Sub
End Class
