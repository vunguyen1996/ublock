Imports System.Configuration
Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmQLLoaiSach
    Private lsbus As LoaiSachBUS
    Private Sub frmDanhSachLoaiSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsbus = New LoaiSachBUS()
        ' Load list loai sach
        loadlistLoaiSach()
    End Sub

    Private Sub loadlistLoaiSach()
        ' Load LoaiHocSinh list
        Dim listLoaiSach = New List(Of LoaiSachDTO)
        Dim result As Result
        result = lsbus.selectAll(listLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListSach.Columns.Clear()
        dgvListSach.DataSource = Nothing

        dgvListSach.AutoGenerateColumns = False
        dgvListSach.AllowUserToAddRows = False
        dgvListSach.DataSource = listLoaiSach

        Dim clMaLoai = New DataGridViewTextBoxColumn()
        clMaLoai.Name = "MALOAISACH"
        clMaLoai.HeaderText = "Mã Loại Sách"
        clMaLoai.DataPropertyName = "MALOAISACH"
        dgvListSach.Columns.Add(clMaLoai)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "TENLOAISACH"
        clTenLoai.HeaderText = "Tên Loại Sách"
        clTenLoai.DataPropertyName = "TENLOAISACH"
        dgvListSach.Columns.Add(clTenLoai)
    End Sub

    Private Sub loadlistLoaiSach_ByTenLoaiSach(tenLoai As String)
        Dim listLoaiSach = New List(Of LoaiSachDTO)
        Dim result As Result
        result = lsbus.selectAll_ByName(tenLoai, listLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại sách theo tên loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListSach.Columns.Clear()
        dgvListSach.DataSource = Nothing

        dgvListSach.AutoGenerateColumns = False
        dgvListSach.AllowUserToAddRows = False
        dgvListSach.DataSource = listLoaiSach

        Dim clMaLoai = New DataGridViewTextBoxColumn()
        clMaLoai.Name = "MALOAISACH"
        clMaLoai.HeaderText = "Mã Loại Sách"
        clMaLoai.DataPropertyName = "MALOAISACH"
        dgvListSach.Columns.Add(clMaLoai)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "TENLOAISACH"
        clTenLoai.HeaderText = "Tên Loại Sách"
        clTenLoai.DataPropertyName = "TENLOAISACH"
        dgvListSach.Columns.Add(clTenLoai)
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListSach.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListSach.RowCount) Then
            Try
                Dim ls As LoaiSachDTO
                ls = New LoaiSachDTO()

                '1. Mapping data from GUI control
                ls.MaLoaiSach = Convert.ToInt32(txtMaLoaiSach.Text)
                ls.TenLoaiSach = txtTenLoaiSach.Text

                '2. Business .....
                If (lsbus.isValidName(ls) = False) Then
                    MessageBox.Show("Tên loại sách không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenLoaiSach.Focus()
                    Return
                End If
                '3. Insert to DB
                Dim result As Result
                result = lsbus.update(ls)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadlistLoaiSach()
                    ' Hightlight the row has been updated on table
                    dgvListSach.Rows(currentRowIndex).Selected = True
                    Try
                        ls = CType(dgvListSach.Rows(currentRowIndex).DataBoundItem, LoaiSachDTO)
                        txtMaLoaiSach.Text = ls.MaLoaiSach
                        txtTenLoaiSach.Text = ls.TenLoaiSach
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật loại sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub dgvListSach_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvListSach.SelectionChanged

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListSach.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListSach.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListSach.RowCount) Then
            Try
                Dim ls = CType(dgvListSach.Rows(currentRowIndex).DataBoundItem, LoaiSachDTO)
                txtMaLoaiSach.Text = ls.MaLoaiSach
                txtTenLoaiSach.Text = ls.TenLoaiSach
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListSach.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListSach.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa loại sách có mã là  " + txtMaLoaiSach.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = lsbus.delete(Convert.ToInt32(txtMaLoaiSach.Text))
                        If (result.FlagResult = True) Then
                            ' Re-Load LoaiHocSinh list
                            loadlistLoaiSach()
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListSach.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListSach.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim ls = CType(dgvListSach.Rows(currentRowIndex).DataBoundItem, LoaiSachDTO)
                                    txtMaLoaiSach.Text = ls.MaLoaiSach
                                    txtTenLoaiSach.Text = ls.TenLoaiSach
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Loại học sinh thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Loại học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub txtTenLoaiSachTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTenLoaiSachTimKiem.TextChanged
        Try
            Dim tenLoai = txtTenLoaiSachTimKiem.Text
            loadlistLoaiSach_ByTenLoaiSach(tenLoai)
        Catch ex As Exception
        End Try
    End Sub
End Class