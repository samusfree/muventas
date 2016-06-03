Imports System.Data.SqlClient
Imports System.Data
Public Class ClaseCambioNombre
    Dim cn As New claseconexion
    Event mensaje(ByVal mensaje As String)
    Event confirmacion(ByVal mensaje As String)

    Public Sub agregarcambionombre(ByVal bean As BeanCambionombre)
        'abrir conexion
        cn.getConexion.Open()
        'definir la transacion
        Dim tr As SqlTransaction = _
        cn.getConexion.BeginTransaction(IsolationLevel.Serializable)
        Try

            'grabaar en la tabla tb_proformas
            Dim cmd As New SqlCommand(
            "agregarcambionombre", cn.getConexion, tr)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@cod_usuario ", SqlDbType.VarChar).Value = bean.cod_usuario
                .Add("@idAntiguo", SqlDbType.VarChar).Value = bean.idAntiguo
                .Add("@nickAntiguo", SqlDbType.VarChar).Value = bean.nickAntiguo
                .Add("@idNuevo", SqlDbType.VarChar).Value = bean.idNuevo
                .Add("@nickNuevo", SqlDbType.VarChar).Value = bean.nickNuevo
                .Add("@cantResets", SqlDbType.Int).Value = bean.cantResets
                .Add("@fechacambio", SqlDbType.SmallDateTime).Value = bean.fechacambio
                .Add("@pagado", SqlDbType.Float).Value = bean.pagado
                .Add("@cod_raza", SqlDbType.Int).Value = bean.cod_raza
                .Add("@modalidad", SqlDbType.VarChar).Value = bean.modalidad
                If bean.fechadeposito = "null" Then
                    .Add("@fecha_deposito", SqlDbType.SmallDateTime).Value = DBNull.Value
                    .Add("@mtcn", SqlDbType.VarChar).Value = DBNull.Value
                Else
                    .Add("@fecha_deposito", SqlDbType.SmallDateTime).Value = bean.fechadeposito
                    .Add("@mtcn", SqlDbType.VarChar).Value = bean.mtcn
                End If

            End With
            cmd.ExecuteNonQuery()
            Dim codigo As Integer = 0
            cmd = New SqlCommand("ultimocambionombreinsertado", cn.getConexion, tr)
            cmd.CommandType = CommandType.StoredProcedure
            codigo = cmd.ExecuteScalar
            tr.Commit()
            RaiseEvent confirmacion("Cambio de Nombre Registrado con el Numero " & codigo)
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
            tr.Rollback()
        Finally
            cn.getConexion.Close()
        End Try
    End Sub

    Public Function cambioxidantiguo(ByVal id As String, ByVal tipo As Integer) As DataTable
        Try
            Dim da As New SqlDataAdapter("cambioxidantiguo", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@idAntiguo", SqlDbType.VarChar).Value = id
            da.SelectCommand.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function cambioxidnuevo(ByVal id As String, ByVal tipo As Integer) As DataTable
        Try
            Dim da As New SqlDataAdapter("cambioxidnuevo", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@idnuevo", SqlDbType.VarChar).Value = id
            da.SelectCommand.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Function cambioxnicknuevo(ByVal nick As String, ByVal tipo As Integer) As DataTable
        Try
            Dim da As New SqlDataAdapter("cambioxnicknuevo", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@nicknuevo", SqlDbType.VarChar).Value = nick
            da.SelectCommand.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Function cambioxnickantiguo(ByVal nick As String, ByVal tipo As Integer) As DataTable
        Try
            Dim da As New SqlDataAdapter("cambioxnickantiguo", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@nickantiguo", SqlDbType.VarChar).Value = nick
            da.SelectCommand.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function


    Public Function cambioxFechas(ByVal fechaini As String, ByVal fechafin As String, ByVal tipo As Integer) As DataTable
        Try
            Dim da As New SqlDataAdapter("listarCambiosNombreEntreFechas", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@fecha1", SqlDbType.SmallDateTime).Value = fechaini
            da.SelectCommand.Parameters.Add("@fecha2", SqlDbType.SmallDateTime).Value = fechafin
            da.SelectCommand.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function obtenerCambioNombre(ByVal cod_cambio As Integer) As BeanCambionombre
        Try
            Dim da As New SqlDataAdapter("obtenerCambioNombre", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@cod_cambio", SqlDbType.Int).Value = cod_cambio
            Dim tabla As New DataTable
            da.Fill(tabla)
            Dim d As DataRow = tabla.Rows(0)
            Dim bean As New BeanCambionombre
            bean.cod_cambio = d(0)
            bean.cod_usuario = d(1)
            bean.idAntiguo = d(2)
            bean.nickAntiguo = d(3)
            bean.idNuevo = d(4)
            bean.nickNuevo = d(5)
            bean.cod_raza = d(6)
            bean.cantResets = d(7)
            bean.fechacambio = d(8)
            bean.pagado = d(9)
            bean.estado = d(10)
            'vbean.modalidad = d(11)
            'bean.mtcn = d(12)
            'bean.fechadeposito = d(13)
            Return (bean)
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Sub anularCambioNombre(ByVal cod_cambio As Integer)
        cn.getConexion.Open()
        Dim tr As SqlTransaction = _
        cn.getConexion.BeginTransaction(IsolationLevel.Serializable)
        Try
            Dim cmd As New SqlCommand("anularCambioNombre", cn.getConexion, tr)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@cod_cambio", SqlDbType.Int).Value = cod_cambio
            End With

            cmd.ExecuteNonQuery()
            tr.Commit()
            RaiseEvent confirmacion("Cambio de Nombre Anulado")
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
            tr.Rollback()
        Finally
            cn.getConexion.Close()
        End Try
    End Sub

    Public Sub actualizarCambioNombre(ByVal bean As BeanCambionombre)
        'abrir conexion
        cn.getConexion.Open()
        'definir la transacion
        Dim tr As SqlTransaction = _
        cn.getConexion.BeginTransaction(IsolationLevel.Serializable)
        Try
            'grabaar en la tabla tb_proformas
            Dim cmd As New SqlCommand( _
            "actualizarCambioNombre", cn.getConexion, tr)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@cod_cambio", SqlDbType.Int).Value = bean.cod_cambio
                .Add("@idAntiguo", SqlDbType.VarChar).Value = bean.idAntiguo
                .Add("@idNuevo", SqlDbType.VarChar).Value = bean.idNuevo
                .Add("@nickAntiguo", SqlDbType.VarChar).Value = bean.nickAntiguo
                .Add("@nickNuevo", SqlDbType.VarChar).Value = bean.nickNuevo
                .Add("@cod_raza", SqlDbType.VarChar).Value = bean.cod_raza
                .Add("@cantResets", SqlDbType.Int).Value = bean.cantResets
            End With
            cmd.ExecuteNonQuery()
            'grabar en la tabla tb_proformasdeta
            tr.Commit()
            RaiseEvent confirmacion("El cambio de nombre " & bean.cod_cambio & " se ha actualizado")
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
            tr.Rollback()
        Finally
            cn.getConexion.Close()
        End Try
    End Sub

End Class
