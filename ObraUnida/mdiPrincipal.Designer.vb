<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiPrincipal
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
        Me.menuTipoObraUnida = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTipoDeVinculo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFuncoes = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOcupacoes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuContasDoOrcamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuUnidades = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuColaboradores = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuProcessos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFichaDeObrasUnidas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEmpregados = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuBeneficiarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMandatos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuBalancoOrcamentario = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConsultas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConsDadosObras = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRelatorios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRelObrasPorConselho = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEmpregadosPorObra = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMandatosPorObra = New System.Windows.Forms.ToolStripMenuItem()
        Me.BalancoOrcamentario = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFichaCadastral = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuPrincipal.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuPrincipal.Size = New System.Drawing.Size(632, 24)
        Me.MenuPrincipal.TabIndex = 9
        Me.MenuPrincipal.Text = "MenuPrincipal"
        '
        'menuCadastro
        '
        Me.menuCadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuTipoObraUnida, Me.menuTipoDeVinculo, Me.menuFuncoes, Me.menuOcupacoes, Me.ToolStripSeparator1, Me.menuContasDoOrcamento, Me.menuUnidades, Me.menuColaboradores})
        Me.menuCadastro.Name = "menuCadastro"
        Me.menuCadastro.Size = New System.Drawing.Size(71, 20)
        Me.menuCadastro.Text = "&Cadastros"
        '
        'menuTipoObraUnida
        '
        Me.menuTipoObraUnida.Name = "menuTipoObraUnida"
        Me.menuTipoObraUnida.Size = New System.Drawing.Size(245, 22)
        Me.menuTipoObraUnida.Text = "Tipo de Obras Unidas / Especiais"
        '
        'menuTipoDeVinculo
        '
        Me.menuTipoDeVinculo.Name = "menuTipoDeVinculo"
        Me.menuTipoDeVinculo.Size = New System.Drawing.Size(245, 22)
        Me.menuTipoDeVinculo.Text = "Tipo de Vínculo"
        '
        'menuFuncoes
        '
        Me.menuFuncoes.Name = "menuFuncoes"
        Me.menuFuncoes.Size = New System.Drawing.Size(245, 22)
        Me.menuFuncoes.Text = "Funções"
        '
        'menuOcupacoes
        '
        Me.menuOcupacoes.Name = "menuOcupacoes"
        Me.menuOcupacoes.Size = New System.Drawing.Size(245, 22)
        Me.menuOcupacoes.Text = "Ocupações"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(242, 6)
        '
        'menuContasDoOrcamento
        '
        Me.menuContasDoOrcamento.Name = "menuContasDoOrcamento"
        Me.menuContasDoOrcamento.Size = New System.Drawing.Size(245, 22)
        Me.menuContasDoOrcamento.Text = "Contas do Orçamento"
        '
        'menuUnidades
        '
        Me.menuUnidades.Name = "menuUnidades"
        Me.menuUnidades.Size = New System.Drawing.Size(245, 22)
        Me.menuUnidades.Text = "Unidades"
        '
        'menuColaboradores
        '
        Me.menuColaboradores.Name = "menuColaboradores"
        Me.menuColaboradores.Size = New System.Drawing.Size(245, 22)
        Me.menuColaboradores.Text = "Colaboradores"
        '
        'menuProcessos
        '
        Me.menuProcessos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFichaDeObrasUnidas, Me.menuEmpregados, Me.menuBeneficiarios, Me.menuMandatos, Me.menuBalancoOrcamentario})
        Me.menuProcessos.Name = "menuProcessos"
        Me.menuProcessos.Size = New System.Drawing.Size(71, 20)
        Me.menuProcessos.Text = "Processos"
        '
        'menuFichaDeObrasUnidas
        '
        Me.menuFichaDeObrasUnidas.Name = "menuFichaDeObrasUnidas"
        Me.menuFichaDeObrasUnidas.Size = New System.Drawing.Size(261, 22)
        Me.menuFichaDeObrasUnidas.Text = "Ficha de Obras Unidas ou Especiais "
        '
        'menuEmpregados
        '
        Me.menuEmpregados.Name = "menuEmpregados"
        Me.menuEmpregados.Size = New System.Drawing.Size(261, 22)
        Me.menuEmpregados.Text = "Empregados"
        '
        'menuBeneficiarios
        '
        Me.menuBeneficiarios.Name = "menuBeneficiarios"
        Me.menuBeneficiarios.Size = New System.Drawing.Size(261, 22)
        Me.menuBeneficiarios.Text = "Beneficiários"
        '
        'menuMandatos
        '
        Me.menuMandatos.Name = "menuMandatos"
        Me.menuMandatos.Size = New System.Drawing.Size(261, 22)
        Me.menuMandatos.Text = "Mandatos"
        '
        'menuBalancoOrcamentario
        '
        Me.menuBalancoOrcamentario.Name = "menuBalancoOrcamentario"
        Me.menuBalancoOrcamentario.Size = New System.Drawing.Size(261, 22)
        Me.menuBalancoOrcamentario.Text = "Balanço Orçamentário"
        '
        'menuConsultas
        '
        Me.menuConsultas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuConsDadosObras})
        Me.menuConsultas.Name = "menuConsultas"
        Me.menuConsultas.Size = New System.Drawing.Size(71, 20)
        Me.menuConsultas.Text = "Consultas"
        '
        'menuConsDadosObras
        '
        Me.menuConsDadosObras.Name = "menuConsDadosObras"
        Me.menuConsDadosObras.Size = New System.Drawing.Size(237, 22)
        Me.menuConsDadosObras.Text = "Consulta dos Dados das Obras "
        '
        'menuRelatorios
        '
        Me.menuRelatorios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuRelObrasPorConselho, Me.menuEmpregadosPorObra, Me.menuMandatosPorObra, Me.BalancoOrcamentario, Me.menuFichaCadastral})
        Me.menuRelatorios.Name = "menuRelatorios"
        Me.menuRelatorios.Size = New System.Drawing.Size(71, 20)
        Me.menuRelatorios.Text = "&Relatórios"
        '
        'menuRelObrasPorConselho
        '
        Me.menuRelObrasPorConselho.Name = "menuRelObrasPorConselho"
        Me.menuRelObrasPorConselho.Size = New System.Drawing.Size(289, 22)
        Me.menuRelObrasPorConselho.Text = "Relatório das Obras Unidas Por Conselho"
        '
        'menuEmpregadosPorObra
        '
        Me.menuEmpregadosPorObra.Name = "menuEmpregadosPorObra"
        Me.menuEmpregadosPorObra.Size = New System.Drawing.Size(289, 22)
        Me.menuEmpregadosPorObra.Text = "Empregados por Obra"
        '
        'menuMandatosPorObra
        '
        Me.menuMandatosPorObra.Name = "menuMandatosPorObra"
        Me.menuMandatosPorObra.Size = New System.Drawing.Size(289, 22)
        Me.menuMandatosPorObra.Text = "Mandatos por Obra"
        '
        'BalancoOrcamentario
        '
        Me.BalancoOrcamentario.Name = "BalancoOrcamentario"
        Me.BalancoOrcamentario.Size = New System.Drawing.Size(289, 22)
        Me.BalancoOrcamentario.Text = "Balanço Orçamentário"
        '
        'menuFichaCadastral
        '
        Me.menuFichaCadastral.Name = "menuFichaCadastral"
        Me.menuFichaCadastral.Size = New System.Drawing.Size(289, 22)
        Me.menuFichaCadastral.Text = "Ficha Cadastral"
        '
        'menuSistema
        '
        Me.menuSistema.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuConfiguracoes, Me.ToolStripMenuItem1, Me.menuUsuarios, Me.Sair})
        Me.menuSistema.Name = "menuSistema"
        Me.menuSistema.Size = New System.Drawing.Size(60, 20)
        Me.menuSistema.Text = "&Sistema"
        '
        'menuConfiguracoes
        '
        Me.menuConfiguracoes.Name = "menuConfiguracoes"
        Me.menuConfiguracoes.Size = New System.Drawing.Size(152, 22)
        Me.menuConfiguracoes.Text = "Configurações"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'menuUsuarios
        '
        Me.menuUsuarios.Name = "menuUsuarios"
        Me.menuUsuarios.Size = New System.Drawing.Size(152, 22)
        Me.menuUsuarios.Text = "Usuários"
        '
        'Sair
        '
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(152, 22)
        Me.Sair.Text = "Sair"
        '
        'Ajuda
        '
        Me.Ajuda.Name = "Ajuda"
        Me.Ajuda.Size = New System.Drawing.Size(50, 20)
        Me.Ajuda.Text = "&Ajuda"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'mdiPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.IsMdiContainer = True
        Me.Name = "mdiPrincipal"
        Me.Text = "Módulo Obras Unidas"
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents menuCadastro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTipoObraUnida As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuProcessos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuConsultas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRelatorios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSistema As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuConfiguracoes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Sair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ajuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents menuTipoDeVinculo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFuncoes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOcupacoes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuContasDoOrcamento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuUnidades As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuColaboradores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFichaDeObrasUnidas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEmpregados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuBeneficiarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuMandatos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuBalancoOrcamentario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuConsDadosObras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRelObrasPorConselho As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEmpregadosPorObra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuMandatosPorObra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BalancoOrcamentario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFichaCadastral As System.Windows.Forms.ToolStripMenuItem

End Class
