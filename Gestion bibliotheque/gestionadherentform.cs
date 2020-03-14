using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_bibliotheque
{
    public partial class gestionadherentform : Form
    {
        public gestionadherentform()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionadherentform_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Form1.OurBib.LesAdherents.lstAdherents;
            cmb_NbreEmprunts.SelectedIndex = 0;


        }

        private void bt_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                Adherent ad = new Adherent();
                int x = int.Parse(txt_Id.Text);
                if (x <= 0)
                    throw new Exception("erreur Id negatif");
                ad.ID = x;
                ad.Nom = txt_Titre.Text;
                ad.Datenaiss = dtp_naiss.Value;
                ad.Sexe = Genre.Homme;
                if (rd_Femme.Checked)
                    ad.Sexe = Genre.Femme;
                ad.NoEmpruntEnCours = int.Parse(cmb_NbreEmprunts.Text);
                bool res = Form1.OurBib.LesAdherents.Add(ad);
                if (!res)
                    throw new Exception("L'adhérent existe déjà\n  Verifier Id");
                MessageBox.Show("Adhérent ajouté avec succés...");




                //update the dataGridView's Content
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Form1.OurBib.LesAdherents.lstAdherents;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_Modifier_Click(object sender, EventArgs e)
        {
            Adherent ad = Form1.OurBib.LesAdherents.FindById(11);
            MessageBox.Show(ad.Nom);
        }
        private void Bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();

            // To show the hidden Form (Form1 in our case)
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Form1);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }


    }
    
}
