Imports MongoDB.Driver

Module Connection1
    Private ReadOnly ConnectionString As String = "mongodb+srv://johnjericpalima11:johnjericpalima11@clpmsdb.wo66qzz.mongodb.net/CLPMSdb?retryWrites=true&w=majority"
    Private ReadOnly DatabaseName As String = "CLPMSdb"

    Private ReadOnly Client As IMongoClient = New MongoClient(ConnectionString)
    Private ReadOnly Database As IMongoDatabase = Client.GetDatabase(DatabaseName)

    Public Function GetMongoDatabase() As IMongoDatabase
        Return Database
    End Function

    Public Function IsConnected() As Boolean
        Try
            Client.ListDatabaseNames()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Admin
    Public Function GetAdminsCollection() As IMongoCollection(Of ADMINREGISISTRATION.Admin)
        Dim collectionName As String = "Admins"
        Return Database.GetCollection(Of ADMINREGISISTRATION.Admin)(collectionName)
    End Function
End Module
