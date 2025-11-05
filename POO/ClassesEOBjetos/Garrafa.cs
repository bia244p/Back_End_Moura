using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEOBjetos
{
    public class Garrafa
    {
        public string Formato;

        public string Tamanho;

        public float Preco;

        public void EncherAgua()
        {
            Console.WriteLine("Enchendo de agua");
        }

        public void EsvaziarGarrafa()
        {
            Console.WriteLine("Esvaziando Garrafa");
        }

    }
}