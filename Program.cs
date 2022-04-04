using System;


namespace exercicio15
{
    internal class Program
    {

        const int MAX = 20;

    static void InserePilha(char[] p, ref int t, char v)
    {
        p[t] = v;
        t = t + 1;
    }
    static char RemovePilha(char[] p, ref int t)
    {
        t = t - 1;
        return (p[t]);
    }
    static bool EstaVaziaPilha(int t)
    {
        if (t == 0)
            return true;
        else
            return false;
    }
    static bool EstaCheiaPilha(int t, int maxVal)
    {
        if (t == maxVal)
            return true;
        else
            return false;
    }

    // -----------------------------------------------------------------------------------------------------------

    static void InsereFila(int[] q, ref int f, int v)
    {
        q[f] = v;
        f = f + 1;
    }
    static int RemoveFila(int[] q, ref int i)
    {
        int v = q[i];
        i = i + 1;
        return (v);
    }
    static bool EstaVaziaFila(int i, int f)
    {
        if (i == f)
            return true;
        else
            return false;
    }
    static bool EstaCheiaFila(int f, int maxValFila)
    {
        if (f == maxValFila)
            return true;
        else
            return false;
    }



    static void trabalho1()
    {
        int potencia(int valueX, int valueY)
        {
            if (valueY == 0)
            {
                return 1;
            }
            else
            {
                return valueX * potencia(valueX, valueY - 1);
            }
        }

        void cubos(int valueCuboN)
        {
            for (int i = 1; i <= valueCuboN; i++)
            {
                Console.Write(i * i * i);
            }
        }

        int mdc(int num1, int num2)
        {
            if (num1 == num2)
            {
                return num1;
            }
            else if (num1 < num2)
            {
                return mdc(num2, num1);
            }
            else
            {
                return mdc(num1 - num2, num2);
            }
        }

        int fibonacci(int numN)
        {
            if (numN == 0 || numN == 1) return numN;
            else return fibonacci(numN - 1) + fibonacci(numN - 2);
        }

        void binario(int numInt)
        {
            int result = numInt / 2;
            int resto = numInt % 2;

            if (resto == 0)
            {
                binario(result);
            }
            Console.WriteLine(result % 2);
        }

        int n = 2;

        while (n <= 6)
        {
            Console.WriteLine("Escolha algum exercício: \n(2) Potência \n(3) Cubos \n(4) MDC \n(5) Fibonacci \n(6) Converter para binário");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 2:
                    int x, y;

                    Console.WriteLine("Escolhe um número para obter sua potência, primeiro base e depois expoente: ");

                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(potencia(x, y));

                    break;
                case 3:
                    int cubosN;

                    Console.WriteLine("Escolha um número: ");

                    cubosN = Convert.ToInt32(Console.ReadLine());

                    cubos(cubosN);

                    break;
                case 4:
                    Console.WriteLine("Escolha dois números para achar o MDC deles: ");
                    int numx, numy;

                    numx = Convert.ToInt32(Console.ReadLine());
                    numy = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(mdc(numx, numy));

                    break;
                case 5:
                    int numFib;

                    Console.WriteLine("Escolha um número para saber sua sequência Fibonacci: ");

                    numFib = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(fibonacci(numFib));

                    break;
                case 6:
                    int numBi;

                    Console.WriteLine("Escolha um número para saber binário: ");

                    numBi = Convert.ToInt32(Console.ReadLine());

                    binario(numBi);
                    break;

                default:
                    Console.WriteLine("Hello world!!");
                    break;
            }
        }

    }

    static void trabalho2()
    {
        string frase, novaFrase = "";

        int tamanho, topo = 0;

        Console.WriteLine("Insira uma frase para o algoritmo mostrar invertida: ");
        frase = Console.ReadLine() + " ";

        char[] pilhaVal;

        tamanho = frase.Length;

        pilhaVal = new Char[tamanho];
        
        int i = 0;

        while (i < frase.Length - 1)
        {
            while (frase[i] != ' ' && i < frase.Length - 1)
            {
                InserePilha(pilhaVal, ref topo, frase[i]);
                i = i + 1;
            }

            while (!EstaVaziaPilha(topo))
            {   
                char novaFraseVal = RemovePilha(pilhaVal, ref topo);
                novaFrase = novaFrase + novaFraseVal;
            }

            novaFrase += " ";
            i = i + 1;
        }

        Console.WriteLine(novaFrase);
        Console.ReadKey();
    }

    static void Main()
    {

        trabalho2();
    }
    }
}
