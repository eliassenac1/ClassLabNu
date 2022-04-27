using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ClassLabNu
{
    public class WebCep
    {
        
            #region "Váriavies"  
            string _uf;
            string _localidade;
            string _bairro;            
            string _lagradouro;
            
            #endregion

            #region "Propiedades"  
            public string UF
            {
                get { return _uf; }
            }
            public string Localidade
            {
                get { return _localidade; }
            }
            public string Bairro
            {
                get { return _bairro; }
            }
            
            public string Lagradouro
            {
                get { return _lagradouro; }
            }
            
            
            #endregion
            #region "Construtor"  
            /// <summary>  
            /// WebService para Busca de CEP  
            ///  </summary>  
            /// <param  name="CEP"></param>  
            public WebCep(string CEP)
            {
                _uf = "";
                _localidade = "";
                _bairro = "";                
                _lagradouro = "";
                

                //Cria um DataSet  baseado no retorno do XML  
                DataSet ds = new DataSet();
                ds.ReadXml("https://viacep.com.br/ws/" + CEP.Replace("-", "").Trim() + "/xml");

                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                    _uf = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                    _localidade = ds.Tables[0].Rows[0]["localidade"].ToString().Trim();
                    _bairro = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();                    
                    _lagradouro = ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();
                    
                }
                }
                //Exemplo do retorno da  WEB  
                //<?xml version="1.0"  encoding="iso-8859-1"?>  
                //<webservicecep>  
                //<uf>RS</uf>  
                //<cidade>Porto  Alegre</cidade>  
                //<bairro>Passo  D'Areia</bairro>  
                //<tipo_logradouro>Avenida</tipo_logradouro>  
                //<logradouro>Assis Brasil</logradouro>  
                //<resultado>1</resultado>  
                //<resultado_txt>sucesso - cep  completo</resultado_txt>  
                //</webservicecep>  

                
            }
            #endregion
        }
    }
