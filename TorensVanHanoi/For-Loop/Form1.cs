using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Loop
{
    public partial class ForLoop : Form
    {
        public ForLoop()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, EventArgs e)
        {
            double stappen = 1;
            double disk;
            int invoer = 1;

            bool gelukt = double.TryParse(schijvenTextBox.Text, out disk);

            if (gelukt)
            {
                for (double i = stappen; i <= disk; i++)
                {
                    lblAnswer.Text = string.Format("Je hebt voor {0} schijven {1} stappen nodig.", invoer, stappen);
                    stappen = stappen * 2 + 1;
                    invoer = invoer + 1;


                 

                    if (stappen / 3600 > 1)
                    {
                        stappen = stappen / 3600;
                        lblTime.Text = string.Format("Dat is dan {0} uur", stappen);
                    }
                    else
                    {
                        lblTime.Text = string.Format("Dat is dan {0} seconden", stappen);
                    }

                    
                }
            }
            else
            {
                MessageBox.Show("Voer een cijfer is");
            }
        }
    }
}
