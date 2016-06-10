
Imports System.Windows.Forms

Public Class agregarDetalleItemsVenta
    Private idItem As Integer
    Dim WithEvents itemDAO As ItemDAO = New ItemDAOImpl
    Dim ventas As ventas


    Public Sub definirParametros(ByVal idItem As Integer)
        Me.idItem = idItem
    End Sub

    Public Sub listar()
        dgItems.AutoGenerateColumns = False
        dgItems.DataSource = itemDAO.devolverListaItemsHijos(idItem)
        dgItems.EditMode = DataGridViewEditMode.EditOnEnter
    End Sub

    Private Sub agregarDetalleItemsVenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MdiParent = menuPrincipal
        listar()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim lstDetalle As New List(Of BeanDetalleMixto)
        For Each row As DataGridViewRow In dgItems.Rows

            If Not row.IsNewRow Then
                If row.Cells(3).Value = "" Or row.Cells(4).Value = "" Then
                    MessageBox.Show("Por favor ingresar todos los datos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim detalle As BeanDetalleMixto = New BeanDetalleMixto
                detalle.cod_item = row.Cells(1).Value
                detalle.descripcion = row.Cells(2).Value
                detalle.precioventa = row.Cells(4).Value
                detalle.cantidad = 1
                detalle.serie = row.Cells(3).Value
                detalle.nivel = 15

                lstDetalle.Add(detalle)
            End If

        Next

        ventas.agregarItems(lstDetalle)
        ventas.limpiardatosdetalle()
        ventas.Show()
        Me.Dispose()

    End Sub

    Public Sub setVenta(ByRef ventas As ventas)
        Me.ventas = ventas
    End Sub

    Private Sub itemDAO_mensaje(mensaje As String) Handles itemDAO.mensaje
        MessageBox.Show(mensaje, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class