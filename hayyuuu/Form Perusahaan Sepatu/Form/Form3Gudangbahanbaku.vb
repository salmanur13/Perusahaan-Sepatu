Public Class Form3Gudangbahanbaku
    Dim stoktali, stokoutsole, stokinsole, stokkain, stokbenang, stokkayu, stokkulit, stokresleting As Integer
    Public Shared tali, outsole, insole, kain, benang, kayu, kulit, resleting As Integer
    Public Shared taliK, outsoleK, insoleK, kainK, benangK, kayuK, kulitK, resletingK As Integer

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'stok awal

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'cek stok
        stoktali = Convert.ToInt32(10) + Convert.ToInt32(bahanbaku.tali)
        stokoutsole = Convert.ToInt32(10) + Convert.ToInt32(bahanbaku.outsole)
        '      stokinsole = Convert.ToInt32(10) + Convert.ToInt32(bahanbaku.insole)
        stokkain = 10
        stokbenang = 10
        stokkayu = 10
        stokkulit = 10
        stokresleting = 10
        ListView3.Items.Add(New ListViewItem(New String() {stoktali, stokoutsole, stokinsole, stokkain, stokkayu, stokkulit, stokresleting, stokbenang}))
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'bahan yang kurang
        If tali < stoktali Then
            taliK = 0
        Else taliK = tali - stoktali
        End If

        If outsole < stokoutsole Then
            outsoleK = 0
        Else outsoleK = Convert.ToInt32(outsole) - Convert.ToInt32(stokoutsole)
        End If

        If insole < stokinsole Then
            insoleK = 0
        Else insoleK = Convert.ToInt32(insole) - Convert.ToInt32(stokinsole)
        End If

        If kain < stokkain Then
            kainK = 0
        Else kainK = Convert.ToInt32(kain) - Convert.ToInt32(stokkain)
        End If

        If benang < stokbenang Then
            benangK = 0
        Else benangK = Convert.ToInt32(benang) - Convert.ToInt32(stokbenang)
        End If

        If kayu < stokkayu Then
            kayuK = 0
        Else kainK = Convert.ToInt32(kayu) - Convert.ToInt32(stokkayu)
        End If

        If resleting < stokresleting Then
            resletingK = 0
        Else resletingK = Convert.ToInt32(resleting) - Convert.ToInt32(stokresleting)
        End If

        If kulit < stokkulit Then
            kulitK = 0
        Else kulitK = Convert.ToInt32(kulit) - Convert.ToInt32(stokkulit)
        End If

        ListView2.Items.Add(New ListViewItem(New String() {taliK, outsoleK, insoleK, kainK, benangK, kayuK, kulitK, resletingK}))
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4Purchasing.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'bahan yang dibutuhkan
        tali = bahanbaku.talisnk
        outsole = Convert.ToInt32(bahanbaku.osfs) + Convert.ToInt32(bahanbaku.ossnk)
        insole = Convert.ToInt32(bahanbaku.isfs) + Convert.ToInt32(bahanbaku.ishls) + Convert.ToInt32(bahanbaku.issnk)
        kain = Convert.ToInt32(bahanbaku.kainfs) + Convert.ToInt32(bahanbaku.kainsnk)
        kulit = Convert.ToInt32(bahanbaku.kulithls)
        kayu = Convert.ToInt32(bahanbaku.kayuhls)
        resleting = Convert.ToInt32(bahanbaku.reshls)
        benang = Convert.ToInt32(bahanbaku.benangfs)

        ListView4.Items.Add(New ListViewItem(New String() {tali, outsole, insole, kain, kulit, kayu, resleting, benang}))
    End Sub
End Class