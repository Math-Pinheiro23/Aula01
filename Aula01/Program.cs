using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciação do objeto 
            Veiculo golf = new Veiculo();
            Console.Write("Digite a marca: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o modelo: ");
            String modelo = Console.ReadLine();
            Console.Write("Digite a placa: ");
            String placa = Console.ReadLine();
            Console.Write("Digite o ano de fabricação: ");
            int ano = int.Parse(Console.ReadLine());
            // objeto chamando método atribuir
            golf.atribuir(marca, modelo, placa, ano);
            Console.WriteLine(golf.retorna());
            Console.ReadKey();

        }
    }
}
