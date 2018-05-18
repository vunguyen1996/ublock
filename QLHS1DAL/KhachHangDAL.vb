Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHS1DTO
Imports Utility
Imports System

Public Class KhachHangDAL
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
        query &= "SELECT TOP 1 [MAKH] "
        query &= "FROM [tblKhachHang] "
        query &= "ORDER BY [MAKH] DESC "

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
                            idOnDB = reader("MAKH")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(kh As KhachHangDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblKhachHang] ([MAKH],[HoTenKH],[TienNoKH],[DiaChi],[Email],[SDT])"
        query &= "VALUES (@makh,@hotenkh,@tienno,@diachi,@email,@sdt)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        kh.MaKH = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@makh", kh.MaKH)
                    .Parameters.AddWithValue("@hotenkh", kh.TenKhachHang)
                    .Parameters.AddWithValue("@tienno", kh.TienNoKH)
                    .Parameters.AddWithValue("@diachi", kh.DiaChiKH)
                    .Parameters.AddWithValue("@email", kh.Email)
                    .Parameters.AddWithValue("@sdt", kh.SDT)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(kh As KhachHangDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblKhachHang] SET"
        query &= " [HoTenKH] = @hotenkh "
        query &= " ,[TienNoKH] = @tienno "
        query &= " ,[DiaChi] = @diachi "
        query &= " ,[Email] = @email "
        query &= " ,[SDT] = @sdt "
        query &= "WHERE "
        query &= " [MAKH] = @makh "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@makh", kh.MaKH)
                    .Parameters.AddWithValue("@hotenkh", kh.TenKhachHang)
                    .Parameters.AddWithValue("@tienno", kh.TienNoKH)
                    .Parameters.AddWithValue("@diachi", kh.DiaChiKH)
                    .Parameters.AddWithValue("@email", kh.Email)
                    .Parameters.AddWithValue("@sdt", kh.SDT)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listKH As List(Of KhachHangDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblKhachHang]"

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
                        listKH.Clear()
                        While reader.Read()
                            listKH.Add(New KhachHangDTO(reader("MAKH"), reader("HoTenKH"), reader("TienNoKH"), reader("DiaChi"), reader("Email"), reader("SDT")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByType(makh As Integer, ByRef listkh As List(Of KhachHangDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT * "
        query &= "FROM [tblKhachHang] "
        query &= "WHERE [MAKH] = @makh "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@makh", makh)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listkh.Clear()
                        While reader.Read()
                            listkh.Add(New KhachHangDTO(reader("MAKH"), reader("HoTenKH"), reader("TienNoKH"), reader("DiaChi"), reader("Email"), reader("SDT")))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy khách hàng theo mã khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByName(name As String, ByRef listkh As List(Of KhachHangDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblKhachHang]"
        query &= " WHERE "
        query &= " [HoTenKH] = @hoten "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@hoten", name)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listkh.Clear()
                        While reader.Read()
                            listkh.Add(New KhachHangDTO(reader("MAKH"), reader("HoTenKH"), reader("TienNoKH"), reader("DiaChi"), reader("Email"), reader("SDT")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(makh As Integer) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [tblKhachHang] "
        query &= " WHERE "
        query &= " [MAKH] = @makh "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@makh", makh)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
