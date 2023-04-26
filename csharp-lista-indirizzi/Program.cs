using csharp_lista_indirizzi;
using System.Security.AccessControl;

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

StreamReader file = File.OpenText("C:\\Users\\Utente\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\addresses.csv");

int contatoreRigheLette = 0;

while (!file.EndOfStream)
{

    string rigaDiTestoLetta = file.ReadLine();
    contatoreRigheLette++;

    if (contatoreRigheLette > 0)
    {
        string[] informazioniSeparate = rigaDiTestoLetta.Split(',');

        if (informazioniSeparate.Length != 6)
        {
            Console.WriteLine("La riga " + contatoreRigheLette + "non rispetta lo standard richiesto di 6 informazioni per riga.");
        }
        else
        {

            try
            {
                Indirizzo indirizzoAcquisito = new Indirizzo(informazioniSeparate[0], informazioniSeparate[1], informazioniSeparate[2], informazioniSeparate[3], informazioniSeparate[4], informazioniSeparate[5]);
                listaIndirizzi.Add(indirizzoAcquisito);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("C'è stato un errore nella lettura del,indirizzo in riga n° " + contatoreRigheLette);
                Console.WriteLine("L'errore è: " + ex.Message);

            }
        }
    }

}

file.Close();

Console.WriteLine(listaIndirizzi);

