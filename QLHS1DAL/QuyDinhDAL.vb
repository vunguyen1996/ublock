Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHS1DTO
Imports Utility

Public Class QuyDinhDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function update(qd As QuyDinhDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblQuyDinh] SET"
        query &= " [LuongNhapToiThieu] = @nhapmin"
        query &= " ,[LuongTonToiDa] = @tonmax"
        query &= " ,[TienNoToiDa] = @nomax"
        query &= " ,[LuongTonToiThieu] = @tonmin"
        query &= "WHERE "
        query &= " [ID] = @id "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@id", qd.ID)
                    .Parameters.AddWithValue("@nhapmin", qd.LuongNhapToiThieu)
                    .Parameters.AddWithValue("@tonmax", qd.LuongTonToiDa)
                    .Parameters.AddWithValue("@nomax", qd.TienNoToiDa)
                    .Parameters.AddWithValue("@tonmin", qd.LuongTonToiThieu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Quy Định không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef quydinh As List(Of QuyDinhDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblQuyDinh]"


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
                        quydinh.Clear()
                        While reader.Read()
                            quydinh.Add(New QuyDinhDTO(reader("ID"), reader("LuongNhapToithieu"), reader("LuongTonToiDa"), reader("TienNoToiDa"), reader("LuongTonToiThieu")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy Quy Định không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
