Public Class CTBaoCaoTonDTO
    Private imaCTBCT As Integer
    Private imaSach As Integer
    Private imaBCT As Integer
    Private itonDau As Integer
    Private iphatSinh As Integer
    Private itonCuoi As Integer

    Public Sub New()

    End Sub

    Public Sub New(imaCTBCT As Integer, imaSach As Integer, imaBCT As Integer, tonDau As Integer, phatSinh As Integer, tonCuoi As Integer)
        Me.imaCTBCT = imaCTBCT
        Me.imaSach = imaSach
        Me.imaBCT = imaBCT
        Me.itonDau = tonDau
        Me.iphatSinh = phatSinh
        Me.itonCuoi = tonCuoi
    End Sub

    Property MaChiTietBaoCaoTon() As Integer
        Get
            Return imaCTBCT
        End Get
        Set(ByVal Value As Integer)
            imaCTBCT = Value
        End Set
    End Property

    Property MaSach() As Integer
        Get
            Return imaSach
        End Get
        Set(ByVal Value As Integer)
            imaSach = Value
        End Set
    End Property

    Property MaBaoCaoTon() As Integer
        Get
            Return imaBCT
        End Get
        Set(ByVal Value As Integer)
            imaBCT = Value
        End Set
    End Property

    Property TonDau() As Integer
        Get
            Return itonDau
        End Get
        Set(ByVal Value As Integer)
            itonDau = Value
        End Set
    End Property

    Property PhatSinh() As Integer
        Get
            Return iphatSinh
        End Get
        Set(ByVal Value As Integer)
            iphatSinh = Value
        End Set
    End Property

    Property TonCuoi() As Integer
        Get
            Return itonCuoi
        End Get
        Set(ByVal Value As Integer)
            itonCuoi = Value
        End Set
    End Property
End Class
