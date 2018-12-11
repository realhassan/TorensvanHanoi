using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursie
{
    public partial class Recursie : Form
    {
        public Recursie()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, EventArgs e)
        {
            double schijven;
            bool gelukt = double.TryParse(schijvenTextBox.Text, out schijven);

            if (!gelukt)
            {
                MessageBox.Show("Voer een getal in");
            }
            else
            {
                double result = count(0, 1, schijven);
                lblAnswer.Text = string.Format("{0} stappen", result);
            }


        }

        static double count(double zetten, double huidigeschijf, double schijven)
        {
            if (huidigeschijf > schijven)
            {
                return zetten;
            }
            else
            {
                zetten = zetten * 2 + 1;
                double resultaat = count(zetten, huidigeschijf + 1, schijven);

                return resultaat;
            }
        }
    }
}
