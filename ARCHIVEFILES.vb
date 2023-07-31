Public Class ARCHIVEFILES
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim yesno As DialogResult = MsgBox("Are you sure you want to recover?", vbYesNo + vbQuestion, "Admin")
        If (yesno = DialogResult.Yes) Then
            CONFIRMPASS.Show()
        End If
    End Sub
End Class