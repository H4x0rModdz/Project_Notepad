namespace Bloco_de_Notas
{
    partial class Replace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replace));
            this.txtBoxLocaliza = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSubstituir = new System.Windows.Forms.RichTextBox();
            this.btnreplace = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxLocaliza
            // 
            this.txtBoxLocaliza.Location = new System.Drawing.Point(82, 4);
            this.txtBoxLocaliza.Name = "txtBoxLocaliza";
            this.txtBoxLocaliza.Size = new System.Drawing.Size(192, 18);
            this.txtBoxLocaliza.TabIndex = 0;
            this.txtBoxLocaliza.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Localize:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "replace with:";
            // 
            // txtBoxSubstituir
            // 
            this.txtBoxSubstituir.Location = new System.Drawing.Point(82, 28);
            this.txtBoxSubstituir.Name = "txtBoxSubstituir";
            this.txtBoxSubstituir.Size = new System.Drawing.Size(192, 20);
            this.txtBoxSubstituir.TabIndex = 3;
            this.txtBoxSubstituir.Text = "";
            // 
            // btnreplace
            // 
            this.btnreplace.Location = new System.Drawing.Point(292, 4);
            this.btnreplace.Name = "btnreplace";
            this.btnreplace.Size = new System.Drawing.Size(173, 22);
            this.btnreplace.TabIndex = 4;
            this.btnreplace.Text = "Replace All";
            this.btnreplace.UseVisualStyleBackColor = true;
            this.btnreplace.Click += new System.EventHandler(this.btnreplace_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(292, 31);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(173, 23);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 239);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnreplace);
            this.Controls.Add(this.txtBoxSubstituir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxLocaliza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Replace";
            this.Text = "Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnreplace;
        private System.Windows.Forms.Button btncancel;
        public System.Windows.Forms.RichTextBox txtBoxLocaliza;
        public System.Windows.Forms.RichTextBox txtBoxSubstituir;
    }
}