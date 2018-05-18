Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmLapHoaDon
    Private hdBus As HoaDonBUS
    Private khBus As KhachHangBUS

    Private khachhang As KhachHangDTO
    Private quydinh As QuyDinhDTO

    Private Sub frmThemhoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hdBus = New HoaDonBUS
        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = hdBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaHD.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub frmMaKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load id khach hang
        khBus = New KhachHangBUS()
        Dim listkh = New List(Of KhachHangDTO)
        ' Dim result As Result
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

    Private Sub frmTienNoToiDa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qdBus = New QuyDinhBUS()
        Dim listQuyDinh = New List(Of QuyDinhDTO)
        Dim result = qdBus.selectALL(listQuyDinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        quydinh = listQuyDinh(0)
        txtTienNoToiDa.Text = quydinh.TienNoToiDa
    End Sub

    Private Sub btThemHoaDon_Click(sender As Object, e As EventArgs) Handles btThemHoaDon.Click
        Dim hoadon As HoaDonDTO
        hoadon = New HoaDonDTO()
        '1. Mapping data from GUI control
        hoadon.MaHoaDon = Convert.ToInt32(txtMaHD.Text)
        hoadon.NgayHoaDon = dtpNgayLapHD.Value
        hoadon.MaKhachHang = txtMaKH.Text
        '2. Business .....
        '3. Insert to DB
        Dim tiennoKH = Integer.Parse(txtTienNo.Text)
        Dim tiennoToiDa = Integer.Parse(txtTienNoToiDa.Text)
        If tiennoKH <= tiennoToiDa Then
            Dim result As Result
            result = hdBus.insert(hoadon)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm hóa đơn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtMaHD.Text = String.Empty

                ' Get Next ID
                Dim nextID As Integer
                result = hdBus.getNextID(nextID)
                If (result.FlagResult = True) Then
                    txtMaHD.Text = nextID.ToString()
                Else
                    MessageBox.Show("Lấy ID kế tiếp của hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If

            Else
                MessageBox.Show("Thêm hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Thêm hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'System.Console.WriteLine(Result.SystemMessage)
        End If
    End Sub

    Private Sub txtMaKH_TextChanged(sender As Object, e As EventArgs) Handles txtMaKH.TextChanged
        Try
            Dim maKH = txtMaKH.Text
            loadListKhachHang_ByMaKH(maKH)
        Catch ex As Exception

        End Try
    End Sub
End Class