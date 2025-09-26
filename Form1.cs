using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sorusayisi = 0, dogrusayisi = 0, yanlissayisi = 0;

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            kullcvb.Text = btnA.Text;

            if (lbldogru.Text == kullcvb.Text)
            {
                dogrusayisi++;
                lbldogrusayisi.Text = dogrusayisi.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlissayisi++;
                lblyanlissayisi.Text = yanlissayisi.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            kullcvb.Text = btnB.Text;

            if (lbldogru.Text == kullcvb.Text)
            {
                dogrusayisi++;
                lbldogrusayisi.Text = dogrusayisi.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlissayisi++;
                lblyanlissayisi.Text = yanlissayisi.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            kullcvb.Text = btnC.Text;

            if (lbldogru.Text == kullcvb.Text)
            {
                dogrusayisi++;
                lbldogrusayisi.Text = dogrusayisi.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlissayisi++;
                lblyanlissayisi.Text = yanlissayisi.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            kullcvb.Text = btnD.Text;

            if (lbldogru.Text == kullcvb.Text)
            {
                dogrusayisi++;
                lbldogrusayisi.Text = dogrusayisi.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlissayisi++;
                lblyanlissayisi.Text = yanlissayisi.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnsonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            kullcvb.Text = "";

            sorusayisi++;
            lblsorusayisi.Text = sorusayisi.ToString();

            if (sorusayisi == 1)
            {
                richTextBox1.Text = "Türkiye'nin başkenti neresidir?";
                btnA.Text = "İstanbul";
                btnB.Text = "Ankara";
                btnC.Text = "İzmir";
                btnD.Text = "Bursa";
                lbldogru.Text = "Ankara";
            }
            else if (sorusayisi == 2)
            {
                richTextBox1.Text = "Dünyanın en yüksek dağı hangisidir?";
                btnA.Text = "K2";
                btnB.Text = "Everest";
                btnC.Text = "Kilimanjaro";
                btnD.Text = "Elbrus";
                lbldogru.Text = "Everest";
            }
            else if (sorusayisi == 3)
            {
                richTextBox1.Text = "En büyük okyanus hangisidir?";
                btnA.Text = "Atlantik Okyanusu";
                btnB.Text = "Hint Okyanusu";
                btnC.Text = "Pasifik Okyanusu";
                btnD.Text = "Arktik Okyanusu";
                lbldogru.Text = "Pasifik Okyanusu";
            }
            else if (sorusayisi == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = false;

                MessageBox.Show("Oyun Bitti!\nDoğru Sayısı: " + dogrusayisi + "\nYanlış Sayısı: " + yanlissayisi);
            }
        }
    }
}
