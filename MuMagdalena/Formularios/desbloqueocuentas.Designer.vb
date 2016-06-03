<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class desbloqueocuentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCBloqueo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFBloqueo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPersoanej = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRBloqueo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSancion = New System.Windows.Forms.TextBox()
        Me.txtRDesbloqueo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDesbloquear = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "C. BLOQUEO"
        '
        'txtCBloqueo
        '
        Me.txtCBloqueo.Enabled = False
        Me.txtCBloqueo.Location = New System.Drawing.Point(126, 23)
        Me.txtCBloqueo.Name = "txtCBloqueo"
        Me.txtCBloqueo.ReadOnly = True
        Me.txtCBloqueo.Size = New System.Drawing.Size(100, 20)
        Me.txtCBloqueo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FECHA BLOQUEO"
        '
        'txtFBloqueo
        '
        Me.txtFBloqueo.Location = New System.Drawing.Point(126, 53)
        Me.txtFBloqueo.Name = "txtFBloqueo"
        Me.txtFBloqueo.ReadOnly = True
        Me.txtFBloqueo.Size = New System.Drawing.Size(100, 20)
        Me.txtFBloqueo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "VENDEDOR"
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(314, 91)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(100, 20)
        Me.txtVendedor.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ID"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(399, 16)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.ReadOnly = True
        Me.txtLogin.Size = New System.Drawing.Size(100, 20)
        Me.txtLogin.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "PERSONAJE"
        '
        'txtPersoanej
        '
        Me.txtPersoanej.Location = New System.Drawing.Point(399, 44)
        Me.txtPersoanej.Name = "txtPersoanej"
        Me.txtPersoanej.ReadOnly = True
        Me.txtPersoanej.Size = New System.Drawing.Size(100, 20)
        Me.txtPersoanej.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "R.BLOQUEO"
        '
        'txtRBloqueo
        '
        Me.txtRBloqueo.Location = New System.Drawing.Point(19, 235)
        Me.txtRBloqueo.Multiline = True
        Me.txtRBloqueo.Name = "txtRBloqueo"
        Me.txtRBloqueo.Size = New System.Drawing.Size(236, 83)
        Me.txtRBloqueo.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "SANCIÓN"
        '
        'txtSancion
        '
        Me.txtSancion.Location = New System.Drawing.Point(126, 129)
        Me.txtSancion.Name = "txtSancion"
        Me.txtSancion.Size = New System.Drawing.Size(358, 20)
        Me.txtSancion.TabIndex = 13
        '
        'txtRDesbloqueo
        '
        Me.txtRDesbloqueo.Location = New System.Drawing.Point(291, 235)
        Me.txtRDesbloqueo.Multiline = True
        Me.txtRDesbloqueo.Name = "txtRDesbloqueo"
        Me.txtRDesbloqueo.Size = New System.Drawing.Size(302, 83)
        Me.txtRDesbloqueo.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(416, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "R.DESBLOQUEO"
        '
        'btnDesbloquear
        '
        Me.btnDesbloquear.Location = New System.Drawing.Point(538, 57)
        Me.btnDesbloquear.Name = "btnDesbloquear"
        Me.btnDesbloquear.Size = New System.Drawing.Size(97, 40)
        Me.btnDesbloquear.TabIndex = 16
        Me.btnDesbloquear.Text = "DESBLOQUEAR"
        Me.btnDesbloquear.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(538, 111)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(97, 38)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(538, 12)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(97, 35)
        Me.btnActualizar.TabIndex = 18
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'desbloqueocuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 330)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnDesbloquear)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRDesbloqueo)
        Me.Controls.Add(Me.txtSancion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRBloqueo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPersoanej)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFBloqueo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCBloqueo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "desbloqueocuentas"
        Me.Text = "DESBLOQUEO CUENTAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCBloqueo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFBloqueo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPersoanej As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRBloqueo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSancion As System.Windows.Forms.TextBox
    Friend WithEvents txtRDesbloqueo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnDesbloquear As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
