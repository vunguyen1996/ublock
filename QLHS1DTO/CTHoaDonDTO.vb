Public Class CTHoaDonDTO
    Private iMaCTHD As Integer
    Private iMaHD As Integer
    Private iMaSach As Integer
    Private iSoluongBan As Integer
    Private iDonGiaBan As Integer
    Private iThanhTien As Integer

    Public Sub New()

    End Sub

    Public Sub New(iMaCTHD As Integer, iMaHD As Integer, iMaSach As Integer, iSoluongBan As Integer, iDonGiaBan As Integer, iThanhTien As Integer)
        Me.iMaCTHD = iMaCTHD
        Me.iMaHD = iMaHD
        Me.iMaSach = iMaSach
        Me.iSoluongBan = iSoluongBan
        Me.iDonGiaBan = iDonGiaBan
        Me.iThanhTien = iThanhTien
    End Sub

    Property MaChiTietHD() As Integer
        Get
            Return iMaCTHD
        End Get
        Set(ByVal Value As Integer)
            iMaCTHD = Value
        End Set
    End Property

    Property MaHD() As Integer
        Get
            Return iMaHD
        End Get
        Set(ByVal Value As Integer)
            iMaHD = Value
        End Set
    End Property

    Property MaSach() As Integer
        Get
            Return iMaSach
        End Get
        Set(ByVal Value As Integer)
            iMaSach = Value
        End Set
    End Property

    Property SoLuongBan() As Integer
        Get
            Return iSoluongBan
        End Get
        Set(ByVal Value As Integer)
            iSoluongBan = Value
        End Set
    End Property

    Property DonGia() As Integer
        Get
            Return iDonGiaBan
        End Get
        Set(ByVal Value As Integer)
            iDonGiaBan = Value
        End Set
    End Property

    Property ThanhTien() As Integer
        Get
            Return iThanhTien
        End Get
        Set(ByVal Value As Integer)
            iThanhTien = Value
        End Set
    End Property
End Class
