


namespace Heranca
{
    public class gato : Animal
    {
       
        public string nome;

        public string raça;

        public int idade;

        public void ExibirInfo()
        {
            Console.WriteLine($"nome: {nome}, raça: {raça} idade: {idade}");
        }
        
         public void FazerSom()
        {
            Console.WriteLine("miau ");
        }
    }
}