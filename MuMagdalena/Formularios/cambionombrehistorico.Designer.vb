<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambionombrehistorico
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
        Me.dgResultado = New System.Windows.Forms.DataGridView()
        Me.btnIDAnt = New System.Windows.Forms.Button()
        Me.btnIAct = New System.Windows.Forms.Button()
        Me.btnNAct = New System.Windows.Forms.Button()
        Me.btnNAnt = New System.Windows.Forms.Button()
        Me.txtCriterio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgResultado
        '
        Me.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResultado.Location = New System.Drawing.Point(12, 39)
        Me.dgResultado.Name = "dgResultado"
        Me.dgResultado.Size = New System.Drawing.Size(978, 487)
        Me.dgResultado.TabIndex = 13
        '
        'btnIDAnt
        '
        Me.btnIDAnt.Location = New System.Drawing.Point(477, 10)
        Me.btnIDAnt.Name = "btnIDAnt"
        Me.btnIDAnt.Size = New System.Drawing.Size(75, 23)
        Me.btnIDAnt.TabIndex = 12
        Me.btnIDAnt.Text = "ID ANT."
        Me.btnIDAnt.UseVisualStyleBackColor = True
        '
        'btnIAct
        '
        Me.btnIAct.Location = New System.Drawing.Point(396, 10)
        Me.btnIAct.Name = "btnIAct"
        Me.btnIAct.Size = New System.Drawing.Size(75, 23)
        Me.btnIAct.TabIndex = 11
        Me.btnIAct.Text = "ID ACT."
        Me.btnIAct.UseVisualStyleBackColor = True
        '
        'btnNAct
        '
        Me.btnNAct.Location = New System.Drawing.Point(639, 10)
        Me.btnNAct.Name = "btnNAct"
        Me.btnNAct.Size = New System.Drawing.Size(75, 23)
        Me.btnNAct.TabIndex = 10
        Me.btnNAct.Text = "NIKC ACT."
        Me.btnNAct.UseVisualStyleBackColor = True
        '
        'btnNAnt
        '
        Me.btnNAnt.Location = New System.Drawing.Point(558, 10)
        Me.btnNAnt.Name = "btnNAnt"
        Me.btnNAnt.Size = New System.Drawing.Size(75, 23)
        Me.btnNAnt.TabIndex = 9
        Me.btnNAnt.Text = "NICK ANT."
        Me.btnNAnt.UseVisualStyleBackColor = True
        '
        'txtCriterio
        '
        Me.txtCriterio.Location = New System.Drawing.Point(174, 13)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(182, 20)
        Me.txtCriterio.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CRITERIO DE BUSQUEDA"
        '
        'cambionombrehistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 671)
        Me.Controls.Add(Me.dgResultado)
        Me.Controls.Add(Me.btnIDAnt)
        Me.Controls.Add(Me.btnIAct)
        Me.Controls.Add(Me.btnNAct)
        Me.Controls.Add(Me.btnNAnt)
        Me.Controls.Add(Me.txtCriterio)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cambionombrehistorico"
        Me.Text = "CAMBIO NOMBRE HISTORICO"
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgResultado As System.Windows.Forms.DataGridView
    Friend WithEvents btnIDAnt As System.Windows.Forms.Button
    Friend WithEvents btnIAct As System.Windows.Forms.Button
    Friend WithEvents btnNAct As System.Windows.Forms.Button
    Friend WithEvents btnNAnt As System.Windows.Forms.Button
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
