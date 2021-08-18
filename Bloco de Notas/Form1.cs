using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Bloco_de_Notas
{
    public partial class Form1 : Form
    {
        bool alterado;
        int zoom = 100;

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public Form1()
        {

            InitializeComponent();
            // posição de onde o bloco de notas vai ficar
            this.Location = new Point(Int32.Parse(config.AppSettings.Settings["windowPositionX"].Value), Int32.Parse(config.AppSettings.Settings["windowPositionY"].Value));
            this.Size = new Size(Int32.Parse(config.AppSettings.Settings["sizeW"].Value), Int32.Parse(config.AppSettings.Settings["sizeH"].Value));
            this.Text = "";

            //exibir ou n a barra de status
            statusBarToolStripMenuItem.Checked = true;

        }

        private void atualizaposition()
        {
            int linha = TxtBoxConteudo.GetLineFromCharIndex(TxtBoxConteudo.SelectionStart);
            int coluna = TxtBoxConteudo.SelectionStart - TxtBoxConteudo.GetFirstCharIndexFromLine(linha);
            tlStrpSttsLblPosition.Text = "Ln: " + linha.ToString() + " Col: " + coluna.ToString();

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtBoxConteudo_TextChanged(object sender, EventArgs e)
        {
            alterado = true;
            this.atualizaposition();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!alterado)
            {
                if (opnFlDlgAbrir.ShowDialog() == DialogResult.OK)
                {
                    this.abrir();
                }
            } else
            {
                if(MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "Notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.abrir();
                } else
                {
                    if(this.Text != "")
                    {
                        // significa que já existe um arquivo aberto
                        this.salvar(this.Text);
                    } else
                    {
                        this.salvarComo();
                    }
                }
            }
        }

        private void abrir()
        {
            //coloca o nome do arquivo como titulo do formulario
            if (!string.IsNullOrEmpty(Text))
            {
                Text = opnFlDlgAbrir.FileName;
                using (StreamReader reader = new StreamReader(opnFlDlgAbrir.OpenFile()))
                {
                    TxtBoxConteudo.Rtf = reader.ReadToEnd();
                    alterado = false;
                }
            }

        }

        private void salvar(String arquivo)
        {
            if(arquivo != "")
            {
                StreamWriter buffer = new StreamWriter(arquivo);
                buffer.Write(TxtBoxConteudo.Rtf);
                buffer.Close();
                this.Text = arquivo;
                alterado = false;
            } else
            {
                MessageBox.Show("Nome de arquivo inválido!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvarComo()
        {
            if(svFlDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                this.salvar(svFlDlgAbrir.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text != "")
            {
                // significa que já existe um arquivo aberto
                this.salvar(this.Text);
            }
            else
            {
                this.salvarComo();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.salvarComo();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtBoxConteudo.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(TxtBoxConteudo.SelectedRtf != "")
            {
                Clipboard.SetDataObject(TxtBoxConteudo.SelectedRtf); // é bom salvar como objeto pq em txt todas as info de fonte e cor serão perdidas
                TxtBoxConteudo.SelectedRtf = "";
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TxtBoxConteudo.SelectedRtf != "")
            {
                Clipboard.SetDataObject(TxtBoxConteudo.SelectedRtf);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                TxtBoxConteudo.SelectedText = (String)Clipboard.GetData(DataFormats.Text);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TxtBoxConteudo.SelectedRtf != "")
            {
                TxtBoxConteudo.SelectedRtf = "";
            }
        }

        private void searchWithBingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TxtBoxConteudo.SelectedRtf != "")
            {
                String texto = TxtBoxConteudo.SelectedText;
                texto.Replace(' ', '+'); // concatenar para mandar pro site
                System.Diagnostics.Process.Start("microsoft-edge:https://www.google.com.br/search?q=" + texto);
            } else
            {
                MessageBox.Show("É necessário selecionar um termo para pesquisar.", "Buscar com o Google", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtBoxConteudo.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TxtBoxConteudo.SelectedText != "")
            {
                MessageBox.Show("Erro: Não selecione textos ao adicionar data e hora.", "Error 77", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                TxtBoxConteudo.SelectedText = System.Environment.NewLine + DateTime.Now;
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.CheckState == CheckState.Checked) // n se usa true pois o CheckState tem 3 estados
            {
                wordWrapToolStripMenuItem.CheckState = CheckState.Unchecked;
                TxtBoxConteudo.WordWrap = false;
            } else
            {
                wordWrapToolStripMenuItem.CheckState = CheckState.Checked;
                TxtBoxConteudo.WordWrap = true;
            }
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pgStpDlg.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prntDlg.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!alterado)
            {
                if (opnFlDlgAbrir.ShowDialog() == DialogResult.OK)
                {
                    this.Text = "";
                    TxtBoxConteudo.Text = "";
                }
            }
            else
            {
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "Notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Text = "";
                    TxtBoxConteudo.Text = "";
                }
                else
                {
                    if (this.Text != "")
                    {
                        // significa que já existe um arquivo aberto
                        this.salvar(this.Text);
                    }
                    else
                    {
                        this.salvarComo();
                    }
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fntDlg.ShowDialog() == DialogResult.OK)
            {
                TxtBoxConteudo.SelectionFont = fntDlg.Font;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            config.AppSettings.Settings["windowPositionX"].Value = this.Location.X.ToString();
            config.AppSettings.Settings["windowPositionY"].Value = this.Location.X.ToString();
            config.AppSettings.Settings["sizeW"].Value = this.Size.Width.ToString();
            config.AppSettings.Settings["sizeH"].Value = this.Size.Height.ToString();
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            statusBarToolStripMenuItem.Checked = !statusBarToolStripMenuItem.Checked; // qnd ela recebe o contrário dela msm
            sttsInfo.Visible = !sttsInfo.Visible; // colocar a barra de status ou tirar ela
        }

        private void atualizaZoom()
        {
            tlStrpSttsLblZoom.Text = this.zoom.ToString() + "%"; // atualiza o zoom em %
        }

        private void expandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom++;
            TxtBoxConteudo.Font = new Font(TxtBoxConteudo.Font.FontFamily, TxtBoxConteudo.Font.Size + 1, TxtBoxConteudo.Font.Style);
            this.atualizaZoom();
        }

        private void reduceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom--;
            TxtBoxConteudo.Font = new Font(TxtBoxConteudo.Font.FontFamily, TxtBoxConteudo.Font.Size - 1, TxtBoxConteudo.Font.Style);
            this.atualizaZoom();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom = 100;
            TxtBoxConteudo.Font = new Font(TxtBoxConteudo.Font.FontFamily, 12, TxtBoxConteudo.Font.Style);
            this.atualizaZoom();
        }

        private void clrDlgColorMenuItem_Click(object sender, EventArgs e)
        {
            if(clrDlgColor.ShowDialog() == DialogResult.OK)
            {
                TxtBoxConteudo.SelectionColor = clrDlgColor.Color;
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace frm = new Replace();
            frm.txtBoxLocaliza.Text = TxtBoxConteudo.SelectedText;
            frm.Show(this);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localizar frm = new Localizar();
            frm.txtBoxLocaliza.Text = TxtBoxConteudo.SelectedText;
            frm.Show(this);
        }
    }
}
