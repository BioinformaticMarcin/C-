using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace thready
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_start.BackColor = Color.Green;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            int min = 0;
            String blad = ""; 
            
            if (textBox_wiadomosc.Text == "")
            {
                blad += "Pole wiadomosc jest puste\n";
                textBox_wiadomosc.BackColor = Color.Red;
            }

            try
            {
                min = int.Parse(textBox_min.Text);
            }
            catch (FormatException)
            {
                if(textBox_min.Text == "")
                {
                    blad += "Pole minuty jest puste";
                    textBox_min.BackColor = Color.Red;
                }
                else
                {
                    blad += "Pole minuty zawiera błąd";
                    textBox_min.BackColor = Color.Red;
                }
            }
            if(blad == "")
            {
                KlasaWWatku kww = new KlasaWWatku(textBox_wiadomosc.Text, min);
                Thread watek = new Thread(new ThreadStart(kww.run));
                watek.Start();
            }
            else
            {
                MessageBox.Show(blad, "Error #5346");
            }
        }

        private void textBox_min_TextChanged(object sender, EventArgs e)
        {
            textBox_min.BackColor = Color.White;
        }

        private void textBox_wiadomosc_TextChanged(object sender, EventArgs e)
        {
            textBox_wiadomosc.BackColor = Color.White;
        }

        private void button_start_MouseUp(object sender, MouseEventArgs e)
        {
            button_start.BackColor = Color.Green;
        }

        private void button_start_MouseDown(object sender, MouseEventArgs e)
        {
            button_start.BackColor = Color.Red;
        }
    }
}
