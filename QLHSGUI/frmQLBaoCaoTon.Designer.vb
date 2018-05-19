<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLBaoCaoTon
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
        Me.tcListBaoCaoTon = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtpThangBaoCaoTonTimKiem = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpThangBaoCaoTon = New System.Windows.Forms.DateTimePicker()
        Me.btXoaBaoCaoTon = New System.Windows.Forms.Button()
        Me.txtMaBaoCaoTon = New System.Windows.Forms.TextBox()
        Me.btCapNhatBaoCaoTon = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvListBaoCaoTon = New System.Windows.Forms.DataGridView()
        Me.tcListBaoCaoTon.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvListBaoCaoTon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcListBaoCaoTon
        '
        Me.tcListBaoCaoTon.Controls.Add(Me.TabPage1)
        Me.tcListBaoCaoTon.Location = New System.Drawing.Point(12, 12)
        Me.tcListBaoCaoTon.Name = "tcListBaoCaoTon"
        Me.tcListBaoCaoTon.SelectedIndex = 0
        Me.tcListBaoCaoTon.Size = New System.Drawing.Size(254, 336)
        Me.tcListBaoCaoTon.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dtpThangBaoCaoTonTimKiem)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.dtpThangBaoCaoTon)
        Me.TabPage1.Controls.Add(Me.btXoaBaoCaoTon)
        Me.TabPage1.Controls.Add(Me.txtMaBaoCaoTon)
        Me.TabPage1.Controls.Add(Me.btCapNhatBaoCaoTon)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.dgvListBaoCaoTon)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(246, 310)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Danh Sách Phiếu Báo Cáo Tồn"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dtpThangBaoCaoTonTimKiem
        '
        Me.dtpThangBaoCaoTonTimKiem.CustomFormat = "MM/yyyy"
        Me.dtpThangBaoCaoTonTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThangBaoCaoTonTimKiem.Location = New System.Drawing.Point(100, 6)
        Me.dtpThangBaoCaoTonTimKiem.Name = "dtpThangBaoCaoTonTimKiem"
        Me.dtpThangBaoCaoTonTimKiem.Size = New System.Drawing.Size(140, 20)
        Me.dtpThangBaoCaoTonTimKiem.TabIndex = 25
        Me.dtpThangBaoCaoTonTimKiem.Value = New Date(2018, 5, 19, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Tháng Báo Cáo"
        '
        'dtpThangBaoCaoTon
        '
        Me.dtpThangBaoCaoTon.CustomFormat = "MM/yyyy"
        Me.dtpThangBaoCaoTon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThangBaoCaoTon.Location = New System.Drawing.Point(100, 239)
        Me.dtpThangBaoCaoTon.Name = "dtpThangBaoCaoTon"
        Me.dtpThangBaoCaoTon.Size = New System.Drawing.Size(140, 20)
        Me.dtpThangBaoCaoTon.TabIndex = 23
        Me.dtpThangBaoCaoTon.Value = New Date(2018, 5, 12, 0, 0, 0, 0)
        '
        'btXoaBaoCaoTon
        '
        Me.btXoaBaoCaoTon.Location = New System.Drawing.Point(123, 277)
        Me.btXoaBaoCaoTon.Name = "btXoaBaoCaoTon"
        Me.btXoaBaoCaoTon.Size = New System.Drawing.Size(75, 23)
        Me.btXoaBaoCaoTon.TabIndex = 22
        Me.btXoaBaoCaoTon.Text = "Xóa"
        Me.btXoaBaoCaoTon.UseVisualStyleBackColor = True
        '
        'txtMaBaoCaoTon
        '
        Me.txtMaBaoCaoTon.Enabled = False
        Me.txtMaBaoCaoTon.Location = New System.Drawing.Point(100, 213)
        Me.txtMaBaoCaoTon.Name = "txtMaBaoCaoTon"
        Me.txtMaBaoCaoTon.ReadOnly = True
        Me.txtMaBaoCaoTon.Size = New System.Drawing.Size(140, 20)
        Me.txtMaBaoCaoTon.TabIndex = 20
        Me.txtMaBaoCaoTon.WordWrap = False
        '
        'btCapNhatBaoCaoTon
        '
        Me.btCapNhatBaoCaoTon.Location = New System.Drawing.Point(42, 277)
        Me.btCapNhatBaoCaoTon.Name = "btCapNhatBaoCaoTon"
        Me.btCapNhatBaoCaoTon.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhatBaoCaoTon.TabIndex = 2
        Me.btCapNhatBaoCaoTon.Text = "Cập nhật"
        Me.btCapNhatBaoCaoTon.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Tháng Báo Cáo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Mã Báo Cáo Tồn"
        '
        'dgvListBaoCaoTon
        '
        Me.dgvListBaoCaoTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListBaoCaoTon.Location = New System.Drawing.Point(6, 36)
        Me.dgvListBaoCaoTon.Name = "dgvListBaoCaoTon"
        Me.dgvListBaoCaoTon.Size = New System.Drawing.Size(234, 171)
        Me.dgvListBaoCaoTon.TabIndex = 0
        '
        'frmQLBaoCaoTon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 357)
        Me.Controls.Add(Me.tcListBaoCaoTon)
        Me.Name = "frmQLBaoCaoTon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Báo Cáo Tồn"
        Me.tcListBaoCaoTon.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvListBaoCaoTon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcListBaoCaoTon As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btXoaBaoCaoTon As Button
    Friend WithEvents txtMaBaoCaoTon As TextBox
    Friend WithEvents btCapNhatBaoCaoTon As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvListBaoCaoTon As DataGridView
    Friend WithEvents dtpThangBaoCaoTon As DateTimePicker
    Friend WithEvents dtpThangBaoCaoTonTimKiem As DateTimePicker
    Friend WithEvents Label3 As Label
End Class
