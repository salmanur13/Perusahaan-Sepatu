Public Class DataLogistik
    Public Shared dataPesanan As New List(Of Pesanan)
    Public Shared datalogistik As New List(Of DataLogistik)
    Public Property JenisSepatu As String
    Public Property JumlahPesanan As Integer
    Public Property TujuanPengiriman As String
    Public Property Ongkir As Integer
    Public Property TanggalPengiriman As String
    Public Property TanggalSampai As String
    Dim hasil As Pesanan
    Sub New(JenisSepatu As String, JumlahPesanan As Integer, TujuanPengiriman As String, Ongkir As Integer, TanggalPengiriman As String, TanggalSampai As String)
        Me.JenisSepatu = JenisSepatu
        Me.JumlahPesanan = JumlahPesanan
        Me.Ongkir = Ongkir
        Me.TujuanPengiriman = TujuanPengiriman
        Me.Ongkir = Ongkir
        Me.TanggalPengiriman = TanggalPengiriman
        Me.TanggalSampai = TanggalSampai
    End Sub
    Function getPesananByName(name As String)
        For Each entry In dataPesanan
            If entry.Nama = name Then
                hasil = entry
            End If
        Next
        Return hasil
    End Function
    Sub savedata()
        datalogistik.Add(Me)
    End Sub
    Sub saveLogistik(entry As DataLogistik)
        datalogistik.Add(entry)
    End Sub
End Class
