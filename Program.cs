using System;
using System.Globalization;

namespace lanchonete_uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double totaldaConta;



            Console.WriteLine("DIGITE O CODIGO DO ITEM: ");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE A QUANTIDADE DO ITEM: ");
            quantidade = int.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                totaldaConta = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                totaldaConta = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                totaldaConta = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                totaldaConta = quantidade * 2.0;
            }
            else
            {
                totaldaConta = quantidade * 1.50;
            }

            Console.WriteLine("O VALOR TOTAL É: R$ " + totaldaConta.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
