Public Class Pesanan
    Public Shared dataPesanan As New List(Of Pesanan)
    Public Property Kode As String
    Public Property Nama As String
    Public Property Tanggal As String
    Public Property Alamat As String
    Public Property No As String
    Public Property WarnaPesanan As String
    Public Property MerkPesanan As String
    Public Property UkuranPesanan As String
    Public Property ItemPesanan As String
    Public Property JumlahPesanan As Integer
    Public Property pV As String
    Public Property pA As String
    Public Property pN As String
    Public Property totalbarang As Integer
    Public Property Flatshoes As String
    Dim hasil As Pesanan

    Sub New(code As String, name As String, Tgl As String, number As String, address As String, Merk As String, Warna As String, Ukuran As String, jumlah As String, tpV As String, tpA As String, tpN As String)
        Kode = code
        Nama = name
        Tanggal = Tgl
        No = number
        Alamat = address
        MerkPesanan = Merk
        WarnaPesanan = Warna
        UkuranPesanan = Ukuran
        ItemPesanan = Merk & "," & Warna & "," & Ukuran

        JumlahPesanan = jumlah
        pV = tpV
        pA = tpA
        pN = tpN
    End Sub

    Sub savedata()
        'database.Add(New CPesanan (kode,name,address))
        dataPesanan.Add(Me)
    End Sub
    Function getPesananByName(Nama As String)
        For Each entry In dataPesanan
            If entry.Nama = Nama Then
                hasil = entry
            End If
        Next
        Return hasil
    End Function
End Class
