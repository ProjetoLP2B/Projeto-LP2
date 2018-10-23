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
    public partial class CadIndicadores : Form
    {
        public CadIndicadores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadIndicadores_Load(object sender, EventArgs e)
        {

        }

        private void lbl_NomeCadIndicadores_Click(object sender, EventArgs e)
        {

        }

        private void lbl_DescricaoCadIndicadores_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ObsCadIndicadores_Click(object sender, EventArgs e)
        {

        }

        private void txt_ObsCadIndicadores_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_OKCadIndicadores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nada a fazer ainda");
        }

        private void btn_CancelarCadIndicadores_Click(object sender, EventArgs e)
        {
            this.Hide();
            var lol = new Controle_e_Visualização_com_Tipo();
            lol.ShowDialog();
        }

        private void txt_NomeCadIndicadores_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CodigoCadIndicadores_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
