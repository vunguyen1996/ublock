Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmThemLoaiSach
    Private lsbus As LoaiSachBUS
    Private Sub frmThemLoaiSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsbus = New LoaiSachBUS

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = lsbus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaLoaiSach.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btNhapLoaiSach_Click(sender As Object, e As EventArgs) Handles btNhapLoaiSach.Click
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
        result = lsbus.insert(ls)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenLoaiSach.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = lsbus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaLoaiSach.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Thêm loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class