Imports System.Reflection
Imports System.Reflection.Assembly

Public Class usrAdmInteractiControleIdioma

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsAdmInteractiControleIdioma As New clsUsrAdmInteractiControleIdioma

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrAdmInteractiControleIdioma_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click

        Try

            'Atualizando os controles
            Atualizar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub Atualizar()

        Try

            'Setando o cursor
            Cursor.Current = Cursors.WaitCursor


            'Exclui primeiro a inserção anterior
            oClsAdmInteractiControleIdioma.DeleteIdiomaControle()

            'Procurando todos os USER CONTROLS do sistema
            For Each sUsrControl In ProcuraUsrControl(Me)

                'Variaveis Locais
                Dim oUsrControl As UserControl
                'Instanciando o assembly atual
                Dim oAssembly As Assembly = GetExecutingAssembly()

                'Criando a instância do FORM
                oUsrControl = oAssembly.CreateInstance("INTERACTI." & sUsrControl)

                'Insere os dados do form
                oClsAdmInteractiControleIdioma.InsertIdiomaControle(oUsrControl, oUsrControl.Name)

            Next


            'Procurando todos os FORMS do sistema
            For Each sForm In ProcuraForm(Me)

                'Variaveis Locais
                Dim oForm As Form

                'Instanciando o assembly atual
                Dim oAssembly As Assembly = GetExecutingAssembly()

                'Criando a instância do FORM
                oForm = oAssembly.CreateInstance("INTERACTI." & sForm)

                'Insere os dados do form
                oClsAdmInteractiControleIdioma.InsertIdiomaControle(oForm, oForm.Name)

            Next

            'Informando ao usuário
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Retornando o cursor
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
