using System;
using System.Collections.Generic;
using System.Text;

namespace BoletoNet
{
    #region Enumerado

    public enum EnumEspecieDocumento_BancoSicred
    {
        Cheque = 1, //CH – CHEQUE
        DuplicataMercantil = 2, //DM – DUPLICATA MERCANTIL
        DuplicataMercantilIndicacao = 3, //DMI – DUPLICATA MERCANTIL P/ INDICAÇÃO
        DuplicataServico = 4, //DS –  DUPLICATA DE SERVIÇO
        DuplicataServicoIndicacao = 5, //DSI –  DUPLICATA DE SERVIÇO P/ INDICAÇÃO
        DuplicataRural = 6, //DR – DUPLICATA RURAL
        LetraCambio = 7, //LC – LETRA DE CAMBIO
        NotaCreditoComercial = 8, //NCC – NOTA DE CRÉDITO COMERCIAL
        NotaCreditoExportacao = 9, //NCE – NOTA DE CRÉDITO A EXPORTAÇÃO
        NotaCreditoIndustrial = 10, //NCI – NOTA DE CRÉDITO INDUSTRIAL
        NotaCreditoRural = 11, //NCR – NOTA DE CRÉDITO RURAL
        NotaPromissoria = 12, //NP – NOTA PROMISSÓRIA
        NotaPromissoriaRural = 13, //NPR –NOTA PROMISSÓRIA RURAL
        TriplicataMercantil = 14, //TM – TRIPLICATA MERCANTIL
        TriplicataServico = 15, //TS –  TRIPLICATA DE SERVIÇO
        NotaSeguro = 16, //NS – NOTA DE SEGURO
        Recibo = 17, //RC – RECIBO
        Fatura = 18, //FAT – FATURA
        NotaDebito = 19, //ND –  NOTA DE DÉBITO
        ApoliceSeguro = 20, //AP –  APÓLICE DE SEGURO
        MensalidadeEscolar = 21, //ME – MENSALIDADE ESCOLAR
        ParcelaConsorcio = 22, //PC –  PARCELA DE CONSÓRCIO
        Outros = 23 //OUTROS
    }

    #endregion

    public class EspecieDocumento_BancoSicred : AbstractEspecieDocumento, IEspecieDocumento
    {
        #region Construtores

        public EspecieDocumento_BancoSicred()
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar objeto", ex);
            }
        }

        public EspecieDocumento_BancoSicred(int codigo)
        {
            try
            {
                this.carregar(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar objeto", ex);
            }
        }

        #endregion

        #region Metodos Privados

        private void carregar(int idCodigo)
        {
            try
            {
                this.Banco = new Banco_Sicredi();

                switch ((EnumEspecieDocumento_BancoSicred)idCodigo)
                {
                    case EnumEspecieDocumento_BancoSicred.Cheque:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.Cheque;
                        this.Especie = "CHEQUE";
                        this.Sigla = "CH";
                        break;
                    case EnumEspecieDocumento_BancoSicred.DuplicataMercantil:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.DuplicataMercantil;
                        this.Especie = "DUPLICATA MERCANTIL";
                        this.Sigla = "DM";
                        break;
                    case EnumEspecieDocumento_BancoSicred.DuplicataMercantilIndicacao:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.DuplicataMercantilIndicacao;
                        this.Especie = "DUPLICATA MERCANTIL P/ INDICAÇÃO";
                        this.Sigla = "DMI";
                        break;
                    case EnumEspecieDocumento_BancoSicred.DuplicataServico:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.DuplicataServico;
                        this.Especie = "DUPLICATA DE SERVIÇO";
                        this.Sigla = "DS";
                        break;
                    case EnumEspecieDocumento_BancoSicred.DuplicataServicoIndicacao:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.DuplicataServicoIndicacao;
                        this.Especie = "DUPLICATA DE SERVIÇO P/ INDICAÇÃO";
                        this.Sigla = "DSI";
                        break;
                    case EnumEspecieDocumento_BancoSicred.DuplicataRural:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.DuplicataRural;
                        this.Especie = "DUPLICATA RURAL";
                        this.Sigla = "DR";
                        break;
                    case EnumEspecieDocumento_BancoSicred.LetraCambio:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.LetraCambio;
                        this.Especie = "LETRA DE CAMBIO";
                        this.Sigla = "LC";
                        break;
                    case EnumEspecieDocumento_BancoSicred.NotaCreditoComercial:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.NotaCreditoComercial;
                        this.Especie = "NOTA DE CRÉDITO COMERCIAL";
                        this.Sigla = "NCC";
                        break;
                    case EnumEspecieDocumento_BancoSicred.NotaCreditoExportacao:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.NotaCreditoExportacao;
                        this.Especie = "NOTA DE CRÉDITO A EXPORTAÇÃO";
                        this.Sigla = "NCE";
                        break;
                    case EnumEspecieDocumento_BancoSicred.NotaCreditoIndustrial:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.NotaCreditoIndustrial;
                        this.Especie = "NOTA DE CRÉDITO INDUSTRIAL";
                        this.Sigla = "NCI";
                        break;
                    case EnumEspecieDocumento_BancoSicred.NotaCreditoRural:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.NotaCreditoRural;
                        this.Especie = "NOTA DE CRÉDITO RURAL";
                        this.Sigla = "NCR";
                        break;
                    case EnumEspecieDocumento_BancoSicred.NotaPromissoria:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.NotaPromissoria;
                        this.Especie = "NOTA PROMISSÓRIA";
                        this.Sigla = "NP";
                        break;
                    case EnumEspecieDocumento_BancoSicred.NotaPromissoriaRural:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.NotaPromissoriaRural;
                        this.Especie = "NOTA PROMISSÓRIA RURAL";
                        this.Sigla = "NPR";
                        break;
                    case EnumEspecieDocumento_BancoSicred.TriplicataMercantil:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.TriplicataMercantil;
                        this.Especie = "TRIPLICATA MERCANTIL";
                        this.Sigla = "TM";
                        break;
                    case EnumEspecieDocumento_BancoSicred.TriplicataServico:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.TriplicataServico;
                        this.Especie = "TRIPLICATA DE SERVIÇO";
                        this.Sigla = "TS";
                        break;
                    case EnumEspecieDocumento_BancoSicred.NotaSeguro:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.NotaSeguro;
                        this.Especie = "NOTA DE SEGURO";
                        this.Sigla = "NS";
                        break;
                    case EnumEspecieDocumento_BancoSicred.Recibo:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.Recibo;
                        this.Especie = "RECIBO";
                        this.Sigla = "RC";
                        break;
                    case EnumEspecieDocumento_BancoSicred.Fatura:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.Fatura;
                        this.Especie = "FATURA";
                        this.Sigla = "FAT";
                        break;
                    case EnumEspecieDocumento_BancoSicred.NotaDebito:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.NotaDebito;
                        this.Especie = "NOTA DE DÉBITO";
                        this.Sigla = "ND";
                        break;
                    case EnumEspecieDocumento_BancoSicred.ApoliceSeguro:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.ApoliceSeguro;
                        this.Especie = "APÓLICE DE SEGURO";
                        this.Sigla = "AP";
                        break;
                    case EnumEspecieDocumento_BancoSicred.MensalidadeEscolar:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.MensalidadeEscolar;
                        this.Especie = "MENSALIDADE ESCOLAR";
                        this.Sigla = "ME";
                        break;
                    case EnumEspecieDocumento_BancoSicred.ParcelaConsorcio:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.ParcelaConsorcio;
                        this.Especie = "PARCELA DE CONSÓRCIO";
                        this.Sigla = "PC";
                        break;
                    case EnumEspecieDocumento_BancoSicred.Outros:
                        this.Codigo = (int)EnumEspecieDocumento_BancoSicred.Outros;
                        this.Especie = "OUTROS";
                        this.Sigla = "OUTROS";
                        break;
                    default:
                        this.Codigo = 0;
                        this.Especie = "( Selecione )";
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar objeto", ex);
            }
        }

        public static EspeciesDocumento CarregaTodas()
        {
            try
            {
                EspeciesDocumento alEspeciesDocumento = new EspeciesDocumento();

                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.Cheque));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.DuplicataMercantil));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.DuplicataMercantilIndicacao));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.DuplicataServico));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.DuplicataServicoIndicacao));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.DuplicataRural));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.LetraCambio));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.NotaCreditoComercial));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.NotaCreditoExportacao));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.NotaCreditoIndustrial));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.NotaCreditoRural));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.NotaPromissoria));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.NotaPromissoriaRural));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.TriplicataMercantil));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.TriplicataServico));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.NotaSeguro));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.Recibo));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.Fatura));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.NotaDebito));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.ApoliceSeguro));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.MensalidadeEscolar));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.ParcelaConsorcio));
                alEspeciesDocumento.Add(new EspecieDocumento_BancoSicred((int)EnumEspecieDocumento_BancoSicred.Outros));

                return alEspeciesDocumento;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar objetos", ex);
            }
        }

        #endregion
    }
}
