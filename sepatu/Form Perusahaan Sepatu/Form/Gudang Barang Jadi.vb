Public Class Gudangbarangjadi
    Private Sub btnLogistik_Click(sender As Object, e As EventArgs) Handles btnLogistik.Click
        Me.Hide()
        Form_Logistik.Show()
    End Sub

    Private Sub btnRefres_Click(sender As Object, e As EventArgs) Handles btnRefrsh.Click
        ListView1.Clear()
        For Each entry In BarangJadi.databarangjadi
            ListView1.Items.Add(New ListViewItem(New String() {entry.sisa, entry.jenprod, entry.jumlprod}))
            ListView2.Items.Add(New ListViewItem(New String() {entry.sisa, entry.jenprod, entry.jumlprod}))
        Next
    End Sub
    Private Sub GudangBarangJadi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Items.Clear()
        For Each entry In BarangJadi.databarangjadi
            ListView1.Items.Add(New ListViewItem(New String() {entry.sisa, entry.jenprod, entry.jumlprod}))
            ListView2.Items.Add(New ListViewItem(New String() {entry.sisa, entry.jenprod, entry.jumlprod}))
        Next
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
End Class
