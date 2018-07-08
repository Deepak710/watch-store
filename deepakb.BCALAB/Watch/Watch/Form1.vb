Public Class Form1
    Public type As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form3.Close()
        Button1.BackgroundImage = Image.FromFile("C:\Users\deepakb.BCALAB\Desktop\Resources\Man.jpg")
        Button1.Text = "Men"
        Button1.BackColor = Color.RoyalBlue
        Button2.BackgroundImage = Image.FromFile("C:\Users\deepakb.BCALAB\Desktop\Resources\Woman.jpg")
        Button2.Text = "Women"
        Button2.BackColor = Color.HotPink
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        type = 1
        Form2.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        type = 2
        Form2.Show()
    End Sub
End Class