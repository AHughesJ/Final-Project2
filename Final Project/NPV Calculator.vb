Option Explicit On
Option Strict On



Public Class NPV_Calculator

    Dim amount As Integer
    Dim discountRate As Decimal

    Public Sub Clear()
        lblStatus.Text = ""
        txtCfQuantity.Text = "0"
        txtDiscountRate.Text = "."
    End Sub


    Private Sub NPV_Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim EnteredCF As Double 'The Cashflow entered by the user 
        Dim CfAccumulator As Double = 0.00 'Accumulates the Cashflows after they are calculated
        Dim expCounter As Integer = 1   'Exponent counter, each period the denominator is raised by +1



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

        If (Not Integer.TryParse(txtCfQuantity.Text, amount)) Then             'Validates Price input as a decimal
            lblStatus.Text = "Cash Flows input is invalid"
            txtCfQuantity.Focus()
            Return
        End If

        If amount <= 0 Then
            lblStatus.Text = "Must input at least 1 cashflow"
            txtCfQuantity.Focus()
            Return
        End If



         amount = CInt(txtCfQuantity.Text)           'assigns the user input to amount (amount of cashflow periods)


        Dim Values(amount - 1) As Double            'amount variable input defines the array length, - 1 since vba counts 0

        For Each amount As Decimal In Values 'displays input message boxes = the quantity of cash flow periods

            EnteredCF = CDbl(InputBox("Enter The Cashflow for this period", "Cash Flow", "0"))

            CfAccumulator = CfAccumulator + CDbl(EnteredCF / (1 + discountRate) ^ expCounter) 'need to add array loop here to calculate denominator 

            expCounter = expCounter + 1 'Increase exponent by 1 for each period
        Next

        lblStatus.Text = "The Net Present Value of this Project Is" & CfAccumulator
    End Sub
End Class
