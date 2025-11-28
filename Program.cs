Console.WriteLine("--- Esperto Contra Sabido ---\n");

int totalAlimentos = ObterTotalAlimentos();

if (totalAlimentos <= 0) return;

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
        int FinkFoxAlimentos = 0;
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

            int distribuidosFinkFox = DistribuirParaFinkFox(ref restantes, ref FinkFoxAlimentos, contadorRodada);

            if (distribuidosFinkFox > 0)
            {
                Console.Write($" ");
                Console.WriteLine("para mim.");
            }
        }

        ExibirResultadoFinal(PicaPauAlimentos, FinkFoxAlimentos);
    }

    static int DistribuirParaFinkFox(ref int restantes, ref int FinkFoxAlimentos, int limite)
    {
        int contadorFinkFox = 0;
        for (int i = 0; i < limite && restantes > 0; i++)
        {
            contadorFinkFox++;
            FinkFoxAlimentos++;
            restantes--;

            Console.Write(contadorFinkFox);

            if (i < limite - 1 && restantes > 0)
            {
                Console.Write(", ");
            }
        }
        return contadorFinkFox;
    }

    static void ExibirResultadoFinal(int PicaPau, int FinkFox)
    {
        Console.WriteLine();
        Console.WriteLine($"Pica-pau recebeu {PicaPau} alimento(s).");
        Console.WriteLine($"Fink Fox recebeu {FinkFox} alimento(s).");
    }


