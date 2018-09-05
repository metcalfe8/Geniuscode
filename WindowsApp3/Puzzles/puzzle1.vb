Public Class puzzle1


    Dim answer As Byte
    Dim score As Integer


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "We" Then answer = answer + 1
        If TextBox1.Text = "We" Then Label6.Visible = True
        If TextBox1.Text = "we" Then answer = answer + 1
        If TextBox1.Text = "we" Then Label6.Visible = True
        If TextBox1.Text = "WE" Then answer = answer + 1
        If TextBox1.Text = "WE" Then Label6.Visible = True


        If TextBox2.Text = "Are" Then answer = answer + 1
        If TextBox2.Text = "Are" Then Label7.Visible = True
        If TextBox2.Text = "ARE" Then answer = answer + 1
        If TextBox2.Text = "ARE" Then Label7.Visible = True
        If TextBox2.Text = "are" Then answer = answer + 1
        If TextBox2.Text = "are" Then Label7.Visible = True


        If TextBox3.Text = "The" Then answer = answer + 1
        If TextBox3.Text = "The" Then Label8.Visible = True
        If TextBox3.Text = "the" Then answer = answer + 1
        If TextBox3.Text = "the" Then Label8.Visible = True
        If TextBox3.Text = "THE" Then answer = answer + 1
        If TextBox3.Text = "THE" Then Label8.Visible = True


        If TextBox4.Text = "Code" Then answer = answer + 1
        If TextBox4.Text = "Code" Then Label9.Visible = True
        If TextBox4.Text = "CODE" Then answer = answer + 1
        If TextBox4.Text = "CODE" Then Label9.Visible = True
        If TextBox4.Text = "code" Then answer = answer + 1
        If TextBox4.Text = "code" Then Label9.Visible = True

        If TextBox5.Text = "Breakers" Then answer = answer + 1
        If TextBox5.Text = "Breakers" Then Label10.Visible = True
        If TextBox5.Text = "BREAKERS" Then answer = answer + 1
        If TextBox5.Text = "BREAKERS" Then Label10.Visible = True
        If TextBox5.Text = "breakers" Then answer = answer + 1
        If TextBox5.Text = "breakers" Then Label10.Visible = True


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
