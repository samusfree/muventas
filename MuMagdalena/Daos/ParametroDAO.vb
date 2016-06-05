Imports System.Data

Public Interface ParametroDAO
    Function listado(ByVal parametro As Integer, ByVal tipo As Integer) As DataTable
End Interface
