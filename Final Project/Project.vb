Option Strict On
Option Explicit On

Public Class Project

    Private Adapter As New SavedProjectsDataSetTableAdapters.SavedProjectsTableAdapter

    Public Shared Property LastError As String

    Public Function Insert(ByVal ProjectId As Short, ByVal Name As String,
                    ByVal InitialCFO As Decimal, ByVal DiscountRate As Decimal, ByVal CfPeriods As Integer,
                   ByVal NPV As Decimal, Optional ByVal Description As String = "") As Boolean
        Try
            LastError = String.Empty
            Adapter.Insert(ProjectId, Name, InitialCFO, DiscountRate, CfPeriods, NPV, Description)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function

    'Public Function Update(ByVal ProjectId As Short, ByVal Name As String,
    '               ByVal InitialCFO As Decimal, ByVal DiscountRate As Decimal, ByVal CfPeriods As Integer,
    '              ByVal NPV As Decimal, Optional ByVal Description As String = "") As Boolean
    '    Try
    '        LastError = String.Empty
    '        Adapter.Update(ProjectId, Name, InitialCFO, DiscountRate, CfPeriods, NPV, Description)
    '        Return True
    '    Catch ex As Exception
    '        LastError = ex.Message
    '        Return False
    '    End Try
    'End Function


End Class