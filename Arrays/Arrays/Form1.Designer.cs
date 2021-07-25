
namespace Arrays
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
            this.btnTestar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVetorTextos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(179, 221);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(170, 71);
            this.btnTestar.TabIndex = 0;
            this.btnTestar.Text = "Testar Vetor";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(373, 221);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(170, 71);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVetorTextos
            // 
            this.btnVetorTextos.Location = new System.Drawing.Point(179, 308);
            this.btnVetorTextos.Name = "btnVetorTextos";
            this.btnVetorTextos.Size = new System.Drawing.Size(170, 71);
            this.btnVetorTextos.TabIndex = 2;
            this.btnVetorTextos.Text = "Vetor Textos";
            this.btnVetorTextos.UseVisualStyleBackColor = true;
            this.btnVetorTextos.Click += new System.EventHandler(this.btnVetorTextos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVetorTextos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTestar);
            this.Name = "Form1";
            this.Text = "Teste Array";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVetorTextos;
    }
}

