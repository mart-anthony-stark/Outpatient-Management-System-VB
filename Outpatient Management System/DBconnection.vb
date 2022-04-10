Imports MySql.Data.MySqlClient

Module DBconnection
    Public Function strconnection() As MySqlConnection
        Dim MysqlConn As MySqlConnection
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=test_db;CharSet=utf8;"
        Return MysqlConn
    End Function

    Public strconn As MySqlConnection = strconnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    'METHOD FOR RETRIEVING DATA IN DB'
    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = sql

            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strconn.Close()
        da.Dispose()
    End Sub
End Module
