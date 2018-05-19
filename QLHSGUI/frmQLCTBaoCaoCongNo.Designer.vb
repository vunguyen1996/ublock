<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLCTBaoCaoCongNo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvListCTBaoCaoCongNo = New System.Windows.Forms.DataGridView()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtMaBCCN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSoTienNoCuoi = New System.Windows.Forms.TextBox()
        Me.txtSoTienPhatSinh = New System.Windows.Forms.TextBox()
        Me.txtSoTienNoDau = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpThangBaoCaoCongNo = New System.Windows.Forms.DateTimePicker()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTienNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtHoTenKH = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaCTBCCN = New System.Windows.Forms.TextBox()
        Me.btCapNhatCTBCCN = New System.Windows.Forms.Button()
        Me.btXoaCTBCCN = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvListCTBaoCaoCongNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 74)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(539, 340)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvListCTBaoCaoCongNo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(531, 314)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Danh Sách Chi Tiết Báo Cáo Công Nợ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvListCTBaoCaoCongNo
        '
        Me.dgvListCTBaoCaoCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListCTBaoCaoCongNo.Location = New System.Drawing.Point(6, 6)
        Me.dgvListCTBaoCaoCongNo.Name = "dgvListCTBaoCaoCongNo"
        Me.dgvListCTBaoCaoCongNo.Size = New System.Drawing.Size(519, 302)
        Me.dgvListCTBaoCaoCongNo.TabIndex = 2
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(535, 56)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtMaBCCN)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(527, 30)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Tìm Kiếm"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtMaBCCN
        '
        Me.txtMaBCCN.Location = New System.Drawing.Point(194, 4)
        Me.txtMaBCCN.Name = "txtMaBCCN"
        Me.txtMaBCCN.Size = New System.Drawing.Size(154, 20)
        Me.txtMaBCCN.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Mã Báo Cáo Công Nợ"
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Location = New System.Drawing.Point(553, 12)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(440, 402)
        Me.TabControl3.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btXoaCTBCCN)
        Me.TabPage3.Controls.Add(Me.btCapNhatCTBCCN)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.txtSoTienNoCuoi)
        Me.TabPage3.Controls.Add(Me.txtSoTienPhatSinh)
        Me.TabPage3.Controls.Add(Me.txtSoTienNoDau)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.dtpThangBaoCaoCongNo)
        Me.TabPage3.Controls.Add(Me.txtMaKH)
        Me.TabPage3.Controls.Add(Me.txtDiaChi)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.txtTienNo)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.txtSDT)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.txtEmail)
        Me.TabPage3.Controls.Add(Me.txtHoTenKH)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.txtMaCTBCCN)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(432, 376)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Thông Tin Chi Tiết Báo Cáo Công Nợ"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 296)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "Số Tiền Phát Sinh"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 322)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Số Tiền Nợ Cuối"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Số Tiền Nợ Đầu"
        '
        'txtSoTienNoCuoi
        '
        Me.txtSoTienNoCuoi.Location = New System.Drawing.Point(171, 319)
        Me.txtSoTienNoCuoi.Name = "txtSoTienNoCuoi"
        Me.txtSoTienNoCuoi.Size = New System.Drawing.Size(246, 20)
        Me.txtSoTienNoCuoi.TabIndex = 76
        '
        'txtSoTienPhatSinh
        '
        Me.txtSoTienPhatSinh.Location = New System.Drawing.Point(171, 293)
        Me.txtSoTienPhatSinh.Name = "txtSoTienPhatSinh"
        Me.txtSoTienPhatSinh.Size = New System.Drawing.Size(246, 20)
        Me.txtSoTienPhatSinh.TabIndex = 75
        '
        'txtSoTienNoDau
        '
        Me.txtSoTienNoDau.Location = New System.Drawing.Point(171, 267)
        Me.txtSoTienNoDau.Name = "txtSoTienNoDau"
        Me.txtSoTienNoDau.Size = New System.Drawing.Size(246, 20)
        Me.txtSoTienNoDau.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Tháng Báo Cáo Công Nợ"
        '
        'dtpThangBaoCaoCongNo
        '
        Me.dtpThangBaoCaoCongNo.CustomFormat = "MM/yyyy"
        Me.dtpThangBaoCaoCongNo.Enabled = False
        Me.dtpThangBaoCaoCongNo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThangBaoCaoCongNo.Location = New System.Drawing.Point(171, 37)
        Me.dtpThangBaoCaoCongNo.Name = "dtpThangBaoCaoCongNo"
        Me.dtpThangBaoCaoCongNo.Size = New System.Drawing.Size(246, 20)
        Me.dtpThangBaoCaoCongNo.TabIndex = 72
        Me.dtpThangBaoCaoCongNo.Value = New Date(2018, 5, 19, 0, 0, 0, 0)
        '
        'txtMaKH
        '
        Me.txtMaKH.Enabled = False
        Me.txtMaKH.Location = New System.Drawing.Point(171, 63)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.ReadOnly = True
        Me.txtMaKH.Size = New System.Drawing.Size(246, 20)
        Me.txtMaKH.TabIndex = 71
        '
        'txtDiaChi
        '
        Me.txtDiaChi.BackColor = System.Drawing.SystemColors.Control
        Me.txtDiaChi.Enabled = False
        Me.txtDiaChi.Location = New System.Drawing.Point(171, 115)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(246, 67)
        Me.txtDiaChi.TabIndex = 70
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 13)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Tiền Nợ Khách Hàng"
        '
        'txtTienNo
        '
        Me.txtTienNo.Enabled = False
        Me.txtTienNo.Location = New System.Drawing.Point(171, 241)
        Me.txtTienNo.Name = "txtTienNo"
        Me.txtTienNo.ReadOnly = True
        Me.txtTienNo.Size = New System.Drawing.Size(246, 20)
        Me.txtTienNo.TabIndex = 68
        Me.txtTienNo.WordWrap = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Số Điện Thoại"
        '
        'txtSDT
        '
        Me.txtSDT.Enabled = False
        Me.txtSDT.Location = New System.Drawing.Point(171, 215)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.ReadOnly = True
        Me.txtSDT.Size = New System.Drawing.Size(246, 20)
        Me.txtSDT.TabIndex = 66
        Me.txtSDT.WordWrap = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Địa Chỉ"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(171, 188)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(246, 20)
        Me.txtEmail.TabIndex = 63
        Me.txtEmail.WordWrap = False
        '
        'txtHoTenKH
        '
        Me.txtHoTenKH.Enabled = False
        Me.txtHoTenKH.Location = New System.Drawing.Point(171, 89)
        Me.txtHoTenKH.Name = "txtHoTenKH"
        Me.txtHoTenKH.ReadOnly = True
        Me.txtHoTenKH.Size = New System.Drawing.Size(246, 20)
        Me.txtHoTenKH.TabIndex = 62
        Me.txtHoTenKH.WordWrap = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Họ Tên Khách Hàng"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Mã Khách Hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Mã Chi Tiết Báo Cáo Công Nợ"
        '
        'txtMaCTBCCN
        '
        Me.txtMaCTBCCN.Enabled = False
        Me.txtMaCTBCCN.Location = New System.Drawing.Point(171, 11)
        Me.txtMaCTBCCN.Name = "txtMaCTBCCN"
        Me.txtMaCTBCCN.ReadOnly = True
        Me.txtMaCTBCCN.Size = New System.Drawing.Size(246, 20)
        Me.txtMaCTBCCN.TabIndex = 59
        '
        'btCapNhatCTBCCN
        '
        Me.btCapNhatCTBCCN.Location = New System.Drawing.Point(148, 350)
        Me.btCapNhatCTBCCN.Name = "btCapNhatCTBCCN"
        Me.btCapNhatCTBCCN.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhatCTBCCN.TabIndex = 80
        Me.btCapNhatCTBCCN.Text = "Cập nhật"
        Me.btCapNhatCTBCCN.UseVisualStyleBackColor = True
        '
        'btXoaCTBCCN
        '
        Me.btXoaCTBCCN.Location = New System.Drawing.Point(229, 350)
        Me.btXoaCTBCCN.Name = "btXoaCTBCCN"
        Me.btXoaCTBCCN.Size = New System.Drawing.Size(75, 23)
        Me.btXoaCTBCCN.TabIndex = 81
        Me.btXoaCTBCCN.Text = "Xóa"
        Me.btXoaCTBCCN.UseVisualStyleBackColor = True
        '
        'frmQLCTBaoCaoCongNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 426)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmQLCTBaoCaoCongNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Chi Tiết Báo Cáo Công Nợ"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvListCTBaoCaoCongNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvListCTBaoCaoCongNo As DataGridView
    Friend WithEvents txtMaBCCN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSoTienNoCuoi As TextBox
    Friend WithEvents txtSoTienPhatSinh As TextBox
    Friend WithEvents txtSoTienNoDau As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpThangBaoCaoCongNo As DateTimePicker
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTienNo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtHoTenKH As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaCTBCCN As TextBox
    Friend WithEvents btXoaCTBCCN As Button
    Friend WithEvents btCapNhatCTBCCN As Button
End Class
