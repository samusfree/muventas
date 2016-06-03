Imports System.Data.SqlClient
Imports System.Data
Public Class ClaseTipoItem
    Dim cn As New ClaseConexion
    Event mensaje(ByVal mensaje As String)

    Public Function listar() As DataTable
        Try
            Dim da As New SqlDataAdapter("listarTipoItems", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function
End Class
