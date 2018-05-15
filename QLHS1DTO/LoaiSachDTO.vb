Public Class LoaiSachDTO
    Private iMaLoaiSach As Integer
    Private strTenLoaiSach As String

    Public Sub New()
    End Sub
    Public Sub New(maloaisach As Integer, tenloaisach As String)
        iMaLoaiSach = maloaisach
        strTenLoaiSach = tenloaisach
    End Sub
    Property MaLoaiSach() As Integer
        Get
            Return iMaLoaiSach
        End Get
        Set(ByVal Value As Integer)
            iMaLoaiSach = Value
        End Set
    End Property
    Property TenLoaiSach() As String
        Get
            Return strTenLoaiSach
        End Get
        Set(ByVal Value As String)
            strTenLoaiSach = Value
        End Set
    End Property
End Class
