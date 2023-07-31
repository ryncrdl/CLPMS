Public Class DASHBOARD
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With PROPERTYMANAGEMENT
            .TopLevel = False
            Panel2.Controls.Add(PROPERTYMANAGEMENT)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        With ADMINHOME
            .TopLevel = False
            Panel2.Controls.Add(ADMINHOME)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With LESSEE
            .TopLevel = False
            Panel2.Controls.Add(LESSEE)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With LESSORACCOUNT
            .TopLevel = False
            Panel2.Controls.Add(LESSORACCOUNT)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With MANAGERACCOUNT
            .TopLevel = False
            Panel2.Controls.Add(MANAGERACCOUNT)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim yesno As DialogResult = MsgBox("Are you sure you want to logout ?", vbYesNo + vbQuestion, "Admin")
        If (yesno = DialogResult.Yes) Then
            Me.Hide()
            LOGIN.Show()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With ADMINREGISISTRATION
            .TopLevel = False
            Panel2.Controls.Add(ADMINREGISISTRATION)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        With ARCHIVEFILES
            .TopLevel = False
            Panel2.Controls.Add(ARCHIVEFILES)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class