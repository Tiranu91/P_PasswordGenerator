namespace PasswordGenerator
{
    partial class GUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn__generate = new System.Windows.Forms.Button();
            this.tb_passphrase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn__generate
            // 
            this.btn__generate.Location = new System.Drawing.Point(153, 102);
            this.btn__generate.Name = "btn__generate";
            this.btn__generate.Size = new System.Drawing.Size(75, 23);
            this.btn__generate.TabIndex = 0;
            this.btn__generate.Text = "Generieren";
            this.btn__generate.UseVisualStyleBackColor = true;
            this.btn__generate.Click += new System.EventHandler(this.btn__generate_Click);
            // 
            // tb_passphrase
            // 
            this.tb_passphrase.Location = new System.Drawing.Point(102, 42);
            this.tb_passphrase.Name = "tb_passphrase";
            this.tb_passphrase.Size = new System.Drawing.Size(183, 20);
            this.tb_passphrase.TabIndex = 1;
            this.tb_passphrase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 155);
            this.Controls.Add(this.tb_passphrase);
            this.Controls.Add(this.btn__generate);
            this.Name = "GUI";
            this.Text = "Passwort Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn__generate;
        private System.Windows.Forms.TextBox tb_passphrase;
    }
}

