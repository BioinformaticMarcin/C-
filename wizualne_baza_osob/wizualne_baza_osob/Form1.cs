using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace wizualne_baza_osob
{
    public partial class Okno_baza : Form
    {
        List<Osoba> lista_osob = new List<Osoba>();

        int whereIAmIndex;


        public Okno_baza()
        {
            InitializeComponent();
        }

        // Main funtion of WinForm, when open window
        private void Form1_Load(object sender, EventArgs e)
        {
            nowyStrip_Click(sender, e);

            Mechanizmy mechanizmy = new Mechanizmy();
            lista_osob = mechanizmy.readXML(lista_osob);
            whereIAmIndex = lista_osob.Count();
            controlNumer.Text = whereIAmIndex.ToString();
        }

        // Strip buttons functionality
        private void nowyStrip_Click(object sender, EventArgs e)
        {
            imieBox.Text = "";
            imieBox.BackColor = Color.White;

            nazwiskoBox.Text = "";
            nazwiskoBox.BackColor = Color.White;

            rokBox.Text = "";
            rokBox.BackColor = Color.White;

            wzrostBox.Text = "";
            wzrostBox.BackColor = Color.White;

            stanowiskocomboBox1.Text = "";
            stanowiskocomboBox1.BackColor = Color.White;

            wynagrodzenieBox.Text = "";
            wynagrodzenieBox.BackColor = Color.White;

            radioButtonmezczyzna.Checked = false;
            radioButtonkobieta.Checked = false;
            boxPlec.BackColor = Color.Transparent;

            statusLabel.Text = "";

            whereIAmIndex = lista_osob.Count();
            controlNumer.Text = whereIAmIndex.ToString();
        }

        private void dodajStrip_Click(object sender, EventArgs e)
        {
            if(whereIAmIndex == lista_osob.Count())
            {
                String bledy = "";

                String imie = imieBox.Text;
                if (imie == "")
                {
                    imieBox.BackColor = Color.Red;
                    bledy += "Pole \"imie\" jest puste\n";
                }

                String nazwisko = nazwiskoBox.Text;
                if (nazwisko == "")
                {
                    nazwiskoBox.BackColor = Color.Red;
                    bledy += "Pole \"nazwisko\" jest puste\n";
                }

                int rok = 0;
                try // try catche bo nie lyknie parsowania do int jesli bedzie cos innrgo niz liczby
                {
                    rok = int.Parse(rokBox.Text);
                }
                catch (Exception c)
                {
                    rokBox.BackColor = Color.Red;
                    if (rokBox.Text == "")
                    {
                        bledy += "Pole \"rok\" jest puste\n";
                    }
                    else
                    {
                        bledy += "Pole \"rok\" zawiera błąd\n";
                    }
                }

                int wzrost = 0;
                String[] wzr = wzrostBox.Text.Split(' ');
                try
                {
                    wzrost = int.Parse(wzr[0]);
                }
                catch (Exception c)
                {
                    wzrostBox.BackColor = Color.Red;
                    if (wzrostBox.Text == "")
                    {
                        bledy += "Pole \"wzrost\" jest puste\n";
                    }
                    else
                    {
                        bledy += "Pole \"wzrost\" zawiera błąd\n";
                    }
                }

                String stanowisko = stanowiskocomboBox1.Text;
                if (stanowisko == "")
                {
                    stanowiskocomboBox1.BackColor = Color.Red;
                    bledy += "Nie wybrano stanowiska\n";
                }

                Boolean plec = true;
                if (radioButtonmezczyzna.Checked || radioButtonkobieta.Checked)
                {
                    plec = radioButtonmezczyzna.Checked;
                }
                else
                {
                    boxPlec.BackColor = Color.Red;
                    bledy += "Nie zaznaczono płci\n";
                }

                int wynagrodzenie = 0;
                String[] wyn = wynagrodzenieBox.Text.Split(' ');
                try
                {
                    wynagrodzenie = int.Parse(wyn[0]);
                }
                catch (Exception c)
                {
                    wynagrodzenieBox.BackColor = Color.Red;
                    if (wynagrodzenieBox.Text == "")
                    {
                        bledy += "Pole \"wynagrodzenie\" jest puste\n";
                    }
                    else
                    {
                        bledy += "Pole \"wynagrodzenie\" zawiera błąd\n";
                    }
                }

                // Creates new object and adds it to list immediately

                if (bledy == "")
                {
                    lista_osob.Add(new Osoba(imie, nazwisko, rok, wzrost, stanowisko, plec, wynagrodzenie));
                    nowyStrip_Click(sender, e);
                    statusLabel.Text = "Pomyślnie dodano!";
                }
                else
                {
                    statusLabel.Text = "Popraw błędy!";
                    MessageBox.Show(bledy, "Error #3892: Blad dodawania"); //drugi element to nazwa okna
                }
            }
            else
            {
                MessageBox.Show("Element już jest dodany!", "Error #2435: Błąd dodawnia");
            }
            
        }

        private void zapiszStrip_Click(object sender, EventArgs e)
        {
            Mechanizmy mechanizmy = new Mechanizmy();
            mechanizmy.writeXML(lista_osob);
        }

        private void usunStrip_Click(object sender, EventArgs e) 
        {
            if(whereIAmIndex < lista_osob.Count())
            {
                lista_osob.RemoveAt(whereIAmIndex); 
                nowyStrip_Click(sender, e);
                statusLabel.Text = "Pomyślnie usunięto!";
            }
            else
            {
                statusLabel.Text = "Zmień kartę aby usunąć!";
            }
        }

        // Functions that make LEFT/RIGHT buttons working
        private void lewoStrip_Click(object sender, EventArgs e)
        {
            if(whereIAmIndex > 0) //when I'm on 1 index I have to add -1 and it'll be 0 - the first object
            {
                whereIAmIndex += -1;
                controlNumer.Text = whereIAmIndex.ToString();

                imieBox.Text = lista_osob[whereIAmIndex].imie;
                imieBox.BackColor = Color.White;

                nazwiskoBox.Text = lista_osob[whereIAmIndex].nazwisko;
                nazwiskoBox.BackColor = Color.White;

                rokBox.Text = lista_osob[whereIAmIndex].rok.ToString();
                rokBox.BackColor = Color.White;

                wzrostBox.Text = lista_osob[whereIAmIndex].wzrost.ToString() + " cm";
                wzrostBox.BackColor = Color.White;

                stanowiskocomboBox1.Text = lista_osob[whereIAmIndex].stanowisko;
                stanowiskocomboBox1.BackColor = Color.White;

                wynagrodzenieBox.Text = lista_osob[whereIAmIndex].wynagrodzenie.ToString() + " zł";
                wynagrodzenieBox.BackColor = Color.White;

                if (lista_osob[whereIAmIndex].plec == true)
                {
                    radioButtonmezczyzna.Checked = true;
                }
                else
                {
                    radioButtonkobieta.Checked = true;
                }
                boxPlec.BackColor = Color.Transparent;

                statusLabel.Text = "";
            }
            else
            {
                statusLabel.Text = "To jest pierwszy element";
            }
        }

        private void prawoStrip_Click(object sender, EventArgs e)
        {
            if (whereIAmIndex < lista_osob.Count() - 1) // -1 because last one has to make form clear
            {
                whereIAmIndex += 1;
                controlNumer.Text = whereIAmIndex.ToString();

                imieBox.Text = lista_osob[whereIAmIndex].imie;
                imieBox.BackColor = Color.White;

                nazwiskoBox.Text = lista_osob[whereIAmIndex].nazwisko;
                nazwiskoBox.BackColor = Color.White;

                rokBox.Text = lista_osob[whereIAmIndex].rok.ToString();
                rokBox.BackColor = Color.White;

                wzrostBox.Text = lista_osob[whereIAmIndex].wzrost.ToString() + " cm";
                wzrostBox.BackColor = Color.White;

                stanowiskocomboBox1.Text = lista_osob[whereIAmIndex].stanowisko;
                stanowiskocomboBox1.BackColor = Color.White;

                wynagrodzenieBox.Text = lista_osob[whereIAmIndex].wynagrodzenie.ToString() + " zł";
                wynagrodzenieBox.BackColor = Color.White;

                if (lista_osob[whereIAmIndex].plec == true)
                {
                    radioButtonmezczyzna.Checked = true;
                }
                else
                {
                    radioButtonkobieta.Checked = true;
                }
                boxPlec.BackColor = Color.Transparent;

                statusLabel.Text = "";
            }
            else if(whereIAmIndex == lista_osob.Count() - 1)
            {
                nowyStrip_Click(sender, e);
            }
            else
            {
                statusLabel.Text = "To jest ostatni element";
            }
        }

        private void lewoEndStrip_Click(object sender, EventArgs e)
        {
            if(whereIAmIndex != 0)
            {
                whereIAmIndex = 0; // Of course first object
                controlNumer.Text = whereIAmIndex.ToString();

                imieBox.Text = lista_osob[whereIAmIndex].imie;
                imieBox.BackColor = Color.White;

                nazwiskoBox.Text = lista_osob[whereIAmIndex].nazwisko;
                nazwiskoBox.BackColor = Color.White;

                rokBox.Text = lista_osob[whereIAmIndex].rok.ToString();
                rokBox.BackColor = Color.White;

                wzrostBox.Text = lista_osob[whereIAmIndex].wzrost.ToString() + " cm";
                wzrostBox.BackColor = Color.White;

                stanowiskocomboBox1.Text = lista_osob[whereIAmIndex].stanowisko;
                stanowiskocomboBox1.BackColor = Color.White;

                wynagrodzenieBox.Text = lista_osob[whereIAmIndex].wynagrodzenie.ToString() + " zł";
                wynagrodzenieBox.BackColor = Color.White;

                if (lista_osob[whereIAmIndex].plec == true)
                {
                    radioButtonmezczyzna.Checked = true;
                }
                else
                {
                    radioButtonkobieta.Checked = true;
                }
                boxPlec.BackColor = Color.Transparent;

                statusLabel.Text = "";
            }
            else
            {
                statusLabel.Text = "To jest pierwszy element";
            }
        }

        private void prawoEndStrip_Click(object sender, EventArgs e)
        {
            if (whereIAmIndex != lista_osob.Count() - 1) // Must be diffrent from last object
            {
                whereIAmIndex = lista_osob.Count() - 1; // Last -1 because then it would be OutOfRange
                controlNumer.Text = whereIAmIndex.ToString();

                imieBox.Text = lista_osob[whereIAmIndex].imie;
                imieBox.BackColor = Color.White;

                nazwiskoBox.Text = lista_osob[whereIAmIndex].nazwisko;
                nazwiskoBox.BackColor = Color.White;

                rokBox.Text = lista_osob[whereIAmIndex].rok.ToString();
                rokBox.BackColor = Color.White;

                wzrostBox.Text = lista_osob[whereIAmIndex].wzrost.ToString() + " cm";
                wzrostBox.BackColor = Color.White;

                stanowiskocomboBox1.Text = lista_osob[whereIAmIndex].stanowisko;
                stanowiskocomboBox1.BackColor = Color.White;

                wynagrodzenieBox.Text = lista_osob[whereIAmIndex].wynagrodzenie.ToString() + " zł";
                wynagrodzenieBox.BackColor = Color.White;

                if (lista_osob[whereIAmIndex].plec == true)
                {
                    radioButtonmezczyzna.Checked = true;
                }
                else
                {
                    radioButtonkobieta.Checked = true;
                }
                boxPlec.BackColor = Color.Transparent;

                statusLabel.Text = "";
            }
            else if(whereIAmIndex == lista_osob.Count() - 1)
            {
                statusLabel.Text = "To jest ostatni element";
            }
        }

        // That functions make red boxes white again and show status text
        private void imieBox_Click(object sender, EventArgs e)
        {
            imieBox.BackColor = Color.White;
            statusLabel.Text = "Wpisz imię";
        }

        private void nazwiskoBox_Click(object sender, EventArgs e)
        {
            nazwiskoBox.BackColor = Color.White;
            statusLabel.Text = "Wpisz nazwisko";
        }

        private void rokBox_Click(object sender, EventArgs e)
        {
            rokBox.BackColor = Color.White;
            statusLabel.Text = "Wpisz datę urodzenia (RRRR)";
        }

        private void wzrostBox_Click(object sender, EventArgs e)
        {
            wzrostBox.BackColor = Color.White;
            statusLabel.Text = "Wpisz wzrost (cm)";
        }

        private void stanowiskocomboBox1_Click(object sender, EventArgs e)
        {
            stanowiskocomboBox1.BackColor = Color.White;
            statusLabel.Text = "Wybierz stanowisko";
        }

        private void wynagrodzenieBox_Click(object sender, EventArgs e)
        {
            wynagrodzenieBox.BackColor = Color.White;
            statusLabel.Text = "Wpisz wynagrodzenie (zł)";
        }

        private void radioButtonmezczyzna_Click(object sender, EventArgs e)
        {
            boxPlec.BackColor = Color.Transparent;
            statusLabel.Text = "";
        }

        private void radioButtonkobieta_Click(object sender, EventArgs e)
        {
            boxPlec.BackColor = Color.Transparent;
            statusLabel.Text = "";
        }

        //That creates 4 new example objects
        private void controlNumer_Click(object sender, EventArgs e)
        {
            lista_osob.Add(new Osoba("Marcin", "Werbliński", 1998, 173, "Prezes", true, 1290));
            lista_osob.Add(new Osoba("Marek", "Rurka", 1976, 160, "Stażysta", true, 3000));
            lista_osob.Add(new Osoba("Karola", "Kotowska", 1989, 165, "Pracownik", false, 1500));
            lista_osob.Add(new Osoba("Anna", "Stołek", 1985, 180, "Prezes", false, 30000));
            whereIAmIndex = lista_osob.Count();
            controlNumer.Text = whereIAmIndex.ToString();
        }

        //Magic functions that they add zl and cm at endings of some textboxes
        private void wynagrodzenieBox_Leave(object sender, EventArgs e)
        {
            if(wynagrodzenieBox.Text != "")
            {
                wynagrodzenieBox.Text += " zł";
            }
        }

        private void wynagrodzenieBox_Enter(object sender, EventArgs e)
        {
            String[] wyn = wynagrodzenieBox.Text.Split(' ');
            wynagrodzenieBox.Text = wyn[0];
        }

        private void wzrostBox_Enter(object sender, EventArgs e)
        {
            String[] wzr = wzrostBox.Text.Split(' ');
            wzrostBox.Text = wzr[0];
        }

        private void wzrostBox_Leave(object sender, EventArgs e)
        {
            if (wzrostBox.Text != "")
            {
                wzrostBox.Text += " cm";
            }
        }
    }
}
