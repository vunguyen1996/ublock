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
        If (khbus.isValidName(kh) = False) Then
            MessageBox.Show("Tên khách hàng không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtHoTenKH.Focus()
            Return
        End If

        'If isValidEmail(txtEmail) = True Then
        '    MessageBox.Show("Email hợp lệ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    'proceed and save email
        'Else
        '    MessageBox.Show("Email không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'End If

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

    Public Sub New()
        InitializeComponent()
        txtEmail.ForeColor = Color.LightGray
        txtEmail.Text = "example@gmail.com"
    End Sub

    Private Sub txtEmail_Enter(sender As Object, e As EventArgs) Handles txtEmail.Enter
        If txtEmail.Text = "example@gmail.com" Then
            txtEmail.Text = ""
            txtEmail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If txtEmail.Text = "" Then
            txtEmail.Text = "example@gmail.com"
            txtEmail.ForeColor = Color.LightGray
        End If
    End Sub
End Class