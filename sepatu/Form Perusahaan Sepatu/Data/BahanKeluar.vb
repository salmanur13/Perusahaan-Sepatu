Public Class BahanKeluar
    Public Shared Property tali As String
    Public Shared Property outsole As String
    Public Shared Property insole As String
    Public Shared Property kain As String
    Public Shared Property benang As String
    Public Shared Property kayu As String
    Public Shared Property kulit As String
    Public Shared Property resleting As String

    Public Shared databahan As New List(Of BahanKeluar)

    Sub New(tali As String, outsole As String, insole As String, kain As String, benang As String, kayu As String, kulit As String, resleting As String)
        Me.tali = tali
        Me.outsole = outsole
        Me.insole = insole
        Me.kain = kain
        Me.benang = benang
        Me.kayu = kayu
        Me.kulit = kulit
        Me.resleting = resleting
    End Sub
    Sub savedata()
        'database.Add(New CPesanan (kode,name,address))
        databahan.Add(Me)
    End Sub
End Class
