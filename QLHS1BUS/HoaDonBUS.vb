Imports QLHS1DAL
Imports QLHS1DTO
Imports Utility

Public Class HoaDonBUS
    Private hdDAL As HoaDonDAL
    Public Sub New()
        hdDAL = New HoaDonDAL
    End Sub
    Public Sub New(connectionString As String)
        hdDAL = New HoaDonDAL(connectionString)
    End Sub
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return hdDAL.getNextID(nextID)
    End Function
    Public Function insert(pn As HoaDonDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return hdDAL.insert(pn)
    End Function
    Public Function update(hoadon As HoaDonDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return hdDAL.update(hoadon)
    End Function
    Public Function delete(mahd As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return hdDAL.delete(mahd)
    End Function
    Public Function selectAll(ByRef listhd As List(Of HoaDonDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return hdDAL.selectALL(listhd)
    End Function
    Public Function selectAll_ByNgayHD(ngayHD As DateTime, ByRef listhd As List(Of HoaDonDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return hdDAL.selectALL_ByNgayHD(ngayHD, listhd)
    End Function

    Public Function selectAll_ByMaHD(maHD As Integer, ByRef listhd As List(Of HoaDonDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return hdDAL.selectALL_ByMaHD(maHD, listhd)
    End Function
End Class
