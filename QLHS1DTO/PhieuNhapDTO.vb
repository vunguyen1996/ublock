Public Class PhieuNhapDTO
    Private iMaPhieuNhap As Integer
    Private dateNgayNhap As DateTime
    Public Sub New()

    End Sub

    Public Sub New(mpn As Integer, dateNgayNhap As DateTime)
        Me.iMaPhieuNhap = mpn
        Me.dateNgayNhap = dateNgayNhap
    End Sub

    Property MaPhieuNhap() As Integer
        Get
            Return iMaPhieuNhap
        End Get
        Set(ByVal Value As Integer)
            iMaPhieuNhap = Value
        End Set
    End Property

    Property NgayNhap() As DateTime
        Get
            Return dateNgayNhap
        End Get
        Set(ByVal value As DateTime)
            dateNgayNhap = value
        End Set
    End Property
End Class
