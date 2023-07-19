<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultabloqueo
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
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.btnBLogin = New System.Windows.Forms.Button()
        Me.btnToos = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dgBloqueo = New System.Windows.Forms.DataGridView()
        CType(Me.dgBloqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(101, 12)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(121, 20)
        Me.txtLogin.TabIndex = 1
        '
        'btnBLogin
        '
        Me.btnBLogin.Location = New System.Drawing.Point(234, 10)
        Me.btnBLogin.Name = "btnBLogin"
        Me.btnBLogin.Size = New System.Drawing.Size(131, 23)
        Me.btnBLogin.TabIndex = 2
        Me.btnBLogin.Text = "BUSQUEDA X ID"
        Me.btnBLogin.UseVisualStyleBackColor = True
        '
        'btnToos
        '
        Me.btnToos.Location = New System.Drawing.Point(373, 10)
        Me.btnToos.Name = "btnToos"
        Me.btnToos.Size = New System.Drawing.Size(196, 23)
        Me.btnToos.TabIndex = 3
        Me.btnToos.Text = "MOSTRAR TODOS LOS BLOQUEOS"
        Me.btnToos.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(576, 9)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'dgBloqueo
        '
        Me.dgBloqueo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBloqueo.Location = New System.Drawing.Point(12, 51)
        Me.dgBloqueo.Name = "dgBloqueo"
        Me.dgBloqueo.Size = New System.Drawing.Size(763, 456)
        Me.dgBloqueo.TabIndex = 5
        '
        'consultabloqueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 651)
        Me.Controls.Add(Me.dgBloqueo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnToos)
        Me.Controls.Add(Me.btnBLogin)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "consultabloqueo"
        Me.Text = "CONSULTA BLOQUEO"
        CType(Me.dgBloqueo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents btnBLogin As System.Windows.Forms.Button
    Friend WithEvents btnToos As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dgBloqueo As System.Windows.Forms.DataGridView
End Class
