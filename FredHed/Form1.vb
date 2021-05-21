Public Class fredForm
    Dim fredTime As Integer
    Dim bestScore As Integer = 9001
    Dim fredString As String
    Private Sub fredBox_TextChanged(sender As Object, e As EventArgs) Handles fredBox.TextChanged
        Dim fredScore As String = fredLabel.Text
        fredString = fredBox.Text
        fredTimer.Interval = 1
        fredTimer.Start()
        Select Case fredString
            Case "fred"
                fredScoreLabel.Show()
                fredSpellLabel.Hide()
                fredTimer.Stop()
                fredBox.Text = ""
                If fredTime < bestScore Then
                    bestScoreLabel.Text = fredTime
                    bestScore = fredTime
                End If
                fredTime = "0"
                fredScoreLabel.Text = fredScore
                fredLabel.Text = "0"
            Case ""
                fredTimer.Stop()
            Case Else
                If fredString.Length = 4 Then
                    fredScoreLabel.Hide()
                    fredSpellLabel.Show()
                    fredBox.Clear()
                    fredTimer.Stop()
                    fredBox.Text = ""
                    fredTime = "0"
                    fredLabel.Text = "0"
                End If
        End Select
    End Sub
    Private Sub fredTimer_Tick(sender As Object, e As EventArgs) Handles fredTimer.Tick
        fredTime = fredTime + 1
        fredLabel.Text = fredTime
    End Sub
    Private Sub exitBut_Click(sender As Object, e As EventArgs) Handles exitBut.Click
        Me.Close()
    End Sub
    Private Sub fredBox_KeyDown(sender As Object, e As KeyEventArgs) Handles fredBox.KeyDown
        If e.Modifiers = Keys.Control Then
            e.Handled = True
            fredBox.Text = ""
            MsgBox("CHEATER!")
        End If
    End Sub
End Class
