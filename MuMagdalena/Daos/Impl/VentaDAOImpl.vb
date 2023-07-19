Imports System.Data
Imports System.Data.SqlClient

Public Class VentaDAOImpl
    Implements VentaDAO
    Dim cn As New ClaseConexion

    Public Event mensaje(mensaje As String) Implements VentaDAO.mensaje

    Public Function listarVentasPorFiltros(idJugador As String, mtcn As String, serie As String, fecha1 As String, fecha2 As String, tipoBusqueda As Integer) As DataTable Implements VentaDAO.listarVentasPorFiltros
        Try
            Dim da As New SqlDataAdapter("SP_VENTA_BUSCAR_POR_FILTROS", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                If idJugador = Nothing Then
                    .Add("@id_jugador", SqlDbType.VarChar).Value = DBNull.Value
                Else
                    .Add("@id_jugador", SqlDbType.VarChar).Value = idJugador
                End If
                If mtcn = Nothing Then
                    .Add("@mtcn", SqlDbType.VarChar).Value = DBNull.Value
                Else
                    .Add("@mtcn", SqlDbType.VarChar).Value = mtcn
                End If

                If serie = Nothing Then
                    .Add("@serie", SqlDbType.VarChar).Value = DBNull.Value
                Else
                    .Add("@serie", SqlDbType.VarChar).Value = serie
                End If

                If fecha1 = Nothing Or fecha2 = Nothing Then
                    .Add("@fecha1", SqlDbType.SmallDateTime).Value = DBNull.Value
                    .Add("@fecha2", SqlDbType.SmallDateTime).Value = DBNull.Value
                Else
                    .Add("@fecha1", SqlDbType.SmallDateTime).Value = fecha1
                    .Add("@fecha2", SqlDbType.SmallDateTime).Value = fecha2
                End If

                .Add("@tipobusqueda", SqlDbType.Int).Value = tipoBusqueda
            End With
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function
End Class
