Imports System.Web.UI.WebControls
Imports MetroFramework.Controls
Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization.Attributes
Imports MongoDB.Bson.Serialization
Imports MongoDB.Driver

Public Class ADMINREGISISTRATION
    'Private MetroTextBox As MetroFramework.Controls.MetroTextBox
    Private DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Private data As List(Of MetroTextBox)
    Private columnsName As List(Of String)

    Private ReadOnly _database As IMongoDatabase

    Public Sub New()
        InitializeComponent()
        _database = Connection1.GetMongoDatabase()
        'columnsName = New List(Of String) From {"ID", "Name", "Age", "Email", "Contact", "Address", "Username", "Password"}
        ' If Connection1.IsConnected() Then
        'MessageBox.Show("Connected to MongoDB successfully!", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Else
        'MessageBox.Show("Failed to connect to MongoDB.", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
    End Sub

    Public Class Admin
        <BsonId>
        <BsonRepresentation(BsonType.ObjectId)>
        Public Property ID As String
        Public Property Name As String
        Public Property Age As Integer
        Public Property Email As String
        Public Property Contact As String
        Public Property Address As String
        Public Property Username As String
        Public Property Password As String
    End Class


    Private Sub ADMINREGISISTRATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New List(Of MetroTextBox) From {txtid, txtname, txtage, txtemail, txtcontact, txtaddress, txtusername, txtpassword}

        Guna2DataGridView1.DataSource = GetAdminsData()

    End Sub


    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearTextBox(data)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim validData As Boolean = True
        ValidateFieldsNotEmptyAdmin(data, validData)
        Try

            If (validData) Then
                Dim age As Integer
                Integer.TryParse(txtage.Text, age)
                Dim admin As New Admin With {
                    .Name = txtname.Text,
                    .Age = age,
                    .Email = txtemail.Text,
                    .Contact = txtcontact.Text,
                    .Address = txtaddress.Text,
                    .Username = txtusername.Text,
                    .Password = txtpassword.Text
                }

                If Integer.TryParse(txtage.Text, admin.Age) Then
                    Dim adminsCollection = Connection1.GetAdminsCollection()
                    adminsCollection.InsertOne(admin)

                    MessageBox.Show("Admin added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearTextBox(data)
                    ' Refresh the DataGridView with the latest data
                    Guna2DataGridView1.DataSource = GetAdminsData()
                Else
                    MessageBox.Show("Please enter a valid age.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function GetAdminsData() As DataTable
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("ID", GetType(String))
        dataTable.Columns.Add("Name", GetType(String))
        dataTable.Columns.Add("Age", GetType(Integer))
        dataTable.Columns.Add("Email", GetType(String))
        dataTable.Columns.Add("Contact", GetType(String))
        dataTable.Columns.Add("Address", GetType(String))
        dataTable.Columns.Add("Username", GetType(String))
        dataTable.Columns.Add("Password", GetType(String))

        Dim adminsCollection = Connection1.GetAdminsCollection()
        Dim adminsCursor = adminsCollection.Find(FilterDefinition(Of Admin).Empty)
        Dim admins = adminsCursor.ToList()

        For Each admin As Admin In admins
            dataTable.Rows.Add(admin.ID, admin.Name, admin.Age, admin.Email, admin.Contact, admin.Address, admin.Username, admin.Password)
        Next

        Return dataTable
    End Function

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        Dim validData As Boolean = True
        ValidateFieldsNotEmptyAdmin(data, validData)

        Dim selectedRowIndex As Integer = Guna2DataGridView1.CurrentCell.RowIndex

        If selectedRowIndex >= 0 AndAlso Guna2DataGridView1.Rows.Count > selectedRowIndex Then
            Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(selectedRowIndex)

            ' Get the ID of the selected admin from the first cell of the row
            Dim adminID As String = selectedRow.Cells("ID").Value.ToString()

            ' Retrieve the existing admin data from MongoDB
            Dim adminsCollection = Connection1.GetAdminsCollection()

            ' Use the adminID as a string directly in the lambda expression
            Dim filter = Builders(Of Admin).Filter.Eq(Function(a) a.ID, adminID)
            Dim existingAdmin = adminsCollection.Find(filter).FirstOrDefault()

            If existingAdmin IsNot Nothing Then
                ' Update the Admin object with the data from the textboxes
                existingAdmin.Name = txtname.Text
                existingAdmin.Age = Integer.Parse(txtage.Text)
                existingAdmin.Email = txtemail.Text
                existingAdmin.Contact = txtcontact.Text
                existingAdmin.Address = txtaddress.Text
                existingAdmin.Username = txtusername.Text
                existingAdmin.Password = txtpassword.Text

                ' Update the admin data in the MongoDB collection
                adminsCollection.ReplaceOne(filter, existingAdmin)

                MessageBox.Show("Admin updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh the DataGridView with the latest data
                Guna2DataGridView1.DataSource = GetAdminsData()
            Else
                MessageBox.Show("Admin not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim id As String = txtid.Text

        If String.IsNullOrEmpty(id) Then
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Try
                Dim selectedRowIndex As Integer = Guna2DataGridView1.CurrentCell.RowIndex

                If selectedRowIndex >= 0 AndAlso Guna2DataGridView1.Rows.Count > selectedRowIndex Then
                    Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(selectedRowIndex)

                    ' Get the ID of the selected admin from the first cell of the row
                    Dim adminID As String = selectedRow.Cells("ID").Value.ToString()

                    ' Show a confirmation dialog before deleting the admin
                    Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to delete this admin?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If confirmationResult = DialogResult.Yes Then
                        ' Retrieve the existing admin data from MongoDB
                        Dim adminsCollection = Connection1.GetAdminsCollection()

                        ' Use the adminID as a string directly in the lambda expression
                        Dim filter = Builders(Of ADMINREGISISTRATION.Admin).Filter.Eq(Function(a) a.ID, adminID)
                        Dim deleteResult = adminsCollection.DeleteOne(filter)

                        If deleteResult.DeletedCount > 0 Then
                            MessageBox.Show("Admin deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Refresh the DataGridView with the latest data
                            Guna2DataGridView1.DataSource = GetAdminsData()
                            ClearTextBox(data)
                        Else
                            MessageBox.Show("Admin not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while removing the admin: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < Guna2DataGridView1.Rows.Count Then
            ' Get the selected row's data
            Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            txtid.Text = selectedRow.Cells("ID").Value.ToString()
            txtname.Text = selectedRow.Cells("Name").Value.ToString()
            txtage.Text = selectedRow.Cells("Age").Value.ToString()
            txtemail.Text = selectedRow.Cells("Email").Value.ToString()
            txtcontact.Text = selectedRow.Cells("Contact").Value.ToString()
            txtaddress.Text = selectedRow.Cells("Address").Value.ToString()
            txtusername.Text = selectedRow.Cells("Username").Value.ToString()
            txtpassword.Text = selectedRow.Cells("Password").Value.ToString()
        End If
    End Sub
End Class