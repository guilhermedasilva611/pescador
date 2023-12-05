using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 * Um pescador comprou um microcomputador para controlar o rendimento diário de seu trabalho. 
 * Toda vez que ele traz um peso de peixes maior que o estabelecido pelo regulamento de pesca do estado 
 * de São Paulo (50 quilos) deve pagar uma multa de R$ 4,00 por quilo excedente. Assim, faça um
 * programa que leia o peso de peixes e verifique se há excesso. Se houver, o programa também deve calcular 
 * o valor da multa que o pescador deverá pagar. No final, o programa deve imprimir o excesso e a multa paga pelo pescador.
 */


namespace Pescador
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("-----PESCADOR-----");


            int i = 1, peixes = 0;
            const double pesoLimite = 50;
            const double acimaDe50Kg = 4.00;
            double pesoPeixe = 0, totalPesoPeixes = 0, multa = 0;


            do
            {

                Console.Write("Digite o peso do peixe:");
                pesoPeixe = double.Parse(Console.ReadLine());

                totalPesoPeixes += pesoPeixe;
                peixes++;

                Console.Write("Deseja pesar outro peixe?(1)-Sim (2)-Não");
                i = int.Parse(Console.ReadLine());

            } while (i == 1);


            if (totalPesoPeixes > pesoLimite)
            {
                totalPesoPeixes -= pesoLimite;
                multa = totalPesoPeixes * acimaDe50Kg;
            }
            else
            {
                Console.WriteLine("Os peixe estão dentro do limite do estado de São Paulo");
            }


            Console.WriteLine($"Total de Peixes pescados:{peixes}");
            Console.WriteLine($"Total de multa a pagar:{multa:F2}");
        }
    }
}
