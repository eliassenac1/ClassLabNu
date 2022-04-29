using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLabNu
{
    public class Produto
    {
        //atributos
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public string Codbar { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }
        public bool Descontinuado { get; set; }
        //propriedades

        // Construtores 



        public Produto()
        {

        }

        public Produto(int id, string descricao, string unidade, string codbar, double valor)
        {
            Id = id;
            this.Descricao = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;

        }


        public Produto(string descricao, string unidade, string codbar, double valor, double desconto)
        {
            this.Descricao = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
            this.Desconto = desconto;

        }
        public Produto(int id, string descricao, string unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
            Id = id;
            this.Descricao = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
            this.Desconto = desconto;
            this.Descontinuado = descontinuado;
        }

        public Produto(int id, string descricao, string unidade, string codbar, double valor, double desconto)
        {
            Id = id;
            this.Descricao = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
            this.Desconto = desconto;
            
        }



        // Metodos 

        public void Inserir()
        {
            // Abre conexão com banco
            MySqlCommand cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produtos_inserir";

            // Parametros
            cmd.Parameters.AddWithValue("_descricao", Descricao);
            cmd.Parameters.AddWithValue("_unidade", Unidade);
            cmd.Parameters.AddWithValue("_codbar", Codbar);
            cmd.Parameters.AddWithValue("_valor", Valor);
            cmd.Parameters.AddWithValue("_desconto", Desconto);
            cmd.ExecuteNonQuery();
            // Fecha Conexão
            cmd.Connection.Close();


        }

        public static Produto ConsultarPorCodbar(string _codbar)
        {
            Produto produtos = new Produto();
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from produtos where codbar = " + _codbar;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Id = Convert.ToInt32(dr["idprod"]);
                produtos.Descricao = dr["descricao"].ToString();
                produtos.Unidade = dr.GetString(2);
                produtos.Codbar = dr.GetString(3);
                produtos.Valor = Convert.ToDouble(dr["valor"]);
                
            }
            return produtos;
        }


        public List<Produto> ListarTodos(string descriParte = null)
        {
            // Nova lista
            List<Produto> produtos = new List<Produto>();

            // Abrir conexão
            MySqlCommand cmd = Banco.Abrir();

            // Comando
            if (descriParte == null)
            {// Lista produtos ativos ordenados alfabéticamente
                cmd.CommandText = "select * from produtos where descontinuado = order by 2";
            }
            else
            {// Lista produtos ativos, por parte da descrição e ordenados alfabéticamente
                cmd.CommandText = "select * from produtos where descontinuado = 0 and dracricao like '%" + descriParte + "%' order by 2  ";

            }
            // Var para Consulta
            MySqlDataReader dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                produtos.Add(new Produto(
                    Convert.ToInt32(dr.GetInt32(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6)
                   ));
            }

            // Fecha Conexão
            cmd.Connection.Close();

            // Retornando lista
            return produtos;

            
        }
        
        public static List<Produto> Listar()
        {
            List<Produto> produtos = new List<Produto>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from produtos order by idprod";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(new Produto(
                Convert.ToInt32(dr.GetInt32(0)),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetDouble(4),
                dr.GetDouble(5)
                // dr.GetBoolean(6)
                ));
            }
            return produtos;
        }



        // Descontinuar produto
        public void Desativar(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Produtos set ativo = 0 where idprod = " + _id;
            cmd.ExecuteReader();
            cmd.Connection.Close();
        }





    }

}
