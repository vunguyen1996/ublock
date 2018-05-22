Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmThemCTHoaDon
    Private cthdBus As CTHoaDonBUS
    Private sachBus As SachBUS
    Private hoadonBus As HoaDonBUS

    Private hoadon As HoaDonDTO
    Private sach As SachDTO
    Private khachhang As KhachHangDTO
    Private loaisach As LoaiSachDTO
    Private quydinh As QuyDinhDTO

    Private Sub frmThemCTHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cthdBus = New CTHoaDonBUS()
        sachBus = New SachBUS()
        hoadonBus = New HoaDonBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = cthdBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaCTHD.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của chi tiết hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub loadlistHD_byMaHD(maHD As String)
        Dim hdBus = New HoaDonBUS()
        Dim listHD = New List(Of HoaDonDTO)
        Dim result = hdBus.selectAll_ByMaHD(maHD, listHD)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        hoadon = listHD(0)
        dtpNgayLapHD.Value = hoadon.NgayHoaDon
        txtMaKH.Text = hoadon.MaKhachHang
        txtTongTriGiaHD.Text = hoadon.TongTriGia
    End Sub

    Private Sub loadListSach_byMaSach(maSach As String)
        Dim sachBus = New SachBUS()
        Dim listSach = New List(Of SachDTO)
        Dim result = sachBus.selectALL_ByMaSach(maSach, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        sach = listSach(0)
        txtSoLuongTon.Text = sach.SoLuongTon
        txtTenSach.Text = sach.TenSach
        txtTacGia.Text = sach.TacGia
        txtTheLoai.Text = sach.MaLoaiSach
    End Sub

    Private Sub loadListKhachHang_ByMaKH(maKH As String)
        Dim khBus = New KhachHangBUS()
        Dim listKH = New List(Of KhachHangDTO)
        Dim result = khBus.selectALL_ByType(maKH, listKH)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin khách hàng theo mã khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        khachhang = listKH(0)
        txtHoTenKH.Text = khachhang.TenKhachHang
        txtDiaChi.Text = khachhang.DiaChiKH
        txtEmail.Text = khachhang.Email
        txtSDT.Text = khachhang.SDT
        txtTienNo.Text = khachhang.TienNoKH
    End Sub

    Private Sub loadlistLoaiSach_byMaLoaiSach(maLoai As String)
        Dim loaisachBus = New LoaiSachBUS()
        Dim listLoai = New List(Of LoaiSachDTO)
        Dim result = loaisachBus.selectAll_ByMaLoaiSach(maLoai, listLoai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin loại sách thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        loaisach = listLoai(0)
        txtTheLoai.Text = loaisach.TenLoaiSach
    End Sub

    Private Sub loadQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qdBus = New QuyDinhBUS()
        Dim listQuyDinh = New List(Of QuyDinhDTO)
        Dim result = qdBus.selectALL(listQuyDinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        quydinh = listQuyDinh(0)
        txtLuongTonToiThieu.Text = quydinh.LuongTonToiThieu
    End Sub

    Private Sub txtMaHD_TextChanged(sender As Object, e As EventArgs) Handles txtMaHD.TextChanged
        Try
            Dim maHD = txtMaHD.Text
            loadlistHD_byMaHD(maHD)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMaSach_TextChanged(sender As Object, e As EventArgs) Handles txtMaSach.TextChanged
        Try
            Dim maSach = txtMaSach.Text
            loadListSach_byMaSach(maSach)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMaKH_TextChanged(sender As Object, e As EventArgs) Handles txtMaKH.TextChanged
        Try
            Dim maKH = txtMaKH.Text
            loadListKhachHang_ByMaKH(maKH)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTheLoai_TextChanged(sender As Object, e As EventArgs) Handles txtTheLoai.TextChanged
        Try
            Dim maLoai = txtTheLoai.Text
            loadlistLoaiSach_byMaLoaiSach(maLoai)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDonGia_TextChanged(sender As Object, e As EventArgs) Handles txtDonGia.TextChanged
        Dim soluongban = Convert.ToInt32(txtSoLuongBan.Text)
        Dim dongia = Convert.ToInt32(txtDonGia.Text)
        Dim thanhtien = (soluongban * dongia)
        txtThanhTien.Text = Convert.ToInt32(thanhtien)
    End Sub

    Private Sub btThemCTHD_Click(sender As Object, e As EventArgs) Handles btThemCTHD.Click
        Dim cthd As CTHoaDonDTO
        cthd = New CTHoaDonDTO()

        Dim tongTriGia = Convert.ToInt32(txtTongTriGiaHD.Text)
        Dim thanhtien = Convert.ToInt32(txtThanhTien.Text)
        Dim tongtrigiaUpdate = Convert.ToInt32(tongTriGia + thanhtien)
        txtTongTriGiaHD.Text = Convert.ToInt32(tongtrigiaUpdate)

        Dim soluongton = Convert.ToInt32(txtSoLuongTon.Text)
        Dim soluongban = Convert.ToInt32(txtSoLuongBan.Text)


        '1. Mapping data from GUI control
        cthd.MaChiTietHD = Convert.ToInt32(txtMaCTHD.Text)
        cthd.MaHD = Convert.ToInt32(txtMaHD.Text)
        cthd.MaSach = Convert.ToInt32(txtMaSach.Text)
        cthd.SoLuongBan = txtSoLuongBan.Text
        cthd.DonGia = txtDonGia.Text
        cthd.ThanhTien = txtThanhTien.Text
        '2. Business .....
        '3. Insert to DB
        Dim luongtontoithieu = Convert.ToInt32(txtLuongTonToiThieu.Text)
        If (soluongton >= luongtontoithieu) Then
            txtSoLuongTon.Text = soluongton - soluongban
            Dim result As Result
            result = cthdBus.insert(cthd)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm chi tiết hóa đơn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Get Next ID
                Dim nextID As Integer
                result = cthdBus.getNextID(nextID)
                If (result.FlagResult = True) Then
                    txtMaCTHD.Text = nextID.ToString()
                Else
                    MessageBox.Show("Lấy ID kế tiếp của chi tiết hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Else
                MessageBox.Show("Thêm chi tiết hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Thêm chi tiết hóa đơn không thành công do số lượng tồn bé hơn quy định.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btUpdateSoLuongTonSauKhiBan_Click(sender As Object, e As EventArgs) Handles btThemCTHD.Click
        Try
            Dim sach As SachDTO
            sach = New SachDTO()

            '1. Mapping data from GUI control
            sach.MaSach = txtMaSach.Text
            sach.SoLuongTon = txtSoLuongTon.Text
            '2. Business .....
            '3. Insert to DB
            Dim result As Result
            result = sachBus.update_SoLuongTon(sach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật số lượng tồn của sách sau khi bán không thành công")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Private Sub btUpdateTriGiaHoaDon_Click(sender As Object, e As EventArgs) Handles btThemCTHD.Click
        Try
            Dim hoadon As HoaDonDTO
            hoadon = New HoaDonDTO()

            hoadon.MaHoaDon = txtMaHD.Text
            hoadon.TongTriGia = txtTongTriGiaHD.Text

            Dim result As Result
            result = hoadonBus.update_TriGiaHoaDon(hoadon)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật tổng trị giá hóa đơn không thành công")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class