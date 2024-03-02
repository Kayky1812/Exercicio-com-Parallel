using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExemploParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime inicio, fim;

            inicio = DateTime.Now;

            Parallel.Invoke(
               () =>
               {
                   Console.WriteLine("Iniciando Processo1");
                   Thread.Sleep(5000);
                   Console.WriteLine("Finalizando Processo1");
                   Console.WriteLine("Iniciando Processo4");
                   Thread.Sleep(3000);
                   Console.WriteLine("Finalizando Processo4");
               },
               () =>
               {
                   Console.WriteLine("Iniciando Processo2");
                   Thread.Sleep(4000);
                   Console.WriteLine("Finalizando Processo2");
                   Console.WriteLine("Iniciando Processo5");
                   Thread.Sleep(5000);
                   Console.WriteLine("Finalizando Processo5");
               },
               () =>
               {
                   Console.WriteLine("Iniciando Processo3");
                   Thread.Sleep(3000);
                   Console.WriteLine("Finalizando Processo3");
               }
            );
            Console.WriteLine("Iniciando Processo6");
            Thread.Sleep(1000);
            Console.WriteLine("Finalizando Processo6");
            fim = DateTime.Now;
            Console.WriteLine("Tudo encerrado após " + (fim - inicio) + " segundos.");
            Console.ReadKey();
        }
    }
}
