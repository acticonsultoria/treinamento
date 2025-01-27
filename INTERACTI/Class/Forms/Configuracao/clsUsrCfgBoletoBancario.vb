Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCfgBoletoBancario

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iBancoConta As Integer
    Private iCodigoCentroGasto As Integer
    Private sContaContabil As String
    Private dJuros As Double
    Private dMulta As Double
    Private iCNAB As Integer
    Private sConvenio As String
    Private sInstrucao1 As String
    Private sInstrucao2 As String
    Private sInstrucao3 As String
    Private iNumeroDias1 As Integer
    Private iNumeroDias2 As Integer
    Private iNumeroDias3 As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property BancoConta() As Integer
        Set(ByVal value As Integer)
            iBancoConta = value
        End Set
    End Property

    Public WriteOnly Property CodigoCentroGasto() As Integer
        Set(ByVal value As Integer)
            iCodigoCentroGasto = value
        End Set
    End Property

    Public WriteOnly Property ContaContabil() As String
        Set(ByVal value As String)
            sContaContabil = value
        End Set
    End Property

    Public WriteOnly Property Juros() As Double
        Set(ByVal value As Double)
            dJuros = value
        End Set
    End Property

    Public WriteOnly Property Multa() As Double
        Set(ByVal value As Double)
            dMulta = value
        End Set
    End Property

    Public WriteOnly Property CNAB() As Integer
        Set(ByVal value As Integer)
            iCNAB = value
        End Set
    End Property

    Public WriteOnly Property Convenio() As String
        Set(ByVal value As String)
            sConvenio = value
        End Set
    End Property

    Public WriteOnly Property Instrucao1() As String
        Set(ByVal value As String)
            sInstrucao1 = value
        End Set
    End Property

    Public WriteOnly Property Instrucao2() As String
        Set(ByVal value As String)
            sInstrucao2 = value
        End Set
    End Property

    Public WriteOnly Property Instrucao3() As String
        Set(ByVal value As String)
            sInstrucao3 = value
        End Set
    End Property

    Public WriteOnly Property NumeroDias1() As Integer
        Set(ByVal value As Integer)
            iNumeroDias1 = value
        End Set
    End Property

    Public WriteOnly Property NumeroDias2() As Integer
        Set(ByVal value As Integer)
            iNumeroDias2 = value
        End Set
    End Property

    Public WriteOnly Property NumeroDias3() As Integer
        Set(ByVal value As Integer)
            iNumeroDias3 = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Salvar()

        'Variaveis Locais
        Dim oSqlParameter(13) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Conta Bancária
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iBancoConta : i += 1

            'Seta Parametros - Código Centro Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_gasto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCentroGasto = -1, DBNull.Value, iCodigoCentroGasto) : i += 1

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sContaContabil = "", DBNull.Value, sContaContabil) : i += 1

            'Seta Parametros - Juros
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "juros"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dJuros : i += 1

            'Seta Parametros - Multa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMulta : i += 1

            'Seta Parametros - CNAB
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cnab"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCNAB = -1, DBNull.Value, iCNAB) : i += 1

            'Seta Parametros - Convênio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "convenio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 9
            oSqlParameter(i).Value = sConvenio : i += 1

            'Seta Parametros - Instrução 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "instrucao1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sInstrucao1 = "", DBNull.Value, sInstrucao1) : i += 1

            'Seta Parametros - Instrução 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "instrucao2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sInstrucao2 = "", DBNull.Value, sInstrucao2) : i += 1

            'Seta Parametros - Instrução 3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "instrucao3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sInstrucao3 = "", DBNull.Value, sInstrucao3) : i += 1

            'Seta Parametros - Nº Dias 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_dias1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iNumeroDias1 = -1, DBNull.Value, iNumeroDias1) : i += 1

            'Seta Parametros - Nº Dias 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_dias2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iNumeroDias2 = -1, DBNull.Value, iNumeroDias2) : i += 1

            'Seta Parametros - Nº Dias 3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_dias3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iNumeroDias3 = -1, DBNull.Value, iNumeroDias3) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_configuracao_boleto_bancario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDados(ByVal iCodigoBancoConta As Integer, _
                         ByVal cboCentroGasto As UIComboBox, _
                         ByVal cboContaContabil As UIComboBox, _
                         ByVal txtJuros As NumericEditBox, _
                         ByVal txtMulta As NumericEditBox, _
                         ByVal cboCNAB As UIComboBox, _
                         ByVal txtConvenio As MaskedEditBox, _
                         ByVal cboInstrucao1 As UIComboBox, _
                         ByVal cboInstrucao2 As UIComboBox, _
                         ByVal cboInstrucao3 As UIComboBox, _
                         ByVal txtNumeroDias1 As NumericEditBox, _
                         ByVal txtNumeroDias2 As NumericEditBox, _
                         ByVal txtNumeroDias3 As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Conta Bancária
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_boleto_bancario", oSqlParameter)

            'Verifica se Existe Linha
            If oSqlDataReader.HasRows = True Then

                While oSqlDataReader.Read

                    'Carrega Controles
                    cboCentroGasto.SelectedValue = oSqlDataReader.Item("codigo_centro_gasto")
                    cboContaContabil.SelectedValue = oSqlDataReader.Item("conta_contabil")
                    txtJuros.Value = oSqlDataReader.Item("juros")
                    txtMulta.Value = oSqlDataReader.Item("multa")
                    cboCNAB.SelectedValue = oSqlDataReader.Item("codigo_cnab")
                    txtConvenio.Text = oSqlDataReader.Item("convenio")
                    cboInstrucao1.SelectedValue = oSqlDataReader.Item("instrucao1")
                    cboInstrucao2.SelectedValue = oSqlDataReader.Item("instrucao2")
                    cboInstrucao3.SelectedValue = oSqlDataReader.Item("instrucao3")
                    txtNumeroDias1.Value = oSqlDataReader.Item("numero_dias1")
                    txtNumeroDias2.Value = oSqlDataReader.Item("numero_dias2")
                    txtNumeroDias3.Value = oSqlDataReader.Item("numero_dias3")

                End While

            Else

                'Limpa Controles
                cboCentroGasto.Text = ""
                cboContaContabil.Text = ""
                txtJuros.Value = 0
                txtMulta.Value = 0
                cboCNAB.SelectedIndex = -1
                txtConvenio.Text = ""
                cboInstrucao1.SelectedIndex = -1
                cboInstrucao2.SelectedIndex = -1
                cboInstrucao3.SelectedIndex = -1
                txtNumeroDias1.Value = 0
                txtNumeroDias2.Value = 0
                txtNumeroDias3.Value = 0

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
