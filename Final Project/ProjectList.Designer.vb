<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvSavedProjects = New System.Windows.Forms.DataGridView()
        Me.ProjectIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InitialCFODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CfPeriodsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SavedProjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SavedProjectsDataSet = New Final_Project.SavedProjectsDataSet()
        Me.SavedProjectsTableAdapter = New Final_Project.SavedProjectsDataSetTableAdapters.SavedProjectsTableAdapter()
        CType(Me.dgvSavedProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SavedProjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SavedProjectsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(136, 210)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Edit"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(354, 210)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgvSavedProjects
        '
        Me.dgvSavedProjects.AutoGenerateColumns = False
        Me.dgvSavedProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSavedProjects.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProjectIdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.InitialCFODataGridViewTextBoxColumn, Me.DiscountRateDataGridViewTextBoxColumn, Me.CfPeriodsDataGridViewTextBoxColumn, Me.NPVDataGridViewTextBoxColumn, Me.MDescriptionDataGridViewTextBoxColumn})
        Me.dgvSavedProjects.DataSource = Me.SavedProjectsBindingSource
        Me.dgvSavedProjects.Location = New System.Drawing.Point(12, 12)
        Me.dgvSavedProjects.Name = "dgvSavedProjects"
        Me.dgvSavedProjects.Size = New System.Drawing.Size(759, 164)
        Me.dgvSavedProjects.TabIndex = 3
        '
        'ProjectIdDataGridViewTextBoxColumn
        '
        Me.ProjectIdDataGridViewTextBoxColumn.DataPropertyName = "ProjectId"
        Me.ProjectIdDataGridViewTextBoxColumn.HeaderText = "ProjectId"
        Me.ProjectIdDataGridViewTextBoxColumn.Name = "ProjectIdDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'InitialCFODataGridViewTextBoxColumn
        '
        Me.InitialCFODataGridViewTextBoxColumn.DataPropertyName = "InitialCFO"
        Me.InitialCFODataGridViewTextBoxColumn.HeaderText = "InitialCFO"
        Me.InitialCFODataGridViewTextBoxColumn.Name = "InitialCFODataGridViewTextBoxColumn"
        '
        'DiscountRateDataGridViewTextBoxColumn
        '
        Me.DiscountRateDataGridViewTextBoxColumn.DataPropertyName = "DiscountRate"
        Me.DiscountRateDataGridViewTextBoxColumn.HeaderText = "DiscountRate"
        Me.DiscountRateDataGridViewTextBoxColumn.Name = "DiscountRateDataGridViewTextBoxColumn"
        '
        'CfPeriodsDataGridViewTextBoxColumn
        '
        Me.CfPeriodsDataGridViewTextBoxColumn.DataPropertyName = "CfPeriods"
        Me.CfPeriodsDataGridViewTextBoxColumn.HeaderText = "CfPeriods"
        Me.CfPeriodsDataGridViewTextBoxColumn.Name = "CfPeriodsDataGridViewTextBoxColumn"
        '
        'NPVDataGridViewTextBoxColumn
        '
        Me.NPVDataGridViewTextBoxColumn.DataPropertyName = "NPV"
        Me.NPVDataGridViewTextBoxColumn.HeaderText = "NPV"
        Me.NPVDataGridViewTextBoxColumn.Name = "NPVDataGridViewTextBoxColumn"
        '
        'MDescriptionDataGridViewTextBoxColumn
        '
        Me.MDescriptionDataGridViewTextBoxColumn.DataPropertyName = "mDescription"
        Me.MDescriptionDataGridViewTextBoxColumn.HeaderText = "mDescription"
        Me.MDescriptionDataGridViewTextBoxColumn.Name = "MDescriptionDataGridViewTextBoxColumn"
        '
        'SavedProjectsBindingSource
        '
        Me.SavedProjectsBindingSource.DataMember = "SavedProjects"
        Me.SavedProjectsBindingSource.DataSource = Me.SavedProjectsDataSet
        '
        'SavedProjectsDataSet
        '
        Me.SavedProjectsDataSet.DataSetName = "SavedProjectsDataSet"
        Me.SavedProjectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SavedProjectsTableAdapter
        '
        Me.SavedProjectsTableAdapter.ClearBeforeFill = True
        '
        'ProjectList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 261)
        Me.Controls.Add(Me.dgvSavedProjects)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "ProjectList"
        Me.Text = "ProjectList"
        CType(Me.dgvSavedProjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavedProjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavedProjectsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvSavedProjects As DataGridView
    Friend WithEvents SavedProjectsDataSet As SavedProjectsDataSet
    Friend WithEvents SavedProjectsBindingSource As BindingSource
    Friend WithEvents SavedProjectsTableAdapter As SavedProjectsDataSetTableAdapters.SavedProjectsTableAdapter
    Friend WithEvents ProjectIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InitialCFODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CfPeriodsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NPVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
