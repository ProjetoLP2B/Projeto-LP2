using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Projeto_LP2
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        private bool validarSenha()
        {
            if (txt_ConfirmeSenhaCadastro.Text == "") return false;
            if (txt_ConfirmeSenhaCadastro.Text == txt_SenhaCadastro.Text)
            {
                return true;
            }
            else return false;
        }
        private bool validarEmail()
        {
            if (txt_EmailCadastro.Text == "") return false;
            string emailRegex = string.Format("{0}{1}",
             @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))",
             @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            bool emailValido = false;
            try
            {
                emailValido = Regex.IsMatch(
                    txt_EmailCadastro.Text,
                    emailRegex);
            }
            catch (RegexMatchTimeoutException)
            {
                emailValido = false;
            }

            return emailValido;
        }
        private bool validarUsuario()
        {
            if (txt_UsuarioCadastro.Text == "") return false;
            if (Regex.IsMatch(txt_UsuarioCadastro.Text, (@"[^a-zA-Z0-9_]")))
            {
                return false;
            }
            else return true;
        }
        private bool validarNome()
        {
            if (txt_NomeCadastro.Text == "") return false;
            if(Regex.IsMatch(txt_NomeCadastro.Text, (@"[^a-zA-Z0-9]"))){
                return false;
            }
            else return true;
        }
        private bool validarSobreNome()
        {
            if (txt_SobrenomeCadastro.Text == "") return false;
            if (Regex.IsMatch(txt_SobrenomeCadastro.Text, (@"[^a-zA-Z0-9]")))
            {
                return false;
            }
            else return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_UsuarioCadastro_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_SairCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Tela_Login = new Login();
            Tela_Login.ShowDialog();
        }

        private void txt_SobrenomeCadastro_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_CadastrarCadastro_Click(object sender, EventArgs e)
        {
            if (!validarEmail())
            {
                lblVerificaEmail.Visible = true;
            }
            else lblVerificaEmail.Visible = false;
            if (!validarNome())
            {
                lblVerificaNome.Visible = true;
            }
            else lblVerificaNome.Visible = false;
            if (!validarSobreNome())
            {
                lblVerificaSobrenome.Visible = true;
            }
            else lblVerificaSobrenome.Visible = false;
            if (!validarUsuario())
            {
                lblVerificaUsuario.Visible = true;
            }
            else lblVerificaUsuario.Visible = false;
            if (!validarSenha())
            {
                lblVerificiaSenha.Visible = true;
            }
            else lblVerificiaSenha.Visible = false;
            if (validarUsuario() && validarSobreNome() && validarEmail() && validarUsuario() && validarSenha())
            {
                if(MessageBox.Show("Cadadastro Efetuado! Deseja efetuar novo cadastro?", "Sucesso!", MessageBoxButtons.YesNo) == DialogResult.Yes){
                    txt_EmailCadastro.Text = null;
                        txt_ConfirmeSenhaCadastro.Text = null;
                        txt_NomeCadastro.Text = null;
                        txt_SenhaCadastro.Text = null;
                        txt_SobrenomeCadastro.Text = null;
                        txt_UsuarioCadastro.Text = null;
                }else{
                    
                    Login Tela_Login = new Login();
                    
                    Tela_Login.ShowDialog();
                }
            }
            }
        }
        }
