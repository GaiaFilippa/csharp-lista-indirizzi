using csharp_lista_indirizzi;
using System.Security.AccessControl;

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

StreamReader file = File.OpenText("C:/Users/Utente/Desktop/Files/addresses.csv");

int contatoreRigheLette = 0;

while (!file.EndOfStream)
{

    string rigaDiTestoLetta = file.ReadLine();
    contatoreRigheLette++;

    if (contatoreRigheLette > 1)
    {
        string[] informazioniSeparate = rigaDiTestoLetta.Split(',');

        if (informazioniSeparate.Length != 6)
        {
            Console.WriteLine("La riga " + contatoreRigheLette + "non rispetta lo standard richiesto di 6 informazioni per riga.");
        }
        else
        {

            int zipIndirizzo = int.Parse(informazioniSeparate[6]);

            try
            {
                Indirizzo indirizzoAcquisito = new Indirizzo(informazioniSeparate[0], informazioniSeparate[1], informazioniSeparate[2], informazioniSeparate[3], informazioniSeparate[4], zipIndirizzo);
                listaIndirizzi.Add(indirizzoAcquisito);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("C'è stato un errore nella lettura del,indirizzo in riga n° " + contatoreRigheLette);
                Console.WriteLine("L'errore è: " + ex.Message);

            }
        }
    }

    file.Close();
}


Console.WriteLine(listaIndirizzi.ToString());

