Public Class sysExit
    Public Shared Function ExitSystem()
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Are you sure you want to log out?", "Barangay Information System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iexit = DialogResult.Yes Then
            Application.Exit()
        End If
        End
    End Function
End Class
