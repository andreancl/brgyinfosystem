Public Class Resident

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnResident_Click(sender As Object, e As EventArgs) Handles btnResident.Click
        Register.Show()
        Me.Hide()
    End Sub
End Class