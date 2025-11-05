using ClassesEOBjetos;

// Console.WriteLine("Bem-Vindo Cadraste seu celular");

// Console.WriteLine("Digite a cor do seu celular: ");
// string CorDigitada = Console.ReadLine();

// Console.WriteLine("Digite o preco do seu celular: ");
// float PrecoDigitado = float.Parse(Console.ReadLine());

// Console.WriteLine("Digite o modelo: ");
// string ModeloDigitado = Console.ReadLine();

// //
// Celular Iphone = new Celular();

// Iphone.Preco = PrecoDigitado;

// Iphone.Modelo = ModeloDigitado;

// Iphone.Cor = CorDigitada;

// Console.WriteLine($"A cor do seu iphone e: {Iphone.Cor} O modelo dele e: {Iphone.Modelo} e o preco e: {Iphone.Preco}");
// Iphone.Ligar();


Console.WriteLine("Me diz o Formato");

//Varialvel do Tipo string  - RadLine pega o que o usuario digitou no terminal
string FormatoGarrafa = Console.ReadLine();

Console.WriteLine("Coloque o tamanho");
string TamanhoGarrafa = Console.ReadLine();

Console.WriteLine("Me diz o preco");
float PrecoGarrafa = float.Parse(Console.ReadLine());

Console.WriteLine("Me diz seu nome");
string NomeUsuario = Console.ReadLine();


//criacao do objeto
Garrafa China = new Garrafa();


//preenchendo os valores das propriedades
China.Formato = FormatoGarrafa;
China.Preco = PrecoGarrafa;
China.Tamanho = TamanhoGarrafa;

Console.WriteLine($"O {NomeUsuario} Tem uma garrafa no formato {China.Formato} e no temanho {China.Tamanho} com o preco {China.Preco}");

//chmando os metodos do objeto china
China.EncherAgua();
China.EsvaziarGarrafa();



