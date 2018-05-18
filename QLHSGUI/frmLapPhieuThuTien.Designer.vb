<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapPhieuThuTien
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
        Me.btThemPhieuThuTien = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbqd = New System.Windows.Forms.CheckBox()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtTienNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTienThu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHoTenKH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpNgayLapPhieuThuTien = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaPhieuThuTien = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(447, 374)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btThemPhieuThuTien)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.cbqd)
        Me.TabPage1.Controls.Add(Me.txt)
        Me.TabPage1.Controls.Add(Me.txtMaKH)
        Me.TabPage1.Controls.Add(Me.txtTienNo)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtSDT)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.txtTienThu)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtDiaChi)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtHoTenKH)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.dtpNgayLapPhieuThuTien)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtMaPhieuThuTien)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(439, 348)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Phiếu Thu Tiền"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btThemPhieuThuTien
        '
        Me.btThemPhieuThuTien.Location = New System.Drawing.Point(180, 319)
        Me.btThemPhieuThuTien.Name = "btThemPhieuThuTien"
        Me.btThemPhieuThuTien.Size = New System.Drawing.Size(75, 23)
        Me.btThemPhieuThuTien.TabIndex = 1
        Me.btThemPhieuThuTien.Text = "Thêm"
        Me.btThemPhieuThuTien.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Áp Dụng Hoặc Không Áp Dụng"
        '
        'cbqd
        '
        Me.cbqd.AutoSize = True
        Me.cbqd.Location = New System.Drawing.Point(206, 290)
        Me.cbqd.Name = "cbqd"
        Me.cbqd.Size = New System.Drawing.Size(192, 17)
        Me.cbqd.TabIndex = 44
        Me.cbqd.Text = "Tiền Thu Không Vượt Quá Tiền Nợ"
        Me.cbqd.UseVisualStyleBackColor = True
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt.Enabled = False
        Me.txt.Location = New System.Drawing.Point(169, 288)
        Me.txt.Name = "txt"
        Me.txt.ReadOnly = True
        Me.txt.Size = New System.Drawing.Size(261, 20)
        Me.txt.TabIndex = 43
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(169, 32)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(261, 20)
        Me.txtMaKH.TabIndex = 42
        '
        'txtTienNo
        '
        Me.txtTienNo.Location = New System.Drawing.Point(169, 210)
        Me.txtTienNo.Name = "txtTienNo"
        Me.txtTienNo.ReadOnly = True
        Me.txtTienNo.Size = New System.Drawing.Size(261, 20)
        Me.txtTienNo.TabIndex = 41
        Me.txtTienNo.WordWrap = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Số Tiền Nợ"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(169, 184)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.ReadOnly = True
        Me.txtSDT.Size = New System.Drawing.Size(261, 20)
        Me.txtSDT.TabIndex = 39
        Me.txtSDT.WordWrap = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(169, 158)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(261, 20)
        Me.txtEmail.TabIndex = 38
        Me.txtEmail.WordWrap = False
        '
        'txtTienThu
        '
        Me.txtTienThu.Location = New System.Drawing.Point(169, 236)
        Me.txtTienThu.Name = "txtTienThu"
        Me.txtTienThu.Size = New System.Drawing.Size(261, 20)
        Me.txtTienThu.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Số Điện Thoại"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Email"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.BackColor = System.Drawing.SystemColors.Control
        Me.txtDiaChi.Location = New System.Drawing.Point(169, 85)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(261, 67)
        Me.txtDiaChi.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Địa Chỉ"
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
        'txtHoTenKH
        '
        Me.txtHoTenKH.Location = New System.Drawing.Point(169, 59)
        Me.txtHoTenKH.Name = "txtHoTenKH"
        Me.txtHoTenKH.ReadOnly = True
        Me.txtHoTenKH.Size = New System.Drawing.Size(261, 20)
        Me.txtHoTenKH.TabIndex = 22
        Me.txtHoTenKH.WordWrap = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Số Tiền Thu"
        '
        'dtpNgayLapPhieuThuTien
        '
        Me.dtpNgayLapPhieuThuTien.CustomFormat = "MM/dd/yyyy"
        Me.dtpNgayLapPhieuThuTien.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayLapPhieuThuTien.Location = New System.Drawing.Point(169, 262)
        Me.dtpNgayLapPhieuThuTien.Name = "dtpNgayLapPhieuThuTien"
        Me.dtpNgayLapPhieuThuTien.Size = New System.Drawing.Size(261, 20)
        Me.dtpNgayLapPhieuThuTien.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Ngày Thu Tiền"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Mã Khách Hàng"
        '
        'txtMaPhieuThuTien
        '
        Me.txtMaPhieuThuTien.Location = New System.Drawing.Point(169, 6)
        Me.txtMaPhieuThuTien.Name = "txtMaPhieuThuTien"
        Me.txtMaPhieuThuTien.ReadOnly = True
        Me.txtMaPhieuThuTien.Size = New System.Drawing.Size(261, 20)
        Me.txtMaPhieuThuTien.TabIndex = 17
        Me.txtMaPhieuThuTien.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu Thu Tiền"
        '
        'frmLapPhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 398)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmLapPhieuThuTien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lập Phiếu Thu Tiền"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaPhieuThuTien As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHoTenKH As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpNgayLapPhieuThuTien As DateTimePicker
    Friend WithEvents txtTienNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTienThu As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents btThemPhieuThuTien As Button
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbqd As CheckBox
    Friend WithEvents txt As TextBox
End Class
