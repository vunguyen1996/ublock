Imports System.Configuration
Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmQLBaoCaoTon
    Private bctBus As BaoCaoTonBUS
    Private Sub frmDanhSachLoaiSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bctBus = New BaoCaoTonBUS()
        ' Load list bao cao ton
        loadlistBaoCaoTon()
    End Sub

    Private Sub loadlistBaoCaoTon()
        ' Load danh sach bao cao ton len datagridview
        Dim listBaoCaoTon = New List(Of BaoCaoTonDTO)
        Dim result As Result
        result = bctBus.selectAll(listBaoCaoTon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListBaoCaoTon.Columns.Clear()
        dgvListBaoCaoTon.DataSource = Nothing

        dgvListBaoCaoTon.AutoGenerateColumns = False
        dgvListBaoCaoTon.AllowUserToAddRows = False
        dgvListBaoCaoTon.DataSource = listBaoCaoTon

        Dim clMaBCT = New DataGridViewTextBoxColumn()
        clMaBCT.Name = "MABAOCAOTON"
        clMaBCT.HeaderText = "Mã Báo Cáo Tồn"
        clMaBCT.DataPropertyName = "MABAOCAOTON"
        dgvListBaoCaoTon.Columns.Add(clMaBCT)

        Dim clThangBCT = New DataGridViewTextBoxColumn()
        clThangBCT.Name = "ThangBaoCao"
        clThangBCT.HeaderText = "Tháng Báo Cáo"
        clThangBCT.DataPropertyName = "ThangBaoCao"
        dgvListBaoCaoTon.Columns.Add(clThangBCT)



    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhatBaoCaoTon.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListBaoCaoTon.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListBaoCaoTon.RowCount) Then
            Try
                Dim bct As BaoCaoTonDTO
                bct = New BaoCaoTonDTO()

                '1. Mapping data from GUI control
                bct.MaBaoCaoTon = Convert.ToInt32(txtMaBaoCaoTon.Text)
                bct.ThangBaoCao = dtpThangBaoCaoTon.Value

                '2. Business .....
                '3. Insert to DB
                Dim result As Result
                result = bctBus.update(bct)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadlistBaoCaoTon()
                    ' Hightlight the row has been updated on table
                    dgvListBaoCaoTon.Rows(currentRowIndex).Selected = True
                    Try
                        bct = CType(dgvListBaoCaoTon.Rows(currentRowIndex).DataBoundItem, BaoCaoTonDTO)
                        txtMaBaoCaoTon.Text = bct.MaBaoCaoTon
                        dtpThangBaoCaoTon.Value = bct.ThangBaoCao
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

    Private Sub dgvListBaoCaoTon_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvListBaoCaoTon.SelectionChanged

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListBaoCaoTon.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListBaoCaoTon.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListBaoCaoTon.RowCount) Then
            Try
                Dim bct = CType(dgvListBaoCaoTon.Rows(currentRowIndex).DataBoundItem, BaoCaoTonDTO)
                txtMaBaoCaoTon.Text = bct.MaBaoCaoTon
                dtpThangBaoCaoTon.Value = bct.ThangBaoCao
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btXoaBaoCaoTon.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListBaoCaoTon.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListBaoCaoTon.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa báo cáo có mã là  " + txtMaBaoCaoTon.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = bctBus.delete(Convert.ToInt32(txtMaBaoCaoTon.Text))
                        If (result.FlagResult = True) Then
                            ' Re-Load LoaiHocSinh list
                            loadlistBaoCaoTon()
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListBaoCaoTon.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListBaoCaoTon.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim bct = CType(dgvListBaoCaoTon.Rows(currentRowIndex).DataBoundItem, BaoCaoTonDTO)
                                    txtMaBaoCaoTon.Text = bct.MaBaoCaoTon
                                    dtpThangBaoCaoTon.Value = bct.ThangBaoCao
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
End Class