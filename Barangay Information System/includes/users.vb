Imports MySql.Data.MySqlClient
Module user
    Public con As MySqlConnection = mysqldb()
    Public Sub LogIn(ByVal username As Object, ByVal password As Object)
        Try
            con.Open()
            Dim query As String
            query = "SELECT UserTypeId FROM users where Username= '" & username & "' and Password = '" & password & "' "
            cmd = New MySqlCommand(query, con)
            dr = cmd.ExecuteReader
            If dr.HasRows() Then
                dr.Read()
                If dr("UserTypeId") = "1" Then
                    With Dashboard
                        .btnDashboard.Visible = True
                        .btnResident.Visible = True
                        .btnServices.Visible = True
                        .btnBlotter.Visible = True
                        .btnUser.Visible = True
                        .btnBackup.Visible = True
                    End With
                    Dashboard.Show()
                    frmLogIn.Hide()
                Else
                    With Dashboard
                        .btnDashboard.Visible = True
                        .btnResident.Visible = True
                        .btnServices.Visible = True
                        .btnBlotter.Visible = True
                        .btnUser.Visible = False
                        .btnBackup.Visible = False
                    End With
                    Dashboard.Show()
                    frmLogIn.Hide()
                End If
            Else
                MessageBox.Show("You Don't Have Permission To Login System At This Time")
            End If
            dr.Close()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub
End Module
