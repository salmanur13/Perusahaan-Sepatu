Public Class Logistik
    Public Shared dataPesanan As New List(Of Pesanan)
    Public Shared datalogistik As New List(Of Logistik)
    Public Property JenisSepatu As String
    Public Property JumlahPesanan As Integer
    Public Property TujuanPengiriman As String
    Public Property Ongkir As Integer
    Public Property TanggalPengiriman As String
    Public Property TanggalSampai As String
    Public Shared tujuan, biaya As String
    Public Shared S, H, F, jml, jenis As Double
    Public Shared Sub ongkoskirim()
        If tujuan = "DKI JAKARTA" Then
            biaya = "10000"
        ElseIf tujuan = "JAWA BARAT" Then
            biaya = "10000"
        ElseIf tujuan = "JAWA TENGAH" Then
            biaya = "10000"
        ElseIf tujuan = "JAWA TIMUR" Then
            biaya = "10000"
        ElseIf tujuan = "DIY" Then
            biaya = "10000"
        ElseIf tujuan = "KEPULAUAN RIAU" Then
            biaya = "10000"
        ElseIf tujuan = "SUMATRA" Then
            biaya = "10000"
        End If
    End Sub
    Sub New(JenisSepatu As String, JumlahPesanan As Integer, TujuanPengiriman As String, Ongkir As Integer, TanggalPengiriman As String, TanggalSampai As String)
        Me.JenisSepatu = JenisSepatu
        Me.JumlahPesanan = JumlahPesanan
        '  Me.Ongkir = Ongkir
        Me.TujuanPengiriman = TujuanPengiriman
        Me.Ongkir = Ongkir
        Me.TanggalPengiriman = TanggalPengiriman
        Me.TanggalSampai = TanggalSampai
    End Sub
    Sub savedata()
        datalogistik.Add(Me)
    End Sub
End Class
