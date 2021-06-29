Public Class Bahanbaku
    Public Shared databahan As New List(Of Bahanbaku)
    Public Shared Property tali As String
    Public Shared Property outsole As String
    Public Shared Property insole As String
    Public Shared Property kain As String
    Public Shared Property benang As String
    Public Shared Property kayu As String
    Public Shared Property kulit As String
    Public Shared Property resleting As String

    Public Shared jenis, kode As String
    Public Shared S, H, F, jml As Double
    Public Shared talisnk, ossnk, kainsnk, issnk, kulithls, kayuhls, reshls, ishls, kainfs, osfs, benangfs, isfs As Integer
    Public Shared Sub model()
        If jenis = "Sneakers" Then
            kode = "S101"
            S = Form1Pemesan.txtA.Text
            jml = S
            talisnk = (jml * 1)
            ossnk = (jml * 1)
            kainsnk = (jml * 3)
            issnk = (jml * 2)
        ElseIf jenis = "Heels" Then
            kode = "S102"
            H = Form1Pemesan.txtN.Text
            jml = H
            kulithls = (jml * 1)
            kayuhls = (jml * 1)
            reshls = (jml * 1)
            ishls = (jml * 2)
        ElseIf jenis = "Flat Shoes" Then
            kode = "S103"
            F = Form1Pemesan.txtV.Text
            jml = F
            kainfs = (jml * 2)
            osfs = (jml * 1)
            benangfs = (jml * 1)
            isfs = (jml * 2)
        End If
    End Sub
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
