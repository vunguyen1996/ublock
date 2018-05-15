<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLPhieuNhap
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
        Me.dgvListPhieuNhap = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtpNgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.btXoaPhieuNhap = New System.Windows.Forms.Button()
        Me.txtMaPhieuNhap = New System.Windows.Forms.TextBox()
        Me.btCapNhatPhieuNhap = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvListPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListPhieuNhap
        '
        Me.dgvListPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListPhieuNhap.Location = New System.Drawing.Point(6, 6)
        Me.dgvListPhieuNhap.Name = "dgvListPhieuNhap"
        Me.dgvListPhieuNhap.Size = New System.Drawing.Size(234, 201)
        Me.dgvListPhieuNhap.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(254, 336)
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
        Me.TabPage1.Size = New System.Drawing.Size(246, 310)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Danh Sách Các Phiếu Nhập"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dtpNgayNhap
        '
        Me.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayNhap.Location = New System.Drawing.Point(93, 239)
        Me.dtpNgayNhap.Name = "dtpNgayNhap"
        Me.dtpNgayNhap.Size = New System.Drawing.Size(147, 20)
        Me.dtpNgayNhap.TabIndex = 23
        Me.dtpNgayNhap.Value = New Date(2003, 3, 28, 0, 0, 0, 0)
        '
        'btXoaPhieuNhap
        '
        Me.btXoaPhieuNhap.Location = New System.Drawing.Point(123, 277)
        Me.btXoaPhieuNhap.Name = "btXoaPhieuNhap"
        Me.btXoaPhieuNhap.Size = New System.Drawing.Size(75, 23)
        Me.btXoaPhieuNhap.TabIndex = 22
        Me.btXoaPhieuNhap.Text = "Xóa"
        Me.btXoaPhieuNhap.UseVisualStyleBackColor = True
        '
        'txtMaPhieuNhap
        '
        Me.txtMaPhieuNhap.Location = New System.Drawing.Point(93, 213)
        Me.txtMaPhieuNhap.Name = "txtMaPhieuNhap"
        Me.txtMaPhieuNhap.ReadOnly = True
        Me.txtMaPhieuNhap.Size = New System.Drawing.Size(147, 20)
        Me.txtMaPhieuNhap.TabIndex = 20
        Me.txtMaPhieuNhap.WordWrap = False
        '
        'btCapNhatPhieuNhap
        '
        Me.btCapNhatPhieuNhap.Location = New System.Drawing.Point(42, 277)
        Me.btCapNhatPhieuNhap.Name = "btCapNhatPhieuNhap"
        Me.btCapNhatPhieuNhap.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhatPhieuNhap.TabIndex = 2
        Me.btCapNhatPhieuNhap.Text = "Cập nhật"
        Me.btCapNhatPhieuNhap.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Ngày Nhập"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Mã Phiếu Nhập"
        '
        'frmQLPhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 356)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmQLPhieuNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Phiếu Nhập Sách"
        CType(Me.dgvListPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
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
End Class
