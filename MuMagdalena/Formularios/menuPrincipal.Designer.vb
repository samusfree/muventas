<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuPrincipal))
        Me.mStripPrincipal = New System.Windows.Forms.MenuStrip()
        Me.SessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioDeNombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BloqueoDeCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsulToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasXIdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasXIDToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasXIDHistoricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasXFechasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioNombrePJToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaCambioDeNombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaCambioNombreHistoricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaCambioNombreXFechasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaCambioNombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeBloqueoDeCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaHistoricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioDeDatosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaCambioDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaCambioDeDatosHistoricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mStripPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mStripPrincipal
        '
        Me.mStripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SessionToolStripMenuItem, Me.TransaccionesToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.ConsulToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.mStripPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mStripPrincipal.Name = "mStripPrincipal"
        Me.mStripPrincipal.Size = New System.Drawing.Size(1008, 24)
        Me.mStripPrincipal.TabIndex = 1
        Me.mStripPrincipal.Text = "MenuStrip1"
        '
        'SessionToolStripMenuItem
        '
        Me.SessionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarSessionToolStripMenuItem, Me.CerrarSessionToolStripMenuItem})
        Me.SessionToolStripMenuItem.Name = "SessionToolStripMenuItem"
        Me.SessionToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.SessionToolStripMenuItem.Text = "Sessión"
        '
        'IniciarSessionToolStripMenuItem
        '
        Me.IniciarSessionToolStripMenuItem.Name = "IniciarSessionToolStripMenuItem"
        Me.IniciarSessionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IniciarSessionToolStripMenuItem.Text = "Iniciar Session"
        '
        'CerrarSessionToolStripMenuItem
        '
        Me.CerrarSessionToolStripMenuItem.Enabled = False
        Me.CerrarSessionToolStripMenuItem.Name = "CerrarSessionToolStripMenuItem"
        Me.CerrarSessionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CerrarSessionToolStripMenuItem.Text = "Cerrar Session"
        '
        'TransaccionesToolStripMenuItem
        '
        Me.TransaccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem1, Me.CambioDeNombreToolStripMenuItem, Me.BloqueoDeCuentasToolStripMenuItem, Me.CambioDeDatosToolStripMenuItem})
        Me.TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        Me.TransaccionesToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.TransaccionesToolStripMenuItem.Text = "Transaciones"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(190, 22)
        Me.VentasToolStripMenuItem1.Text = "Ventas Items "
        '
        'CambioDeNombreToolStripMenuItem
        '
        Me.CambioDeNombreToolStripMenuItem.Name = "CambioDeNombreToolStripMenuItem"
        Me.CambioDeNombreToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.CambioDeNombreToolStripMenuItem.Text = "Cambio de nombre PJ"
        '
        'BloqueoDeCuentasToolStripMenuItem
        '
        Me.BloqueoDeCuentasToolStripMenuItem.Name = "BloqueoDeCuentasToolStripMenuItem"
        Me.BloqueoDeCuentasToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.BloqueoDeCuentasToolStripMenuItem.Text = "Bloqueo de ID"
        '
        'CambioDeDatosToolStripMenuItem
        '
        Me.CambioDeDatosToolStripMenuItem.Name = "CambioDeDatosToolStripMenuItem"
        Me.CambioDeDatosToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.CambioDeDatosToolStripMenuItem.Text = "Cambio de Datos"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.ItemsToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimientos"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ItemsToolStripMenuItem.Text = "Items"
        '
        'ConsulToolStripMenuItem
        '
        Me.ConsulToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasXIdToolStripMenuItem, Me.CambioNombrePJToolStripMenuItem, Me.ConsultaCambioNombreToolStripMenuItem, Me.CambioDeDatosToolStripMenuItem1})
        Me.ConsulToolStripMenuItem.Name = "ConsulToolStripMenuItem"
        Me.ConsulToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsulToolStripMenuItem.Text = "Consultas"
        '
        'VentasXIdToolStripMenuItem
        '
        Me.VentasXIdToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasXIDToolStripMenuItem1, Me.VentasXIDHistoricoToolStripMenuItem, Me.VentasXFechasToolStripMenuItem})
        Me.VentasXIdToolStripMenuItem.Name = "VentasXIdToolStripMenuItem"
        Me.VentasXIdToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.VentasXIdToolStripMenuItem.Text = "Ventas"
        '
        'VentasXIDToolStripMenuItem1
        '
        Me.VentasXIDToolStripMenuItem1.Name = "VentasXIDToolStripMenuItem1"
        Me.VentasXIDToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.VentasXIDToolStripMenuItem1.Text = "Ventas Actuales"
        '
        'VentasXIDHistoricoToolStripMenuItem
        '
        Me.VentasXIDHistoricoToolStripMenuItem.Name = "VentasXIDHistoricoToolStripMenuItem"
        Me.VentasXIDHistoricoToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.VentasXIDHistoricoToolStripMenuItem.Text = "Ventas Historico"
        '
        'VentasXFechasToolStripMenuItem
        '
        Me.VentasXFechasToolStripMenuItem.Name = "VentasXFechasToolStripMenuItem"
        Me.VentasXFechasToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.VentasXFechasToolStripMenuItem.Text = "Ventas x Fechas"
        '
        'CambioNombrePJToolStripMenuItem
        '
        Me.CambioNombrePJToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaCambioDeNombreToolStripMenuItem, Me.ConsultaCambioNombreHistoricoToolStripMenuItem, Me.ConsultaCambioNombreXFechasToolStripMenuItem})
        Me.CambioNombrePJToolStripMenuItem.Name = "CambioNombrePJToolStripMenuItem"
        Me.CambioNombrePJToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.CambioNombrePJToolStripMenuItem.Text = "Cambio de Nombre Pj"
        '
        'ConsultaCambioDeNombreToolStripMenuItem
        '
        Me.ConsultaCambioDeNombreToolStripMenuItem.Name = "ConsultaCambioDeNombreToolStripMenuItem"
        Me.ConsultaCambioDeNombreToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ConsultaCambioDeNombreToolStripMenuItem.Text = "Consulta Cambio de Nombre"
        '
        'ConsultaCambioNombreHistoricoToolStripMenuItem
        '
        Me.ConsultaCambioNombreHistoricoToolStripMenuItem.Name = "ConsultaCambioNombreHistoricoToolStripMenuItem"
        Me.ConsultaCambioNombreHistoricoToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ConsultaCambioNombreHistoricoToolStripMenuItem.Text = "Consulta Cambio Nombre Historico"
        '
        'ConsultaCambioNombreXFechasToolStripMenuItem
        '
        Me.ConsultaCambioNombreXFechasToolStripMenuItem.Name = "ConsultaCambioNombreXFechasToolStripMenuItem"
        Me.ConsultaCambioNombreXFechasToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ConsultaCambioNombreXFechasToolStripMenuItem.Text = "Consulta Cambio Nombre x Fechas"
        '
        'ConsultaCambioNombreToolStripMenuItem
        '
        Me.ConsultaCambioNombreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaDeBloqueoDeCuentasToolStripMenuItem, Me.ConsultaHistoricoToolStripMenuItem})
        Me.ConsultaCambioNombreToolStripMenuItem.Name = "ConsultaCambioNombreToolStripMenuItem"
        Me.ConsultaCambioNombreToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ConsultaCambioNombreToolStripMenuItem.Text = "Bloqueo de ID"
        '
        'ConsultaDeBloqueoDeCuentasToolStripMenuItem
        '
        Me.ConsultaDeBloqueoDeCuentasToolStripMenuItem.Name = "ConsultaDeBloqueoDeCuentasToolStripMenuItem"
        Me.ConsultaDeBloqueoDeCuentasToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ConsultaDeBloqueoDeCuentasToolStripMenuItem.Text = "Consulta de Bloqueo de Cuentas"
        '
        'ConsultaHistoricoToolStripMenuItem
        '
        Me.ConsultaHistoricoToolStripMenuItem.Name = "ConsultaHistoricoToolStripMenuItem"
        Me.ConsultaHistoricoToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ConsultaHistoricoToolStripMenuItem.Text = "Consulta Historico"
        '
        'CambioDeDatosToolStripMenuItem1
        '
        Me.CambioDeDatosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaCambioDeDatosToolStripMenuItem, Me.ConsultaCambioDeDatosHistoricoToolStripMenuItem})
        Me.CambioDeDatosToolStripMenuItem1.Name = "CambioDeDatosToolStripMenuItem1"
        Me.CambioDeDatosToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.CambioDeDatosToolStripMenuItem1.Text = "Cambio de Datos"
        '
        'ConsultaCambioDeDatosToolStripMenuItem
        '
        Me.ConsultaCambioDeDatosToolStripMenuItem.Name = "ConsultaCambioDeDatosToolStripMenuItem"
        Me.ConsultaCambioDeDatosToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.ConsultaCambioDeDatosToolStripMenuItem.Text = "Consulta Cambio de Datos"
        '
        'ConsultaCambioDeDatosHistoricoToolStripMenuItem
        '
        Me.ConsultaCambioDeDatosHistoricoToolStripMenuItem.Name = "ConsultaCambioDeDatosHistoricoToolStripMenuItem"
        Me.ConsultaCambioDeDatosHistoricoToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.ConsultaCambioDeDatosHistoricoToolStripMenuItem.Text = "Consulta Cambio de Datos Historico"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'menuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 701)
        Me.Controls.Add(Me.mStripPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mStripPrincipal
        Me.MaximumSize = New System.Drawing.Size(1024, 740)
        Me.Name = "menuPrincipal"
        Me.Text = "Sistema Ventas"
        Me.mStripPrincipal.ResumeLayout(False)
        Me.mStripPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mStripPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents SessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsulToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasXIdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambioNombrePJToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IniciarSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambioDeNombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaCambioNombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BloqueoDeCuentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasXIDToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasXIDHistoricoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasXFechasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaCambioDeNombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeBloqueoDeCuentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaHistoricoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaCambioNombreHistoricoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaCambioNombreXFechasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambioDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambioDeDatosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaCambioDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaCambioDeDatosHistoricoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
