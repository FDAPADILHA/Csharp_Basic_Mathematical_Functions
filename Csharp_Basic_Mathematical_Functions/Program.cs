using System;
using System.Globalization;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;
            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            Console.WriteLine("Raiz quadrada de " + x + " = " + A);
            Console.WriteLine("Raiz quadrada de " + y + " = " + B);
            Console.WriteLine("Raiz quadrada de 25 = " + C);
            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine(x + " elevado a " + y + " = " + A);
            Console.WriteLine(x + " elevado ao quadrado = " + B);
            Console.WriteLine("5 elevado ao quadrado = " + C);
            A = Math.Abs(y);
            B = Math.Abs(z);
            Console.WriteLine("Valor absoluto de " + y + " = " + A);
            Console.WriteLine("Valor absoluto de " + z + " = " + B);
            Console.ReadLine();
            */
            //Bháskara programada
            // delta = Math.Pow(b, 2.0) - 4 * a * c;
            //x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            //x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            //EXERCICIO 2

            /*Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma casa decimal, 
             *bem como o valor do metro quadrado do terreno com duas casas decimais.  
             *Em seguida, o programa deve mostrar o valor da área do terreno, 
             *bem como o valor do preço do terreno, ambos com duas casas decimais.*/

            double largura, comprimento, valorMetroQuadrado, area, preco;
            Console.WriteLine("Insira a largura do terreno em metros: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o comprimento do terreno em metros: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor do metro quadrado do terrreno: ");
            valorMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * valorMetroQuadrado;

            Console.WriteLine("A área do seu terreno é: " + area.ToString("F2",CultureInfo.InvariantCulture) + " metros");
            Console.WriteLine("O preço do terreno é: " + preco.ToString("F2",CultureInfo.InvariantCulture) + "R$");

            /*Debug no Visual Studio

                Parar marcar uma linha de breakpoint:
	                Depuar->Alternar ponto de interrupção(F9)

                Para iniciar o debug:
	                Depurar->Iniciar depuração(F5)

                Para executar uma linha:
	                F10

                Para interromper o debug:
                    SHIFT + F5*/
        }
    }
}