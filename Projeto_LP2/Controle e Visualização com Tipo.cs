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
    public partial class Controle_e_Visualização_com_Tipo : Form
    {
        public Controle_e_Visualização_com_Tipo()
        {
            InitializeComponent();
        }

        private void btn_AddControlView_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nova_janela = new CadIndicadores();
            nova_janela.ShowDialog();
        }

        private void lstViewControleTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_RelacaoControlView_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nova_janelaY = new Relação_item_indicador();
            nova_janelaY.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var new_window = new SelecionarIndicador();
            new_window.ShowDialog();
        }

        private void btn_EditarControlView_Click(object sender, EventArgs e)
        {
            this.Hide();
            var new_window1 = new EditarIndicadores();
            new_window1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atividades_Usuarios Window = new Atividades_Usuarios();
            Window.ShowDialog();
        }
    }
}
