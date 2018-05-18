<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThemCTPhieuNhap
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSoLuongTonSauKhiNhap = New System.Windows.Forms.TextBox()
        Me.btThemCTPN = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSoLuongTonToiDa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTheLoai = New System.Windows.Forms.TextBox()
        Me.dtpNgayLapPhieu = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMaPhieuNhap = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSoLuongTon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSoLuongNhapToiThieu = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSoLuongNhap = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaCTPN = New System.Windows.Forms.TextBox()
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
        Me.TabControl1.Size = New System.Drawing.Size(393, 383)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtSoLuongTonSauKhiNhap)
        Me.TabPage1.Controls.Add(Me.btThemCTPN)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtSoLuongTonToiDa)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtTheLoai)
        Me.TabPage1.Controls.Add(Me.dtpNgayLapPhieu)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtMaPhieuNhap)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtTacGia)
        Me.TabPage1.Controls.Add(Me.txtTenSach)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtMaSach)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtSoLuongTon)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtSoLuongNhapToiThieu)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtSoLuongNhap)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtMaCTPN)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(385, 357)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Chi Tiết Phiếu Nhập"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 13)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Số Lượng Tồn Sau Khi Nhập"
        '
        'txtSoLuongTonSauKhiNhap
        '
        Me.txtSoLuongTonSauKhiNhap.Location = New System.Drawing.Point(155, 240)
        Me.txtSoLuongTonSauKhiNhap.Name = "txtSoLuongTonSauKhiNhap"
        Me.txtSoLuongTonSauKhiNhap.ReadOnly = True
        Me.txtSoLuongTonSauKhiNhap.Size = New System.Drawing.Size(224, 20)
        Me.txtSoLuongTonSauKhiNhap.TabIndex = 47
        Me.txtSoLuongTonSauKhiNhap.WordWrap = False
        '
        'btThemCTPN
        '
        Me.btThemCTPN.Location = New System.Drawing.Point(155, 328)
        Me.btThemCTPN.Name = "btThemCTPN"
        Me.btThemCTPN.Size = New System.Drawing.Size(75, 23)
        Me.btThemCTPN.TabIndex = 1
        Me.btThemCTPN.Text = "Thêm"
        Me.btThemCTPN.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 295)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Số Lượng Tồn Tối Đa"
        '
        'txtSoLuongTonToiDa
        '
        Me.txtSoLuongTonToiDa.Location = New System.Drawing.Point(155, 292)
        Me.txtSoLuongTonToiDa.Name = "txtSoLuongTonToiDa"
        Me.txtSoLuongTonToiDa.ReadOnly = True
        Me.txtSoLuongTonToiDa.Size = New System.Drawing.Size(224, 20)
        Me.txtSoLuongTonToiDa.TabIndex = 45
        Me.txtSoLuongTonToiDa.WordWrap = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Thể Loại"
        '
        'txtTheLoai
        '
        Me.txtTheLoai.Location = New System.Drawing.Point(155, 136)
        Me.txtTheLoai.Name = "txtTheLoai"
        Me.txtTheLoai.ReadOnly = True
        Me.txtTheLoai.Size = New System.Drawing.Size(224, 20)
        Me.txtTheLoai.TabIndex = 43
        Me.txtTheLoai.WordWrap = False
        '
        'dtpNgayLapPhieu
        '
        Me.dtpNgayLapPhieu.CustomFormat = "MM/dd/yyy"
        Me.dtpNgayLapPhieu.Enabled = False
        Me.dtpNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayLapPhieu.Location = New System.Drawing.Point(155, 58)
        Me.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu"
        Me.dtpNgayLapPhieu.Size = New System.Drawing.Size(224, 20)
        Me.dtpNgayLapPhieu.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Ngày Lập Phiếu"
        '
        'txtMaPhieuNhap
        '
        Me.txtMaPhieuNhap.Location = New System.Drawing.Point(155, 32)
        Me.txtMaPhieuNhap.Name = "txtMaPhieuNhap"
        Me.txtMaPhieuNhap.Size = New System.Drawing.Size(224, 20)
        Me.txtMaPhieuNhap.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Tác Giả"
        '
        'txtTacGia
        '
        Me.txtTacGia.Location = New System.Drawing.Point(155, 162)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.ReadOnly = True
        Me.txtTacGia.Size = New System.Drawing.Size(224, 20)
        Me.txtTacGia.TabIndex = 37
        Me.txtTacGia.WordWrap = False
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(155, 110)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.ReadOnly = True
        Me.txtTenSach.Size = New System.Drawing.Size(224, 20)
        Me.txtTenSach.TabIndex = 35
        Me.txtTenSach.WordWrap = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Tên Sách"
        '
        'txtMaSach
        '
        Me.txtMaSach.Location = New System.Drawing.Point(155, 84)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(224, 20)
        Me.txtMaSach.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Số Lượng Tồn Ban Đầu"
        '
        'txtSoLuongTon
        '
        Me.txtSoLuongTon.Location = New System.Drawing.Point(155, 188)
        Me.txtSoLuongTon.Name = "txtSoLuongTon"
        Me.txtSoLuongTon.ReadOnly = True
        Me.txtSoLuongTon.Size = New System.Drawing.Size(224, 20)
        Me.txtSoLuongTon.TabIndex = 31
        Me.txtSoLuongTon.WordWrap = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Số Lượng Nhập Tối Thiểu"
        '
        'txtSoLuongNhapToiThieu
        '
        Me.txtSoLuongNhapToiThieu.Location = New System.Drawing.Point(155, 266)
        Me.txtSoLuongNhapToiThieu.Name = "txtSoLuongNhapToiThieu"
        Me.txtSoLuongNhapToiThieu.ReadOnly = True
        Me.txtSoLuongNhapToiThieu.Size = New System.Drawing.Size(224, 20)
        Me.txtSoLuongNhapToiThieu.TabIndex = 29
        Me.txtSoLuongNhapToiThieu.WordWrap = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Số Lượng Nhập"
        '
        'txtSoLuongNhap
        '
        Me.txtSoLuongNhap.Location = New System.Drawing.Point(155, 214)
        Me.txtSoLuongNhap.Name = "txtSoLuongNhap"
        Me.txtSoLuongNhap.Size = New System.Drawing.Size(224, 20)
        Me.txtSoLuongNhap.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Mã Sách"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Mã Phiếu Nhập"
        '
        'txtMaCTPN
        '
        Me.txtMaCTPN.Location = New System.Drawing.Point(155, 6)
        Me.txtMaCTPN.Name = "txtMaCTPN"
        Me.txtMaCTPN.ReadOnly = True
        Me.txtMaCTPN.Size = New System.Drawing.Size(224, 20)
        Me.txtMaCTPN.TabIndex = 16
        Me.txtMaCTPN.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Chi Tiết Phiếu Nhập"
        '
        'frmThemCTPhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 407)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmThemCTPhieuNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Chi Tiết Phiếu Nhập"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaCTPN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSoLuongNhap As TextBox
    Friend WithEvents btThemCTPN As Button
    Friend WithEvents txtSoLuongNhapToiThieu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSoLuongTon As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents txtTacGia As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMaPhieuNhap As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpNgayLapPhieu As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTheLoai As TextBox
    Friend WithEvents txtSoLuongTonToiDa As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSoLuongTonSauKhiNhap As TextBox
    Friend WithEvents Label12 As Label
End Class
