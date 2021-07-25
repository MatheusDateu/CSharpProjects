
namespace Estrutura_De_Repetição_While_For
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboAnos = new System.Windows.Forms.ComboBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o ano:";
            // 
            // cboAnos
            // 
            this.cboAnos.FormattingEnabled = true;
            this.cboAnos.Location = new System.Drawing.Point(221, 144);
            this.cboAnos.Name = "cboAnos";
            this.cboAnos.Size = new System.Drawing.Size(151, 28);
            this.cboAnos.TabIndex = 1;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(74, 249);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(148, 29);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "Voltar à página";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(283, 249);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(148, 29);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.cboAnos);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAnos;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSair;
    }
}