namespace Bloco_de_Notas
{
    partial class Localizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Localizar));
            this.btncancel = new System.Windows.Forms.Button();
            this.btnreplace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxLocaliza = new System.Windows.Forms.RichTextBox();
            this.chckBoxCaseSensitive = new System.Windows.Forms.CheckBox();
            this.chckBoxMatch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(277, 33);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(173, 23);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnreplace
            // 
            this.btnreplace.Location = new System.Drawing.Point(277, 6);
            this.btnreplace.Name = "btnreplace";
            this.btnreplace.Size = new System.Drawing.Size(173, 22);
            this.btnreplace.TabIndex = 8;
            this.btnreplace.Text = "Find";
            this.btnreplace.UseVisualStyleBackColor = true;
            this.btnreplace.Click += new System.EventHandler(this.btnreplace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Localize:";
            // 
            // txtBoxLocaliza
            // 
            this.txtBoxLocaliza.Location = new System.Drawing.Point(67, 6);
            this.txtBoxLocaliza.Name = "txtBoxLocaliza";
            this.txtBoxLocaliza.Size = new System.Drawing.Size(192, 18);
            this.txtBoxLocaliza.TabIndex = 6;
            this.txtBoxLocaliza.Text = "";
            // 
            // chckBoxCaseSensitive
            // 
            this.chckBoxCaseSensitive.AutoSize = true;
            this.chckBoxCaseSensitive.Location = new System.Drawing.Point(67, 30);
            this.chckBoxCaseSensitive.Name = "chckBoxCaseSensitive";
            this.chckBoxCaseSensitive.Size = new System.Drawing.Size(113, 17);
            this.chckBoxCaseSensitive.TabIndex = 10;
            this.chckBoxCaseSensitive.Text = "Differ \"A\" from \"a\"";
            this.chckBoxCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // chckBoxMatch
            // 
            this.chckBoxMatch.AutoSize = true;
            this.chckBoxMatch.Location = new System.Drawing.Point(67, 53);
            this.chckBoxMatch.Name = "chckBoxMatch";
            this.chckBoxMatch.Size = new System.Drawing.Size(113, 17);
            this.chckBoxMatch.TabIndex = 11;
            this.chckBoxMatch.Text = "Match whole word";
            this.chckBoxMatch.UseVisualStyleBackColor = true;
            // 
            // Localizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 107);
            this.ControlBox = false;
            this.Controls.Add(this.chckBoxMatch);
            this.Controls.Add(this.chckBoxCaseSensitive);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnreplace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxLocaliza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Localizar";
            this.Text = "Localize";
            this.Load += new System.EventHandler(this.Localizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnreplace;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox txtBoxLocaliza;
        private System.Windows.Forms.CheckBox chckBoxCaseSensitive;
        private System.Windows.Forms.CheckBox chckBoxMatch;
    }
}