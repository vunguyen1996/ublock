Public Class KhachHangDTO
    Private iMaKH As Integer
    Private strHoTenKH As String
    Private iTienNoKH As String
    Private strDiaChi As String
    Private strEmail As String
    Private strSDT As String

    Public Sub New()

    End Sub

    Public Sub New(iMaKH As Integer, strHoTenKH As String, iTienNoKH As String, strDiaChi As String, strEmail As String, strSDT As String)
        Me.iMaKH = iMaKH
        Me.strHoTenKH = strHoTenKH
        Me.iTienNoKH = iTienNoKH
        Me.strDiaChi = strDiaChi
        Me.strEmail = strEmail
        Me.strSDT = strSDT
    End Sub

    Public Property MaKH() As Integer
        Get
            Return iMaKH
        End Get
        Set(value As Integer)
            iMaKH = value
        End Set
    End Property

    Public Property TenKhachHang() As String
        Get
            Return strHoTenKH
        End Get
        Set(value As String)
            strHoTenKH = value
        End Set
    End Property

    Public Property TienNoKH() As String
        Get
            Return iTienNoKH
        End Get
        Set(value As String)
            iTienNoKH = value
        End Set
    End Property

    Public Property DiaChiKH() As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return strEmail
        End Get
        Set(value As String)
            strEmail = value
        End Set
    End Property

    Public Property SDT() As String
        Get
            Return strSDT
        End Get
        Set(value As String)
            strSDT = value
        End Set
    End Property
End Class
