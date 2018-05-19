<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQLKhachHang
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btXoaKhachHang = New System.Windows.Forms.Button()
        Me.btCapNhatKhachHang = New System.Windows.Forms.Button()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTienNoKH = New System.Windows.Forms.TextBox()
        Me.txtHoTenKH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvListKhachHang = New System.Windows.Forms.DataGridView()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btTimKiemTheHoTen = New System.Windows.Forms.Button()
        Me.btTimKiemTheoMAKH = New System.Windows.Forms.Button()
        Me.txtMaKHTimKiem = New System.Windows.Forms.TextBox()
        Me.txtHoTenKHTimKiem = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvListKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(11, 295)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(644, 267)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btXoaKhachHang)
        Me.TabPage1.Controls.Add(Me.btCapNhatKhachHang)
        Me.TabPage1.Controls.Add(Me.txtDiaChi)
        Me.TabPage1.Controls.Add(Me.txtSDT)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtTienNoKH)
        Me.TabPage1.Controls.Add(Me.txtHoTenKH)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtMaKH)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(636, 241)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Khách Hàng"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btXoaKhachHang
        '
        Me.btXoaKhachHang.Location = New System.Drawing.Point(320, 212)
        Me.btXoaKhachHang.Name = "btXoaKhachHang"
        Me.btXoaKhachHang.Size = New System.Drawing.Size(75, 23)
        Me.btXoaKhachHang.TabIndex = 32
        Me.btXoaKhachHang.Text = "Xóa"
        Me.btXoaKhachHang.UseVisualStyleBackColor = True
        '
        'btCapNhatKhachHang
        '
        Me.btCapNhatKhachHang.Location = New System.Drawing.Point(239, 212)
        Me.btCapNhatKhachHang.Name = "btCapNhatKhachHang"
        Me.btCapNhatKhachHang.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhatKhachHang.TabIndex = 31
        Me.btCapNhatKhachHang.Text = "Cập nhật"
        Me.btCapNhatKhachHang.UseVisualStyleBackColor = True
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(175, 85)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(294, 67)
        Me.txtDiaChi.TabIndex = 34
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(175, 182)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(294, 20)
        Me.txtSDT.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Số Điện Thoại"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(175, 158)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(294, 20)
        Me.txtEmail.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Địa Chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Tiền Nợ Khách Hàng"
        '
        'txtTienNoKH
        '
        Me.txtTienNoKH.Location = New System.Drawing.Point(175, 59)
        Me.txtTienNoKH.Name = "txtTienNoKH"
        Me.txtTienNoKH.Size = New System.Drawing.Size(294, 20)
        Me.txtTienNoKH.TabIndex = 20
        '
        'txtHoTenKH
        '
        Me.txtHoTenKH.Location = New System.Drawing.Point(175, 33)
        Me.txtHoTenKH.Name = "txtHoTenKH"
        Me.txtHoTenKH.Size = New System.Drawing.Size(294, 20)
        Me.txtHoTenKH.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Họ Tên Khách Hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Mã Khách Hàng"
        '
        'txtMaKH
        '
        Me.txtMaKH.Enabled = False
        Me.txtMaKH.Location = New System.Drawing.Point(175, 7)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.ReadOnly = True
        Me.txtMaKH.Size = New System.Drawing.Size(294, 20)
        Me.txtMaKH.TabIndex = 16
        Me.txtMaKH.WordWrap = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Mã Khách Hàng"
        '
        'dgvListKhachHang
        '
        Me.dgvListKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListKhachHang.Location = New System.Drawing.Point(6, 6)
        Me.dgvListKhachHang.Name = "dgvListKhachHang"
        Me.dgvListKhachHang.Size = New System.Drawing.Size(624, 153)
        Me.dgvListKhachHang.TabIndex = 19
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(12, 102)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(644, 191)
        Me.TabControl2.TabIndex = 20
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvListKhachHang)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(636, 165)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Danh Sách Khách Hàng"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage4)
        Me.TabControl3.Location = New System.Drawing.Point(11, 12)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(644, 88)
        Me.TabControl3.TabIndex = 30
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btTimKiemTheHoTen)
        Me.TabPage4.Controls.Add(Me.btTimKiemTheoMAKH)
        Me.TabPage4.Controls.Add(Me.txtMaKHTimKiem)
        Me.TabPage4.Controls.Add(Me.txtHoTenKHTimKiem)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(636, 62)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Tìm Kiếm"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btTimKiemTheHoTen
        '
        Me.btTimKiemTheHoTen.Location = New System.Drawing.Point(476, 33)
        Me.btTimKiemTheHoTen.Name = "btTimKiemTheHoTen"
        Me.btTimKiemTheHoTen.Size = New System.Drawing.Size(75, 20)
        Me.btTimKiemTheHoTen.TabIndex = 32
        Me.btTimKiemTheHoTen.Text = "Search"
        Me.btTimKiemTheHoTen.UseVisualStyleBackColor = True
        '
        'btTimKiemTheoMAKH
        '
        Me.btTimKiemTheoMAKH.Location = New System.Drawing.Point(476, 7)
        Me.btTimKiemTheoMAKH.Name = "btTimKiemTheoMAKH"
        Me.btTimKiemTheoMAKH.Size = New System.Drawing.Size(75, 20)
        Me.btTimKiemTheoMAKH.TabIndex = 31
        Me.btTimKiemTheoMAKH.Text = "Search"
        Me.btTimKiemTheoMAKH.UseVisualStyleBackColor = True
        '
        'txtMaKHTimKiem
        '
        Me.txtMaKHTimKiem.Location = New System.Drawing.Point(176, 7)
        Me.txtMaKHTimKiem.Name = "txtMaKHTimKiem"
        Me.txtMaKHTimKiem.Size = New System.Drawing.Size(294, 20)
        Me.txtMaKHTimKiem.TabIndex = 30
        '
        'txtHoTenKHTimKiem
        '
        Me.txtHoTenKHTimKiem.Location = New System.Drawing.Point(176, 33)
        Me.txtHoTenKHTimKiem.Name = "txtHoTenKHTimKiem"
        Me.txtHoTenKHTimKiem.Size = New System.Drawing.Size(294, 20)
        Me.txtHoTenKHTimKiem.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Họ Tên Khách Hàng"
        '
        'frmQLKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 574)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmQLKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Khách Hàng"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvListKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTienNoKH As TextBox
    Friend WithEvents txtHoTenKH As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvListKhachHang As DataGridView
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txtHoTenKHTimKiem As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btCapNhatKhachHang As Button
    Friend WithEvents btXoaKhachHang As Button
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtMaKHTimKiem As TextBox
    Friend WithEvents btTimKiemTheoMAKH As Button
    Friend WithEvents btTimKiemTheHoTen As Button
End Class
