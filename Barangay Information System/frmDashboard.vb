﻿Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                ctl.BackColor = Me.BackColor
            End If
        Next ctl
    End Sub
    Private Sub btnResident_Click(sender As Object, e As EventArgs) Handles btnResident.Click
        closeChildForm()
        showForm(Resident)
    End Sub
    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click
        closeChildForm()
        showForm(Blotter)
    End Sub
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        closeChildForm()
        showForm(frmUser)
    End Sub
    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Backup.Show()
    End Sub
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        sysExit.ExitSystem()
    End Sub
End Class