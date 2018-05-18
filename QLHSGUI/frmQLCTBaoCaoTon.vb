Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmQLCTBaoCaoTon
    Private sachBus As SachBUS
    Private loaisachBus As LoaiSachBUS
    Private ctbaocaotonBus As CTBaoCaoTonBUS
    Private baocaotonBus As BaoCaoTonBUS

    Private baocaoton As BaoCaoTonDTO
    Private sach As SachDTO
    Private loaiSach As LoaiSachDTO

    Private Sub frmQLCTBaoCaoTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sachBus = New SachBUS()
        loaisachBus = New LoaiSachBUS()
        ctbaocaotonBus = New CTBaoCaoTonBUS()
        baocaotonBus = New BaoCaoTonBUS()

        Dim listBaoCaoTon = New List(Of BaoCaoTonDTO)
        Dim result As Result
        result = baocaotonBus.selectAll(listBaoCaoTon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
    End Sub

    Private Sub loadListChiTietBaoCaoTon()
        Dim listct = New List(Of CTBaoCaoTonDTO)
        Dim result As Result
        result = ctbaocaotonBus.selectAll(listct)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chi tiết báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListChiTietBaoCaoTon.Columns.Clear()
        dgvListChiTietBaoCaoTon.DataSource = Nothing

        dgvListChiTietBaoCaoTon.AutoGenerateColumns = False
        dgvListChiTietBaoCaoTon.AllowUserToAddRows = False
        dgvListChiTietBaoCaoTon.DataSource = listct

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaChiTietBaoCaoTon"
        clMa.HeaderText = "Mã Chi Tiết Báo Cáo Tồn"
        clMa.DataPropertyName = "MaChiTietBaoCaoTon"
        dgvListChiTietBaoCaoTon.Columns.Add(clMa)

        Dim clMaSach = New DataGridViewTextBoxColumn()
        clMaSach.Name = "MaSach"
        clMaSach.HeaderText = "Mã Sách"
        clMaSach.DataPropertyName = "MaSach"
        dgvListChiTietBaoCaoTon.Columns.Add(clMaSach)

        'Dim clMaBaoCaoTon = New DataGridViewTextBoxColumn()
        'clMaBaoCaoTon.Name = "MaBaoCaoTon"
        'clMaBaoCaoTon.HeaderText = "Mã Báo Cáo Tồn"
        'clMaBaoCaoTon.DataPropertyName = "MaBaoCaoTon"
        'dgvListChiTietBaoCaoTon.Columns.Add(clMaBaoCaoTon)

        Dim clTonDau = New DataGridViewTextBoxColumn()
        clTonDau.Name = "TonDau"
        clTonDau.HeaderText = "Số Lượng Tồn Đầu"
        clTonDau.DataPropertyName = "TonDau"
        dgvListChiTietBaoCaoTon.Columns.Add(clTonDau)

        Dim clPhatSinh = New DataGridViewTextBoxColumn()
        clPhatSinh.Name = "PhatSinh"
        clPhatSinh.HeaderText = "Phát Sinh"
        clPhatSinh.DataPropertyName = "PhatSinh"
        dgvListChiTietBaoCaoTon.Columns.Add(clPhatSinh)

        Dim clTonCuoi = New DataGridViewTextBoxColumn()
        clTonCuoi.Name = "TonCuoi"
        clTonCuoi.HeaderText = "Số Lượng Tồn Cuối"
        clTonCuoi.DataPropertyName = "TonCuoi"
        dgvListChiTietBaoCaoTon.Columns.Add(clTonCuoi)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListChiTietBaoCaoTon.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub loadlistBaoCao_ByMaBaoCaoTon(maBaoCao As String)
        Dim listctBaoCao = New List(Of CTBaoCaoTonDTO)
        Dim result As Result
        result = ctbaocaotonBus.selectAll_byMaBaoCaoTon(maBaoCao, listctBaoCao)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chi tiết báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListChiTietBaoCaoTon.Columns.Clear()
        dgvListChiTietBaoCaoTon.DataSource = Nothing

        dgvListChiTietBaoCaoTon.AutoGenerateColumns = False
        dgvListChiTietBaoCaoTon.AllowUserToAddRows = False
        dgvListChiTietBaoCaoTon.DataSource = listctBaoCao

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaChiTietBaoCaoTon"
        clMa.HeaderText = "Mã Chi Tiết Báo Cáo Tồn"
        clMa.DataPropertyName = "MaChiTietBaoCaoTon"
        dgvListChiTietBaoCaoTon.Columns.Add(clMa)

        Dim clMaSach = New DataGridViewTextBoxColumn()
        clMaSach.Name = "MaSach"
        clMaSach.HeaderText = "Mã Sách"
        clMaSach.DataPropertyName = "MaSach"
        dgvListChiTietBaoCaoTon.Columns.Add(clMaSach)

        'Dim clMaBaoCaoTon = New DataGridViewTextBoxColumn()
        'clMaBaoCaoTon.Name = "MaBaoCaoTon"
        'clMaBaoCaoTon.HeaderText = "Mã Báo Cáo Tồn"
        'clMaBaoCaoTon.DataPropertyName = "MaBaoCaoTon"
        'dgvListChiTietBaoCaoTon.Columns.Add(clMaBaoCaoTon)

        Dim clTonDau = New DataGridViewTextBoxColumn()
        clTonDau.Name = "TonDau"
        clTonDau.HeaderText = "Số Lượng Tồn Đầu"
        clTonDau.DataPropertyName = "TonDau"
        dgvListChiTietBaoCaoTon.Columns.Add(clTonDau)

        Dim clPhatSinh = New DataGridViewTextBoxColumn()
        clPhatSinh.Name = "PhatSinh"
        clPhatSinh.HeaderText = "Phát Sinh"
        clPhatSinh.DataPropertyName = "PhatSinh"
        dgvListChiTietBaoCaoTon.Columns.Add(clPhatSinh)

        Dim clTonCuoi = New DataGridViewTextBoxColumn()
        clTonCuoi.Name = "TonCuoi"
        clTonCuoi.HeaderText = "Số Lượng Tồn Cuối"
        clTonCuoi.DataPropertyName = "TonCuoi"
        dgvListChiTietBaoCaoTon.Columns.Add(clTonCuoi)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListChiTietBaoCaoTon.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub loadlistBaoCaoTon(maBaoCaoTon As String)
        Dim baocaotonBus = New BaoCaoTonBUS()
        Dim listBaoCao = New List(Of BaoCaoTonDTO)
        Dim result = baocaotonBus.selectAll_byMaBaoCaoTon(maBaoCaoTon, listBaoCao)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        baocaoton = listBaoCao(0)
        dtpThangBaoCaoTon.Value = baocaoton.ThangBaoCao
    End Sub

    Private Sub dgvListCTBaoCaoTon_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvListChiTietBaoCaoTon.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListChiTietBaoCaoTon.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvChiTietPhieuNhap.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListChiTietBaoCaoTon.RowCount) Then
            Try
                Dim ctbct = CType(dgvListChiTietBaoCaoTon.Rows(currentRowIndex).DataBoundItem, CTBaoCaoTonDTO)
                txtMaCTBCT.Text = ctbct.MaChiTietBaoCaoTon
                txtMaSach.Text = ctbct.MaSach
                txtMaBaoCaoTon.Text = ctbct.MaBaoCaoTon
                txtSoLuongTonDau.Text = ctbct.TonDau
                txtPhatSinh.Text = ctbct.PhatSinh
                txtSoLuongTonCuoi.Text = ctbct.TonCuoi
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMaBaoCaoTonTimKiem.TextChanged
        Try
            Dim maBaoCao = txtMaBaoCaoTonTimKiem.Text
            loadlistBaoCao_ByMaBaoCaoTon(maBaoCao)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMaBaoCaoTon_TextChanged(sender As Object, e As EventArgs) Handles txtMaBaoCaoTon.TextChanged
        Try
            Dim maBaoCaoTon = txtMaBaoCaoTon.Text
            loadlistBaoCaoTon(maBaoCaoTon)
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
            loadlistLoaiSach(maLoai)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCapNhatChiTietBaoCaoTon_Click(sender As Object, e As EventArgs) Handles btCapNhatChiTietBaoCaoTon.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListChiTietBaoCaoTon.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListChiTietBaoCaoTon.RowCount) Then
            Try
                Dim ct As CTBaoCaoTonDTO
                ct = New CTBaoCaoTonDTO()

                '1. Mapping data from GUI control
                ct.MaChiTietBaoCaoTon = txtMaCTBCT.Text
                ct.TonDau = txtSoLuongTonDau.Text
                ct.PhatSinh = txtPhatSinh.Text
                ct.TonCuoi = txtSoLuongTonCuoi.Text
                '2. Business .....
                '3. Insert to DB
                Dim result As Result
                result = ctbaocaotonBus.update(ct)
                If (result.FlagResult = True) Then
                    ' Re-Load khlist
                    loadlistBaoCao_ByMaBaoCaoTon(txtMaBaoCaoTonTimKiem.Text)
                    ' Hightlight the row has been updated on table
                    dgvListChiTietBaoCaoTon.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btXoaChiTietBaoCaoTon_Click(sender As Object, e As EventArgs) Handles btXoaChiTietBaoCaoTon.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListChiTietBaoCaoTon.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListChiTietBaoCaoTon.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa chi tiết báo cáo có mã là  " + txtMaCTBCT.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = ctbaocaotonBus.delete(Convert.ToInt32(txtMaCTBCT.Text))
                        If (result.FlagResult = True) Then
                            ' Re-Load LoaiHocSinh list
                            loadlistBaoCao_ByMaBaoCaoTon(txtMaBaoCaoTonTimKiem.Text)
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListChiTietBaoCaoTon.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListChiTietBaoCaoTon.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim ctbct = CType(dgvListChiTietBaoCaoTon.Rows(currentRowIndex).DataBoundItem, CTBaoCaoTonDTO)
                                    txtMaCTBCT.Text = ctbct.MaChiTietBaoCaoTon
                                    txtMaSach.Text = ctbct.MaSach
                                    txtMaBaoCaoTon.Text = ctbct.MaBaoCaoTon
                                    txtSoLuongTonDau.Text = ctbct.TonDau
                                    txtPhatSinh.Text = ctbct.PhatSinh
                                    txtSoLuongTonCuoi.Text = ctbct.TonCuoi
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
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