Imports System.Windows.Forms

Public Class menuPrincipal
    Public cod_usuario As String
    Public usuario As New BeanUsuario

    Public Sub definirusuario(ByVal cod_usuario As String)
        Me.cod_usuario = cod_usuario
    End Sub

    Public Sub mostrarmenus(ByVal beanUsuario As BeanUsuario)
        usuario = beanUsuario
        cod_usuario = beanUsuario.cod_usuario
        'opciones generica
        IniciarSessionToolStripMenuItem.Enabled = False
        CerrarSessionToolStripMenuItem.Enabled = True
        AyudaToolStripMenuItem.Enabled = True

        'menus padres habilitados para ambos usuarios
        TransaccionesToolStripMenuItem.Enabled = True
        ConsulToolStripMenuItem.Enabled = True

        'opciones especificas
        If (beanUsuario.tipousuario.Equals("Administrador")) Then
            'opciones de mantenimiento del sistema
            MantenimientoToolStripMenuItem.Enabled = True
        Else
            'se deshabilita opciones especificas 
            VentasXFechasToolStripMenuItem.Enabled = False
            ConsultaCambioNombreXFechasToolStripMenuItem.Enabled = False

        End If

        Me.cod_usuario = cod_usuario
        Me.Text = " Sistema de Ventas Sesión " + cod_usuario
    End Sub

    Public Sub cerrarventanas()
        For Each m As Form In MdiChildren
            m.Dispose()
        Next
    End Sub

    Public Sub deshabilitarmenus()
        For Each itemMenu As ToolStripItem In mStripPrincipal.Items
            itemMenu.Enabled = False
        Next
        SessionToolStripMenuItem.Enabled = True
        IniciarSessionToolStripMenuItem.Enabled = True
        CerrarSessionToolStripMenuItem.Enabled = False
    End Sub

    Private Sub menuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deshabilitarmenus()
        Me.WindowState = 2
    End Sub

    Private Sub CerrarSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSessionToolStripMenuItem.Click
        deshabilitarmenus()
        cerrarventanas()
        Me.Text = "Sistema de Ventas"
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        mantenimientoUsuarios.Show()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        about.Show()
    End Sub

    Private Sub IniciarSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IniciarSessionToolStripMenuItem.Click
        login.Show()
    End Sub

    Private Sub ItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemsToolStripMenuItem.Click
        mantenimientoItems.Show()
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem1.Click
        ventas.Show()
    End Sub
    Private Sub CambioDeNombreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambioDeNombreToolStripMenuItem.Click
        cambiodeNombre.Show()
    End Sub

    Private Sub BloqueoDeCuentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BloqueoDeCuentasToolStripMenuItem.Click
        bloqueodecuentas.Show()
    End Sub

    Private Sub VentasXIDToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasXIDToolStripMenuItem1.Click
        ventaxID.Show()
    End Sub

    Private Sub VentasXIDHistoricoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasXIDHistoricoToolStripMenuItem.Click
        ventasxidhistorico.Show()
    End Sub

    Private Sub VentasXFechasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasXFechasToolStripMenuItem.Click
        ventaentrefechas.Show()
    End Sub

    Private Sub ConsultaCambioDeNombreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaCambioDeNombreToolStripMenuItem.Click
        consultacambionombre.Show()
    End Sub

    Private Sub ConsultaDeBloqueoDeCuentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeBloqueoDeCuentasToolStripMenuItem.Click
        consultabloqueo.Show()
    End Sub

    Private Sub ConsultaHistoricoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaHistoricoToolStripMenuItem.Click
        consultabloqueohistorico.Show()
    End Sub

    Private Sub ConsultaCambioNombreHistoricoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaCambioNombreHistoricoToolStripMenuItem.Click
        cambionombrehistorico.Show()
    End Sub

    Private Sub ConsultaCambioNombreXFechasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaCambioNombreXFechasToolStripMenuItem.Click
        cambionombrefechas.Show()
    End Sub

    Private Sub CambioDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambioDeDatosToolStripMenuItem.Click
        cambioDatos.Show()
    End Sub

    Private Sub ConsultaCambioDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaCambioDeDatosToolStripMenuItem.Click
        consultaCambioDatos.Show()
    End Sub

    Private Sub ConsultaCambioDeDatosHistoricoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaCambioDeDatosHistoricoToolStripMenuItem.Click
        consultaCambioDatosHistorico.Show()
    End Sub
End Class
