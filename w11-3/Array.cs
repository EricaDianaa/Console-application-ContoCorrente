using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace w11_3
{
    public class Array
    {
        public string[] Nomi = new string[5];
        public void AddName()
        {
            for (int i = 0; i < Nomi.Length; i++)
            {
                Console.WriteLine("Inserisci nome");
                Nomi[i] = Console.ReadLine();
            }
            Console.WriteLine("Cerca nome");
             string nome = Console.ReadLine();
   
            foreach (var item in Nomi)
            {
                if (nome == item)
                {
                    Console.WriteLine(nome + " è presente nell'array");
                }
                else
                {
                    Console.WriteLine(nome + " non è presente nell'array");
                }
            }




        }

        public double[] Number = new double[5];
        public void AddNumber()
        {
            for (int i = 0; i < Number.Length; i++)
            {
                Console.WriteLine("Inserisci numeri");
                Number[i] =double.Parse( Console.ReadLine());
               
            }
          
            Console.WriteLine(Number.Sum());
            Console.WriteLine(Number.Sum()/Number.Length);
        }


    }
}
