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
            Produto produtos = new Produto(
                tb_descricao.Text,
                tb_codbar.Text,
                tb_unidade.Text,
                Double.Parse(tb_valor.Text),
                Double.Parse(tb_desconto.Text));

            produtos.Inserir();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
           
        }

        private void dgv_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
