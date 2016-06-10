Imports System.Data

Public Interface ItemDAO
    Event mensaje(ByVal mensaje As String)
    Sub agregarItemHijo(ByVal idItemPadre As Integer, ByVal idItemHijo As Integer)
    Function eliminarItemHijos(ids As List(Of Integer)) As Integer
    Function devolverListaItemsHijos(ByVal cod_item As Integer) As DataTable
End Interface