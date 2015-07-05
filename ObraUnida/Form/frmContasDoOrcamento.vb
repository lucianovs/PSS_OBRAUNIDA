Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class frmContasDoOrcamento
    '?? Alterar para a Entidade Principal ??
    Dim dt As DataTable = New DataTable("EUN023")

    Dim i As Integer
    Dim bAlterar As Boolean = False
    Dim bIncluir As Boolean = False
    Dim cQuery As String

    Private Sub frmContasDoOrcamento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        g_Param(1) = txtCodigo.Text 'Voltar com a Chave do registro do formulário
        g_AtuBrowse = True
    End Sub

    Private Sub frmContasDoOrcamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Criar um adaptador que vai fazer o download de dados da base de dados
        '?? Alterar o Código para a Entidade Principal ??
        cQuery = "SELECT * FROM EUN023 where UN023_CODCTA = "
        If g_Comando = "incluir" Then
            cQuery += "0"
        Else
            cQuery += IIf(g_Param(1) = "INSERT", "0", g_Param(1)).ToString()
        End If
        Using da As New OleDbDataAdapter()
            da.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)
            ' Preencher o DataTable 
            da.Fill(dt)
        End Using
        i = 0

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

        TratarObjetos()
    End Sub

    Private Sub TratarObjetos()

        tssContReg.Text = "Registro " & (i + 1).ToString & "/" & dt.Rows.Count().ToString

        'Botoes da Barra de comandos
        btnIncluir.Enabled = Not bAlterar And Me.Tag = 4 'And Me.Tag > 1
        btnAlterar.Enabled = Not bAlterar 'And Me.Tag > 1
        btnExcluir.Enabled = Not bAlterar And Me.Tag = 4
        btnGravar.Enabled = bAlterar
        btnCancelar.Enabled = bAlterar
        btnAnterior.Enabled = Not bAlterar
        btnProximo.Enabled = Not bAlterar
        btnLocalizar.Enabled = Not bAlterar
        btnImprimir.Enabled = Not bAlterar

        'Campos
        '?? Alterar para os seus objetos da Tela ??
        lblCodigo.Enabled = False
        lblDescricao.Enabled = bAlterar
        txtCodigo.Enabled = False
        txtDescricao.Enabled = bAlterar
        cbTipoConta.Enabled = bAlterar
        cbSituacaoCadastro.Enabled = bAlterar
        dtpDataAlteracao.Enabled = bAlterar
        txtLoginUsuarioAlteracao.Enabled = bAlterar

        Dim situacao As String
        'Preencher Campos
        If i > -1 And Not bIncluir And Not dt.Rows.Count = 0 Then
            txtCodigo.Text = dt.Rows(i).Item("UN023_CODCTA")
            txtDescricao.Text = dt.Rows(i).Item("UN023_DESCTA")
            cbTipoConta.Text = IIf(dt.Rows(i).Item("UN023_TIPCTA") = "R", "RECEITA", "DESPESA")

            situacao = dt.Rows(i).Item("UN023_SITCAD")

            If (situacao = "A") Then
                situacao = "ATIVO"
            ElseIf (situacao = "I") Then
                situacao = "INATIVO"
            ElseIf (situacao = "E") Then
                situacao = "EXCLUÍDO"
            End If

            cbSituacaoCadastro.Text = situacao
            dtpDataAlteracao.Text = dt.Rows(i).Item("UN023_DATALT")
            txtLoginUsuarioAlteracao.Text = dt.Rows(i).Item("UN023_USUALT")

            'Verificar se é para excluir o registro comandado pelo browse
            If g_Comando = "excluir" Then
                Call Excluir_Registro()
            End If
        ElseIf bIncluir Then
            Call btnIncluir_Click(Nothing, New System.EventArgs())
        End If

    End Sub

    Private Sub btnProximo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProximo.Click

        i += 1
        If Not i = dt.Rows.Count() Then
            Call TratarObjetos()
        Else
            i = dt.Rows.Count() - 1
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

        dt.Clear()
        Me.Close()

    End Sub

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        bAlterar = True
        bIncluir = True

        'Inicializar os seus Componentes de Entrada de Dados
        txtCodigo.Text = "auto"
        txtDescricao.Text = ""

        If Not g_Comando = "incluir" Then Call TratarObjetos()


    End Sub

    Private Sub btnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravar.Click
        Dim cSql As String = ""
        Dim cMensagem As String = ""
        Dim cmd As OleDbCommand

        Dim Situacao As String

        If cbSituacaoCadastro.SelectedItem = "ATIVO" Then
            Situacao = "A"
        ElseIf cbSituacaoCadastro.SelectedItem = "INATIVO" Then
            Situacao = "I"
        Else
            Situacao = "E"
        End If

        Dim TipoConta As String

        If cbTipoConta.SelectedItem = "RECEITA" Then
            TipoConta = "R"
        Else
            TipoConta = "D"
        End If


        If ConectarBanco() Then
            '?? Colocar o Comando SQL para Gravar (Update e Insert)
            If bIncluir Then

                cSql = "INSERT INTO EUN023(" & _
                    "UN023_CODCTA," & _
                    "UN023_DESCTA," & _
                    "UN023_TIPCTA," & _
                    "UN023_SITCAD," & _
                    "UN023_DATALT," & _
                    "UN023_USUALT)"
                cSql += " values (" &
                    Integer.Parse(
                    ProxCodChave("EUN023", "UN023_CODCTA")) & _
                    ",'" & txtDescricao.Text & "'" & _
                    ", '" & TipoConta & "'" & _
                    ", '" & Situacao & "'" & _
                    ", '" & dtpDataAlteracao.Text & "'" & _
                    ", '" & txtLoginUsuarioAlteracao.Text & "')"

            ElseIf bAlterar Then
                cSql = "UPDATE EUN023 set UN023_DESCTA='" & txtDescricao.Text & "'" & _
                ", UN023_TIPCTA ='" & TipoConta & "'" & _
                ", UN023_SITCAD ='" & Situacao & "'" & _
                ", UN023_DATALT='" & dtpDataAlteracao.Text & "'" & _
                ", UN023_USUALT='" & txtLoginUsuarioAlteracao.Text & "'" & _
                 " WHERE UN023_CODCTA = " & Integer.Parse(txtCodigo.Text)
                'acessoWEB=" & If(chkSIM.Checked = 0, False, True)
            End If
            cmd = New OleDbCommand(cSql, g_ConnectBanco)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                bIncluir = False
                bAlterar = False

                If bIncluir Then
                    dt.Clear()
                    'fechar o form de cadastro
                    Me.Close()
                Else
                    dt.Reset()
                    Using da As New OleDbDataAdapter()
                        da.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

                        ' Preencher o DataTable 
                        da.Fill(dt)
                    End Using
                    'Verificar se o comando veio do browse
                    If bIncluir Or bAlterar Then
                        dt.Clear()
                        Me.Close()
                    Else
                        TratarObjetos()
                    End If
                End If
            End Try
        Else
            MsgBox(cMensagem)
        End If

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Call Excluir_Registro()

    End Sub

    Private Sub Excluir_Registro()
        Dim cSql As String
        Dim cMensagem As String = ""
        Dim cmd As OleDbCommand

        If MsgBox("Deseja excluir este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "cadastro de Usuarios") = MsgBoxResult.Yes Then
            '?? Alterar para a Tabela a ser Excluída ??
            cSql = "DELETE FROM EUN023 where UN023_CODCTA = " & Integer.Parse(txtCodigo.Text)
            cmd = New OleDbCommand(cSql, g_ConnectBanco)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally

                dt.Reset()
                Using da As New OleDbDataAdapter()
                    da.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

                    'Preencher o DataTable 
                    da.Fill(dt)
                End Using

                If i > dt.Rows.Count() - 1 Then
                    i = dt.Rows.Count() - 1
                End If

                'Verificar se o comando veio do browse
                If g_Comando = "excluir" Then
                    dt.Clear() 'Limpar o DataTable
                    Me.Close()
                Else
                    TratarObjetos()
                End If
            End Try
        Else
            dt.Clear() 'Limpar o DataTable
            Me.Close()
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
        Dim FormCheckBox As CheckBox
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

        margemEsq = 5
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
            ElseIf (TypeOf FormControl Is CheckBox) Then
                FormCheckBox = FormControl
                posicaoDaLinha = margemSup + (((FormCheckBox.TabIndex * 2) + LinhaAdic) * fonteNormal.GetHeight(Relatorio.Graphics))
                Relatorio.Graphics.DrawString(FormCheckBox.Text & " - " & IIf(FormCheckBox.Checked, "SIM", "NÃO"), fonteNormal, Brushes.Black, margemEsq + 150, posicaoDaLinha, New StringFormat())
            End If
        Next

        'imprime o rodape no relatorio
        Relatorio.Graphics.DrawLine(Pens.Black, margemEsq, margemInf, margemDir, margemInf)
        Relatorio.Graphics.DrawString(System.DateTime.Now, fonteRodape, Brushes.Black, margemEsq, margemInf, New StringFormat())
        Relatorio.Graphics.DrawString("Formulário", fonteRodape, Brushes.Black, margemDir - 50, margemInf, New StringFormat())

        Relatorio.HasMorePages = False

    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        dt.Clear() 'Limpar o DataTable

        Me.Close()
    End Sub
End Class

