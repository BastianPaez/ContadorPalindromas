namespace FrasePalindroma
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
            this.btnValidar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFrase = new System.Windows.Forms.TextBox();
            this.CantidadLetras = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(242, 200);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(180, 23);
            this.btnValidar.TabIndex = 0;
            this.btnValidar.Text = "Validar Frase";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(256, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese una frase.";
            // 
            // TxtFrase
            // 
            this.TxtFrase.Location = new System.Drawing.Point(85, 160);
            this.TxtFrase.MaxLength = 100;
            this.TxtFrase.Name = "TxtFrase";
            this.TxtFrase.Size = new System.Drawing.Size(530, 20);
            this.TxtFrase.TabIndex = 2;
            this.TxtFrase.TextChanged += new System.EventHandler(this.TxtFrase_TextChanged);
            // 
            // CantidadLetras
            // 
            this.CantidadLetras.AutoSize = true;
            this.CantidadLetras.Location = new System.Drawing.Point(621, 163);
            this.CantidadLetras.Name = "CantidadLetras";
            this.CantidadLetras.Size = new System.Drawing.Size(13, 13);
            this.CantidadLetras.TabIndex = 3;
            this.CantidadLetras.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "/100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(719, 51);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contador de palabras Palindromas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(718, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CantidadLetras);
            this.Controls.Add(this.TxtFrase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidar);
            this.Name = "Form1";
            this.Text = "Contador de Palindromas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFrase;
        private System.Windows.Forms.Label CantidadLetras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

