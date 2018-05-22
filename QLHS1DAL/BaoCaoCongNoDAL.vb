Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHS1DTO
Imports Utility

Public Class BaoCaoCongNoDAL
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
        query &= "SELECT TOP 1 [MABAOCAOCONGNO] "
        query &= "FROM [tblBaoCaoCongNo] "
        query &= "ORDER BY [MABAOCAOCONGNO] DESC "

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
                            idOnDB = reader("MABAOCAOCONGNO")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(bccn As BaoCaoCongNoDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblBaoCaoCongNo] ([MABAOCAOCONGNO], [ThangBaoCaoCongNo])"
        query &= "VALUES (@MABAOCAOCONGNO,@thangbaocao)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        bccn.MaBaoCaoCongNo = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MABAOCAOCONGNO", bccn.MaBaoCaoCongNo)
                    .Parameters.AddWithValue("@thangbaocao", bccn.ThangBaoCaoCongNo)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(bccn As BaoCaoCongNoDTO) As Result

        Dim query As String = String.Empty

        query &= " UPDATE [tblBaoCaoCongNo] SET"
        query &= " [ThangBaoCaoCongNo] = @thangbaocao "
        query &= "WHERE "
        query &= " [MABAOCAOCONGNO] = @MABAOCAOCONGNO "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MABAOCAOCONGNO", bccn.MaBaoCaoCongNo)
                    .Parameters.AddWithValue("@thangbaocao", bccn.ThangBaoCaoCongNo)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listBaoCaoCongNo As List(Of BaoCaoCongNoDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblBaoCaoCongNo]"


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
                            listBaoCaoCongNo.Add(New BaoCaoCongNoDTO(reader("MABAOCAOCONGNO"), reader("ThangBaoCaoCongNo")))
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

    Public Function selectALL_byMaBaoCao(maBaoCao As Integer, ByRef listBaoCaoCongNo As List(Of BaoCaoCongNoDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblBaoCaoCongNo]"
        query &= " WHERE "
        query &= " [MABAOCAOCONGNO] = @maBaoCao"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maBaoCao", maBaoCao)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listBaoCaoCongNo.Clear()
                        While reader.Read()
                            listBaoCaoCongNo.Add(New BaoCaoCongNoDTO(reader("MABAOCAOCONGNO"), reader("ThangBaoCaoCongNo")))
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

    Public Function selectALL_byThangBaoCao(thangBaoCao As Integer, ByRef listBaoCaoCongNo As List(Of BaoCaoCongNoDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblBaoCaoCongNo]"
        query &= " WHERE "
        query &= " month([ThangBaoCaoCongNo]) = @thang"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@thang", thangBaoCao)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listBaoCaoCongNo.Clear()
                        While reader.Read()
                            listBaoCaoCongNo.Add(New BaoCaoCongNoDTO(reader("MABAOCAOCONGNO"), reader("ThangBaoCaoCongNo")))
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

    Public Function delete(mabccn As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblBaoCaoCongNo] "
        query &= " WHERE "
        query &= " [MABAOCAOCONGNO] = @MABAOCAOCONGNO "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MABAOCAOCONGNO", mabccn)
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
