Imports System.IO
Public Class Backup
    Dim Path As String
    Dim BackupPath As String
    Dim DatabaseName As String = "brgyinfodb" + Date.Now.ToString("dd-MM-yyyy-HH-mm-ss")

    Sub Backup()
        Try
            If Not Directory.Exists(BackupPath) Then
                Directory.CreateDirectory(BackupPath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Process.Start("C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe", "--replace --column-statistics=0 -u root -proot --databases brgyinfodb -r """ & BackupPath & "" & DatabaseName & ".sql""")
        MsgBox("Backup Created Successfully!", MsgBoxStyle.Information, "Backup")
    End Sub

    Sub Restore()
        Dim myProcess As New Process()

        myProcess.StartInfo.FileName = "cmd.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.WorkingDirectory = "C:\Program Files\MySQL\MySQL Server 8.0\bin"
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.Start()
        Dim myStreamerWriter As StreamWriter = myProcess.StandardInput
        Dim myStreamerReader As StreamReader = myProcess.StandardOutput
        myStreamerWriter.WriteLine("mysql -u root -proot brgyinfodb < " & Path & "")
        myStreamerWriter.Close()
        myProcess.WaitForExit()
        myProcess.Close()
    End Sub

    Private Sub linkClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        FolderBrowserDialog1.ShowDialog()
        BackupPath = FolderBrowserDialog1.SelectedPath.ToString() + "\"
        Backup()
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Path = OpenFileDialog1.FileName.ToString()
        Restore()
        MsgBox("Database Restoration Successfully!", MsgBoxStyle.Information, "Restore")
    End Sub
End Class