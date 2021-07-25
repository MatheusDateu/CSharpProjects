
namespace Array_Multidimensional
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
            this.btnArrayMulti = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArrayMulti
            // 
            this.btnArrayMulti.Location = new System.Drawing.Point(164, 207);
            this.btnArrayMulti.Name = "btnArrayMulti";
            this.btnArrayMulti.Size = new System.Drawing.Size(216, 90);
            this.btnArrayMulti.TabIndex = 0;
            this.btnArrayMulti.Text = "Array Multidimensional";
            this.btnArrayMulti.UseVisualStyleBackColor = true;
            this.btnArrayMulti.Click += new System.EventHandler(this.btnArrayMulti_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(420, 207);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(216, 90);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnArrayMulti);
            this.Name = "Form1";
            this.Text = "Array Multidimensional";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArrayMulti;
        private System.Windows.Forms.Button btnSair;
    }
}

