﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.menuCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuProcessos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConsultas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRelatorios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSistema = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConfiguracoes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sair = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ajuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCadastro, Me.menuProcessos, Me.menuConsultas, Me.menuRelatorios, Me.menuSistema, Me.Ajuda})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.MdiWindowListItem = Me.menuSistema
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(996, 28)
        Me.MenuPrincipal.TabIndex = 0
        Me.MenuPrincipal.Text = "MenuPrincipal"
        '
        'menuCadastro
        '
        Me.menuCadastro.Name = "menuCadastro"
        Me.menuCadastro.Size = New System.Drawing.Size(86, 24)
        Me.menuCadastro.Text = "&Cadastros"
        '
        'menuProcessos
        '
        Me.menuProcessos.Name = "menuProcessos"
        Me.menuProcessos.Size = New System.Drawing.Size(85, 24)
        Me.menuProcessos.Text = "Processos"
        '
        'menuConsultas
        '
        Me.menuConsultas.Name = "menuConsultas"
        Me.menuConsultas.Size = New System.Drawing.Size(84, 24)
        Me.menuConsultas.Text = "Consultas"
        '
        'menuRelatorios
        '
        Me.menuRelatorios.Name = "menuRelatorios"
        Me.menuRelatorios.Size = New System.Drawing.Size(88, 24)
        Me.menuRelatorios.Text = "&Relatórios"
        '
        'menuSistema
        '
        Me.menuSistema.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuConfiguracoes, Me.ToolStripMenuItem1, Me.menuUsuarios, Me.Sair})
        Me.menuSistema.Name = "menuSistema"
        Me.menuSistema.Size = New System.Drawing.Size(73, 24)
        Me.menuSistema.Text = "&Sistema"
        '
        'menuConfiguracoes
        '
        Me.menuConfiguracoes.Name = "menuConfiguracoes"
        Me.menuConfiguracoes.Size = New System.Drawing.Size(173, 24)
        Me.menuConfiguracoes.Text = "Configurações"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(170, 6)
        '
        'menuUsuarios
        '
        Me.menuUsuarios.Name = "menuUsuarios"
        Me.menuUsuarios.Size = New System.Drawing.Size(173, 24)
        Me.menuUsuarios.Text = "Usuários"
        '
        'Sair
        '
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(173, 24)
        Me.Sair.Text = "Sair"
        '
        'Ajuda
        '
        Me.Ajuda.Name = "Ajuda"
        Me.Ajuda.Size = New System.Drawing.Size(60, 24)
        Me.Ajuda.Text = "&Ajuda"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 456)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(996, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 478)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.Name = "frmPrincipal"
        Me.Text = "Descrição do módulo"
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents menuSistema As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuConfiguracoes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Sair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCadastro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuProcessos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuConsultas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRelatorios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ajuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip

End Class
