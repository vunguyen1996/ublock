Imports System.Configuration
Imports System.Data.SqlClient
Imports System
Imports Utility
Imports QLHS1DTO

Public Class CTHoaDonDAL
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
        query &= "SELECT TOP 1 [MActhd] "
        query &= "FROM [tblCTHoaDon] "
        query &= "ORDER BY [MACTHD] DESC "

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
                            idOnDB = reader("MACTHD")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(cthd As CTHoaDonDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblCTHoaDon] ([MACTHD], [MAHD], [MASACH], [SoLuongBan], [DonGiaBan], [ThanhTien])"
        query &= "VALUES (@macthd, @mahd, @masach, @soluongban, @dongia, @thanhtien)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        cthd.MaChiTietHD = nextID
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@macthd", cthd.MaChiTietHD)
                    .Parameters.AddWithValue("@mahd", cthd.MaHD)
                    .Parameters.AddWithValue("@masach", cthd.MaSach)
                    .Parameters.AddWithValue("@soluongban", cthd.SoLuongBan)
                    .Parameters.AddWithValue("@dongia", cthd.DonGia)
                    .Parameters.AddWithValue("@thanhtien", cthd.ThanhTien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm chi tiết hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(cthd As CTHoaDonDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblCTHoaDon] SET [MAHD] = @mahd, [MASACH] = @masach, [SoLuongBan] = @soluongban, [DonGiaBan] = @dongia, [ThanhTien] = @thanhtien"
        query &= " WHERE "
        query &= " [MACTHD] = @macthd "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@macthd", cthd.MaChiTietHD)
                    .Parameters.AddWithValue("@mahd", cthd.MaHD)
                    .Parameters.AddWithValue("@masach", cthd.MaSach)
                    .Parameters.AddWithValue("@soluongban", cthd.SoLuongBan)
                    .Parameters.AddWithValue("@dongia", cthd.DonGia)
                    .Parameters.AddWithValue("@thanhtien", cthd.ThanhTien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật phiếu hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listHoaDon As List(Of CTHoaDonDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblCTHoaDon]"


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
                        listHoaDon.Clear()
                        While reader.Read()
                            listHoaDon.Add(New CTHoaDonDTO(reader("MACTHD"), reader("MAHD"), reader("MASACH"), reader("SoLuongBan"), reader("DonGiaBan"), reader("ThanhTien")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_byMaHD(maHD As Integer, ByRef listHoaDon As List(Of CTHoaDonDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblCTHoaDon]"
        query &= "WHERE [MAHD] = @mahd"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mahd", maHD)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listHoaDon.Clear()
                        While reader.Read()
                            listHoaDon.Add(New CTHoaDonDTO(reader("MACTHD"), reader("MAHD"), reader("MASACH"), reader("SoLuongBan"), reader("DonGiaBan"), reader("ThanhTien")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(macthd As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblCTHoaDon] "
        query &= " WHERE "
        query &= " [MACTHD] = @macthd "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@macthd", macthd)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
