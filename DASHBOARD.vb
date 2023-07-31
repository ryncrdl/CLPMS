Public Class DASHBOARD
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SwitchingPanels.SwitchPanel(Panel2, PROPERTYMANAGEMENT)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SwitchingPanels.SwitchPanel(Panel2, ADMINHOME)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SwitchingPanels.SwitchPanel(Panel2, LESSEE)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SwitchingPanels.SwitchPanel(Panel2, LESSORACCOUNT)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SwitchingPanels.SwitchPanel(Panel2, MANAGERACCOUNT)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SwitchingPanels.SwitchPanel(Panel2, ADMINREGISISTRATION)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SwitchingPanels.SwitchPanel(Panel2, ARCHIVEFILES)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim yesno As DialogResult = MsgBox("Are you sure you want to logout ?", vbYesNo + vbQuestion, "Admin")
        If (yesno = DialogResult.Yes) Then
            Me.Hide()
            LOGIN.Show()
        End If
    End Sub
End Class