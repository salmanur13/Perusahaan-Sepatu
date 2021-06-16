Public Class Barangjadi
    Public Shared databarangjadi As New List(Of Barangjadi)
    Public sisa As Integer
    Public jenprod As Integer
    Public jumlprod As Integer
    Sub New(sisa As Integer, jenprod As Integer, jumlprod As Integer)
        Me.sisa = sisa
        Me.jenprod = jenprod
        Me.jumlprod = jumlprod
    End Sub
End Class
