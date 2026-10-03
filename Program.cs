using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // --- MAPEAMENTO DE FREQUÊNCIAS ---
        int DoGrave = 660; 
        int Re = 1485;
        int Fa = 1759;
        int Sol = 1980;
        int SolSustenido = 2100; 
        int La = 2200;
        int LaSustenido = 2330; 
        int Si = 2475;

        int DoAgudo = 1320; 
        int ReAgudo = 2970; 
        int MiAgudo = 3300; 
        int FaAgudo = 3518; 

        int t = 110; 

        Console.Clear();
        Console.WriteLine("Tocando Megalovania... Pressione Ctrl+C para parar.");

        // ==========================================
        // 🎼 PARTE 1: O RIFF INICIAL (INTRODUÇÃO)
        // ==========================================
        
        // Linha 1
        Console.Beep(Re, t); Console.Beep(Re, t); Console.Beep(ReAgudo, t); Thread.Sleep(30);
        Console.Beep(La, t); Thread.Sleep(30); Console.Beep(SolSustenido, t); Console.Beep(Sol, t); 
        Console.Beep(Fa, t); Console.Beep(Re, t); Console.Beep(Fa, t); Console.Beep(Sol, t);
        Console.Beep(DoGrave, t); Console.Beep(DoGrave, t);
        Thread.Sleep(100);

        // Linha 2
        Console.Beep(Re, t); Console.Beep(Re, t); Console.Beep(ReAgudo, t); Thread.Sleep(30);
        Console.Beep(La, t); Thread.Sleep(30); Console.Beep(SolSustenido, t); Console.Beep(Sol, t); 
        Console.Beep(Fa, t); Console.Beep(Re, t); Console.Beep(Fa, t); Console.Beep(Sol, t);
        Console.Beep(Si, t); Console.Beep(Si, t);
        Thread.Sleep(100);

        // Linha 3
        Console.Beep(Re, t); Console.Beep(Re, t); Console.Beep(ReAgudo, t); Thread.Sleep(30);
        Console.Beep(La, t); Thread.Sleep(30); Console.Beep(SolSustenido, t); Console.Beep(Sol, t); 
        Console.Beep(Fa, t); Console.Beep(Re, t); Console.Beep(Fa, t); Console.Beep(Sol, t);
        Console.Beep(LaSustenido, t); Console.Beep(LaSustenido, t);
        Thread.Sleep(100);

        // Linha 4
        Console.Beep(Re, t); Console.Beep(Re, t); Console.Beep(ReAgudo, t); Thread.Sleep(30);
        Console.Beep(La, t); Thread.Sleep(30); Console.Beep(SolSustenido, t); Console.Beep(Sol, t); 
        Console.Beep(Fa, t); Console.Beep(Re, t); Console.Beep(Fa, t); Console.Beep(Sol, t);
        Console.Beep(LaSustenido, t); Console.Beep(LaSustenido, t);
        Thread.Sleep(200);


        // ==========================================
        // 🎹 PARTE 2: A SUBIDA DO TEMA (PRÉ-REFRÃO)
        // ==========================================
        
        // Linha 1
        Console.Beep(Fa, t); Console.Beep(Fa, t); Console.Beep(Fa, t); Console.Beep(Fa, t);
        Console.Beep(Re, t); Console.Beep(Re, t); Console.Beep(Re, t);
        Thread.Sleep(50);

        // Linha 2
        Console.Beep(Fa, t); Console.Beep(Fa, t); Console.Beep(Fa, t); Console.Beep(Sol, t);
        Console.Beep(SolSustenido, t); Console.Beep(Sol, t); Console.Beep(Fa, t); Console.Beep(Re, t);
        Console.Beep(Fa, t); Console.Beep(Sol, t);
        Thread.Sleep(50);

        // Linha 3
        Console.Beep(Fa, t); Console.Beep(Fa, t); Console.Beep(Fa, t); Console.Beep(Sol, t);
        Console.Beep(SolSustenido, t); Console.Beep(La, t); Console.Beep(DoAgudo, t); Console.Beep(La, t);
        Console.Beep(DoAgudo, t); Console.Beep(ReAgudo, t);
        Thread.Sleep(50);

        // Linha 4
        Console.Beep(ReAgudo, t); Console.Beep(ReAgudo, t); Console.Beep(ReAgudo, t); 
        Console.Beep(La, t); Console.Beep(La, t); Console.Beep(La, t); 
        Console.Beep(Sol, t); Console.Beep(Fa, t); Console.Beep(Re, t);
        Thread.Sleep(200);


        // ==========================================
        // 🔥 PARTE 3: O CLÍMAX (REFRÃO RÁPIDO)
        // ==========================================
        
        // Linha 1
        Console.Beep(ReAgudo, t); Console.Beep(ReAgudo, t); Console.Beep(ReAgudo, t); Thread.Sleep(30);
        Console.Beep(La, t); Thread.Sleep(30); Console.Beep(SolSustenido, t); Console.Beep(Sol, t); 
        Console.Beep(Fa, t); Console.Beep(Re, t); Console.Beep(Fa, t); Console.Beep(Sol, t);
        Console.Beep(FaAgudo, t); Console.Beep(FaAgudo, t);
        Thread.Sleep(100);

        // Linha 2
        Console.Beep(ReAgudo, t); Console.Beep(ReAgudo, t); Console.Beep(ReAgudo, t); Thread.Sleep(30);
        Console.Beep(La, t); Thread.Sleep(30); Console.Beep(SolSustenido, t); Console.Beep(Sol, t); 
        Console.Beep(Fa, t); Console.Beep(Re, t); Console.Beep(Fa, t); Console.Beep(Sol, t);
        Console.Beep(MiAgudo, t); Console.Beep(MiAgudo, t);
        Thread.Sleep(100);

        // Linha 3
        Console.Beep(ReAgudo, t); Console.Beep(ReAgudo, t); Console.Beep(ReAgudo, t); Thread.Sleep(30);
        Console.Beep(La, t); Thread.Sleep(30); Console.Beep(SolSustenido, t); Console.Beep(Sol, t); 
        Console.Beep(Fa, t); Console.Beep(Re, t); Console.Beep(Fa, t); Console.Beep(Sol, t);
        Console.Beep(ReAgudo, t); Console.Beep(ReAgudo, t);
        Thread.Sleep(100);

        // Linha 4 (Finalização)
        Console.Beep(La, t); Console.Beep(Sol, t); Console.Beep(Fa, t); Console.Beep(Re, t);
        Console.Beep(Fa, t); Console.Beep(Sol, t); Console.Beep(SolSustenido, t); Console.Beep(Sol, t);
        Console.Beep(Fa, t); Console.Beep(Re, t);

        // ==========================================
        // 💀 TELA FINAL: APARECE O SANS
        // ==========================================
        Console.Clear();
        DesenharSans();
    }

    static void DesenharSans()
    {
        Console.ForegroundColor = ConsoleColor.Cyan; // O famoso olho azul/ciano do Sans
        Console.WriteLine("\n         Megalovania terminada... You're gonna have a bad time.\n");
        Console.ResetColor();

        Console.WriteLine("                  @@@@@@@@@@@@@@@@        ");
        Console.WriteLine("              @@@@@@@@@@@@@@@@@@@@@@@@    ");
        Console.WriteLine("            @@@@@@@@@@@@@@@@@@@@@@@@@@@@  ");
        Console.WriteLine("           @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ ");
        Console.WriteLine("          @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("          @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        
        // Olhos (Destacando o olho esquerdo dele em azul se o terminal suportar)
        Console.Write("          @@@@  ");
        Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("████"); Console.ResetColor();
        Console.Write("  @@@@@@@@@@  ");
        Console.Write("████");
        Console.WriteLine("  @@@@");

        Console.Write("          @@@@  ");
        Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("████"); Console.ResetColor();
        Console.Write("  @@@@@@@@@@  ");
        Console.Write("████");
        Console.WriteLine("  @@@@");

        Console.WriteLine("          @@@@@@@@@@@@@@    @@@@@@@@@@@@@@");
        Console.WriteLine("           @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ ");
        Console.WriteLine("            @@@@@@@@@  ████████  @@@@@@@  ");
        Console.WriteLine("              @@@@@@@            @@@@@@   ");
        Console.WriteLine("                @@@@██████████████@@      ");
        Console.WriteLine("                  ██  ██  ██  ██  ██      ");
        Console.WriteLine("                    ██████████████        \n");
    }
}
