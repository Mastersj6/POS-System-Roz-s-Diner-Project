Imports System.Data.Odbc
Public Class DBAccess
    Private ConnectionString As String = "Driver={MySQL ODBC 8.0 ANSI Driver}; server=141.209.241.47; database=sp2020bis425fc1g4; user=sp2020bis425fc1g4; password=firstpass"

    Private DBConnection As New OdbcConnection(ConnectionString)

    Private DBCommand As OdbcCommand

    Public DBDataAdapter As OdbcDataAdapter

    Public Params As New List(Of OdbcParameter)

    Public DBDataTable As DataTable
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecuteQuery(QueryString As String)
        RecordCount = 0
        Exception = String.Empty

        Try
            DBConnection.Open()
            DBCommand = New OdbcCommand(QueryString, DBConnection)

            'Load parameters into command
            For Each p As OdbcParameter In Params
                DBCommand.Parameters.Add(p)
            Next

            Params.Clear()

            DBDataTable = New DataTable
            DBDataAdapter = New OdbcDataAdapter(DBCommand)

            RecordCount = DBDataAdapter.Fill(DBDataTable)
        Catch ex As Exception
            Exception = ex.Message
        End Try

        If DBConnection.State = ConnectionState.Open Then DBConnection.Close()
    End Sub

    Public Sub AddParam(Name As String, value As Object)
        Dim NewParam As New OdbcParameter(Name, value)
        Params.Add(NewParam)
    End Sub

End Class