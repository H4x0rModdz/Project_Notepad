using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloco_de_Notas
{
    public partial class Replace : Form
    {
        public Replace()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreplace_Click(object sender, EventArgs e)
        {
            if (((Form1)this.Owner).TxtBoxConteudo.Text != "") // meu if
            { 
                String busca = txtBoxLocaliza.Text;
                String nova = txtBoxSubstituir.Text;
                String text = ((Form1)this.Owner).TxtBoxConteudo.Text;

                ((Form1)this.Owner).TxtBoxConteudo.Text = text.Replace(busca, nova);

                this.Close();
            } else
            {
                MessageBox.Show("Texto não encontrado para substituição", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
