Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmThemPhieuNhap
    Private pnBus As PhieuNhapBUS
    Private Sub frmThemPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnBus = New PhieuNhapBUS
        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = pnBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaPhieuNhapSach.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btNhapPhieuNhapSach_Click(sender As Object, e As EventArgs) Handles btNhapPhieuNhapSach.Click
        Dim phieunhap As PhieuNhapDTO
        phieunhap = New PhieuNhapDTO()

        '1. Mapping data from GUI control
        phieunhap.MaPhieuNhap = Convert.ToInt32(txtMaPhieuNhapSach.Text)
        phieunhap.NgayNhap = dtpNgayLapPhieu.Value
        '2. Business .....
        '3. Insert to DB
        Dim result As Result
        result = pnBus.insert(phieunhap)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm phiếu nhập thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMaPhieuNhapSach.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = pnBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaPhieuNhapSach.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class