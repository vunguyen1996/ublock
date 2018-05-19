<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemCTBaoCaoCongNo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaCTBCCN = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.txtMaBCCN = New System.Windows.Forms.TextBox()
        Me.dtpThangBaoCaoCongNo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btThemCTBCCN = New System.Windows.Forms.Button()
        Me.txtSoTienNoDau = New System.Windows.Forms.TextBox()
        Me.txtSoTienPhatSinh = New System.Windows.Forms.TextBox()
        Me.txtSoTienNoCuoi = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Chi Tiết Báo Cáo Công Nợ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Báo Cáo Công Nợ"
        '
        'txtMaCTBCCN
        '
        Me.txtMaCTBCCN.Enabled = False
        Me.txtMaCTBCCN.Location = New System.Drawing.Point(162, 6)
        Me.txtMaCTBCCN.Name = "txtMaCTBCCN"
        Me.txtMaCTBCCN.ReadOnly = True
        Me.txtMaCTBCCN.Size = New System.Drawing.Size(246, 20)
        Me.txtMaCTBCCN.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(428, 435)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtSoTienNoCuoi)
        Me.TabPage1.Controls.Add(Me.txtSoTienPhatSinh)
        Me.TabPage1.Controls.Add(Me.txtSoTienNoDau)
        Me.TabPage1.Controls.Add(Me.btThemCTBCCN)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.dtpThangBaoCaoCongNo)
        Me.TabPage1.Controls.Add(Me.txtMaBCCN)
        Me.TabPage1.Controls.Add(Me.txtMaKH)
        Me.TabPage1.Controls.Add(Me.txtDiaChi)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtTienNo)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtSDT)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.txtHoTenKH)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtMaCTBCCN)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(420, 409)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Chi Tiết Báo Cáo Công Nợ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(162, 84)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(246, 20)
        Me.txtMaKH.TabIndex = 47
        '
        'txtDiaChi
        '
        Me.txtDiaChi.BackColor = System.Drawing.SystemColors.Control
        Me.txtDiaChi.Enabled = False
        Me.txtDiaChi.Location = New System.Drawing.Point(162, 136)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(246, 67)
        Me.txtDiaChi.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Tiền Nợ Khách Hàng"
        '
        'txtTienNo
        '
        Me.txtTienNo.Enabled = False
        Me.txtTienNo.Location = New System.Drawing.Point(162, 262)
        Me.txtTienNo.Name = "txtTienNo"
        Me.txtTienNo.ReadOnly = True
        Me.txtTienNo.Size = New System.Drawing.Size(246, 20)
        Me.txtTienNo.TabIndex = 44
        Me.txtTienNo.WordWrap = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Số Điện Thoại"
        '
        'txtSDT
        '
        Me.txtSDT.Enabled = False
        Me.txtSDT.Location = New System.Drawing.Point(162, 236)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.ReadOnly = True
        Me.txtSDT.Size = New System.Drawing.Size(246, 20)
        Me.txtSDT.TabIndex = 42
        Me.txtSDT.WordWrap = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Địa Chỉ"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(162, 209)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(246, 20)
        Me.txtEmail.TabIndex = 39
        Me.txtEmail.WordWrap = False
        '
        'txtHoTenKH
        '
        Me.txtHoTenKH.Enabled = False
        Me.txtHoTenKH.Location = New System.Drawing.Point(162, 110)
        Me.txtHoTenKH.Name = "txtHoTenKH"
        Me.txtHoTenKH.ReadOnly = True
        Me.txtHoTenKH.Size = New System.Drawing.Size(246, 20)
        Me.txtHoTenKH.TabIndex = 38
        Me.txtHoTenKH.WordWrap = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Họ Tên Khách Hàng"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Mã Khách Hàng"
        '
        'txtMaBCCN
        '
        Me.txtMaBCCN.Location = New System.Drawing.Point(162, 32)
        Me.txtMaBCCN.Name = "txtMaBCCN"
        Me.txtMaBCCN.Size = New System.Drawing.Size(246, 20)
        Me.txtMaBCCN.TabIndex = 48
        '
        'dtpThangBaoCaoCongNo
        '
        Me.dtpThangBaoCaoCongNo.CustomFormat = "MM/yyyy"
        Me.dtpThangBaoCaoCongNo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThangBaoCaoCongNo.Location = New System.Drawing.Point(162, 58)
        Me.dtpThangBaoCaoCongNo.Name = "dtpThangBaoCaoCongNo"
        Me.dtpThangBaoCaoCongNo.Size = New System.Drawing.Size(246, 20)
        Me.dtpThangBaoCaoCongNo.TabIndex = 49
        Me.dtpThangBaoCaoCongNo.Value = New Date(2018, 5, 19, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Tháng Báo Cáo Công Nợ"
        '
        'btThemCTBCCN
        '
        Me.btThemCTBCCN.Location = New System.Drawing.Point(177, 380)
        Me.btThemCTBCCN.Name = "btThemCTBCCN"
        Me.btThemCTBCCN.Size = New System.Drawing.Size(75, 23)
        Me.btThemCTBCCN.TabIndex = 51
        Me.btThemCTBCCN.Text = "Thêm"
        Me.btThemCTBCCN.UseVisualStyleBackColor = True
        '
        'txtSoTienNoDau
        '
        Me.txtSoTienNoDau.Location = New System.Drawing.Point(162, 288)
        Me.txtSoTienNoDau.Name = "txtSoTienNoDau"
        Me.txtSoTienNoDau.Size = New System.Drawing.Size(246, 20)
        Me.txtSoTienNoDau.TabIndex = 52
        '
        'txtSoTienPhatSinh
        '
        Me.txtSoTienPhatSinh.Location = New System.Drawing.Point(162, 314)
        Me.txtSoTienPhatSinh.Name = "txtSoTienPhatSinh"
        Me.txtSoTienPhatSinh.Size = New System.Drawing.Size(246, 20)
        Me.txtSoTienPhatSinh.TabIndex = 53
        '
        'txtSoTienNoCuoi
        '
        Me.txtSoTienNoCuoi.Location = New System.Drawing.Point(162, 340)
        Me.txtSoTienNoCuoi.Name = "txtSoTienNoCuoi"
        Me.txtSoTienNoCuoi.Size = New System.Drawing.Size(246, 20)
        Me.txtSoTienNoCuoi.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Số Tiền Nợ Đầu"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 343)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Số Tiền Nợ Cuối"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 317)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Số Tiền Phát Sinh"
        '
        'frmThemCTBaoCaoCongNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 459)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmThemCTBaoCaoCongNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Chi Tiết Báo Cáo Công Nợ"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaCTBCCN As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
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
    Friend WithEvents txtMaBCCN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpThangBaoCaoCongNo As DateTimePicker
    Friend WithEvents btThemCTBCCN As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSoTienNoCuoi As TextBox
    Friend WithEvents txtSoTienPhatSinh As TextBox
    Friend WithEvents txtSoTienNoDau As TextBox
End Class
