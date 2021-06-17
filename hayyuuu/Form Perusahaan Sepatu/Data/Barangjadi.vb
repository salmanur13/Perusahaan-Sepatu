Public Class Barangjadi
    Public Shared databarangjadi As New List(Of Barangjadi)
    ' Public sisa As Integer
    Public jenprod As Integer
    Public jumlprod As Integer
    Public Property jenisProduksi As String
    Public Property jumlahProduksi As String
    Sub New(jenprod As Integer, jumlprod As Integer)
        '   Me.sisa = sisa
        Me.jenprod = jenprod
        Me.jumlprod = jumlprod
    End Sub
    'Sub New(jenis, jumlah)
    '   jenisProduksi = jenis
    '  jumlahProduksi = jumlah
    ' End Sub
    Sub savedata()
        'database.Add(New CPesanan (kode,name,address))
        databarangjadi.Add(Me)
    End Sub

End Class
