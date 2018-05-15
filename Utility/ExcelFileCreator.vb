'Imports System.Windows.Forms

'Module ExcelFileCreator
'    ''' <summary>
'    ''' Xuất dữ liệu từ DataGridView ra một tập tin Excel với đường dẫn đầy đủ tương ứng
'    ''' </summary>
'    ''' <param name="dataSource">DataGridView cần xuất dữ liệu</param>
'    ''' <param name="fileName">Đường dẫn đầy đủ của tập tin Excel</param>
'    ''' <param name="header">Nội dung của dòng đầu tiên trong tập tin Excel</param>
'    ''' <returns>0: Xuất tập tin thành công | 1: Xuất tập tin thất bại</returns>
'    Public Function ExportToExcel(ByVal dataSource As DataGridView, fileName As String, header As String)
'        Dim excelApp As New Microsoft.Office.Interop.Excel.Application
'        excelApp.Workbooks.Add(Type.Missing)
'        excelApp.Columns.ColumnWidth = 20
'        Try
'            excelApp.Cells(1, 1) = header

'            For i As Integer = 1 To dataSource.Columns.Count
'                excelApp.Cells(2, i) = dataSource.Columns(i - 1).HeaderText
'            Next

'            For i As Integer = 0 To dataSource.Rows.Count - 2
'                For j As Integer = 0 To dataSource.Columns.Count - 1
'                    excelApp.Cells(i + 3, j + 1) = dataSource.Rows(i).Cells(j).Value.ToString()
'                Next
'            Next

'            excelApp.ActiveWorkbook.SaveCopyAs(fileName.ToString())
'            excelApp.ActiveWorkbook.Saved = True
'            excelApp.Quit()
'        Catch ex As Exception
'            Return 1
'        End Try

'        Return 0
'    End Function

'    ''' <summary>
'    ''' Xuất dữ liệu từ DataTable ra một tập tin Excel với đường dẫn đầy đủ tương ứng
'    ''' </summary>
'    ''' <param name="dataSource">DataTable cần xuất dữ liệu</param>
'    ''' <param name="fileName">Đường dẫn đầy đủ của tập tin Excel</param>
'    ''' <param name="header">Nội dung của dòng đầu tiên trong tập tin Excel</param>
'    ''' <returns>0: Xuất tập tin thành công | 1: Xuất tập tin thất bại</returns>
'    Public Function ExportToExcel(ByVal dataSource As DataTable, fileName As String, header As String)
'        Dim excelApp As New Microsoft.Office.Interop.Excel.Application
'        excelApp.Workbooks.Add(Type.Missing)
'        excelApp.Columns.ColumnWidth = 20
'        Try
'            excelApp.Cells(1, 1) = header

'            For i As Integer = 1 To dataSource.Columns.Count
'                excelApp.Cells(2, i) = dataSource.Columns(i - 1).ColumnName
'            Next

'            For i As Integer = 0 To dataSource.Rows.Count - 1
'                For j As Integer = 0 To dataSource.Columns.Count - 1
'                    excelApp.Cells(i + 3, j + 1) = dataSource.Rows(i).Item(j).ToString()
'                Next
'            Next

'            excelApp.ActiveWorkbook.SaveCopyAs(fileName.ToString())
'            excelApp.ActiveWorkbook.Saved = True
'            excelApp.Quit()
'        Catch ex As Exception
'            Return 1
'        End Try
'        Return 0
'    End Function
'End Module


