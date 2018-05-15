Public Class SachDTO
    Private iMaSach As Integer
    Private strTenSach As String
    Private iMaLoaiSach As Integer
    Private strTacGia As String
    Private iSoLuongTon As Integer
    Public Sub New()

    End Sub
    Public Sub New(iMaSach As Integer, strTenSach As String, iMaLoaiSach As Integer, strTacGia As String, iSoluongTon As Integer)
        Me.iMaSach = iMaSach
        Me.strTenSach = strTenSach
        Me.iMaLoaiSach = iMaLoaiSach
        Me.strTacGia = strTacGia
        Me.iSoLuongTon = iSoluongTon
    End Sub
    Public Property MaSach As Integer
        Get
            Return iMaSach
        End Get
        Set(value As Integer)
            iMaSach = value
        End Set
    End Property
    Public Property TenSach As String
        Get
            Return strTenSach
        End Get
        Set(value As String)
            strTenSach = value
        End Set
    End Property
    Public Property MaLoaiSach As Integer
        Get
            Return iMaLoaiSach
        End Get
        Set(value As Integer)
            iMaLoaiSach = value
        End Set
    End Property
    Public Property TacGia As String
        Get
            Return strTacGia
        End Get
        Set(value As String)
            strTacGia = value
        End Set
    End Property
    Public Property SoLuongTon As Integer
        Get
            Return iSoLuongTon
        End Get
        Set(value As Integer)
            iSoLuongTon = value
        End Set
    End Property
End Class
