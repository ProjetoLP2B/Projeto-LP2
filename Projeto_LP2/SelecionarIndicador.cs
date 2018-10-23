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
    public partial class SelecionarIndicador : Form
    {
        public SelecionarIndicador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var new_window1 = new Controle_e_Visualização_com_Tipo();
            new_window1.ShowDialog();
        }
    }
}
