Imports MySql.Data.MySqlClient

Public Class frmLogIn
    Dim Command As MySqlCommand

    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        anima1.ShowSync(l1)
        anima1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide
        anima1.ShowSync(l2)
        anima1.AnimationType = Guna.UI.Animation.AnimationType.HorizBlind
        anima1.ShowSync(l3)
        anima1.AnimationType = Guna.UI.Animation.AnimationType.HorizBlind
        anima1.ShowSync(L4)
        anima1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide
        anima1.ShowSync(p2)
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim connection As New Connections 'Called the Class Connection'
        connection.OpenDBConnection() 'Called the Method OpenDBConnection'
        Dim Reader As MySqlDataReader
        Try
            Dim Query As String
            Query = "select * from users where Username='" & txtUserName.Text & "'and Password='" & txtPassword.Text & "'"
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

    Private Sub linkaccnt_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkaccnt.LinkClicked
        anima1.HideSync(p2)
        anima1.ShowSync(p3)
    End Sub

    Private Sub btnx_Click_1(sender As Object, e As EventArgs) Handles btnx.Click
        anima1.HideSync(p3)
        anima1.ShowSync(p2)
    End Sub

    Private Sub cbxPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPassword.CheckedChanged
        If cbxPassword.Checked = False Then
            txtPassword.isPassword = True
        Else
            txtPassword.isPassword = False
        End If
    End Sub
End Class
