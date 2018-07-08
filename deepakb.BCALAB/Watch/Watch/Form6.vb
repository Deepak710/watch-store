Imports System.Data.SqlClient
Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form5.Close()
        Me.Text = Form3.Label1.Text
        Me.BackColor = Form3.BackColor
        Dim con As SqlConnection = New SqlConnection("Data Source = BCALAB-39; Initial Catalog = master; Integrated Security = True")
        con.Open()
        Dim com As SqlCommand = New SqlCommand("select count(bill_no) from cust where bill_no like '" + Form1.type.ToString + Form2.type.ToString + (Form3.watch + 1).ToString + "%'", con)
        Dim dr = com.ExecuteReader()
        dr.Read()
        Dim n As Integer = dr(0)
        dr.Close()
        If n = 0 Then
            MessageBox.Show(Form3.Label1.Text + " was never Bought", Me.Text, MessageBoxButtons.OK)
            Me.Close()
        End If
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from cust where bill_no like '" + Form1.type.ToString + Form2.type.ToString + (Form3.watch + 1).ToString + "%'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        con.Close()
        Dim tot As Long = 0
        Label8.Location = New Point(360, 95 + n * 15)
        Label9.Location = New Point(455, 95 + n * 15)
        Button1.Location = New Point(410, 125 + n * 15)
        Me.Size = New Size(900, 200 + n * 15)
        Dim pos() As Integer = {20, 155, 245, 385, 485, 605, 745}
        For lc As Integer = 0 To n - 1
            For i As Integer = 0 To 6
                Dim l As New Label With {
               .Location = New Point(pos(i), 75 + (lc * 15)),
               .AutoSize = True,
               .Font = New Font("Courier New", 11, FontStyle.Bold, FontStyle.Italic),
               .Text = ds.Tables(0).Rows(lc).Item(i)
                }
                If i = 4 Then
                    tot += Val(l.Text)
                    l.Text = StrReverse(l.Text)
                    For j As Integer = 1 To l.Text.Length
                        If j Mod 3 = 0 Then
                            l.Text = l.Text.Insert(j, ",")
                        End If
                    Next
                    l.Text = "₹ " + StrReverse(l.Text)
                ElseIf i = 6 Then
                    l.Text = (CDate(l.Text) - CDate(Now.ToShortDateString)).TotalDays.ToString + " Days"
                    If (CDate(ds.Tables(0).Rows(lc).Item(i)) - CDate(Now.ToShortDateString)).TotalDays < 0 Then
                        l.Text = "Warranty Void"
                    End If
                End If
                Me.Controls.Add(l)
            Next
        Next
        Label9.Text = StrReverse(tot.ToString)
        For i As Integer = 1 To Label9.Text.Length
            If i Mod 3 = 0 Then
                Label9.Text = Label9.Text.Insert(i, ",")
            End If
        Next
        Label9.Text = "₹ " + StrReverse(Label9.Text)
    End Sub
    Private Sub Form6_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Form3.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class