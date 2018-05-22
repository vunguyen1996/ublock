Public Class CTBaoCaoCongNoDTO
    Private iMaCTBCCN As Integer
    Private iMaKH As Integer
    Private iMaBCCN As Integer
    Private txtSoTienNoDau As String
    Private txtSoTienPhatSinh As String
    Private txtSoTienNoCuoi As String

    Public Sub New()

    End Sub

    Public Sub New(iMaCTBCCN As Integer, iMaKH As Integer, iMaBCCN As Integer, strSoTienNoDau As String, strSoTienPhatSinh As String, strSoTienNoCuoi As String)
        Me.iMaCTBCCN = iMaCTBCCN
        Me.iMaKH = iMaKH
        Me.iMaBCCN = iMaBCCN
        Me.txtSoTienNoDau = strSoTienNoDau
        Me.txtSoTienPhatSinh = strSoTienPhatSinh
        Me.txtSoTienNoCuoi = strSoTienNoCuoi
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

    Property SoTienNoDau() As String
        Get
            Return txtSoTienNoDau
        End Get
        Set(ByVal Value As String)
            txtSoTienNoDau = Value
        End Set
    End Property

    Property SoTienPhatSinh() As String
        Get
            Return txtSoTienPhatSinh
        End Get
        Set(ByVal Value As String)
            txtSoTienPhatSinh = Value
        End Set
    End Property

    Property SoTienNoCuoi() As String
        Get
            Return txtSoTienNoCuoi
        End Get
        Set(ByVal Value As String)
            txtSoTienNoCuoi = Value
        End Set
    End Property
End Class
