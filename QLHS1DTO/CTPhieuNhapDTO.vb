Public Class CTPhieuNhapDTO
    Private iMaCTPN As Integer
    Private iMAPN As Integer
    Private iMASACH As Integer
    Private iSoLuongNhap As Integer

    Public Sub New()
    End Sub
    Public Sub New(mactpn As Integer, mapn As Integer, masach As Integer, soluong As Integer)
        Me.iMaCTPN = mactpn
        Me.iMAPN = mapn
        Me.iMASACH = masach
        Me.iSoLuongNhap = soluong
    End Sub
    Property MaChiTietPhieuNhap() As Integer
        Get
            Return iMaCTPN
        End Get
        Set(ByVal Value As Integer)
            iMaCTPN = Value
        End Set
    End Property
    Property MaPhieuNhap() As Integer
        Get
            Return iMAPN
        End Get
        Set(ByVal Value As Integer)
            iMAPN = Value
        End Set
    End Property
    Property MaSach() As Integer
        Get
            Return iMASACH
        End Get
        Set(ByVal Value As Integer)
            iMASACH = Value
        End Set
    End Property
    Property SoLuongNhap() As Integer
        Get
            Return iSoLuongNhap
        End Get
        Set(ByVal Value As Integer)
            iSoLuongNhap = Value
        End Set
    End Property
End Class
