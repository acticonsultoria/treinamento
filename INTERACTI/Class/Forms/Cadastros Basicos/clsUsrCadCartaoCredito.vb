Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrCadCartaoCredito

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iCodigoBancoConta As Integer
    Private iCodigoBandeiraCartaoCredito As Integer
    Private sQuatroUltimosDigitos As String
    Private iDiaFechamento As Integer
    Private iDiaPagamento As Integer
    Private sValidade As String
    Private iCodigoFuncionarioPortador As Integer
    Private iCodigo As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoBancoConta() As Integer
        Get
            Return iCodigoBancoConta
        End Get
        Set(ByVal value As Integer)
            iCodigoBancoConta = value
        End Set
    End Property

    Public Property CodigoBandeiraCartaoCredito() As Integer
        Get
            Return iCodigoBandeiraCartaoCredito
        End Get
        Set(ByVal value As Integer)
            iCodigoBandeiraCartaoCredito = value
        End Set
    End Property

    Public Property QuatroUltimosDigitos() As String
        Get
            Return sQuatroUltimosDigitos
        End Get
        Set(ByVal value As String)
            sQuatroUltimosDigitos = value
        End Set
    End Property

    Public Property Validade() As String
        Get
            Return sValidade
        End Get
        Set(ByVal value As String)
            sValidade = value
        End Set
    End Property

    Public Property DiaFechamento() As Integer
        Get
            Return iDiaFechamento
        End Get
        Set(ByVal value As Integer)
            iDiaFechamento = value
        End Set
    End Property

    Public Property DiaPagamento() As Integer
        Get
            Return iDiaPagamento
        End Get
        Set(ByVal value As Integer)
            iDiaPagamento = value
        End Set
    End Property

    Public Property CodigoFuncionarioPortador() As Integer
        Get
            Return iCodigoFuncionarioPortador
        End Get
        Set(ByVal value As Integer)
            iCodigoFuncionarioPortador = value
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Código Bandeira Cartão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_bandeira_cartao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoBandeiraCartaoCredito : i += 1

            'Seta Parametros - Último Quatros Dígitos
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quatro_ultimos_digitos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4
            oSqlParameter(i).Value = sQuatroUltimosDigitos : i += 1

            'Seta Parametros - Data de Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sValidade : i += 1

            'Seta Parametros - Dia Fechamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "dia_fechamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iDiaFechamento : i += 1

            'Seta Parametros - Dia Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "dia_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iDiaPagamento : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo Funcionário Portador
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario_portador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoFuncionarioPortador = -1, DBNull.Value, iCodigoFuncionarioPortador) : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_cartao_credito", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Código Bandeira Cartão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_bandeira_cartao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoBandeiraCartaoCredito : i += 1

            'Seta Parametros - Último Quatros Dígitos
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quatro_ultimos_digitos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4
            oSqlParameter(i).Value = sQuatroUltimosDigitos : i += 1

            'Seta Parametros - Data de Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sValidade : i += 1

            'Seta Parametros - Dia Fechamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "dia_fechamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iDiaFechamento : i += 1

            'Seta Parametros - Dia Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "dia_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iDiaPagamento : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Codigo Funcionário Portador
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario_portador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoFuncionarioPortador = -1, DBNull.Value, iCodigoFuncionarioPortador) : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_cartao_credito", oSqlParameter)

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

            For Each oRow In gSelecaoRow

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_cartao_credito", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iCodigoContaBancaria As Integer, _
                        ByVal iCodigoBandeiraCartao As Integer, _
                        ByVal sQuatroUltimosDigitos As String, _
                        ByVal sValidade As String, _
                        ByVal iCodigoFuncionarioPortador As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoContaBancaria : i += 1

            'Seta Parametros - Código Bandeira Cartão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_bandeira_cartao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBandeiraCartao : i += 1

            'Seta Parametros - Quatro Últimos Dígitos
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quatro_ultimos_digitos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4
            oSqlParameter(i).Value = sQuatroUltimosDigitos : i += 1

            'Seta Parametros - Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sValidade), sValidade, DBNull.Value) : i += 1

            'Seta Parametros - Codigo Funcionário Portador
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario_portador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionarioPortador : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_cartao_credito", oSqlParameter)

            'Configurar Grid
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

    Public Function ValidaCartao(ByVal iCodigo As Integer, _
                                 ByVal iCodigoContaBancaria As Integer, _
                                 ByVal iCodigoBandeiraCartao As Integer, _
                                 ByVal sQuatroUltimosDigitos As String, _
                                 ByVal sValidade As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaCartao = False

            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Código Bandeira Cartão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_bandeira_cartao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBandeiraCartao : i += 1

            'Seta Parametros - Quatro Últimos Dígitos
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quatro_ultimos_digitos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4
            oSqlParameter(i).Value = sQuatroUltimosDigitos : i += 1

            'Seta Parametros - Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sValidade), DBNull.Value, sValidade) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_cartao_credito", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaCartao = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
