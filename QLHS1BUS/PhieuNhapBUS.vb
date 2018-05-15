Imports QLHS1DAL
Imports QLHS1DTO
Imports Utility

Public Class PhieuNhapBUS
    Private pnDAL As PhieuNhapDAL
    Public Sub New()
        pnDAL = New PhieuNhapDAL
    End Sub
    Public Sub New(connectionString As String)
        pnDAL = New PhieuNhapDAL(connectionString)
    End Sub
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return pnDAL.getNextID(nextID)
    End Function
    Public Function insert(pn As PhieuNhapDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pnDAL.insert(pn)
    End Function
    Public Function update(pn As PhieuNhapDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pnDAL.update(pn)
    End Function
    Public Function delete(maphieu As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pnDAL.delete(maphieu)
    End Function
    Public Function selectAll(ByRef listPhieu As List(Of PhieuNhapDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pnDAL.selectALL(listPhieu)
    End Function
End Class
