Public Class CTBaoCaoCongNoDTO
    Private iMaCTBCCN As Integer
    Private iMaKH As Integer
    Private iMaBCCN As Integer
    Private strSoTienNoDau As String
    Private strSoTienPhatSinh As String
    Private strSoTienNoCuoi As String

    Public Sub New()

    End Sub

    Public Sub New(iMaCTBCCN As Integer, iMaKH As Integer, iMaBCCN As Integer, strSoTienNoDau As String, strSoTienPhatSinh As String, strSoTienNoCuoi As String)
        Me.iMaCTBCCN = iMaCTBCCN
        Me.iMaKH = iMaKH
        Me.iMaBCCN = iMaBCCN
        Me.strSoTienNoDau = strSoTienNoDau
        Me.strSoTienPhatSinh = strSoTienPhatSinh
        Me.strSoTienNoCuoi = strSoTienNoCuoi
    End Sub

    Property MaChiTietBaoCaoCongNo() As Integer
        Get
            Return iMaCTBCCN
        End Get
        Set(ByVal Value As Integer)
            iMaCTBCCN = Value
        End Set
    End Property

    Property MaKhachHang() As Integer
        Get
            Return iMaKH
        End Get
        Set(ByVal Value As Integer)
            iMaKH = Value
        End Set
    End Property

    Property MaBaoCaoCongNo() As Integer
        Get
            Return iMaBCCN
        End Get
        Set(ByVal Value As Integer)
            iMaBCCN = Value
        End Set
    End Property

    Property SoTienNoDau() As Integer
        Get
            Return strSoTienNoDau
        End Get
        Set(ByVal Value As Integer)
            strSoTienNoDau = Value
        End Set
    End Property

    Property SoTienPhatSinh() As Integer
        Get
            Return strSoTienPhatSinh
        End Get
        Set(ByVal Value As Integer)
            strSoTienPhatSinh = Value
        End Set
    End Property

    Property SoTienNoCuoi() As Integer
        Get
            Return strSoTienNoCuoi
        End Get
        Set(ByVal Value As Integer)
            strSoTienNoCuoi = Value
        End Set
    End Property
End Class
