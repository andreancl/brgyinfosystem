Imports MySql.Data.MySqlClient

Public Class Blotter
    Dim command As MySqlCommand

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnResident_Click(sender As Object, e As EventArgs) Handles btnResident.Click
        Resident.Show()
        Me.Close()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs)
        NewUser.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        sysExit.ExitSystem()
    End Sub
End Class