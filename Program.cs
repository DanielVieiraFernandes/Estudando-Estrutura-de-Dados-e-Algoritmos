class Program
{

    //public static void compararNumero(int[] vetor, int numero, int inicio, int fim)
    //{
    //    if (inicio >= vetor.Length || inicio < 0)
    //    {
    //        Console.WriteLine("O número não está presente no vetor");
    //        return;
    //    }

    //    if (Math.Abs((vetor.Length - 1) - fim) <= 3)
    //    {
    //        int fimAntigo = fim;
    //        fim = inicio;
    //        if (vetor[inicio] > numero)
    //        {
    //            inicio = inicio-- == fimAntigo ? inicio + 1 : inicio--;
    //            compararNumero(vetor, numero, inicio, fim);
    //            return;
    //        }
    //        else if (vetor[inicio] < numero)
    //        {
    //            inicio = inicio++ == fimAntigo ? inicio - 1 : inicio++;
    //            compararNumero(vetor, numero, inicio, fim);
    //            return;
    //        }
    //        else if (vetor[inicio] == numero)
    //        {
    //            Console.WriteLine($"Número {numero} está presente no vetor na posição {inicio}");
    //            return;
    //        }

    //        Console.WriteLine($"Número {numero} não está presente no vetor");
    //        return;

    //    }

    //    fim = inicio;

    //    if (vetor[inicio] > numero)
    //    {
    //        inicio = (vetor.Length / 2) - (inicio / 2);
    //        compararNumero(vetor, numero, inicio, fim);
    //        return;
    //    }
    //    else if (vetor[inicio] < numero)
    //    {
    //        inicio = (vetor.Length / 2) + (inicio / 2);
    //        compararNumero(vetor, numero, inicio, fim);
    //        return;
    //    }
    //    else if (vetor[inicio] == numero)
    //    {
    //        Console.WriteLine($"Número {numero} está presente no vetor na posição {inicio}");
    //        return;
    //    }
    //}

    public static void compararNumero(int[] vetor, int alvo, int baixo, int alto)
    {
        if (baixo > alto)
        {
            Console.WriteLine($"Número {alvo} não está presente no vetor");
            return;
        }

        int meio = baixo + (alto - baixo) / 2;

        if (vetor[meio] == alvo)
        {
            Console.WriteLine($"Número {alvo} está presente no vetor na posição {meio}");
            return;
        }
        else if (vetor[meio] > alvo)
        {
            compararNumero(vetor, alvo, baixo, meio - 1);
        }
        else
        {
            compararNumero(vetor, alvo, meio + 1, alto);
        }
    }
    public static void Main()
    {
        Console.Write("Digite o número que você quer encontrar no vetor: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int[] vetor = [2, 12, 45, 67, 123, 208, 300, 408, 567, 638, 740, 1012, 1200, 1386, 1776];

        compararNumero(vetor, numero, 0, vetor.Length - 1);
    }

}
