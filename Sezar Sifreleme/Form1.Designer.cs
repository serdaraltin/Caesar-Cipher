namespace Sezar_Sifreleme
{
    partial class Form1
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
            this.tx_acikmesaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_anahtar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tx_sifrelimesaj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tx_acikmesaj
            // 
            this.tx_acikmesaj.Location = new System.Drawing.Point(127, 13);
            this.tx_acikmesaj.Name = "tx_acikmesaj";
            this.tx_acikmesaj.Size = new System.Drawing.Size(254, 20);
            this.tx_acikmesaj.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Açık Mesaj (plain text) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anahtar (key) :";
            // 
            // tx_anahtar
            // 
            this.tx_anahtar.Location = new System.Drawing.Point(127, 39);
            this.tx_anahtar.Name = "tx_anahtar";
            this.tx_anahtar.Size = new System.Drawing.Size(75, 20);
            this.tx_anahtar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Şifrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_sifrelimesaj
            // 
            this.tx_sifrelimesaj.Location = new System.Drawing.Point(127, 94);
            this.tx_sifrelimesaj.Multiline = true;
            this.tx_sifrelimesaj.Name = "tx_sifrelimesaj";
            this.tx_sifrelimesaj.Size = new System.Drawing.Size(254, 51);
            this.tx_sifrelimesaj.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 155);
            this.Controls.Add(this.tx_sifrelimesaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_anahtar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_acikmesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_acikmesaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_anahtar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tx_sifrelimesaj;
    }
}

