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
    public partial class gestionempruntform : Form
    {
        public gestionempruntform()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionempruntform_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Form1.OurBib.LesEmprunts.lstEmprunts;
            cmb_CodeLivre.DataSource = Form1.OurBib.LesLivres.LesCodes();
            cmb_IdAdhérent.DataSource = Form1.OurBib.LesAdherents.LesIds();

        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
        }

        private void bt_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                Emprunt Ep = new Emprunt();
                Ep.IdAdherent = int.Parse(cmb_IdAdhérent.Text);
                Ep.CodeLivre = int.Parse(cmb_CodeLivre.Text);
                Ep.DateEmprunt = dtp_dateEmprunt.Value;
                Ep.DateRetour = dtp_dateRetour.Value;
                bool res = Form1.OurBib.LesEmprunts.Add(Ep);
                if (!res)
                    throw new Exception("L'Emprunt existe déjà...");
                MessageBox.Show("Emprunt ajouté avec succés...");

                //update the dataGridView's Content
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Form1.OurBib.LesEmprunts.lstEmprunts;

                bool res1 = Form1.OurBib.LesAdherents.AddEmprunt(int.Parse(cmb_IdAdhérent.Text));
                if (!res1)
                    throw new Exception("L'adhérent n'existe pas..");
                bool res2 = Form1.OurBib.LesLivres.AddEmprunt(int.Parse(cmb_CodeLivre.Text));
                if (!res2)
                    throw new Exception("Le livre n'existe pas..");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
