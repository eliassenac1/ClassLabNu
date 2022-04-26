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
    public partial class FUsuario : Form
    {
        public FUsuario(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(
               Convert.ToInt32(txtId.Text),
                 txtNome.Text,
                 txtEmail.Text,
                 txtSenha.Text
                 );
            usuario.Inserir();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlLisar_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();            
            if (usuario.alterar(int.Parse(txtId.Text), txtNome.Text, txtSenha.Text, txtEmail.Text))
            {
                MessageBox.Show("Usuario Alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha na alteração do Usuario!");
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
