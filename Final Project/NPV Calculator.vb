Option Explicit On
Option Strict On

Public Class NPV_Calculator

    Dim amount As Integer

    'Public Shared Function NPV(Rate As Double, ByRef ValueArray As Double()) As Double
    'End Function

    '' Define money format.
    'Dim MoneyFmt As String = "###,##0.00"
    '' Define percentage format.
    'Dim PercentFmt As String = "#0.00"


    '    ' Use the NPV function to calculate the net present value.
    '    ' Set fixed internal rate.
    '    Dim FixedRetRate As Double = 0.0625
    '    ' Calculate net present value.
    '    Dim NetPVal As Double = NPV(FixedRetRate, values)
    '' Display net present value.
    'MsgBox("The net present value of these cash flows is " & 
    '    Format(NetPVal, MoneyFmt) & ".")



    Private Sub NPV_Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCfQuantity.Text = CType(0, String)
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim EnteredCF As Double 'The Cashflow entered by the user 
        Dim CfAccumulator As Double = 0 'Accumulates the Cashflows after they are calculated

        amount = CInt(txtCfQuantity.Text)           'assigns the user input to amount (amount of cashflow periods)
        Dim Values(amount - 1) As Double            'amount variable input defines the array length, - 1 since vba counts 0

        For Each amount As Decimal In Values 'displays input message boxes = the quantity of cash flow periods

            EnteredCF = CDbl(InputBox("Enter The Cashflow for this period", "Cash Flow", "0"))

            CfAccumulator = CfAccumulator + CDbl(EnteredCF / (1 + (0.1) ^ Values.Length)) 'need to add array loop here to calculate denominator  
        Next
        MessageBox.Show(CfAccumulator.ToString)         'For test only 
    End Sub
End Class