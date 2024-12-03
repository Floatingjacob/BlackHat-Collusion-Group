
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
        TextBox1.Text = ("The answer is: " & Add("1", "6"))
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
        Throw New NotImplementedException()
    End Function

    Public Function Divide(number1 As Double, number2 As Double) As Double Implements ICalculator.Divide
        Throw New NotImplementedException()
    End Function

    Public Function Multiply(number1 As Double, number2 As Double) As Double Implements ICalculator.Multiply
        Throw New NotImplementedException()
    End Function

    Public Function Squared(number1 As Double) As Double Implements ICalculator.Squared
        Throw New NotImplementedException()
    End Function

    Public Function SquareRoot(number1 As Double) As Double Implements ICalculator.SquareRoot
        Throw New NotImplementedException()
    End Function

    Public Function Subtract(number1 As Double, number2 As Double) As Double Implements ICalculator.Subtract
        Throw New NotImplementedException()
    End Function
End Class
