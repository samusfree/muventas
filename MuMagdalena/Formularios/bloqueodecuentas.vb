Imports System.Windows.Forms

Public Class bloqueodecuentas
    Dim WithEvents bloqueo As New claseBloqueo
    Dim WithEvents usuario As New claseUsuario


    Private Sub bloqueodecuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cboSancion.Items
            .Add("7 Dias de Bloqueo")
            .Add("10 Dias de Bloqueo")
            .Add("15 Dias de Bloqueo")
            .Add("21 Dias de Bloqueo")
            .Add("30 Dias de Bloqueo")
            .Add("6 Meses")
            .Add("1 Año")
            .Add("Permanente")
            .Add("Otro")
        End With
        Me.MdiParent = menuPrincipal
        With cboSancion
        End With
        limpiar()
        cboSancion.SelectedIndex = 0
        txtVendedor.Text = menuPrincipal.cod_usuario
    End Sub

    Private Sub txtGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            If txtLogin.Text <> "" AndAlso txtRazonBloqueo.Text <> "" Then

                Dim bean As New BeanBloqueo
                If txtSancion.Enabled = False Then
                    bean.sancion = cboSancion.Text
                Else
                    bean.sancion = txtSancion.Text
                End If
                bean.cod_usuario = txtVendedor.Text
                bean.fecha_bloqueo = dtFecha_Bloqueo.Text
                bean.id_jugador = txtLogin.Text
                bean.razonbloqueo = txtRazonBloqueo.Text
                If txtPersonaje.Text = "" Then
                    bean.personaje = "null"
                Else
                    bean.personaje = txtPersonaje.Text
                End If
                bloqueo.agregarbloqueo(bean)
                limpiar()
            Else
                MessageBox.Show("Falta Llenar Datos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Verifique los Datos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub usuario_mensaje(ByVal mensaje As String) Handles usuario.mensaje
        MessageBox.Show(mensaje, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub



    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Public Sub limpiar()
        txtLogin.Text = ""
        txtPersonaje.Text = ""
        txtRazonBloqueo.Text = ""
        txtLogin.Focus()
    End Sub

    Private Sub bloqueo_confirmacion(ByVal mensaje As String) Handles bloqueo.confirmacion
        MessageBox.Show(mensaje, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub bloqueo_mensaje(ByVal mensaje As String) Handles bloqueo.mensaje
        MessageBox.Show(mensaje, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub cboSancion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSancion.SelectedIndexChanged
        If cboSancion.Text = "Otro" Then
            txtSancion.Enabled = True
        Else
            txtSancion.Enabled = False
        End If
    End Sub


End Class
