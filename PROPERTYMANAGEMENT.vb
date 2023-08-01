Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization.Attributes
Imports MongoDB.Driver

Public Class PROPERTYMANAGEMENT

    Private ReadOnly _database As IMongoDatabase
    Private Sub PROPERTYMANAGEMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2DataGridView1.DataSource = GetPropertiesData()
    End Sub


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

    Public Class PropertyM
        <BsonId>
        <BsonRepresentation(BsonType.ObjectId)>
        Public Property ID As String
        Public Property SquareMeter As Integer
        Public Property Amenities As Integer
        Public Property Description As String
        Public Property Permit As String
        Public Property EstablishDate As Date
    End Class

    Public Function GetPropertiesData() As DataTable
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("ID", GetType(String))
        dataTable.Columns.Add("Square Meter", GetType(String))
        dataTable.Columns.Add("Amenities", GetType(Integer))
        dataTable.Columns.Add("Description", GetType(String))
        dataTable.Columns.Add("Permit", GetType(String))
        dataTable.Columns.Add("Date", GetType(String))

        Dim propertiesCollection = Connection1.GetPropertiesCollection()
        Dim propertiesCursor = propertiesCollection.Find(FilterDefinition(Of PropertyM).Empty)
        Dim properties = propertiesCursor.ToList()

        For Each propertyM As PropertyM In properties
            dataTable.Rows.Add(propertyM.ID, propertyM.SquareMeter, propertyM.Amenities, propertyM.Description, propertyM.Permit, propertyM.EstablishDate)
        Next

        Return dataTable
    End Function

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged
        If MetroComboBox1.Text = "Available Properties" Then
            Guna2Button1.Visible = True
            Guna2Button3.Visible = True
            ' Guna2Button5.Visible = False
        ElseIf MetroComboBox1.Text = "Occupied Properties" Then
            Guna2Button1.Visible = False
            Guna2Button3.Visible = False
            ' Guna2Button5.Visible = True
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        PROPERTYMANAGEMENTADD.Show()
    End Sub

    Private Sub f_Click(sender As Object, e As EventArgs)

    End Sub
End Class