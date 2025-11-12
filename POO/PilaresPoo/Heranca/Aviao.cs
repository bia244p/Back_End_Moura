using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Aviao : Veiculo
    {
        public int QtdAsas;

        public void Voar()
        {
            Console.WriteLine($"Avião levantou vouo");
        }

      public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Quantidade assas: {QtdAsas}");
        }

    }
}