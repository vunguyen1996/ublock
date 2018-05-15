Public Class BaoCaoTonDTO
    Private iMaBaoCaoTon As Integer
    Private dateThangBaoCao As DateTime
    Public Sub New()

    End Sub
    Public Sub New(iMaBaoCaoTon As Integer, dateThangBaoCao As DateTime)
        Me.iMaBaoCaoTon = iMaBaoCaoTon
        Me.dateThangBaoCao = dateThangBaoCao
    End Sub
    Property MaBaoCaoTon() As Integer
        Get
            Return iMaBaoCaoTon
        End Get
        Set(ByVal Value As Integer)
            iMaBaoCaoTon = Value
        End Set
    End Property

    Property ThangBaoCao() As DateTime
        Get
            Return dateThangBaoCao
        End Get
        Set(ByVal value As DateTime)
            dateThangBaoCao = value
        End Set
    End Property
End Class
