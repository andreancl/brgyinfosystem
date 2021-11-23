Public Class Dashboard

    Private Sub btnResident_Click(sender As Object, e As EventArgs) Handles btnResident.Click
<<<<<<< Updated upstream
        closeChildForm()
        showForm(Resident)
    End Sub

    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click
        closeChildForm()
        showForm(Blotter)
=======
        Resident.Show()
        Me.Close()
    End Sub

    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click
        Blotter.Show()
        Me.Close()
>>>>>>> Stashed changes
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs)
        NewUser.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        sysExit.ExitSystem()
<<<<<<< Updated upstream
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                ctl.BackColor = Me.BackColor
            End If
        Next ctl
=======
>>>>>>> Stashed changes
    End Sub


End Class