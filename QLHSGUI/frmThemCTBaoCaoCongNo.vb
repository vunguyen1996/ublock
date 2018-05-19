Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmThemCTBaoCaoCongNo
    Private ctbccnBus As CTBaoCaoCongNoBUS

    Private khachhang As KhachHangDTO
    Private baocaoCN As BaoCaoCongNoDTO

    Private Sub frmThemCTBaoCaoCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctbccnBus = New CTBaoCaoCongNoBUS()
        Dim nextID As Integer
        Dim result As Result
        result = ctbccnBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaCTBCCN.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của chi tiết báo cáo công nợ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
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

    Private Sub loadListBaoCaoCongNo_byMaBaoCaoCongNo(maBaoCao As Integer)
        Dim bccnBus = New BaoCaoCongNoBUS()
        Dim listBCCN = New List(Of BaoCaoCongNoDTO)
        Dim result = bccnBus.selectAll_byMaBaoCao(maBaoCao, listBCCN)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin báo cáo theo mã báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        baocaoCN = listBCCN(0)
        dtpThangBaoCaoCongNo.Value = baocaoCN.ThangBaoCaoCongNo
    End Sub

    Private Sub txtMaKH_TextChanged(sender As Object, e As EventArgs) Handles txtMaKH.TextChanged
        Try
            Dim maKH = txtMaKH.Text
            loadListKhachHang_ByMaKH(maKH)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtMaBCCN.TextChanged
        Try
            Dim maBaoCao = txtMaBCCN.Text
            loadListBaoCaoCongNo_byMaBaoCaoCongNo(maBaoCao)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btThemCTBCCN_Click(sender As Object, e As EventArgs) Handles btThemCTBCCN.Click
        Dim ctbccn As CTBaoCaoCongNoDTO
        ctbccn = New CTBaoCaoCongNoDTO()

        '1. Mapping data from GUI control
        ctbccn.MaChiTietBaoCaoCongNo = Convert.ToInt32(txtMaCTBCCN.Text)
        ctbccn.MaKhachHang = Convert.ToInt32(txtMaKH.Text)
        ctbccn.MaBaoCaoCongNo = Convert.ToInt32(txtMaBCCN.Text)
        ctbccn.SoTienNoDau = txtSoTienNoDau.Text
        ctbccn.SoTienPhatSinh = txtSoTienPhatSinh.Text
        ctbccn.SoTienNoCuoi = txtSoTienNoCuoi.Text
        '2. Business .....
        '3. Insert to DB
        Dim result As Result
        result = ctbccnBus.insert(ctbccn)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm chi tiết báo cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMaCTBCCN.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = ctbccnBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaCTBCCN.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của chi tiết báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm chi tiết báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class