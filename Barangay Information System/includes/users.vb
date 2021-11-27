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
                    Dashboard.lblUserName.Text = "Admin"
                    With Dashboard
                        .btnDashboard.Visible = True
                        .btnResident.Visible = True
                        .btnBlotter.Visible = True
                        .btnUser.Visible = True
                        .btnBackup.Visible = True
                    End With
                    Dashboard.Show()
                    frmLogIn.Hide()
                Else
                    Dashboard.lblUserName.Text = "User"
                    With Dashboard
                        .btnDashboard.Visible = True
                        .btnResident.Visible = True
                        .btnBlotter.Visible = True
                        .btnUser.Visible = False
                        .btnBackup.Visible = False
                    End With
                    Dashboard.Show()
                    frmLogIn.Hide()
                End If
            End If
            dr.Close()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub
End Module
