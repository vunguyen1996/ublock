Public Class QuyDinhDTO
    Private iID As Integer
    Private iLNTT As Integer
    Private iLTTD As Integer
    Private iTNTD As Integer
    Private iLTTT As Integer

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, iLNTT As Integer, iLTTD As Integer, iTNTD As Integer, iLTTT As Integer)
        Me.iID = id
        Me.iLNTT = iLNTT
        Me.iLTTD = iLTTD
        Me.iTNTD = iTNTD
        Me.iLTTT = iLTTT
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
            Return iLNTT
        End Get
        Set(value As Integer)
            iLNTT = value
        End Set
    End Property

    Public Property LuongTonToiDa() As Integer
        Get
            Return iLTTD
        End Get
        Set(value As Integer)
            iLTTD = value
        End Set
    End Property

    Public Property TienNoToiDa() As Integer
        Get
            Return iTNTD
        End Get
        Set(value As Integer)
            iTNTD = value
        End Set
    End Property

    Public Property LuongTonToiThieu() As Integer
        Get
            Return iLTTT
        End Get
        Set(value As Integer)
            iLTTT = value
        End Set
    End Property
End Class
