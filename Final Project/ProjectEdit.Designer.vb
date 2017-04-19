<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectEdit
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblProjectId = New System.Windows.Forms.Label()
        Me.txtProjectId = New System.Windows.Forms.TextBox()
        Me.lblDes = New System.Windows.Forms.Label()
        Me.cboDecimals = New System.Windows.Forms.ComboBox()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.lblCFO = New System.Windows.Forms.Label()
        Me.txtInitialCashflow = New System.Windows.Forms.TextBox()
        Me.txtDiscountRate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCF = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtCfQuantity = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(241, 216)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 36)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblProjectId
        '
        Me.lblProjectId.AutoSize = True
        Me.lblProjectId.Location = New System.Drawing.Point(25, 42)
        Me.lblProjectId.Name = "lblProjectId"
        Me.lblProjectId.Size = New System.Drawing.Size(57, 13)
        Me.lblProjectId.TabIndex = 27
        Me.lblProjectId.Text = "Project ID:"
        '
        'txtProjectId
        '
        Me.txtProjectId.Location = New System.Drawing.Point(137, 42)
        Me.txtProjectId.Name = "txtProjectId"
        Me.txtProjectId.Size = New System.Drawing.Size(100, 20)
        Me.txtProjectId.TabIndex = 26
        '
        'lblDes
        '
        Me.lblDes.AutoSize = True
        Me.lblDes.Location = New System.Drawing.Point(279, 26)
        Me.lblDes.Name = "lblDes"
        Me.lblDes.Size = New System.Drawing.Size(80, 13)
        Me.lblDes.TabIndex = 25
        Me.lblDes.Text = "Decimal Places"
        '
        'cboDecimals
        '
        Me.cboDecimals.FormattingEnabled = True
        Me.cboDecimals.Location = New System.Drawing.Point(296, 42)
        Me.cboDecimals.Name = "cboDecimals"
        Me.cboDecimals.Size = New System.Drawing.Size(45, 21)
        Me.cboDecimals.TabIndex = 24
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(137, 75)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(100, 20)
        Me.txtProjectName.TabIndex = 23
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.Location = New System.Drawing.Point(25, 75)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(74, 13)
        Me.lblProjectName.TabIndex = 22
        Me.lblProjectName.Text = "Project Name:"
        '
        'lblCFO
        '
        Me.lblCFO.AutoSize = True
        Me.lblCFO.Location = New System.Drawing.Point(25, 108)
        Me.lblCFO.Name = "lblCFO"
        Me.lblCFO.Size = New System.Drawing.Size(99, 13)
        Me.lblCFO.TabIndex = 21
        Me.lblCFO.Text = "Insert Cash Outflow"
        '
        'txtInitialCashflow
        '
        Me.txtInitialCashflow.Location = New System.Drawing.Point(137, 108)
        Me.txtInitialCashflow.Name = "txtInitialCashflow"
        Me.txtInitialCashflow.Size = New System.Drawing.Size(100, 20)
        Me.txtInitialCashflow.TabIndex = 20
        '
        'txtDiscountRate
        '
        Me.txtDiscountRate.Location = New System.Drawing.Point(137, 141)
        Me.txtDiscountRate.Name = "txtDiscountRate"
        Me.txtDiscountRate.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountRate.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Insert Discount Rate:"
        '
        'lblCF
        '
        Me.lblCF.AutoSize = True
        Me.lblCF.Location = New System.Drawing.Point(25, 177)
        Me.lblCF.Name = "lblCF"
        Me.lblCF.Size = New System.Drawing.Size(90, 13)
        Me.lblCF.TabIndex = 18
        Me.lblCF.Text = "Insert CF Periods:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(47, 216)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 36)
        Me.btnCalc.TabIndex = 16
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtCfQuantity
        '
        Me.txtCfQuantity.Location = New System.Drawing.Point(137, 174)
        Me.txtCfQuantity.Name = "txtCfQuantity"
        Me.txtCfQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtCfQuantity.TabIndex = 15
        '
        'ProjectEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 298)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblProjectId)
        Me.Controls.Add(Me.txtProjectId)
        Me.Controls.Add(Me.lblDes)
        Me.Controls.Add(Me.cboDecimals)
        Me.Controls.Add(Me.txtProjectName)
        Me.Controls.Add(Me.lblProjectName)
        Me.Controls.Add(Me.lblCFO)
        Me.Controls.Add(Me.txtInitialCashflow)
        Me.Controls.Add(Me.txtDiscountRate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCF)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtCfQuantity)
        Me.Name = "ProjectEdit"
        Me.Text = "ProjectEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents lblProjectId As Label
    Friend WithEvents txtProjectId As TextBox
    Friend WithEvents lblDes As Label
    Friend WithEvents cboDecimals As ComboBox
    Friend WithEvents txtProjectName As TextBox
    Friend WithEvents lblProjectName As Label
    Friend WithEvents lblCFO As Label
    Friend WithEvents txtInitialCashflow As TextBox
    Friend WithEvents txtDiscountRate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCF As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents txtCfQuantity As TextBox
End Class
