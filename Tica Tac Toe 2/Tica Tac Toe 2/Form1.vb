Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightYellow
        Button1.BackColor = Color.LightBlue
        Button2.BackColor = Color.LightBlue
        Label1.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ako As Integer
        ako = MessageBox.Show("Are You Sure You Want To Quit?", "Program Termination", MessageBoxButtons.YesNo)

        If ako = vbYes Then
            Me.Close()

        End If
        If ako = vbNo Then

        End If
    End Sub
End Class
