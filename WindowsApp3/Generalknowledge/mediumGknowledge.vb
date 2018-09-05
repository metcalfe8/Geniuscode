Public Class mediumGknowledge

    Dim answer As Byte
        Dim score As Integer


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "02/09/1945" Then answer = answer + 1
        If TextBox1.Text = "02/09/1945" Then Label6.Visible = True
        If TextBox1.Text = "1945" Then answer = answer + 1
        If TextBox1.Text = "1945" Then Label6.Visible = True


        If TextBox2.Text = "Bletchley park" Then answer = answer + 1
        If TextBox2.Text = "Bletchley park" Then Label7.Visible = True
        If TextBox2.Text = "Bletchley Park" Then answer = answer + 1
        If TextBox2.Text = "Bletchley Park" Then Label7.Visible = True
        If TextBox2.Text = "bletchley park" Then answer = answer + 1
        If TextBox2.Text = "bletchley park" Then Label7.Visible = True


        If TextBox3.Text = "Enigma" Then answer = answer + 1
        If TextBox3.Text = "Enigma" Then Label8.Visible = True
        If TextBox3.Text = "enigma" Then answer = answer + 1
        If TextBox3.Text = "enigma" Then Label8.Visible = True


        If TextBox4.Text = "Apple" Then answer = answer + 1
        If TextBox4.Text = "Apple" Then Label9.Visible = True
        If TextBox4.Text = "apple" Then answer = answer + 1
        If TextBox4.Text = "apple" Then Label9.Visible = True

        If TextBox5.Text = "Bill Gates" Then answer = answer + 1
        If TextBox5.Text = "Bill Gates" Then Label10.Visible = True
        If TextBox5.Text = "bill gates" Then answer = answer + 1
        If TextBox5.Text = "bill gates" Then Label10.Visible = True
        If TextBox5.Text = "Bill gates" Then answer = answer + 1
        If TextBox5.Text = "Bill gates" Then Label10.Visible = True


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
