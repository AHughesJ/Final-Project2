Option Explicit On
Option Strict On


'NEED TO CLEAR ALL VARIABLES AFTER EACH CALCULATION, THIS IS THROWING OFF CALCULATIONS WHEN MULTIPLE ARE RAN IN A SINGLE RUN

Public Class NPV_Calculator

    Dim amount As Integer
    Dim discountRate As Decimal
    Dim ProjectName As String

    Dim EnteredCF As Double 'The Cashflow entered by the user 
    Dim CfAccumulator As Double = 0.00 'Accumulates the Cashflows after they are calculated
    Dim expCounter As Integer = 1   'Exponent counter, each period the denominator is raised by +1
    Dim initialCFO As Double
    Dim decSelect As Integer = 2    'Base decimal place
    Dim projectId As Integer

    Dim ProjectDescription As String


    Public Sub Clear()
        lblStatus.Text = ""
        txtCfQuantity.Text = "0"
        txtDiscountRate.Text = "."
        txtProjectName.Text = ""
        txtInitialCashflow.Text = "-"
        cboDecimals.Items.Clear()
    End Sub


    Private Sub NPV_Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear()

        cboDecimals.Items.Add(1)       'Filling combo box
        cboDecimals.Items.Add(2)
        cboDecimals.Items.Add(3)
        cboDecimals.Items.Add(4)
        cboDecimals.Items.Add(5)
        cboDecimals.SelectedIndex = +1 'Displays to user that default decimal place is 2


    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        expCounter = 1 'Resetting the counter incase multiple calculations are ran in one setting
        CfAccumulator = 0.00

        If txtProjectName.Text = "" Then
            lblStatus.Text = "Insert a name for this project"
            txtProjectName.Focus()
            Return
        End If

        txtProjectName.Text = ProjectName

        If (Not Double.TryParse(txtInitialCashflow.Text, initialCFO)) Then
            lblStatus.Text = "Initial Cash Outflow is Invalid, insert a negative number"
            txtDiscountRate.Focus()
            Return
        End If

        If initialCFO > 0 Then
            lblStatus.Text = "Initial Cash Outflow should be negative"
            txtInitialCashflow.Focus()
            Return
        End If


        If (Not Decimal.TryParse(txtDiscountRate.Text, discountRate)) Then             'Validates Price input as a decimal
            lblStatus.Text = "Discount Rate is Invalid, insert rate between 0 and 1"
            txtDiscountRate.Focus()
            Return
        End If

        discountRate = CDec(txtDiscountRate.Text)

        If discountRate >= 1 Or discountRate < 0 Then
            lblStatus.Text = "Discount Rate is Invalid, insert rate between 0 and 1"
            txtDiscountRate.Focus()
            Return
        End If


        If (Not Integer.TryParse(txtCfQuantity.Text, amount)) Then             'Validates Cashflow quantity input as a integer
            lblStatus.Text = "Cash Flows input is invalid"
            txtCfQuantity.Focus()
            Return
        End If

        If amount <= 0 Then                                                     'Validates Cashflow quantity input as a positive integer
            lblStatus.Text = "You cannot have negative Cash Flow periods"
            txtCfQuantity.Focus()
            Return
        End If

        amount = CInt(txtCfQuantity.Text)           'assigns the user input to amount (amount of cashflow periods)


        Dim Values(amount - 1) As Double            'amount variable input defines the array length, - 1 since vba counts 0

        For Each amount As Decimal In Values 'displays input message boxes = the quantity of cash flow periods

            Try
                EnteredCF = CDbl(InputBox("Enter The Cashflow for this period", "Cash Flow", "0"))
            Catch ex As Exception
                Exit Sub
            End Try

            CfAccumulator = CfAccumulator + CDbl(EnteredCF / (1 + discountRate) ^ expCounter)

            expCounter = expCounter + 1 'Increase exponent by 1 for each period
        Next

        CfAccumulator = CfAccumulator + initialCFO           'adds the negative initital cashflow to the accumulated discounted future cashflows
        CfAccumulator = Math.Round(CfAccumulator, decSelect) 'Rounds to user specified decimal places
        lblStatus.Text = "The Net Present Value of this Project Is " & CfAccumulator.ToString()

        Dim result As Integer = MsgBox("Add a Project Description?", vbYesNo)

        If result = DialogResult.No Then
            ProjectDescription = " "
        ElseIf result = DialogResult.Yes Then
            ProjectDescription = InputBox("", "Add Your Project Description:")
        End If
    End Sub

    Private Sub cboDecimals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDecimals.SelectedIndexChanged
        decSelect = cboDecimals.SelectedIndex + 1 'Sets Decimal Places to users selected amount
    End Sub
End Class
