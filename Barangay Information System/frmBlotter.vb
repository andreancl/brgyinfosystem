Imports MySql.Data.MySqlClient

Public Class Blotter
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs)
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnResident_Click(sender As Object, e As EventArgs)
        Resident.Show()
        Me.Close()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs)
        NewUser.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        sysExit.ExitSystem()
    End Sub

    Private Sub btnNewBlotter_Click(sender As Object, e As EventArgs) Handles btnNewBlotter.Click
        NewBlotter.Show()
    End Sub
End Class