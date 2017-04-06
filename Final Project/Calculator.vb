'Option Explicit On
'Option Strict On

Public Class RegCalc

    Dim f As Double
    Dim s As Double
    Dim a As Double

    Dim Button As String


    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btnDec.Click
        'Adds buttons 1-9, . 
        Dim b As Button = sender
        If label1.Text = "0" Then
            label1.Text = b.Text
        Else
            label1.Text = label1.Text + b.Text
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        label1.Text = "0"
        Label3.Text = ""
    End Sub


    Private Sub btnMath_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click, btnPlus.Click, btnMinus.Click, btnDivide.Click, btnExp.Click

        Dim Buttons As Button = sender

        f = CDbl(label1.Text)

        Label3.Text = label1.Text

        label1.Text = ""

        Button = Buttons.Text

        Label3.Text = Label3.Text + " " + Button

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        s = label1.Text

        If Button = "+" Then
            a = f + s
            label1.Text = ""
            label1.Text = a
            Label3.Text = ""
        ElseIf Button = "-" Then
            a = f - s
            label1.Text = a
            Label3.Text = ""
        ElseIf Button = "/" Then
            a = f / s
            label1.Text = a
            Label3.Text = ""
        ElseIf Button = "*" Then
            a = f * s
            label1.Text = a
            Label3.Text = ""
        ElseIf Button = "^" Then
            a = f ^ s
            label1.Text = a
            Label3.Text = ""
        End If
    End Sub

    Private Sub FinancialCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinancialCalculatorToolStripMenuItem.Click
        NPV_Calculator.ShowDialog()

    End Sub
End Class
