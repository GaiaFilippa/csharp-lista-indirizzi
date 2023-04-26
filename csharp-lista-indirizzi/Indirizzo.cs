using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Indirizzo
    {
        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private int zip;


        // costruttore
        public Indirizzo(string name, string surname, string street, string city, string province, int zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }

        // getters
        public string GetName()
        {
            return this.name;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        public string GetStreet()
        {
            return this.street;
        }

        public string GetCity()
        {
            return this.city;
        }

        public string GetProvince()
        {
            return this.province;
        }

        public int GetZip()
        {
            return this.zip;
        }

        // methods

        public string RappresentazioneInStringa()
        {
            string rapprStringa = "Nome: " + this.name + "\n";
            rapprStringa += "Cognome: " + this.surname + "\n";
            rapprStringa += "Via: " + this.street + "\n";
            rapprStringa += "Città: " + this.city + "\n";
            rapprStringa += "Provincia: " + this.province + "\n";
            rapprStringa += "ZIP: " + this.zip + "\n";

            rapprStringa += "\n";

            return rapprStringa;
        }
    }
}
