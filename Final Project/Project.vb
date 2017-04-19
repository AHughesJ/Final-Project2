Option Strict On
Option Explicit On

Public Class Project

    Private Adapter As New SavedProjectsDataSetTableAdapters.SavedProjectsTableAdapter

    Public Shared Property LastError As String


    Public ReadOnly Property AllProjects As DataTable
        Get
            Return Adapter.GetData                  'Returns all data in the table
        End Get
    End Property



    'Public Function Insert(ByVal ProjectId As Short, ByVal Name As String,
    '                ByVal InitialCFO As Decimal, ByVal DiscountRate As Decimal, ByVal CfPeriods As Integer,
    '               ByVal NPV As Decimal, Optional ByVal Description As String = "") As Boolean
    Public Function Insert(ByVal ProjectId As Short, ByVal Name As String,
                   ByVal InitialCFO As Decimal, ByVal DiscountRate As Decimal, ByVal CfPeriods As Integer,
                       ByVal NPV As Decimal, ByVal Description As String) As Boolean

        Try
            LastError = String.Empty
            Adapter.Insert(ProjectId, Name, InitialCFO, DiscountRate, CfPeriods, NPV, Description)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function

    Public Function FindById(ByVal ProjectId As Short) As DataTable
        Dim table As DataTable = Adapter.GetData()                  'Retrieves all rows from the table
        table.DefaultView.RowFilter = "ProjectId = " & ProjectId    'Filters the table to the Project ID
        Return table
    End Function

    'Public Function Update(ByVal Name As String,
    '           ByVal InitialCFO As Decimal, ByVal DiscountRate As Decimal, ByVal CfPeriods As Integer,
    '                  ByVal NPV As Decimal, ByVal Description As String, ByVal ProjectId As Short) As Boolean
    '    Try
    '        LastError = String.Empty
    '        Adapter.Update(Name, InitialCFO, DiscountRate, CfPeriods, NPV, Description, ProjectId)
    '        Return True
    '    Catch ex As Exception
    '        LastError = ex.Message
    '        Return False
    '    End Try
    'End Function

    'Public Function Delete(ByVal ProjectId As Short) As Boolean
    '    Dim rowsaffected As Integer = Adapter.Delete(ProjectId) 'calls the adapters delete query, using ProjectId
    '    Return rowsaffected > 0
    'End Function



End Class