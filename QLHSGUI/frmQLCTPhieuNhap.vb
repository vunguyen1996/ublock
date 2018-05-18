Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility
Imports System.Configuration

Public Class frmQLCTPhieuNhap
    Private phieunhapBus As PhieuNhapBUS
    Private ctphieunhapBus As CTPhieuNhapBUS
    Private sachBus As SachBUS

    Private sach As SachDTO
    Private loaiSach As LoaiSachDTO

    Private Sub frmQLCTPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieunhapBus = New PhieuNhapBUS()
        ctphieunhapBus = New CTPhieuNhapBUS()
        sachBus = New SachBUS()

        'Load loai sach
        Dim listpn = New List(Of PhieuNhapDTO)
        Dim result As Result
        result = phieunhapBus.selectAll(listpn)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'cbbMaPN.DataSource = New BindingSource(listpn, String.Empty)
        'cbbMaPN.DisplayMember = "TENLOAISACH"
        'cbbMaPN.ValueMember = "MAPHIEUNHAP"

    End Sub
    Private Sub loadListCTPhieuNhap()
        Dim listctpn = New List(Of CTPhieuNhapDTO)
        Dim result As Result
        result = ctphieunhapBus.selectAll(listctpn)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chi tiết phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListChiTietPhieuNhap.Columns.Clear()
        dgvListChiTietPhieuNhap.DataSource = Nothing

        dgvListChiTietPhieuNhap.AutoGenerateColumns = False
        dgvListChiTietPhieuNhap.AllowUserToAddRows = False
        dgvListChiTietPhieuNhap.DataSource = listctpn

        Dim clMaCTPN = New DataGridViewTextBoxColumn()
        clMaCTPN.Name = "MaChiTietPhieuNhap"
        clMaCTPN.HeaderText = "Mã Chi Tiết Phiếu Nhập"
        clMaCTPN.DataPropertyName = "MaChiTietPhieuNhap"
        dgvListChiTietPhieuNhap.Columns.Add(clMaCTPN)

        'Dim clMaPN = New DataGridViewTextBoxColumn()
        'clMaPN.Name = "MAPHIEUNHAP"
        'clMaPN.HeaderText = "Mã Phiếu Nhập"
        'clMaPN.DataPropertyName = "MAPHIEUNHAP"
        'dgvListChiTietPhieuNhap.Columns.Add(clMaPN)

        Dim clMaSach = New DataGridViewTextBoxColumn()
        clMaSach.Name = "MaSach"
        clMaSach.HeaderText = "Mã Sách"
        clMaSach.DataPropertyName = "MaSach"
        dgvListChiTietPhieuNhap.Columns.Add(clMaSach)

        Dim clSLN = New DataGridViewTextBoxColumn()
        clSLN.Name = "SoLuongNhap"
        clSLN.HeaderText = "Số Lượng Nhập"
        clSLN.DataPropertyName = "SoLuongNhap"
        dgvListChiTietPhieuNhap.Columns.Add(clSLN)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListChiTietPhieuNhap.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub loadListCTPhieuNhap(maPhieuNhap As String)
        Dim listctpn = New List(Of CTPhieuNhapDTO)
        Dim result As Result
        result = ctphieunhapBus.selectALL_ByType(maPhieuNhap, listctpn)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chi tiết phiếu nhập theo phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListChiTietPhieuNhap.Columns.Clear()
        dgvListChiTietPhieuNhap.DataSource = Nothing

        dgvListChiTietPhieuNhap.AutoGenerateColumns = False
        dgvListChiTietPhieuNhap.AllowUserToAddRows = False
        dgvListChiTietPhieuNhap.DataSource = listctpn

        Dim clMaCTPN = New DataGridViewTextBoxColumn()
        clMaCTPN.Name = "MaChiTietPhieuNhap"
        clMaCTPN.HeaderText = "Mã Chi Tiết Phiếu Nhập"
        clMaCTPN.DataPropertyName = "MaChiTietPhieuNhap"
        dgvListChiTietPhieuNhap.Columns.Add(clMaCTPN)

        'Dim clMaPN = New DataGridViewTextBoxColumn()
        'clMaPN.Name = "MAPHIEUNHAP"
        'clMaPN.HeaderText = "Mã Phiếu Nhập"
        'clMaPN.DataPropertyName = "MAPHIEUNHAP"
        'dgvListChiTietPhieuNhap.Columns.Add(clMaPN)

        Dim clMaSach = New DataGridViewTextBoxColumn()
        clMaSach.Name = "MaSach"
        clMaSach.HeaderText = "Mã Sách"
        clMaSach.DataPropertyName = "MaSach"
        dgvListChiTietPhieuNhap.Columns.Add(clMaSach)

        Dim clSLN = New DataGridViewTextBoxColumn()
        clSLN.Name = "SoLuongNhap"
        clSLN.HeaderText = "Số Lượng Nhập"
        clSLN.DataPropertyName = "SoLuongNhap"
        dgvListChiTietPhieuNhap.Columns.Add(clSLN)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListChiTietPhieuNhap.DataSource)
        myCurrencyManager.Refresh()
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
        txtSoLuongTon.Text = sach.SoLuongTon
        txtTenSach.Text = sach.TenSach
        txtTacGia.Text = sach.TacGia
        txtTheLoai.Text = sach.MaLoaiSach
    End Sub

    Private Sub loadListLoaiSach(maLoai As String)
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

    Private Sub dgvListCTPhieuNhap_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvListChiTietPhieuNhap.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListChiTietPhieuNhap.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvChiTietPhieuNhap.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListChiTietPhieuNhap.RowCount) Then
            Try
                Dim ctpn = CType(dgvListChiTietPhieuNhap.Rows(currentRowIndex).DataBoundItem, CTPhieuNhapDTO)
                txtMaSach.Text = ctpn.MaSach
                txtMaCTPN.Text = ctpn.MaChiTietPhieuNhap
                txtSoLuongNhap.Text = ctpn.SoLuongNhap
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btCapNhatCTPN_Click(sender As Object, e As EventArgs) Handles btCapNhatCTPN.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListChiTietPhieuNhap.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListChiTietPhieuNhap.RowCount) Then
            Try
                Dim ctpn As CTPhieuNhapDTO
                ctpn = New CTPhieuNhapDTO()

                '1. Mapping data from GUI control
                ctpn.MaChiTietPhieuNhap = txtMaCTPN.Text
                ctpn.MaSach = txtMaSach.Text
                ctpn.SoLuongNhap = txtSoLuongNhap.Text
                '2. Business .....
                '3. Insert to DB
                Dim result As Result
                result = ctphieunhapBus.update(ctpn)
                If (result.FlagResult = True) Then
                    ' Re-Load chi tiet phieu nhap list
                    loadListCTPhieuNhap(txtMaPhieuNhapTimKiem.Text)
                    ' Hightlight the row has been updated on table
                    dgvListChiTietPhieuNhap.Rows(currentRowIndex).Selected = True
                    'Try
                    '    ctpn = CType(dgvListChiTietPhieuNhap.Rows(currentRowIndex).DataBoundItem, CTPhieuNhapDTO)
                    '    txtMaCTPN.Text = ctpn.MaChiTietPhieuNhap
                    '    txtMaSach.Text = ctpn.MaSach
                    '    txtSoLuongNhap.Text = ctpn.SoLuongNhap
                    'Catch ex As Exception
                    '    Console.WriteLine(ex.StackTrace)
                    'End Try
                    MessageBox.Show("Cập nhật chi tiết phiếu nhập thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật chi tiết phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btXoaCTPN_Click(sender As Object, e As EventArgs) Handles btXoaCTPN.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListChiTietPhieuNhap.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListChiTietPhieuNhap.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa chi tiết phiếu nhập có mã số là " + txtMaCTPN.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = ctphieunhapBus.delete(txtMaCTPN.Text)
                        If (result.FlagResult = True) Then
                            ' Re-Load LoaiHocSinh list
                            loadListCTPhieuNhap(txtMaPhieuNhapTimKiem.Text)
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListChiTietPhieuNhap.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListChiTietPhieuNhap.Rows(currentRowIndex).Selected = True
                            End If
                            MessageBox.Show("Xóa chi tiết phiếu nhập thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa chi tiết phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub txtMaPhieuNhapTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtMaPhieuNhapTimKiem.TextChanged
        Try
            Dim mapn = txtMaPhieuNhapTimKiem.Text
            loadListCTPhieuNhap(mapn)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtMaSach_TextChanged(sender As Object, e As EventArgs) Handles txtMaSach.TextChanged
        Try
            Dim maSach = txtMaSach.Text
            loadListSach(maSach)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTheLoai_TextChanged(sender As Object, e As EventArgs) Handles txtTheLoai.TextChanged
        Try
            Dim maLoai = txtTheLoai.Text
            loadListLoaiSach(maLoai)
        Catch ex As Exception

        End Try
    End Sub
End Class