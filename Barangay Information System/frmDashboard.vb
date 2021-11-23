Public Class Dashboard

    Private Sub btnResident_Click(sender As Object, e As EventArgs) Handles btnResident.Click
        closeChildForm()
        showForm(Resident)
    End Sub

    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click
        closeChildForm()
        showForm(Blotter)
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        NewUser.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        sysExit.ExitSystem()
    End Sub
End Class