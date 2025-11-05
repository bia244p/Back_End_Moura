using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEOBjetos
{
    public class Celular
    {
        //propriedades 
        public string Cor;
        public float Preco;
        public string Modelo;

        //Metodos
        public void Ligar()
        {
            Console.WriteLine("Ligando celular");
        }
    }
}