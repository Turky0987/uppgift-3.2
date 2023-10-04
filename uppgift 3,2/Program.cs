using System;

class Program
{
    static void Main()
    {
        Console.Write("Har du gått ut gymnasiet? (j/n): ");
        char harGåtUtGymnasiet = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (harGåtUtGymnasiet == 'j' || harGåtUtGymnasiet == 'J')
        {
            Console.Write("Hur gammal är du? Ange ålder: ");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig.");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");
            }
        }
        else
        {
            Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");
        }
    }
}
