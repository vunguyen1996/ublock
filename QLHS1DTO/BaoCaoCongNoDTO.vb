Public Class BaoCaoCongNoDTO
    Private iMaBCCN As Integer
    Private dateThangBaoCao As DateTime

    Public Sub New()

    End Sub

    Public Sub New(iMaBCCN As Integer, dateThangBaoCao As DateTime)
        Me.iMaBCCN = iMaBCCN
        Me.dateThangBaoCao = dateThangBaoCao
    End Sub

    Property MaBaoCaoCongNo() As Integer
        Get
            Return iMaBCCN
        End Get
        Set(ByVal Value As Integer)
            iMaBCCN = Value
        End Set
    End Property

    Property ThangBaoCaoCongNo() As DateTime
        Get
            Return dateThangBaoCao
        End Get
        Set(value As DateTime)
            dateThangBaoCao = value
        End Set
    End Property
End Class
