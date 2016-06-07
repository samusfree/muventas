<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenimientoItemsPadre
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboItem = New System.Windows.Forms.ComboBox()
        Me.cboTipoItem = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboItemHijo = New System.Windows.Forms.ComboBox()
        Me.cboTipoItemHijo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cboCerrar = New System.Windows.Forms.Button()
        Me.dgItems = New System.Windows.Forms.DataGridView()
        Me.correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboItem)
        Me.GroupBox1.Controls.Add(Me.cboTipoItem)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 75)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Padre"
        '
        'cboItem
        '
        Me.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItem.FormattingEnabled = True
        Me.cboItem.Location = New System.Drawing.Point(387, 31)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(257, 21)
        Me.cboItem.TabIndex = 13
        '
        'cboTipoItem
        '
        Me.cboTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoItem.FormattingEnabled = True
        Me.cboTipoItem.Location = New System.Drawing.Point(82, 36)
        Me.cboTipoItem.Name = "cboTipoItem"
        Me.cboTipoItem.Size = New System.Drawing.Size(193, 21)
        Me.cboTipoItem.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(302, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Item/Set"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Tipo de Item"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboItemHijo)
        Me.GroupBox2.Controls.Add(Me.cboTipoItemHijo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(663, 75)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item Hijo"
        '
        'cboItemHijo
        '
        Me.cboItemHijo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItemHijo.FormattingEnabled = True
        Me.cboItemHijo.Location = New System.Drawing.Point(387, 31)
        Me.cboItemHijo.Name = "cboItemHijo"
        Me.cboItemHijo.Size = New System.Drawing.Size(257, 21)
        Me.cboItemHijo.TabIndex = 13
        '
        'cboTipoItemHijo
        '
        Me.cboTipoItemHijo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoItemHijo.FormattingEnabled = True
        Me.cboTipoItemHijo.Location = New System.Drawing.Point(82, 36)
        Me.cboTipoItemHijo.Name = "cboTipoItemHijo"
        Me.cboTipoItemHijo.Size = New System.Drawing.Size(193, 21)
        Me.cboTipoItemHijo.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(302, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Item/Set"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tipo de Item"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(773, 13)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(136, 32)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(773, 65)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(136, 33)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'cboCerrar
        '
        Me.cboCerrar.Location = New System.Drawing.Point(773, 116)
        Me.cboCerrar.Name = "cboCerrar"
        Me.cboCerrar.Size = New System.Drawing.Size(136, 37)
        Me.cboCerrar.TabIndex = 17
        Me.cboCerrar.Text = "CERRAR"
        Me.cboCerrar.UseVisualStyleBackColor = True
        '
        'dgItems
        '
        Me.dgItems.AllowUserToAddRows = False
        Me.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.correlativo, Me.cod_item, Me.descripcion, Me.tipoItem, Me.precio})
        Me.dgItems.Location = New System.Drawing.Point(12, 197)
        Me.dgItems.Name = "dgItems"
        Me.dgItems.ReadOnly = True
        Me.dgItems.Size = New System.Drawing.Size(809, 427)
        Me.dgItems.TabIndex = 18
        '
        'correlativo
        '
        Me.correlativo.DataPropertyName = "correlativo"
        Me.correlativo.HeaderText = "#"
        Me.correlativo.Name = "correlativo"
        Me.correlativo.ReadOnly = True
        Me.correlativo.Width = 39
        '
        'cod_item
        '
        Me.cod_item.DataPropertyName = "cod_item"
        Me.cod_item.HeaderText = "Codigo Item"
        Me.cod_item.Name = "cod_item"
        Me.cod_item.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Nombre"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 120
        '
        'tipoItem
        '
        Me.tipoItem.DataPropertyName = "desc_tipo_item"
        Me.tipoItem.HeaderText = "Tipo de Item"
        Me.tipoItem.Name = "tipoItem"
        Me.tipoItem.ReadOnly = True
        '
        'precio
        '
        Me.precio.DataPropertyName = "precio"
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(836, 197)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(136, 32)
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'mantenimientoItemsPadre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 636)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgItems)
        Me.Controls.Add(Me.cboCerrar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "mantenimientoItemsPadre"
        Me.Text = "MANTENIMIENTO DE ITEMS PADRE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboItem As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipoItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboItemHijo As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipoItemHijo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents cboCerrar As System.Windows.Forms.Button
    Friend WithEvents dgItems As System.Windows.Forms.DataGridView
    Friend WithEvents correlativo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
