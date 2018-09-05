Public Class easyGknowledge

    Dim answer As Byte
        Dim score As Integer

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "Alan Turing" Then answer = answer + 1
        If TextBox1.Text = "Alan Turing" Then Label6.Visible = True
        If TextBox1.Text = "alan turing" Then answer = answer + 1
        If TextBox1.Text = "alan turing" Then Label6.Visible = True
        If TextBox1.Text = "Alan turing" Then answer = answer + 1
        If TextBox1.Text = "Alan turing" Then Label6.Visible = True
        If TextBox1.Text = "alan Turing" Then answer = answer + 1
        If TextBox1.Text = "alan Turing" Then Label6.Visible = True

        If TextBox2.Text = "Victory" Then answer = answer + 1
        If TextBox2.Text = "Victory" Then Label7.Visible = True
        If TextBox2.Text = "victory" Then answer = answer + 1
        If TextBox2.Text = "victory" Then Label7.Visible = True

        If TextBox3.Text = "Joan Clarke" Then answer = answer + 1
        If TextBox3.Text = "Joan Clarke" Then Label8.Visible = True
        If TextBox3.Text = "joan clarke" Then answer = answer + 1
        If TextBox3.Text = "joan clarke" Then Label8.Visible = True
        If TextBox3.Text = "Joan Clarke" Then answer = answer + 1
        If TextBox3.Text = "Joan Clarke" Then Label8.Visible = True

        If TextBox4.Text = "Winston Churchill" Then answer = answer + 1
        If TextBox4.Text = "Winston Churchill" Then Label9.Visible = True
        If TextBox4.Text = "winston churchill" Then answer = answer + 1
        If TextBox4.Text = "winston churchill" Then Label9.Visible = True

        If TextBox5.Text = "Adolf Hitler" Then answer = answer + 1
        If TextBox5.Text = "Adolf Hitler" Then Label10.Visible = True
        If TextBox5.Text = "adolf hitler" Then answer = answer + 1
        If TextBox5.Text = "adolf hitler" Then Label10.Visible = True


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
