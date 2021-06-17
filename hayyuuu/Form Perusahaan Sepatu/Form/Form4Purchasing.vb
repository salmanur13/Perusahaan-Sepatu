Public Class Form4Purchasing
    Dim kode As Integer
    Public tanggal As Date = Now
    Dim beliTali, beliOs As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qs1.Text = Form3Gudangbahanbaku.taliK
        qs2.Text = Form3Gudangbahanbaku.outsoleK
        hs1.Text = 10000
        hs2.Text = 25000
    End Sub

    Private Sub btnlview_Click(sender As Object, e As EventArgs) Handles btnlview.Click
        Dim belibahan As New bahanbaku(qs1.Text, qs2.Text, qs3.Text, qs4.Text, qs5.Text, qs6.Text, qs7.Text, qs8.Text)
        belibahan.savedata()
        ListView1.Items.Clear()
        For Each belibahan In bahanbaku.databahan
            ListView1.Items.Add(New ListViewItem(New String() {tanggal, TxtKodePurs.Text, bahanbaku.tali, bahanbaku.outsole, bahanbaku.kain, bahanbaku.insole, bahanbaku.kulit, bahanbaku.kayu, bahanbaku.resleting, bahanbaku.benang}))
        Next
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Form3Gudangbahanbaku.Show()
    End Sub

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        beliTali = Convert.ToInt32(qs1.Text) * Convert.ToInt32(hs1.Text)
        beliOs = Convert.ToInt32(qs2.Text) * Convert.ToInt32(hs2.Text)
        txttot.Text = Convert.ToInt32(beliTali) + Convert.ToInt32(beliOs)

    End Sub
    '   Private Sub Purchasing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '   End Sub
    '  Public CB As New CBom
    ' Public CHarga As New CHarga
    'Public tot1, tot2, tot3, tot4 As Double
    ' Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
    '    kode = kode + 1
    '   TxtKodePurs.Text = "PUR" & Format(tanggal, "ddMMyy") & Format(kode, "000")
    '  Date1PUR.Text = DateAdd("d", 2, Pemesanan.Date1Pemesanan.Text)


    'Private Sub btnIview_Click(sender As Object, e As EventArgs) Handles btnIview.Click
    '       ListView1.Items.Add(New ListViewItem(New String() {TxtKodePurs.Text, Date1PUR.Text, qdin1.Text, qdin2.Text, qdin3.Text, qdin4.Text, qrod1.Text, qrod2.Text, qrod3.Text, qrod4.Text, qbod1.Text, qbod2.Text, qbod3.Text, qbod4.Text}))
    'End Sub
    ' Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '   Me.Hide()
    '  Gudang_Bahan_Baku.Show()
    '  End Sub

End Class

