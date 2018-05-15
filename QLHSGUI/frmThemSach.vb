Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmThemSach
    Private sachBus As SachBUS
    Private loaisachBus As LoaiSachBUS

    Private listLoaiSach As List(Of LoaiSachDTO)

    Private Sub frmThemLoaiSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sachBus = New SachBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = sachBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaSach.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub frmLoaiSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load id loai sach
        loaisachBus = New LoaiSachBUS()
        Dim listLoaiSach = New List(Of LoaiSachDTO)
        ' Dim result As Result
        Dim result = loaisachBus.selectAll(listLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbbLoaiSach.DataSource = New BindingSource(listLoaiSach, String.Empty)
        cbbLoaiSach.DisplayMember = "TENLOAISACH"
        cbbLoaiSach.ValueMember = "MALOAISACH"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbbLoaiSach.DataSource)
        myCurrencyManager.Refresh()
        If (listLoaiSach.Count > 0) Then
            cbbLoaiSach.SelectedIndex = 0
        End If
    End Sub

    Private Sub btThemSach_Click(sender As Object, e As EventArgs) Handles btThemSach.Click
        Dim sach As SachDTO
        sach = New SachDTO()

        '1. Mapping data from GUI control
        sach.MaSach = Convert.ToInt32(txtMaSach.Text)
        sach.TenSach = txtTenSach.Text
        sach.TacGia = txtTacGia.Text
        sach.SoLuongTon = txtSoLuongTon.Text 
        sach.MaLoaiSach = Convert.ToInt32(cbbLoaiSach.SelectedValue)

        '2. Business .....
        If (sachBus.isValidName(sach) = False) Then
            MessageBox.Show("Tên sách không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenSach.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = sachBus.insert(sach)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenSach.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = sachBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaSach.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Thêm sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class