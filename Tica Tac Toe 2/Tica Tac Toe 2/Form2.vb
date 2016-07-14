Public Class Form2

    Dim turn As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        turn = 1
        Me.BackColor = Color.LightYellow
        Button1.BackColor = Color.LightBlue
        Button2.BackColor = Color.LightBlue
        Button3.BackColor = Color.LightBlue
        Button4.BackColor = Color.LightBlue
        Button5.BackColor = Color.LightBlue
        Button6.BackColor = Color.LightBlue
        Button7.BackColor = Color.LightBlue
        Button8.BackColor = Color.LightBlue
        Button9.BackColor = Color.LightBlue
        Button10.BackColor = Color.LightBlue
    End Sub
    Private Sub win()
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()

        ElseIf Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()
        End If
    End Sub
    Private Sub disablebuttons()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False

    End Sub
End Class