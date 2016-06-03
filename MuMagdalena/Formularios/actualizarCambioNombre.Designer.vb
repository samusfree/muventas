<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class actualizarCambioNombre
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboRaza = New System.Windows.Forms.ComboBox()
        Me.txtPjAntiguo = New System.Windows.Forms.TextBox()
        Me.txtPJNuevo = New System.Windows.Forms.TextBox()
        Me.txtIDNuevo = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.txtIdAntiguo = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtCantResets = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CODIGO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID ANTIGUO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PJ ANTIGUO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "RAZA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "VENDEDOR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(257, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "FECHA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(257, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ID NUEVO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(257, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "PJ NUEVO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(257, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "CANT RESETS"
        '
        'cboRaza
        '
        Me.cboRaza.FormattingEnabled = True
        Me.cboRaza.Location = New System.Drawing.Point(95, 112)
        Me.cboRaza.Name = "cboRaza"
        Me.cboRaza.Size = New System.Drawing.Size(135, 21)
        Me.cboRaza.TabIndex = 9
        '
        'txtPjAntiguo
        '
        Me.txtPjAntiguo.Location = New System.Drawing.Point(95, 83)
        Me.txtPjAntiguo.Name = "txtPjAntiguo"
        Me.txtPjAntiguo.Size = New System.Drawing.Size(135, 20)
        Me.txtPjAntiguo.TabIndex = 10
        '
        'txtPJNuevo
        '
        Me.txtPJNuevo.Location = New System.Drawing.Point(343, 83)
        Me.txtPJNuevo.Name = "txtPJNuevo"
        Me.txtPJNuevo.Size = New System.Drawing.Size(130, 20)
        Me.txtPJNuevo.TabIndex = 11
        '
        'txtIDNuevo
        '
        Me.txtIDNuevo.Location = New System.Drawing.Point(343, 47)
        Me.txtIDNuevo.Name = "txtIDNuevo"
        Me.txtIDNuevo.Size = New System.Drawing.Size(130, 20)
        Me.txtIDNuevo.TabIndex = 12
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(343, 16)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(130, 20)
        Me.txtFecha.TabIndex = 13
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(95, 146)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(135, 20)
        Me.txtVendedor.TabIndex = 14
        '
        'txtIdAntiguo
        '
        Me.txtIdAntiguo.Location = New System.Drawing.Point(95, 51)
        Me.txtIdAntiguo.Name = "txtIdAntiguo"
        Me.txtIdAntiguo.Size = New System.Drawing.Size(135, 20)
        Me.txtIdAntiguo.TabIndex = 15
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(95, 16)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(135, 20)
        Me.txtCodigo.TabIndex = 16
        '
        'txtCantResets
        '
        Me.txtCantResets.Location = New System.Drawing.Point(343, 117)
        Me.txtCantResets.Name = "txtCantResets"
        Me.txtCantResets.Size = New System.Drawing.Size(130, 20)
        Me.txtCantResets.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(512, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "ACTUALIZAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(512, 83)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "CANCELAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(512, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "ANULAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'actualizarCambioNombre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 351)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCantResets)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtIdAntiguo)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtIDNuevo)
        Me.Controls.Add(Me.txtPJNuevo)
        Me.Controls.Add(Me.txtPjAntiguo)
        Me.Controls.Add(Me.cboRaza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "actualizarCambioNombre"
        Me.Text = "ACTUALIZAR CAMBIO NOMBRE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboRaza As System.Windows.Forms.ComboBox
    Friend WithEvents txtPjAntiguo As System.Windows.Forms.TextBox
    Friend WithEvents txtPJNuevo As System.Windows.Forms.TextBox
    Friend WithEvents txtIDNuevo As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtIdAntiguo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtCantResets As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
