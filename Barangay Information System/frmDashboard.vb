Public Class Dashboard
    Private Sub btnResident_Click(sender As Object, e As EventArgs) Handles btnResident.Click
        Resident.Show()
        Me.Hide()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        NewUser.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        ExitSys.ExitSystem()
    End Sub
End Class