Imports System.Data.SqlClient
Public Class Form7
    Public but As Integer = 0
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form3.Hide()
        Me.BackColor = Form3.BackColor()
        Me.Text = Form3.Label1.Text
        PictureBox1.BackgroundImage = Form3.BackgroundImage
        Label2.Text = Form3.Label2.Text
        Label4.Text = Form3.TextBox1.Text
        Label6.Text = (Form3.ds.Tables(0).Rows(Form3.watch).Item(6) * Val(Label4.Text)).ToString
        Label6.Text = StrReverse(Label6.Text)
        For i As Integer = 1 To Label6.Text.Length
            If i Mod 3 = 0 Then
                Label6.Text = Label6.Text.Insert(i, ",")
            End If
        Next
        Label6.Text = "₹ " + StrReverse(Label6.Text)
        Label8.Text = Form3.ds.Tables(0).Rows(Form3.watch).Item(7).ToString + " Years"
        Label10.Text = Form1.type.ToString + Form2.type.ToString + (Form3.watch + 1).ToString + Now.Year.ToString + Now.DayOfYear.ToString + Now.Hour.ToString + Now.Minute.ToString + Now.Second.ToString
        PictureBox1.BackgroundImage = Form3.PictureBox1.BackgroundImage
    End Sub
    Private Sub Form7_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If but = 2 Then
            Form3.Show()
        Else
            Form3.Close()
            Form1.Show()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source = BCALAB-39; Initial Catalog = master; Integrated Security = True")
        con.Open()
        Dim com As SqlCommand = New SqlCommand("insert into cust values ('" + Label10.Text + "', '" + TextBox1.Text + "', " + TextBox2.Text + ", " + Label4.Text + ", " + (Form3.ds.Tables(0).Rows(Form3.watch).Item(6) * Val(Label4.Text)).ToString + ", '" + Now.ToShortDateString + "', '" + Now.Date.AddYears(Form3.ds.Tables(0).Rows(Form3.watch).Item(7).ToString).ToShortDateString + "')", con)
        Dim dr = com.ExecuteReader()
        dr.Close()
        com = New SqlCommand("update watches set qty = " + (Form3.ds.Tables(0).Rows(Form3.watch).Item(5) - Val(Label4.Text)).ToString + " where gender = '" + Form2.ts + "' and company = '" + Form3.Text + "' and model = '" + Form3.Label1.Text + "'", con)
        dr = com.ExecuteReader()
        dr.Close()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from watches where gender = '" + Form2.ts + "' and company = '" + Form3.Text + "'", con)
        Form3.ds.Clear()
        da.Fill(Form3.ds)
        con.Close()
        MessageBox.Show("Successfully Bought", Me.Text, MessageBoxButtons.OK)
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        but = 2
        Me.Close()
    End Sub
End Class