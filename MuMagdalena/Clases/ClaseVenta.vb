Imports System.Data.SqlClient
Imports System.Data
Public Class ClaseVenta
    Dim cn As New ClaseConexion
    Dim detalle As New DataTable
    'constructor para definir la estructura del datatable
    'que maneja el detalle
    Sub New()
        detalle.Columns.Add("#", Type.GetType("System.Int32"))
        detalle.Columns.Add("Codigo Item", Type.GetType("System.Int32"))
        detalle.Columns.Add("Set/Item", Type.GetType("System.String"))
        detalle.Columns.Add("Serial", Type.GetType("System.String"))
        detalle.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        detalle.Columns.Add("Precio", Type.GetType("System.Decimal"))
        detalle.Columns.Add("Nivel", Type.GetType("System.Int32"))
        detalle.PrimaryKey = New DataColumn() {detalle.Columns(0)}
    End Sub
    'esta funcion devuelve el detalle 
    Public Function registro() As DataTable
        Return detalle
    End Function
    'eventos para confirmar o informar errores
    Public Event mensaje(ByVal contenido As String)
    Public Event confirmacion(ByVal contenido As String)
    'es para agregar un item al datablessss
    ' es el detalle
    Public Sub agregar(ByVal bean As BeanDetalleMixto)
        'Dim f As DataRow = detalle.Rows.Find(bean.cod_item)
        'si no lo encontro, agrego el registro
        'If f Is Nothing Then
        Dim f As DataRow
        f = detalle.NewRow
        f(0) = detalle.Rows.Count + 1
        f(1) = bean.cod_item
        f(2) = bean.descripcion
        f(3) = bean.serie
        f(4) = bean.cantidad
        f(5) = bean.precioventa
        f(6) = bean.nivel
        detalle.Rows.Add(f)
        'Else
        'si lo encontro mensaje
        'RaiseEvent mensaje("Item o Set ya registrado con esa serie")
        'End If
    End Sub

    Public Sub quitar(ByVal index As Integer)
        detalle.Rows.RemoveAt(index)
    End Sub

    'grabar la proforma y sus detalle
    Public Sub grabar(ByVal venta As BeanVenta)
        'abrir conexion
        cn.getConexion.Open()
        'definir la transacion
        Dim tr As SqlTransaction = _
        cn.getConexion.BeginTransaction(IsolationLevel.Serializable)
        Try
            'grabaar en la tabla tb_proformas
            For Each reg As DataRow In detalle.Rows
                Dim cmd As New SqlCommand( _
            "insertarVenta", cn.getConexion, tr)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@cod_item", SqlDbType.Int).Value = reg(1)
                    .Add("@serie", SqlDbType.VarChar).Value = reg(3)
                    .Add("@cod_usuario", SqlDbType.VarChar).Value = venta.cod_usuario
                    .Add("@id_jugador", SqlDbType.VarChar).Value = venta.id_jugador
                    .Add("@nombresapellidos", SqlDbType.VarChar).Value = venta.nombresapellidos
                    .Add("@fecha_venta", SqlDbType.SmallDateTime).Value = venta.fecha_venta
                    .Add("@modalidad", SqlDbType.VarChar).Value = venta.modalidad
                    If venta.fechadeposito = "null" Then
                        .Add("@fecha_deposito", SqlDbType.SmallDateTime).Value = DBNull.Value
                        .Add("@mtcn", SqlDbType.VarChar).Value = DBNull.Value
                    Else
                        .Add("@fecha_deposito", SqlDbType.SmallDateTime).Value = venta.fechadeposito
                        .Add("@mtcn", SqlDbType.VarChar).Value = venta.mtcn
                    End If
                    .Add("@estado", SqlDbType.VarChar).Value = "Normal"
                    .Add("@cantidad", SqlDbType.Int).Value = reg(4)
                    .Add("@precioventa", SqlDbType.Float).Value = reg(5)
                    .Add("@observacion", SqlDbType.VarChar).Value = venta.observacion
                    .Add("@nivel", SqlDbType.Int).Value = reg(6)
                End With
                cmd.ExecuteNonQuery()
            Next
            'grabar en la tabla tb_proformasdeta
            tr.Commit()
            RaiseEvent confirmacion("Venta Realizada")
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
            tr.Rollback()
        Finally
            cn.getConexion.Close()
        End Try
    End Sub
    Public Sub limpiar()
        detalle.Clear()
    End Sub
    'es para obtener el la ultima cabecera de ienta insertada 
    Public Function obtenerUltimoInsertado() As Integer
        Dim da As New SqlDataAdapter("ultimaventainsertada", cn.getConexion)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim tabla As New DataTable
        da.Fill(tabla)
        Dim d As DataRow
        d = tabla.Rows(0)
        Return Integer.Parse(d(0).ToString())
        Return Nothing
    End Function
    'es para listar los items vendidos en las ventas x id del jugador
    Public Function ventasxid(ByVal id_jugar As String) As DataTable
        Try
            Dim da As New SqlDataAdapter("listaitemvendidosxId", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@id_jugador", _
            SqlDbType.VarChar).Value = id_jugar
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function ventasxserie(ByVal serie As String) As DataTable
        Try
            Dim da As New SqlDataAdapter("listaitemvendidosxSerie", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@serie", _
            SqlDbType.VarChar).Value = serie
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function ventasxseriehistorico(ByVal serie As String) As DataTable
        Try
            Dim da As New SqlDataAdapter("listaitemvendidosxSeriehistorico", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@serie", _
            SqlDbType.VarChar).Value = serie
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    'es para listar los items vendidos en las ventas x id del jugador
    Public Function ventasxmtcn(ByVal mtcn As String) As DataTable
        Try
            Dim da As New SqlDataAdapter("ventasxmtcn", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@mtcn", _
            SqlDbType.VarChar).Value = mtcn
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function ventasxmtcnHistorico(ByVal mtcn As String) As DataTable
        Try
            Dim da As New SqlDataAdapter("ventasxmtcnHistorico", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@mtcn", _
            SqlDbType.VarChar).Value = mtcn
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    'es para listar los items vendidos en las ventas x id del jugador
    Public Function ventasxextranjerologin(ByVal id_jugador As String) As DataTable
        Try
            Dim da As New SqlDataAdapter("ventasxextranjerologin", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@id_jugador", _
            SqlDbType.VarChar).Value = id_jugador
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function


    Public Function ventasxidhistorico(ByVal id_jugar As String) As DataTable
        Try
            Dim da As New SqlDataAdapter("listaitemvendidosxIdhistorico", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@id_jugador",
            SqlDbType.VarChar).Value = id_jugar
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    'procedimiento para obtener el precio del item que se definio en la BD
    Public Function obteneritemxventa(ByVal cod_venta As Integer, ByVal cod_item As Integer, _
    ByVal serie As String) As BeanDetalleCompleto
        Try
            Dim da As New SqlDataAdapter("obteneritemxventa", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@cod_venta", SqlDbType.Int).Value = cod_venta
                .Add("@cod_item", SqlDbType.Int).Value = cod_item
                .Add("@serie", SqlDbType.VarChar).Value = serie
            End With
            Dim tabla As New DataTable
            da.Fill(tabla)
            Dim d As DataRow = tabla.Rows(0)
            Dim bean As New BeanDetalleCompleto
            bean.cod_venta = d(0)
            bean.usuario = d(1)
            bean.login = d(2)
            bean.fecha_venta = d(3)
            bean.modalidad = d(4)
            bean.precioventa = d(5)
            bean.cod_tipoitem = d(6)
            bean.cod_item = d(7)
            bean.descripcion = d(8)
            bean.estado = d(9)
            bean.serie = d(10)
            bean.cantidad = d(11)
            bean.nombreapellidos = d(12)
            bean.observacion = d(13)
            If d(14) IsNot DBNull.Value Then
                bean.mtcn = d(14)
            End If
            If d(15) IsNot DBNull.Value Then
                bean.fechadepo = d(15)
            End If
            bean.nivel = d(16)
            Return (bean)
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
        Return Nothing
    End Function

    Public Function obteneritemxventaMTCN(ByVal cod_venta As Integer, ByVal cod_item As Integer, _
ByVal serie As String) As BeanVentaCompleto
        Try
            Dim da As New SqlDataAdapter("obteneritemxventamtcn", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@cod_venta", SqlDbType.Int).Value = cod_venta
                .Add("@cod_item", SqlDbType.Int).Value = cod_item
                .Add("@serie", SqlDbType.VarChar).Value = serie
            End With
            Dim tabla As New DataTable
            da.Fill(tabla)
            Dim d As DataRow = tabla.Rows(0)
            Dim bean As New BeanVentaCompleto
            bean.cod_venta = d(0)
            bean.usuario = d(1)
            bean.login = d(2)
            bean.fecha_venta = d(3)
            bean.modalidad = d(4)
            bean.precioventa = d(5)
            bean.cod_tipoitem = d(6)
            bean.cod_item = d(7)
            bean.descripcion = d(8)
            bean.estado = d(9)
            bean.serie = d(10)
            bean.cantidad = d(11)
            bean.nombreapellidos = d(12)
            bean.observacion = d(13)
            bean.fecha_deposito = d(14)
            bean.mtcn = d(15)
            Return bean
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
        Return Nothing
    End Function
    Public Sub cambiarventa(ByVal cod_venta As Integer, ByVal cod_item As Integer, ByVal serie As String)
        Try
            Dim cmd As New SqlCommand("cambioitemoset", cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@cod_venta", SqlDbType.Int).Value = cod_venta
                .Add("@cod_item", SqlDbType.Int).Value = cod_item
                .Add("@serie", SqlDbType.VarChar).Value = serie
            End With
            cn.getConexion.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
    End Sub

    Public Sub anularventa(ByVal cod_venta As Integer, ByVal cod_item As Integer, ByVal serie As String)
        Try
            Dim cmd As New SqlCommand("anularventa", cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@cod_venta", SqlDbType.Int).Value = cod_venta
                .Add("@cod_item", SqlDbType.Int).Value = cod_item
                .Add("@serie", SqlDbType.VarChar).Value = serie
            End With
            cn.getConexion.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
    End Sub

    Public Sub actualizarventa(ByVal bean As BeanVentaActualizar)
        'abrir conexion
        cn.getConexion.Open()
        'definir la transacion
        Dim tr As SqlTransaction = _
        cn.getConexion.BeginTransaction(IsolationLevel.Serializable)
        Try
            'grabaar en la tabla tb_proformas
            Dim cmd As New SqlCommand( _
            "modificarventa", cn.getConexion, tr)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@cod_venta", SqlDbType.Int).Value = bean.cod_venta
                .Add("@id_jugador", SqlDbType.VarChar).Value = bean.login
                .Add("@cod_itema", SqlDbType.Int).Value = bean.cod_itema
                .Add("@cod_itemn", SqlDbType.Int).Value = bean.cod_itemn
                .Add("@seriea", SqlDbType.VarChar).Value = bean.seriea
                .Add("@serien", SqlDbType.VarChar).Value = bean.serien
                .Add("@observacion", SqlDbType.VarChar).Value = bean.observacion
                .Add("@precioventa", SqlDbType.Float).Value = bean.precioventa
                .Add("@cantidad", SqlDbType.Int).Value = bean.cantidad
                .Add("@modalidad", SqlDbType.VarChar).Value = bean.modalidad
                .Add("@mtcn", SqlDbType.VarChar).Value = bean.mtcn
                .Add("@nom", SqlDbType.VarChar).Value = bean.nombreapellido
                .Add("@nivel", SqlDbType.Int).Value = bean.nivel
            End With
            cmd.ExecuteNonQuery()
            'grabar en la tabla tb_proformasdeta
            tr.Commit()
            RaiseEvent confirmacion("La venta " & bean.cod_venta & " se ha actualizado")
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
            tr.Rollback()
        Finally
            cn.getConexion.Close()
        End Try
    End Sub

    Public Function ventasentrefechas(ByVal fecha1 As String, _
    ByVal fecha2 As String) As DataTable
        Try
            Dim da As New SqlDataAdapter("ventasxfechas", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@fecha1", SqlDbType.SmallDateTime).Value = fecha1
                .Add("@fecha2", SqlDbType.SmallDateTime).Value = fecha2
            End With
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function ventasentrefechasnormales(ByVal fecha1 As String, _
    ByVal fecha2 As String) As DataTable
        Try
            Dim da As New SqlDataAdapter("ventasxfechasnormales", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@fecha1", SqlDbType.SmallDateTime).Value = fecha1
                .Add("@fecha2", SqlDbType.SmallDateTime).Value = fecha2
            End With
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function ventasxfechasnormalesycambio(ByVal fecha1 As String,
ByVal fecha2 As String) As DataTable
        Try
            Dim da As New SqlDataAdapter("ventasxfechasnormalesycambio", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@fecha1", SqlDbType.SmallDateTime).Value = fecha1
                .Add("@fecha2", SqlDbType.SmallDateTime).Value = fecha2
            End With
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function totalvendientrefechas(ByVal fecha1 As String, _
    ByVal fecha2 As String) As Double
        Try
            Dim cmd As New SqlCommand("totalventaentrefechas", cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@fecha1", SqlDbType.SmallDateTime).Value = fecha1
                .Add("@fecha2", SqlDbType.SmallDateTime).Value = fecha2
            End With
            cn.getConexion.Open()
            Dim codigo As Double = 0
            If cmd.ExecuteScalar IsNot DBNull.Value Then
                codigo = cmd.ExecuteScalar
            End If
            Return codigo
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
        Return Nothing
    End Function

    Public Function totalventaentrefechasNormal(ByVal fecha1 As String, _
    ByVal fecha2 As String) As Double
        Try
            Dim cmd As New SqlCommand("totalventaentrefechasNormal", cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@fecha1", SqlDbType.SmallDateTime).Value = fecha1
                .Add("@fecha2", SqlDbType.SmallDateTime).Value = fecha2
            End With
            cn.getConexion.Open()
            Dim codigo As Double = 0
            If cmd.ExecuteScalar IsNot DBNull.Value Then
                codigo = cmd.ExecuteScalar
            End If
            Return codigo
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
        Return Nothing
    End Function
End Class



