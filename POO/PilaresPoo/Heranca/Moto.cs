using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Moto: Veiculo
    {
        public int QuntidadeSilindradas;

        public int QuantidadeRodas;

        public void SomDamoto()
        {
            Console.WriteLine($"grrrrrrrrrrrr");
        }

        public void ExibirInfo()
        {

            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Quantidade de rodas: {QuantidadeRodas}");

        }
        
        public void Acelerar()
        {
            Console.WriteLine($"UUU tu tu tutu");
        }
    }
}