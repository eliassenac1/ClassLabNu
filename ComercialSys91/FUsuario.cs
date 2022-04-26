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
        public FUsuario()
        {
            InitializeComponent();
            //MdiParent = parent;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario (txtNome.Text, txtEmail.Text, txtSenha.Text);

            usuario.Inserir();

            if (usuario.Id > 0)
            {
                
                MessageBox.Show("Cliente gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao inserir cliente.");
            }


        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlLisar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.Clear();
            List<Usuario> listadeusuarios = Usuario.Listar();
            int cont = 0;
            foreach (Usuario usuario in listadeusuarios)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id.ToString();
                dgvUsuarios.Rows[cont].Cells[1].Value = usuario.Nome.ToString();
                dgvUsuarios.Rows[cont].Cells[2].Value = usuario.Email.ToString();
                dgvUsuarios.Rows[cont].Cells[3].Value = usuario.Senha.ToString();
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Ativo;

                cont++;
            }

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
