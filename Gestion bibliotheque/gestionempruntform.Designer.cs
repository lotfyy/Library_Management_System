namespace Gestion_bibliotheque
{
    partial class gestionempruntform
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
            this.bt_close = new System.Windows.Forms.Button();
            this.dtp_dateEmprunt = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_CodeLivre = new System.Windows.Forms.ComboBox();
            this.cmb_IdAdhérent = new System.Windows.Forms.ComboBox();
            this.dtp_dateRetour = new System.Windows.Forms.DateTimePicker();
            this.txt_Genre = new System.Windows.Forms.Label();
            this.txt_Datenaiss = new System.Windows.Forms.Label();
            this.txt_Nom = new System.Windows.Forms.Label();
            this.txt_kt = new System.Windows.Forms.Label();
            this.bt_Supprimer = new System.Windows.Forms.Button();
            this.bt_Modifier = new System.Windows.Forms.Button();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Ajouter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(764, 463);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 1;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // dtp_dateEmprunt
            // 
            this.dtp_dateEmprunt.Location = new System.Drawing.Point(148, 146);
            this.dtp_dateEmprunt.Name = "dtp_dateEmprunt";
            this.dtp_dateEmprunt.Size = new System.Drawing.Size(200, 20);
            this.dtp_dateEmprunt.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_CodeLivre);
            this.groupBox1.Controls.Add(this.cmb_IdAdhérent);
            this.groupBox1.Controls.Add(this.dtp_dateRetour);
            this.groupBox1.Controls.Add(this.dtp_dateEmprunt);
            this.groupBox1.Controls.Add(this.txt_Genre);
            this.groupBox1.Controls.Add(this.txt_Datenaiss);
            this.groupBox1.Controls.Add(this.txt_Nom);
            this.groupBox1.Controls.Add(this.txt_kt);
            this.groupBox1.Location = new System.Drawing.Point(69, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 267);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations des Adherents";
            // 
            // cmb_CodeLivre
            // 
            this.cmb_CodeLivre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CodeLivre.FormattingEnabled = true;
            this.cmb_CodeLivre.Location = new System.Drawing.Point(148, 86);
            this.cmb_CodeLivre.Name = "cmb_CodeLivre";
            this.cmb_CodeLivre.Size = new System.Drawing.Size(121, 21);
            this.cmb_CodeLivre.TabIndex = 19;
            // 
            // cmb_IdAdhérent
            // 
            this.cmb_IdAdhérent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_IdAdhérent.FormattingEnabled = true;
            this.cmb_IdAdhérent.Location = new System.Drawing.Point(148, 113);
            this.cmb_IdAdhérent.Name = "cmb_IdAdhérent";
            this.cmb_IdAdhérent.Size = new System.Drawing.Size(121, 21);
            this.cmb_IdAdhérent.TabIndex = 18;
            // 
            // dtp_dateRetour
            // 
            this.dtp_dateRetour.Location = new System.Drawing.Point(148, 172);
            this.dtp_dateRetour.Name = "dtp_dateRetour";
            this.dtp_dateRetour.Size = new System.Drawing.Size(200, 20);
            this.dtp_dateRetour.TabIndex = 17;
            // 
            // txt_Genre
            // 
            this.txt_Genre.AutoSize = true;
            this.txt_Genre.Location = new System.Drawing.Point(28, 175);
            this.txt_Genre.Name = "txt_Genre";
            this.txt_Genre.Size = new System.Drawing.Size(65, 13);
            this.txt_Genre.TabIndex = 9;
            this.txt_Genre.Text = "Date Retour";
            // 
            // txt_Datenaiss
            // 
            this.txt_Datenaiss.AutoSize = true;
            this.txt_Datenaiss.Location = new System.Drawing.Point(28, 146);
            this.txt_Datenaiss.Name = "txt_Datenaiss";
            this.txt_Datenaiss.Size = new System.Drawing.Size(72, 13);
            this.txt_Datenaiss.TabIndex = 8;
            this.txt_Datenaiss.Text = "Date Emprunt";
            // 
            // txt_Nom
            // 
            this.txt_Nom.AutoSize = true;
            this.txt_Nom.Location = new System.Drawing.Point(28, 116);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(62, 13);
            this.txt_Nom.TabIndex = 7;
            this.txt_Nom.Text = "kt Adherent";
            // 
            // txt_kt
            // 
            this.txt_kt.AutoSize = true;
            this.txt_kt.Location = new System.Drawing.Point(28, 91);
            this.txt_kt.Name = "txt_kt";
            this.txt_kt.Size = new System.Drawing.Size(58, 13);
            this.txt_kt.TabIndex = 6;
            this.txt_kt.Text = "Code Livre";
            // 
            // bt_Supprimer
            // 
            this.bt_Supprimer.Location = new System.Drawing.Point(115, 140);
            this.bt_Supprimer.Name = "bt_Supprimer";
            this.bt_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.bt_Supprimer.TabIndex = 2;
            this.bt_Supprimer.Text = "Supprimer";
            this.bt_Supprimer.UseVisualStyleBackColor = true;
            // 
            // bt_Modifier
            // 
            this.bt_Modifier.Location = new System.Drawing.Point(115, 113);
            this.bt_Modifier.Name = "bt_Modifier";
            this.bt_Modifier.Size = new System.Drawing.Size(75, 23);
            this.bt_Modifier.TabIndex = 1;
            this.bt_Modifier.Text = "Modifier";
            this.bt_Modifier.UseVisualStyleBackColor = true;
            // 
            // bt_Annuler
            // 
            this.bt_Annuler.Location = new System.Drawing.Point(115, 168);
            this.bt_Annuler.Name = "bt_Annuler";
            this.bt_Annuler.Size = new System.Drawing.Size(75, 23);
            this.bt_Annuler.TabIndex = 3;
            this.bt_Annuler.Text = "Annuler";
            this.bt_Annuler.UseVisualStyleBackColor = true;
            this.bt_Annuler.Click += new System.EventHandler(this.bt_Annuler_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_Annuler);
            this.groupBox2.Controls.Add(this.bt_Supprimer);
            this.groupBox2.Controls.Add(this.bt_Modifier);
            this.groupBox2.Controls.Add(this.bt_Ajouter);
            this.groupBox2.Location = new System.Drawing.Point(455, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 266);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // bt_Ajouter
            // 
            this.bt_Ajouter.Location = new System.Drawing.Point(115, 85);
            this.bt_Ajouter.Name = "bt_Ajouter";
            this.bt_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.bt_Ajouter.TabIndex = 0;
            this.bt_Ajouter.Text = "Ajouter";
            this.bt_Ajouter.UseVisualStyleBackColor = true;
            this.bt_Ajouter.Click += new System.EventHandler(this.bt_Ajouter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 100);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(81, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(691, 148);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste des Emprunts";
            // 
            // gestionempruntform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bt_close);
            this.Name = "gestionempruntform";
            this.Text = "gestionempruntform";
            this.Load += new System.EventHandler(this.gestionempruntform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.DateTimePicker dtp_dateEmprunt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_CodeLivre;
        private System.Windows.Forms.ComboBox cmb_IdAdhérent;
        private System.Windows.Forms.DateTimePicker dtp_dateRetour;
        private System.Windows.Forms.Label txt_Genre;
        private System.Windows.Forms.Label txt_Datenaiss;
        private System.Windows.Forms.Label txt_Nom;
        private System.Windows.Forms.Label txt_kt;
        private System.Windows.Forms.Button bt_Supprimer;
        private System.Windows.Forms.Button bt_Modifier;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_Ajouter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}