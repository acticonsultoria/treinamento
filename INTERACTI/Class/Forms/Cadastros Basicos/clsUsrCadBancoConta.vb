Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrCadBancoConta

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iBanco As Integer
    Private sAgencia As String
    Private sConta As String
    Private sDigitoConta As String
    Private sLogradouro As String
    Private sNumero As String
    Private sBairro As String
    Private iMunicipio As Integer
    Private iPais As Integer
    Private sUF As String
    Private sComplemento As String
    Private sCEP As String
    Private sObservacao As String
    Private bAtivo As Boolean
    Private bAplicacao As Boolean
    Private iCodigoBancoConta As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property Banco() As Integer
        Get
            Return iBanco
        End Get
        Set(ByVal value As Integer)
            iBanco = value
        End Set
    End Property

    Public Property Agencia() As String
        Get
            Return sAgencia
        End Get
        Set(ByVal value As String)
            sAgencia = value
        End Set
    End Property

    Public Property Conta() As String
        Get
            Return sConta
        End Get
        Set(ByVal value As String)
            sConta = value
        End Set
    End Property

    Public Property DigitoConta() As String
        Get
            Return sDigitoConta
        End Get
        Set(ByVal value As String)
            sDigitoConta = value
        End Set
    End Property

    Public Property Logradouro() As String
        Get
            Return sLogradouro
        End Get
        Set(ByVal value As String)
            sLogradouro = value
        End Set
    End Property

    Public Property Numero() As String
        Get
            Return sNumero
        End Get
        Set(ByVal value As String)
            sNumero = value
        End Set
    End Property

    Public Property Bairro() As String
        Get
            Return sBairro
        End Get
        Set(ByVal value As String)
            sBairro = value
        End Set
    End Property

    Public Property CodigoMunicipio() As Integer
        Get
            Return iMunicipio
        End Get
        Set(ByVal value As Integer)
            iMunicipio = value
        End Set
    End Property

    Public Property Pais() As Integer
        Get
            Return iPais
        End Get
        Set(ByVal value As Integer)
            iPais = value
        End Set
    End Property

    Public Property UF() As String
        Get
            Return sUF
        End Get
        Set(ByVal value As String)
            sUF = value
        End Set
    End Property

    Public Property Complemento() As String
        Get
            Return sComplemento
        End Get
        Set(ByVal value As String)
            sComplemento = value
        End Set
    End Property

    Public Property Cep() As String
        Get
            Return sCEP
        End Get
        Set(ByVal value As String)
            sCEP = value
        End Set
    End Property

    Public Property Observacao() As String
        Get
            Return sObservacao
        End Get
        Set(ByVal value As String)
            sObservacao = value
        End Set
    End Property

    Public Property Ativo() As Boolean
        Get
            Return bAtivo
        End Get
        Set(ByVal value As Boolean)
            bAtivo = value
        End Set
    End Property

    Public Property Aplicacao() As Boolean
        Get
            Return bAplicacao
        End Get
        Set(ByVal value As Boolean)
            bAplicacao = value
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return iCodigoBancoConta
        End Get
        Set(ByVal value As Integer)
            iCodigoBancoConta = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: BANCO :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Banco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iBanco : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Agência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sAgencia : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sConta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Digito de Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "digito_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sDigitoConta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sLogradouro = "", DBNull.Value, sLogradouro) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sNumero = "", DBNull.Value, sNumero) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sBairro = "", DBNull.Value, sBairro) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iMunicipio = -1, DBNull.Value, iMunicipio) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - País
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iPais = -1, DBNull.Value, iPais) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sUF = "", DBNull.Value, sUF) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = IIf(sCEP = "", DBNull.Value, sCEP) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aplicacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAplicacao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_banco_conta", oSqlParameter)

            'Seta Código
            iCodigoBancoConta = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Banco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iBanco : i += 1

            'Seta Parametros - Agência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sAgencia : i += 1

            'Seta Parametros - Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sConta : i += 1

            'Seta Parametros - Digito de Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "digito_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sDigitoConta : i += 1

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sLogradouro = "", DBNull.Value, sLogradouro) : i += 1

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sNumero = "", DBNull.Value, sNumero) : i += 1

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sBairro = "", DBNull.Value, sBairro) : i += 1

            'Seta Parametros - Código Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iMunicipio = -1, DBNull.Value, iMunicipio) : i += 1

            'Seta Parametros - País
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iPais = -1, DBNull.Value, iPais) : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sUF = "", DBNull.Value, sUF) : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = IIf(sCEP = "", DBNull.Value, sCEP) : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aplicacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAplicacao : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_banco_conta", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_banco_conta", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                        ByVal iBanco As Integer, _
                        ByVal sAgencia As String, _
                        ByVal sNumeroConta As String, _
                        ByVal sDigitoControle As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Personalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iBanco : i += 1

            'Seta Parametros - Agência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sAgencia : i += 1

            'Seta Parametros - Número da Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sNumeroConta : i += 1

            'Seta Parametros - Digito de Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "digito_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sDigitoControle : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_banco_conta", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControles(ByVal iCodigoBancoConta As Integer, _
                             ByVal cboBanco As UIComboBox, _
                             ByVal txtAgencia As MaskedEditBox, _
                             ByVal txtConta As MaskedEditBox, _
                             ByVal txtDigitoConta As MaskedEditBox, _
                             ByVal cboAtivo As UIComboBox, _
                             ByVal cboAplicacao As UIComboBox, _
                             ByVal txtLogradouro As MaskedEditBox, _
                             ByVal txtNumero As MaskedEditBox, _
                             ByVal txtBairro As MaskedEditBox, _
                             ByVal cboMunicipio As UIComboBox, _
                             ByVal cboPais As UIComboBox, _
                             ByVal cboUF As UIComboBox, _
                             ByVal txtComplemento As MaskedEditBox, _
                             ByVal txtCEP As MaskedEditBox, _
                             ByVal txtObservacao As EditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_banco_conta", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    cboBanco.SelectedValue = oSqlDataReader.Item("codigo_banco")
                    cboBanco.Tag = iCodigoBancoConta
                    txtAgencia.Text = oSqlDataReader.Item("agencia")
                    txtConta.Text = oSqlDataReader.Item("conta")
                    txtDigitoConta.Text = oSqlDataReader.Item("digito_controle")
                    cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
                    cboAplicacao.SelectedValue = oSqlDataReader.Item("aplicacao")
                    txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                    txtNumero.Text = oSqlDataReader.Item("numero")
                    txtBairro.Text = oSqlDataReader.Item("bairro")
                    cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                    cboUF.SelectedValue = oSqlDataReader.Item("uf")
                    cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                    txtComplemento.Text = oSqlDataReader.Item("complemento")
                    txtCEP.Text = oSqlDataReader.Item("cep")
                    txtObservacao.Text = oSqlDataReader.Item("observacao")

                End While

            End If

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaAgenciaConta() As Boolean

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaAgenciaConta = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Codigo Banco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iBanco : i += 1

            'Seta Parametros - Agência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sAgencia : i += 1

            'Seta Parametros - Número Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sConta : i += 1

            'Seta Parametros - Dígito Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "digito_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sDigitoConta : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_banco_conta", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaAgenciaConta = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: CONTATO :::"

    Public Sub InsertContato(ByVal sNome As String, _
                             ByVal sTelefone As String, _
                             ByVal sCelular As String, _
                             ByVal sDataAniversario As String, _
                             ByVal sEmail As String, _
                             ByVal sComplemento As String, _
                             ByVal iCodigoTipoContato As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer

        Try

            'Seta Váriavel
            i = 0

            'Seta Parametros - Código Banco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoContato : i += 1

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 70
            oSqlParameter(i).Value = sNome : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sTelefone = "", DBNull.Value, sTelefone) : i += 1

            'Seta Parametros - Celular
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "celular"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sCelular = "", DBNull.Value, sCelular) : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sEmail = "", DBNull.Value, sEmail) : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1

            'Seta Parametros - Data Aniversário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_aniversario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataAniversario), sDataAniversario, DBNull.Value)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_banco_conta_contato", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateContato(ByVal sNome As String, _
                             ByVal sTelefone As String, _
                             ByVal sCelular As String, _
                             ByVal sDataAniversario As String, _
                             ByVal sEmail As String, _
                             ByVal sComplemento As String, _
                             ByVal iCodigoTipoContato As Integer, _
                             ByVal iCodigoContato As Integer)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer

        Try

            'Seta Váriavel
            i = 0

            'Seta Parametros - Código Banco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoContato : i += 1

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 70
            oSqlParameter(i).Value = sNome : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sTelefone = "", DBNull.Value, sTelefone) : i += 1

            'Seta Parametros - Celular
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "celular"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sCelular = "", DBNull.Value, sCelular) : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sEmail = "", DBNull.Value, sEmail) : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1

            'Seta Parametros - Data Aniversário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_aniversario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataAniversario), sDataAniversario, DBNull.Value) : i += 1

            'Seta Parametros - Código 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoContato

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_banco_conta_contato", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteContato()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Banco Conta
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_banco_conta"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoBancoConta : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_banco_conta_contato", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridContato(ByVal oGrid As GridEX, _
                               ByVal iCodigoBancoConta As Integer)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_banco_conta_contato", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
