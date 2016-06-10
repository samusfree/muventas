Imports System.Data
Imports System.Windows.Forms

Public Class mantenimientoItemsPadre
    Dim parametros As New ParametroDAOImpl
    'Dim WithEvents item As New claseItem
    Dim WithEvents itemDao As New ItemDAOImpl

    Private Sub mantenimientoItemsPadre_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgItems.AutoGenerateColumns = False
        MdiParent = menuPrincipal
        Me.WindowState = 2
        RemoveHandler cboTipoItem.SelectedIndexChanged, AddressOf cboTipoItem_SelectedIndexChanged
        RemoveHandler cboTipoItemHijo.SelectedIndexChanged, AddressOf cboTipoItemHijo_SelectedIndexChanged

        'agregando seleccion por defecto
        Dim dtTipoItems As DataTable = parametros.listado(AppConstants.ParametroTipoItem, Nothing)
        Dim rowTipoItems As DataRow = dtTipoItems.NewRow
        rowTipoItems("descripcion") = "Seleccione un Item"
        rowTipoItems("codigo") = "0"
        dtTipoItems.Rows.InsertAt(rowTipoItems, 0)

        cboTipoItem.DataSource = dtTipoItems
        cboTipoItem.DisplayMember = "descripcion"
        cboTipoItem.ValueMember = "codigo"

        Dim dtTipoItemsHijo As DataTable = parametros.listado(AppConstants.ParametroTipoItem, Nothing)
        Dim rowTipoItemsHijo As DataRow = dtTipoItemsHijo.NewRow
        rowTipoItemsHijo("descripcion") = "Seleccione un Item"
        rowTipoItemsHijo("codigo") = "0"
        dtTipoItemsHijo.Rows.InsertAt(rowTipoItemsHijo, 0)

        With cboTipoItemHijo
            .DataSource = dtTipoItemsHijo
            .DisplayMember = "descripcion"
            .ValueMember = "codigo"
        End With

        cboTipoItem.SelectedIndex = 0
        cboTipoItemHijo.SelectedIndex = 0

        Me.WindowState = 2
        AddHandler cboTipoItem.SelectedIndexChanged, AddressOf cboTipoItem_SelectedIndexChanged
        AddHandler cboTipoItemHijo.SelectedIndexChanged, AddressOf cboTipoItemHijo_SelectedIndexChanged
        btnEliminar.Hide()
    End Sub

    Private Sub limpiar()

        cboTipoItemHijo.SelectedIndex = 0
        dgItems.DataSource = itemDao.devolverListaItemsHijos(cboItem.SelectedValue)
        If dgItems.RowCount > 0 Then
            btnEliminar.Show()
        Else
            btnEliminar.Hide()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cboItem.SelectedIndex < 1 Or cboItemHijo.SelectedIndex < 1 Then
            MessageBox.Show("Por favor seleccione el Item Padre o Item Hijo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        itemDao.agregarItemHijo(cboItem.SelectedValue, cboItemHijo.SelectedValue)

        MessageBox.Show("Se agrego el item Hijo", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

        limpiar()

    End Sub

    Private Sub cboTipoItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoItem.SelectedIndexChanged
        RemoveHandler cboItem.SelectedIndexChanged, AddressOf cboItem_SelectedIndexChanged
        Dim dtItems As DataTable = parametros.listado(AppConstants.ParametroItem, cboTipoItem.SelectedValue)
        Dim rowItems As DataRow = dtItems.NewRow
        rowItems("descripcion") = "Seleccione un Item"
        rowItems("codigo") = "0"
        dtItems.Rows.InsertAt(rowItems, 0)

        With cboItem
            .DataSource = dtItems
            .DisplayMember = "descripcion"
            .ValueMember = "codigo"
        End With
        AddHandler cboItem.SelectedIndexChanged, AddressOf cboItem_SelectedIndexChanged
    End Sub

    Private Sub cboTipoItemHijo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoItemHijo.SelectedIndexChanged
        Dim dtItems As DataTable = parametros.listado(AppConstants.ParametroItem, cboTipoItemHijo.SelectedValue)
        Dim rowItems As DataRow = dtItems.NewRow
        rowItems("descripcion") = "Seleccione un Item"
        rowItems("codigo") = "0"
        dtItems.Rows.InsertAt(rowItems, 0)

        With cboItemHijo
            .DataSource = dtItems
            .DisplayMember = "descripcion"
            .ValueMember = "codigo"
        End With
    End Sub

    Private Sub cboItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItem.SelectedIndexChanged
        limpiar()
    End Sub

    Private Sub itemDao_mensaje(mensaje As String) Handles itemDao.mensaje
        MessageBox.Show(mensaje, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub cboCerrar_Click(sender As Object, e As EventArgs) Handles cboCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cboTipoItem.SelectedIndex = 0
        limpiar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgItems.SelectedRows.Count > 0 Then
            Dim lista As New List(Of Integer)
            For Each row As DataGridViewRow In dgItems.SelectedRows
                lista.Add(row.Cells(0).Value)
            Next

            If itemDao.eliminarItemHijos(lista) > 0 Then
                MessageBox.Show("Se eliminó los items hijos seleccionados", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al eliminar los items hijos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            limpiar()
        Else
            MessageBox.Show("Por favor seleccione los items a eliminar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class