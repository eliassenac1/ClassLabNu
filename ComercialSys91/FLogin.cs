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
              



        public FLogin()
        {
            InitializeComponent();
            
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
          
            
            

            if (Usuario.EfetuarLogin (tb_usuario.Text, tb_senha.Text))
            {
                
                
                this.Close();
                
            }
            else
            {
                lb_errologin.Text = "Usuário ou Senha Inválidos";
                tb_usuario.Clear();
                tb_senha.Clear();
                tb_usuario.Focus();
                
            }
                    
            
            

            
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            // this.Close();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
