Imports MySql.Data.MySqlClient

Public Class Resident
    Dim Command As MySqlCommand
    Dim dbDataSet As New DataTable

    Private Sub Resident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_ResidentInfo()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub load_ResidentInfo()
        Dim connection As New Connections 'Called the Class Connection'
        connection.OpenDBConnection() 'Called the Method OpenDBConnection'
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            Dim Query As String
            Query = "select * from tbl_resident"
            Command = New MySqlCommand(Query, connection.GetDBConnection()) 'Called the Method GetDBConnection that will return the actual DB Connection'
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgvResident.DataSource = bSource
            SDA.Update(dbDataSet)
            connection.CloseDBConnection() 'Called the Method CloseDBConnection'
        Catch ex As Exception
            connection.DisposeDBConnection() 'Called the Method DisposeDBConnection'
        End Try
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("LastName Like'%{0}%'", txtSearchBox.Text)
        dgvResident.DataSource = DV
    End Sub

    Private Sub btnNewResident_Click(sender As Object, e As EventArgs) Handles btnNewResident.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub Middlename_TextChanged(sender As Object, e As EventArgs) Handles Middlename.TextChanged

    End Sub

    Private Sub sex_TextChanged(sender As Object, e As EventArgs) Handles sex.TextChanged

    End Sub
End Class