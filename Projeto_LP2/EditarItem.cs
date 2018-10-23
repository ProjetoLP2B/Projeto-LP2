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
    public partial class EditarItem : Form
    {
        public EditarItem()
        {
            InitializeComponent();
        }

        private void btn_CancelarCadItemIndicadores_Click(object sender, EventArgs e)
        {
            this.Hide();
            var qualquer = new ControleVisualização();
            qualquer.ShowDialog();
        }
    }
}
