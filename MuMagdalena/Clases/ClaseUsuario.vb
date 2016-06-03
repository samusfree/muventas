Imports System.Data.SqlClient
Imports System.Data
Imports System.Security.Cryptography
Imports System.Text

Public Class ClaseUsuario
    Dim cn As New ClaseConexion
    Event mensaje(ByVal mensaje As String)

    Public Function validar(ByVal codigo As String, ByVal password As String) As BeanUsuario
        Try
            Dim da As New SqlDataAdapter("validarUsuario", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            'definir el parametro declarado
            da.SelectCommand.Parameters.Add("@cod_usuario", SqlDbType.VarChar).Value = codigo
            da.SelectCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = getMD5Hash(password)
            Dim tabla As New DataTable
            da.Fill(tabla)
            If (tabla.Rows.Count >= 1) Then
                Dim bean As New BeanUsuario
                Dim r As DataRow
                r = tabla.Rows(0)
                bean.cod_usuario = r(0)
                bean.password = r(1)
                bean.tipousuario = r(2)
                Return bean
            Else
                Return Nothing
            End If
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Function listarnicks() As DataTable
        Try
            Dim da As New SqlDataAdapter("listarUsuarios", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim tabla As New DataTable
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Sub agregarUsuario(ByVal cod_usuario As String, ByVal password As String, ByVal tipousuario As String)
        Try
            cn.getConexion.Open()
            Dim da As New SqlDataAdapter("agregarUsuario", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            'definir el parametro declarado
            da.SelectCommand.Parameters.Add("@cod_usuario", SqlDbType.VarChar).Value = cod_usuario
            da.SelectCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = getMD5Hash(password)
            da.SelectCommand.Parameters.Add("@tipousuario", SqlDbType.VarChar).Value = tipousuario
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
    End Sub

    Public Sub actualizar(ByVal cod_usuario As String, ByVal tipousuario As String)
        Try
            cn.getConexion.Open()
            Dim da As New SqlDataAdapter("cambiarTipo", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            'definir el parametro declarado
            da.SelectCommand.Parameters.Add("@cod_usuario", SqlDbType.VarChar).Value = cod_usuario
            da.SelectCommand.Parameters.Add("@tipousuario", SqlDbType.VarChar).Value = tipousuario
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
    End Sub


    Public Sub modificarClave(ByVal cod_usuario As String, ByVal password As String)
        Try
            cn.getConexion.Open()
            Dim da As New SqlDataAdapter("cambiarClave", cn.getConexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            'definir el parametro declarado
            da.SelectCommand.Parameters.Add("@cod_usuario", SqlDbType.VarChar).Value = cod_usuario
            da.SelectCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = getMD5Hash(password)
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            RaiseEvent mensaje(ex.Message)
        Finally
            cn.getConexion.Close()
        End Try
    End Sub

    Function getMD5Hash(ByVal strToHash As String) As String
        Dim md5Obj As New Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function

End Class
