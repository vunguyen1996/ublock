Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmLapPhieuThuTien
    Private phieuThuBus As PhieuThuTienBUS
    Private khBus As KhachHangBUS
    Private qdBus As QuyDinhBUS

    Private listKH As List(Of KhachHangDTO)
    Private listQD As List(Of QuyDinhDTO)
    Private khachhang As KhachHangDTO
    Private quydinh As QuyDinhDTO

    Private Sub frmLapPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieuThuBus = New PhieuThuTienBUS()
        Dim nextID As Integer
        Dim result As Result
        result = phieuThuBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaPhieuThuTien.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của phiếu thu tiền không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
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

    Private Sub frmApDungQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qdBus = New QuyDinhBUS()
        Dim listQuyDinh = New List(Of QuyDinhDTO)
        Dim result = qdBus.selectALL(listQuyDinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        quydinh = listQuyDinh(0)
        cbqd.Checked = quydinh.ApDung
    End Sub

    Private Sub txtMaKH_TextChanged(sender As Object, e As EventArgs) Handles txtMaKH.TextChanged
        Try
            Dim maKH = txtMaKH.Text
            loadKhachHang_ByMaKH(maKH)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btThemPhieuThuTien_Click(sender As Object, e As EventArgs) Handles btThemPhieuThuTien.Click
        Dim phieuThu As PhieuThuTienDTO
        phieuThu = New PhieuThuTienDTO()
        '1. Mapping data from GUI control
        phieuThu.MaPhieuThu = Convert.ToInt32(txtMaPhieuThuTien.Text)
        phieuThu.MaKhachHang = Convert.ToInt32(txtMaKH.Text)
        phieuThu.NgayThu = dtpNgayLapPhieuThuTien.Text
        phieuThu.SoTienThu = txtTienThu.Text

        Dim sotienthu = txtTienThu.Text
        Dim sotienno = txtTienNo.Text
        If cbqd.Checked = True Then
            If sotienthu <= sotienno Then
                Dim result As Result
                result = phieuThuBus.insert(phieuThu)
                MessageBox.Show("Thêm sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Get Next ID
                Dim nextID As Integer
                result = phieuThuBus.getNextID(nextID)
                If (result.FlagResult = True) Then
                    txtMaPhieuThuTien.Text = nextID.ToString()
                Else
                    MessageBox.Show("Lấy ID kế tiếp của sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Else
                MessageBox.Show("Thêm không thành công vì số tiền thu lớn hơn số tiền nợ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTienThu.Focus()
                'System.Console.WriteLine(Result.SystemMessage)
            End If
        Else
            Dim result As Result
            result = phieuThuBus.insert(phieuThu)
            MessageBox.Show("Thêm thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Get Next ID
            Dim nextID As Integer
            result = phieuThuBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaPhieuThuTien.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        End If
    End Sub
End Class