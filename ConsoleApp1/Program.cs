namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Atleta luigi = new Atleta();

            luigi.Presentazione();
            Console.WriteLine(luigi.Vittorie());
            luigi.WinStreack();
   
            Atleta fernando = new Atleta();
            fernando.VittorieMassime(20);



            Dipendente pinco = new Dipendente();
            pinco.Lamentela();
            pinco.Boh();

            Dipendente coso = new Dipendente();
            coso.Contratto(59);
            coso.Boh();


            Animale domenico = new Animale();
            domenico.Saluto();
            domenico.Dieta();
            domenico.PesoDaPerdere();

            Animale fuffy = new Animale();
            fuffy.NumeroCanasse(30);
            fuffy.Saluto();

            Veicolo panda = new Veicolo();
            panda.ShowRoom();
            Console.WriteLine(panda.CambioMarca());
            panda.NuovaMarca();

            Veicolo dommy = new Veicolo();
            dommy.NumeroPneumatici(50);
            dommy.ShowRoom();
        }
    }

    internal class Atleta
    {
        public int Height = 180;
        public string Sport = "Calcio";
        public int Winner = 15;

        public void Presentazione()
        {
            Console.WriteLine("il mio sport preferito è " + Sport + " e ho " + Winner + "vittore");
        }
           
        public int Vittorie()
        {
            return 10 + Winner;
        }

        public void VittorieMassime(int delta)
        {
            Winner = Winner + delta;
        }

        public void WinStreack()
        {
            Console.WriteLine("tra " + Vittorie() + " vittorie vinco tutto");
        }

    }

    internal class Dipendente
    {
        public int OreLavoro = 8;
        public string Ditta = "Adecco";
        public int AnniContratto = 10;

        public void Lamentela()
        {
            Console.WriteLine("lavoro da " + AnniContratto + " anni, presso" + Ditta);
        }

        public void Boh()
        {
            Console.WriteLine("provo a fare una modifica su" + AnniContratto.ToString());
        }
        
        public int Pensione()
        {
            return 30 + AnniContratto;
        }

        public void Contratto(int anni)
        {
            AnniContratto = AnniContratto + anni;
        }





    }

    internal class Animale
    {
        public string Razza = "pugliese";
        public int NumeroDenti = 25;
        public int Peso = 300;

        public void Saluto()
        {
            Console.WriteLine("Ciao sono Domenico e sono" + Razza + " peso " + Peso + "kg" + "e ho" + NumeroDenti + "denti");
        }

        public void NumeroCanasse(int denti)
        {
            NumeroDenti = NumeroDenti + denti;
        }

        public int Dieta()
        {
            return 400 - Peso;
        }

        public void PesoDaPerdere()
        {
            Console.WriteLine("mi mancano" + Dieta() + "per stare in forma");
        }

    }

    internal class Veicolo
    {
        public string Marca = "Mercedes";
        public int RUote = 6;

        public void ShowRoom()
        {
            Console.WriteLine("ho comprato una macchina della " + Marca + "ha " +  RUote + "ruote");
        }

        public void NumeroPneumatici(int ruote)
        {
            RUote = RUote + ruote;
        }

        public string CambioMarca()
        {
            return Marca + "sooooo";
        }

        public void NuovaMarca()
        {
            Console.WriteLine("la mia " + CambioMarca());
        }

    }




}
