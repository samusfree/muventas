Imports System.Data

Public Class VentaTempUtil
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

    Public Sub limpiar()
        detalle.Clear()
    End Sub
End Class
