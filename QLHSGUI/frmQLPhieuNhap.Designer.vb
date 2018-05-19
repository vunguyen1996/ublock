<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQLPhieuNhap
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
        Me.dgvListPhieuNhap = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtpNgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.btXoaPhieuNhap = New System.Windows.Forms.Button()
        Me.txtMaPhieuNhap = New System.Windows.Forms.TextBox()
        Me.btCapNhatPhieuNhap = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtpNgayNhapTimKiem = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvListPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListPhieuNhap
        '
        Me.dgvListPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListPhieuNhap.Location = New System.Drawing.Point(6, 6)
        Me.dgvListPhieuNhap.Name = "dgvListPhieuNhap"
        Me.dgvListPhieuNhap.Size = New System.Drawing.Size(234, 158)
        Me.dgvListPhieuNhap.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 72)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(254, 276)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dtpNgayNhap)
        Me.TabPage1.Controls.Add(Me.btXoaPhieuNhap)
        Me.TabPage1.Controls.Add(Me.txtMaPhieuNhap)
        Me.TabPage1.Controls.Add(Me.btCapNhatPhieuNhap)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.dgvListPhieuNhap)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(246, 250)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Danh Sách Các Phiếu Nhập"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dtpNgayNhap
        '
        Me.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayNhap.Location = New System.Drawing.Point(93, 196)
        Me.dtpNgayNhap.Name = "dtpNgayNhap"
        Me.dtpNgayNhap.Size = New System.Drawing.Size(147, 20)
        Me.dtpNgayNhap.TabIndex = 23
        Me.dtpNgayNhap.Value = New Date(2003, 3, 28, 0, 0, 0, 0)
        '
        'btXoaPhieuNhap
        '
        Me.btXoaPhieuNhap.Location = New System.Drawing.Point(127, 222)
        Me.btXoaPhieuNhap.Name = "btXoaPhieuNhap"
        Me.btXoaPhieuNhap.Size = New System.Drawing.Size(75, 23)
        Me.btXoaPhieuNhap.TabIndex = 22
        Me.btXoaPhieuNhap.Text = "Xóa"
        Me.btXoaPhieuNhap.UseVisualStyleBackColor = True
        '
        'txtMaPhieuNhap
        '
        Me.txtMaPhieuNhap.Enabled = False
        Me.txtMaPhieuNhap.Location = New System.Drawing.Point(93, 170)
        Me.txtMaPhieuNhap.Name = "txtMaPhieuNhap"
        Me.txtMaPhieuNhap.ReadOnly = True
        Me.txtMaPhieuNhap.Size = New System.Drawing.Size(147, 20)
        Me.txtMaPhieuNhap.TabIndex = 20
        Me.txtMaPhieuNhap.WordWrap = False
        '
        'btCapNhatPhieuNhap
        '
        Me.btCapNhatPhieuNhap.Location = New System.Drawing.Point(46, 222)
        Me.btCapNhatPhieuNhap.Name = "btCapNhatPhieuNhap"
        Me.btCapNhatPhieuNhap.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhatPhieuNhap.TabIndex = 2
        Me.btCapNhatPhieuNhap.Text = "Cập nhật"
        Me.btCapNhatPhieuNhap.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Ngày Nhập"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Mã Phiếu Nhập"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(253, 58)
        Me.TabControl2.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtpNgayNhapTimKiem)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(245, 32)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Tìm Kiếm"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dtpNgayNhapTimKiem
        '
        Me.dtpNgayNhapTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayNhapTimKiem.Location = New System.Drawing.Point(92, 6)
        Me.dtpNgayNhapTimKiem.Name = "dtpNgayNhapTimKiem"
        Me.dtpNgayNhapTimKiem.Size = New System.Drawing.Size(147, 20)
        Me.dtpNgayNhapTimKiem.TabIndex = 25
        Me.dtpNgayNhapTimKiem.Value = New Date(2018, 3, 28, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Ngày Nhập"
        '
        'frmQLPhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 355)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmQLPhieuNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Phiếu Nhập Sách"
        CType(Me.dgvListPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvListPhieuNhap As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btCapNhatPhieuNhap As Button
    Friend WithEvents txtMaPhieuNhap As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btXoaPhieuNhap As Button
    Friend WithEvents dtpNgayNhap As DateTimePicker
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dtpNgayNhapTimKiem As DateTimePicker
    Friend WithEvents Label3 As Label
End Class
