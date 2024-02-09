using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        //ifs aqui (usar else if ao invés de vários ifs dentro de elses!)
        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("A alíquota do seu IR é de 7.5% e pode deduzir na declaração o valor de R$ 142");
        }
        else
        {
            if (salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("A alíquota do seu IR é de 15% e pode deduzir na declaração o valor de R$ 350");
            }
            else
            {
                if (salario >= 3751.01 && salario <= 4664.00)
                {
                    Console.WriteLine("A alíquota do seu IR é de 22.5% e pode deduzir na declaração o valor de R$ 636");
                }
            }
        }

    }
}