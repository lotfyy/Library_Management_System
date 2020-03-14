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
    public partial class gestionlivreform : Form
    {
        public gestionlivreform()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                Livre L = new Livre();
                L.Code = int.Parse(txt_Code.Text);
                L.Titre = txt_Titre.Text;
                L.Auteur = txt_Auteur.Text;
                L.NbreExplaire = int.Parse(txt_NbE.Text);
                bool res = Form1.OurBib.LesLivres.Add(L);
                if (!res)
                    throw new Exception("Le Livre existe déjà\n  Verifier Code");
                MessageBox.Show("Livre ajouté avec succés...");
                //update the dataGridView's Content
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Form1.OurBib.LesLivres.lstLivres;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //int RowIndex = dataGridView1.SelectedRows[0].Index;
                //ou bien
                int RowIndex = dataGridView1.CurrentRow.Index;
                int code = (int)dataGridView1[0, RowIndex].Value;
                if (RowIndex == -1)
                    throw new Exception("Vous devez selectionnez une ligne au niveau du dataGrid");
                txt_Code.Text = code.ToString();
                Livre L = Form1.OurBib.LesLivres.Find(code);
                if (L == null)
                    throw new Exception("Le Livre n'existe pas dans la bibliothèque");
                txt_Titre.Text = L.Titre;
                txt_Auteur.Text = L.Auteur;
                txt_NbE.Text = L.NbreExplaire.ToString();
                //ou bien à partir du dataGridView directement
                txt_Titre.Text = (string)dataGridView1[1, RowIndex].Value;
                txt_Auteur.Text = (string)dataGridView1[2, RowIndex].Value;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void gestionlivreform_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Form1.OurBib.LesLivres.lstLivres;
        }

        private void bt_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                int code = int.Parse(txt_Code.Text);
                bool res = Form1.OurBib.LesLivres.Remove(code);
                if (!res)
                    throw new Exception("Le Livre n'existe pas");
                MessageBox.Show("Livre supprimé avec succés...");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Form1.OurBib.LesLivres.lstLivres;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //int RowIndex = dataGridView1.SelectedRows[0].Index;
                //ou bien
                int RowIndex = dataGridView1.CurrentRow.Index;
                int code = (int)dataGridView1[0, RowIndex].Value;
                if (RowIndex == -1)
                    throw new Exception("Vous devez selectionnez une ligne au niveau du dataGrid");
                txt_Code.Text = code.ToString();
                Livre L = Form1.OurBib.LesLivres.Find(code);
                if (L == null)
                    throw new Exception("Le Livre n'existe pas dans la bibliothèque");
                txt_Titre.Text = L.Titre;
                txt_Auteur.Text = L.Auteur;
                txt_NbE.Text = L.NbreExplaire.ToString();
                //ou bien à partir du dataGridView directement
                //txt_Titre.Text = (string)dataGridView1[1, RowIndex].Value;
                //txt_Auteur.Text = (string)dataGridView1[2, RowIndex].Value;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var x = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString();
            // NB do not use .Value as it will not be set (committed) yet

            if (x.Length == 0)
            {
                MessageBox.Show("You must enter a value");
                e.Cancel = true;
            }
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    //int RowIndex = dataGridView1.SelectedRows[0].Index;
                    //ou bien
                    int RowIndex = dataGridView1.CurrentRow.Index;
                    int code = (int)dataGridView1[0, RowIndex].Value;
                    if (RowIndex == -1)
                        throw new Exception("Vous devez selectionnez une ligne au niveau du dataGrid");
                    txt_Code.Text = code.ToString();
                    Livre L = Form1.OurBib.LesLivres.Find(code);
                    if (L == null)
                        throw new Exception("Le Livre n'existe pas dans la bibliothèque");
                    txt_Titre.Text = L.Titre;
                    txt_Auteur.Text = L.Auteur;
                    txt_NbE.Text = L.NbreExplaire.ToString();

                    //or get values directly from the dataGridView
                    //txt_Titre.Text = (string)dataGridView1[1, RowIndex].Value;
                    //txt_Auteur.Text = (string)dataGridView1[2, RowIndex].Value;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }
    }
}
