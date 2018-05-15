<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemCTPhieuNhap
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
        Me.txtSoLuongTon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSoLuongNhapToiThieu = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSoLuongNhap = New System.Windows.Forms.TextBox()
        Me.cbbMaSach = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbbMaPN = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaCTPN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btThemCTPN = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.TabControl1.Size = New System.Drawing.Size(393, 195)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtSoLuongTon)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtSoLuongNhapToiThieu)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtSoLuongNhap)
        Me.TabPage1.Controls.Add(Me.cbbMaSach)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cbbMaPN)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtMaCTPN)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(385, 169)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Chi Tiết Phiếu Nhập"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtSoLuongTon
        '
        Me.txtSoLuongTon.Location = New System.Drawing.Point(142, 85)
        Me.txtSoLuongTon.Name = "txtSoLuongTon"
        Me.txtSoLuongTon.ReadOnly = True
        Me.txtSoLuongTon.Size = New System.Drawing.Size(237, 20)
        Me.txtSoLuongTon.TabIndex = 31
        Me.txtSoLuongTon.WordWrap = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Số Lượng Nhập Tối Thiểu"
        '
        'txtSoLuongNhapToiThieu
        '
        Me.txtSoLuongNhapToiThieu.Location = New System.Drawing.Point(142, 137)
        Me.txtSoLuongNhapToiThieu.Name = "txtSoLuongNhapToiThieu"
        Me.txtSoLuongNhapToiThieu.ReadOnly = True
        Me.txtSoLuongNhapToiThieu.Size = New System.Drawing.Size(237, 20)
        Me.txtSoLuongNhapToiThieu.TabIndex = 29
        Me.txtSoLuongNhapToiThieu.WordWrap = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Số Lượng Nhập"
        '
        'txtSoLuongNhap
        '
        Me.txtSoLuongNhap.Location = New System.Drawing.Point(142, 111)
        Me.txtSoLuongNhap.Name = "txtSoLuongNhap"
        Me.txtSoLuongNhap.Size = New System.Drawing.Size(237, 20)
        Me.txtSoLuongNhap.TabIndex = 27
        '
        'cbbMaSach
        '
        Me.cbbMaSach.FormattingEnabled = True
        Me.cbbMaSach.Location = New System.Drawing.Point(142, 58)
        Me.cbbMaSach.Name = "cbbMaSach"
        Me.cbbMaSach.Size = New System.Drawing.Size(237, 21)
        Me.cbbMaSach.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Mã Sách"
        '
        'cbbMaPN
        '
        Me.cbbMaPN.FormattingEnabled = True
        Me.cbbMaPN.Location = New System.Drawing.Point(142, 32)
        Me.cbbMaPN.Name = "cbbMaPN"
        Me.cbbMaPN.Size = New System.Drawing.Size(237, 21)
        Me.cbbMaPN.TabIndex = 18
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
        Me.txtMaCTPN.Location = New System.Drawing.Point(142, 6)
        Me.txtMaCTPN.Name = "txtMaCTPN"
        Me.txtMaCTPN.ReadOnly = True
        Me.txtMaCTPN.Size = New System.Drawing.Size(237, 20)
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
        'btThemCTPN
        '
        Me.btThemCTPN.Location = New System.Drawing.Point(170, 213)
        Me.btThemCTPN.Name = "btThemCTPN"
        Me.btThemCTPN.Size = New System.Drawing.Size(75, 23)
        Me.btThemCTPN.TabIndex = 1
        Me.btThemCTPN.Text = "Nhập"
        Me.btThemCTPN.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Số Lượng Tồn"
        '
        'frmThemCTPhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 248)
        Me.Controls.Add(Me.btThemCTPN)
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
    Friend WithEvents cbbMaPN As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaCTPN As TextBox
    Friend WithEvents cbbMaSach As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSoLuongNhap As TextBox
    Friend WithEvents btThemCTPN As Button
    Friend WithEvents txtSoLuongNhapToiThieu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSoLuongTon As TextBox
    Friend WithEvents Label5 As Label
End Class
