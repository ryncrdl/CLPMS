Imports System.Web.UI.WebControls
Imports MetroFramework.Controls
Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization.Attributes
Imports MongoDB.Driver

Public Class ADMINREGISISTRATION

    Private Const ConnectionString As String = "mongodb+srv://johnjericpalima11:johnjericpalima11@clpmsdb.wo66qzz.mongodb.net/CLPMSdb?retryWrites=true&w=majority"

    Private MetroTextBox As MetroFramework.Controls.MetroTextBox
    Private DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Private data As List(Of MetroTextBox)
    Private columnsName As List(Of String)

    Private ReadOnly _database As IMongoDatabase

    Public Sub New()
        InitializeComponent()
        _database = Connection1.GetMongoDatabase()

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

        For i As Integer = 0 To columnsName.Count - 1
            Guna2DataGridView1.Columns.Add(columnsName(i), columnsName(i))
        Next

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
        Dim admins = adminsCollection.Find(FilterDefinition(Of Admin).Empty).ToList()

        For Each admin As Admin In admins
            dataTable.Rows.Add(admin.ID, admin.Name, admin.Age, admin.Email, admin.Contact, admin.Address, admin.Username, admin.Password)
        Next

        Return dataTable
    End Function

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        Dim validData As Boolean = True
        ValidateFieldsNotEmptyAdmin(data, validData)
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        ClearTextBox(data)
    End Sub
End Class