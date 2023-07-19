<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCod_usuario = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INICIO DE SESSION "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NICK"
        '
        'txtCod_usuario
        '
        Me.txtCod_usuario.Location = New System.Drawing.Point(216, 96)
        Me.txtCod_usuario.Name = "txtCod_usuario"
        Me.txtCod_usuario.Size = New System.Drawing.Size(188, 20)
        Me.txtCod_usuario.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(216, 129)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(188, 20)
        Me.txtPassword.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PASSWORD"
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnIngresar.Location = New System.Drawing.Point(226, 197)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(189, 45)
        Me.btnIngresar.TabIndex = 5
        Me.btnIngresar.Text = "INGRESAR"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AcceptButton = Me.btnIngresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 448)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtCod_usuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login"
        Me.Text = "INGRESAR AL SISTEMA DE VENTAS "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCod_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
End Class
