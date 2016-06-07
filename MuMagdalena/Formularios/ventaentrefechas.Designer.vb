<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventaentrefechas
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
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dtFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dgVentas = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalVendido = New System.Windows.Forms.TextBox()
        Me.btnNorCam = New System.Windows.Forms.Button()
        Me.btnhisto = New System.Windows.Forms.Button()
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(297, 4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(117, 23)
        Me.btnConsultar.TabIndex = 0
        Me.btnConsultar.Text = "Consultar Normales"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dtFecha1
        '
        Me.dtFecha1.Location = New System.Drawing.Point(80, 9)
        Me.dtFecha1.Name = "dtFecha1"
        Me.dtFecha1.Size = New System.Drawing.Size(200, 20)
        Me.dtFecha1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FECHA 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FECHA 2"
        '
        'dtFecha2
        '
        Me.dtFecha2.Location = New System.Drawing.Point(80, 39)
        Me.dtFecha2.Name = "dtFecha2"
        Me.dtFecha2.Size = New System.Drawing.Size(200, 20)
        Me.dtFecha2.TabIndex = 4
        '
        'dgVentas
        '
        Me.dgVentas.AllowUserToAddRows = False
        Me.dgVentas.AllowUserToDeleteRows = False
        Me.dgVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVentas.Location = New System.Drawing.Point(12, 84)
        Me.dgVentas.Name = "dgVentas"
        Me.dgVentas.ReadOnly = True
        Me.dgVentas.Size = New System.Drawing.Size(766, 500)
        Me.dgVentas.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(551, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TOTAL VENDIDO"
        '
        'txtTotalVendido
        '
        Me.txtTotalVendido.Location = New System.Drawing.Point(669, 53)
        Me.txtTotalVendido.Name = "txtTotalVendido"
        Me.txtTotalVendido.ReadOnly = True
        Me.txtTotalVendido.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalVendido.TabIndex = 7
        Me.txtTotalVendido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnNorCam
        '
        Me.btnNorCam.Location = New System.Drawing.Point(420, 4)
        Me.btnNorCam.Name = "btnNorCam"
        Me.btnNorCam.Size = New System.Drawing.Size(153, 23)
        Me.btnNorCam.TabIndex = 8
        Me.btnNorCam.Text = "Consultar Normales/Cambio"
        Me.btnNorCam.UseVisualStyleBackColor = True
        '
        'btnhisto
        '
        Me.btnhisto.Location = New System.Drawing.Point(579, 4)
        Me.btnhisto.Name = "btnhisto"
        Me.btnhisto.Size = New System.Drawing.Size(127, 23)
        Me.btnhisto.TabIndex = 9
        Me.btnhisto.Text = "Consultar Historico"
        Me.btnhisto.UseVisualStyleBackColor = True
        '
        'ventaentrefechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 593)
        Me.Controls.Add(Me.btnhisto)
        Me.Controls.Add(Me.btnNorCam)
        Me.Controls.Add(Me.txtTotalVendido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgVentas)
        Me.Controls.Add(Me.dtFecha2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtFecha1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Name = "ventaentrefechas"
        Me.Text = "CONSULTA DE VENTAS X FECHAS"
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dtFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgVentas As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalVendido As System.Windows.Forms.TextBox
    Friend WithEvents btnNorCam As System.Windows.Forms.Button
    Friend WithEvents btnhisto As System.Windows.Forms.Button
End Class
