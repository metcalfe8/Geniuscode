﻿Public Class Logiceasy

    Dim answer As Byte
        Dim score As Integer


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "bob" Then answer = answer + 1
        If TextBox1.Text = "bob" Then Label6.Visible = True
        If TextBox1.Text = "Bob" Then answer = answer + 1
        If TextBox1.Text = "Bob" Then Label6.Visible = True
        If TextBox2.Text = "2" Then answer = answer + 1
        If TextBox2.Text = "2" Then Label7.Visible = True
        If TextBox3.Text = "4" Then answer = answer + 1
        If TextBox3.Text = "4" Then Label8.Visible = True
        If TextBox4.Text = "B" Then answer = answer + 1
        If TextBox4.Text = "B" Then Label9.Visible = True
        If TextBox4.Text = "b" Then answer = answer + 1
        If TextBox4.Text = "b" Then Label9.Visible = True
        If TextBox4.Text = "Bee" Then answer = answer + 1
        If TextBox4.Text = "Bee" Then Label9.Visible = True
        If TextBox4.Text = "bee" Then answer = answer + 1
        If TextBox4.Text = "bee" Then Label9.Visible = True
        If TextBox5.Text = "1" Then answer = answer + 1
        If TextBox5.Text = "1" Then Label10.Visible = True

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
