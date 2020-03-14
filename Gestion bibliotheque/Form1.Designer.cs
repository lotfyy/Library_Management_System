namespace Gestion_bibliotheque
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
            this.bt_gestionlivre = new System.Windows.Forms.Button();
            this.bt_gestionAdherent = new System.Windows.Forms.Button();
            this.bt_gestionEmprunt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_gestionlivre
            // 
            this.bt_gestionlivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gestionlivre.Location = new System.Drawing.Point(332, 49);
            this.bt_gestionlivre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_gestionlivre.Name = "bt_gestionlivre";
            this.bt_gestionlivre.Size = new System.Drawing.Size(113, 53);
            this.bt_gestionlivre.TabIndex = 0;
            this.bt_gestionlivre.Text = "gestion livre";
            this.bt_gestionlivre.UseVisualStyleBackColor = true;
            this.bt_gestionlivre.Click += new System.EventHandler(this.bt_gestionlivre_Click);
            // 
            // bt_gestionAdherent
            // 
            this.bt_gestionAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gestionAdherent.Location = new System.Drawing.Point(332, 109);
            this.bt_gestionAdherent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_gestionAdherent.Name = "bt_gestionAdherent";
            this.bt_gestionAdherent.Size = new System.Drawing.Size(113, 53);
            this.bt_gestionAdherent.TabIndex = 1;
            this.bt_gestionAdherent.Text = "gestion adherent";
            this.bt_gestionAdherent.UseVisualStyleBackColor = true;
            this.bt_gestionAdherent.Click += new System.EventHandler(this.bt_gestionAdherent_Click);
            // 
            // bt_gestionEmprunt
            // 
            this.bt_gestionEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gestionEmprunt.Location = new System.Drawing.Point(332, 168);
            this.bt_gestionEmprunt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_gestionEmprunt.Name = "bt_gestionEmprunt";
            this.bt_gestionEmprunt.Size = new System.Drawing.Size(113, 53);
            this.bt_gestionEmprunt.TabIndex = 2;
            this.bt_gestionEmprunt.Text = "gestion emprunt";
            this.bt_gestionEmprunt.UseVisualStyleBackColor = true;
            this.bt_gestionEmprunt.Click += new System.EventHandler(this.bt_gestionEmprunt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.bt_gestionEmprunt);
            this.Controls.Add(this.bt_gestionAdherent);
            this.Controls.Add(this.bt_gestionlivre);
            this.Font = new System.Drawing.Font("Impact", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Gestion Bibliotheque";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_gestionlivre;
        private System.Windows.Forms.Button bt_gestionAdherent;
        private System.Windows.Forms.Button bt_gestionEmprunt;
    }
}

