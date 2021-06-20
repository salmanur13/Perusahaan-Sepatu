Public Class Penyimpanan
    Public Shared dataPesanan As New List(Of Pesanan)
    Public Shared neededBahan As New List(Of Bahanbaku) 'save the needed bahan baku
    Public Shared dataBahan As New List(Of Bahanbaku) 'save the real bahan baku
    Public Shared dataJadi As New List(Of Barangjadi) 'save for logistics
    Public Shared dataLogistik As New List(Of Logistik)
    Public Shared Penyimpanan As New List(Of Penyimpanan)
    Sub New()

    End Sub
    Dim hasil As Pesanan
    Dim result As Pesanan
    Sub savePesanan(pesanan As Pesanan)
        dataPesanan.Add(pesanan)
        Debug.WriteLine("BERHASIL")
    End Sub
    Function getPesananByName(name As String)
        For Each entry In dataPesanan
            If entry.Nama = name Then
                result = entry
            End If
        Next
        Return result
    End Function
    Function getPesananByMerk(Merk As String)
        For Each entry In dataPesanan
            If entry.MerkPesanan = Merk Then
                hasil = entry
            End If
        Next
        Return hasil
    End Function
    Sub saveBarangJadi(barang As Barangjadi)
        dataJadi.Add(barang)
    End Sub
    Sub saveLogistik(entry As Logistik)
        dataLogistik.Add(entry)
    End Sub
    Sub saveRequiredBahan(bahan As Bahanbaku) 'bahan yang dibutuhkan
        neededBahan.Add(bahan)
    End Sub
    Sub saveRealBahan(bahan As Bahanbaku)
        dataBahan.Add(bahan)
    End Sub
    Sub savedata()
        Penyimpanan.Add(Me)
    End Sub
End Class
