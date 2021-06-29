Public Class Barangjadi
    Public Shared datajadi As New List(Of Barangjadi)
    Public Property jenprod As String
    Public Property jumlprod As String
    Public Property tanggal As String
    Sub New(tanggal As String, jenprod As String, jumlprod As Integer)
        Me.tanggal = tanggal
        '   Me.sisa = sisa
        Me.jenprod = jenprod
        Me.jumlprod = jumlprod
    End Sub
    Sub savedata()
        'database.Add(New CPesanan (kode,name,address))
        datajadi.Add(Me)
    End Sub

End Class
