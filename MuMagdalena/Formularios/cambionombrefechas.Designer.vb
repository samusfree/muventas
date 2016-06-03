<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambionombrefechas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgResultado
        '
        Me.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResultado.Location = New System.Drawing.Point(23, 69)
        Me.dgResultado.Name = "dgResultado"
        Me.dgResultado.Size = New System.Drawing.Size(727, 463)
        Me.dgResultado.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "FECHA INICIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "FECHA FIN"
        '
        'dtFechaIni
        '
        Me.dtFechaIni.Location = New System.Drawing.Point(143, 19)
        Me.dtFechaIni.Name = "dtFechaIni"
        Me.dtFechaIni.Size = New System.Drawing.Size(200, 20)
        Me.dtFechaIni.TabIndex = 15
        '
        'dtFechaFin
        '
        Me.dtFechaFin.Location = New System.Drawing.Point(143, 43)
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.dtFechaFin.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(384, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 27)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Consultar Normales"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(570, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 27)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Consultar Historico"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cambionombrefechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 552)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtFechaFin)
        Me.Controls.Add(Me.dtFechaIni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgResultado)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cambionombrefechas"
        Me.Text = "CAMBIO NOMBRE X FECHAS"
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgResultado As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
