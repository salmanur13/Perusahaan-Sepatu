Public Class Pesanan
    Public Shared dataPesanan As New List(Of Pesanan)
    Public Property Kode As String 'mendekalrasikan kode sebagai property baru bersifat public ketika sebagai string
    Public Property Nama As String 'mendekalrasikan nama sebagai property baru bersifat public ketika sebagai string
    Public Property Tanggal As String 'mendekalrasikan tanggal sebagai property baru bersifat public ketika sebagai string
    Public Property Deadline As String 'mendekalrasikan Deadline sebagai property baru bersifat public ketika sebagai string
    Public Property Alamat As String 'mendekalrasikan alamat sebagai property baru bersifat public ketika sebagai string
    Public Property No As String 'mendekalrasikan no sebagai property baru bersifat public ketika sebagai string
    Public Property WarnaPesanan As String 'mendekalrasikan  WarnaPesanan sebagai property baru bersifat public ketika sebagai string
    Public Property MerkPesanan As String 'mendekalrasikan MerkPesanan sebagai property baru bersifat public ketika sebagai string
    Public Property UkuranPesanan As String 'mendekalrasikan UkuranPesanan sebagai property baru bersifat public ketika sebagai string
    Public Property ItemPesanan As String 'mendekalrasikan ItemPesanan sebagai property baru bersifat public ketika sebagai string
    Public Property Jumlah As Integer 'mendekalrasikan Jumlahsebagai property baru bersifat public ketika sebagai integer
    Public Property pV As String 'mendekalrasikan pV sebagai property baru bersifat public ketika sebagai string
    Public Property pA As String 'mendekalrasikan pA sebagai property baru bersifat public ketika sebagai string
    Public Property pN As String 'mendekalrasikan pN sebagai property baru bersifat public ketika sebagai string
    Sub New(Kode As String, Nama As String, Tanggal As String, Deadline As String, No As String, Alamat As String, MerkPesanan As String, WarnaPesanan As String, UkuranPesanan As String, jumlah As Integer, tpV As String, tpA As String, tpN As String)
        Me.Jumlah = jumlah
        Me.Kode = Kode
        Me.Nama = Nama
        Me.Tanggal = Tanggal
        Me.Deadline = Deadline
        Me.No = No
        Me.Alamat = Alamat
        Me.MerkPesanan = MerkPesanan
        Me.WarnaPesanan = WarnaPesanan
        Me.UkuranPesanan = UkuranPesanan
        ItemPesanan = MerkPesanan & "," & WarnaPesanan & "," & UkuranPesanan

        '        JumlahPesanan = jumlah
        pV = tpV
        pA = tpA
        pN = tpN
    End Sub
    Sub savedata() 'savedata
        dataPesanan.Add(Me)
    End Sub
End Class
