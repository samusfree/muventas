Imports System.Data
Imports System.Data.SqlClient
Imports SistemaVentas

Public Class ItemDAOImpl
    Implements ItemDAO
    Dim cn As New ClaseConexion
    Public Event mensaje(mensaje As String) Implements ItemDAO.mensaje

    Public Sub agregarItemHijo(idItemPadre As Integer, idItemHijo As Integer) Implements ItemDAO.agregarItemHijo
        Try
            cn.getConexion.Open()
            Dim da As New SqlDataAdapter("SP_ITEM_HIJO_AGREGAR", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            'definir el parametro declarado
            da.SelectCommand.Parameters.Add("@itempadre", SqlDbType.Int).Value = idItemPadre
            da.SelectCommand.Parameters.Add("@itemhijo", SqlDbType.Int).Value = idItemHijo
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            RaiseEvent mensaje("Hubo un error al agregar el item Hijo")
        Finally
            cn.getConexion.Close()
        End Try
    End Sub

    Public Function eliminarItemHijos(idItemPadre As Integer, idsItemHijos As List(Of Integer)) As Integer Implements ItemDAO.eliminarItemHijos
        cn.getConexion.Open()
        Dim tr As SqlTransaction =
        cn.getConexion.BeginTransaction(IsolationLevel.Serializable)
        Dim cmd As SqlCommand
        Try
            For Each idItemHijo As Integer In idsItemHijos
                cmd = New SqlCommand("SP_ITEM_HIJO_ELIMINAR", cn.getConexion, tr)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@itempadre", SqlDbType.Int).Value = idItemPadre
                    .Add("@itemhijo", SqlDbType.VarChar).Value = idItemHijo
                End With

                cmd.ExecuteNonQuery()
            Next

            tr.Commit()

            Return 1
        Catch ex As Exception
            tr.Rollback()
            Return 0
        Finally
            cn.getConexion.Close()
        End Try
    End Function
End Class
