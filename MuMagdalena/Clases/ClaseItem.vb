Imports System.Data
Imports System.Data.SqlClient
Public Class claseItem
    Dim cn As New ClaseConexion
    Event mensaje(ByVal mensaje As String)

    Public Function listarporTipoItem(ByVal cod_tipoitem As Integer) As DataTable
        Try
            Dim da As New SqlDataAdapter("SP_ITEM_OBTENER_POR_TIPO", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@cod_tipoitem", SqlDbType.Int).Value = cod_tipoitem
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Sub agregarItem(ByVal item As BeanItems)
        Try
            cn.getConexion.Open()
            Dim da As New SqlDataAdapter("agregarItem", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            'definir el parametro declarado
            da.SelectCommand.Parameters.Add("@cod_tipoitem", SqlDbType.Int).Value = item.cod_tipoitem
            da.SelectCommand.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = item.descripcion
            da.SelectCommand.Parameters.Add("@precio", SqlDbType.Float).Value = item.precio
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
    End Sub
    Public Sub modificaritem(ByVal item As BeanItems)
        Try
            cn.getConexion.Open()
            Dim da As New SqlDataAdapter("modificaritem", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            'definir el parametro declarado
            da.SelectCommand.Parameters.Add("@cod_item", SqlDbType.Int).Value = item.cod_item
            da.SelectCommand.Parameters.Add("@cod_tipoitem", SqlDbType.Int).Value = item.cod_tipoitem
            da.SelectCommand.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = item.descripcion
            da.SelectCommand.Parameters.Add("@precio", SqlDbType.Float).Value = item.precio
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
    End Sub

    Public Function devolveritem(ByVal cod_item As Integer) As Double
        Try
            Dim da As New SqlDataAdapter("devolveritem", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@cod_item", SqlDbType.Int).Value = cod_item
            Dim d As DataRow
            Dim tabla As New DataTable
            da.Fill(tabla)
            d = tabla.Rows(0)
            Return d(3).ToString()
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function
End Class
