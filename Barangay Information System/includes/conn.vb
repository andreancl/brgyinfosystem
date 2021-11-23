Imports MySql.Data.MySqlClient
Module conn
    Public Function mysqldb() As MySqlConnection
<<<<<<< Updated upstream
        Return New MySqlConnection("server=localhost;user id=root;password=nicole062419;database=brgyinfodb")
=======
        Return New MySqlConnection("server=localhost;user id=root;password=nicole062419;database=brgyinfodb;sslMode=none")
>>>>>>> Stashed changes
    End Function
    Public con As MySqlConnection = mysqldb()
End Module
