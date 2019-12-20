using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe quantas vezes os interuptores serão usados:");
            int quantidade = int.Parse(Console.ReadLine());
            Lampada h = new Lampada();

            for(int i = 0; i <quantidade; i++)
            {
                Console.Write("Informe o interruptor: ");
                h.VerificarInteruptor(int.Parse(Console.ReadLine()));
            }

            int l1 =  h.ValorFinalL1();
            int l2 = h.ValorFinalL2();

            Console.WriteLine(l1);
            Console.WriteLine(l2);

        }
    }
}
