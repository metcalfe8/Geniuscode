Public Class Puzzle3

    Dim answer As Byte
    Dim score As Integer


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "Aaron" Then answer = answer + 1
        If TextBox1.Text = "Aaron" Then Label6.Visible = True
        If TextBox1.Text = "aaron" Then answer = answer + 1
        If TextBox1.Text = "aaron" Then Label6.Visible = True
        If TextBox1.Text = "AARON" Then answer = answer + 1
        If TextBox1.Text = "AARON" Then Label6.Visible = True


        If TextBox2.Text = "Swartz" Then answer = answer + 1
        If TextBox2.Text = "Swartz" Then Label7.Visible = True
        If TextBox2.Text = "swartz" Then answer = answer + 1
        If TextBox2.Text = "swartz" Then Label7.Visible = True
        If TextBox2.Text = "SWARTZ" Then answer = answer + 1
        If TextBox2.Text = "SWARTZ" Then Label7.Visible = True


        If TextBox3.Text = "Must" Then answer = answer + 1
        If TextBox3.Text = "Must" Then Label8.Visible = True
        If TextBox3.Text = "must" Then answer = answer + 1
        If TextBox3.Text = "must" Then Label8.Visible = True
        If TextBox3.Text = "MUST" Then answer = answer + 1
        If TextBox3.Text = "MUST" Then Label8.Visible = True




        If TextBox4.Text = "Be" Then answer = answer + 1
        If TextBox4.Text = "Be" Then Label10.Visible = True
        If TextBox4.Text = "BE" Then answer = answer + 1
        If TextBox4.Text = "BE" Then Label10.Visible = True
        If TextBox4.Text = "be" Then answer = answer + 1
        If TextBox4.Text = "be" Then Label10.Visible = True

        If TextBox5.Text = "Remembered" Then answer = answer + 1
        If TextBox5.Text = "Remembered" Then Label9.Visible = True
        If TextBox5.Text = "remembered" Then answer = answer + 1
        If TextBox5.Text = "remembered" Then Label9.Visible = True
        If TextBox5.Text = "REMEMBERED" Then answer = answer + 1
        If TextBox5.Text = "REMEBERED" Then Label9.Visible = True

        Question.Text = "you had " & answer & "Questions right"
        Percent.Text = "that is" & answer / 5 * 100 & "%"




    End Sub

    Private Sub mathquest5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False

    End Sub

    Private Sub Answer1_Click(sender As Object, e As EventArgs) Handles Answer1.Click
        answer = 0
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        Question.Text = ""
        Percent.Text = ""





    End Sub


End Class
