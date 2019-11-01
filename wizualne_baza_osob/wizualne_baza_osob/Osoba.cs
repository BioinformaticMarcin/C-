using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wizualne_baza_osob
{
    public class Osoba
    {
        public String imie;
        public String nazwisko;
        public int rok;
        public int wzrost;
        public String stanowisko;
        public Boolean plec;
        public int wynagrodzenie;

        public Osoba() { }
        public Osoba(String imie, String nazwisko, int rok, int wzrost, String stanowisko, Boolean plec, int wynagrodzenie)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rok = rok;
            this.wzrost = wzrost;
            this.stanowisko = stanowisko;
            this.plec = plec;
            this.wynagrodzenie = wynagrodzenie;
        }
    }
}
