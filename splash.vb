Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class splash
    Private fadeIn As Boolean = True
    Private fadeValue As Single = 0
    Private holdTime As Integer = 1000
    Private initialWaitTime As Integer = 1000
    Private initialWaitTimer As Timer

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 10
        AddHandler Timer1.Tick, AddressOf Timer1_Tick

        initialWaitTimer = New Timer()
        initialWaitTimer.Interval = initialWaitTime
        AddHandler initialWaitTimer.Tick, AddressOf InitialWaitTimer_Tick
        initialWaitTimer.Start()
        PictureBox1.Image = Image.FromFile("blackhat.png")
    End Sub

    Private Sub InitialWaitTimer_Tick(sender As Object, e As EventArgs)
        initialWaitTimer.Stop()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        If fadeIn Then
            fadeValue += 0.01F
            If fadeValue >= 1 Then
                fadeIn = False
                Timer1.Interval = holdTime
            End If
        Else
            Timer1.Interval = 10
            fadeValue -= 0.01F
            If fadeValue <= 0 Then
                Timer1.Stop()
                Dim form1 As New Form1()
                form1.Show()
                Me.Hide()
            End If
        End If
        PictureBox1.Invalidate()
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        If PictureBox1.Image IsNot Nothing Then

            e.Graphics.Clear(PictureBox1.BackColor)

            Dim attributes As New Imaging.ImageAttributes()
            Dim cm As New ColorMatrix() With {
                .Matrix33 = fadeValue
            }
            attributes.SetColorMatrix(cm, Imaging.ColorMatrixFlag.Default, Imaging.ColorAdjustType.Bitmap)

            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
            e.Graphics.DrawImage(PictureBox1.Image, New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height), 0, 0, PictureBox1.Image.Width, PictureBox1.Image.Height, GraphicsUnit.Pixel, attributes)
        End If
    End Sub

End Class
