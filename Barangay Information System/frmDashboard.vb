Public Class Dashboard

    Private Sub btnResident_Click(sender As Object, e As EventArgs) Handles btnResident.Click
        Resident.Show()
        Me.Close()
    End Sub

    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click
        Blotter.Show()
        Me.Close()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs)
        NewUser.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        sysExit.ExitSystem()
    End Sub
End Class