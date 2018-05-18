Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmThemKhachHang
    Private khbus As KhachHangBUS

    Private Sub frmThemKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khbus = New KhachHangBUS

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = khbus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaKH.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btThemKhachHang_Click(sender As Object, e As EventArgs) Handles btThemKhachHang.Click
        Dim kh As KhachHangDTO
        kh = New KhachHangDTO()

        '1. Mapping data from GUI control
        kh.MaKH = Convert.ToInt32(txtMaKH.Text)
        kh.TenKhachHang = txtHoTenKH.Text
        kh.TienNoKH = txtTienNoKH.Text
        kh.DiaChiKH = txtDiaChi.Text
        kh.Email = txtEmail.Text
        kh.SDT = txtSDT.Text
        '2. Business .....
        'check name
        If (khbus.isValidName(kh) = False) Then
            MessageBox.Show("Tên khách hàng không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtHoTenKH.Focus()
            Return
        End If

        'check email
        If (khbus.IsValidEmailFormat(txtEmail.Text) = False) Then
            MessageBox.Show("Địa chỉ email không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            Return
        End If

        '3. Insert to DB
        Dim result As Result
        result = khbus.insert(kh)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm khách hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtHoTenKH.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = khbus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaKH.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Thêm khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class