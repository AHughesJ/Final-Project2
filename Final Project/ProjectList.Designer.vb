﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectList))
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
        Me.SavedProjectsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SavedProjectsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SavedProjectsDataSet = New Final_Project.SavedProjectsDataSet()
        Me.Tools = New System.Windows.Forms.ToolStrip()
        Me.btnAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblProject = New System.Windows.Forms.ToolStripLabel()
        Me.cboProjectName = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SavedProjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SavedProjectsTableAdapter = New Final_Project.SavedProjectsDataSetTableAdapters.SavedProjectsTableAdapter()
        CType(Me.dgvSavedProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SavedProjectsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SavedProjectsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SavedProjectsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tools.SuspendLayout()
        CType(Me.SavedProjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvSavedProjects.DataSource = Me.SavedProjectsBindingSource1
        Me.dgvSavedProjects.Location = New System.Drawing.Point(12, 39)
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
        'SavedProjectsBindingSource1
        '
        Me.SavedProjectsBindingSource1.DataMember = "SavedProjects"
        Me.SavedProjectsBindingSource1.DataSource = Me.SavedProjectsDataSetBindingSource
        '
        'SavedProjectsDataSetBindingSource
        '
        Me.SavedProjectsDataSetBindingSource.DataSource = Me.SavedProjectsDataSet
        Me.SavedProjectsDataSetBindingSource.Position = 0
        '
        'SavedProjectsDataSet
        '
        Me.SavedProjectsDataSet.DataSetName = "SavedProjectsDataSet"
        Me.SavedProjectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tools
        '
        Me.Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAll, Me.ToolStripSeparator1, Me.lblProject, Me.cboProjectName, Me.ToolStripSeparator2, Me.btnEdit, Me.btnClose, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripSeparator4})
        Me.Tools.Location = New System.Drawing.Point(0, 0)
        Me.Tools.Name = "Tools"
        Me.Tools.Size = New System.Drawing.Size(760, 25)
        Me.Tools.TabIndex = 5
        Me.Tools.Text = "ToolStrip1"
        '
        'btnAll
        '
        Me.btnAll.AutoSize = False
        Me.btnAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAll.Image = CType(resources.GetObject("btnAll.Image"), System.Drawing.Image)
        Me.btnAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(50, 22)
        Me.btnAll.Text = "All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'lblProject
        '
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(82, 22)
        Me.lblProject.Text = "Project Name:"
        '
        'cboProjectName
        '
        Me.cboProjectName.Name = "cboProjectName"
        Me.cboProjectName.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnEdit
        '
        Me.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(31, 22)
        Me.btnEdit.Text = "Edit"
        '
        'btnClose
        '
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 22)
        Me.btnClose.Text = "Close"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripButton1.Text = "Delete"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'SavedProjectsBindingSource
        '
        Me.SavedProjectsBindingSource.DataMember = "SavedProjects"
        Me.SavedProjectsBindingSource.DataSource = Me.SavedProjectsDataSet
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
        Me.Controls.Add(Me.Tools)
        Me.Controls.Add(Me.dgvSavedProjects)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "ProjectList"
        Me.Text = "ProjectList"
        CType(Me.dgvSavedProjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavedProjectsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavedProjectsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavedProjectsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tools.ResumeLayout(False)
        Me.Tools.PerformLayout()
        CType(Me.SavedProjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvSavedProjects As DataGridView
    Friend WithEvents SavedProjectsDataSet As SavedProjectsDataSet
    Friend WithEvents SavedProjectsBindingSource As BindingSource
    Friend WithEvents SavedProjectsTableAdapter As SavedProjectsDataSetTableAdapters.SavedProjectsTableAdapter
    Friend WithEvents Tools As ToolStrip
    Friend WithEvents btnAll As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblProject As ToolStripLabel
    Friend WithEvents cboProjectName As ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnEdit As ToolStripButton
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SavedProjectsDataSetBindingSource As BindingSource
    Friend WithEvents ProjectIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InitialCFODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CfPeriodsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NPVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SavedProjectsBindingSource1 As BindingSource
End Class
