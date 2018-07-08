Imports System.Data.SqlClient
Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form3.Hide()
        Form5.Close()
        Me.Text = "Add to " + Form2.Text + " " + Form3.Text + " Collection"
    End Sub
    Private Sub Form4_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Form3.n > 1 Then
            Form3.Show()
        Else
            Form3.Close()
            Form2.Show()
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        PictureBox1.BackgroundImage = Image.FromFile(TextBox2.Text)
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TextBox2.Text = OpenFileDialog1.FileName
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim loc As String = "C:\Users\deepakb.BCALAB\Desktop\Resources\" + Form2.ts + "\" + Form3.Text + "\" + TextBox1.Text + ".jpg"
        Dim img As New Bitmap(TextBox2.Text)
        img.Save(loc, Imaging.ImageFormat.Jpeg)
        Dim con As SqlConnection = New SqlConnection("Data Source = BCALAB-39; Initial Catalog = master; Integrated Security = True")
        con.Open()
        Dim com As SqlCommand = New SqlCommand("insert into watches values ('" + Form2.ts + "', '" + Form3.Text + "', '" + TextBox1.Text + "', " + (Form3.n + 1).ToString + ", '" + loc + "', " + TextBox3.Text + ", " + TextBox4.Text + ", " + TextBox5.Text + ")", con)
        Dim dr = com.ExecuteReader()
        dr.Close()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from watches where gender = '" + Form2.ts + "' and company = '" + Form3.Text + "'", con)
        Form3.ds.Clear()
        da.Fill(Form3.ds)
        con.Close()
        If MsgBox(TextBox1.Text + " Added to " + Form3.Text + " Collection", MsgBoxStyle.OkOnly, "Success") = MsgBoxResult.Ok Then
            Form3.n += 1
            Me.Close()
        End If
    End Sub
End Class