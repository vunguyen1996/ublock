Imports System.Text.RegularExpressions
Imports QLHS1DAL
Imports QLHS1DTO
Imports Utility

Public Class KhachHangBUS
    Private khDAL As KhachHangDAL

    Public Sub New()
        khDAL = New KhachHangDAL
    End Sub

    Public Sub New(connectionString As String)
        khDAL = New KhachHangDAL(connectionString)
    End Sub

    Public Function isValidName(kh As KhachHangDTO) As Boolean
        If (kh.TenKhachHang.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    'Public Function isValidEmail(emailAddress As KhachHangDTO) As Boolean
    '    ' Dim email As New Regex("^(?<user>[^@]+)@(?<host>.+)$")
    '    Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
    '    If (email.IsMatch()) Then

    '    End If

    '    'If email.IsMatch(emailAddress) Then
    '    '    Return True
    '    'Else
    '    '    Return False
    '    'End If
    'End Function

    Public Function insert(kh As KhachHangDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return khDAL.insert(kh)
    End Function
    Public Function update(kh As KhachHangDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return khDAL.update(kh)
    End Function
    Public Function delete(makh As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return khDAL.delete(makh)
    End Function
    Public Function selectAll(ByRef listkh As List(Of KhachHangDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return khDAL.selectALL(listkh)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return khDAL.getNextID(nextID)
    End Function

    Public Function selectALL_ByType(makh As Integer, ByRef listkh As List(Of KhachHangDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return khDAL.selectALL_ByType(makh, listkh)
    End Function
End Class
