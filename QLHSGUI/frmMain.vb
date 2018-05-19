Imports System.Configuration

Public Class frmMain
    Private ConnectionString As String

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ThêmPhiếuNhậpSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmPhiếuNhậpSáchToolStripMenuItem.Click
        Dim frm As frmLapPhieuNhapSach = New frmLapPhieuNhapSach
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
        Dim frm As frmLapBaoCaoTon = frmLapBaoCaoTon
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýBáoCáoTồnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýBáoCáoTồnToolStripMenuItem.Click
        Dim frm As frmQLBaoCaoTon = New frmQLBaoCaoTon
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuyĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuyĐịnhToolStripMenuItem.Click
        Dim frm As frmThayDoiQuyDinh = New frmThayDoiQuyDinh
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LậpHóaĐơnBánSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpHóaĐơnBánSáchToolStripMenuItem.Click
        Dim frm As frmLapHoaDon = New frmLapHoaDon
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýHóaĐơnBánSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýHóaĐơnBánSáchToolStripMenuItem.Click
        Dim frm As frmQLHoaDon = New frmQLHoaDon
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Dim frm As frmAbout = New frmAbout
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LậpPhiếuThuTiềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpPhiếuThuTiềnToolStripMenuItem.Click
        Dim frm As frmLapPhieuThuTien = New frmLapPhieuThuTien
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýPhiếuThuTiềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhiếuThuTiềnToolStripMenuItem.Click
        Dim frm As frmQLPhieuThuTien = New frmQLPhieuThuTien
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmChiTiếtBáoCáoTồnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmChiTiếtBáoCáoTồnToolStripMenuItem.Click
        Dim frm As frmThemCTBaoCaoTon = New frmThemCTBaoCaoTon
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýChiTiếtBáoCáoTồnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýChiTiếtBáoCáoTồnToolStripMenuItem.Click
        Dim frm As frmQLCTBaoCaoTon = New frmQLCTBaoCaoTon
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmChiTiếtHóaĐơnToolStripMenuItem.Click
        Dim frm As frmThemCTHoaDon = New frmThemCTHoaDon
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýChiTiếtHóaĐơnToolStripMenuItem.Click
        Dim frm As frmQLCTHoaDon = New frmQLCTHoaDon
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LậpBáoCáoCôngNợToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpBáoCáoCôngNợToolStripMenuItem.Click
        Dim frm As frmLapBaoCaoCongNo = frmLapBaoCaoCongNo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýBáoCáoCôngNợToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýBáoCáoCôngNợToolStripMenuItem.Click
        Dim frm As frmQLBaoCaoCongNo = New frmQLBaoCaoCongNo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmChiTiếtBáoCáoCôngNợToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmChiTiếtBáoCáoCôngNợToolStripMenuItem.Click
        Dim frm As frmThemCTBaoCaoCongNo = New frmThemCTBaoCaoCongNo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýChiTiếtBáoCáoCôngNợToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýChiTiếtBáoCáoCôngNợToolStripMenuItem.Click
        Dim frm As frmQLCTBaoCaoCongNo = New frmQLCTBaoCaoCongNo
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
