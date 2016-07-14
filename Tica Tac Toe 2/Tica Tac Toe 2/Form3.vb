Public Class Form3

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.BackColor = Color.LightYellow
        Timer1.Start()
        ProgressBar1.Value = ProgressBar1.Value + 1
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Close()
            Form2.Show()
        End If
    End Sub

    Private Sub ProgressBar1_Move(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Move
        Timer1.Start()

    End Sub
End Class