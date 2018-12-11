using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machtsverheffen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, EventArgs e)
        {
            double n;
            // formule is n = schijven ( 2^n-1 )
            bool succes = double.TryParse(schijvenTextBox.Text, out n);

            if (succes)
            {
                double result = Math.Pow(2, n) - 1;
                antwoordLabel.Text = string.Format("{0}", result);
            }
            else
            {
                antwoordLabel.Text = "kan antwoord niet vinden" ;
            }

        }
    }
}
