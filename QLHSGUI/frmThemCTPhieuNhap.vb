Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmThemCTPhieuNhap
    Private ctpnBus As CTPhieuNhapBUS
    Private phieunhapBus As PhieuNhapBUS
    Private sachBus As SachBUS
    Private qdBus As QuyDinhBUS

    Private listPhieuNhap As List(Of PhieuNhapDTO)
    Private listSach As List(Of SachDTO)
    Private quydinh As QuyDinhDTO
    Private sach As SachDTO
    Private loaiSach As LoaiSachDTO
    Private phieunhap As PhieuNhapDTO

    Private Sub frmThemPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctpnBus = New CTPhieuNhapBUS
        sachBus = New SachBUS()

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

    Private Sub frmSoLuongNhapToiThieuAndTonToiDa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qdBus = New QuyDinhBUS()
        Dim listQuyDinh = New List(Of QuyDinhDTO)
        Dim result = qdBus.selectALL(listQuyDinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        quydinh = listQuyDinh(0)
        txtSoLuongNhapToiThieu.Text = quydinh.LuongNhapToiThieu
        txtSoLuongTonToiDa.Text = quydinh.LuongTonToiDa
    End Sub

    Private Sub loadListSach(maSach As String)
        Dim sachBus = New SachBUS()
        Dim listSach = New List(Of SachDTO)
        Dim result = sachBus.selectALL_ByMaSach(maSach, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        sach = listSach(0)
        txtSoLuongTonBanDau.Text = sach.SoLuongTon
        txtTenSach.Text = sach.TenSach
        txtTacGia.Text = sach.TacGia
        txtTheLoai.Text = sach.MaLoaiSach
    End Sub

    Private Sub loadlistLoaiSach(maLoai As String)
        Dim loaisachBus = New LoaiSachBUS()
        Dim listLoai = New List(Of LoaiSachDTO)
        Dim result = loaisachBus.selectAll_ByMaLoaiSach(maLoai, listLoai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin loại sách thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        loaiSach = listLoai(0)
        txtTheLoai.Text = loaiSach.TenLoaiSach
    End Sub

    Private Sub loadListPhieuNhap(maPhieu As String)
        phieunhapBus = New PhieuNhapBUS()
        listPhieuNhap = New List(Of PhieuNhapDTO)
        Dim result = phieunhapBus.selectAll_ByMaPhieuNhap(maPhieu, listPhieuNhap)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        phieunhap = listPhieuNhap(0)
        dtpNgayLapPhieu.Value = phieunhap.NgayNhap
    End Sub

    Private Sub btNhapCTPhieuNhapSach_Click(sender As Object, e As EventArgs) Handles btThemCTPN.Click
        Dim ctphieunhap As CTPhieuNhapDTO
        ctphieunhap = New CTPhieuNhapDTO()


        '1. Mapping data from GUI control
        ctphieunhap.MaChiTietPhieuNhap = Convert.ToInt32(txtMaCTPN.Text)
        ctphieunhap.MaPhieuNhap = txtMaPhieuNhap.Text
        ctphieunhap.MaSach = txtMaSach.Text
        ctphieunhap.SoLuongNhap = txtSoLuongNhap.Text
        '2. Business .....
        '3. Insert to DB
        Dim SoLuongNhap = Integer.Parse(txtSoLuongNhap.Text)
        Dim SoLuongNhapToiThieu = Integer.Parse(txtSoLuongNhapToiThieu.Text)
        Dim SoLuongTon = Integer.Parse(txtSoLuongTonBanDau.Text)
        Dim SoLuongTonToiDa = txtSoLuongTonToiDa.Text

        If (SoLuongNhap >= SoLuongNhapToiThieu) Then
            If (SoLuongTon < SoLuongTonToiDa) Then
                Dim result As Result
                result = ctpnBus.insert(ctphieunhap)

                'result = sachBus.update(SachDTO)
                If (result.FlagResult = True) Then
                    MessageBox.Show("Thêm chi tiết phiếu nhập thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Else
                MessageBox.Show("Thêm chi tiết phiếu nhập không thành công ! Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSoLuongNhap.Focus()
            End If
        Else
            MessageBox.Show("Thêm chi tiết phiếu nhập không thành công ! Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSoLuongNhap.Focus()
        End If
    End Sub

    Private Sub updateSoluongTonSauKhiNhap_Click(sender As Object, e As EventArgs) Handles btThemCTPN.Click
        Try
            Dim sach As SachDTO
            sach = New SachDTO()

            '1. Mapping data from GUI control
            sach.MaSach = txtMaSach.Text
            sach.SoLuongTon = txtSoLuongTonSauKhiNhap.Text
            '2. Business .....
            '3. Insert to DB
            Dim result As Result
            result = sachBus.update_SoLuongTon(sach)
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Private Sub txtMaSach_TextChanged(sender As Object, e As EventArgs) Handles txtMaSach.TextChanged
        Try
            Dim maSach = txtMaSach.Text
            loadListSach(maSach)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMaPhieuNhap_TextChanged(sender As Object, e As EventArgs) Handles txtMaPhieuNhap.TextChanged
        Try
            Dim maPhieu = txtMaPhieuNhap.Text
            loadListPhieuNhap(maPhieu)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTheLoai_TextChanged(sender As Object, e As EventArgs) Handles txtTheLoai.TextChanged
        Try
            Dim maLoai = txtTheLoai.Text
            loadlistLoaiSach(maLoai)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSoLuongNhap_TextChanged(sender As Object, e As EventArgs) Handles txtSoLuongNhap.TextChanged
        Dim soluongtontruockhinhap = Integer.Parse(txtSoLuongTonBanDau.Text)
        Dim soluongnhap = Integer.Parse(txtSoLuongNhap.Text)
        Dim soluongtoncuoi = soluongtontruockhinhap + soluongnhap
        txtSoLuongTonSauKhiNhap.Text = soluongtoncuoi
    End Sub

End Class