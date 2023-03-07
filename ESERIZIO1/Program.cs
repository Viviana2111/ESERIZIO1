namespace ESERIZIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Atleta andrea = new Atleta();
            andrea.nome = "Andrea";
            andrea.cognome = "Stefanini";
            andrea.sport = "Calciatore";
            andrea.sesso = "Maschio";

            Atleta francesca = new Atleta();
            francesca.nome = "Francesca";
            francesca.cognome = "Giorgio";
            francesca.sport = "Ginnasta";
            francesca.sesso = "Femmina";


            Dipendente giovanni = new Dipendente();
            giovanni.nome = "Giovanni";
            giovanni.cognome = "Gino";
            giovanni.matricola = 1222;

            Dipendente federica = new Dipendente();
            federica.nome = "Federica";
            federica.cognome = "Nono";
            federica.matricola = 1444;

            Animale tigre = new Animale();
            tigre.animal = "Tigre";
            tigre.specie = "Felino";
            tigre.ambiente = "Terra";
            tigre.dieta = "carnivoro";

            Animale giraffa = new Animale();
            giraffa.animal = "Giraffa";
            giraffa.specie = "Boh";
            giraffa.ambiente = "terra";
            giraffa.dieta = "erbivoro";

            Macchina toyota = new Macchina();
            toyota.prezzo = 24000;
            toyota.marca = "Toyota";
            toyota.modello = "Corolla";
            toyota.anno = 2013;

            Macchina puma = new Macchina();
            puma.prezzo = 27000;
            puma.marca = "Ford";
            puma.marca = "Puma";
            puma.anno = 2019;




        }


    }
    internal class Atleta
    //entry point

    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public string sport { get; set; }
        public string sesso { get; set; }
        public int anno { get; set; }

        public void PreseAtlete()
        { Console.WriteLine("Ciao {0} {1}, il tuo sport è {2} sei nella categoria {3} {4}", nome, cognome, sesso, anno); }


    }
}


internal class Dipendente
{

    public string nome { get; set; }
    public string cognome { get; set; }
    public int matricola { get; set; }

    public void Presentazione()
    { Console.WriteLine("Ciao {0} {1}, questo sarà il tuo numero di matricola: {3}", nome, cognome, matricola); }



}

internal class Animale
{
    public string animal { get; set; }
    public string specie { get; set; }
    public string ambiente { get; set; }
    public string dieta { get; set; }

    public void SchedaAnimale()
    {
        Console.WriteLine("Vi presento quest'animale La {0}, lui appartiete alla specie dei {1}, vive sulla {2} ed ha una dieta {3} ", animal, specie, ambiente, dieta);
    }

}
internal class Macchina
{
    public decimal prezzo { get; set; }
    public string marca { get; set; }
    public string modello { get; set; }
    public int anno { get; set; }

    public void View()
    { Console.WriteLine("Questa macchina {0}, costa {1}, è di marca {2}", modello, prezzo, marca); }


}


