Imports MongoDB.Driver

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
            Try
                Dim username As String = TextBox1.Text
                Dim password As String = TextBox2.Text

                ' Retrieve the existing admin data from MongoDB
                Dim adminsCollection = Connection1.GetAdminsCollection()

                ' Build the filter to find the admin with the specified username and password
                Dim filter = Builders(Of ADMINREGISISTRATION.Admin).Filter.And(
                Builders(Of ADMINREGISISTRATION.Admin).Filter.Eq(Function(a) a.Username, username),
                Builders(Of ADMINREGISISTRATION.Admin).Filter.Eq(Function(a) a.Password, password)
            )

                ' Check if an admin with the given credentials exists
                Dim admin As ADMINREGISISTRATION.Admin = adminsCollection.Find(filter).FirstOrDefault()

                If admin IsNot Nothing Then
                    ' Successfully logged in
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    TextBox1.Clear()
                    TextBox2.Clear()
                    Me.Close()
                    DASHBOARD.Show()
                Else
                    ' Invalid credentials
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
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