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
    public partial class EditarIndicadores : Form
    {
        public EditarIndicadores()
        {
            InitializeComponent();
        }

        private void btn_CancelarCadItemIndicadores_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nova_janela3 = new Controle_e_Visualização_com_Tipo();
            nova_janela3.ShowDialog();
            
        }

        private void btn_OKCadItemIndicadores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nava a fazer ainda");
        }
    }
}
