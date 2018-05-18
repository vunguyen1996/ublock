Public Class PhieuThuTienDTO
    Private iMaPhieu As Integer
    Private iMaKH As Integer
    Private dateNgayThuTien As DateTime
    Private iSoTienThu As Integer

    Public Sub New()

    End Sub

    Public Sub New(iMaPhieu As Integer, iMaKH As Integer, dateNgayThuTien As DateTime, iSoTienThu As Integer)
        Me.iMaPhieu = iMaPhieu
        Me.iMaKH = iMaKH
        Me.dateNgayThuTien = dateNgayThuTien
        Me.iSoTienThu = iSoTienThu
    End Sub

    Public Property MaPhieuThu() As Integer
        Get
            Return iMaPhieu
        End Get
        Set(value As Integer)
            iMaPhieu = value
        End Set
    End Property

    Public Property MaKhachHang() As Integer
        Get
            Return iMaKH
        End Get
        Set(value As Integer)
            iMaKH = value
        End Set
    End Property

    Public Property NgayThu() As DateTime
        Get
            Return dateNgayThuTien
        End Get
        Set(value As DateTime)
            dateNgayThuTien = value
        End Set
    End Property

    Public Property SoTienThu() As Integer
        Get
            Return iSoTienThu
        End Get
        Set(value As Integer)
            iSoTienThu = value
        End Set
    End Property
End Class
