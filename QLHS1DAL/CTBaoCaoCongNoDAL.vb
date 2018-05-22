Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHS1DTO
Imports Utility

Public Class CTBaoCaoCongNoDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MACTBAOCAOCONGNO] "
        query &= "FROM [tblCTBaoCaoCongNo] "
        query &= "ORDER BY [MACTBAOCAOCONGNO] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("MACTBAOCAOCONGNO")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của chi tiết báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function insert(ctbccn As CTBaoCaoCongNoDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblCTBaoCaoCongNo] ([MACTBAOCAOCONGNO],[MAKH],[MABAOCAOCONGNO],[SoTienNoDau],[SoTienPhatSinh],[SoTienNoCuoi])"
        query &= "VALUES (@mactbccn,@makh,@mabccn,@nodau,@phatsinh,@nocuoi)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        ctbccn.MaChiTietBaoCaoCongNo = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mactbccn", ctbccn.MaChiTietBaoCaoCongNo)
                    .Parameters.AddWithValue("@makh", ctbccn.MaKhachHang)
                    .Parameters.AddWithValue("@mabccn", ctbccn.MaBaoCaoCongNo)
                    .Parameters.AddWithValue("@nodau", ctbccn.SoTienNoDau)
                    .Parameters.AddWithValue("@phatsinh", ctbccn.SoTienPhatSinh)
                    .Parameters.AddWithValue("@nocuoi", ctbccn.SoTienNoCuoi)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm chi tiết báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(ctbccn As CTBaoCaoCongNoDTO) As Result

        Dim query As String = String.Empty

        query &= " UPDATE [tblCTBaoCaoCongNo] SET"
        query &= " [MAKH] = @makh"
        query &= " ,[MABAOCAOCONGNO] = @mabc"
        query &= " ,[SoTienNoDau] = @nodau"
        query &= " ,[SoTienPhatSinh] = @phatsinh"
        query &= " ,[SoTienNoCuoi] = @nocuoi"
        query &= " WHERE "
        query &= " [MACTBAOCAOCONGNO] = @mact "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mact", ctbccn.MaChiTietBaoCaoCongNo)
                    .Parameters.AddWithValue("@makh", ctbccn.MaKhachHang)
                    .Parameters.AddWithValue("@mabc", ctbccn.MaBaoCaoCongNo)
                    .Parameters.AddWithValue("@nodau", ctbccn.SoTienNoDau)
                    .Parameters.AddWithValue("@phatsinh", ctbccn.SoTienPhatSinh)
                    .Parameters.AddWithValue("@nocuoi", ctbccn.SoTienNoCuoi)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật báo chi tiết cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listBaoCaoCongNo As List(Of CTBaoCaoCongNoDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblCTBaoCaoCongNo]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listBaoCaoCongNo.Clear()
                        While reader.Read()
                            listBaoCaoCongNo.Add(New CTBaoCaoCongNoDTO(reader("MACTBAOCAOCONGNO"), reader("MAKH"), reader("MABAOCAOCONGNO"), reader("SoTienNoDau"), reader("SoTienPhatSinh"), reader("SoTienNoCuoi")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất danh sách báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_byMaBaoCao(maBaoCao As Integer, ByRef listCTBaoCaoCongNo As List(Of CTBaoCaoCongNoDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblCTBaoCaoCongNo]"
        query &= " WHERE [MABAOCAOCONGNO] = @mabc"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mabc", maBaoCao)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listCTBaoCaoCongNo.Clear()
                        While reader.Read()
                            listCTBaoCaoCongNo.Add(New CTBaoCaoCongNoDTO(reader("MACTBAOCAOCONGNO"), reader("MAKH"), reader("MABAOCAOCONGNO"), reader("SoTienNoDau"), reader("SoTienPhatSinh"), reader("SoTienNoCuoi")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất danh sách báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(mactbccn As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblCTBaoCaoCongNo] "
        query &= " WHERE "
        query &= " [MACTBAOCAOCONGNO] = @mact"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mact", mactbccn)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
