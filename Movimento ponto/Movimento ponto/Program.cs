using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimento_ponto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a coordenada x:");
            int xInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a coordenada y:");
            int yInicial = int.Parse(Console.ReadLine());

            Ponto ponto = new Ponto(xInicial, yInicial);

            Console.WriteLine("Digite o valor de movimento para a esquerda:");
            int movimentoEsquerda = int.Parse(Console.ReadLine());
            ponto.MoverEsquerda(movimentoEsquerda);

            Console.WriteLine("Digite o valor de movimento para a direita:");
            int movimentoDireita = int.Parse(Console.ReadLine());
            ponto.MoverDireita(movimentoDireita);

            Console.WriteLine("Digite o valor de movimento para cima:");
            int movimentoCima = int.Parse(Console.ReadLine());
            ponto.MoverCima(movimentoCima);

            Console.WriteLine("Digite o valor de movimento para baixo:");
            int movimentoBaixo = int.Parse(Console.ReadLine());
            ponto.MoverBaixo(movimentoBaixo);

            ponto.ExibirCoordenadas();
        }
    }
}
