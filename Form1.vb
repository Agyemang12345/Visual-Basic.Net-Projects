Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        lblpercent.Text = ProgressBar1.Value & "%"

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If

        If ProgressBar1.Value = 10 Then
            lblProcessing.Text = "Loading..."
        End If

        If ProgressBar1.Value = 50 Then
            lblProcessing.Text = "Launching Database..."
        End If

        If ProgressBar1.Value = 100 Then
            lblProcessing.Text = "Done..."
            Form2.Show()
            Me.Hide()
        End If
    End Sub
End Class
