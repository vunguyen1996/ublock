<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLBaoCaoCongNo
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
        Me.btXoaBaoCaoCongNo = New System.Windows.Forms.Button()
        Me.txtMaBaoCaoCongNo = New System.Windows.Forms.TextBox()
        Me.btCapNhatBaoCaoCongNo = New System.Windows.Forms.Button()
        Me.dtpThangBaoCaoCongNo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvListBaoCaoCongNo = New System.Windows.Forms.DataGridView()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtpThangBaoCaoCongNoTimKiem = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvListBaoCaoCongNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 224)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(260, 126)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btXoaBaoCaoCongNo)
        Me.TabPage1.Controls.Add(Me.txtMaBaoCaoCongNo)
        Me.TabPage1.Controls.Add(Me.btCapNhatBaoCaoCongNo)
        Me.TabPage1.Controls.Add(Me.dtpThangBaoCaoCongNo)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(252, 100)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Báo Cáo Công Nợ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btXoaBaoCaoCongNo
        '
        Me.btXoaBaoCaoCongNo.Location = New System.Drawing.Point(129, 71)
        Me.btXoaBaoCaoCongNo.Name = "btXoaBaoCaoCongNo"
        Me.btXoaBaoCaoCongNo.Size = New System.Drawing.Size(75, 23)
        Me.btXoaBaoCaoCongNo.TabIndex = 19
        Me.btXoaBaoCaoCongNo.Text = "Xóa"
        Me.btXoaBaoCaoCongNo.UseVisualStyleBackColor = True
        '
        'txtMaBaoCaoCongNo
        '
        Me.txtMaBaoCaoCongNo.Enabled = False
        Me.txtMaBaoCaoCongNo.Location = New System.Drawing.Point(140, 6)
        Me.txtMaBaoCaoCongNo.Name = "txtMaBaoCaoCongNo"
        Me.txtMaBaoCaoCongNo.ReadOnly = True
        Me.txtMaBaoCaoCongNo.Size = New System.Drawing.Size(106, 20)
        Me.txtMaBaoCaoCongNo.TabIndex = 8
        '
        'btCapNhatBaoCaoCongNo
        '
        Me.btCapNhatBaoCaoCongNo.Location = New System.Drawing.Point(48, 71)
        Me.btCapNhatBaoCaoCongNo.Name = "btCapNhatBaoCaoCongNo"
        Me.btCapNhatBaoCaoCongNo.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhatBaoCaoCongNo.TabIndex = 1
        Me.btCapNhatBaoCaoCongNo.Text = "Cập nhật"
        Me.btCapNhatBaoCaoCongNo.UseVisualStyleBackColor = True
        '
        'dtpThangBaoCaoCongNo
        '
        Me.dtpThangBaoCaoCongNo.CustomFormat = "MM/yyyy"
        Me.dtpThangBaoCaoCongNo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThangBaoCaoCongNo.Location = New System.Drawing.Point(140, 32)
        Me.dtpThangBaoCaoCongNo.Name = "dtpThangBaoCaoCongNo"
        Me.dtpThangBaoCaoCongNo.Size = New System.Drawing.Size(106, 20)
        Me.dtpThangBaoCaoCongNo.TabIndex = 18
        Me.dtpThangBaoCaoCongNo.Value = New Date(2018, 5, 19, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tháng Báo Cáo Công Nợ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Báo Cáo Công Nợ"
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage4)
        Me.TabControl3.Location = New System.Drawing.Point(12, 72)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(260, 150)
        Me.TabControl3.TabIndex = 6
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvListBaoCaoCongNo)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(252, 124)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Danh Sách Báo Cáo Công Nợ"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvListBaoCaoCongNo
        '
        Me.dgvListBaoCaoCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListBaoCaoCongNo.Location = New System.Drawing.Point(6, 6)
        Me.dgvListBaoCaoCongNo.Name = "dgvListBaoCaoCongNo"
        Me.dgvListBaoCaoCongNo.Size = New System.Drawing.Size(240, 112)
        Me.dgvListBaoCaoCongNo.TabIndex = 0
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(260, 58)
        Me.TabControl2.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtpThangBaoCaoCongNoTimKiem)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(252, 32)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Tìm Kiếm"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dtpThangBaoCaoCongNoTimKiem
        '
        Me.dtpThangBaoCaoCongNoTimKiem.CustomFormat = "MM/yyyy"
        Me.dtpThangBaoCaoCongNoTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThangBaoCaoCongNoTimKiem.Location = New System.Drawing.Point(142, 6)
        Me.dtpThangBaoCaoCongNoTimKiem.Name = "dtpThangBaoCaoCongNoTimKiem"
        Me.dtpThangBaoCaoCongNoTimKiem.Size = New System.Drawing.Size(104, 20)
        Me.dtpThangBaoCaoCongNoTimKiem.TabIndex = 20
        Me.dtpThangBaoCaoCongNoTimKiem.Value = New Date(2018, 5, 19, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Tháng Báo Cáo Công Nợ"
        '
        'frmQLBaoCaoCongNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 360)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "frmQLBaoCaoCongNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Báo Cáo Công Nợ"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvListBaoCaoCongNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btCapNhatBaoCaoCongNo As Button
    Friend WithEvents dtpThangBaoCaoCongNo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgvListBaoCaoCongNo As DataGridView
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dtpThangBaoCaoCongNoTimKiem As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaBaoCaoCongNo As TextBox
    Friend WithEvents btXoaBaoCaoCongNo As Button
End Class
