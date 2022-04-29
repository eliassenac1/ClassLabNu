using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLabNu;

namespace ComercialSys91
{
    public partial class FProduto : Form
    {
        public FProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produtos = new Produto(
               tb_descricao.Text,
               tb_codbar.Text,
               tb_unidade.Text,
               Double.Parse(tb_valor.Text),
               Double.Parse(tb_desconto.Text));

                produtos.Inserir();
                MessageBox.Show("Produto Inserido com Sucesso.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_produtos.Rows.Clear();
                List<Produto> listadeprodutos = Produto.Listar();
                int cont = 0;
                foreach (Produto produtos in listadeprodutos)
                {
                    dgv_produtos.Rows.Add();
                    dgv_produtos.Rows[cont].Cells[0].Value = produtos.Id.ToString();
                    dgv_produtos.Rows[cont].Cells[1].Value = produtos.Descricao.ToString();
                    dgv_produtos.Rows[cont].Cells[2].Value = produtos.Unidade.ToString();
                    dgv_produtos.Rows[cont].Cells[3].Value = produtos.Codbar.ToString();
                    dgv_produtos.Rows[cont].Cells[4].Value = produtos.Valor.ToString();
                    dgv_produtos.Rows[cont].Cells[5].Value = produtos.Desconto.ToString();
                    // dgv_produtos.Rows[cont].Cells[6].Value = produtos.Descontinuado;



                    cont++;
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
           
                
            
        }

        private void dgv_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
