Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmQLCTHoaDon
    Private hoadonBus As HoaDonBUS
    Private cthoadonBus As CTHoaDonBUS

    Private hoadon As HoaDonDTO
    Private loaisach As LoaiSachDTO
    Private sach As SachDTO
    Private khachhang As KhachHangDTO
    Private quydinh As QuyDinhDTO

    Private Sub frmQLCTHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hoadonBus = New HoaDonBUS()
        cthoadonBus = New CTHoaDonBUS()
        Dim listhd = New List(Of HoaDonDTO)
        Dim result As Result
        result = hoadonBus.selectAll(listhd)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        'loadListCTHoaDon()
    End Sub

    Private Sub loadListCTHoaDon()
        Dim listcthd = New List(Of CTHoaDonDTO)
        Dim result As Result
        result = cthoadonBus.selectALL(listcthd)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListCTHD.Columns.Clear()
        dgvListCTHD.DataSource = Nothing

        dgvListCTHD.AutoGenerateColumns = False
        dgvListCTHD.AllowUserToAddRows = False
        dgvListCTHD.DataSource = listcthd

        Dim clMaCTHD = New DataGridViewTextBoxColumn()
        clMaCTHD.Name = "MaChiTietHD"
        clMaCTHD.HeaderText = "Mã Chi Tiết Hóa Đơn"
        clMaCTHD.DataPropertyName = "MaChiTietHD"
        dgvListCTHD.Columns.Add(clMaCTHD)

        Dim clMaHD = New DataGridViewTextBoxColumn()
        clMaHD.Name = "MaHD"
        clMaHD.HeaderText = "Mã Hóa Đơn"
        clMaHD.DataPropertyName = "MaHD"
        dgvListCTHD.Columns.Add(clMaHD)

        Dim clMaSach = New DataGridViewTextBoxColumn()
        clMaSach.Name = "MaSach"
        clMaSach.HeaderText = "Mã Sách"
        clMaSach.DataPropertyName = "MaSach"
        dgvListCTHD.Columns.Add(clMaSach)

        Dim clSLB = New DataGridViewTextBoxColumn()
        clSLB.Name = "SoLuongBan"
        clSLB.HeaderText = "Số Lượng Bán"
        clSLB.DataPropertyName = "SoLuongBan"
        dgvListCTHD.Columns.Add(clSLB)

        Dim clThanhTien = New DataGridViewTextBoxColumn()
        clThanhTien.Name = "ThanhTien"
        clThanhTien.HeaderText = "Thành Tiền"
        clThanhTien.DataPropertyName = "ThanhTien"

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListCTHD.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub loadListCTHoaDon_byMaHD(maHD As Integer)
        Dim listcthd = New List(Of CTHoaDonDTO)
        Dim result As Result
        result = cthoadonBus.selectALL_byMaHD(maHD, listcthd)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListCTHD.Columns.Clear()
        dgvListCTHD.DataSource = Nothing

        dgvListCTHD.AutoGenerateColumns = False
        dgvListCTHD.AllowUserToAddRows = False
        dgvListCTHD.DataSource = listcthd

        Dim clMaCTHD = New DataGridViewTextBoxColumn()
        clMaCTHD.Name = "MaChiTietHD"
        clMaCTHD.HeaderText = "Mã Chi Tiết Hóa Đơn"
        clMaCTHD.DataPropertyName = "MaChiTietHD"
        dgvListCTHD.Columns.Add(clMaCTHD)

        Dim clMaHD = New DataGridViewTextBoxColumn()
        clMaHD.Name = "MaHD"
        clMaHD.HeaderText = "Mã Hóa Đơn"
        clMaHD.DataPropertyName = "MaHD"
        dgvListCTHD.Columns.Add(clMaHD)

        Dim clMaSach = New DataGridViewTextBoxColumn()
        clMaSach.Name = "MaSach"
        clMaSach.HeaderText = "Mã Sách"
        clMaSach.DataPropertyName = "MaSach"
        dgvListCTHD.Columns.Add(clMaSach)

        Dim clSLB = New DataGridViewTextBoxColumn()
        clSLB.Name = "SoLuongBan"
        clSLB.HeaderText = "Số Lượng Bán"
        clSLB.DataPropertyName = "SoLuongBan"
        dgvListCTHD.Columns.Add(clSLB)

        Dim clThanhTien = New DataGridViewTextBoxColumn()
        clThanhTien.Name = "ThanhTien"
        clThanhTien.HeaderText = "Thành Tiền"
        clThanhTien.DataPropertyName = "ThanhTien"

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListCTHD.DataSource)
        myCurrencyManager.Refresh()
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

    Private Sub dgvListCTPhieuNhap_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvListCTHD.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListCTHD.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvChiTietPhieuNhap.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListCTHD.RowCount) Then
            Try
                Dim cthd = CType(dgvListCTHD.Rows(currentRowIndex).DataBoundItem, CTHoaDonDTO)
                txtMaCTHD.Text = cthd.MaChiTietHD
                txtMaSach.Text = cthd.MaSach
                txtSoLuongBan.Text = cthd.SoLuongBan
                txtDonGia.Text = cthd.DonGia
                txtThanhTien.Text = cthd.ThanhTien
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMaHD.TextChanged
        Try
            Dim maHD = txtMaHD.Text
            loadListCTHoaDon_byMaHD(maHD)
            loadlistHD_byMaHD(maHD)
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

    Private Sub txtMaSach_TextChanged(sender As Object, e As EventArgs) Handles txtMaSach.TextChanged
        Try
            Dim maSach = txtMaSach.Text
            loadListSach_byMaSach(maSach)
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
End Class