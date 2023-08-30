using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w11_3
{
    public class ContoCorrente
    {

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public decimal ImportoIniziale { get; set; }
        private decimal _saldo = 0;
        public decimal import = 0;
        decimal[] array=new decimal[10];

        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; } 
        }
        private bool contoAperto = false;
        public bool ContoAperto
        {
            get { return contoAperto; }
            set { contoAperto = value;}
        }
        public double Scelta { get; set; }

        public ContoCorrente() { }
        public ContoCorrente(double scelta,string nome, string cognome, decimal importo)
        {
            Scelta = scelta;
            Nome = nome;
            Cognome=cognome;
            ImportoIniziale = importo;
        }

        public ContoCorrente( double scelta,decimal importo)
        {
            Scelta = scelta;
            import = importo;
        }




        public void Versamento(decimal importo)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = importo; 
            }
           
      
            _saldo += importo ;
            Console.WriteLine("Conto: " + importo);
            via();
        }

        public void Prelievo(decimal importo)
        {
          
            _saldo -= importo;
            Console.WriteLine("Conto: " + importo);
            via();
        }
        public void via()
        {
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("       -------BANCA-------           ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Scegli l'operazione da effettuare");
            Console.WriteLine("1 APRI NUOVO CONTO CORRENTE");
            Console.WriteLine("2 EFFETTUA UN VERSAMENTO");
            Console.WriteLine("3 EFFETTUA UN PRELIEVO");
            Console.WriteLine("4 ESCI");

            double scelta = Convert.ToDouble(Console.ReadLine());


            if (scelta == 1)
            {
                //Apri conto
                Console.WriteLine(" ");
                Console.WriteLine("Inserisci nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Inserisci cognome");
                string cognome = Console.ReadLine();
                Console.WriteLine("Importo iniziale minimo 1000$");
                decimal importo =decimal.Parse( Console.ReadLine());

                ContoCorrente contoCorrente1 = new ContoCorrente(scelta, nome, cognome,importo);
                Console.WriteLine("Conto corrente n° 2383899 intestato a " + nome + " " + cognome + " aperto correttamente");

            }

            else if (scelta == 2)
            {

                Console.WriteLine(" ");
                Console.WriteLine("Inserisci la cifra dell'importo da versare");
                decimal importo = decimal.Parse(Console.ReadLine());

                ContoCorrente contoCorrente1 = new ContoCorrente(scelta, importo);
               contoCorrente1.Versamento(importo);
               

            }
            else if (scelta == 3)
            {


                Console.WriteLine(" ");
                Console.WriteLine("Inserisci la cifra dell'importo da prelevare");
                decimal importo = decimal.Parse(Console.ReadLine());

                ContoCorrente contoCorrente1 = new ContoCorrente(scelta, importo);
                contoCorrente1.Prelievo(importo);
            }
            else if (scelta == 4)
            {

                Console.WriteLine("Esci");
            }




        }
    }
}
