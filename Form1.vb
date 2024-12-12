

Public Class Form1
    Implements ICalculator
    Public mathed = 0
    Private Sub BtnVal_Click(sender As Object, e As EventArgs) Handles BtnVal0.Click, BtnVal1.Click, BtnVal2.Click, BtnVal3.Click, BtnVal4.Click, BtnVal5.Click, BtnVal6.Click, BtnVal7.Click, BtnVal8.Click, BtnVal9.Click
        If mathed = 1 Then
            TextBox1.Text = ""
            mathed = 0
        ElseIf mathed = 0 Then
            Dim button As Button = CType(sender, Button)
            TextBox1.AppendText(button.Text)
        End If
    End Sub
    Private Sub BtnOperator_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim button As Button = CType(sender, Button)
        TextBox1.AppendText(" " & button.Text & " ")
    End Sub
    Private Sub BtnEquals_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Try
            Dim expression As String = TextBox1.Text
            Dim result As Double = EvaluateExpression(expression)
            TextBox1.Text = "The answer is: " & result
            mathed = 1

        Catch ex As Exception
            TextBox1.Text = "Error: " & ex.Message
        End Try
    End Sub
    Private Function EvaluateExpression(expression As String) As Double
        Dim dataTable As New DataTable()
        Dim result As Object = dataTable.Compute(expression, Nothing)
        Return Convert.ToDouble(result)
    End Function
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles Btn.Click
        TextBox1.Clear()
        mathed = 0
    End Sub
    Public Function Add(number1 As Double, number2 As Double) As Double Implements ICalculator.Add
        Return number1 + number2
    End Function

    Public Function Subtract(number1 As Double, number2 As Double) As Double Implements ICalculator.Subtract
        Return number1 - number2
    End Function

    Public Function Multiply(number1 As Double, number2 As Double) As Double Implements ICalculator.Multiply
        Return number1 * number2
    End Function

    Public Function Divide(number1 As Double, number2 As Double) As Double Implements ICalculator.Divide
        Return number1 / number2
    End Function

    Public Function Squared(number1 As Double) As Double Implements ICalculator.Squared
        Return number1 ^ 2
    End Function

    Public Function SquareRoot(number1 As Double) As Double Implements ICalculator.SquareRoot
        Return Math.Sqrt(number1)
    End Function

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.AppendText("*")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.AppendText("/")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.AppendText("-")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = ""
    End Sub
End Class
