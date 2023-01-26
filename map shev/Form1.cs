using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace map_shev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clear();
        }

        private void pictureBoxStart1_Click(object sender, EventArgs e)
        {
            nameLabel.Text = "Race start 1";
            marafonLabel.Text = "Samba full marafon";
            clear();
        }

        private void pictureBoxfirst_Click(object sender, EventArgs e)
        {
            clear();
            nameLabel.Text = "МЦК Лужники";
            pictureBoxDrinks.Visible = true; labelDrinks.Visible = true;
            pictureBoxEnergy.Visible = true; labelEnergy.Visible = true;
        }

        private void pictureBoxsecond_Click(object sender, EventArgs e)
        {
            clear();
            nameLabel.Text = "Новодевичей монастырь";
            pictureBoxDrinks.Visible = true; labelDrinks.Visible = true;
            pictureBoxEnergy.Visible = true; labelEnergy.Visible = true;
            pictureBoxTuilets.Visible = true; labelToilets.Visible = true;
            pictureBoxInformation.Visible = true; labelInformation.Visible = true;
            pictureBoxMedical.Visible = true; labelMedical.Visible = true;
        }

        private void pictureBoxthird_Click(object sender, EventArgs e)
        {
            clear();
            nameLabel.Text = "Метро Киевская";
            pictureBoxDrinks.Visible = true; labelDrinks.Visible = true;
            pictureBoxEnergy.Visible = true; labelEnergy.Visible = true;
            pictureBoxTuilets.Visible = true; labelToilets.Visible = true;
        }

        private void pictureBoxforth_Click(object sender, EventArgs e)
        {
            clear();
            nameLabel.Text = "МИД";
            pictureBoxDrinks.Visible = true; labelDrinks.Visible = true;
            pictureBoxEnergy.Visible = true; labelEnergy.Visible = true;
            pictureBoxTuilets.Visible = true; labelToilets.Visible = true;
            pictureBoxMedical.Visible = true; labelMedical.Visible = true;
            pictureBoxMedical.Location = new Point(673, 382); labelMedical.Location = new Point(744, 396);
        }

        private void pictureBoxfifth_Click(object sender, EventArgs e)
        {
            clear();
            nameLabel.Text = "Парк Горького";
            pictureBoxDrinks.Visible = true; labelDrinks.Visible = true;
            pictureBoxEnergy.Visible = true; labelEnergy.Visible = true;
            pictureBoxTuilets.Visible = true; labelToilets.Visible = true;
            pictureBoxInformation.Visible = true; labelInformation.Visible = true;
        }

        private void pictureBoxsix_Click(object sender, EventArgs e)
        {
            clear();
            nameLabel.Text = "Здание РАН";
            pictureBoxDrinks.Visible = true; labelDrinks.Visible = true;
            pictureBoxEnergy.Visible = true; labelEnergy.Visible = true;
            pictureBoxTuilets.Visible = true; labelToilets.Visible = true;
        }

        private void pictureBoxseven_Click(object sender, EventArgs e)
        {
            clear();
            nameLabel.Text = "Метро Воробьевы горы";
            pictureBoxDrinks.Visible = true; labelDrinks.Visible = true;
            pictureBoxEnergy.Visible = true; labelEnergy.Visible = true;
            pictureBoxTuilets.Visible = true; labelToilets.Visible = true;
            pictureBoxInformation.Visible = true; labelInformation.Visible = true;
            pictureBoxMedical.Visible = true; labelMedical.Visible = true;
        }

        private void pictureBoxnine_Click(object sender, EventArgs e)
        {
            clear();
            nameLabel.Text = "Стадион Лужники";
            pictureBoxDrinks.Visible = true; labelDrinks.Visible = true;
            pictureBoxEnergy.Visible = true; labelEnergy.Visible = true;
            pictureBoxTuilets.Visible = true; labelToilets.Visible = true;
            pictureBoxInformation.Visible = true; labelInformation.Visible = true;
            pictureBoxMedical.Visible = true; labelMedical.Visible = true;
        }

        //снова делает все невидимыми
        private void clear()
        {
            pictureBoxDrinks.Visible = false; labelDrinks.Visible = false;
            pictureBoxEnergy.Visible = false; labelEnergy.Visible = false;
            pictureBoxTuilets.Visible = false; labelToilets.Visible = false;
            pictureBoxInformation.Visible = false; labelInformation.Visible = false;
            pictureBoxMedical.Visible = false; labelMedical.Visible = false;
        }

        private void pictureBoxStart3_Click(object sender, EventArgs e)
        {
            nameLabel.Text = "Race start 3";
            marafonLabel.Text = "Capoiera Fun Run 5km";
            clear();
        }

        private void pictureBoxStart2_Click(object sender, EventArgs e)
        {
            nameLabel.Text = "Race start 2";
            marafonLabel.Text = "Jongo Half Marafon";
            clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            nameLabel.Text = "ФИНИШ!!!";
        }
    }
}

