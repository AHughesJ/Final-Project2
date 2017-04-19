Option Explicit On
Option Strict On

Public Class ProjectList

    Private mProjects As New Project
    Private Formloading As Boolean = True

    Private Sub ProjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SavedProjectsTableAdapter.Fill(Me.SavedProjects._SavedProjects)

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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvSavedProjects.SelectedRows.Count > 0 Then
            Dim ProjectId As Short = CShort(dgvSavedProjects.SelectedRows(0).Cells(0).Value)
            If mProjects.Delete(ProjectId) Then
                dgvSavedProjects.DataSource = mProjects.AllProjects
            Else
                MessageBox.Show("Unable to delete this project")
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If dgvSavedProjects.SelectedRows.Count > 0 Then
            Dim ProjectId As Short = CShort(dgvSavedProjects.SelectedRows(0).Cells(0).Value)
            Dim form As New ProjectEdit
            'form.ProjectId = ProjectId
            'frm.AppointmentId = apptId
            form.ShowDialog()
            dgvSavedProjects.DataSource = mProjects.AllProjects
        End If


    End Sub
End Class