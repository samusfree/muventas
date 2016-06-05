Imports System.Data.SqlClient
Imports System.Data
Public Class claseItem
    Dim cn As New ClaseConexion
    Event mensaje(ByVal mensaje As String)

    Public Function listarporTipoItem(ByVal cod_tipoitem As Integer) As DataTable
        Try
            Dim da As New SqlDataAdapter("listarItemsxTipoItems", cn.getConexion)
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

    Public Function devolverListaItemsHijos(ByVal cod_item As Integer) As List(Of BeanItems)
        Try
            Dim da As New SqlDataAdapter("obtenerItemsHijos", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@codItem", SqlDbType.Int).Value = cod_item
            cn.getConexion.Open()
            Dim tabla As New DataTable
            da.Fill(tabla)

            Dim list As List(Of BeanItems) = New List(Of BeanItems)

            For Each r As DataRow In tabla.Rows
                Dim bean As New BeanItems
                bean.cod_item = r(1)
                bean.cod_tipoitem = r(2)
                bean.descripcion = r(3)
                'bean.precio = r(4)
                list.Add(bean)
            Next

            Return list
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
        Return Nothing
    End Function


    Public Function devolverListaItemsHijosDataTable(ByVal cod_item As Integer) As DataTable
        Try
            Dim da As New SqlDataAdapter("obtenerItemsHijos", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@codItem", SqlDbType.Int).Value = cod_item
            cn.getConexion.Open()
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
        Return Nothing
    End Function
End Class
