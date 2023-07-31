Imports MetroFramework.Controls
Imports Guna.UI2.WinForms
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Web.UI.WebControls

Module Validation1
    Private MetroTextBox As MetroFramework.Controls.MetroTextBox
    Private DataGridView As Guna.UI2.WinForms.Guna2DataGridView

    Public Function ViewDataToTextBox(table As DataGridView, data As List(Of MetroTextBox), columnsName As List(Of String))
        ' Check if there is a selected row
        If table.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = table.SelectedRows(0)

            For i As Integer = 0 To columnsName.Count - 1
                data(i).Text = selectedRow.Cells(columnsName(i)).Value.ToString()
            Next

        Else
            ' Clear the TextBoxes/MetroTextBoxes if no row is selected
            ClearTextBox(data)
        End If
    End Function


    Public Function ValidateFieldsNotEmpty(data As List(Of MetroTextBox))
        ' Check if any of the fields are empty or null
        If String.IsNullOrEmpty(data(1).Text.Trim()) Then
            MessageBox.Show("Please enter your name.")
            Return False
        End If

        Dim ageValue As Integer
        If Not Integer.TryParse(data(2).Text, ageValue) Or ageValue <= 0 Then
            MessageBox.Show("Please enter a valid age.")
            Return False
        End If

        If String.IsNullOrEmpty(data(3).Text.Trim()) Then
            MessageBox.Show("Please enter your email.")
            Return False
        End If

        If (String.IsNullOrEmpty(data(4).Text.Trim())) Then
            MessageBox.Show("Please enter your contact number.")
            Return False
        ElseIf Not Integer.TryParse(data(4).Text, ageValue) Then
            MessageBox.Show("Please enter valid contact number.")
            Return False
        End If

        If String.IsNullOrEmpty(data(5).Text.Trim()) Then
            MessageBox.Show("Please enter your address.")
            Return False
        End If


        If String.IsNullOrEmpty(data(6).Text.Trim()) Then
            MessageBox.Show("Please enter your business name.")

            Return False
        End If

        If String.IsNullOrEmpty(data(7).Text.Trim()) Then
            MessageBox.Show("Please enter your username.")
            Return False
        End If

        If String.IsNullOrEmpty(data(8).Text.Trim()) Then
            MessageBox.Show("Please enter your password.")
            Return False
        End If

        ClearTextBox(data)
        MessageBox.Show("Successfully added but saving data are under development!")

    End Function

    Public Function ClearTextBox(data As List(Of MetroTextBox))
        For Each d As MetroTextBox In data
            If d IsNot Nothing Then
                d.Text = String.Empty
            End If
        Next
    End Function

    Public Function DeleteData(txtid As MetroTextBox, data As List(Of MetroTextBox))
        If (String.IsNullOrEmpty(txtid.Text)) Then
            MessageBox.Show("Select row to delete data")

        Else
            ClearTextBox(data)
            MessageBox.Show("Successfully deleted but saving data are under development!")

        End If
    End Function

End Module
