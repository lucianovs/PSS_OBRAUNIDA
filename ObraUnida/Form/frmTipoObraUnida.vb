Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class frmTipoObraUnida
    '?? Alterar para a Entidade Principal ??
    Dim dtCadastro As DataTable = New DataTable("EUN009")

    Dim i As Integer
    Dim bAlterar As Boolean = False
    Dim bIncluir As Boolean = False
    Dim cQueryCadastro As String
    Dim cCampos As String
    Dim cValorCampos As String
    Dim nCodUsuario As Integer
    Dim nPermissao As Integer

    Private Sub frmTipoObraUnida_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        g_Param(1) = txtCodigo.Text 'Voltar com a Chave do registro do formulário
        g_AtuBrowse = True
        g_Comando = "REFRESH" 'Forçar a atualização do browser pelo timer
    End Sub

    Private Sub frmTipoObraUnida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nCodUsuario = getCodUsuario(ClassCrypt.Decrypt(g_Login))

        'Criar um adaptador que vai fazer o download de dados da base de dados
        '?? Alterar o Código para a Entidade Principal ??

        cQueryCadastro = "SELECT * FROM EUN009 where UN009_TIPOBR = " '& g_Param(1) 'Parametro global do c

        If g_Comando = "incluir" Then
            cQueryCadastro += "0"
        Else
            cQueryCadastro += g_Param(1)
        End If

        Using da As New OleDbDataAdapter()
            da.SelectCommand = New OleDbCommand(cQueryCadastro, g_ConnectBanco)

            ' Preencher o DataTable 
            da.Fill(dtCadastro)
        End Using

        If g_Param(1) <> "INSERT" Then
            'Posicionar no registro selecionado
            'Iniciar com o comando passado
            
            If g_Comando = "incluir" Then
                bIncluir = True
                bAlterar = True
            ElseIf g_Comando = "alterar" Then
                bIncluir = False
                bAlterar = True
            Else
                bIncluir = False
                bAlterar = False
            End If
        Else
            bIncluir = True
            bAlterar = True
        End If

        Call TratarObjetos()
    End Sub

    Private Sub TratarObjetos()
        
        tssContReg.Text = "Registro " & (i + 1).ToString & "/" & dtCadastro.Rows.Count().ToString

        'Botoes da Barra de comandos
        btnIncluir.Enabled = False 'Not bAlterar And Me.Tag = 4 'And Me.Tag > 1
        btnAlterar.Enabled = Not bAlterar And Me.Tag > 1
        btnExcluir.Enabled = Not bAlterar And Me.Tag > 2
        btnGravar.Enabled = bAlterar
        btnCancelar.Enabled = bAlterar
        btnAnterior.Enabled = False 'Not bAlterar
        btnProximo.Enabled = False 'Not bAlterar
        btnLocalizar.Enabled = Not bAlterar
        btnImprimir.Enabled = Not bAlterar

        'Campos
        '?? Alterar para os seus objetos da Tela ??
        lblCodigo.Enabled = False
        lblDescricao.Enabled = bAlterar

        txtCodigo.Enabled = False
        txtDescricao.Enabled = bAlterar
        
        
        'Preencher Campos e Armazenar os dados do formulário para gravar o log
        If i > -1 And Not bIncluir Then
            txtCodigo.Text = dtCadastro.Rows(i).Item("UN009_TIPOBR")
            txtDescricao.Text = IIf(IsDBNull(dtCadastro.Rows(i).Item("UN009_DESTIP")), "", dtCadastro.Rows(i).Item("UN009_DESTIP").ToString())
           
        End If

        'Verificar se é para excluir o registro - comandado pelo browse
        If g_Comando = "excluir" Then
            Call Excluir_Registro()
        End If

    End Sub

    

    Private Sub btnProximo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProximo.Click

        i += 1
        If Not i = dtCadastro.Rows.Count() Then
            Call TratarObjetos()
        Else
            i = dtCadastro.Rows.Count() - 1
        End If

    End Sub

    Private Sub btnAnterior_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnterior.Click

        i -= 1
        If Not i < 0 Then
            Call TratarObjetos()
        Else
            i = 0
        End If

    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click

        bAlterar = True
        Call TratarObjetos()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If g_Comando = "inserir" Or g_Comando = "alterar" Then
            dtCadastro.Clear()
            Me.Close()
        Else
            bAlterar = False
            bIncluir = False
            TratarObjetos()
        End If
    End Sub

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        bAlterar = True
        bIncluir = True

        'Inicializar os seus Componentes de Entrada de Dados
        txtCodigo.Text = ""
        txtDescricao.Text = ""
        
        Call TratarObjetos()

    End Sub

    Private Sub btnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravar.Click
        Dim cSql As String = ""
        Dim cMensagem As String = ""
        Dim cmd As OleDbCommand

        If Validardados(cMensagem) Then
            If ConectarBanco() Then
                '?? Colocar o Comando SQL para Gravar (Update e Insert)
                If bIncluir Then
                    cSql = "INSERT INTO EUN009(UN009_TIPOBR, UN009_DESTIP) "
                    cSql += " values (" & Integer.Parse(ProxCodChave("EUN009", "UN009_TIPOBR")) & ", '" & txtDescricao.Text & "')"

                    
                ElseIf bAlterar Then
                    cSql = "UPDATE EUN009 set UN009_DESTIP = '" & txtDescricao.Text & "' "                
                    cSql += " where UN009_TIPOBR = " & Integer.Parse(txtCodigo.Text)
                End If

                cmd = New OleDbCommand(cSql, g_ConnectBanco)

                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString())
                Finally
                    
                    bIncluir = False
                    bAlterar = False

                    If g_Param(1) = "INSERT" Then
                        dtCadastro.Clear()
                        'fechar o form de cadastro
                        Me.Close()
                    Else
                        dtCadastro.Reset()
                        Using da As New OleDbDataAdapter()
                            da.SelectCommand = New OleDbCommand(cQueryCadastro, g_ConnectBanco)

                            ' Preencher o DataTable 
                            da.Fill(dtCadastro)
                        End Using
                        'Verificar se o comando veio do browse
                        If g_Comando = "incluir" Or g_Comando = "alterar" Then
                            dtCadastro.Clear()
                            Me.Close()
                        Else
                            TratarObjetos()
                        End If
                    End If
                End Try
            Else
                MsgBox("Erro ao conectar com o banco de Dados!!")
            End If
        Else
            MsgBox(cMensagem)
        End If

    End Sub

    Private Function Validardados(ByRef cMensagem As String) As Boolean
        Dim bRetorno As Boolean = True

        '?? Acrescentar as validações da Tela ??
        If Trim(txtDescricao.Text) = "" Then
            cMensagem += " <A Descrição do tipo não pode estar vazia> "
            bRetorno = False
        End If
        
        Return (bRetorno)

    End Function

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Call Excluir_Registro()

    End Sub

    Private Sub Excluir_Registro()
        Dim cSql As String
        Dim sMensagem As String = ""
        Dim cmd As OleDbCommand
        Dim bPodeExcluir As Boolean

        bPodeExcluir = GetPermissaoExcluirUnidade(Double.Parse(txtCodigo.Text), sMensagem)

        If bPodeExcluir Then
            If MsgBox("Deseja excluir este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '?? Alterar para a Tabela a ser Excluída ??
                cSql = "DELETE FROM EUN009 where UN009_TIPOBR = " & Integer.Parse(txtCodigo.Text)


                cmd = New OleDbCommand(cSql, g_ConnectBanco)

                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString())
                Finally
                    dtCadastro.Reset()
                    Using da As New OleDbDataAdapter()
                        da.SelectCommand = New OleDbCommand(cQueryCadastro, g_ConnectBanco)

                        'Preencher o DataTable 
                        da.Fill(dtCadastro)
                    End Using

                    If i > dtCadastro.Rows.Count() - 1 Then
                        i = dtCadastro.Rows.Count() - 1
                    End If
                    'Verificar se o comando veio do browse
                    If g_Comando = "excluir" Then
                        dtCadastro.Clear() 'Limpar o DataTable
                        Me.Close()
                    Else
                        TratarObjetos()
                    End If
                End Try
            End If
        Else
            MsgBox(sMensagem)
        End If

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        'cria um novo documento para impressão
        Dim pd As PrintDocument = New PrintDocument()

        'relaciona o objeto pd ao procedimento rptProdutos
        AddHandler pd.PrintPage, AddressOf Me.rptFormulario

        'cria uma nova instância do objeto PrintPreviewDialog()
        Dim objPrintPreview = New PrintPreviewDialog()

        'define algumas propriedades do obejto
        With objPrintPreview
            'indica qual o documento vai ser visualizado
            .Document = pd
            .WindowState = FormWindowState.Maximized
            .PrintPreviewControl.Zoom = 1   'maxima a visualização
            .Text = Me.Text
            'exibe a janela de visualização para o usuário
            .ShowDialog()
        End With

    End Sub

    Private Sub rptFormulario(ByVal sender As Object, ByVal Relatorio As System.Drawing.Printing.PrintPageEventArgs)
        Dim FormControl As Control
        Dim FormListBox As ListBox
        Dim pLinhaList As String

        Dim LinhasPorPagina As Integer
        Dim LinhaAdic As Integer
        Dim posicaoDaLinha As Integer
        Dim y As Integer

        Dim margemEsq As Single = Relatorio.MarginBounds.Left
        Dim margemSup As Single = Relatorio.MarginBounds.Top
        Dim margemDir As Single = Relatorio.MarginBounds.Right
        Dim margemInf As Single = Relatorio.MarginBounds.Bottom

        Dim fonteTitulo As Font
        Dim fonteRodape As Font
        Dim fonteNormal As Font

        fonteTitulo = New Font("Verdana", 15, FontStyle.Bold)
        fonteRodape = New Font("Verdana", 8)
        fonteNormal = New Font("Verdana", 10)

        LinhasPorPagina = Relatorio.MarginBounds.Height / fonteNormal.GetHeight(Relatorio.Graphics) - 10

        margemEsq = 10
        'Imprimir o Cabeçalho
        Relatorio.Graphics.DrawLine(Pens.Black, margemEsq, 40, margemDir, 40)
        Relatorio.Graphics.DrawImage(Image.FromFile("logo.png"), 10, 48)
        Relatorio.Graphics.DrawString(Me.Text, fonteTitulo, Brushes.Blue, margemEsq + 275, 80, New StringFormat())
        Relatorio.Graphics.DrawLine(Pens.Black, margemEsq, 145, margemDir, 145)
        LinhaAdic = 2

        For Each FormControl In Me.Controls
            If (TypeOf FormControl Is Label) Then
                posicaoDaLinha = margemSup + (((FormControl.TabIndex * 2) + LinhaAdic) * fonteNormal.GetHeight(Relatorio.Graphics))
                Relatorio.Graphics.DrawString(FormControl.Text, fonteNormal, Brushes.Black, margemEsq, posicaoDaLinha, New StringFormat())
            ElseIf (TypeOf FormControl Is TextBox) Or (TypeOf FormControl Is ComboBox) Then
                posicaoDaLinha = margemSup + (((FormControl.TabIndex * 2) + LinhaAdic) * fonteNormal.GetHeight(Relatorio.Graphics))
                Relatorio.Graphics.DrawString(FormControl.Text, fonteNormal, Brushes.Black, margemEsq + 150, posicaoDaLinha, New StringFormat())
            ElseIf (TypeOf FormControl Is DateTimePicker) Then

                posicaoDaLinha = margemSup + (((FormControl.TabIndex * 2) + LinhaAdic) * fonteNormal.GetHeight(Relatorio.Graphics))
                Relatorio.Graphics.DrawString(FormControl.Text, fonteNormal, Brushes.Black, margemEsq + 150, posicaoDaLinha, New StringFormat())
            ElseIf (TypeOf FormControl Is ListBox) Then
                FormListBox = FormControl
                posicaoDaLinha = margemSup + (((FormListBox.TabIndex * 2) + LinhaAdic) * fonteNormal.GetHeight(Relatorio.Graphics))
                pLinhaList = ""
                For y = 0 To FormListBox.Items.Count - 1
                    If Trim(FormListBox.Items(y).ToString) = "" Then Exit For
                    pLinhaList += "(" & FormListBox.Items(y).ToString & ") "
                Next
                Relatorio.Graphics.DrawString(pLinhaList, fonteNormal, Brushes.Black, margemEsq + 150, posicaoDaLinha, New StringFormat())
            End If
        Next

        'imprime o rodape no relatorio
        Relatorio.Graphics.DrawLine(Pens.Black, margemEsq, margemInf, margemDir, margemInf)
        Relatorio.Graphics.DrawString(System.DateTime.Now, fonteRodape, Brushes.Black, margemEsq, margemInf, New StringFormat())
        Relatorio.Graphics.DrawString("Formulário", fonteRodape, Brushes.Black, margemDir - 50, margemInf, New StringFormat())

        Relatorio.HasMorePages = False
    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        dtCadastro.Clear() 'Limpar o DataTable

        Me.Close()
    End Sub

End Class