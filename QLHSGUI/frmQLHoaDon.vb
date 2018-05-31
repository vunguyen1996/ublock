Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmQLHoaDon
    Private hdBus As HoaDonBUS
    Private khBus As KhachHangBUS

    Private khachhang As KhachHangDTO
    Private listKH As List(Of KhachHangDTO)

    Private Sub frmQLHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hdBus = New HoaDonBUS()
        ' Load list hoa don
        loadlistHoaDon()
    End Sub

    Private Sub loadlistHoaDon()
        ' Load Loaihoadon list
        Dim listhd = New List(Of HoaDonDTO)
        Dim result As Result
        result = hdBus.selectAll(listhd)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListHoaDon.Columns.Clear()
        dgvListHoaDon.DataSource = Nothing

        dgvListHoaDon.AutoGenerateColumns = False
        dgvListHoaDon.AllowUserToAddRows = False
        dgvListHoaDon.DataSource = listhd

        Dim clMaHD = New DataGridViewTextBoxColumn()
        clMaHD.Name = "MaHoaDon"
        clMaHD.HeaderText = "Mã Hóa Đơn"
        clMaHD.DataPropertyName = "MaHoaDon"
        dgvListHoaDon.Columns.Add(clMaHD)

        Dim clMaKH = New DataGridViewTextBoxColumn()
        clMaKH.Name = "MaKhachHang"
        clMaKH.HeaderText = "Mã Khách Hàng"
        clMaKH.DataPropertyName = "MaKhachHang"
        dgvListHoaDon.Columns.Add(clMaKH)

        Dim clNgayHoaDon = New DataGridViewTextBoxColumn()
        clNgayHoaDon.Name = "NgayHoaDon"
        clNgayHoaDon.HeaderText = "Ngày Hóa Đơn"
        clNgayHoaDon.DataPropertyName = "NgayHoaDon"
        dgvListHoaDon.Columns.Add(clNgayHoaDon)

        Dim clTriGia = New DataGridViewTextBoxColumn()
        clTriGia.Name = "TongTriGia"
        clTriGia.HeaderText = "Trị Giá"
        clTriGia.DataPropertyName = "TongTriGia"
        dgvListHoaDon.Columns.Add(clTriGia)
    End Sub

    Private Sub loadlistHoaDon_ByNgayHoaDon(ngayHD As DateTime)
        Dim listhd = New List(Of HoaDonDTO)
        Dim result As Result
        result = hdBus.selectAll_ByNgayHD(ngayHD, listhd)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListHoaDon.Columns.Clear()
        dgvListHoaDon.DataSource = Nothing

        dgvListHoaDon.AutoGenerateColumns = False
        dgvListHoaDon.AllowUserToAddRows = False
        dgvListHoaDon.DataSource = listhd

        Dim clMaHD = New DataGridViewTextBoxColumn()
        clMaHD.Name = "MaHoaDon"
        clMaHD.HeaderText = "Mã Hóa Đơn"
        clMaHD.DataPropertyName = "MaHoaDon"
        dgvListHoaDon.Columns.Add(clMaHD)

        Dim clMaKH = New DataGridViewTextBoxColumn()
        clMaKH.Name = "MaKhachHang"
        clMaKH.HeaderText = "Mã Khách Hàng"
        clMaKH.DataPropertyName = "MaKhachHang"
        dgvListHoaDon.Columns.Add(clMaKH)

        Dim clNgayHoaDon = New DataGridViewTextBoxColumn()
        clNgayHoaDon.Name = "NgayHoaDon"
        clNgayHoaDon.HeaderText = "Ngày Hóa Đơn"
        clNgayHoaDon.DataPropertyName = "NgayHoaDon"
        dgvListHoaDon.Columns.Add(clNgayHoaDon)

        Dim clTriGia = New DataGridViewTextBoxColumn()
        clTriGia.Name = "TongTriGia"
        clTriGia.HeaderText = "Trị Giá"
        clTriGia.DataPropertyName = "TongTriGia"
        dgvListHoaDon.Columns.Add(clTriGia)
    End Sub

    Private Sub loadListKhachHang_ByMaKH(maKH As String)
        khBus = New KhachHangBUS()
        listKH = New List(Of KhachHangDTO)
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

    Private Sub dgvListHoaDon_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListHoaDon.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListHoaDon.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHoaDon.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListHoaDon.RowCount) Then
            Try
                Dim hd = CType(dgvListHoaDon.Rows(currentRowIndex).DataBoundItem, HoaDonDTO)
                txtMaHD.Text = hd.MaHoaDon
                dtpNgayLapHD.Value = hd.NgayHoaDon
                txtMaKH.Text = hd.MaKhachHang
                txtTriGia.Text = hd.TongTriGia
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btXoaHoaDon.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListHoaDon.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListHoaDon.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa hóa đơn có mã phiếu là  " + txtMaHD.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = hdBus.delete(txtMaHD.Text)
                        If (result.FlagResult = True) Then
                            ' Re-Load LoaiHocSinh list
                            loadlistHoaDon()
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListHoaDon.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListHoaDon.Rows(currentRowIndex).Selected = True
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListHoaDon.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim hoadon = CType(dgvListHoaDon.Rows(currentRowIndex).DataBoundItem, HoaDonDTO)
                                    txtMaHD.Text = hoadon.MaHoaDon
                                    dtpNgayLapHD.Value = hoadon.NgayHoaDon
                                    txtMaKH.Text = hoadon.MaKhachHang
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa hóa đơn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select
        End If
    End Sub

    Private Sub txtMaKH_TextChanged(sender As Object, e As EventArgs) Handles txtMaKH.TextChanged
        Try
            Dim maKH = txtMaKH.Text
            loadListKhachHang_ByMaKH(maKH)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpNgayHDTimKiem_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayHDTimKiem.ValueChanged
        Try
            Dim ngayHD = dtpNgayHDTimKiem.Value.ToShortDateString
            loadlistHoaDon_ByNgayHoaDon(ngayHD)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCapNhatHD_Click(sender As Object, e As EventArgs) Handles btCapNhatHD.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListHoaDon.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListHoaDon.RowCount) Then
            Try
                Dim hoadon As HoaDonDTO
                hoadon = New HoaDonDTO()
                '1. Mapping data from GUI control
                hoadon.NgayHoaDon = dtpNgayLapHD.Value.ToShortDateString
                hoadon.TongTriGia = txtTriGia.Text
                hoadon.MaHoaDon = Convert.ToInt32(txtMaHD.Text)
                '2. Business .....
                '3. Insert to DB
                Dim result As Result
                result = hdBus.update(hoadon)
                If (result.FlagResult = True) Then
                    ' Re-Load sach list
                    'loadListSach_ByMaLoaiSach(cbbLoaiSach.SelectedValue)
                    loadlistHoaDon()
                    ' Hightlight the row has been updated on table
                    dgvListHoaDon.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật hóa đơn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
End Class