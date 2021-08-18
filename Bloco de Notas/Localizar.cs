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
    public partial class Localizar : Form
    {
        public Localizar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Localizar_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreplace_Click(object sender, EventArgs e)
        {
            String busca = txtBoxLocaliza.Text;
            String texto = ((Form1)this.Owner).TxtBoxConteudo.Text;

            RichTextBoxFinds regra = RichTextBoxFinds.None;
            if(chckBoxCaseSensitive.Checked == true)
            {
                regra = RichTextBoxFinds.MatchCase;
            }
            if(chckBoxMatch.Checked == true)
            {
                regra = RichTextBoxFinds.WholeWord;
            }
            int index = 0;

            while(index < ((Form1)this.Owner).TxtBoxConteudo.Text.LastIndexOf(busca))
            {
                ((Form1)this.Owner).TxtBoxConteudo.Find(busca, index, texto.Length, regra);
                ((Form1)this.Owner).TxtBoxConteudo.SelectionBackColor = Color.Lime;
                index = ((Form1)this.Owner).TxtBoxConteudo.Text.IndexOf(busca, index) + 1;
            }
            this.Close();
        }
    }
}
