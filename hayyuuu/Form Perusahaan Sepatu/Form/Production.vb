Public Class Production
    Private Sub btngudangbahanjadi_Click(sender As Object, e As EventArgs) Handles btngudangbahanjadi.Click
        Me.Hide()
        '     Form3Gudangbahanbaku
        '    Gudang_Bahan_Jadi.Show()
    End Sub
    Private Sub btngudangbahanbaku_Click(sender As Object, e As EventArgs) Handles btngudangbahanbaku.Click
        Me.Hide()
        '    Gudang_Bahan_Baku.Show()
    End Sub
    '  Public CBom As New Form2BOM
    Public Sneakers, Flatshoes, Heels As Integer
    Private Sub Production_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlihatdata_Click(sender As Object, e As EventArgs) Handles btnlihatdata.Click
        LvDisplay.Items.Add(New ListViewItem(New String() {Tanggal.Text, cbxJenis.Text, txtJumlah.Text}))
    End Sub
    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        bahanbaku.jenis = cbxJenis.Text
        bahanbaku.model()
        txtJumlah.Text = bahanbaku.jml
        '   If ComboBoxJenis.Text = "Sneakers" Then

        '   End If
        '     Dim barang As New Barangjadi(cbxJenis.Text, txtJumlah.Text)
        '    Barang.savedata()
    End Sub

    '   Private Sub btnlihatdata_Click(sender As Object, e As EventArgs) Handles btnlihatdata.Click
    '  If cbxJenis.Text = "Sneakers" Then
    '         LvDisplay.Items.Add(New ListViewItem(New String() {Date1.Text, cbxJenis.Text, Sneakers}))
    'ElseIf cbxJenis.Text = "Flatshoes" Then
    '       LvDisplay.Items.Add(New ListViewItem(New String() {Date1.Text, cbxJenis.Text, Flatshoes}))
    'ElseIf cbxJenis.Text = "Heels" Then
    '       LvDisplay.Items.Add(New ListViewItem(New String() {Date1.Text, cbxJenis.Text, Heels}))
    'End If
    'End Sub
    Private Sub btnhapus_Click(sender As Object, e As EventArgs)
        '    Talisn.Clear()
        '   Outsolesn.Clear()
        '  Kainsn.Clear()
        ' Insolesn.Clear()
        'KulitSuedehl.Clear()
        'Kayuhl.Clear()
        'Insolehl.Clear()
        'Resletinghl.Clear()
        'Kainfs.Clear()
        'Outsolefs.Clear()
        'Benangfs.Clear()
        'Insolefs.Clear()
        'txtJumlah.Clear()
    End Sub

End Class