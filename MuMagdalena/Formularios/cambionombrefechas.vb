Public Class cambionombrefechas
    Dim claseCambio As New clasecambionombre
    Dim tipo As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dgResultado.DataSource = claseCambio.cambioxFechas(dtFechaIni.Text, dtFechaFin.Text, 1)
        tipo = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dgResultado.DataSource = claseCambio.cambioxFechas(dtFechaIni.Text, dtFechaFin.Text, 2)
        tipo = 1
    End Sub

    Private Sub dgResultado_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgResultado.CellContentDoubleClick
        Dim cod_cambio As String = Nothing
        cod_cambio = dgResultado.CurrentRow.Cells(0).Value
        If tipo = 0 Then
            actualizarCambioNombre.definirValores(cod_cambio, 1)
        Else
            actualizarCambioNombre.definirValores(cod_cambio, 2)
        End If
        actualizarCambioNombre.Show()
    End Sub

    Private Sub cambionombrefechas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = menuPrincipal
        Me.WindowState = 2
    End Sub
End Class