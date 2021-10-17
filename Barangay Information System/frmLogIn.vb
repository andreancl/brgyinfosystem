Imports MySql.Data.MySqlClient

Public Class LogIn
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=nicole062419;database=brgyinfodb"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from brgyinfodb.tbl_user where Username='" & txtUserName.Text & "'and Password='" & txtPassword.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
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

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
