Imports QLHS1DAL
Imports QLHS1DTO
Imports Utility

Public Class CTPhieuNhapBUS
    Private ctDAL As CTPhieuNhapDAL

    Public Sub New()
        ctDAL = New CTPhieuNhapDAL()
    End Sub

    Public Sub New(connectionString As String)
        ctDAL = New CTPhieuNhapDAL(connectionString)
    End Sub

    Public Function isValidMaPhieuNhap(phieuNhap As CTPhieuNhapDTO) As Boolean
        If (phieuNhap.MaPhieuNhap = "") Then
            Return False
        End If
        Return True
    End Function

    Public Function isValidSoLuongNhap(SLN As CTPhieuNhapDTO) As Boolean
        If (SLN.SoLuongNhap = "") Then
            Return False
        End If
        Return True
    End Function

    Public Function insert(ct As CTPhieuNhapDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctDAL.insert(ct)
    End Function

    Public Function update(ct As CTPhieuNhapDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctDAL.update(ct)
    End Function

    Public Function delete(mact As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctDAL.delete(mact)
    End Function

    Public Function selectAll(ByRef listCt As List(Of CTPhieuNhapDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctDAL.selectALL(listCt)
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return ctDAL.getNextID(nextID)
    End Function

    Public Function selectALL_ByType(maPhieuNhap As Integer, ByRef listCTPhieuNhap As List(Of CTPhieuNhapDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctDAL.selectALL_ByType(maPhieuNhap, listCTPhieuNhap)
    End Function

    'Public Function selectALL_ByMaPN(maPhieuNhap As Integer, ByRef listCTPhieuNhap As List(Of CTPhieuNhapDTO), ByRef listSach As List(Of SachDTO), ByRef listLoaiSach As List(Of LoaiSachDTO)) As Result
    '    '1. verify data here!!

    '    '2. insert to DB
    '    Return ctDAL.selectALL_ByMaPH(maPhieuNhap, listCTPhieuNhap, listSach, listLoaiSach )
    'End Function

End Class
