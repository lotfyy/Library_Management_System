namespace Gestion_bibliotheque
{
    partial class gestionlivreform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NbE = new System.Windows.Forms.TextBox();
            this.txt_Auteur = new System.Windows.Forms.TextBox();
            this.txt_Titre = new System.Windows.Forms.TextBox();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.bt_Supprimer = new System.Windows.Forms.Button();
            this.bt_Modifier = new System.Windows.Forms.Button();
            this.bt_Ajouter = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(713, 425);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 2;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_NbE);
            this.groupBox1.Controls.Add(this.txt_Auteur);
            this.groupBox1.Controls.Add(this.txt_Titre);
            this.groupBox1.Controls.Add(this.txt_Code);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 267);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations des Livres";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_NbE
            // 
            this.txt_NbE.Location = new System.Drawing.Point(148, 172);
            this.txt_NbE.Name = "txt_NbE";
            this.txt_NbE.Size = new System.Drawing.Size(150, 20);
            this.txt_NbE.TabIndex = 14;
            this.txt_NbE.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txt_Auteur
            // 
            this.txt_Auteur.Location = new System.Drawing.Point(148, 143);
            this.txt_Auteur.Name = "txt_Auteur";
            this.txt_Auteur.Size = new System.Drawing.Size(150, 20);
            this.txt_Auteur.TabIndex = 13;
            this.txt_Auteur.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_Titre
            // 
            this.txt_Titre.Location = new System.Drawing.Point(148, 117);
            this.txt_Titre.Name = "txt_Titre";
            this.txt_Titre.Size = new System.Drawing.Size(150, 20);
            this.txt_Titre.TabIndex = 12;
            this.txt_Titre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(148, 91);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(150, 20);
            this.txt_Code.TabIndex = 11;
            this.txt_Code.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre Exemplaires";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Auteur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Titre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_Annuler);
            this.groupBox2.Controls.Add(this.bt_Supprimer);
            this.groupBox2.Controls.Add(this.bt_Modifier);
            this.groupBox2.Controls.Add(this.bt_Ajouter);
            this.groupBox2.Location = new System.Drawing.Point(386, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 266);
            this.groupBox2.TabIndex = 4;
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
            this.bt_Supprimer.Click += new System.EventHandler(this.bt_Supprimer_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(691, 148);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste des livres";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 100);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gestionlivreform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 482);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_close);
            this.Name = "gestionlivreform";
            this.Text = "gestionlivreform";
            this.Load += new System.EventHandler(this.gestionlivreform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_NbE;
        private System.Windows.Forms.TextBox txt_Auteur;
        private System.Windows.Forms.TextBox txt_Titre;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.Button bt_Supprimer;
        private System.Windows.Forms.Button bt_Modifier;
        private System.Windows.Forms.Button bt_Ajouter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}