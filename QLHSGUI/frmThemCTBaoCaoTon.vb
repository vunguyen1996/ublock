Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmThemCTBaoCaoTon
    Private sachBus As SachBUS
    Private ctbaocaotonBus As CTBaoCaoTonBUS


    Private listSach As List(Of SachDTO)
    Private sach As SachDTO
    Private listBaoCaoTon As List(Of BaoCaoTonDTO)
    Private loaiSach As LoaiSachDTO
    Private baocaoton As BaoCaoTonDTO

    Private Sub frmThemCTBaoCaoTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctbaocaotonBus = New CTBaoCaoTonBUS()
        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = ctbaocaotonBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaCTBCT.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của chi tiết báo cáo tồn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub loadlistBaoCaoTon(maBaoCao As String)
        Dim baocaotonBus = New BaoCaoTonBUS()
        Dim listBaoCao = New List(Of BaoCaoTonDTO)
        Dim result = baocaotonBus.selectAll_byMaBaoCaoTon(maBaoCao, listBaoCao)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        baocaoton = listBaoCao(0)
        dtpThangBaoCaoTon.Value = baocaoton.ThangBaoCao
    End Sub

    Private Sub loadListSach(maSach As String)
        Dim sachBus = New SachBUS()
        Dim listSach = New List(Of SachDTO)
        Dim result = sachBus.selectALL_ByMaSach(maSach, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        sach = listSach(0)
        txtTenSach.Text = sach.TenSach
        txtTacGia.Text = sach.TacGia
        txtTheLoai.Text = sach.MaLoaiSach
    End Sub

    Private Sub loadlistLoaiSach(maLoai As String)
        Dim loaisachBus = New LoaiSachBUS()
        Dim listLoai = New List(Of LoaiSachDTO)
        Dim result = loaisachBus.selectAll_ByMaLoaiSach(maLoai, listLoai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin loại sách thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        loaiSach = listLoai(0)
        txtTheLoai.Text = loaiSach.TenLoaiSach
    End Sub

    Private Sub txtMaSach_TextChanged(sender As Object, e As EventArgs) Handles txtMaSach.TextChanged
        Try
            Dim maSach = txtMaSach.Text
            loadListSach(maSach)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMaBaoCaoTon_TextChanged(sender As Object, e As EventArgs) Handles txtMaBaoCaoTon.TextChanged
        Try
            Dim maBC = txtMaBaoCaoTon.Text
            loadlistBaoCaoTon(maBC)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTheLoai_TextChanged(sender As Object, e As EventArgs) Handles txtTheLoai.TextChanged
        Try
            Dim maLoai = txtTheLoai.Text
            loadlistLoaiSach(maLoai)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btThemCTBCT_Click(sender As Object, e As EventArgs) Handles btThemCTBCT.Click
        Dim ctbct As CTBaoCaoTonDTO
        ctbct = New CTBaoCaoTonDTO()

        '1. Mapping data from GUI control
        ctbct.MaChiTietBaoCaoTon = txtMaCTBCT.Text
        ctbct.MaSach = txtMaSach.Text
        ctbct.MaBaoCaoTon = txtMaBaoCaoTon.Text
        ctbct.TonDau = txtTonDau.Text
        ctbct.PhatSinh = txtPhatSinh.Text
        ctbct.TonCuoi = txtTonCuoi.Text
        '2. Business .....
        '3. Insert to DB
        Dim result = ctbaocaotonBus.insert(ctbct)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm báo cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Get Next ID
            Dim nextID As Integer
            result = ctbaocaotonBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaCTBCT.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Thêm báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class