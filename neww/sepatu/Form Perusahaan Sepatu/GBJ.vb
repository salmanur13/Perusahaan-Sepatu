Public Class GBJ
    Dim Penyimpanan As New Penyimpanan
    Dim jenis As String
    Dim jumlahKS, jumlahKH, jumlahMS, jumlahMH As Integer
    Dim jmlS, jmlH As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListView1.Items.Clear()
        '    For Each entry In Penyimpanan.dataJadi
        '   ListView1.Items.Add(New ListViewItem(New String() {entry.jenisProduksi, entry.jumlprod}))
        '  Next
        For Each entry In Penyimpanan.dataLogistik
            jenis = entry.JenisSepatu
            If jenis = "Sneakers" Then
                jumlahKS = entry.JumlahPesanan
            ElseIf jenis = "Heels" Then
                jumlahKH = entry.JumlahPesanan
            End If
        Next
        For Each barangmasuk In Penyimpanan.dataJadi
            jenis = barangmasuk.jenprod
            If jenis = "Sneakers" Then
                jumlahMS = barangmasuk.jumlprod
            ElseIf jenis = "Heels" Then
                jumlahMH = barangmasuk.jumlprod
            End If
        Next

        ListView1.Items.Add(New ListViewItem(New String() {jumlahMS - jumlahKS, jumlahMH - jumlahKH}))
        ListView2.Items.Clear()
        For Each barangjadi In Penyimpanan.dataJadi
            jenis = barangjadi.jenprod
            If jenis = "Sneakers" Then
                jmlS = barangjadi.jumlprod
            ElseIf jenis = "Heels" Then
                jmlH = barangjadi.jumlprod
            End If
        Next
        ListView2.Items.Add(New ListViewItem(New String() {jmlS, jmlH}))
    End Sub
End Class