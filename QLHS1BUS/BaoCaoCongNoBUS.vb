Imports QLHS1DAL
Imports QLHS1DTO
Imports Utility

Public Class BaoCaoCongNoBUS
    Private bccnDAL As BaoCaoCongNoDAL

    Public Sub New()
        bccnDAL = New BaoCaoCongNoDAL()
    End Sub

    Public Sub New(connectionString As String)
        bccnDAL = New BaoCaoCongNoDAL(connectionString)
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return bccnDAL.getNextID(nextID)
    End Function

    Public Function insert(bccn As BaoCaoCongNoDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccnDAL.insert(bccn)
    End Function

    Public Function update(bccn As BaoCaoCongNoDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccnDAL.update(bccn)
    End Function

    Public Function delete(mabccn As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccnDAL.delete(mabccn)
    End Function

    Public Function selectAll(ByRef listBaoCaoCongNo As List(Of BaoCaoCongNoDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccnDAL.selectALL(listBaoCaoCongNo)
    End Function

    Public Function selectAll_byMaBaoCaoTon(maBaoCao As Integer, ByRef listBaoCaoCongNo As List(Of BaoCaoCongNoDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccnDAL.selectALL_byMaBaoCao(maBaoCao, listBaoCaoCongNo)
    End Function

    Public Function selectAll_byThangBaoCao(thangBaoCao As DateTime, ByRef listBaoCaoCongNo As List(Of BaoCaoCongNoDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccnDAL.selectALL_byThangBaoCao(thangBaoCao, listBaoCaoCongNo)
    End Function

End Class
