<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemCTBaoCaoTon
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
        Me.txtTonCuoi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTonDau = New System.Windows.Forms.TextBox()
        Me.btThemCTBCT = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTheLoai = New System.Windows.Forms.TextBox()
        Me.dtpThangBaoCaoTon = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMaBaoCaoTon = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhatSinh = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaCTBCT = New System.Windows.Forms.TextBox()
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
        Me.TabControl1.Size = New System.Drawing.Size(395, 337)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtTonCuoi)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtTonDau)
        Me.TabPage1.Controls.Add(Me.btThemCTBCT)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtTheLoai)
        Me.TabPage1.Controls.Add(Me.dtpThangBaoCaoTon)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtMaBaoCaoTon)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtTacGia)
        Me.TabPage1.Controls.Add(Me.txtTenSach)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtMaSach)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtPhatSinh)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtMaCTBCT)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(387, 311)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Chi Tiết Phiếu Nhập"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtTonCuoi
        '
        Me.txtTonCuoi.Location = New System.Drawing.Point(155, 240)
        Me.txtTonCuoi.Name = "txtTonCuoi"
        Me.txtTonCuoi.Size = New System.Drawing.Size(224, 20)
        Me.txtTonCuoi.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Số Lượng Tồn Cuối"
        '
        'txtTonDau
        '
        Me.txtTonDau.Location = New System.Drawing.Point(155, 188)
        Me.txtTonDau.Name = "txtTonDau"
        Me.txtTonDau.Size = New System.Drawing.Size(224, 20)
        Me.txtTonDau.TabIndex = 49
        '
        'btThemCTBCT
        '
        Me.btThemCTBCT.Location = New System.Drawing.Point(155, 282)
        Me.btThemCTBCT.Name = "btThemCTBCT"
        Me.btThemCTBCT.Size = New System.Drawing.Size(75, 23)
        Me.btThemCTBCT.TabIndex = 1
        Me.btThemCTBCT.Text = "Thêm"
        Me.btThemCTBCT.UseVisualStyleBackColor = True
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
        Me.txtTheLoai.Enabled = False
        Me.txtTheLoai.Location = New System.Drawing.Point(155, 136)
        Me.txtTheLoai.Name = "txtTheLoai"
        Me.txtTheLoai.ReadOnly = True
        Me.txtTheLoai.Size = New System.Drawing.Size(224, 20)
        Me.txtTheLoai.TabIndex = 43
        Me.txtTheLoai.WordWrap = False
        '
        'dtpThangBaoCaoTon
        '
        Me.dtpThangBaoCaoTon.CustomFormat = "MM/yyyy"
        Me.dtpThangBaoCaoTon.Enabled = False
        Me.dtpThangBaoCaoTon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThangBaoCaoTon.Location = New System.Drawing.Point(155, 58)
        Me.dtpThangBaoCaoTon.Name = "dtpThangBaoCaoTon"
        Me.dtpThangBaoCaoTon.Size = New System.Drawing.Size(224, 20)
        Me.dtpThangBaoCaoTon.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Tháng Báo Cáo Tồn"
        '
        'txtMaBaoCaoTon
        '
        Me.txtMaBaoCaoTon.Location = New System.Drawing.Point(155, 32)
        Me.txtMaBaoCaoTon.Name = "txtMaBaoCaoTon"
        Me.txtMaBaoCaoTon.Size = New System.Drawing.Size(224, 20)
        Me.txtMaBaoCaoTon.TabIndex = 39
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
        Me.txtTacGia.Enabled = False
        Me.txtTacGia.Location = New System.Drawing.Point(155, 162)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.ReadOnly = True
        Me.txtTacGia.Size = New System.Drawing.Size(224, 20)
        Me.txtTacGia.TabIndex = 37
        Me.txtTacGia.WordWrap = False
        '
        'txtTenSach
        '
        Me.txtTenSach.Enabled = False
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
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Số Lượng Tồn Đầu"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Phát Sinh"
        '
        'txtPhatSinh
        '
        Me.txtPhatSinh.Location = New System.Drawing.Point(155, 214)
        Me.txtPhatSinh.Name = "txtPhatSinh"
        Me.txtPhatSinh.Size = New System.Drawing.Size(224, 20)
        Me.txtPhatSinh.TabIndex = 27
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
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Mã Báo Cáo Tồn"
        '
        'txtMaCTBCT
        '
        Me.txtMaCTBCT.Enabled = False
        Me.txtMaCTBCT.Location = New System.Drawing.Point(155, 6)
        Me.txtMaCTBCT.Name = "txtMaCTBCT"
        Me.txtMaCTBCT.ReadOnly = True
        Me.txtMaCTBCT.Size = New System.Drawing.Size(224, 20)
        Me.txtMaCTBCT.TabIndex = 16
        Me.txtMaCTBCT.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Chi Tiết Báo Cáo Tồn"
        '
        'frmThemCTBaoCaoTon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 357)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmThemCTBaoCaoTon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Chi Tiết Báo Cáo Tồn"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btThemCTBCT As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTheLoai As TextBox
    Friend WithEvents dtpThangBaoCaoTon As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMaBaoCaoTon As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTacGia As TextBox
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPhatSinh As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaCTBCT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTonCuoi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTonDau As TextBox
End Class
