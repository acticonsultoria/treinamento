Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCfgCupomFiscal

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private lCupomFiscal As Long
    Private sMensagem As String
    Private iTipoICF As Integer
    Private sArquivo As String
    Private iCodigoDeposito As Integer
    Private iCodigoBancoConta As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CupomFiscal() As Long
        Get
            Return lCupomFiscal
        End Get
        Set(ByVal value As Long)
            lCupomFiscal = value
        End Set
    End Property

    Public Property Mensagem() As String
        Get
            Return sMensagem
        End Get
        Set(ByVal value As String)
            sMensagem = value
        End Set
    End Property

    Public Property TipoICF() As Integer
        Get
            Return iTipoICF
        End Get
        Set(ByVal value As Integer)
            iTipoICF = value
        End Set
    End Property

    Public Property Arquivo() As String
        Get
            Return sArquivo
        End Get
        Set(ByVal value As String)
            sArquivo = value
        End Set
    End Property

    Public Property CodigoDeposito() As Integer
        Get
            Return iCodigoDeposito
        End Get
        Set(ByVal value As Integer)
            iCodigoDeposito = value
        End Set
    End Property

    Public Property CodigoBancoConta() As Integer
        Get
            Return iCodigoBancoConta
        End Get
        Set(ByVal value As Integer)
            iCodigoBancoConta = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Save()

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cupom Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_cupom_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCupomFiscal : i += 1

            'Seta Parametros - Mensagem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 384
            oSqlParameter(i).Value = IIf(sMensagem.Trim = "", DBNull.Value, sMensagem.Trim) : i += 1

            'Seta Parametros - Tipo ICF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_icf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoICF : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDeposito : i += 1

            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Path Config
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "path_config"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivo.Trim : i += 1

            'Seta Parametros - Hostname
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hostname"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = System.Net.Dns.GetHostName : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_configuracao_cupom_fiscal", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDados(ByVal txtCupomFiscal As MaskedEditBox, _
                         ByVal txtMensagem As EditBox, _
                         ByVal cboTipoICF As UIComboBox, _
                         ByVal txtArquivo As MaskedEditBox, _
                         ByVal cboDeposito As UIComboBox, _
                         ByVal cboContaBancaria As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Hostname
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hostname"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = System.Net.Dns.GetHostName : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_cupom_fiscal", oSqlParameter)

            'Verifica se Existe Linha
            If oSqlDataReader.HasRows = True Then

                While oSqlDataReader.Read

                    'Carrega Controles
                    txtCupomFiscal.Text = oSqlDataReader.Item("numero_cupom_fiscal")
                    txtMensagem.Text = oSqlDataReader.Item("mensagem")
                    cboTipoICF.SelectedValue = oSqlDataReader.Item("tipo_icf")
                    txtArquivo.Text = oSqlDataReader.Item("path_config")
                    cboDeposito.SelectedValue = oSqlDataReader.Item("codigo_deposito")
                    cboContaBancaria.SelectedValue = oSqlDataReader.Item("codigo_banco_conta")

                End While

            Else

                'Limpa Controles
                txtCupomFiscal.Text = ""
                txtMensagem.Text = ""
                cboTipoICF.SelectedIndex = -1
                txtArquivo.Text = ""
                cboDeposito.SelectedIndex = -1

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
