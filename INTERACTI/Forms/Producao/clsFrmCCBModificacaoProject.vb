Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsFrmCCBModificacaoProject

#Region "::: VARIÁVEIS :::"
    Public Enum eType
        numero = 1
        texto = 2
    End Enum

    'Capa
    Private lCodigoProjectCapa As Long
    Private iUsuario As Integer
    Private dDataInput As Date
    Private dDataInicio As Date
    Private lCodigoCB As Long


    'Linha
    Private iSequencia As Integer
    Private iNivel As Integer
    Private iAtividade As Integer
    Private sDescricaoAtividade As String
    Private iTempo As Integer
    Private sPredecessor As String
    Private iDepartamento As Integer
    Private iTipoRestricao As Integer
    Private dDataRestricao As Date
    Private dPrazoFinal As Date
    Private dPorcentagemConcluida As Double



#End Region

#Region "::: PROPERTIE :::"
    Private _tratarCampoGrid As Integer

    Public Property CodigoProjectCapa() As Long
        Get
            Return lCodigoProjectCapa
        End Get
        Set(ByVal value As Long)
            lCodigoProjectCapa = value
        End Set
    End Property
    Public Property CodigoCB() As Long
        Get
            Return lCodigoCB
        End Get
        Set(ByVal value As Long)
            lCodigoCB = value
        End Set
    End Property
    Public Property Usuario() As Integer
        Get
            Return iUsuario
        End Get
        Set(ByVal value As Integer)
            iUsuario = value
        End Set
    End Property
    Public Property DataInput() As Date
        Get
            Return dDataInput
        End Get
        Set(ByVal value As Date)
            dDataInput = value
        End Set
    End Property
    Public Property DataInicio() As Date
        Get
            Return dDataInicio
        End Get
        Set(ByVal value As Date)
            dDataInicio = value
        End Set
    End Property

    'Linha
    Public Property Sequencia() As Integer
        Get
            Return iSequencia
        End Get
        Set(ByVal value As Integer)
            iSequencia = value
        End Set
    End Property
    Public Property Nivel() As Integer
        Get
            Return iNivel
        End Get
        Set(ByVal value As Integer)
            iNivel = value
        End Set
    End Property
    Public Property Atividade() As Integer
        Get
            Return iAtividade
        End Get
        Set(ByVal value As Integer)
            iAtividade = value
        End Set
    End Property
    Public Property DescricaoAtividade() As String
        Get
            Return sDescricaoAtividade
        End Get
        Set(ByVal value As String)
            sDescricaoAtividade = value
        End Set
    End Property
    Public Property Tempo() As Integer
        Get
            Return iTempo
        End Get
        Set(ByVal value As Integer)
            iTempo = value
        End Set
    End Property
    Public Property Predecessor() As String
        Get
            Return sPredecessor
        End Get
        Set(ByVal value As String)
            sPredecessor = value
        End Set
    End Property
    Public Property Departamento() As Integer
        Get
            Return iDepartamento
        End Get
        Set(ByVal value As Integer)
            iDepartamento = value
        End Set
    End Property
    Public Property TipoRestricao() As Integer
        Get
            Return iTipoRestricao
        End Get
        Set(ByVal value As Integer)
            iTipoRestricao = value
        End Set
    End Property
    Public Property DataRestricao() As Date
        Get
            Return dDataRestricao
        End Get
        Set(ByVal value As Date)
            dDataRestricao = value
        End Set
    End Property
    Public Property PrazoFinal() As Date
        Get
            Return dPrazoFinal
        End Get
        Set(ByVal value As Date)
            dPrazoFinal = value
        End Set
    End Property
    Public Property PorcentagemConcluida() As Double
        Get
            Return dPorcentagemConcluida
        End Get
        Set(ByVal value As Double)
            dPorcentagemConcluida = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Property TratarCampoGrid(p1 As Object, p2 As Object) As Integer
        Get
            Return _tratarCampoGrid
        End Get
        Set(value As Integer)
            _tratarCampoGrid = value
        End Set
    End Property

    Public Sub LoadDadosAtividade(ByVal oGrid As GridEX, _
                                  ByVal iCodigoAtividade As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter

        Try


            'Seta Parametros - Código da Atividade
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_ccb_atividade_project"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigoAtividade

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_ccb_dados_atividade_project", oSqlParameter)

            While oSqlDataReader.Read

                oGrid.SetValue("tempo", oSqlDataReader.Item("duracao"))
                oGrid.SetValue("departamento", oSqlDataReader.Item("codigo_ccb_departamento"))
                oGrid.SetValue("restricao", oSqlDataReader.Item("codigo_ccb_tipo_restricao"))

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosUsuario(ByVal iCodigoUsuario As Integer, _
                                ByVal oTxtNome As Janus.Windows.GridEX.EditControls.EditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter

        Try


            'Seta Parametros - Código do Usuário
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_usuario"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigoUsuario

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_ccb_dados_usuario", oSqlParameter)

            If oSqlDataReader.Read Then
                oTxtNome.Text = oSqlDataReader.Item("nome")
                oTxtNome.Tag = goUsuario.iEmpresa
            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertCapa()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim iReturn As Integer
        Try


            'Seta Parametros - Data Input
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "data_input"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Date
            oSqlParameter(0).Value = dDataInput

            'Seta Parametros - Código do CB
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_cb"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = lCodigoCB

            'Seta Parametros - Data Início
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_inicio"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = dDataInicio

            'Seta Parametros - Código do Usuário
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_usuario"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iUsuario

            'Seta Parametros - Código do Project Capa
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_ccb_project_capa"
            oSqlParameter(4).Direction = ParameterDirection.Output
            oSqlParameter(4).SqlDbType = SqlDbType.BigInt
            oSqlParameter(4).Value = lCodigoProjectCapa

            'Executa Query
            iReturn = ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_ccb_project_capa", oSqlParameter)

            'Retornando o valor da capa
            lCodigoProjectCapa = oSqlParameter(4).Value


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertLinha()

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim iReturn As Integer
        Try


            'Seta Parametros - Codigo Project Caapa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_ccb_project_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoProjectCapa

            'Seta Parametros - Sequencia
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "sequencia"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iSequencia

            'Seta Parametros - Nível
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "nivel"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = IIf(iNivel = -1, DBNull.Value, iNivel)


            'Seta Parametros - Descrição da Atividade
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "descricao_atividade"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Size = 100
            oSqlParameter(3).Value = sDescricaoAtividade


            'Seta Parametros - Duração
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "tempo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = IIf(iTempo = -1, DBNull.Value, iTempo)

            'Seta Parametros - Recurso
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "codigo_ccb_departamento"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Int
            oSqlParameter(5).Value = IIf(iDepartamento = -1, DBNull.Value, iDepartamento)

            'Seta Parametros - Predecessor
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "predecessor"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.VarChar
            oSqlParameter(6).Size = 100
            oSqlParameter(6).Value = IIf(sPredecessor = "", DBNull.Value, sPredecessor)

            'Seta Parametros - Restricao
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_ccb_tipo_restricao"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = IIf(iTipoRestricao = -1, DBNull.Value, iTipoRestricao)

            'Seta Parametros - Data Restricao
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "data_restricao"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Date
            oSqlParameter(8).Value = IIf(dDataRestricao = Date.MinValue, DBNull.Value, dDataRestricao)

            'Seta Parametros - Prazo Final
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "prazo_final"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Date
            oSqlParameter(9).Value = IIf(dPrazoFinal = Date.MinValue, DBNull.Value, dPrazoFinal)

            'Seta Parametros - Porcentagem Concluída
            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "porcentagem_concluida"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.Float
            oSqlParameter(10).Value = IIf(dPorcentagemConcluida = -1, DBNull.Value, dPorcentagemConcluida)

            'Executa Query
            iReturn = ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_ccb_project_linha", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub CarregarGrid(ByVal lCodigoProjectCapa As Long, _
                                ByVal oGrid As Janus.Windows.GridEX.GridEX)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter

        Try


            'Seta Parametros - Código do project capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_ccb_project_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoProjectCapa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_ccb_project_linha", oSqlParameter)

            LimpaGridUnbound(oGrid)
            With oSqlDataReader
                While oSqlDataReader.Read

                    oGrid.AddItem("", "", _
                                   .Item("nivel"), _
                                   .Item("descricao_atividade"), _
                                   .Item("tempo"), _
                                   .Item("departamento"), _
                                   .Item("predecessor"), _
                                   .Item("restricao"), _
                                   .Item("data_restricao"), _
                                   .Item("prazo_final"), _
                                   .Item("porcentagem_concluida"), _
                                   0, _
                                   "")


                End While
            End With
            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ExportarTarefas(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                                ByVal sNomeArquivo As String)


        Dim prjApplication As New Microsoft.Office.Interop.MSProject.Application
        Dim prjProject As Microsoft.Office.Interop.MSProject.Project
        Dim prjTask As Microsoft.Office.Interop.MSProject.Task
        Dim sPredecessores() As String
        Dim sAtividadePredecessora() As String

        Try

            'Seta Dados Do Projeto no Project 
            prjProject = prjApplication.Projects.Add
            prjProject.BuiltinDocumentProperties("Subject") = "Assunto do Projeto"
            prjProject.BuiltinDocumentProperties("Title") = "CCB - Tarefas"

            With oGrid

                For i = 0 To .RowCount - 1

                    .Row = i

                    'Carrega Atividades No MS Project
                    prjTask = prjProject.Tasks.Add

                    'Exporta Nome Da Atividade
                    prjTask.Name = LTrim(.CurrentRow.Cells.Item("atividade").Text)

                    'Exporta Duracao Da Atividade
                    If .CurrentRow.Cells.Item("tempo").Text <> Nothing Then
                        prjTask.Duration = CStr(.CurrentRow.Cells.Item("tempo").Text) & "d?"
                    End If

                    'Configura Predecessores da Atividade
                    If .CurrentRow.Cells.Item("predecessores").Text <> Nothing Then

                        sPredecessores = .CurrentRow.Cells.Item("predecessores").Text.Split(";")

                        'Loop para Inserir Predecessoras
                        For j As Integer = 0 To sPredecessores.GetUpperBound(0) - 1 Step 1

                            sAtividadePredecessora = sPredecessores(j).Split(",")

                            prjTask.LinkPredecessors(prjProject.Tasks.UniqueID(CInt(sAtividadePredecessora(0))), _
                                                    CInt(sAtividadePredecessora(1)), _
                                                    Replace(sAtividadePredecessora(2), ";", "") & "d")

                        Next


                    End If

                    'Define  Recursos para Atividade
                    If .CurrentRow.Cells.Item("departamento").Text <> Nothing Then
                        prjTask.ResourceNames = .CurrentRow.Cells.Item("departamento").Text
                    End If


                    'Define Nivel da Atividade
                    If .CurrentRow.Cells.Item("nivel").Text <> Nothing Then
                        prjTask.OutlineLevel = .CurrentRow.Cells.Item("nivel").Value
                    End If

                    'Define Restricao da Atividade
                    If .CurrentRow.Cells.Item("restricao").Text <> Nothing Then
                        prjTask.ConstraintType = CInt(.CurrentRow.Cells.Item("restricao").Value)
                    End If

                    'Define Data da Restricao
                    If .CurrentRow.Cells.Item("data_restricao").Text <> Nothing Then
                        prjTask.ConstraintDate = .CurrentRow.Cells.Item("data_restricao").Value
                    End If

                    'Define Prazo Final 
                    If .CurrentRow.Cells.Item("prazo_final").Text <> Nothing Then
                        prjTask.Deadline = .CurrentRow.Cells.Item("prazo_final").Value
                    End If

                    If TratarCampoGrid(.CurrentRow.Cells.Item("porcentagem_concluida").Value, eType.numero) <> -1 Then
                        Try
                            prjTask.PercentWorkComplete = .CurrentRow.Cells.Item("porcentagem_concluida").Value * 100
                        Catch ex As Exception

                        End Try

                    End If

                Next i

            End With


            'Veririfca se há um arquivo de mesmo nome gravado.
            If My.Computer.FileSystem.FileExists(sNomeArquivo) <> False Then
                Kill(sNomeArquivo)
            End If

            'Salva Dados do Projeto
            prjProject.SaveAs(sNomeArquivo, Microsoft.Office.Interop.MSProject.PjFileFormat.pjMPP)

            'Fecha Aplicação Project
            prjApplication.Quit()


        Catch ex As Exception
            'Fecha Aplicação Project
            prjApplication.Quit(Microsoft.Office.Interop.MSProject.PjSaveType.pjDoNotSave)
            Throw ex
        End Try

    End Sub

    Public Sub LimpaGridUnbound(ByVal oGrid As Janus.Windows.GridEX.GridEX)

        Try

            'Variaveis Locais
            Dim oRow As GridEXRow

            For Each oRow In oGrid.GetDataRows

                oRow.Delete()

            Next

            'Limpando os itens
            oGrid.ClearItems()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

End Class
