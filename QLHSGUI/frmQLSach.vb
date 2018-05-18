Imports QLHS1BUS
Imports QLHS1DTO
Imports Utility

Public Class frmQLSach
    Private sachBus As SachBUS
    Private loaisachBus As LoaiSachBUS
    Private sach As SachDTO

    Private loaisach As LoaiSachDTO

    Private Sub frmQLSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sachBus = New SachBUS()
        loaisachBus = New LoaiSachBUS()

        'Load loai sach
        Dim listLoaiSach = New List(Of LoaiSachDTO)
        Dim result As Result
        result = loaisachBus.selectAll(listLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbbLoaiSach.DataSource = New BindingSource(listLoaiSach, String.Empty)
        cbbLoaiSach.DisplayMember = "TENLOAISACH"
        cbbLoaiSach.ValueMember = "MALOAISACH"

        cbbLoaiSachCapNhat.DataSource = New BindingSource(listLoaiSach, String.Empty)
        cbbLoaiSachCapNhat.DisplayMember = "TENLOAISACH"
        cbbLoaiSachCapNhat.ValueMember = "MALOAISACH"
    End Sub

    'Private Sub frmSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    sachBus = New SachBUS
    '    Dim listSach = New List(Of SachDTO)
    '    Dim result = sachBus.selectAll(listSach)
    '    If (result.FlagResult = False) Then
    '        MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        System.Console.WriteLine(result.SystemMessage)
    '    End If
    '    sachDTO = listSach(0)
    '    cbbLoaiSachCapNhat.Text = Convert.
    'End Sub

    Private Sub loadListSach()
        Dim listSach = New List(Of SachDTO)
        Dim result As Result
        result = sachBus.selectAll(listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListSach.SuspendLayout()
        dgvListSach.Columns.Clear()
        dgvListSach.DataSource = Nothing

        dgvListSach.AutoGenerateColumns = False
        dgvListSach.AllowUserToAddRows = False
        dgvListSach.DataSource = listSach

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MASACH"
        clMa.HeaderText = "Mã Sách"
        clMa.DataPropertyName = "MASACH"
        dgvListSach.Columns.Add(clMa)

        Dim clTenSach = New DataGridViewTextBoxColumn()
        clTenSach.Name = "TenSach"
        clTenSach.HeaderText = "Tên Sach"
        clTenSach.DataPropertyName = "TenSach"
        dgvListSach.Columns.Add(clTenSach)

        Dim clTacGia = New DataGridViewTextBoxColumn()
        clTacGia.Name = "TacGia"
        clTacGia.HeaderText = "Tác Giả"
        clTacGia.DataPropertyName = "TacGia"
        dgvListSach.Columns.Add(clTacGia)
        'dgvListSach.ResumeLayout()

        Dim clSL = New DataGridViewTextBoxColumn()
        clSL.Name = "SoLuongTon"
        clSL.HeaderText = "Số Lượng Tồn"
        clSL.DataPropertyName = "SoLuongTon"
        dgvListSach.Columns.Add(clSL)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListSach.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub loadListSach_ByMaLoaiSach(maLoaiSach As String)
        Dim listSach = New List(Of SachDTO)
        Dim result As Result
        result = sachBus.selectALL_ByType(maLoaiSach, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách theo loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListSach.SuspendLayout()
        dgvListSach.Columns.Clear()
        dgvListSach.DataSource = Nothing

        dgvListSach.AutoGenerateColumns = False
        dgvListSach.AllowUserToAddRows = False
        dgvListSach.DataSource = listSach

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MASACH"
        clMa.HeaderText = "Mã Sách"
        clMa.DataPropertyName = "MASACH"
        dgvListSach.Columns.Add(clMa)

        Dim clTenSach = New DataGridViewTextBoxColumn()
        clTenSach.Name = "TenSach"
        clTenSach.HeaderText = "Tên Sách"
        clTenSach.DataPropertyName = "TenSach"
        dgvListSach.Columns.Add(clTenSach)

        Dim clTacGia = New DataGridViewTextBoxColumn()
        clTacGia.Name = "TacGia"
        clTacGia.HeaderText = "Tác Giả"
        clTacGia.DataPropertyName = "TacGia"
        dgvListSach.Columns.Add(clTacGia)

        Dim clSL = New DataGridViewTextBoxColumn()
        clSL.Name = "SoLuongTon"
        clSL.HeaderText = "Số Lượng Tồn"
        clSL.DataPropertyName = "SoLuongTon"
        dgvListSach.Columns.Add(clSL)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListSach.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub loadListSach_ByTenSach(tenSach As String)
        Dim listSach = New List(Of SachDTO)
        Dim result As Result
        result = sachBus.selectALL_ByName(tenSach, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách theo tên sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListSach.SuspendLayout()
        dgvListSach.Columns.Clear()
        dgvListSach.DataSource = Nothing

        dgvListSach.AutoGenerateColumns = False
        dgvListSach.AllowUserToAddRows = False
        dgvListSach.DataSource = listSach

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MASACH"
        clMa.HeaderText = "Mã Sách"
        clMa.DataPropertyName = "MASACH"
        dgvListSach.Columns.Add(clMa)

        Dim clTenSach = New DataGridViewTextBoxColumn()
        clTenSach.Name = "TenSach"
        clTenSach.HeaderText = "Tên Sách"
        clTenSach.DataPropertyName = "TenSach"
        dgvListSach.Columns.Add(clTenSach)

        Dim clTacGia = New DataGridViewTextBoxColumn()
        clTacGia.Name = "TacGia"
        clTacGia.HeaderText = "Tác Giả"
        clTacGia.DataPropertyName = "TacGia"
        dgvListSach.Columns.Add(clTacGia)

        Dim clSL = New DataGridViewTextBoxColumn()
        clSL.Name = "SoLuongTon"
        clSL.HeaderText = "Số Lượng Tồn"
        clSL.DataPropertyName = "SoLuongTon"
        dgvListSach.Columns.Add(clSL)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListSach.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    'Private Sub loadTenLoaiSach_ByMaLoaiSach(maLoai As String)
    '    Dim loaisachBus = New LoaiSachBUS()
    '    Dim listLoai = New List(Of LoaiSachDTO)
    '    Dim result = loaisachBus.selectAll_ByMaLoaiSach(maLoai, listLoai)
    '    If (result.FlagResult = False) Then
    '        MessageBox.Show("Lấy thông tin loại sách thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        System.Console.WriteLine(result.SystemMessage)
    '    End If
    '    loaisach = listLoai(0)
    '    cbbLoaiSachCapNhat.Text = loaisach.TenLoaiSach
    'End Sub

    'Private Sub loadMaLoaiSach_BymaSach(maSach As String)
    '    Dim listSach = New List(Of SachDTO)
    '    Dim result As Result
    '    result = sachBus.selectALL_ByType(maSach, listSach)
    '    If (result.FlagResult = False) Then
    '        MessageBox.Show("Lấy danh sách sách theo loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        System.Console.WriteLine(result.SystemMessage)
    '        Return
    '    End If
    '    sach = listSach(0)
    '    cbbLoaiSachCapNhat.Text = sach.MaLoaiSach
    'End Sub

    Private Sub dgvListSach_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvListSach.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListSach.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListSach.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListSach.RowCount) Then
            Try
                Dim sach = CType(dgvListSach.Rows(currentRowIndex).DataBoundItem, SachDTO)
                txtMaSach.Text = sach.MaSach
                txtTenSach.Text = sach.TenSach
                txtTacGia.Text = sach.TacGia
                txtSoLuongTon.Text = sach.SoLuongTon
                cbbLoaiSachCapNhat.SelectedIndex = cbbLoaiSach.SelectedIndex
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btCapNhatSach.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListSach.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListSach.RowCount) Then
            Try
                Dim sach As SachDTO
                sach = New SachDTO()

                '1. Mapping data from GUI control
                sach.MaSach = txtMaSach.Text
                sach.TenSach = txtTenSach.Text
                sach.TacGia = txtTacGia.Text
                sach.SoLuongTon = txtSoLuongTon.Text
                sach.MaLoaiSach = Convert.ToInt32(cbbLoaiSachCapNhat.SelectedValue)
                '2. Business .....
                If (sachBus.isValidName(sach) = False) Then
                    MessageBox.Show("Tên sách không đúng.")
                    txtTenSach.Focus()
                    Return
                End If
                '3. Insert to DB
                Dim result As Result
                result = sachBus.update(sach)
                If (result.FlagResult = True) Then
                    ' Re-Load sach list
                    loadListSach_ByMaLoaiSach(cbbLoaiSach.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvListSach.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btXoaSach.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListSach.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListSach.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa sách có mã số là " + txtMaSach.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = sachBus.delete(txtMaSach.Text)
                        If (result.FlagResult = True) Then
                            ' Re-Load LoaiHocSinh list
                            loadListSach_ByMaLoaiSach(cbbLoaiSach.SelectedValue)
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListSach.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListSach.Rows(currentRowIndex).Selected = True
                            End If
                            MessageBox.Show("Xóa sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select
        End If
    End Sub

    Private Sub cbbLoaiSach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbLoaiSach.SelectedIndexChanged
        Try
            Dim maLoai = Convert.ToInt32(cbbLoaiSach.SelectedValue)
            loadListSach_ByMaLoaiSach(maLoai)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btTenSachTimKiem_Click(sender As Object, e As EventArgs) Handles btTenSachTimKiem.Click
        Try
            Dim tenSach = txtTenSachTimKiem.Text
            loadListSach_ByTenSach(tenSach)
        Catch ex As Exception
        End Try
    End Sub

    'txtTenSachTimKiem
    Public Sub New()
        InitializeComponent()
        txtTenSachTimKiem.ForeColor = Color.LightGray
        txtTenSachTimKiem.Text = "Vui Lòng Nhập Tên Sách Muốn Tra Cứu"
    End Sub

    Private Sub txtTenSachTimKiem_Enter(sender As Object, e As EventArgs) Handles txtTenSachTimKiem.Enter
        If txtTenSachTimKiem.Text = "Vui Lòng Nhập Tên Sách Muốn Tra Cứu" Then
            txtTenSachTimKiem.Text = ""
            txtTenSachTimKiem.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtTenSachTimKiem_Leave(sender As Object, e As EventArgs) Handles txtTenSachTimKiem.Leave
        If txtTenSachTimKiem.Text = "" Then
            txtTenSachTimKiem.Text = "Vui Lòng Nhập Tên Sách Muốn Tra Cứu"
            txtTenSachTimKiem.ForeColor = Color.LightGray
        End If
    End Sub
End Class