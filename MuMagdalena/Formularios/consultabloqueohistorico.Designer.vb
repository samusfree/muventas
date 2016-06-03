<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultabloqueohistorico
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
        Me.dgBloqueo = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnBLogin = New System.Windows.Forms.Button
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dgBloqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgBloqueo
        '
        Me.dgBloqueo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBloqueo.Location = New System.Drawing.Point(26, 51)
        Me.dgBloqueo.Name = "dgBloqueo"
        Me.dgBloqueo.Size = New System.Drawing.Size(706, 490)
        Me.dgBloqueo.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(624, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "CANCELAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(421, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "MOSTRAR TODOS LOS BLOQUEOS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnBLogin
        '
        Me.btnBLogin.Location = New System.Drawing.Point(282, 15)
        Me.btnBLogin.Name = "btnBLogin"
        Me.btnBLogin.Size = New System.Drawing.Size(131, 23)
        Me.btnBLogin.TabIndex = 14
        Me.btnBLogin.Text = "BUSQUEDA ID"
        Me.btnBLogin.UseVisualStyleBackColor = True
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(149, 17)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(121, 20)
        Me.txtLogin.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ID"
        '
        'consultabloqueohistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 553)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnBLogin)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgBloqueo)
        Me.Name = "consultabloqueohistorico"
        Me.Text = "CONSULTA BLOQUEO HISTORICO"
        CType(Me.dgBloqueo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgBloqueo As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnBLogin As System.Windows.Forms.Button
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
