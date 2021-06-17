Public Class Form_Logistik
    Private Sub btnMenuutama_Click(sender As Object, e As EventArgs) Handles btnMenuutama.Click
        Me.Hide()
        Form_Utama.Show()
    End Sub
    Private Sub comboNameChanged(sender As Object, e As EventArgs) Handles cmbpesanan.SelectedValueChanged
        'Dim pesanan As Pesanan = DataLogistik.getPesananByName(cmbpesanan.SelectedItem.ToString())

    End Sub

    Private Sub btnlihatdata_Click(sender As Object, e As EventArgs) Handles btnlihatdata.Click

    End Sub
End Class
