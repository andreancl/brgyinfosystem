Imports MySql.Data.MySqlClient

Public Class frmLogIn
<<<<<<< Updated upstream
    Public con As MySqlConnection = mysqldb()
=======
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        LogIn(txtUserName.Text, txtPassword.Text)
        If Not UserExists() Then
            MsgBox("User does not exist!")
        End If
    End Sub
    Private Function UserExists() As Boolean
        Dim Result As Boolean = False
=======
        Dim connection As New Connections 'Called the Class Connection'
        connection.OpenDBConnection() 'Called the Method OpenDBConnection'
        Dim Reader As MySqlDataReader
        Dim Command As New MySqlCommand
>>>>>>> Stashed changes
        Try
            con.Open()
            Dim query As String
            query = "SELECT * FROM users where Username= '" & txtUserName.Text & "' and Password = '" & txtPassword.Text & "' "
            cmd = New MySqlCommand(query, con)
            If cmd.ExecuteScalar() > 0 Then Result = True
            cmd.Dispose()
        Catch ex As Exception
        Finally
            con.close()
        End Try
        Return Result
    End Function
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
