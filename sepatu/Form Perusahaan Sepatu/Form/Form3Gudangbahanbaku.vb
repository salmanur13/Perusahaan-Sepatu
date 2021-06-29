Public Class Form3Gudangbahanbaku
    Dim stoktali, stokoutsole, stokinsole, stokkain, stokbenang, stokkayu, stokkulit, stokresleting As Integer
    Public Shared tali, outsole, insole, kain, benang, kayu, kulit, resleting As Integer
    Public Shared taliK, outsoleK, insoleK, kainK, benangK, kayuK, kulitK, resletingK As Integer
    Private Sub Form3Gudangbahanbaku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'bahan yang dibutuhkan
        'bahan dari bom - bahan dari produksi
        ListView4.Items.Clear()
        tali = Bahanbaku.talisnk - Convert.ToInt32(BahanKeluar.tali)
        outsole = Convert.ToInt32(Bahanbaku.osfs) + Convert.ToInt32(Bahanbaku.ossnk) + Convert.ToInt32(BahanKeluar.outsole)
        insole = Convert.ToInt32(Bahanbaku.isfs) + Convert.ToInt32(Bahanbaku.ishls) + Convert.ToInt32(Bahanbaku.issnk) + Convert.ToInt32(BahanKeluar.insole)
        kain = Convert.ToInt32(Bahanbaku.kainfs) + Convert.ToInt32(Bahanbaku.kainsnk) + Convert.ToInt32(BahanKeluar.kain)
        benang = Convert.ToInt32(Bahanbaku.benangfs) + Convert.ToInt32(BahanKeluar.benang)
        kayu = Convert.ToInt32(Bahanbaku.kayuhls) + Convert.ToInt32(BahanKeluar.kayu)
        kulit = Convert.ToInt32(Bahanbaku.kulithls) + Convert.ToInt32(BahanKeluar.kulit)
        resleting = Convert.ToInt32(Bahanbaku.reshls) + Convert.ToInt32(BahanKeluar.resleting)

        ListView4.Items.Add(New ListViewItem(New String() {tali, outsole, insole, kain, benang, kayu, kulit, resleting}))

        'stok = stok awal + hasil dari purchasing - hasil dari produksi
        'bahan yang dibutuhkan-bahan produksi
        'SA = Stok Awal
        ListView3.Items.Clear()
        Dim SA As Integer
        SA = 10
        stoktali = SA + Convert.ToInt32(Bahanbaku.tali) - Convert.ToInt32(BahanKeluar.tali)
        stokoutsole = SA + Convert.ToInt32(Bahanbaku.outsole) + Convert.ToInt32(BahanKeluar.outsole)
        stokinsole = SA + Convert.ToInt32(Bahanbaku.insole) + Convert.ToInt32(BahanKeluar.insole)
        stokkain = SA + Convert.ToInt32(Bahanbaku.kain) + Convert.ToInt32(BahanKeluar.kain)
        stokbenang = SA + Convert.ToInt32(Bahanbaku.benang) + Convert.ToInt32(BahanKeluar.benang)
        stokkayu = SA + Convert.ToInt32(Bahanbaku.kayu) + Convert.ToInt32(BahanKeluar.kayu)
        stokkulit = SA + Convert.ToInt32(Bahanbaku.kulit) + Convert.ToInt32(BahanKeluar.kulit)
        stokresleting = SA + Convert.ToInt32(Bahanbaku.resleting) + Convert.ToInt32(BahanKeluar.resleting)
        ListView3.Items.Add(New ListViewItem(New String() {stoktali, stokoutsole, stokinsole, stokkain, stokbenang, stokkayu, stokkulit, stokresleting}))
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'refresh
        ListView4.Items.Clear()
        tali = Bahanbaku.talisnk - Convert.ToInt32(BahanKeluar.tali)
        outsole = Convert.ToInt32(Bahanbaku.osfs) + Convert.ToInt32(Bahanbaku.ossnk) + Convert.ToInt32(BahanKeluar.outsole)
        insole = Convert.ToInt32(Bahanbaku.isfs) + Convert.ToInt32(Bahanbaku.ishls) + Convert.ToInt32(Bahanbaku.issnk) + Convert.ToInt32(BahanKeluar.insole)
        kain = Convert.ToInt32(Bahanbaku.kainfs) + Convert.ToInt32(Bahanbaku.kainsnk) + Convert.ToInt32(BahanKeluar.kain)
        benang = Convert.ToInt32(Bahanbaku.benangfs) + Convert.ToInt32(BahanKeluar.benang)
        kayu = Convert.ToInt32(Bahanbaku.kayuhls) + Convert.ToInt32(BahanKeluar.kayu)
        kulit = Convert.ToInt32(Bahanbaku.kulithls) + Convert.ToInt32(BahanKeluar.kulit)
        resleting = Convert.ToInt32(Bahanbaku.reshls) + Convert.ToInt32(BahanKeluar.resleting)

        ListView4.Items.Add(New ListViewItem(New String() {tali, outsole, insole, kain, benang, kayu, kulit, resleting}))


        'stok = stok awal + hasil dari purchasing - hasil dari produksi
        'bahan yang dibutuhkan-bahan produksi
        'SA = Stok Awal
        ListView3.Items.Clear()
        Dim SA As Integer
        SA = 10
        stoktali = SA + Convert.ToInt32(Bahanbaku.tali) - Convert.ToInt32(BahanKeluar.tali)
        stokoutsole = SA + Convert.ToInt32(Bahanbaku.outsole) + Convert.ToInt32(BahanKeluar.outsole)
        stokinsole = SA + Convert.ToInt32(Bahanbaku.insole) + Convert.ToInt32(BahanKeluar.insole)
        stokkain = SA + Convert.ToInt32(Bahanbaku.kain) + Convert.ToInt32(BahanKeluar.kain)
        stokbenang = SA + Convert.ToInt32(Bahanbaku.benang) + Convert.ToInt32(BahanKeluar.benang)
        stokkayu = SA + Convert.ToInt32(Bahanbaku.kayu) + Convert.ToInt32(BahanKeluar.kayu)
        stokkulit = SA + Convert.ToInt32(Bahanbaku.kulit) + Convert.ToInt32(BahanKeluar.kulit)
        stokresleting = SA + Convert.ToInt32(Bahanbaku.resleting) + Convert.ToInt32(BahanKeluar.resleting)
        ListView3.Items.Add(New ListViewItem(New String() {stoktali, stokoutsole, stokinsole, stokkain, stokbenang, stokkayu, stokkulit, stokresleting}))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'bahan yang kurang
        'tali = bahan dari bom - bahan dari produksi
        'stok = 'bahan yang dibutuhkan-bahan produksi
        'kain kayu

        '   If stok yang ada > bahan yang dibutuhkan maka bahan kurang = 0
        '   If stok yang ada < bahan yang dibutuhkan maka bahan kurang = bahan yang dibutuhkan-stok
        ListView2.Items.Clear()
        If tali < stoktali Then
            taliK = 0
        Else taliK = Convert.ToInt32(tali) - Convert.ToInt32(stoktali)
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
        Else kayuK = Convert.ToInt32(kayu) - Convert.ToInt32(stokkayu)
        End If
        If kulit < stokkulit Then
            kulitK = 0
        Else kulitK = Convert.ToInt32(kulit) - Convert.ToInt32(stokkulit)
        End If
        If resleting < stokresleting Then
            resletingK = 0
        Else resletingK = Convert.ToInt32(resleting) - Convert.ToInt32(stokresleting)
        End If
        ListView2.Items.Add(New ListViewItem(New String() {taliK, outsoleK, insoleK, kainK, benangK, kayuK, kulitK, resletingK}))
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4Purchasing.Show()
        Me.Hide()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FormProduction.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_Utama.Show()
        Me.Hide()
    End Sub
End Class