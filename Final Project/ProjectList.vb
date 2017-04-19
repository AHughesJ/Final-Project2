Public Class ProjectList
    Private Sub ProjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SavedProjectsDataSet.SavedProjects' table. You can move, or remove it, as needed.
        Me.SavedProjectsTableAdapter.Fill(Me.SavedProjectsDataSet.SavedProjects)

    End Sub


End Class