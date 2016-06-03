Imports System.Data.SqlClient
Imports System.Data
Public Class ClaseRaza
    Dim cn As New claseconexion
    Public Function listado() As DataTable
        Try
            Dim da As New SqlDataAdapter("listarRaza", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception

        End Try
        Return Nothing
    End Function
End Class
