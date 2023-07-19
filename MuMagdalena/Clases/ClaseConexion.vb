Imports System.Configuration
Imports System.Data.SqlClient
Public Class ClaseConexion
    Protected configuracion As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("bdMagdalena")
    Dim cn As New SqlConnection(configuracion.ConnectionString)
    Public ReadOnly Property getConexion() As SqlConnection
        Get
            Return cn
        End Get
    End Property
End Class
