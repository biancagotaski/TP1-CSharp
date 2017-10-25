using System;
using System.Windows;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Beep(1000, 1000);
            

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            string userMessage = string.Format("{0:c}", 1000);
            Console.WriteLine(userMessage);
            MessageBox.Show(userMessage);

            //string num;
            //Console.Write("Digite o primeiro número: ");
            //num = Console.ReadLine();
            //float variavel;
            //float.TryParse(num , out variavel);
            ////Console.Write("O número digitado é: {0}", num);

            //string num2;

            //Console.Write("Digite o segundo número: ");
            //num2 = Console.ReadLine();
            //float variavel2;
            //float.TryParse(num2, out variavel2);

            //float resultado = variavel + variavel2;
            //Console.Write("O resultado final é: {0}", resultado);

            //Console.Write("Pressione qualquer tecla para sair.");
            Console.ReadKey();

            //Quando se tem mais de um parâmetro na concatenação para mostrar no console:
            //Console.WriteLine("Olá {0}, sua idade é {1}, nome, idade);
            //Interpolação de string, fica:
            //Console.WriteLine($"Olá {nome}, sua idade é {idade}");

            //Para criar uma variável dinâmica, em caso de querer passar valores de tipos diferentes para ela, e não precisar fazer conversão:
            //dinamyc nomeDaVariavel;
            //nomeDaVariavel = "Joana";
            //nomeDaVariavel = 20;

            
        }
    }
}