
Public Class Form1
    Implements ICalculator

    Private Sub BtnVal0_Click(sender As Object, e As EventArgs) Handles BtnVal0.Click
        TextBox1.AppendText("0")

    End Sub

    Private Sub BtnVal1_Click(sender As Object, e As EventArgs) Handles BtnVal1.Click
        TextBox1.AppendText("1")
    End Sub

    Private Sub BtnVal2_Click(sender As Object, e As EventArgs) Handles BtnVal2.Click
        TextBox1.AppendText("2")
    End Sub

    Private Sub BtnVal3_Click(sender As Object, e As EventArgs) Handles BtnVal3.Click
        TextBox1.AppendText("3")
    End Sub

    Private Sub BtnVal4_Click(sender As Object, e As EventArgs) Handles BtnVal4.Click
        TextBox1.AppendText("4")
    End Sub

    Private Sub BtnVal5_Click(sender As Object, e As EventArgs) Handles BtnVal5.Click
        TextBox1.AppendText("5")
    End Sub

    Private Sub BtnVal6_Click(sender As Object, e As EventArgs) Handles BtnVal6.Click
        TextBox1.AppendText("6")
    End Sub

    Private Sub BtnVal7_Click(sender As Object, e As EventArgs) Handles BtnVal7.Click
        TextBox1.AppendText("7")
    End Sub

    Private Sub BtnVal8_Click(sender As Object, e As EventArgs) Handles BtnVal8.Click
        TextBox1.AppendText("8")
    End Sub

    Private Sub BtnVal9_Click(sender As Object, e As EventArgs) Handles BtnVal9.Click
        TextBox1.AppendText("9")
    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        TextBox1.AppendText("")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = "The answer is: " & Add(number1:=, number2:=)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.AppendText("+")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.AppendText("")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.AppendText("")
    End Sub

    Public Function Add(number1 As Double, number2 As Double) As Double Implements ICalculator.Add
        Return number1 + number2
    End Function

    Public Function Divide(number1 As Double, number2 As Double) As Double Implements ICalculator.Divide
        Return number1 / number2
    End Function

    Public Function Multiply(number1 As Double, number2 As Double) As Double Implements ICalculator.Multiply
        Return number1 * number2
    End Function

    Public Function Squared(number1 As Double) As Double Implements ICalculator.Squared
        Return number1 ^ 2
    End Function

    Public Function SquareRoot(number1 As Double) As Double Implements ICalculator.SquareRoot
        Return Math.Sqrt(number1)
    End Function

    Public Function Subtract(number1 As Double, number2 As Double) As Double Implements ICalculator.Subtract
        Throw New NotImplementedException()
    End Function
    Private Function DoSomeMath(num1 As Integer, operator1 As String, num2 As Integer) As String
        Dim result1 As Double
        Select Case operator1
            Case "+"
                result1 = num1 + num2
            Case "-"
                result1 = num1 - num2
            Case "*"
                result1 = num1 * num2
            Case "/"
                result1 = num1 / num2
            Case Else
                Return "Invalid operator"
        End Select
        Return $"{num1} {operator1} {num2} = {result1}"
    End Function

    Private Function DoSomeMath(num1 As Integer, operator1 As String, num2 As Integer, operator2 As String, num3 As Integer) As String
        Dim result1 As Double
        Select Case operator1
            Case "+"
                result1 = num1 + num2
            Case "-"
                result1 = num1 - num2
            Case "*"
                result1 = num1 * num2
            Case "/"
                result1 = num1 / num2
            Case Else
                Return "Invalid operator"
        End Select

        Dim result2 As Double
        Select Case operator2
            Case "+"
                result2 = result1 + num3
            Case "-"
                result2 = result1 - num3
            Case "*"
                result2 = result1 * num3
            Case "/"
                result2 = result1 / num3
            Case Else
                Return "Invalid operator"
        End Select

        Return $"{num1} {operator1} {num2} {operator2} {num3} = {result2}"
    End Function

    Private Function DoSomeMath(num1 As Integer, operator1 As String, num2 As Integer, operator2 As String, num3 As Integer, operator3 As String, num4 As Integer) As String
        Dim result1 As Double
        Select Case operator1
            Case "+"
                result1 = num1 + num2
            Case "-"
                result1 = num1 - num2
            Case "*"
                result1 = num1 * num2
            Case "/"
                result1 = num1 / num2
            Case Else
                Return "Invalid operator"
        End Select

        Dim result2 As Double
        Select Case operator2
            Case "+"
                result2 = result1 + num3
            Case "-"
                result2 = result1 - num3
            Case "*"
                result2 = result1 * num3
            Case "/"
                result2 = result1 / num3
            Case Else
                Return "Invalid operator"
        End Select

        Dim result3 As Double
        Select Case operator3
            Case "+"
                result3 = result2 + num4
            Case "-"
                result3 = result2 - num4
            Case "*"
                result3 = result2 * num4
            Case "/"
                result3 = result2 / num4
            Case Else
                Return "Invalid operator"
        End Select

        Return $"{num1} {operator1} {num2} {operator2} {num3} {operator3} {num4} = {result3}"
    End Function
End Class
