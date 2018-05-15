<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLCTPhieuNhap
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
        Me.dgvListChiTietPhieuNhap = New System.Windows.Forms.DataGridView()
        Me.cbbMaPN = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSoLuongNhap = New System.Windows.Forms.TextBox()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.txtMaCTPN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btCapNhatCTPN = New System.Windows.Forms.Button()
        Me.btXoaCTPN = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvListChiTietPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(361, 237)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvListChiTietPhieuNhap)
        Me.TabPage1.Controls.Add(Me.cbbMaPN)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(353, 211)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Danh Sách Sách"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvListChiTietPhieuNhap
        '
        Me.dgvListChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListChiTietPhieuNhap.Location = New System.Drawing.Point(6, 35)
        Me.dgvListChiTietPhieuNhap.Name = "dgvListChiTietPhieuNhap"
        Me.dgvListChiTietPhieuNhap.Size = New System.Drawing.Size(341, 170)
        Me.dgvListChiTietPhieuNhap.TabIndex = 18
        '
        'cbbMaPN
        '
        Me.cbbMaPN.FormattingEnabled = True
        Me.cbbMaPN.Location = New System.Drawing.Point(121, 8)
        Me.cbbMaPN.Name = "cbbMaPN"
        Me.cbbMaPN.Size = New System.Drawing.Size(222, 21)
        Me.cbbMaPN.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Mã phiếu nhập"
        '
        'txtSoLuongNhap
        '
        Me.txtSoLuongNhap.Location = New System.Drawing.Point(124, 58)
        Me.txtSoLuongNhap.Name = "txtSoLuongNhap"
        Me.txtSoLuongNhap.Size = New System.Drawing.Size(219, 20)
        Me.txtSoLuongNhap.TabIndex = 29
        '
        'txtMaSach
        '
        Me.txtMaSach.Location = New System.Drawing.Point(124, 32)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.ReadOnly = True
        Me.txtMaSach.Size = New System.Drawing.Size(219, 20)
        Me.txtMaSach.TabIndex = 28
        Me.txtMaSach.WordWrap = False
        '
        'txtMaCTPN
        '
        Me.txtMaCTPN.Location = New System.Drawing.Point(124, 6)
        Me.txtMaCTPN.Name = "txtMaCTPN"
        Me.txtMaCTPN.ReadOnly = True
        Me.txtMaCTPN.Size = New System.Drawing.Size(219, 20)
        Me.txtMaCTPN.TabIndex = 30
        Me.txtMaCTPN.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Mã chi tiết phiếu nhập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Mã sách"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Số lượng nhập"
        '
        'btCapNhatCTPN
        '
        Me.btCapNhatCTPN.Location = New System.Drawing.Point(113, 375)
        Me.btCapNhatCTPN.Name = "btCapNhatCTPN"
        Me.btCapNhatCTPN.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhatCTPN.TabIndex = 33
        Me.btCapNhatCTPN.Text = "Cập nhật"
        Me.btCapNhatCTPN.UseVisualStyleBackColor = True
        '
        'btXoaCTPN
        '
        Me.btXoaCTPN.Location = New System.Drawing.Point(194, 375)
        Me.btXoaCTPN.Name = "btXoaCTPN"
        Me.btXoaCTPN.Size = New System.Drawing.Size(75, 23)
        Me.btXoaCTPN.TabIndex = 34
        Me.btXoaCTPN.Text = "Xóa"
        Me.btXoaCTPN.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(12, 251)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(357, 118)
        Me.TabControl2.TabIndex = 35
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtMaCTPN)
        Me.TabPage2.Controls.Add(Me.txtMaSach)
        Me.TabPage2.Controls.Add(Me.txtSoLuongNhap)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(349, 92)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Danh Sách Sách"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmQLCTPhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 409)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.btXoaCTPN)
        Me.Controls.Add(Me.btCapNhatCTPN)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmQLCTPhieuNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Chi Tiết Phiếu Nhập"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvListChiTietPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cbbMaPN As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvListChiTietPhieuNhap As DataGridView
    Friend WithEvents txtSoLuongNhap As TextBox
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents txtMaCTPN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btCapNhatCTPN As Button
    Friend WithEvents btXoaCTPN As Button
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
End Class
