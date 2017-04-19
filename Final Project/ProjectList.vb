Option Explicit On
Option Strict On

Public Class ProjectList

    Private mProjects As New Project
    Private Formloading As Boolean = True

    Private Sub ProjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SavedProjectsDataSet.SavedProjects' table. You can move, or remove it, as needed.
        Me.SavedProjectsTableAdapter.Fill(Me.SavedProjectsDataSet.SavedProjects)

        With cboProjectName.ComboBox
            .DataSource = mProjects.AllProjects
            .DisplayMember = "Name"
            .ValueMember = "ProjectId"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = -1
        End With

        Formloading = False

    End Sub


    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        dgvSavedProjects.DataSource = mProjects.AllProjects     'Showing all data in the table
    End Sub

    Private Sub cboProjectName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProjectName.SelectedIndexChanged

        If Not Formloading Then                 'If the form isn't loading, then display when a new index is selected
            Dim ProjectID As Short = CShort(cboProjectName.ComboBox.SelectedValue)
            dgvSavedProjects.DataSource = mProjects.FindById(ProjectID)
        End If

    End Sub
End Class