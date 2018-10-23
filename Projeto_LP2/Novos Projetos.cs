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
    public partial class Novos_Projetos : Form
    {
        public Novos_Projetos()
        {
            InitializeComponent();
        }

        private void Novos_Projetos_Load(object sender, EventArgs e)
        {

        }

        private void cmb_PropriedadesNovoProj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var texto = comboBox.Text;
            comboBox.ResetText();



            if (texto != "")
            {
                for(int i = 0; i < listView1.Items.Count; i++)
                {
                    if (texto == listView1.Items[i].SubItems[1].Text)
                    {
                        MessageBox.Show("Propriedade já cadastrada!");
                        return;
                    }

                }
                int num = listView1.Items.Count + 1;
                string[] row = { num.ToString(), texto };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
            else
                MessageBox.Show("Erro!");

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exibirRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void remover_click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
        }

        private void cmbNovaSelecao(object sender, EventArgs e)
        {

        }
    }
}
