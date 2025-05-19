Console.Clear();

Console.WriteLine("--- Fluxograma da Engenharia ---");

Console.Write("O objeto está se movendo (S/N)? ");
char movendo = Convert.ToChar(Console.ReadLine()!.ToUpper());

if (movendo == 'S')
    {
        Console.Write("Deveria (S/N)? ");
        movendo = Convert.ToChar(Console.ReadLine()!.ToUpper());
            if( movendo == 'S')
             {
                Console.WriteLine("Ótimo.");
            }
            else
             {
                Console.WriteLine("Use Silver Tape.");
             }
     }
else
    {
        Console.Write("Deveria (S/N)? ");
        movendo = Convert.ToChar(Console.ReadLine()!.ToUpper());

            if( movendo == 'S')
            {
                Console.WriteLine("Use WD-40");
            }
            else
            {
                Console.WriteLine("Ótimo.");
            }
    }
        