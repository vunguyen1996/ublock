<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemLoaiSach
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
        Me.btNhapLoaiSach = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtTenLoaiSach = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaLoaiSach = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btNhapLoaiSach
        '
        Me.btNhapLoaiSach.Location = New System.Drawing.Point(184, 118)
        Me.btNhapLoaiSach.Name = "btNhapLoaiSach"
        Me.btNhapLoaiSach.Size = New System.Drawing.Size(75, 23)
        Me.btNhapLoaiSach.TabIndex = 19
        Me.btNhapLoaiSach.Text = "Nhập"
        Me.btNhapLoaiSach.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(422, 100)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtTenLoaiSach)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtMaLoaiSach)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(414, 74)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Loại Sách"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtTenLoaiSach
        '
        Me.txtTenLoaiSach.Location = New System.Drawing.Point(83, 40)
        Me.txtTenLoaiSach.Name = "txtTenLoaiSach"
        Me.txtTenLoaiSach.Size = New System.Drawing.Size(325, 20)
        Me.txtTenLoaiSach.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã loại sách"
        '
        'txtMaLoaiSach
        '
        Me.txtMaLoaiSach.Enabled = False
        Me.txtMaLoaiSach.Location = New System.Drawing.Point(83, 11)
        Me.txtMaLoaiSach.Name = "txtMaLoaiSach"
        Me.txtMaLoaiSach.ReadOnly = True
        Me.txtMaLoaiSach.Size = New System.Drawing.Size(325, 20)
        Me.txtMaLoaiSach.TabIndex = 15
        Me.txtMaLoaiSach.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên loại sách"
        '
        'frmThemLoaiSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 149)
        Me.Controls.Add(Me.btNhapLoaiSach)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmThemLoaiSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Loại Sách"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btNhapLoaiSach As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtTenLoaiSach As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaLoaiSach As TextBox
    Friend WithEvents Label2 As Label
End Class
