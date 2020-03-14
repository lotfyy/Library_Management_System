namespace Gestion_bibliotheque
{
    partial class gestionadherentform
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.bt_Supprimer = new System.Windows.Forms.Button();
            this.bt_Modifier = new System.Windows.Forms.Button();
            this.bt_Ajouter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_NbreEmprunts = new System.Windows.Forms.ComboBox();
            this.txt_Emprunt = new System.Windows.Forms.Label();
            this.rd_Femme = new System.Windows.Forms.RadioButton();
            this.rd_Homme = new System.Windows.Forms.RadioButton();
            this.dtp_naiss = new System.Windows.Forms.DateTimePicker();
            this.txt_Titre = new System.Windows.Forms.TextBox();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_Genre = new System.Windows.Forms.Label();
            this.txt_Datenaiss = new System.Windows.Forms.Label();
            this.txt_Nom = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(774, 456);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 0;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(85, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(691, 148);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste des Adherents";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 100);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_Annuler);
            this.groupBox2.Controls.Add(this.bt_Supprimer);
            this.groupBox2.Controls.Add(this.bt_Modifier);
            this.groupBox2.Controls.Add(this.bt_Ajouter);
            this.groupBox2.Location = new System.Drawing.Point(459, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 266);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_NbreEmprunts);
            this.groupBox1.Controls.Add(this.txt_Emprunt);
            this.groupBox1.Controls.Add(this.rd_Femme);
            this.groupBox1.Controls.Add(this.rd_Homme);
            this.groupBox1.Controls.Add(this.dtp_naiss);
            this.groupBox1.Controls.Add(this.txt_Titre);
            this.groupBox1.Controls.Add(this.txt_Code);
            this.groupBox1.Controls.Add(this.txt_Genre);
            this.groupBox1.Controls.Add(this.txt_Datenaiss);
            this.groupBox1.Controls.Add(this.txt_Nom);
            this.groupBox1.Controls.Add(this.txt_Id);
            this.groupBox1.Location = new System.Drawing.Point(73, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 267);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations des Adherents";
            // 
            // cmb_NbreEmprunts
            // 
            this.cmb_NbreEmprunts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_NbreEmprunts.FormattingEnabled = true;
            this.cmb_NbreEmprunts.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmb_NbreEmprunts.Location = new System.Drawing.Point(148, 201);
            this.cmb_NbreEmprunts.Name = "cmb_NbreEmprunts";
            this.cmb_NbreEmprunts.Size = new System.Drawing.Size(121, 21);
            this.cmb_NbreEmprunts.TabIndex = 17;
            // 
            // txt_Emprunt
            // 
            this.txt_Emprunt.AutoSize = true;
            this.txt_Emprunt.Location = new System.Drawing.Point(28, 204);
            this.txt_Emprunt.Name = "txt_Emprunt";
            this.txt_Emprunt.Size = new System.Drawing.Size(96, 13);
            this.txt_Emprunt.TabIndex = 16;
            this.txt_Emprunt.Text = "Emprunts en Cours";
            // 
            // rd_Femme
            // 
            this.rd_Femme.AutoSize = true;
            this.rd_Femme.Location = new System.Drawing.Point(248, 173);
            this.rd_Femme.Name = "rd_Femme";
            this.rd_Femme.Size = new System.Drawing.Size(59, 17);
            this.rd_Femme.TabIndex = 15;
            this.rd_Femme.TabStop = true;
            this.rd_Femme.Text = "Femme";
            this.rd_Femme.UseVisualStyleBackColor = true;
            // 
            // rd_Homme
            // 
            this.rd_Homme.AutoSize = true;
            this.rd_Homme.Location = new System.Drawing.Point(148, 173);
            this.rd_Homme.Name = "rd_Homme";
            this.rd_Homme.Size = new System.Drawing.Size(61, 17);
            this.rd_Homme.TabIndex = 14;
            this.rd_Homme.TabStop = true;
            this.rd_Homme.Text = "Homme";
            this.rd_Homme.UseVisualStyleBackColor = true;
            // 
            // dtp_naiss
            // 
            this.dtp_naiss.Location = new System.Drawing.Point(148, 146);
            this.dtp_naiss.Name = "dtp_naiss";
            this.dtp_naiss.Size = new System.Drawing.Size(200, 20);
            this.dtp_naiss.TabIndex = 13;
            // 
            // txt_Titre
            // 
            this.txt_Titre.Location = new System.Drawing.Point(148, 117);
            this.txt_Titre.Name = "txt_Titre";
            this.txt_Titre.Size = new System.Drawing.Size(200, 20);
            this.txt_Titre.TabIndex = 12;
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(148, 91);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(200, 20);
            this.txt_Code.TabIndex = 11;
            // 
            // txt_Genre
            // 
            this.txt_Genre.AutoSize = true;
            this.txt_Genre.Location = new System.Drawing.Point(28, 175);
            this.txt_Genre.Name = "txt_Genre";
            this.txt_Genre.Size = new System.Drawing.Size(36, 13);
            this.txt_Genre.TabIndex = 9;
            this.txt_Genre.Text = "Genre";
            this.txt_Genre.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_Datenaiss
            // 
            this.txt_Datenaiss.AutoSize = true;
            this.txt_Datenaiss.Location = new System.Drawing.Point(28, 146);
            this.txt_Datenaiss.Name = "txt_Datenaiss";
            this.txt_Datenaiss.Size = new System.Drawing.Size(96, 13);
            this.txt_Datenaiss.TabIndex = 8;
            this.txt_Datenaiss.Text = "Date de naissance";
            // 
            // txt_Nom
            // 
            this.txt_Nom.AutoSize = true;
            this.txt_Nom.Location = new System.Drawing.Point(28, 116);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(29, 13);
            this.txt_Nom.TabIndex = 7;
            this.txt_Nom.Text = "Nom";
            // 
            // txt_Id
            // 
            this.txt_Id.AutoSize = true;
            this.txt_Id.Location = new System.Drawing.Point(28, 91);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(16, 13);
            this.txt_Id.TabIndex = 6;
            this.txt_Id.Text = "Id";
            this.txt_Id.Click += new System.EventHandler(this.label1_Click);
            // 
            // gestionadherentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 482);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_close);
            this.Name = "gestionadherentform";
            this.Text = "gestionadherentform";
            this.Load += new System.EventHandler(this.gestionadherentform_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.Button bt_Supprimer;
        private System.Windows.Forms.Button bt_Modifier;
        private System.Windows.Forms.Button bt_Ajouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Titre;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label txt_Genre;
        private System.Windows.Forms.Label txt_Datenaiss;
        private System.Windows.Forms.Label txt_Nom;
        private System.Windows.Forms.Label txt_Id;
        private System.Windows.Forms.DateTimePicker dtp_naiss;
        private System.Windows.Forms.RadioButton rd_Femme;
        private System.Windows.Forms.RadioButton rd_Homme;
        private System.Windows.Forms.Label txt_Emprunt;
        private System.Windows.Forms.ComboBox cmb_NbreEmprunts;
    }
}