using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezar_Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string acik_mesaj = tx_acikmesaj.Text;
            string sifreli_mesaj = "";
            List<char> karekter = acik_mesaj.ToCharArray().ToList();

            for ( int i=0; i < karekter.Count(); i++)
            {
                sifreli_mesaj = sifreli_mesaj + (char)(karekter[i] + Convert.ToInt32(tx_anahtar.Text));
            }

            tx_sifrelimesaj.Text = sifreli_mesaj;

        }
    }
}
