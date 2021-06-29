Public Class Logistikk
    Inherits Penyimpanan
    Public Property JenisSepatu As String
    Public Property JumlahPesanan As Integer
    Public Property TujuanPengiriman As String
    Public Property Ongkir As Integer
    Public Property TanggalPengiriman As String
    Public Property TanggalSampai As String
    Public DKIJakarta As String = "DKI JAKARTA"
    Public JawaBarat As String = "Jawa Barat"
    Public JawaTengah As String = "Jawa Tengah"
    Public JawaTimur As String = "Jawa Timur"
    Public DIY As String = "DIY"
    Public KepulauanRiau As String = "Kepulauan Riau"
    Public Sumatra As String = "Sumatra"
    Dim hasil As Pesanan
    Public Shared Tujuan As String
    Public Shared rega As Integer
    Sub New(JenisSepatu As String, JumlahPesanan As Integer, TujuanPengiriman As String, Ongkir As Integer, TanggalPengiriman As String, TanggalSampai As String)
        Me.JenisSepatu = JenisSepatu
        Me.JumlahPesanan = JumlahPesanan
        '  Me.Ongkir = Ongkir
        Me.TujuanPengiriman = TujuanPengiriman
        Me.Ongkir = Ongkir
        Me.TanggalPengiriman = TanggalPengiriman
        Me.TanggalSampai = TanggalSampai
    End Sub
    Public Shared Sub ONGKIRR()
        If Tujuan = "DKI JAKARTA" Then
            rega = "8000"
        End If
        If Tujuan = "JAWA BARAT" Then
            rega = "11000"
        End If
        If Tujuan = "JAWA TENGAH" Then
            rega = "16000"
        End If
        If Tujuan = "JAWA TIMUR" Then
            rega = "17000"
        End If
        If Tujuan = "DIY" Then
            rega = "16000"
        End If
        If Tujuan = "KEPULAUAN RIAU" Then
            rega = "35000"
        End If
        If Tujuan = "SUMATRA" Then
            rega = "37000"
        End If
    End Sub
End Class
