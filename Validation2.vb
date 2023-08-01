Imports MetroFramework.Controls
Imports CLPMS.Validation1
Module Validation2
    Public Function ValidateFieldsNotEmptyAdmin(data As List(Of MetroTextBox), ByRef validData As Boolean)
        ' Check if any of the fields are empty or null
        validData = True

        If String.IsNullOrEmpty(data(1).Text.Trim()) Then
            MessageBox.Show("Please enter your name.")
            validData = False
            Return False
        End If

        Dim ageValue As Integer
        If Not Integer.TryParse(data(2).Text, ageValue) Or ageValue <= 0 Then
            MessageBox.Show("Please enter a valid age.")
            validData = False
            Return False
        End If

        If String.IsNullOrEmpty(data(3).Text.Trim()) Then
            MessageBox.Show("Please enter your email.")
            validData = False
            Return False
        End If

        If (String.IsNullOrEmpty(data(4).Text.Trim())) Then
            MessageBox.Show("Please enter your contact number.")
            Return False
        End If

        If String.IsNullOrEmpty(data(5).Text.Trim()) Then
            MessageBox.Show("Please enter your address.")
            validData = False
            Return False
        End If

        If String.IsNullOrEmpty(data(6).Text.Trim()) Then
            MessageBox.Show("Please enter your username.")
            validData = False
            Return False
        End If

        If String.IsNullOrEmpty(data(7).Text.Trim()) Then
            MessageBox.Show("Please enter your password.")
            validData = False
            Return False
        End If
    End Function

    Public Function ValidatePropertyData(data As List(Of MetroTextBox), ByRef validData As Boolean)
        ' Check if any of the fields are empty or null
        validData = True

        Dim sq As Integer
        If Not Integer.TryParse(data(0).Text, sq) Or sq <= 0 Then
            MessageBox.Show("Please enter a valid square meter.")
            validData = False
            Return False
        End If

        If String.IsNullOrEmpty(data(1).Text.Trim()) Then
            MessageBox.Show("Please enter amenities.")
            validData = False
            Return False
        End If

        If String.IsNullOrEmpty(data(2).Text.Trim()) Then
            MessageBox.Show("Please enter description.")
            validData = False
            Return False
        End If

        If String.IsNullOrEmpty(data(3).Text.Trim()) Then
            MessageBox.Show("Please enter Permit.")
            validData = False
            Return False
        End If

    End Function

End Module
