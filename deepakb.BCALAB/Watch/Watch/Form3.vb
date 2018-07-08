Imports System.Data.SqlClient
Public Class Form3
    Public type As Integer = 0
    Public watch = 0
    Public ds As New DataSet
    Public n As Integer = 0
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Hide()
        Form7.Close()
        Dim con As SqlConnection = New SqlConnection("Data Source = BCALAB-39; Initial Catalog = master; Integrated Security = True")
        con.Open()
        Dim com As SqlCommand = New SqlCommand("select count(model) from watches where gender = '" + Form2.ts + "' and company = '" + Me.Text + "'", con)
        Dim dr = com.ExecuteReader()
        dr.Read()
        n = dr(0)
        dr.Close()
        TextBox1.Text = 0
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from watches where gender = '" + Form2.ts + "' and company = '" + Me.Text + "'", con)
        da.Fill(ds)
        If n <> 0 Then
            Label1.Text = ds.Tables(0).Rows(watch).Item(2)
            PictureBox1.BackgroundImage = Image.FromFile(ds.Tables(0).Rows(watch).Item(4))
            Label2.Text = ds.Tables(0).Rows(watch).Item(6).ToString
            Label2.Text = StrReverse(Label2.Text)
            For i As Integer = 1 To Label2.Text.Length
                If i Mod 3 = 0 Then
                    Label2.Text = Label2.Text.Insert(i, ",")
                End If
            Next
            Label2.Text = "₹ " + StrReverse(Label2.Text)
        End If
        con.Close()
    End Sub
    Private Sub Form3_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If type <> 23 Then
            Form2.Show()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) > 1 Then
            TextBox1.Text = Val(TextBox1.Text) - 1
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Val(TextBox1.Text) < ds.Tables(0).Rows(watch).Item(5).ToString Then
            TextBox1.Text = Val(TextBox1.Text) + 1
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Val(TextBox1.Text) > 0 Then
            type = 23
            Form7.Show()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        type = 24
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        watch -= 1
        If watch = -1 Then
            watch = n - 1
        End If
        If n <> 0 Then
            Label1.Text = ds.Tables(0).Rows(watch).Item(2)
            PictureBox1.BackgroundImage = Image.FromFile(ds.Tables(0).Rows(watch).Item(4))
            Label2.Text = ds.Tables(0).Rows(watch).Item(6).ToString
            Label2.Text = StrReverse(Label2.Text)
            If Val(TextBox1.Text) > ds.Tables(0).Rows(watch).Item(5) Then
                TextBox1.Text = ds.Tables(0).Rows(watch).Item(5)
            End If
            For i As Integer = 1 To Label2.Text.Length
                If i Mod 3 = 0 Then
                    Label2.Text = Label2.Text.Insert(i, ",")
                End If
            Next
            Label2.Text = "₹ " + StrReverse(Label2.Text)
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If watch = n - 1 Then
            watch = -1
        End If
        watch += 1
        If n <> 0 Then
            Label1.Text = ds.Tables(0).Rows(watch).Item(2)
            PictureBox1.BackgroundImage = Image.FromFile(ds.Tables(0).Rows(watch).Item(4))
            Label2.Text = ds.Tables(0).Rows(watch).Item(6).ToString
            Label2.Text = StrReverse(Label2.Text)
            If Val(TextBox1.Text) > ds.Tables(0).Rows(watch).Item(5) Then
                TextBox1.Text = ds.Tables(0).Rows(watch).Item(5)
            End If
            For i As Integer = 1 To Label2.Text.Length
                If i Mod 3 = 0 Then
                    Label2.Text = Label2.Text.Insert(i, ",")
                End If
            Next
            Label2.Text = "₹ " + StrReverse(Label2.Text)
        End If
    End Sub
    Private Sub AddWatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddWatchToolStripMenuItem.Click
        type = 1
        Form5.Show()
    End Sub
    Private Sub RemoveWatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveWatchToolStripMenuItem.Click
        type = 2
        Form5.Show()
    End Sub
    Private Sub ChangeStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeStockToolStripMenuItem.Click
        type = 3
        Form5.Show()
    End Sub
    Private Sub ChangePriceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePriceToolStripMenuItem.Click
        type = 4
        Form5.Show()
    End Sub
    Private Sub ViewHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHistoryToolStripMenuItem.Click
        type = 5
        Form5.Show()
    End Sub
End Class