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
        private string zip;


        // costruttore
        public Indirizzo(string name, string surname, string street, string city, string province, string zip)
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

        public string GetZip()
        {
            return this.zip;
        }

        // methods

        public override string ToString()
        {
            string indirizzo = "Nome: " + this.name + "\n";
            indirizzo += "Cognome: " + this.surname + "\n";
            indirizzo += "Via: " + this.street + "\n";
            indirizzo += "Città: " + this.city + "\n";
            indirizzo += "Provincia: " + this.province + "\n";
            indirizzo += "ZIP: " + this.zip + "\n";

            indirizzo += "\n";

            return indirizzo;
        }
    }
}
