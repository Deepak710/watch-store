Imports System.Data.SqlClient
Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form3.Hide()
        Me.Text = Form3.Label1.Text
        Button1.BackColor = Form3.BackColor
        BackColor = Form3.BackColor
        Label1.Text = "Enter Username"
        TextBox2.PasswordChar = "●"
        Label2.Text = "Enter Password"
    End Sub
    Private Sub Form5_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If (Form3.type <> 1 And Form3.type <> 5 And Form3.type <> 2) Or (Label1.Text = "Enter Username" And Label2.Text = "Enter Password") Then
            Dim con As SqlConnection = New SqlConnection("Data Source = BCALAB-39; Initial Catalog = master; Integrated Security = True")
            con.Open()
            Dim da As SqlDataAdapter = New SqlDataAdapter("select * from watches where gender = '" + Form2.ts + "' and company = '" + Form3.Text + "'", con)
            Form3.ds.Clear()
            da.Fill(Form3.ds)
            con.Close()
            Form3.TextBox1.Text = 0
            Form3.Label2.Text = Form3.ds.Tables(0).Rows(Form3.watch).Item(6).ToString
            Form3.Label2.Text = StrReverse(Form3.Label2.Text)
            For i As Integer = 1 To Form3.Label2.Text.Length
                If i Mod 3 = 0 Then
                    Form3.Label2.Text = Form3.Label2.Text.Insert(i, ",")
                End If
            Next
            Form3.Label2.Text = "₹ " + StrReverse(Form3.Label2.Text)
            Form3.Show()
        ElseIf Form3.type = 2 Then
            Form3.Close()
            Form2.Show()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Deepak Balaji" And TextBox2.Text = "DMB" And Label1.Text = "Enter Username" And Label2.Text = "Enter Password" Then
            If Form3.type = 1 Then
                Label1.Text = ""
                Label2.Text = ""
                Form4.BackColor = Me.BackColor
                Form4.Show()
            ElseIf Form3.type = 2 Then
                Label1.Text = ""
                Label2.Text = ""
                Dim con As SqlConnection = New SqlConnection("Data Source = BCALAB-39; Initial Catalog = master; Integrated Security = True")
                con.Open()
                Dim com As SqlCommand = New SqlCommand("delete from watches where gender = '" + Form2.ts + "' and company = '" + Form3.Text + "' and model = '" + Form3.Label1.Text + "'", con)
                com.ExecuteReader()
                con.Close()
                Me.Hide()
                MsgBox(Form3.Label1.Text + " Removed from " + Form3.Text + " Collection", MsgBoxStyle.OkOnly, "Success")
                Me.Close()
            ElseIf Form3.type = 3 Then
                Label1.Text = "Current Stock"
                Label2.Text = "New Stock"
                TextBox1.Text = Form3.ds.Tables(0).Rows(Form3.watch).Item(5).ToString
                TextBox2.PasswordChar = ""
                TextBox2.Text = ""
            ElseIf Form3.type = 4 Then
                Label1.Text = "Current Price"
                Label2.Text = "New Price"
                TextBox1.Text = Form3.ds.Tables(0).Rows(Form3.watch).Item(6).ToString
                TextBox2.PasswordChar = ""
                TextBox2.Text = ""
            ElseIf Form3.type = 5 Then
                Label1.Text = ""
                Label2.Text = ""
                Form6.BackColor = Me.BackColor
                Form6.Show()
            End If
        ElseIf Label1.Text = "Current Stock" And Label2.Text = "New Stock" Then
            Dim con As SqlConnection = New SqlConnection("Data Source = BCALAB-39; Initial Catalog = master; Integrated Security = True")
            con.Open()
            Dim com As SqlCommand = New SqlCommand("update watches set qty = " + TextBox2.Text + " where gender = '" + Form2.ts + "' and company = '" + Form3.Text + "' and model = '" + Form3.Label1.Text + "'", con)
            Dim dr = com.ExecuteReader()
            dr.Close()
            con.Close()
            If MsgBox(Form3.Label1.Text + "'s Stock Updated", MsgBoxStyle.OkOnly, "Success") = MsgBoxResult.Ok Then
                Me.Close()
            End If
        ElseIf Label1.Text = "Current Price" And Label2.Text = "New Price" Then
            Dim con As SqlConnection = New SqlConnection("Data Source = BCALAB-39; Initial Catalog = master; Integrated Security = True")
            con.Open()
            Dim com As SqlCommand = New SqlCommand("update watches set price = " + TextBox2.Text + " where gender = '" + Form2.ts + "' and company = '" + Form3.Text + "' and model = '" + Form3.Label1.Text + "'", con)
            Dim dr = com.ExecuteReader()
            dr.Close()
            con.Close()
            If MsgBox(Form3.Label1.Text + "'s Price Updated", MsgBoxStyle.OkOnly, "Success") = MsgBoxResult.Ok Then
                Me.Close()
            End If
        Else
            If MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) = DialogResult.Retry Then
                TextBox1.Text = ""
                TextBox2.Text = ""
                Me.Show()
            Else
                Me.Close()
            End If
        End If
    End Sub
End Class