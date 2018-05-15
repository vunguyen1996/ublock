<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemPhieuNhap
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
        Me.dtpNgayLapPhieu = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaPhieuNhapSach = New System.Windows.Forms.TextBox()
        Me.btNhapPhieuNhapSach = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpNgayLapPhieu
        '
        Me.dtpNgayLapPhieu.CustomFormat = "MM/dd/yyyy"
        Me.dtpNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayLapPhieu.Location = New System.Drawing.Point(103, 32)
        Me.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu"
        Me.dtpNgayLapPhieu.Size = New System.Drawing.Size(173, 20)
        Me.dtpNgayLapPhieu.TabIndex = 6
        Me.dtpNgayLapPhieu.Value = New Date(2018, 5, 12, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Mã Phiếu Nhập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ngày Nhập"
        '
        'txtMaPhieuNhapSach
        '
        Me.txtMaPhieuNhapSach.Location = New System.Drawing.Point(103, 6)
        Me.txtMaPhieuNhapSach.Name = "txtMaPhieuNhapSach"
        Me.txtMaPhieuNhapSach.ReadOnly = True
        Me.txtMaPhieuNhapSach.Size = New System.Drawing.Size(173, 20)
        Me.txtMaPhieuNhapSach.TabIndex = 16
        Me.txtMaPhieuNhapSach.WordWrap = False
        '
        'btNhapPhieuNhapSach
        '
        Me.btNhapPhieuNhapSach.Location = New System.Drawing.Point(129, 111)
        Me.btNhapPhieuNhapSach.Name = "btNhapPhieuNhapSach"
        Me.btNhapPhieuNhapSach.Size = New System.Drawing.Size(75, 23)
        Me.btNhapPhieuNhapSach.TabIndex = 17
        Me.btNhapPhieuNhapSach.Text = "Nhập"
        Me.btNhapPhieuNhapSach.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(307, 93)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dtpNgayLapPhieu)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtMaPhieuNhapSach)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(299, 67)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Phiếu Nhập"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'frmThemPhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 147)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btNhapPhieuNhapSach)
        Me.Name = "frmThemPhieuNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Phiếu Nhập Sách"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpNgayLapPhieu As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaPhieuNhapSach As TextBox
    Friend WithEvents btNhapPhieuNhapSach As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
End Class
