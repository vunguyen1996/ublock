Imports QLHS1BUS
Imports QLHS1DTO

Public Class frmQuyDinh
    Dim qdBus As QuyDinhBUS
    Dim quydinh As QuyDinhDTO

    Private Sub frmQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qdBus = New QuyDinhBUS()
        Dim listQuyDinh = New List(Of QuyDinhDTO)
        Dim result = qdBus.selectALL(listQuyDinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        quydinh = listQuyDinh(0)
        txtLuongNhapToiThieu.Text = quydinh.LuongNhapToiThieu
        txtLuongTonToiDa.Text = quydinh.LuongTonToiDa
        txtTienNoToiDa.Text = quydinh.TienNoToiDa
        txtLuongTonToiThieu.Text = quydinh.LuongTonToiThieu
    End Sub

    Private Sub btCapNhatQuyDinh_Click(sender As Object, e As EventArgs) Handles btCapNhatQuyDinh.Click
        Try
            quydinh.LuongNhapToiThieu = Integer.Parse(txtLuongNhapToiThieu.Text)
            quydinh.LuongTonToiDa = Integer.Parse(txtLuongTonToiDa.Text)
            quydinh.TienNoToiDa = Integer.Parse(txtTienNoToiDa.Text)
            quydinh.LuongTonToiThieu = Integer.Parse(txtLuongTonToiThieu.Text)
            Dim result = qdBus.update(quydinh)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            MessageBox.Show("Cập nhật Quy Định thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub
End Class