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
    public partial class Relação_item_indicador : Form
    {
        public Relação_item_indicador()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nada a fazer ainda");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nova_janelay = new Controle_e_Visualização_com_Tipo();
            nova_janelay.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nada a fazer ainda");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nada a fazer ainda");
        }
    }
}
