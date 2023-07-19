Imports System.Data
Imports System.Data.SqlClient

Public Class ClaseBloqueo
    Dim cn As New claseconexion
    Event mensaje(ByVal mensaje As String)
    Event confirmacion(ByVal mensaje As String)

    Public Sub agregarbloqueo(ByVal bean As BeanBloqueo)
        Try
            cn.getConexion.Open()
            Dim cmd As New SqlCommand("agregarbloqueo", cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@fecha_bloqueo", SqlDbType.SmallDateTime).Value = bean.fecha_bloqueo
                .Add("@cod_usuario", SqlDbType.VarChar).Value = bean.cod_usuario
                .Add("@id_jugador", SqlDbType.VarChar).Value = bean.id_jugador
                If bean.personaje = "null" Then
                    .Add("@personaje", SqlDbType.VarChar).Value = DBNull.Value
                Else
                    .Add("@personaje", SqlDbType.VarChar).Value = bean.personaje
                End If
                .Add("@razonbloqueo", SqlDbType.VarChar).Value = bean.razonbloqueo
                .Add("@sancion", SqlDbType.VarChar).Value = bean.sancion
            End With
            cmd.ExecuteNonQuery()
            RaiseEvent confirmacion("Bloqueo Insertado")
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
    End Sub

    Public Function listarbloqueo() As DataTable
        Try
            Dim da As New SqlDataAdapter("listarbloqueo", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function listarbloqueohistorico() As DataTable
        Try
            Dim da As New SqlDataAdapter("listarbloqueoHistorico", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function busquedabloqueo(ByVal login As String) As DataTable
        Try
            Dim da As New SqlDataAdapter("bloqueoxlogin", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@id_jugador", SqlDbType.VarChar).Value = login
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Function busquedabloqueohistorico(ByVal login As String) As DataTable
        Try
            Dim da As New SqlDataAdapter("bloqueoxloginhistorico", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@id_jugador", SqlDbType.VarChar).Value = login
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function devolverbloqueo(ByVal cod_bloqueo As Integer) As BeanBloqueo
        Try
            Dim da As New SqlDataAdapter("devolverbloqueo", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@cod_bloqueo", SqlDbType.Int).Value = cod_bloqueo
            cn.getConexion.Open()
            Dim tabla As New DataTable
            da.Fill(tabla)
            Dim r As DataRow = tabla.Rows(0)
            Dim bean As New BeanBloqueo
            bean.fecha_bloqueo = r(0)
            bean.cod_usuario = r(1)
            bean.id_jugador = r(2)
            If r(3) Is DBNull.Value Then
                bean.personaje = ""
            Else

                bean.personaje = r(3)
            End If
            bean.estado = r(4)
            bean.razonbloqueo = r(5)
            bean.cod_bloqueo = r(8)
            bean.sancion = r(6)

            Return bean
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
        Return Nothing
    End Function

    Public Sub desbloquearcuenta(ByVal bean As BeanBloqueo)
        Try
            Dim cmd As New SqlCommand("desbloquearcuenta", cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@cod_bloqueo", SqlDbType.Int).Value = bean.cod_bloqueo
            cmd.Parameters.Add("@razondesbloqueo", SqlDbType.VarChar).Value = bean.razondesbloqueo
            cn.getConexion.Open()
            cmd.ExecuteNonQuery()
            RaiseEvent confirmacion("Cuenta Desbloqueada " & bean.id_jugador)
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
    End Sub

    Public Sub actualizarBloqueo(ByVal bean As BeanBloqueo)
        Try
            Dim cmd As New SqlCommand("actualizarbloqueo", cn.getConexion)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                cmd.Parameters.Add("@cod_bloqueo", SqlDbType.Int).Value = bean.cod_bloqueo
                cmd.Parameters.Add("@sancion", SqlDbType.VarChar).Value = bean.sancion
                cmd.Parameters.Add("@razonbloqueo", SqlDbType.VarChar).Value = bean.razonbloqueo
            End With
            cn.getConexion.Open()
            cmd.ExecuteNonQuery()
            RaiseEvent confirmacion("Cuenta Actualizada " & bean.id_jugador)
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
    End Sub
End Class
