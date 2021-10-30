Imports MySql.Data.MySqlClient

Public Class LogIn
    Dim Command As MySqlCommand

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim connection As New Connections 'Called the Class Connection'
        connection.OpenDBConnection() 'Called the Method OpenDBConnection'
        Dim Reader As MySqlDataReader
        Try
            Dim Query As String
            Query = "select * from tbl_user where Username='" & txtUserName.Text & "'and Password='" & txtPassword.Text & "'"
            Command = New MySqlCommand(Query, connection.GetDBConnection()) 'Called the Method GetDBConnection that will return the actual DB Connection'
            Reader = Command.ExecuteReader
            Dim count As Integer
            count = 0
            While Reader.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Welcome to Barangay Information System")
                Dashboard.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and Password. Please Try Again")
            Else
                MessageBox.Show("Invalid Username and Password.")
            End If
            connection.CloseDBConnection() 'Called the Method CloseDBConnection'
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.DisposeDBConnection() 'Called the Method DisposeDBConnection'
        End Try
    End Sub

    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
