Imports QLHS1DAL
Imports QLHS1DTO
Imports Utility

Public Class BaoCaoTonBUS
    Private bctDAL As BaoCaoTonDAL

    Public Sub New()
        bctDAL = New BaoCaoTonDAL()
    End Sub

    Public Sub New(connectionString As String)
        bctDAL = New BaoCaoTonDAL(connectionString)
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return bctDAL.getNextID(nextID)
    End Function

    Public Function insert(bct As BaoCaoTonDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bctDAL.insert(bct)
    End Function

    Public Function update(bct As BaoCaoTonDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bctDAL.update(bct)
    End Function

    Public Function delete(mabct As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bctDAL.delete(mabct)
    End Function

    Public Function selectAll(ByRef listbct As List(Of BaoCaoTonDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bctDAL.selectALL(listbct)
    End Function

    Public Function selectAll_byMaBaoCaoTon(maBaoCao As Integer, ByRef listbct As List(Of BaoCaoTonDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bctDAL.selectALL_byMaBaoCao(maBaoCao, listbct)
    End Function

    Public Function selectAll_byThangBaoCao(thangBaoCao As DateTime, ByRef listbct As List(Of BaoCaoTonDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bctDAL.selectALL_byThangBaoCao(thangBaoCao, listbct)
    End Function

End Class
