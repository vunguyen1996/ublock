Imports QLHS1DAL
Imports QLHS1DTO
Imports Utility

Public Class CTHoaDonBUS
    Private cthdDAL As CTHoaDonDAL
    Public Sub New()
        cthdDAL = New CTHoaDonDAL
    End Sub
    Public Sub New(connectionString As String)
        cthdDAL = New CTHoaDonDAL(connectionString)
    End Sub
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return cthdDAL.getNextID(nextID)
    End Function
    Public Function insert(cthd As CTHoaDonDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return cthdDAL.insert(cthd)
    End Function
End Class
