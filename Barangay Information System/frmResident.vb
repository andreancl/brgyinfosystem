Imports MySql.Data.MySqlClient

Public Class Resident
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim dbDataSet As New DataTable

    Private Sub Resident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_ResidentInfo()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub load_ResidentInfo()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=nicole062419;database=brgyinfodb"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from brgyinfodb.tbl_resident"
            Command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgvResident.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()
        Catch ex As Exception

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
End Class