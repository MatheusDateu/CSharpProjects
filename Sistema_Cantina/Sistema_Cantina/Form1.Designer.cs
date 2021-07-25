
namespace Sistema_Cantina
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCaixa = new System.Windows.Forms.ListBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA CANTINA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CÓDIGO DO PRODUTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "VALOR TOTAL";
            // 
            // lstCaixa
            // 
            this.lstCaixa.FormattingEnabled = true;
            this.lstCaixa.ItemHeight = 20;
            this.lstCaixa.Location = new System.Drawing.Point(250, 166);
            this.lstCaixa.Name = "lstCaixa";
            this.lstCaixa.Size = new System.Drawing.Size(284, 224);
            this.lstCaixa.TabIndex = 3;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(82, 208);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(162, 27);
            this.txtProduto.TabIndex = 4;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // picImagem
            // 
            this.picImagem.Image = ((System.Drawing.Image)(resources.GetObject("picImagem.Image")));
            this.picImagem.Location = new System.Drawing.Point(82, 241);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(162, 148);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 5;
            this.picImagem.TabStop = false;
            this.picImagem.Click += new System.EventHandler(this.picImagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lstCaixa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sistema Cantina";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCaixa;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.PictureBox picImagem;
    }
}

