<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapHoaDon
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
        Me.btThemHoaDon = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTongTriGiaHoaDon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTienNoToiDa = New System.Windows.Forms.TextBox()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.dtpNgayLapHD = New System.Windows.Forms.DateTimePicker()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btThemHoaDon
        '
        Me.btThemHoaDon.Location = New System.Drawing.Point(155, 326)
        Me.btThemHoaDon.Name = "btThemHoaDon"
        Me.btThemHoaDon.Size = New System.Drawing.Size(75, 23)
        Me.btThemHoaDon.TabIndex = 3
        Me.btThemHoaDon.Text = "Thêm"
        Me.btThemHoaDon.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(390, 381)
        Me.TabControl2.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtpNgayLapHD)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtTongTriGiaHoaDon)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtTienNoToiDa)
        Me.TabPage2.Controls.Add(Me.txtMaKH)
        Me.TabPage2.Controls.Add(Me.txtDiaChi)
        Me.TabPage2.Controls.Add(Me.btThemHoaDon)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtTienNo)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtSDT)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtEmail)
        Me.TabPage2.Controls.Add(Me.txtHoTenKH)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtMaHD)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(382, 355)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Thông Tin Hóa Đơn"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Tổng Trị Giá"
        '
        'txtTongTriGiaHoaDon
        '
        Me.txtTongTriGiaHoaDon.Location = New System.Drawing.Point(118, 289)
        Me.txtTongTriGiaHoaDon.Name = "txtTongTriGiaHoaDon"
        Me.txtTongTriGiaHoaDon.Size = New System.Drawing.Size(246, 20)
        Me.txtTongTriGiaHoaDon.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Tiền Nợ Tối Đa"
        '
        'txtTienNoToiDa
        '
        Me.txtTienNoToiDa.Enabled = False
        Me.txtTienNoToiDa.Location = New System.Drawing.Point(118, 237)
        Me.txtTienNoToiDa.Name = "txtTienNoToiDa"
        Me.txtTienNoToiDa.ReadOnly = True
        Me.txtTienNoToiDa.Size = New System.Drawing.Size(246, 20)
        Me.txtTienNoToiDa.TabIndex = 36
        Me.txtTienNoToiDa.WordWrap = False
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(118, 32)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(246, 20)
        Me.txtMaKH.TabIndex = 35
        '
        'txtDiaChi
        '
        Me.txtDiaChi.BackColor = System.Drawing.SystemColors.Control
        Me.txtDiaChi.Enabled = False
        Me.txtDiaChi.Location = New System.Drawing.Point(118, 85)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(246, 67)
        Me.txtDiaChi.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Tiền Nợ"
        '
        'txtTienNo
        '
        Me.txtTienNo.Enabled = False
        Me.txtTienNo.Location = New System.Drawing.Point(118, 211)
        Me.txtTienNo.Name = "txtTienNo"
        Me.txtTienNo.ReadOnly = True
        Me.txtTienNo.Size = New System.Drawing.Size(246, 20)
        Me.txtTienNo.TabIndex = 32
        Me.txtTienNo.WordWrap = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Số Điện Thoại"
        '
        'txtSDT
        '
        Me.txtSDT.Enabled = False
        Me.txtSDT.Location = New System.Drawing.Point(118, 185)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.ReadOnly = True
        Me.txtSDT.Size = New System.Drawing.Size(246, 20)
        Me.txtSDT.TabIndex = 30
        Me.txtSDT.WordWrap = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Địa Chỉ"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(118, 159)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(246, 20)
        Me.txtEmail.TabIndex = 27
        Me.txtEmail.WordWrap = False
        '
        'txtHoTenKH
        '
        Me.txtHoTenKH.Enabled = False
        Me.txtHoTenKH.Location = New System.Drawing.Point(118, 59)
        Me.txtHoTenKH.Name = "txtHoTenKH"
        Me.txtHoTenKH.ReadOnly = True
        Me.txtHoTenKH.Size = New System.Drawing.Size(246, 20)
        Me.txtHoTenKH.TabIndex = 25
        Me.txtHoTenKH.WordWrap = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Họ Tên Khách Hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Ngày Hóa Đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Mã Khách Hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Mã Hóa Đơn"
        '
        'txtMaHD
        '
        Me.txtMaHD.Enabled = False
        Me.txtMaHD.Location = New System.Drawing.Point(118, 7)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.ReadOnly = True
        Me.txtMaHD.Size = New System.Drawing.Size(246, 20)
        Me.txtMaHD.TabIndex = 18
        Me.txtMaHD.WordWrap = False
        '
        'dtpNgayLapHD
        '
        Me.dtpNgayLapHD.CustomFormat = "MM/dd/yyyy"
        Me.dtpNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayLapHD.Location = New System.Drawing.Point(118, 263)
        Me.dtpNgayLapHD.Name = "dtpNgayLapHD"
        Me.dtpNgayLapHD.Size = New System.Drawing.Size(246, 20)
        Me.dtpNgayLapHD.TabIndex = 40
        '
        'frmLapHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 405)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "frmLapHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lập Hóa Đơn Bán Sách"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btThemHoaDon As Button
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaHD As TextBox
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTienNoToiDa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTongTriGiaHoaDon As TextBox
    Friend WithEvents dtpNgayLapHD As DateTimePicker
End Class
