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
        Dim belibahan As New Bahanbaku(qs1.Text, qs2.Text, qs3.Text, qs4.Text, qs5.Text, qs6.Text, qs7.Text, qs8.Text)
        belibahan.savedata()
        ListView1.Items.Clear()
        For Each belibahan In Bahanbaku.databahan
            ListView1.Items.Add(New ListViewItem(New String() {tanggal, TxtKodePurs.Text, Bahanbaku.tali, Bahanbaku.outsole, Bahanbaku.kain, Bahanbaku.insole, Bahanbaku.kulit, Bahanbaku.kayu, Bahanbaku.resleting, Bahanbaku.benang}))
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
End Class

