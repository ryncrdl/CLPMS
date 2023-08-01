Imports CLPMS.PROPERTYMANAGEMENTADD
Imports CLPMS.ADMINREGISISTRATION
Imports CLPMS.PROPERTYMANAGEMENT
Imports MongoDB.Driver

Module Connection1
    Public ReadOnly ConnectionString As String = "mongodb+srv://johnjericpalima11:johnjericpalima11@clpmsdb.wo66qzz.mongodb.net/CLPMSdb?retryWrites=true&w=majority"
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

    Private Function GetCollectionName(Of T)() As IMongoCollection(Of T)
        Dim collectionName As String = GetType(T).Name
        Return Database.GetCollection(Of T)(collectionName)
    End Function

    'Admin
    '   Public Function GetAdminsCollection() As IMongoCollection(Of GetCollectionName)
    'Dim collectionName As String = "Admins"
    ' Database.GetCollection(Of ADMINREGISISTRATION.Admin)(collectionName)
    'End Function

    'Admin  
    Public Function GetAdminsCollection() As IMongoCollection(Of Admin)
        Return GetCollectionName(Of Admin)()
    End Function

    'Property
    Public Function GetPropertiesCollection() As IMongoCollection(Of PropertyM)
        Return GetCollectionName(Of PropertyM)()
    End Function

End Module
