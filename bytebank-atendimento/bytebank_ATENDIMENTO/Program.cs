Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

//TestaArrayInt();
//void TestaArrayInt()
//{
//    int[] idades = { 30, 40, 17, 21, 18 };
//    Console.WriteLine($"Tamanho do Array: {idades.Length}");

//    for (int i = 0; i < idades.Length; i++)
//    {
//        Console.WriteLine($"Indice [{i}] = {idades[i]}");
//    }

//    Console.WriteLine($"Média de idades: {idades.Average()}");
//}


void MediaDaAmostra(double[] amostra)
{
    double media = 0;
    double acumulador = 0;

    if ((amostra == null) || (amostra.Length == 0))
    {
        Console.WriteLine("Amostra de dados nula ou vazia.");
    }
    else
    {
        for (int i = 0; i < amostra.Length; i++)
        {
            acumulador = acumulador + amostra[i];
        }
        media = acumulador / amostra.Length;
        Console.WriteLine($"a média é {media}");
    }


}

double[] valores = { 2.4, 10, 5.7, 15 };
MediaDaAmostra(valores);

//double CalculaMedia(double[] valores)
//{
//    double media = 0;
//    double acumulador = 0;

//    if ((valores == null) || (valores.Length == 0))
//    {
//        Console.WriteLine("Amostra de dados nula ou vazia.");
//        return 0;
//    }
//    else
//    {
//        for (int i = 0; i < valores.Length; i++)
//        {
//            acumulador = acumulador + valores[i];
//        }
//        media = acumulador / valores.Length;
//    }

//    return media;
//}

