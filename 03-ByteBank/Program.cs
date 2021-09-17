using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente("Gabriela",0001,2382219,0.0);
            ContaCorrente contaDaDaniela = new ContaCorrente("Daniela", 0001, 2382218, 100.0);

            contaDaGabriela.Depositar(100);
            contaDaGabriela.Sacar(50);
            contaDaDaniela.Transferir(contaDaGabriela, 50);

            Console.WriteLine(contaDaGabriela.ToString());
            Console.WriteLine(contaDaDaniela.ToString());

           

            Console.ReadLine();
        }

    }
}
