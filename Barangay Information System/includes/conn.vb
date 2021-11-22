Imports MySql.Data.MySqlClient
Module conn
    Public Function mysqldb() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=nicole062419;database=brgyinfodb")
    End Function
    Public con As MySqlConnection = mysqldb()
End Module
