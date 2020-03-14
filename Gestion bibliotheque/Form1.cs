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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static internal Bibliotheque OurBib = new Bibliotheque();

        private void bt_gestionlivre_Click(object sender, EventArgs e)
        {
            gestionlivreform glf = new gestionlivreform();
            glf.Show();
            //this.Hide();
        }

        private void bt_gestionAdherent_Click(object sender, EventArgs e)
        {
            gestionadherentform glf = new gestionadherentform();
            glf.Show();
            this.Hide();
        }

        private void bt_gestionEmprunt_Click(object sender, EventArgs e)
        {
            gestionempruntform glf = new gestionempruntform();
            glf.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var response = MessageBox.Show("Would you really close the window?", "Close Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            e.Cancel = (response == DialogResult.No);
        }
    }
}
