Public Interface ItemDAO
    Event mensaje(ByVal mensaje As String)
    Sub agregarItemHijo(ByVal idItemPadre As Integer, ByVal idItemHijo As Integer)
    Function eliminarItemHijos(ByVal idItemPadre As Integer, ByVal idsItemHijos As List(Of Integer)) As Integer
End Interface