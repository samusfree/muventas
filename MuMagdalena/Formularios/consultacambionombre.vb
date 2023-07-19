Imports System.Windows.Forms

Public Class consultacambionombre
    Dim WithEvents cnombre As New clasecambionombre
    Private Sub cnombre_confirmacion(ByVal mensaje As String) Handles cnombre.confirmacion
        MessageBox.Show( _
        mensaje, "Mensaje de Confirmacion", MessageBoxButtons.OK, _
        MessageBoxIcon.Information)
    End Sub

    Private Sub cnombre_mensaje(ByVal mensaje As String) Handles cnombre.mensaje
        MessageBox.Show( _
                mensaje, "Mensaje de Error", MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
    End Sub
    Private Sub consultacambionombre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = menuPrincipal
        Me.WindowState = 2
    End Sub

    Private Sub btnNAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNAnt.Click
        dgResultado.DataSource = cnombre.cambioxnickantiguo(txtCriterio.Text.Trim, 1)
    End Sub

    Private Sub btnIAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIAct.Click
        dgResultado.DataSource = cnombre.cambioxidnuevo(txtCriterio.Text.Trim, 1)
    End Sub

    Private Sub btnIDAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIDAnt.Click
        dgResultado.DataSource = cnombre.cambioxidantiguo(txtCriterio.Text.Trim, 1)
    End Sub

    Private Sub btnNAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNAct.Click
        dgResultado.DataSource = cnombre.cambioxnicknuevo(txtCriterio.Text.Trim, 1)
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtCriterio.Text = ""
        txtCriterio.Focus()
        dgResultado.DataSource = Nothing
    End Sub

    Private Sub dgResultado_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgResultado.CellContentDoubleClick
        Dim cod_cambio As String = Nothing
        cod_cambio = dgResultado.CurrentRow.Cells(0).Value
        actualizarCambioNombre.definirValores(cod_cambio, 1)
        actualizarCambioNombre.Show()
    End Sub


End Class