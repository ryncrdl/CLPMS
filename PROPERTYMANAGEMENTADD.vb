Imports CLPMS.ADMINREGISISTRATION
Imports Guna.UI2.WinForms
Imports MetroFramework.Controls
Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization.Attributes

Imports CLPMS.PROPERTYMANAGEMENT
Public Class PROPERTYMANAGEMENTADD
    'Private MetroTextBox As MetroFramework.Controls.MetroTextBox
    Private data As List(Of MetroTextBox)


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim validData As Boolean = True
        Validation2.ValidatePropertyData(data, validData)

        Try
            If (validData) Then
                Dim sq As Integer
                If Not Integer.TryParse(txtsq.Text, sq) Or sq <= 0 Then
                    MessageBox.Show("Please enter a valid square meter.", "Invalid Square Meter", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim amenities As String = txtamenities.Text
                    Dim description As String = txtdescription.Text
                    Dim permit As String = txtpermit.Text

                    Dim establishDate As Date
                    If Date.TryParse(txtdate.Text, establishDate) Then
                        Dim properties As New PropertyM With {
                    .SquareMeter = sq,
                    .Amenities = amenities,
                    .Description = description,
                    .Permit = permit,
                    .EstablishDate = establishDate
                }

                        Dim propertiesCollection = Connection1.GetPropertiesCollection()
                        propertiesCollection.InsertOne(properties)

                        MessageBox.Show("Property added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearTextBox(data)
                        Me.Close()
                        ' Refresh the DataGridView with the latest data
                        PROPERTYMANAGEMENT.Guna2DataGridView1.DataSource = PROPERTYMANAGEMENT.GetPropertiesData()
                    Else
                        MessageBox.Show("Please enter a valid date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        ClearTextBox(data)
    End Sub

    Private Sub PROPERTYMANAGEMENTADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New List(Of MetroTextBox) From {txtsq, txtamenities, txtdescription, txtpermit}
    End Sub
End Class