Imports System.Data
Imports System.Data.SqlClient
Public Class ClaseCambioDatos
    Dim cn As New ClaseConexion

    Public Sub guardarDatos(ByVal bean As beanCambioDatos)
        Try
            cn.getConexion.Open()
            Dim da As New SqlDataAdapter("insertarCambioDatos", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            'definir el parametro declarado
            da.SelectCommand.Parameters.Add("@cod_usuario", SqlDbType.VarChar).Value = bean.cod_usuario
            da.SelectCommand.Parameters.Add("@idcuenta", SqlDbType.VarChar).Value = bean.idcuenta
            da.SelectCommand.Parameters.Add("@proantiguo", SqlDbType.VarChar).Value = bean.proantiguo
            da.SelectCommand.Parameters.Add("@pronuevo", SqlDbType.VarChar).Value = bean.pronuevo
            da.SelectCommand.Parameters.Add("@dniantiguo", SqlDbType.VarChar).Value = bean.dniantiguo
            da.SelectCommand.Parameters.Add("@dninuevo", SqlDbType.VarChar).Value = bean.dninuevo
            da.SelectCommand.Parameters.Add("@correoant", SqlDbType.VarChar).Value = bean.correoant
            da.SelectCommand.Parameters.Add("@correonuevo", SqlDbType.VarChar).Value = bean.correonuevo
            da.SelectCommand.Parameters.Add("@fecha", SqlDbType.SmallDateTime).Value = bean.fecha
            da.SelectCommand.Parameters.Add("@pagado", SqlDbType.Float).Value = bean.pagado
            da.SelectCommand.Parameters.Add("@modalidad", SqlDbType.VarChar).Value = bean.modalidad
            da.SelectCommand.Parameters.Add("@observacion", SqlDbType.VarChar).Value = bean.observacion
           
            If bean.modalidad <> "EFECTIVO" Then
                da.SelectCommand.Parameters.Add("@fecha_deposito", SqlDbType.SmallDateTime).Value = bean.fecha_deposito
                da.SelectCommand.Parameters.Add("@mtcn", SqlDbType.VarChar).Value = bean.mtcn
            Else
                da.SelectCommand.Parameters.Add("@fecha_deposito", SqlDbType.SmallDateTime).Value = DBNull.Value
                da.SelectCommand.Parameters.Add("@mtcn", SqlDbType.VarChar).Value = DBNull.Value
            End If

            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
    End Sub

    Function obtenerCambioDatos(ByVal codCambioDatos As Integer) As BeanCambioDatos
        Try
            Dim da As New SqlDataAdapter("obtenerCambioDatos", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@cod_cambiodatos", SqlDbType.Int).Value = codCambioDatos
            Dim tabla As New DataTable
            da.Fill(tabla)
            Dim d As DataRow = tabla.Rows(0)
            Dim bean As New BeanCambioDatos
            bean.cod_cambiodatos = d(0)
            bean.cod_usuario = d(1)
            bean.idcuenta = d(2)
            bean.proantiguo = d(3)
            bean.pronuevo = d(4)

            If Not IsDBNull(d(5)) Then
                bean.dniantiguo = d(5)
            End If

            If Not IsDBNull(d(6)) Then
                bean.dninuevo = d(6)
            End If

            bean.correoant = d(7)
            bean.correonuevo = d(8)
            bean.fecha = d(9)
            bean.pagado = d(10)
            bean.estado = d(11)

            If Not IsDBNull(d(12)) Then
                bean.fecha_deposito = d(12)
            End If
            If Not IsDBNull(d(13)) Then
                bean.mtcn = d(13)
            End If

            bean.modalidad = d(14)

            If Not IsDBNull(d(15)) Then
                bean.observacion = d(15)
            End If

            Return (bean)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Sub anularCambioDatos(ByVal cod_cambio As Integer, ByVal observacion As String)
        cn.getConexion.Open()
        Dim tr As SqlTransaction = _
        cn.getConexion.BeginTransaction(IsolationLevel.Serializable)
        Try
            Dim cmd As New SqlCommand("anularCambioDatos", cn.getConexion, tr)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@cod_cambiodatos", SqlDbType.Int).Value = cod_cambio
                .Add("@observacion", SqlDbType.VarChar).Value = observacion
            End With

            cmd.ExecuteNonQuery()
            tr.Commit()
        Catch ex As Exception
            tr.Rollback()
        Finally
            cn.getConexion.Close()
        End Try
    End Sub

    Function busqueda(ByVal valor As String, ByVal tipoParametro As Integer, ByVal tipoBusqueda As Integer) As Object
        Try
            Dim da As New SqlDataAdapter("buscarCambioDatos", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@fechainicio", SqlDbType.SmallDateTime).Value = DBNull.Value
            da.SelectCommand.Parameters.Add("@fechafin", SqlDbType.SmallDateTime).Value = DBNull.Value
            da.SelectCommand.Parameters.Add("@tipo", SqlDbType.Int).Value = tipoBusqueda

            If tipoParametro = 1 Then
                da.SelectCommand.Parameters.Add("@idcuenta", SqlDbType.VarChar).Value = valor
                da.SelectCommand.Parameters.Add("@mtcn", SqlDbType.VarChar).Value = DBNull.Value
            End If

            If tipoParametro = 2 Then
                da.SelectCommand.Parameters.Add("@mtcn", SqlDbType.VarChar).Value = valor
                da.SelectCommand.Parameters.Add("@idcuenta", SqlDbType.VarChar).Value = DBNull.Value
            End If

            Dim tabla As New DataTable

            da.Fill(tabla)

            Return tabla

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Function busqueda(ByVal fechaInicio As String, ByVal fechaFin As String, ByVal tipoBusqueda As Integer) As Object
        Try
            Dim da As New SqlDataAdapter("buscarCambioDatos", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@idcuenta", SqlDbType.VarChar).Value = DBNull.Value
            da.SelectCommand.Parameters.Add("@mtcn", SqlDbType.VarChar).Value = DBNull.Value
            da.SelectCommand.Parameters.Add("@fechainicio", SqlDbType.SmallDateTime).Value = fechaInicio
            da.SelectCommand.Parameters.Add("@fechafin", SqlDbType.SmallDateTime).Value = fechaFin
            da.SelectCommand.Parameters.Add("@tipo", SqlDbType.Int).Value = tipoBusqueda
            Dim tabla As New DataTable

            da.Fill(tabla)

            Return tabla

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

End Class
