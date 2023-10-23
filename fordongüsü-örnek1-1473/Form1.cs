using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fordongüsü_örnek1_1473
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;

            for(int i = 0; i < 10; i++)
            {
                string metin = i.ToString() + "😍 🥰" + ad;
                lbAd.Items.Add(metin);
            }
        }
    }
}
