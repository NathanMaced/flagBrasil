
namespace flagoBrasil
{
    partial class FormCombinacoes
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
            this.labelTexto = new System.Windows.Forms.Label();
            this.checkRetangulo = new System.Windows.Forms.CheckBox();
            this.checkLosango = new System.Windows.Forms.CheckBox();
            this.pictureBoxFormas = new System.Windows.Forms.PictureBox();
            this.checkBoxCirculo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTexto
            // 
            this.labelTexto.Location = new System.Drawing.Point(385, 96);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(353, 23);
            this.labelTexto.TabIndex = 0;
            this.labelTexto.Text = "Forma desconhecida";
            this.labelTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkRetangulo
            // 
            this.checkRetangulo.AutoSize = true;
            this.checkRetangulo.Location = new System.Drawing.Point(50, 102);
            this.checkRetangulo.Name = "checkRetangulo";
            this.checkRetangulo.Size = new System.Drawing.Size(75, 17);
            this.checkRetangulo.TabIndex = 1;
            this.checkRetangulo.Text = "Retângulo";
            this.checkRetangulo.UseVisualStyleBackColor = true;
            this.checkRetangulo.CheckedChanged += new System.EventHandler(this.checkRetangulo_CheckedChanged);
            // 
            // checkLosango
            // 
            this.checkLosango.AutoSize = true;
            this.checkLosango.Location = new System.Drawing.Point(50, 187);
            this.checkLosango.Name = "checkLosango";
            this.checkLosango.Size = new System.Drawing.Size(67, 17);
            this.checkLosango.TabIndex = 2;
            this.checkLosango.Text = "Losango";
            this.checkLosango.UseVisualStyleBackColor = true;
            this.checkLosango.CheckedChanged += new System.EventHandler(this.checkLosango_CheckedChanged);
            // 
            // pictureBoxFormas
            // 
            this.pictureBoxFormas.Image = global::flagoBrasil.Properties.Resources.duvida;
            this.pictureBoxFormas.Location = new System.Drawing.Point(385, 141);
            this.pictureBoxFormas.Name = "pictureBoxFormas";
            this.pictureBoxFormas.Size = new System.Drawing.Size(353, 237);
            this.pictureBoxFormas.TabIndex = 3;
            this.pictureBoxFormas.TabStop = false;
            this.pictureBoxFormas.Click += new System.EventHandler(this.pictureBoxFormas_Click);
            // 
            // checkBoxCirculo
            // 
            this.checkBoxCirculo.AutoSize = true;
            this.checkBoxCirculo.Location = new System.Drawing.Point(50, 268);
            this.checkBoxCirculo.Name = "checkBoxCirculo";
            this.checkBoxCirculo.Size = new System.Drawing.Size(58, 17);
            this.checkBoxCirculo.TabIndex = 4;
            this.checkBoxCirculo.Text = "Circulo";
            this.checkBoxCirculo.UseVisualStyleBackColor = true;
            this.checkBoxCirculo.CheckedChanged += new System.EventHandler(this.checkBoxCirculo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nathan de Macedo Araujo";
            // 
            // FormCombinacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxCirculo);
            this.Controls.Add(this.pictureBoxFormas);
            this.Controls.Add(this.checkLosango);
            this.Controls.Add(this.checkRetangulo);
            this.Controls.Add(this.labelTexto);
            this.Name = "FormCombinacoes";
            this.Text = "O programa de combinações";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.CheckBox checkRetangulo;
        private System.Windows.Forms.CheckBox checkLosango;
        private System.Windows.Forms.PictureBox pictureBoxFormas;
        private System.Windows.Forms.CheckBox checkBoxCirculo;
        private System.Windows.Forms.Label label1;
    }
}

