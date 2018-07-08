Imports System.Data.SqlClient
Public Class Form2
    Public type As Integer = 0
    Public ts As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        Form5.Close()
        Dim con As SqlConnection = New SqlConnection("Data Source = BCALAB-39; Initial Catalog = master; Integrated Security = True")
        con.Open()
        Dim com As SqlCommand
        If (Form1.type = 1) Then
            ts = Form1.Button1.Text
            Me.BackColor = Form1.Button1.BackColor
        ElseIf (Form1.type = 2) Then
            ts = Form1.Button2.Text
            Me.BackColor = Form1.Button2.BackColor
        End If
        Me.Text = ts + "'s Watches"
        com = New SqlCommand("select * from com where type = '" + ts + "'", con)
        Dim dr = com.ExecuteReader
        dr.Read()
        Button1.ForeColor = Me.BackColor
        Button1.Text = dr(0).ToString
        Button1.BackgroundImage = Image.FromFile(dr(1).ToString)
        dr.Read()
        Button2.ForeColor = Me.BackColor
        Button2.Text = dr(0).ToString
        Button2.BackgroundImage = Image.FromFile(dr(1).ToString)
        dr.Read()
        Button3.ForeColor = Me.BackColor
        Button3.Text = dr(0).ToString
        Button3.BackgroundImage = Image.FromFile(dr(1).ToString)
        dr.Read()
        Button4.ForeColor = Me.BackColor
        Button4.Text = dr(0).ToString
        Button4.BackgroundImage = Image.FromFile(dr(1).ToString)
        dr.Read()
        Button5.ForeColor = Me.BackColor
        Button5.Text = dr(0).ToString
        Button5.BackgroundImage = Image.FromFile(dr(1).ToString)
        dr.Read()
        Button6.ForeColor = Me.BackColor
        Button6.Text = dr(0).ToString
        Button6.BackgroundImage = Image.FromFile(dr(1).ToString)
        con.Close()
    End Sub
    Private Sub Form2_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Form1.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        type = 1
        Form3.BackColor = Me.BackColor
        Form3.Text = Button1.Text
        Form3.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        type = 2
        Form3.BackColor = Me.BackColor
        Form3.Text = Button2.Text
        Form3.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        type = 3
        Form3.BackColor = Me.BackColor
        Form3.Text = Button3.Text
        Form3.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        type = 4
        Form3.BackColor = Me.BackColor
        Form3.Text = Button4.Text
        Form3.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        type = 5
        Form3.BackColor = Me.BackColor
        Form3.Text = Button5.Text
        Form3.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        type = 6
        Form3.BackColor = Me.BackColor
        Form3.Text = Button6.Text
        Form3.Show()
    End Sub
End Class