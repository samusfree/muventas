<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenimientoUsuarios
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
        Me.Nick = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.txtNick = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTipousuario = New System.Windows.Forms.ComboBox()
        Me.btnCamClave = New System.Windows.Forms.Button()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nick
        '
        Me.Nick.AutoSize = True
        Me.Nick.Location = New System.Drawing.Point(44, 69)
        Me.Nick.Name = "Nick"
        Me.Nick.Size = New System.Drawing.Size(32, 13)
        Me.Nick.TabIndex = 0
        Me.Nick.Text = "NICK"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(44, 98)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(70, 13)
        Me.Password.TabIndex = 1
        Me.Password.Text = "PASSWORD"
        '
        'txtNick
        '
        Me.txtNick.Location = New System.Drawing.Point(144, 66)
        Me.txtNick.Name = "txtNick"
        Me.txtNick.Size = New System.Drawing.Size(100, 20)
        Me.txtNick.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(144, 95)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "MANTENIMIENTO DE USUARIOS"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(337, 63)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(142, 23)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Location = New System.Drawing.Point(337, 103)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(142, 23)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "ACTUALIZAR DATOS"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'dgUsuarios
        '
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarios.Location = New System.Drawing.Point(28, 161)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.Size = New System.Drawing.Size(288, 192)
        Me.dgUsuarios.TabIndex = 7
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(337, 178)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(142, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "TIPO USUARIO"
        '
        'cboTipousuario
        '
        Me.cboTipousuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipousuario.FormattingEnabled = True
        Me.cboTipousuario.Location = New System.Drawing.Point(144, 125)
        Me.cboTipousuario.Name = "cboTipousuario"
        Me.cboTipousuario.Size = New System.Drawing.Size(121, 21)
        Me.cboTipousuario.TabIndex = 10
        '
        'btnCamClave
        '
        Me.btnCamClave.Enabled = False
        Me.btnCamClave.Location = New System.Drawing.Point(337, 139)
        Me.btnCamClave.Name = "btnCamClave"
        Me.btnCamClave.Size = New System.Drawing.Size(142, 23)
        Me.btnCamClave.TabIndex = 11
        Me.btnCamClave.Text = "CAMBIAR CLAVE"
        Me.btnCamClave.UseVisualStyleBackColor = True
        '
        'mantenimientoUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 379)
        Me.Controls.Add(Me.btnCamClave)
        Me.Controls.Add(Me.cboTipousuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dgUsuarios)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtNick)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Nick)
        Me.Name = "mantenimientoUsuarios"
        Me.Text = "MANTENIMIENTO DE USUARIOS"
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nick As System.Windows.Forms.Label
    Friend WithEvents Password As System.Windows.Forms.Label
    Friend WithEvents txtNick As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents dgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTipousuario As System.Windows.Forms.ComboBox
    Friend WithEvents btnCamClave As System.Windows.Forms.Button
End Class
