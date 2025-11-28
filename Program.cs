/*
int parteFox, partePicaPau;

conta o numero normal
1
2
3
4
5
6
7
8
9
10

conta o numero de forma extensa

1
1 2
1 2 3
1 2 3 4



Console.WriteLine("--- Esperto Contra Sabido ---\n");

Console.WriteLine("Quantos alimentos serão distribuídos? ");



Console.WriteLine($"Pica-pau recebeu {partePicaPau} alimento(s).");
Console.WriteLine($"Fox recebeu {parteFox} alimento(s).");

*/



Console.WriteLine("--- Esperto Contra Sabido ---\n");

        int totalAlimentos = ObterTotalAlimentos();

        if (totalAlimentos <= 0)
        {
            return;
        }

        Console.WriteLine();

        DistribuirAlimentos(totalAlimentos);
    

    static int ObterTotalAlimentos()
    {
        Console.Write("Quantos alimentos serão distribuídos? ");
        if (int.TryParse(Console.ReadLine(), out int total))
        {
            return total;
        }
        return 0;
    }

    
    static void DistribuirAlimentos(int totalInicial)
    {
        int restantes = totalInicial;
        int PicaPauAlimentos = 0;
        int FoxAlimentos = 0;
        int contadorRodada = 0;

        while (restantes > 0)
        {
            contadorRodada++;

            if (restantes > 0)
            {
                PicaPauAlimentos++;
                restantes--;
                Console.Write($"{contadorRodada} para você. ");
            }

            int distribuidosFox = DistribuirParaFox(ref restantes, ref FoxAlimentos, contadorRodada);

            if (distribuidosFox > 0)
            {
                Console.WriteLine("para mim.");
            }
            else
            {
                Console.WriteLine();
            }
        }

        ExibirResultadoFinal(PicaPauAlimentos, FoxAlimentos);
    }

    static int DistribuirParaFox(ref int restantes, ref int FoxAlimentos, int limite)
    {
        int contadorFox = 0;
        for (int i = 0; i < limite && restantes > 0; i++)
        {
            contadorFox++;
            FoxAlimentos++;
            restantes--;

            Console.Write(contadorFox);

            if (i < limite - 1 && restantes > 0)
            {
                Console.Write(", ");
            }
        }
        return contadorFox;
    }

    static void ExibirResultadoFinal(int PicaPau, int Fox)
    {
        Console.WriteLine();
        Console.WriteLine($"Pica-pau recebeu {PicaPau} alimento(s).");
        Console.WriteLine($"Fox recebeu {Fox} alimento(s).");
    }


