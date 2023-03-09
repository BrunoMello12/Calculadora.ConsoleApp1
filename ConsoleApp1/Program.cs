internal class Program
{
    private static void Main(string[] args)
    {


        while (true)
        {
            Console.Clear();
            Console.WriteLine("Digite 1 para somar");
            Console.WriteLine("Digite 2 para multiplicar");
            Console.WriteLine("Digite 3 para subtrair");
            Console.WriteLine("Digite 4 para dividir");
            Console.WriteLine("Digite 5 para gerar a tabuada");
            Console.WriteLine("Digite S para sair");

            string opcao = Console.ReadLine();

            if (opcao == "s" || opcao == "S")
            {
                break;
            }
            if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "s" && opcao != "S" && opcao != "5")
            {
                Console.WriteLine("Opção inválida, tente novamente!");
                continue;
            }

            if (opcao == "5")
            {
                Console.WriteLine("Informe um número para a tabuada: ");
                int tabuada = int.Parse(Console.ReadLine());
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{tabuada} X {i} = {tabuada * i}");
                }
            }
            else
            {
                Console.Write("Informe o número: ");
                decimal n1 = decimal.Parse(Console.ReadLine());
                Console.Write("Informe outro número: ");
                decimal n2 = decimal.Parse(Console.ReadLine());



                if (opcao == "1")
                {
                    decimal soma = n1 + n2;
                    decimal result = Math.Round(soma, 2);
                    Console.WriteLine($"A soma ficou: {result}");
                }
                else if (opcao == "2")
                {
                    decimal multi = n1 * n2;
                    decimal result = Math.Round(multi, 2);
                    Console.WriteLine($"A multiplicação ficou: {result}");
                }
                else if (opcao == "3")
                {
                    decimal sub = n1 - n2;
                    decimal result = Math.Round(sub, 2);
                    Console.WriteLine($"A subtração ficou: {result}");
                }
                else if (opcao == "4")
                {
                    if (n2 == 0)
                    {
                        Console.WriteLine("O segundo número não pode ser ZERO");
                        Console.WriteLine("Informe o segundo número: ");
                        n2 = decimal.Parse(Console.ReadLine());
                        decimal div = n1 / n2;
                        decimal result = Math.Round(div, 2);
                        Console.WriteLine($"A divisão ficou: {result}");
                    }
                    else
                    {
                        decimal div = n1 / n2;
                        decimal result = Math.Round(div, 2);
                        Console.WriteLine($"A divisão ficou: {result}");
                    }
                }
            }
            Console.ReadLine();
        }
        
    }
}
   
    