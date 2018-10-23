using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LP2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_LoginSenha_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_SenhaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            var login = "1";
            var senha = "1";

            if(userCampo.Text == login && senhaCampo.Text == senha)
            {
                this.Hide();
                var lol = new Atividades_Usuarios();
                lol.ShowDialog();
 
            }
            else
            {
                erroLogin.Show();
            }   
        }

        private void cadastro_Click(object sender, EventArgs e)
        {
            Hide();
            var nova_janela = new Cadastro();
            nova_janela.ShowDialog();
            
        }
    }
}
