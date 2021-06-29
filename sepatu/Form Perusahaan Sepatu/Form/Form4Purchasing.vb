Public Class Form4Purchasing
    '  Dim kode As Integer
    Public tanggal As Date = Now
    Dim beliTali, beliOs, beliKain, beliis, belikulit, belikayu, belires, belibenang As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qs1.Text = Form3Gudangbahanbaku.taliK
        qs2.Text = Form3Gudangbahanbaku.outsoleK
        qs3.Text = Form3Gudangbahanbaku.insoleK
        qs4.Text = Form3Gudangbahanbaku.kainK
        qs5.Text = Form3Gudangbahanbaku.benangK
        qs6.Text = Form3Gudangbahanbaku.kayuK
        qs7.Text = Form3Gudangbahanbaku.kulitK
        qs8.Text = Form3Gudangbahanbaku.resletingK

        hs1.Text = 10000
        hs2.Text = 25000
        hs3.Text = 25000
        hs4.Text = 40000
        hs5.Text = 5000
        hs6.Text = 15000
        hs7.Text = 40000
        hs8.Text = 10000

    End Sub
    Private Sub btnlview_Click(sender As Object, e As EventArgs) Handles btnlview.Click
        Dim belibahan As New Bahanbaku(qs1.Text, qs2.Text, qs3.Text, qs4.Text, qs5.Text, qs6.Text, qs7.Text, qs8.Text)
        belibahan.savedata()
        ListView1.Items.Clear()
        '  For Each belibahan In Bahanbaku.databahan
        ' ListView1.Items.Add(New ListViewItem(New String() {tanggal, TxtKodePurs.Text, belibahan.tali, belibahan.outsole, belibahan.insole, belibahan.kain, belibahan.benang, belibahan.kayu, belibahan.kulit, belibahan.resleting}))
        ' Next
        ListView1.Items.Add(New ListViewItem(New String() {tanggal, TxtKodePurs.Text, Bahanbaku.tali, Bahanbaku.outsole, Bahanbaku.insole, Bahanbaku.kain, Bahanbaku.benang, Bahanbaku.kayu, Bahanbaku.kulit, Bahanbaku.resleting}))
        ' ListView1.Items.Add(New ListViewItem(New String() {tanggal, TxtKodePurs.Text, beliTali, beliOs, beliis, beliKain, belibenang, belikayu, belikulit, belires}))
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Form3Gudangbahanbaku.Show()
    End Sub

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        beliTali = Convert.ToInt32(qs1.Text) * Convert.ToInt32(hs1.Text)
        beliOs = Convert.ToInt32(qs2.Text) * Convert.ToInt32(hs2.Text)
        beliis = Convert.ToInt32(qs3.Text) * Convert.ToInt32(hs3.Text)
        beliKain = Convert.ToInt32(qs4.Text) * Convert.ToInt32(hs4.Text)
        belibenang = Convert.ToInt32(qs5.Text) * Convert.ToInt32(hs5.Text)
        belikayu = Convert.ToInt32(qs6.Text) * Convert.ToInt32(hs6.Text)
        belikulit = Convert.ToInt32(qs7.Text) * Convert.ToInt32(hs7.Text)
        belires = Convert.ToInt32(qs8.Text) * Convert.ToInt32(hs8.Text)

        txttot.Text = Convert.ToInt32(beliTali) + Convert.ToInt32(beliOs) + Convert.ToInt32(beliKain) + Convert.ToInt32(beliis) + Convert.ToInt32(belikulit) + Convert.ToInt32(belikayu) + Convert.ToInt32(belires) + Convert.ToInt32(belibenang)
    End Sub
End Class