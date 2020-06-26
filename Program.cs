using System;

namespace InteiroMaior
{
    class Program
    {
        static void Main(string[] args)
        {
           int num;
           Console.WriteLine("Digite um número maior que 0 (e tecle ENTER)");
            num = int.Parse(Console.ReadLine());
           Console.WriteLine("A sequência é:");
            for(int i = 0; i <= num; i++)
           {
                Console.WriteLine(i);
           }
        }
    }
}
