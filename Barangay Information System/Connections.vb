Imports MySql.Data.MySqlClient

Public Class Connections
    Private _connectionString As String = "server=localhost;userid=root;password=nicole062419;database=brgyinfodb"
    Dim MysqlConn As New MySqlConnection(_connectionString)

    Public Function GetDBConnection()
        Return MysqlConn
    End Function

    Public Function OpenDBConnection() As MySqlConnection
        MysqlConn.Open()
        Return MysqlConn
    End Function

    Public Function CloseDBConnection()
        MysqlConn.Close()
        Return MysqlConn
    End Function

    Public Function DisposeDBConnection()
        MysqlConn.Dispose()
        Return MysqlConn
    End Function

End Class
