Public Class QuyDinhDTO
    Private iID As Integer
    Private iLuongNhapToiThieu As Integer
    Private iLuongTonToiDa As Integer
    Private iTienNoToiDa As Integer
    Private iLuongTonToiThieu As Integer
    Private strApDung As String

    Public Sub New()
        iID = 0
        iLuongNhapToiThieu = 0
        iLuongTonToiDa = 0
        iTienNoToiDa = 0
        iLuongNhapToiThieu = 0
    End Sub

    Public Sub New(id As Integer, iLuongNhapToiThieu As Integer, iLuongTonToiDa As Integer, iTienNoToiDa As Integer, iLuongTonToiThieu As Integer, strApDung As String)
        Me.iID = id
        Me.iLuongNhapToiThieu = iLuongNhapToiThieu
        Me.iLuongTonToiDa = iLuongTonToiDa
        Me.iTienNoToiDa = iTienNoToiDa
        Me.iLuongTonToiThieu = iLuongTonToiThieu
        Me.strApDung = strApDung
    End Sub

    Public Property ID() As Integer
        Get
            Return iID
        End Get
        Set(value As Integer)
            iID = value
        End Set
    End Property

    Public Property LuongNhapToiThieu() As Integer
        Get
            Return iLuongNhapToiThieu
        End Get
        Set(value As Integer)
            iLuongNhapToiThieu = value
        End Set
    End Property

    Public Property LuongTonToiDa() As Integer
        Get
            Return iLuongTonToiDa
        End Get
        Set(value As Integer)
            iLuongTonToiDa = value
        End Set
    End Property

    Public Property TienNoToiDa() As Integer
        Get
            Return iTienNoToiDa
        End Get
        Set(value As Integer)
            iTienNoToiDa = value
        End Set
    End Property

    Public Property LuongTonToiThieu() As Integer
        Get
            Return iLuongTonToiThieu
        End Get
        Set(value As Integer)
            iLuongTonToiThieu = value
        End Set
    End Property

    Public Property ApDung() As String
        Get
            Return strApDung
        End Get
        Set(value As String)
            strApDung = value
        End Set
    End Property
End Class
