Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmLapBaoCaoCongNo
    Private bccnBus As BaoCaoCongNoBUS

    Private Sub frmLapBaoCaoCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bccnBus = New BaoCaoCongNoBUS()
        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = bccnBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaBaoCaoCongNo.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của báo cáo tồn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btThemBaoCaoCongNo_Click(sender As Object, e As EventArgs) Handles btThemBaoCaoCongNo.Click
        Dim bccn As BaoCaoCongNoDTO
        bccn = New BaoCaoCongNoDTO()

        '1. Mapping data from GUI control
        bccn.MaBaoCaoCongNo = Convert.ToInt32(txtMaBaoCaoCongNo.Text)
        bccn.ThangBaoCaoCongNo = dtpThangBaoCaoCongNo.Value.ToShortDateString
        '2. Business .....
        '3. Insert to DB
        Dim result As Result
        result = bccnBus.insert(bccn)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm báo cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMaBaoCaoCongNo.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = bccnBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaBaoCaoCongNo.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class