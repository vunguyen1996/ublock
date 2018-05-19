Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmQLBaoCaoCongNo
    Private bccnBus As BaoCaoCongNoBUS

    Private Sub frmQLBaoCaoCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bccnBus = New BaoCaoCongNoBUS()
        loadlistBaoCaoCongNo()
    End Sub

    Private Sub loadlistBaoCaoCongNo()
        Dim listBaoCaoCongNo = New List(Of BaoCaoCongNoDTO)
        Dim result As Result
        result = bccnBus.selectAll(listBaoCaoCongNo)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListBaoCaoCongNo.Columns.Clear()
        dgvListBaoCaoCongNo.DataSource = Nothing

        dgvListBaoCaoCongNo.AutoGenerateColumns = False
        dgvListBaoCaoCongNo.AllowUserToAddRows = False
        dgvListBaoCaoCongNo.DataSource = listBaoCaoCongNo

        Dim clMaBaoCao = New DataGridViewTextBoxColumn()
        clMaBaoCao.Name = "MaBaoCaoCongNo"
        clMaBaoCao.HeaderText = "Mã Báo Cáo Công Nợ"
        clMaBaoCao.DataPropertyName = "MaBaoCaoCongNo"
        dgvListBaoCaoCongNo.Columns.Add(clMaBaoCao)

        Dim clThangBaoCao = New DataGridViewTextBoxColumn()
        clThangBaoCao.Name = "ThangBaoCaoCongNo"
        clThangBaoCao.HeaderText = "Tháng Báo Cáo Công Nợ"
        clThangBaoCao.DataPropertyName = "ThangBaoCaoCongNo"
        dgvListBaoCaoCongNo.Columns.Add(clThangBaoCao)
    End Sub

    Private Sub loadlistBaoCaoCongNo_byThangBaoCao(thangBaoCao As DateTime)
        Dim listBaoCaoCongNo = New List(Of BaoCaoCongNoDTO)
        Dim result As Result
        result = bccnBus.selectAll_byThangBaoCao(thangBaoCao, listBaoCaoCongNo)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListBaoCaoCongNo.Columns.Clear()
        dgvListBaoCaoCongNo.DataSource = Nothing

        dgvListBaoCaoCongNo.AutoGenerateColumns = False
        dgvListBaoCaoCongNo.AllowUserToAddRows = False
        dgvListBaoCaoCongNo.DataSource = listBaoCaoCongNo

        Dim clMaBaoCao = New DataGridViewTextBoxColumn()
        clMaBaoCao.Name = "MaBaoCaoCongNo"
        clMaBaoCao.HeaderText = "Mã Báo Cáo Công Nợ"
        clMaBaoCao.DataPropertyName = "MaBaoCaoCongNo"
        dgvListBaoCaoCongNo.Columns.Add(clMaBaoCao)

        Dim clThangBaoCao = New DataGridViewTextBoxColumn()
        clThangBaoCao.Name = "ThangBaoCaoCongNo"
        clThangBaoCao.HeaderText = "Tháng Báo Cáo Công Nợ"
        clThangBaoCao.DataPropertyName = "ThangBaoCaoCongNo"
        dgvListBaoCaoCongNo.Columns.Add(clThangBaoCao)
    End Sub

    Private Sub dgvListBaoCaoCongNo_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListBaoCaoCongNo.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListBaoCaoCongNo.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListbccn.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListBaoCaoCongNo.RowCount) Then
            Try
                Dim bcct = CType(dgvListBaoCaoCongNo.Rows(currentRowIndex).DataBoundItem, BaoCaoCongNoDTO)
                txtMaBaoCaoCongNo.Text = bcct.MaBaoCaoCongNo
                dtpThangBaoCaoCongNo.Value = bcct.ThangBaoCaoCongNo
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btCapNhatBaoCaoCongNo_Click(sender As Object, e As EventArgs) Handles btCapNhatBaoCaoCongNo.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListBaoCaoCongNo.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListBaoCaoCongNo.RowCount) Then
            Try
                Dim bccn As BaoCaoCongNoDTO
                bccn = New BaoCaoCongNoDTO()

                '1. Mapping data from GUI control
                bccn.MaBaoCaoCongNo = Convert.ToInt32(txtMaBaoCaoCongNo.Text)
                bccn.ThangBaoCaoCongNo = dtpThangBaoCaoCongNo.Value
                '2. Business .....
                '3. Insert to DB
                Dim result As Result
                result = bccnBus.update(bccn)
                If (result.FlagResult = True) Then
                    ' Re-Load phieu nhap
                    loadlistBaoCaoCongNo_byThangBaoCao(dtpThangBaoCaoCongNo.Value)
                    ' Hightlight the row has been updated on table
                    dgvListBaoCaoCongNo.Rows(currentRowIndex).Selected = True
                    Try
                        bccn = CType(dgvListBaoCaoCongNo.Rows(currentRowIndex).DataBoundItem, BaoCaoCongNoDTO)
                        txtMaBaoCaoCongNo.Text = bccn.MaBaoCaoCongNo
                        dtpThangBaoCaoCongNo.Value = bccn.ThangBaoCaoCongNo
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật báo cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btXoaBaoCaoCongNo_Click(sender As Object, e As EventArgs) Handles btXoaBaoCaoCongNo.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListBaoCaoCongNo.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListBaoCaoCongNo.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa phiếu nhập có mã phiếu là  " + txtMaBaoCaoCongNo.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = bccnBus.delete(txtMaBaoCaoCongNo.Text)
                        If (result.FlagResult = True) Then
                            ' Re-Load LoaiHocSinh list
                            loadlistBaoCaoCongNo()
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListBaoCaoCongNo.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListBaoCaoCongNo.Rows(currentRowIndex).Selected = True
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListBaoCaoCongNo.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim bccn = CType(dgvListBaoCaoCongNo.Rows(currentRowIndex).DataBoundItem, BaoCaoCongNoDTO)
                                    txtMaBaoCaoCongNo.Text = bccn.MaBaoCaoCongNo
                                    dtpThangBaoCaoCongNo.Value = bccn.ThangBaoCaoCongNo
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa báo cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub dtpThangBaoCaoCongNoTimKiem_ValueChanged(sender As Object, e As EventArgs) Handles dtpThangBaoCaoCongNoTimKiem.ValueChanged
        Try
            Dim thangBaoCao = dtpThangBaoCaoCongNoTimKiem.Value
            loadlistBaoCaoCongNo_byThangBaoCao(thangBaoCao)
        Catch ex As Exception

        End Try
    End Sub

End Class