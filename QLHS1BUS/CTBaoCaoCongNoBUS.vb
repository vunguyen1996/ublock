Imports QLHS1DAL
Imports QLHS1DTO
Imports Utility

Public Class CTBaoCaoCongNoBUS
    Private ctbccnDAL As CTBaoCaoCongNoDAL

    Public Sub New()
        ctbccnDAL = New CTBaoCaoCongNoDAL()
    End Sub

    Public Sub New(connectionString As String)
        ctbccnDAL = New CTBaoCaoCongNoDAL(connectionString)
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return ctbccnDAL.getNextID(nextID)
    End Function

    Public Function insert(ctbccn As CTBaoCaoCongNoDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctbccnDAL.insert(ctbccn)
    End Function

    Public Function update(ctbccn As CTBaoCaoCongNoDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctbccnDAL.update(ctbccn)
    End Function

    Public Function delete(mactbccn As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctbccnDAL.delete(mactbccn)
    End Function

    Public Function selectAll(ByRef listctbccn As List(Of CTBaoCaoCongNoDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctbccnDAL.selectALL(listctbccn)
    End Function

    Public Function selectAll_byMaBaoCao(maBaoCao As Integer, ByRef listctbccn As List(Of CTBaoCaoCongNoDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctbccnDAL.selectALL_byMaBaoCao(maBaoCao, listctbccn)
    End Function
End Class
