Imports System.Configuration
Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmQLPhieuNhap
    Private pnBus As PhieuNhapBUS
    Private ctpnBus As CTPhieuNhapBUS

    Private Sub frmQLPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnBus = New PhieuNhapBUS()
        ' Load list phieu nhap
        loadlistPhieuNhap()
    End Sub

    Private Sub loadlistPhieuNhap()
        ' Load LoaiPhieuNhap list
        Dim listPhieuNhap = New List(Of PhieuNhapDTO)
        Dim result As Result
        result = pnBus.selectAll(listPhieuNhap)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListPhieuNhap.Columns.Clear()
        dgvListPhieuNhap.DataSource = Nothing

        dgvListPhieuNhap.AutoGenerateColumns = False
        dgvListPhieuNhap.AllowUserToAddRows = False
        dgvListPhieuNhap.DataSource = listPhieuNhap

        Dim clMaPhieuNhap = New DataGridViewTextBoxColumn()
        clMaPhieuNhap.Name = "MAPHIEUNHAP"
        clMaPhieuNhap.HeaderText = "Mã Phiếu"
        clMaPhieuNhap.DataPropertyName = "MAPHIEUNHAP"
        dgvListPhieuNhap.Columns.Add(clMaPhieuNhap)

        Dim clNgayNhap = New DataGridViewTextBoxColumn()
        clNgayNhap.Name = "NgayNhap"
        clNgayNhap.HeaderText = "Ngày Nhập"
        clNgayNhap.DataPropertyName = "NgayNhap"
        dgvListPhieuNhap.Columns.Add(clNgayNhap)
    End Sub

    Private Sub loadlistPhieuNhap_ByNgayNhap(ngaynhap As DateTime)
        Dim listPhieuNhap = New List(Of PhieuNhapDTO)
        Dim result As Result
        result = pnBus.selectAll_ByNgayNhap(ngaynhap, listPhieuNhap)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu nhập theo ngày nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListPhieuNhap.Columns.Clear()
        dgvListPhieuNhap.DataSource = Nothing

        dgvListPhieuNhap.AutoGenerateColumns = False
        dgvListPhieuNhap.AllowUserToAddRows = False
        dgvListPhieuNhap.DataSource = listPhieuNhap

        Dim clMaPhieuNhap = New DataGridViewTextBoxColumn()
        clMaPhieuNhap.Name = "MAPHIEUNHAP"
        clMaPhieuNhap.HeaderText = "Mã Phiếu"
        clMaPhieuNhap.DataPropertyName = "MAPHIEUNHAP"
        dgvListPhieuNhap.Columns.Add(clMaPhieuNhap)

        Dim clNgayNhap = New DataGridViewTextBoxColumn()
        clNgayNhap.Name = "NgayNhap"
        clNgayNhap.HeaderText = "Ngày Nhập"
        clNgayNhap.DataPropertyName = "NgayNhap"
        dgvListPhieuNhap.Columns.Add(clNgayNhap)
    End Sub

    Private Sub dgvListPhieuNhap_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListPhieuNhap.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListPhieuNhap.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListPhieuNhap.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListPhieuNhap.RowCount) Then
            Try
                Dim pn = CType(dgvListPhieuNhap.Rows(currentRowIndex).DataBoundItem, PhieuNhapDTO)
                txtMaPhieuNhap.Text = pn.MaPhieuNhap
                dtpNgayNhap.Value = pn.NgayNhap
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btCapNhatPhieuNhap_Click(sender As Object, e As EventArgs) Handles btCapNhatPhieuNhap.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListPhieuNhap.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListPhieuNhap.RowCount) Then
            Try
                Dim phieunhap As PhieuNhapDTO
                phieunhap = New PhieuNhapDTO()

                '1. Mapping data from GUI control
                phieunhap.MaPhieuNhap = Convert.ToInt32(txtMaPhieuNhap.Text)
                phieunhap.NgayNhap = dtpNgayNhap.Value
                '2. Business .....
                '3. Insert to DB
                Dim result As Result
                result = pnBus.update(phieunhap)
                If (result.FlagResult = True) Then
                    ' Re-Load phieu nhap
                    loadlistPhieuNhap_ByNgayNhap(dtpNgayNhap.Value)
                    ' Hightlight the row has been updated on table
                    dgvListPhieuNhap.Rows(currentRowIndex).Selected = True
                    Try
                        phieunhap = CType(dgvListPhieuNhap.Rows(currentRowIndex).DataBoundItem, PhieuNhapDTO)
                        txtMaPhieuNhap.Text = phieunhap.MaPhieuNhap
                        dtpNgayNhap.Value = phieunhap.NgayNhap
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật phiếu nhập thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btXoaPhieuNhap_Click(sender As Object, e As EventArgs) Handles btXoaPhieuNhap.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListPhieuNhap.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListPhieuNhap.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa phiếu nhập có mã phiếu là  " + txtMaPhieuNhap.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = pnBus.delete(txtMaPhieuNhap.Text)
                        If (result.FlagResult = True) Then
                            ' Re-Load LoaiHocSinh list
                            loadlistPhieuNhap()
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListPhieuNhap.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListPhieuNhap.Rows(currentRowIndex).Selected = True
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListPhieuNhap.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim phieunhap = CType(dgvListPhieuNhap.Rows(currentRowIndex).DataBoundItem, PhieuNhapDTO)
                                    txtMaPhieuNhap.Text = phieunhap.MaPhieuNhap
                                    dtpNgayNhap.Value = phieunhap.NgayNhap
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa phiếu nhập thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub dtpNgayNhapTimKiem_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayNhapTimKiem.ValueChanged
        Try
            Dim ngaynhap = dtpNgayNhapTimKiem.Value
            loadlistPhieuNhap_ByNgayNhap(ngaynhap)
        Catch ex As Exception
        End Try
    End Sub
End Class