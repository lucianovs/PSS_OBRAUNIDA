<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOcupacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOcupacoes))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnIncluir = New System.Windows.Forms.ToolStripButton()
        Me.btnAlterar = New System.Windows.Forms.ToolStripButton()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGravar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAnterior = New System.Windows.Forms.ToolStripButton()
        Me.btnProximo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLocalizar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssContReg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblDataAlteracao = New System.Windows.Forms.Label()
        Me.cbSituacaoCadastro = New System.Windows.Forms.ComboBox()
        Me.lblSituacao = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnIncluir, Me.btnAlterar, Me.btnExcluir, Me.ToolStripSeparator1, Me.btnGravar, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnAnterior, Me.btnProximo, Me.ToolStripSeparator2, Me.btnLocalizar, Me.btnImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(449, 39)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnIncluir
        '
        Me.btnIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnIncluir.Image = CType(resources.GetObject("btnIncluir.Image"), System.Drawing.Image)
        Me.btnIncluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(36, 36)
        Me.btnIncluir.Text = "Incluir"
        '
        'btnAlterar
        '
        Me.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(36, 36)
        Me.btnAlterar.Text = "Alterar"
        '
        'btnExcluir
        '
        Me.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(36, 36)
        Me.btnExcluir.Text = "Excluir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnGravar
        '
        Me.btnGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(36, 36)
        Me.btnGravar.Text = "Gravar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(36, 36)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'btnAnterior
        '
        Me.btnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(36, 36)
        Me.btnAnterior.Text = "Anterior"
        '
        'btnProximo
        '
        Me.btnProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnProximo.Image = CType(resources.GetObject("btnProximo.Image"), System.Drawing.Image)
        Me.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(36, 36)
        Me.btnProximo.Text = "Próximo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnLocalizar
        '
        Me.btnLocalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLocalizar.Image = CType(resources.GetObject("btnLocalizar.Image"), System.Drawing.Image)
        Me.btnLocalizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(36, 36)
        Me.btnLocalizar.Text = "Localizar"
        '
        'btnImprimir
        '
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(36, 36)
        Me.btnImprimir.Text = "Imprimir"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(13, 61)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "Código:"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.ForeColor = System.Drawing.Color.Red
        Me.lblDescricao.Location = New System.Drawing.Point(13, 98)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(58, 13)
        Me.lblDescricao.TabIndex = 3
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(62, 60)
        Me.txtCodigo.MaxLength = 8
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(63, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.Location = New System.Drawing.Point(77, 98)
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(291, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssContReg})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 256)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(449, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssContReg
        '
        Me.tssContReg.Name = "tssContReg"
        Me.tssContReg.Size = New System.Drawing.Size(78, 17)
        Me.tssContReg.Text = "Registro n / n"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(116, 173)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(136, 20)
        Me.DateTimePicker1.TabIndex = 24
        '
        'lblDataAlteracao
        '
        Me.lblDataAlteracao.AutoSize = True
        Me.lblDataAlteracao.Location = New System.Drawing.Point(13, 173)
        Me.lblDataAlteracao.Name = "lblDataAlteracao"
        Me.lblDataAlteracao.Size = New System.Drawing.Size(96, 13)
        Me.lblDataAlteracao.TabIndex = 23
        Me.lblDataAlteracao.Text = "Data da Alteração:"
        '
        'cbSituacaoCadastro
        '
        Me.cbSituacaoCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSituacaoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSituacaoCadastro.FormattingEnabled = True
        Me.cbSituacaoCadastro.Items.AddRange(New Object() {"ATIVO", "INATIVO", "EXCLUÍDO"})
        Me.cbSituacaoCadastro.Location = New System.Drawing.Point(131, 137)
        Me.cbSituacaoCadastro.Name = "cbSituacaoCadastro"
        Me.cbSituacaoCadastro.Size = New System.Drawing.Size(121, 21)
        Me.cbSituacaoCadastro.TabIndex = 22
        '
        'lblSituacao
        '
        Me.lblSituacao.AutoSize = True
        Me.lblSituacao.Location = New System.Drawing.Point(13, 137)
        Me.lblSituacao.Name = "lblSituacao"
        Me.lblSituacao.Size = New System.Drawing.Size(112, 13)
        Me.lblSituacao.TabIndex = 21
        Me.lblSituacao.Text = "Situação do Cadastro:"
        '
        'frmOcupacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 278)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblDataAlteracao)
        Me.Controls.Add(Me.cbSituacaoCadastro)
        Me.Controls.Add(Me.lblSituacao)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOcupacoes"
        Me.Text = "Ocupação"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnIncluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAlterar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGravar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAnterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnProximo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnLocalizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssContReg As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDataAlteracao As System.Windows.Forms.Label
    Friend WithEvents cbSituacaoCadastro As System.Windows.Forms.ComboBox
    Friend WithEvents lblSituacao As System.Windows.Forms.Label
End Class
