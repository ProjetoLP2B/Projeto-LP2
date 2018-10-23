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
    public partial class Atividades_Usuarios : Form
    {
        public Atividades_Usuarios()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Atividades_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void novo_projeto_Click(object sender, EventArgs e)
        {
            this.Hide();
            var lol = new Novos_Projetos();
            lol.ShowDialog();

        }

        private void gerenciar_dados_Click(object sender, EventArgs e)
        {
            this.Hide();
            var lol = new Controle_e_Visualização_com_Tipo();
            lol.ShowDialog();

        }

        private void gerItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var lol = new ControleVisualização();
            lol.ShowDialog();

        }

        private void OnFormCLose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
