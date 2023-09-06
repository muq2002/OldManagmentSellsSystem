Imports System.Data.OleDb
Public Class DatabaseEngine
    Dim Conn As New OleDbConnection("provider=microsoft.ace.oledb.12.0; data source=Shopment.accdb")
    Dim cmd As New OleDbCommand("", Conn)
    Public Sub RunCommand(SQLCommand As String, Optional Message As String = "")
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            cmd.CommandText = SQLCommand
            cmd.ExecuteNonQuery()

            If Message <> "" Then MsgBox(Message)

        Catch ex As Exception
            MessageBox.Show(SQLCommand + vbNewLine + ex.Message, "Managnemt Shop", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Public Function GetTable(SelectCommand As String) As DataTable
        Try
            Dim tbl As New DataTable
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            cmd.CommandText = SelectCommand
            tbl.Load(cmd.ExecuteReader)
            Return tbl

        Catch ex As Exception
            MessageBox.Show(SelectCommand + vbNewLine + ex.Message, "Managnemt Shop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New DataTable
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()

        End Try
    End Function

    Public Sub DisposeConnection()
        Conn.Dispose()
        cmd.Dispose()
    End Sub
End Class
