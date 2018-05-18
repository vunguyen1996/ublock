<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThayDoiQuyDinh
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
        Me.txtLuongTonToiDa = New System.Windows.Forms.TextBox()
        Me.btCapNhatQuyDinh = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLuongTonToiThieu = New System.Windows.Forms.TextBox()
        Me.cbqd = New System.Windows.Forms.CheckBox()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.txtTienNoToiDa = New System.Windows.Forms.TextBox()
        Me.txtLuongNhapToiThieu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLuongTonToiDa
        '
        Me.txtLuongTonToiDa.Location = New System.Drawing.Point(181, 32)
        Me.txtLuongTonToiDa.Name = "txtLuongTonToiDa"
        Me.txtLuongTonToiDa.Size = New System.Drawing.Size(266, 20)
        Me.txtLuongTonToiDa.TabIndex = 6
        '
        'btCapNhatQuyDinh
        '
        Me.btCapNhatQuyDinh.Location = New System.Drawing.Point(206, 184)
        Me.btCapNhatQuyDinh.Name = "btCapNhatQuyDinh"
        Me.btCapNhatQuyDinh.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhatQuyDinh.TabIndex = 9
        Me.btCapNhatQuyDinh.Text = "Cập nhật"
        Me.btCapNhatQuyDinh.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(461, 166)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtLuongTonToiThieu)
        Me.TabPage1.Controls.Add(Me.cbqd)
        Me.TabPage1.Controls.Add(Me.txt)
        Me.TabPage1.Controls.Add(Me.txtTienNoToiDa)
        Me.TabPage1.Controls.Add(Me.txtLuongTonToiDa)
        Me.TabPage1.Controls.Add(Me.txtLuongNhapToiThieu)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(453, 140)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Danh Sách Các Quy Định"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Áp Dụng Hoặc Không Áp Dụng"
        '
        'txtLuongTonToiThieu
        '
        Me.txtLuongTonToiThieu.Location = New System.Drawing.Point(181, 84)
        Me.txtLuongTonToiThieu.Name = "txtLuongTonToiThieu"
        Me.txtLuongTonToiThieu.Size = New System.Drawing.Size(266, 20)
        Me.txtLuongTonToiThieu.TabIndex = 10
        '
        'cbqd
        '
        Me.cbqd.AutoSize = True
        Me.cbqd.Location = New System.Drawing.Point(215, 112)
        Me.cbqd.Name = "cbqd"
        Me.cbqd.Size = New System.Drawing.Size(192, 17)
        Me.cbqd.TabIndex = 9
        Me.cbqd.Text = "Tiền Thu Không Vượt Quá Tiền Nợ"
        Me.cbqd.UseVisualStyleBackColor = True
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt.Enabled = False
        Me.txt.Location = New System.Drawing.Point(181, 110)
        Me.txt.Name = "txt"
        Me.txt.ReadOnly = True
        Me.txt.Size = New System.Drawing.Size(266, 20)
        Me.txt.TabIndex = 8
        '
        'txtTienNoToiDa
        '
        Me.txtTienNoToiDa.Location = New System.Drawing.Point(181, 58)
        Me.txtTienNoToiDa.Name = "txtTienNoToiDa"
        Me.txtTienNoToiDa.Size = New System.Drawing.Size(266, 20)
        Me.txtTienNoToiDa.TabIndex = 7
        '
        'txtLuongNhapToiThieu
        '
        Me.txtLuongNhapToiThieu.Location = New System.Drawing.Point(181, 6)
        Me.txtLuongNhapToiThieu.Name = "txtLuongNhapToiThieu"
        Me.txtLuongNhapToiThieu.Size = New System.Drawing.Size(266, 20)
        Me.txtLuongNhapToiThieu.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lượng Tồn Tối Thiểu Sau Khi Bán"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lượng Nhập Tối Thiểu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tiền Nợ Tối Đa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lượng Tồn Tối Đa Trước Khi Bán"
        '
        'frmThayDoiQuyDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 217)
        Me.Controls.Add(Me.btCapNhatQuyDinh)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmThayDoiQuyDinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thay Đổi Quy Định"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtLuongTonToiDa As TextBox
    Friend WithEvents btCapNhatQuyDinh As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLuongTonToiThieu As TextBox
    Friend WithEvents cbqd As CheckBox
    Friend WithEvents txt As TextBox
    Friend WithEvents txtTienNoToiDa As TextBox
    Friend WithEvents txtLuongNhapToiThieu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
