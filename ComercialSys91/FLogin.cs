using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using ClassLabNu;

namespace ComercialSys91
{
    public partial class FLogin : Form
    {
        FrmPrincipal frmPrincipal;      



        public FLogin(FrmPrincipal f)
        {
            InitializeComponent();
            frmPrincipal = f;
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
          
            
            string usuario = tb_usuario.Text;
            string senha = tb_senha.Text;  

            if(usuario == "" || senha =="")
            {
                MessageBox.Show("Usuário ou senha Inválidos");
                tb_usuario.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Login efetuado com sucesso");
                this.Close();
            }
                    
            
            

            
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            // this.Close();
        }
    }
}
