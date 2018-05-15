Imports QLHS1DAL
Imports QLHS1DTO
Imports Utility

Public Class SachBUS
    Private sachDAL As SachDAL
    Public Sub New()
        sachDAL = New SachDAL()
    End Sub
    Public Sub New(connectionString As String)
        sachDAL = New SachDAL(connectionString)
    End Sub
    Public Function isValidName(sach As SachDTO) As Boolean
        If (sach.TenSach.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function insert(sach As SachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.insert(sach)
    End Function
    Public Function update(sach As SachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.update(sach)
    End Function
    Public Function delete(maSach As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.delete(maSach)
    End Function
    Public Function selectAll(ByRef listSach As List(Of SachDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.selectALL(listSach)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return sachDAL.getNextID(nextID)
    End Function
    Public Function selectALL_ByType(maLoaiSach As Integer, ByRef listSach As List(Of SachDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.selectALL_ByType(maLoaiSach, listSach)
    End Function
End Class
