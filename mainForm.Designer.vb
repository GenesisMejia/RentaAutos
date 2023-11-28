<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSistema = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnDevolver = New System.Windows.Forms.Button()
        Me.btnRentar = New System.Windows.Forms.Button()
        Me.btnVehiculos = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelTop = New System.Windows.Forms.Label()
        Me.btnSesion = New System.Windows.Forms.Button()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.lbNombreUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbIdUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnSistema)
        Me.Panel1.Controls.Add(Me.btnUsuarios)
        Me.Panel1.Controls.Add(Me.btnReportes)
        Me.Panel1.Controls.Add(Me.btnDevolver)
        Me.Panel1.Controls.Add(Me.btnRentar)
        Me.Panel1.Controls.Add(Me.btnVehiculos)
        Me.Panel1.Controls.Add(Me.btnClientes)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(281, 719)
        Me.Panel1.TabIndex = 0
        '
        'btnSistema
        '
        Me.btnSistema.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSistema.ForeColor = System.Drawing.Color.White
        Me.btnSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSistema.Location = New System.Drawing.Point(12, 608)
        Me.btnSistema.Name = "btnSistema"
        Me.btnSistema.Size = New System.Drawing.Size(243, 75)
        Me.btnSistema.TabIndex = 16
        Me.btnSistema.Text = "Sistema"
        Me.btnSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSistema.UseVisualStyleBackColor = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUsuarios.Location = New System.Drawing.Point(12, 527)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(243, 75)
        Me.btnUsuarios.TabIndex = 15
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.White
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReportes.Location = New System.Drawing.Point(12, 446)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(243, 75)
        Me.btnReportes.TabIndex = 14
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'btnDevolver
        '
        Me.btnDevolver.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDevolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDevolver.ForeColor = System.Drawing.Color.White
        Me.btnDevolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDevolver.Location = New System.Drawing.Point(12, 365)
        Me.btnDevolver.Name = "btnDevolver"
        Me.btnDevolver.Size = New System.Drawing.Size(243, 75)
        Me.btnDevolver.TabIndex = 13
        Me.btnDevolver.Text = "Devolver"
        Me.btnDevolver.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDevolver.UseVisualStyleBackColor = False
        '
        'btnRentar
        '
        Me.btnRentar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRentar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRentar.ForeColor = System.Drawing.Color.White
        Me.btnRentar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRentar.Location = New System.Drawing.Point(12, 284)
        Me.btnRentar.Name = "btnRentar"
        Me.btnRentar.Size = New System.Drawing.Size(243, 75)
        Me.btnRentar.TabIndex = 12
        Me.btnRentar.Text = "Rentar"
        Me.btnRentar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRentar.UseVisualStyleBackColor = False
        '
        'btnVehiculos
        '
        Me.btnVehiculos.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVehiculos.ForeColor = System.Drawing.Color.White
        Me.btnVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVehiculos.Location = New System.Drawing.Point(12, 203)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Size = New System.Drawing.Size(243, 75)
        Me.btnVehiculos.TabIndex = 11
        Me.btnVehiculos.Text = "Vehículos"
        Me.btnVehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnVehiculos.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientes.Location = New System.Drawing.Point(12, 122)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(243, 75)
        Me.btnClientes.TabIndex = 10
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(34, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Azure
        Me.Panel2.Controls.Add(Me.LabelTop)
        Me.Panel2.Controls.Add(Me.btnSesion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(281, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(970, 76)
        Me.Panel2.TabIndex = 1
        '
        'LabelTop
        '
        Me.LabelTop.AutoSize = True
        Me.LabelTop.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTop.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LabelTop.Location = New System.Drawing.Point(354, 31)
        Me.LabelTop.Name = "LabelTop"
        Me.LabelTop.Size = New System.Drawing.Size(195, 27)
        Me.LabelTop.TabIndex = 6
        Me.LabelTop.Text = "Acceso al Sistema"
        Me.LabelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSesion
        '
        Me.btnSesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSesion.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSesion.ForeColor = System.Drawing.Color.White
        Me.btnSesion.Location = New System.Drawing.Point(800, 12)
        Me.btnSesion.Name = "btnSesion"
        Me.btnSesion.Size = New System.Drawing.Size(158, 46)
        Me.btnSesion.TabIndex = 5
        Me.btnSesion.Text = "Cerrar Sesión"
        Me.btnSesion.UseVisualStyleBackColor = False
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.Lavender
        Me.PanelPrincipal.BackgroundImage = CType(resources.GetObject("PanelPrincipal.BackgroundImage"), System.Drawing.Image)
        Me.PanelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(281, 76)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(970, 643)
        Me.PanelPrincipal.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.lbNombreUsuario, Me.lbIdUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(281, 697)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(970, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 20)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'lbNombreUsuario
        '
        Me.lbNombreUsuario.Name = "lbNombreUsuario"
        Me.lbNombreUsuario.Size = New System.Drawing.Size(49, 17)
        Me.lbNombreUsuario.Text = "nombre"
        '
        'lbIdUsuario
        '
        Me.lbIdUsuario.Name = "lbIdUsuario"
        Me.lbIdUsuario.Size = New System.Drawing.Size(13, 17)
        Me.lbIdUsuario.Text = "0"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 719)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proudly RENT A CAR"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSistema As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnDevolver As Button
    Friend WithEvents btnRentar As Button
    Friend WithEvents btnVehiculos As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents lbNombreUsuario As ToolStripStatusLabel
    Friend WithEvents lbIdUsuario As ToolStripStatusLabel
    Friend WithEvents btnSesion As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelTop As Label
End Class
