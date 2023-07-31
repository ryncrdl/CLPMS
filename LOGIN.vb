Public Class LOGIN
    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text = "") Then
            MsgBox("Please enter your username")
            TextBox1.Focus()

        ElseIf (TextBox2.Text = "") Then
            MsgBox("Please enter your password")
            TextBox2.Focus()

        Else
            TextBox1.Clear()
            TextBox2.Clear()
            DASHBOARD.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim yesno As DialogResult = MsgBox("Are you sure you want to logout ?", vbYesNo + vbQuestion, "Admin")
        If (yesno = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            CheckBox1.Text = "Hide"
            TextBox2.UseSystemPasswordChar = False
        Else
            CheckBox1.Text = "Show"
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.UseSystemPasswordChar = True
    End Sub
End Class