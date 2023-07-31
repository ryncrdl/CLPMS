Public Class PROPERTYMANAGEMENT
    Private Sub PROPERTYMANAGEMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged
        If MetroComboBox1.Text = "Available Properties" Then
            Guna2Button1.Visible = True
            Guna2Button3.Visible = True
            Guna2Button5.Visible = False
        ElseIf MetroComboBox1.Text = "Occupied Properties" Then
            Guna2Button1.Visible = False
            Guna2Button3.Visible = False
            Guna2Button5.Visible = True
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        PROPERTYMANAGEMENTADD.Show()
    End Sub

    Private Sub f_Click(sender As Object, e As EventArgs) Handles f.Click

    End Sub
End Class