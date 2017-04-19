Option Explicit On
Option Strict On

Public Class ProjectEdit

    Public Property ProjectId As Short

    Private mProject As New Project

    Private Sub ProjectEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ProjectId = 1

        Dim row As SavedProjects.SavedProjectsRow
        ' row = mProject.FindById(ProjectId)
        txtProjectId.Text = CType(row.ProjectId, String)



    End Sub
End Class