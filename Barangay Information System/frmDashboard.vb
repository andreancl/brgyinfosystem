Public Class Dashboard
    Private Sub btnResident_Click(sender As Object, e As EventArgs) Handles btnResident.Click
        Resident.Show()
        Me.Hide()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        NewUser.Show()
    End Sub
End Class