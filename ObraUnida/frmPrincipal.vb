Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class frmPrincipal
    Dim bUsarVPN As Boolean = IIf(LerDadosINI(nomeArquivoINI(), "VPN", "Ativar", "nao") = "nao", False, True)

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Argumentos() As String = Environment.GetCommandLineArgs
        Dim sNomeUsuario As String
        Dim bArguments As Boolean = True
        Dim x, y As Integer

        g_Modulo = "OBRAUNIDA"

        'Ativar os Parâmetros iniciais de Segurança
        'Resgatar as Informações da Chamada
        x = 0
        y = 0
        g_Login = ""

        If Not bUsarVPN Then
            bArguments = False
            '***** Indicar qual usuário deverá se logado automaticamente
            g_Login = ClassCrypt.Encrypt("admin")
            'g_Login = ClassCrypt.Encrypt("jose.alves")
            'g_Login = ClassCrypt.Encrypt("teste.3")
            '*****
        End If
        Try
            Do While bArguments
                If Environment.CommandLine(x) = "-" Then
                    If y = 0 Then
                        y = x
                    Else
                        bArguments = False
                    End If
                ElseIf y <> 0 Then
                    g_Login += Environment.CommandLine(x)
                End If
                x += 1
            Loop

            'MsgBox(g_Login)
            If g_Login = "" Then
                'Ativar estas Linhas quando for colocar em produção
                MsgBox("Este programa não tem permissão para ser executado. Contactar o administrador da rede!!", MsgBoxStyle.Critical)
                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox("Este programa não tem permissão para ser executado. Contactar o administrador da rede!!", MsgBoxStyle.Critical)
            Application.Exit()

        Finally
            'Conection String
            g_ConnectString = (LerDadosINI(nomeArquivoINI(), "CONEXAO", "ConnectString", _
                ClassCrypt.Encrypt("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SSVP.accdb;Persist Security Info=False;")))

            'Conectar com o Banco de dados
            If ConectarBanco() Then

                'Ler o Usuário e Validar o Acesso
                sNomeUsuario = LerUsuario(ClassCrypt.Decrypt(g_Login), Nothing)

                If sNomeUsuario <> "" Then
                    Me.Text = "Modulo " & g_Modulo & " - Usuário: " & sNomeUsuario
                Else
                    Application.Exit()
                End If

                'Verificar o acesso às opções do sistema
                Dim cModulo As Integer = getCodModulo(g_Modulo) 'Pegar o código do Módulo
                Dim nCodUsuario As Integer = getCodUsuario(ClassCrypt.Decrypt(g_Login)) 'pegar o código do usuario

                For Each _control As Object In Me.Controls
                    If TypeOf (_control) Is MenuStrip Then
                        For Each itm As ToolStripMenuItem In _control.items
                            If itm.Text <> "&Sair" And itm.Name.ToString.StartsWith("menu") Then
                                itm.Tag = NivelAcesso(nCodUsuario, cModulo, itm.Name, "")
                                itm.Enabled = itm.Tag > 0
                                'Função para Verificar os SubItens do menu
                                If itm.DropDownItems.Count > 0 Then LoopMenuItems(itm, nCodUsuario, cModulo, itm.Name)
                            End If
                        Next
                    End If
                Next
            Else
                Application.Exit()
            End If
        End Try

    End Sub

    Private Function LoopMenuItems(ByVal parent As ToolStripMenuItem, nCodUsuario As Integer, cModulo As Integer, fPrincOpcao As String) As Object
        Dim retval As Object = Nothing

        For Each child As Object In parent.DropDownItems

            'MessageBox.Show("Child : " & child.name)

            If TypeOf (child) Is ToolStripMenuItem Then
                If child.Text <> "Sair" And child.Name.ToString.StartsWith("menu") Then
                    child.Tag = NivelAcesso(nCodUsuario, cModulo, child.Name, fPrincOpcao)
                    child.Enabled = child.Tag > 0
                    If child.DropDownItems.Count > 0 Then
                        retval = LoopMenuItems(child, nCodUsuario, cModulo, child.name)
                        If Not retval Is Nothing Then Exit For
                    End If
                End If
            End If
        Next

        Return retval
    End Function

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Sair.Click
        Application.Exit()
    End Sub

    Private Sub menuConfiguracoes_Click(sender As Object, e As EventArgs) Handles menuConfiguracoes.Click
        Dim ChildForm As New Parametros

        ChildForm.MdiParent = Me
        ChildForm.Tag = menuConfiguracoes.Tag 'é gravado no tag do menu o nível de acesso
        ChildForm.Show()

    End Sub

    Private Sub menuUsuarios_Click(sender As Object, e As EventArgs) Handles menuUsuarios.Click
        '?? Alterar os parâmetros para passar ao Browse (Entudade e Form. do Cadastro) ??
        Dim frmBrowse_Usuario As frmBrowse = New frmBrowse("ESI000", "frmUsuario", , "SI000_STAUSU<>'E'")

        frmBrowse_Usuario.MdiParent = Me
        frmBrowse_Usuario.Tag = menuUsuarios.Tag 'é gravado no tag do menu o nível de acesso
        frmBrowse_Usuario.Text = menuUsuarios.Text
        frmBrowse_Usuario.Show()

    End Sub

    Private Sub ObraUnidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuTipoObraUnida.Click

        Dim frmBrowse_TipoObraUnida As frmBrowse = New frmBrowse("EUN009", "frmTipoObraUnida")

        frmBrowse_TipoObraUnida.MdiParent = Me
        frmBrowse_TipoObraUnida.Tag = menuTipoObraUnida.Tag 'é gravado no tag do menu o nível de acesso
        frmBrowse_TipoObraUnida.Text = menuTipoObraUnida.Text
        frmBrowse_TipoObraUnida.Show()




    End Sub
End Class
