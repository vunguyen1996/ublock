Imports System.Configuration

Public Class frmMain
    Private ConnectionString As String

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ThêmPhiếuNhậpSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmPhiếuNhậpSáchToolStripMenuItem.Click
        Dim frm As frmThemPhieuNhap = New frmThemPhieuNhap
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýPhiếuNhậpSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhiếuNhậpSáchToolStripMenuItem.Click
        Dim frm As frmQLPhieuNhap = New frmQLPhieuNhap
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmChiTiếtPhiếuNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmChiTiếtPhiếuNhậpToolStripMenuItem.Click
        Dim frm As frmThemCTPhieuNhap = New frmThemCTPhieuNhap
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmLoạiSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmLoạiSáchToolStripMenuItem.Click
        Dim frm As frmThemLoaiSach = New frmThemLoaiSach
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýLoạiSáchToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles QuảnLýLoạiSáchToolStripMenuItem.Click
        Dim frm As frmQLLoaiSach = New frmQLLoaiSach
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmSáchToolStripMenuItem.Click
        Dim frm As frmThemSach = New frmThemSach
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSáchToolStripMenuItem.Click
        Dim frm As frmQLSach = New frmQLSach
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýChiTiếtPhiếuNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýChiTiếtPhiếuNhậpToolStripMenuItem.Click
        Dim frm As frmQLCTPhieuNhap = New frmQLCTPhieuNhap
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmKháchHàngToolStripMenuItem.Click
        Dim frm As frmThemKhachHang = New frmThemKhachHang
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýKháchHàngToolStripMenuItem.Click
        Dim frm As frmQLKhachHang = New frmQLKhachHang
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmBáoCáoTồnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmBáoCáoTồnToolStripMenuItem.Click
        Dim frm As frmThemBaoCaoTon = frmThemBaoCaoTon
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýBáoCáoTồnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýBáoCáoTồnToolStripMenuItem.Click
        Dim frm As frmQLBaoCaoTon = New frmQLBaoCaoTon
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
