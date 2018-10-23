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
    public partial class ControleVisualização : Form
    {
        public ControleVisualização()
        {
            InitializeComponent();
        }

        private void ControleVisualização_Load(object sender, EventArgs e)
        {

        }

        private void lstViewControle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_RelacaoControlView_Click(object sender, EventArgs e)
        {
            this.Close();
            var nova_janelaY = new Relação_item_indicador();
            nova_janelaY.ShowDialog();
        }

        private void btn_EditarControlView_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nova_janelaX = new EditarItem();
            nova_janelaX.ShowDialog();
        }

        private void btn_DeletarControlView_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddControlView_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nova_janela1 = new CadItemIndicador();
            nova_janela1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nova_janelax = new Atividades_Usuarios();
            nova_janelax.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
