Public Class Form1
    Implements ICalculator

    Private Sub BtnVal_Click(sender As Object, e As EventArgs) Handles BtnVal0.Click, BtnVal1.Click, BtnVal2.Click, BtnVal3.Click, BtnVal4.Click, BtnVal5.Click, BtnVal6.Click, BtnVal7.Click, BtnVal8.Click, BtnVal9.Click
        Dim button As Button = CType(sender, Button)
        TextBox1.AppendText(button.Text)
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
        Catch ex As Exception
            TextBox1.Text = "Error: " & ex.Message
        End Try
    End Sub

    Private Function EvaluateExpression(expression As String) As Double
        While expression.Contains("^")
            Dim index As Integer = expression.IndexOf("^")
            Dim baseNumber As String = ExtractNumberBeforeOperator(expression, index)
            Dim exponent As String = ExtractNumberAfterOperator(expression, index)
            Dim powerValue As Double = Math.Pow(Convert.ToDouble(baseNumber), Convert.ToDouble(exponent))
            expression = expression.Replace($"{baseNumber}^{exponent}", powerValue.ToString())
        End While

        While expression.Contains("√")
            Dim index As Integer = expression.IndexOf("√")
            Dim number As String = ExtractNumberAfterSqrt(expression, index)
            Dim sqrtValue As Double = Math.Sqrt(Convert.ToDouble(number))
            expression = expression.Replace($"√{number}", sqrtValue.ToString())
        End While

        Dim dataTable As New DataTable()
        Dim result As Object = dataTable.Compute(expression, Nothing)
        Return Convert.ToDouble(result)
    End Function

    Private Function ExtractNumberBeforeOperator(expression As String, index As Integer) As String
        Dim number As String = ""
        For i = index - 1 To 0 Step -1
            If Char.IsDigit(expression(i)) OrElse expression(i) = "." Then
                number = expression(i) & number
            Else
                Exit For
            End If
        Next
        Return number
    End Function

    Private Function ExtractNumberAfterOperator(expression As String, index As Integer) As String
        Dim number As String = ""
        For i = index + 1 To expression.Length - 1
            If Char.IsDigit(expression(i)) OrElse expression(i) = "." Then
                number &= expression(i)
            Else
                Exit For
            End If
        Next
        Return number
    End Function

    Private Function ExtractNumberAfterSqrt(expression As String, index As Integer) As String
        Dim startIndex As Integer = index + 1
        Dim number As String = ""
        For i = startIndex To expression.Length - 1
            If Char.IsDigit(expression(i)) OrElse expression(i) = "." Then
                number &= expression(i)
            Else
                Exit For
            End If
        Next
        Return number
    End Function

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles Btn.Click
        TextBox1.Clear()
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
        If number2 = 0 Then Throw New DivideByZeroException("Cannot divide by zero")
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

    Private Sub BtnSqrt_Click(sender As Object, e As EventArgs) Handles BtnSqrt.Click
        TextBox1.AppendText("√")
    End Sub
>>>>>>>>> Temporary merge branch 2
End Class
