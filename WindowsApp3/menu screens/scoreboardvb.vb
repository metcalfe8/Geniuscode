Public Class scoreboard
    Private Sub scoreboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub scoreboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Lblscore.Text = " Your Score is" + Score.ToString + " points"
    End Sub
End Class