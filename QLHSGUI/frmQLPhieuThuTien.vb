Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmQLPhieuThuTien
    Private phieuThuBus As PhieuThuTienBUS
    Private khBus As KhachHangBUS
    Private qdBus As QuyDinhBUS

    Private listKH As List(Of KhachHangDTO)
    Private listQD As List(Of QuyDinhDTO)
    Private khachhang As KhachHangDTO

    Private Sub frmQLPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieuThuBus = New PhieuThuTienBUS()
        khBus = New KhachHangBUS()
        qdBus = New QuyDinhBUS()

        Dim listPhieuThuTien = New List(Of PhieuThuTienDTO)
        Dim result As Result
        result = phieuThuBus.selectAll(listPhieuThuTien)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu thu tiền k thành công không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
    End Sub

    Private Sub loadListPhieuThu()
        Dim listPhieuThuTien = New List(Of PhieuThuTienDTO)
        Dim result As Result
        result = phieuThuBus.selectAll(listPhieuThuTien)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu thu tiền k thành công không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListPhieuThuTien.Columns.Clear()
        dgvListPhieuThuTien.DataSource = Nothing

        dgvListPhieuThuTien.AutoGenerateColumns = False
        dgvListPhieuThuTien.AllowUserToAddRows = False
        dgvListPhieuThuTien.DataSource = listPhieuThuTien

        Dim clMaKh = New DataGridViewTextBoxColumn()
        clMaKh.Name = "MaKhachHang"
        clMaKh.HeaderText = "Mã Khách Hàng"
        clMaKh.DataPropertyName = "MaKhachHang"
        dgvListPhieuThuTien.Columns.Add(clMaKh)

        Dim clNgayThu = New DataGridViewTextBoxColumn()
        clNgayThu.Name = "NgayThu"
        clNgayThu.HeaderText = "Ngày Thu"
        clNgayThu.DataPropertyName = "NgayThu"
        dgvListPhieuThuTien.Columns.Add(clNgayThu)

        Dim clSoTienThu = New DataGridViewTextBoxColumn()
        clSoTienThu.Name = "SoTienThu"
        clSoTienThu.HeaderText = "Số Tiền Thu"
        clSoTienThu.DataPropertyName = "SoTienThu"
        dgvListPhieuThuTien.Columns.Add(clSoTienThu)
    End Sub

    Private Sub loadListPhieuThu_byMaPhieuThu(maPhieu As String)
        phieuThuBus = New PhieuThuTienBUS()
        Dim listPhieuThu = New List(Of PhieuThuTienDTO)
        Dim result = phieuThuBus.selectAll_byMaPhieu(maPhieu, listPhieuThu)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin phiếu thu tiền theo mã phiếu thu tiền không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        dgvListPhieuThuTien.Columns.Clear()
        dgvListPhieuThuTien.DataSource = Nothing

        dgvListPhieuThuTien.AutoGenerateColumns = False
        dgvListPhieuThuTien.AllowUserToAddRows = False
        dgvListPhieuThuTien.DataSource = listPhieuThu

        Dim clMaKh = New DataGridViewTextBoxColumn()
        clMaKh.Name = "MaKhachHang"
        clMaKh.HeaderText = "Mã Khách Hàng"
        clMaKh.DataPropertyName = "MaKhachHang"
        dgvListPhieuThuTien.Columns.Add(clMaKh)

        Dim clNgayThu = New DataGridViewTextBoxColumn()
        clNgayThu.Name = "NgayThu"
        clNgayThu.HeaderText = "Ngày Thu"
        clNgayThu.DataPropertyName = "NgayThu"
        dgvListPhieuThuTien.Columns.Add(clNgayThu)

        Dim clSoTienThu = New DataGridViewTextBoxColumn()
        clSoTienThu.Name = "SoTienThu"
        clSoTienThu.HeaderText = "Số Tiền Thu"
        clSoTienThu.DataPropertyName = "SoTienThu"
        dgvListPhieuThuTien.Columns.Add(clSoTienThu)
    End Sub

    Private Sub loadKhachHang_ByMaKH(maKH As String)
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

    Private Sub dgvListCTPhieuThu_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvListPhieuThuTien.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListPhieuThuTien.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvChiTietPhieuNhap.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListPhieuThuTien.RowCount) Then
            Try
                Dim ctpt = CType(dgvListPhieuThuTien.Rows(currentRowIndex).DataBoundItem, PhieuThuTienDTO)
                txtMaKH.Text = ctpt.MaKhachHang
                dtpNgayThu.Value = ctpt.NgayThu
                txtSoTienThu.Text = ctpt.SoTienThu
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub txtMaPhieuThuTienTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtMaPhieuThuTienTimKiem.TextChanged
        Try
            Dim maPhieu = txtMaPhieuThuTienTimKiem.Text
            loadListPhieuThu_byMaPhieuThu(maPhieu)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMaKH_TextChanged(sender As Object, e As EventArgs) Handles txtMaKH.TextChanged
        Try
            Dim maKH = txtMaKH.Text
            loadKhachHang_ByMaKH(maKH)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCapNhatPhieuThuTien_Click(sender As Object, e As EventArgs) Handles btCapNhatPhieuThuTien.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListPhieuThuTien.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListPhieuThuTien.RowCount) Then

        End If
        Try
            Dim phieuthutien As PhieuThuTienDTO
            phieuthutien = New PhieuThuTienDTO()

            '1. Mapping data from GUI control
            phieuthutien.MaPhieuThu = Convert.ToInt32(txtMaPhieuThuTienTimKiem.Text)
            phieuthutien.MaKhachHang = Convert.ToInt32(txtMaKH.Text)
            phieuthutien.NgayThu = dtpNgayThu.Value
            phieuthutien.SoTienThu = txtSoTienThu.Text
            '2. Business .....
            '3. Insert to DB
            Dim result As Result
            result = phieuThuBus.update(phieuthutien)
            If (result.FlagResult = True) Then
                ' Re-Load phieuThuTien list
                loadListPhieuThu_byMaPhieuThu(txtMaPhieuThuTienTimKiem.Text)
                ' Hightlight the row has been updated on table
                dgvListPhieuThuTien.Rows(currentRowIndex).Selected = True
                Try
                    phieuthutien = CType(dgvListPhieuThuTien.Rows(currentRowIndex).DataBoundItem, PhieuThuTienDTO)
                    txtMaPhieuThuTienTimKiem.Text = phieuthutien.MaPhieuThu
                    txtMaKH.Text = phieuthutien.MaKhachHang
                    dtpNgayThu.Value = phieuthutien.NgayThu
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                End Try
                MessageBox.Show("Cập nhật thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cập nhật không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Private Sub btXoaPhieuThuTien_Click(sender As Object, e As EventArgs) Handles btXoaPhieuThuTien.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListPhieuThuTien.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListPhieuThuTien.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa phiếu thu tiền có mã số là " + txtMaPhieuThuTienTimKiem.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = phieuThuBus.delete(txtMaPhieuThuTienTimKiem.Text)
                        If (result.FlagResult = True) Then
                            ' Re-Load LoaiHocSinh list
                            loadListPhieuThu()
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListPhieuThuTien.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListPhieuThuTien.Rows(currentRowIndex).Selected = True
                            End If
                            MessageBox.Show("Xóa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
End Class