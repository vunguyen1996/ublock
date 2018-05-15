<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQLSach
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvListSach = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cbbLoaiSach = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtSoLuongTon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbbLoaiSachCapNhat = New System.Windows.Forms.ComboBox()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.btCapNhatSach = New System.Windows.Forms.Button()
        Me.btXoaSach = New System.Windows.Forms.Button()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btTraCuu = New System.Windows.Forms.Button()
        Me.txtTenSachTimKiem = New System.Windows.Forms.TextBox()
        CType(Me.dgvListSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListSach
        '
        Me.dgvListSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListSach.Location = New System.Drawing.Point(6, 6)
        Me.dgvListSach.Name = "dgvListSach"
        Me.dgvListSach.Size = New System.Drawing.Size(427, 138)
        Me.dgvListSach.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 78)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(447, 176)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvListSach)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(439, 150)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Danh Sách Sách"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cbbLoaiSach
        '
        Me.cbbLoaiSach.FormattingEnabled = True
        Me.cbbLoaiSach.Location = New System.Drawing.Point(96, 6)
        Me.cbbLoaiSach.Name = "cbbLoaiSach"
        Me.cbbLoaiSach.Size = New System.Drawing.Size(254, 21)
        Me.cbbLoaiSach.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Loại sách"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(461, 78)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(447, 176)
        Me.TabControl2.TabIndex = 27
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtSoLuongTon)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.cbbLoaiSachCapNhat)
        Me.TabPage2.Controls.Add(Me.txtTacGia)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtTenSach)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtMaSach)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(439, 150)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Thông Tin Sách"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtSoLuongTon
        '
        Me.txtSoLuongTon.Location = New System.Drawing.Point(125, 116)
        Me.txtSoLuongTon.Name = "txtSoLuongTon"
        Me.txtSoLuongTon.Size = New System.Drawing.Size(254, 20)
        Me.txtSoLuongTon.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Số Lượng Tồn"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Tác Giả"
        '
        'cbbLoaiSachCapNhat
        '
        Me.cbbLoaiSachCapNhat.FormattingEnabled = True
        Me.cbbLoaiSachCapNhat.Location = New System.Drawing.Point(125, 63)
        Me.cbbLoaiSachCapNhat.Name = "cbbLoaiSachCapNhat"
        Me.cbbLoaiSachCapNhat.Size = New System.Drawing.Size(254, 21)
        Me.cbbLoaiSachCapNhat.TabIndex = 30
        '
        'txtTacGia
        '
        Me.txtTacGia.Location = New System.Drawing.Point(125, 90)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(254, 20)
        Me.txtTacGia.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Thể Loại"
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(125, 37)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(254, 20)
        Me.txtTenSach.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Tên Sách"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sách"
        '
        'txtMaSach
        '
        Me.txtMaSach.Location = New System.Drawing.Point(125, 11)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.ReadOnly = True
        Me.txtMaSach.Size = New System.Drawing.Size(254, 20)
        Me.txtMaSach.TabIndex = 25
        Me.txtMaSach.WordWrap = False
        '
        'btCapNhatSach
        '
        Me.btCapNhatSach.Location = New System.Drawing.Point(380, 256)
        Me.btCapNhatSach.Name = "btCapNhatSach"
        Me.btCapNhatSach.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhatSach.TabIndex = 28
        Me.btCapNhatSach.Text = "Cập nhật"
        Me.btCapNhatSach.UseVisualStyleBackColor = True
        '
        'btXoaSach
        '
        Me.btXoaSach.Location = New System.Drawing.Point(461, 256)
        Me.btXoaSach.Name = "btXoaSach"
        Me.btXoaSach.Size = New System.Drawing.Size(75, 23)
        Me.btXoaSach.TabIndex = 29
        Me.btXoaSach.Text = "Xóa"
        Me.btXoaSach.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Location = New System.Drawing.Point(12, 12)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(896, 60)
        Me.TabControl3.TabIndex = 30
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btTraCuu)
        Me.TabPage3.Controls.Add(Me.txtTenSachTimKiem)
        Me.TabPage3.Controls.Add(Me.cbbLoaiSach)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(888, 34)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Tìm Kiếm"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btTraCuu
        '
        Me.btTraCuu.Location = New System.Drawing.Point(493, 7)
        Me.btTraCuu.Name = "btTraCuu"
        Me.btTraCuu.Size = New System.Drawing.Size(75, 23)
        Me.btTraCuu.TabIndex = 31
        Me.btTraCuu.Text = "Tra Cứu"
        Me.btTraCuu.UseVisualStyleBackColor = True
        '
        'txtTenSachTimKiem
        '
        Me.txtTenSachTimKiem.Location = New System.Drawing.Point(574, 9)
        Me.txtTenSachTimKiem.Name = "txtTenSachTimKiem"
        Me.txtTenSachTimKiem.Size = New System.Drawing.Size(254, 20)
        Me.txtTenSachTimKiem.TabIndex = 35
        '
        'frmQLSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 285)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.btXoaSach)
        Me.Controls.Add(Me.btCapNhatSach)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmQLSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Sách"
        CType(Me.dgvListSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvListSach As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtSoLuongTon As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbbLoaiSachCapNhat As ComboBox
    Friend WithEvents txtTacGia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbbLoaiSach As ComboBox
    Friend WithEvents btCapNhatSach As Button
    Friend WithEvents btXoaSach As Button
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtTenSachTimKiem As TextBox
    Friend WithEvents btTraCuu As Button
End Class
