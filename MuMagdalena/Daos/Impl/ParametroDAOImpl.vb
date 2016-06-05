Imports System.Data
Imports System.Data.SqlClient
Imports SistemaVentas

Public Class ParametroDAOImpl
    Implements ParametroDAO

    Dim cn As New ClaseConexion

    Public Function listado(ByVal parametro As Integer, ByVal tipo As Integer) As DataTable Implements ParametroDAO.listado
        Try
            Dim da As New SqlDataAdapter("obtenerParametros", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@parametro", SqlDbType.Int).Value = parametro
            da.SelectCommand.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
End Class
