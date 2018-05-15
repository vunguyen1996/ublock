Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmThemCTPhieuNhap
    Private ctpnBus As CTPhieuNhapBUS
    Private phieunhapBus As PhieuNhapBUS
    Private sachBus As SachBUS

    Private listPhieuNhap As List(Of PhieuNhapDTO)
    Private listSach As List(Of SachDTO)

    Private Sub frmThemPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctpnBus = New CTPhieuNhapBUS
        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = ctpnBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaCTPN.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của chi tiết phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub frmPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load id phieu nhap
        phieunhapBus = New PhieuNhapBUS()
        Dim listPhieuNhap = New List(Of PhieuNhapDTO)
        ' Dim result As Result
        Dim result = phieunhapBus.selectAll(listPhieuNhap)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbbMaPN.DataSource = New BindingSource(listPhieuNhap, String.Empty)
        cbbMaPN.DisplayMember = "MAPHIEUNHAP"
        cbbMaPN.ValueMember = "MAPHIEUNHAP"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbbMaPN.DataSource)
        myCurrencyManager.Refresh()
        If (listPhieuNhap.Count > 0) Then
            cbbMaPN.SelectedIndex = 0
        End If
    End Sub

    Private Sub cbbMaPN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbMaPN.SelectedIndexChanged
        'load id sach
        sachBus = New SachBUS()
        Dim listSach = New List(Of SachDTO)
        Dim result As Result
        result = sachBus.selectAll(listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        cbbMaSach.DataSource = New BindingSource(listSach, String.Empty)
        cbbMaSach.DisplayMember = "MASACH"
        cbbMaSach.ValueMember = "TenSach"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbbMaSach.DataSource)
        myCurrencyManager.Refresh()
        cbbMaSach.SelectedIndex = 0
        If (listSach.Count > 0) Then
            cbbMaSach.SelectedIndex = 0
        End If
    End Sub

    Private Sub btNhapCTPhieuNhapSach_Click(sender As Object, e As EventArgs) Handles btThemCTPN.Click
        Dim ctphieunhap As CTPhieuNhapDTO
        ctphieunhap = New CTPhieuNhapDTO()

        '1. Mapping data from GUI control
        ctphieunhap.MaChiTietPhieuNhap = Convert.ToInt32(txtMaCTPN.Text)
        ctphieunhap.MaPhieuNhap = cbbMaPN.Text
        ctphieunhap.MaSach = cbbMaSach.Text
        ctphieunhap.SoLuongNhap = txtSoLuongNhap.Text
        '2. Business .....
        '3. Insert to DB
        Dim result As Result
        result = ctpnBus.insert(ctphieunhap)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm phiếu nhập thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMaCTPN.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = ctpnBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaCTPN.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của chi tiết phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm chi tiết phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

End Class