Imports System.Windows.Forms

Public Class desbloqueocuentas
    Dim cod_bloqueo As Integer
    Dim WithEvents bloqueo As New claseBloqueo
    Dim bean As New BeanBloqueo


    Public Sub definivalor(ByVal cod_bloqueo As Integer)
        Me.cod_bloqueo = cod_bloqueo
    End Sub

    Private Sub desbloqueocuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = menuPrincipal
        Try
            bean = bloqueo.devolverbloqueo(cod_bloqueo)
            txtCBloqueo.Text = bean.cod_bloqueo
            txtFBloqueo.Text = bean.fecha_bloqueo
            txtLogin.Text = bean.id_jugador
            txtPersoanej.Text = bean.personaje
            txtRBloqueo.Text = bean.razonbloqueo
            txtSancion.Text = bean.sancion
            txtVendedor.Text = bean.cod_usuario
        Catch ex As Exception
            Me.Dispose()
        End Try
    End Sub

    Private Sub bloqueo_confirmacion(ByVal mensaje As String) Handles bloqueo.confirmacion
        MessageBox.Show(mensaje, "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub bloqueo_mensaje(ByVal mensaje As String) Handles bloqueo.mensaje
        MessageBox.Show(mensaje, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnDesbloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesbloquear.Click
        Dim opcion As Integer = MessageBox.Show("Desea Desbloquear la cuenta", "Confirmación", _
              MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If opcion = 1 Then
            Try
                If txtRDesbloqueo.Text <> "" Then
                    bean.razondesbloqueo = txtRDesbloqueo.Text
                    bloqueo.desbloquearcuenta(bean)
                    btnCancelar.Enabled = False
                    btnDesbloquear.Enabled = False
                Else
                    MessageBox.Show("Falta Llenar datos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
            End Try
        Else
            Exit Sub
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub


    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim opcion As Integer = MessageBox.Show("Desea Actualizar los datos", "Confirmación", _
              MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If opcion = 1 Then
            Dim beanB As New BeanBloqueo
            beanB.cod_bloqueo = txtCBloqueo.Text
            beanB.razonbloqueo = txtRBloqueo.Text
            beanB.sancion = txtSancion.Text
            bloqueo.actualizarBloqueo(beanB)
        End If
    End Sub
End Class