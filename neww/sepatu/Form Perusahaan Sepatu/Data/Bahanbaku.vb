Public Class Bahanbaku
    Public Shared databahan As New List(Of Bahanbaku)
    Public Shared jenis, kode As String
    Public Shared S, H, F, jml As Double
    Public Shared talisnk, ossnk, kainsnk, issnk, kulithls, kayuhls, reshls, ishls, kainfs, osfs, benangfs, isfs As Integer
    Public Shared tali, outsole, insole, kain, benang, kayu, kulit, resleting As String
    '  Public Shared tali2, outsole2, insole2 As Integer
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
    Sub New(qs1 As String, qs2 As String, qs3 As String, qs4 As String, qs5 As String, qs6 As String, qs7 As String, qs8 As String)
        tali = qs1
        outsole = qs2
        insole = qs3
        kain = qs4
        benang = qs5
        kayu = qs6
        kulit = qs7
        resleting = qs8
    End Sub
    Sub savedata()
        'database.Add(New CPesanan (kode,name,address))
        databahan.Add(Me)
    End Sub
End Class
