Imports MySql.Data.MySqlClient

Public Class Resident
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim dbDataSet As New DataTable

    Public Sub frmResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_ResidentInfo()

        dgvResident.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvResident.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub

    Public Sub load_ResidentInfo()
        Dim connection As New Connections
        Dim adapter As MySqlDataAdapter
        Try
            connection.OpenDBConnection()
            Dim sql As String = "SELECT * FROM residents"
            Command = New MySqlCommand(sql, connection.GetDBConnection)
            adapter = New MySqlDataAdapter(Command)
            Dim ds As New DataSet
            adapter.Fill(ds)
            dgvResident.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.CloseDBConnection()
        End Try
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnNewResident_Click(sender As Object, e As EventArgs) Handles btnNewResident.Click
        NewResident.Show()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        NewUser.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        ExitSys.ExitSystem()
    End Sub
End Class