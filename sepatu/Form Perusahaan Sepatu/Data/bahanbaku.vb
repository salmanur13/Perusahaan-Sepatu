Public Class bahanbaku
    Public Shared bhnbaku As New List(Of bahanbaku)
    Public Shared bahansnk As New List(Of bahanbaku)
    Public Shared bahanhls As New List(Of bahanbaku)
    Public Shared bahanfs As New List(Of bahanbaku)
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
    Sub Simpanbahansnk()
        bahansnk.Add(Me)
    End Sub
    Sub Simpanbahanhls()
        bahanhls.Add(Me)
    End Sub
    Sub Simpanbahanfs()
        bahanfs.Add(Me)
    End Sub
End Class

