Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmQLCTBaoCaoCongNo
    Private bccnBus As BaoCaoCongNoBUS
    Private ctbccnBus As CTBaoCaoCongNoBUS

    Private baocaoCN As BaoCaoCongNoDTO
    Private khachhang As KhachHangDTO

    Private Sub frmQLCTBaoCaoCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bccnBus = New BaoCaoCongNoBUS()
        ctbccnBus = New CTBaoCaoCongNoBUS()

        Dim listbccn = New List(Of BaoCaoCongNoDTO)
        Dim result As Result
        result = bccnBus.selectAll(listbccn)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        'loadlistCTBaoCaoCongNo()
    End Sub

    Private Sub loadlistCTBaoCaoCongNo()
        Dim listctbccn = New List(Of CTBaoCaoCongNoDTO)
        Dim result As Result
        result = ctbccnBus.selectAll(listctbccn)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListCTBaoCaoCongNo.Columns.Clear()
        dgvListCTBaoCaoCongNo.DataSource = Nothing

        dgvListCTBaoCaoCongNo.AutoGenerateColumns = False
        dgvListCTBaoCaoCongNo.AllowUserToAddRows = False
        dgvListCTBaoCaoCongNo.DataSource = listctbccn

        Dim clMaCTBCCN = New DataGridViewTextBoxColumn()
        clMaCTBCCN.Name = "MaChiTietBaoCaoCongNo"
        clMaCTBCCN.HeaderText = "Mã Chi Báo Cáo Công Nợ"
        clMaCTBCCN.DataPropertyName = "MaChiTietBaoCaoCongNo"
        dgvListCTBaoCaoCongNo.Columns.Add(clMaCTBCCN)

        Dim clMaKH = New DataGridViewTextBoxColumn()
        clMaKH.Name = "MaKhachHang"
        clMaKH.HeaderText = "Mã Khách Hàng"
        clMaKH.DataPropertyName = "MaKhachHang"
        dgvListCTBaoCaoCongNo.Columns.Add(clMaKH)

        Dim clNoDau = New DataGridViewTextBoxColumn()
        clNoDau.Name = "SoTienNoDau"
        clNoDau.HeaderText = "Số Tiền Nợ Đầu"
        clNoDau.DataPropertyName = "SoTienNoDau"
        dgvListCTBaoCaoCongNo.Columns.Add(clNoDau)

        Dim clPhatSinh = New DataGridViewTextBoxColumn()
        clPhatSinh.Name = "SoTienPhatSinh"
        clPhatSinh.HeaderText = "Số Tiền Phát Sinh"
        clPhatSinh.DataPropertyName = "SoTienPhatSinh"
        dgvListCTBaoCaoCongNo.Columns.Add(clPhatSinh)

        Dim clNoCuoi = New DataGridViewTextBoxColumn()
        clNoCuoi.Name = "SoTienNoCuoi"
        clNoCuoi.HeaderText = "Số Tiền Nợ Cuối"
        clNoCuoi.DataPropertyName = "SoTienNoCuoi"
        dgvListCTBaoCaoCongNo.Columns.Add(clNoCuoi)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListCTBaoCaoCongNo.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub loadlistCTBaoCaoCongNo_byMaBaoCaoCongNo(maBaoCao As Integer)
        Dim listctbccn = New List(Of CTBaoCaoCongNoDTO)
        Dim result As Result
        result = ctbccnBus.selectAll_byMaBaoCao(maBaoCao, listctbccn)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListCTBaoCaoCongNo.Columns.Clear()
        dgvListCTBaoCaoCongNo.DataSource = Nothing

        dgvListCTBaoCaoCongNo.AutoGenerateColumns = False
        dgvListCTBaoCaoCongNo.AllowUserToAddRows = False
        dgvListCTBaoCaoCongNo.DataSource = listctbccn

        Dim clMaCTBCCN = New DataGridViewTextBoxColumn()
        clMaCTBCCN.Name = "MaChiTietBaoCaoCongNo"
        clMaCTBCCN.HeaderText = "Mã Chi Báo Cáo Công Nợ"
        clMaCTBCCN.DataPropertyName = "MaChiTietBaoCaoCongNo"
        dgvListCTBaoCaoCongNo.Columns.Add(clMaCTBCCN)

        Dim clMaKH = New DataGridViewTextBoxColumn()
        clMaKH.Name = "MaKhachHang"
        clMaKH.HeaderText = "Mã Khách Hàng"
        clMaKH.DataPropertyName = "MaKhachHang"
        dgvListCTBaoCaoCongNo.Columns.Add(clMaKH)

        Dim clNoDau = New DataGridViewTextBoxColumn()
        clNoDau.Name = "SoTienNoDau"
        clNoDau.HeaderText = "Số Tiền Nợ Đầu"
        clNoDau.DataPropertyName = "SoTienNoDau"
        dgvListCTBaoCaoCongNo.Columns.Add(clNoDau)

        Dim clPhatSinh = New DataGridViewTextBoxColumn()
        clPhatSinh.Name = "SoTienPhatSinh"
        clPhatSinh.HeaderText = "Số Tiền Phát Sinh"
        clPhatSinh.DataPropertyName = "SoTienPhatSinh"
        dgvListCTBaoCaoCongNo.Columns.Add(clPhatSinh)

        Dim clNoCuoi = New DataGridViewTextBoxColumn()
        clNoCuoi.Name = "SoTienNoCuoi"
        clNoCuoi.HeaderText = "Số Tiền Nợ Cuối"
        clNoCuoi.DataPropertyName = "SoTienNoCuoi"
        dgvListCTBaoCaoCongNo.Columns.Add(clNoCuoi)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListCTBaoCaoCongNo.DataSource)
        myCurrencyManager.Refresh()
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

    Private Sub loadListBaoCaoCongNo_byMaBaoCaoCongNo(maBaoCao As Integer)
        Dim bccnBus = New BaoCaoCongNoBUS()
        Dim listBCCN = New List(Of BaoCaoCongNoDTO)
        Dim result = bccnBus.selectAll_byMaBaoCao(maBaoCao, listBCCN)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin báo cáo theo mã báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        baocaoCN = listBCCN(0)
        dtpThangBaoCaoCongNo.Value = baocaoCN.ThangBaoCaoCongNo
    End Sub

    Private Sub dgvListCTBaoCaoCongNo_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvListCTBaoCaoCongNo.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListCTBaoCaoCongNo.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvChiTietPhieuNhap.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListCTBaoCaoCongNo.RowCount) Then
            Try
                Dim ctbccn = CType(dgvListCTBaoCaoCongNo.Rows(currentRowIndex).DataBoundItem, CTBaoCaoCongNoDTO)
                txtMaCTBCCN.Text = ctbccn.MaChiTietBaoCaoCongNo
                txtMaKH.Text = ctbccn.MaKhachHang
                txtSoTienNoDau.Text = ctbccn.SoTienNoDau
                txtSoTienPhatSinh.Text = ctbccn.SoTienPhatSinh
                txtSoTienNoCuoi.Text = ctbccn.SoTienNoCuoi
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub txtMaBCCN_TextChanged(sender As Object, e As EventArgs) Handles txtMaBCCN.TextChanged
        Try
            Dim maBaoCao = txtMaBCCN.Text
            loadlistCTBaoCaoCongNo_byMaBaoCaoCongNo(maBaoCao)
            loadListBaoCaoCongNo_byMaBaoCaoCongNo(maBaoCao)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMaKH_TextChanged(sender As Object, e As EventArgs) Handles txtMaKH.TextChanged
        Try
            Dim maKh = txtMaKH.Text
            loadListKhachHang_ByMaKH(maKh)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCapNhatCTBCCN_Click(sender As Object, e As EventArgs) Handles btCapNhatCTBCCN.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListCTBaoCaoCongNo.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListCTBaoCaoCongNo.RowCount) Then
            Try
                Dim ctbccn As CTBaoCaoCongNoDTO
                ctbccn = New CTBaoCaoCongNoDTO()

                '1. Mapping data from GUI control
                ctbccn.MaChiTietBaoCaoCongNo = txtMaCTBCCN.Text
                ctbccn.MaKhachHang = txtMaKH.Text
                ctbccn.MaBaoCaoCongNo = txtMaBCCN.Text
                ctbccn.SoTienNoDau = txtSoTienNoDau.Text
                ctbccn.SoTienPhatSinh = txtSoTienPhatSinh.Text
                ctbccn.SoTienNoCuoi = txtSoTienNoCuoi.Text
                '2. Business .....
                '3. Insert to DB
                Dim result As Result
                result = ctbccnBus.update(ctbccn)
                If (result.FlagResult = True) Then
                    ' Re-Load chi tiet phieu nhap list
                    loadlistCTBaoCaoCongNo_byMaBaoCaoCongNo(txtMaBCCN.Text)
                    ' Hightlight the row has been updated on table
                    dgvListCTBaoCaoCongNo.Rows(currentRowIndex).Selected = True
                    'Try
                    '    ctpn = CType(dgvListChiTietPhieuNhap.Rows(currentRowIndex).DataBoundItem, CTPhieuNhapDTO)
                    '    txtMaCTPN.Text = ctpn.MaChiTietPhieuNhap
                    '    txtMaSach.Text = ctpn.MaSach
                    '    txtSoLuongNhap.Text = ctpn.SoLuongNhap
                    'Catch ex As Exception
                    '    Console.WriteLine(ex.StackTrace)
                    'End Try
                    MessageBox.Show("Cập nhật chi tiết báo cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật chi tiết báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btXoaCTBCCN_Click(sender As Object, e As EventArgs) Handles btXoaCTBCCN.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListCTBaoCaoCongNo.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListCTBaoCaoCongNo.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa chi tiết phiếu nhập có mã số là " + txtMaCTBCCN.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = ctbccnBus.delete(txtMaCTBCCN.Text)
                        If (result.FlagResult = True) Then
                            ' Re-Load LoaiHocSinh list
                            loadlistCTBaoCaoCongNo()
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListCTBaoCaoCongNo.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListCTBaoCaoCongNo.Rows(currentRowIndex).Selected = True
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
End Class