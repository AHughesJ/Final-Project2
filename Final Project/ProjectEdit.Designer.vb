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
        Me.txtNPVprev = New System.Windows.Forms.TextBox()
        Me.lblPrevNPV = New System.Windows.Forms.Label()
        Me.txtPrevDescrip = New System.Windows.Forms.TextBox()
        Me.lblPreviousDescription = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(241, 295)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 36)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblProjectId
        '
        Me.lblProjectId.AutoSize = True
        Me.lblProjectId.Location = New System.Drawing.Point(58, 24)
        Me.lblProjectId.Name = "lblProjectId"
        Me.lblProjectId.Size = New System.Drawing.Size(57, 13)
        Me.lblProjectId.TabIndex = 27
        Me.lblProjectId.Text = "Project ID:"
        '
        'txtProjectId
        '
        Me.txtProjectId.Location = New System.Drawing.Point(129, 24)
        Me.txtProjectId.Name = "txtProjectId"
        Me.txtProjectId.Size = New System.Drawing.Size(100, 20)
        Me.txtProjectId.TabIndex = 26
        '
        'lblDes
        '
        Me.lblDes.AutoSize = True
        Me.lblDes.Location = New System.Drawing.Point(271, 8)
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
        Me.txtProjectName.Location = New System.Drawing.Point(129, 57)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(100, 20)
        Me.txtProjectName.TabIndex = 23
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.Location = New System.Drawing.Point(49, 57)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(74, 13)
        Me.lblProjectName.TabIndex = 22
        Me.lblProjectName.Text = "Project Name:"
        '
        'lblCFO
        '
        Me.lblCFO.AutoSize = True
        Me.lblCFO.Location = New System.Drawing.Point(45, 90)
        Me.lblCFO.Name = "lblCFO"
        Me.lblCFO.Size = New System.Drawing.Size(73, 13)
        Me.lblCFO.TabIndex = 21
        Me.lblCFO.Text = "Cash Outflow:"
        '
        'txtInitialCashflow
        '
        Me.txtInitialCashflow.Location = New System.Drawing.Point(129, 90)
        Me.txtInitialCashflow.Name = "txtInitialCashflow"
        Me.txtInitialCashflow.Size = New System.Drawing.Size(100, 20)
        Me.txtInitialCashflow.TabIndex = 20
        '
        'txtDiscountRate
        '
        Me.txtDiscountRate.Location = New System.Drawing.Point(129, 123)
        Me.txtDiscountRate.Name = "txtDiscountRate"
        Me.txtDiscountRate.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountRate.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Discount Rate:"
        '
        'lblCF
        '
        Me.lblCF.AutoSize = True
        Me.lblCF.Location = New System.Drawing.Point(62, 159)
        Me.lblCF.Name = "lblCF"
        Me.lblCF.Size = New System.Drawing.Size(61, 13)
        Me.lblCF.TabIndex = 18
        Me.lblCF.Text = "CF Periods:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(48, 295)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 36)
        Me.btnCalc.TabIndex = 16
        Me.btnCalc.Text = "Re - Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtCfQuantity
        '
        Me.txtCfQuantity.Location = New System.Drawing.Point(129, 156)
        Me.txtCfQuantity.Name = "txtCfQuantity"
        Me.txtCfQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtCfQuantity.TabIndex = 15
        '
        'txtNPVprev
        '
        Me.txtNPVprev.Location = New System.Drawing.Point(127, 188)
        Me.txtNPVprev.Name = "txtNPVprev"
        Me.txtNPVprev.Size = New System.Drawing.Size(100, 20)
        Me.txtNPVprev.TabIndex = 29
        '
        'lblPrevNPV
        '
        Me.lblPrevNPV.AutoSize = True
        Me.lblPrevNPV.Location = New System.Drawing.Point(45, 191)
        Me.lblPrevNPV.Name = "lblPrevNPV"
        Me.lblPrevNPV.Size = New System.Drawing.Size(76, 13)
        Me.lblPrevNPV.TabIndex = 30
        Me.lblPrevNPV.Text = "Previous NPV:"
        '
        'txtPrevDescrip
        '
        Me.txtPrevDescrip.Location = New System.Drawing.Point(127, 223)
        Me.txtPrevDescrip.Name = "txtPrevDescrip"
        Me.txtPrevDescrip.Size = New System.Drawing.Size(100, 20)
        Me.txtPrevDescrip.TabIndex = 31
        '
        'lblPreviousDescription
        '
        Me.lblPreviousDescription.AutoSize = True
        Me.lblPreviousDescription.Location = New System.Drawing.Point(16, 226)
        Me.lblPreviousDescription.Name = "lblPreviousDescription"
        Me.lblPreviousDescription.Size = New System.Drawing.Size(107, 13)
        Me.lblPreviousDescription.TabIndex = 32
        Me.lblPreviousDescription.Text = "Previous Description:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 353)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(380, 22)
        Me.StatusStrip1.TabIndex = 33
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ProjectEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 375)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblPreviousDescription)
        Me.Controls.Add(Me.txtPrevDescrip)
        Me.Controls.Add(Me.lblPrevNPV)
        Me.Controls.Add(Me.txtNPVprev)
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
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
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
    Friend WithEvents txtNPVprev As TextBox
    Friend WithEvents lblPrevNPV As Label
    Friend WithEvents txtPrevDescrip As TextBox
    Friend WithEvents lblPreviousDescription As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
