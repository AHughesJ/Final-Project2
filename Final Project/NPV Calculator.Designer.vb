<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NPV_Calculator
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
        Me.txtCfQuantity = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblCF = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiscountRate = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProjectListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtInitialCashflow = New System.Windows.Forms.TextBox()
        Me.lblCFO = New System.Windows.Forms.Label()
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCfQuantity
        '
        Me.txtCfQuantity.Location = New System.Drawing.Point(124, 159)
        Me.txtCfQuantity.Name = "txtCfQuantity"
        Me.txtCfQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtCfQuantity.TabIndex = 0
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(124, 198)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 36)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblCF
        '
        Me.lblCF.AutoSize = True
        Me.lblCF.Location = New System.Drawing.Point(12, 162)
        Me.lblCF.Name = "lblCF"
        Me.lblCF.Size = New System.Drawing.Size(90, 13)
        Me.lblCF.TabIndex = 2
        Me.lblCF.Text = "Insert CF Periods:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Insert Discount Rate:"
        '
        'txtDiscountRate
        '
        Me.txtDiscountRate.Location = New System.Drawing.Point(125, 124)
        Me.txtDiscountRate.Name = "txtDiscountRate"
        Me.txtDiscountRate.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountRate.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectListToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(315, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProjectListToolStripMenuItem
        '
        Me.ProjectListToolStripMenuItem.Name = "ProjectListToolStripMenuItem"
        Me.ProjectListToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ProjectListToolStripMenuItem.Text = "Project List"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 256)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(315, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'txtInitialCashflow
        '
        Me.txtInitialCashflow.Location = New System.Drawing.Point(124, 88)
        Me.txtInitialCashflow.Name = "txtInitialCashflow"
        Me.txtInitialCashflow.Size = New System.Drawing.Size(100, 20)
        Me.txtInitialCashflow.TabIndex = 6
        '
        'lblCFO
        '
        Me.lblCFO.AutoSize = True
        Me.lblCFO.Location = New System.Drawing.Point(12, 91)
        Me.lblCFO.Name = "lblCFO"
        Me.lblCFO.Size = New System.Drawing.Size(99, 13)
        Me.lblCFO.TabIndex = 7
        Me.lblCFO.Text = "Insert Cash Outflow"
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.Location = New System.Drawing.Point(12, 51)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(74, 13)
        Me.lblProjectName.TabIndex = 8
        Me.lblProjectName.Text = "Project Name:"
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(124, 48)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(100, 20)
        Me.txtProjectName.TabIndex = 9
        '
        'NPV_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 278)
        Me.Controls.Add(Me.txtProjectName)
        Me.Controls.Add(Me.lblProjectName)
        Me.Controls.Add(Me.lblCFO)
        Me.Controls.Add(Me.txtInitialCashflow)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtDiscountRate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCF)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtCfQuantity)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "NPV_Calculator"
        Me.Text = "NPV_Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCfQuantity As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblCF As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDiscountRate As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProjectListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents txtInitialCashflow As TextBox
    Friend WithEvents lblCFO As Label
    Friend WithEvents lblProjectName As Label
    Friend WithEvents txtProjectName As TextBox
End Class
