﻿// definizione array 
string[] cibi = { "pizza", "carbonara", "sushi", "bistecca", "lasagna" };

// stampo la lunghezza della classifica
Console.WriteLine("Lunghezza della classifica. " + cibi.Length);

for (int i = 0; i < cibi.Length; i++)
{
    // stampo ogni piatto e la sua posizione in classifica
    Console.WriteLine("piatto in posizione "+ (i+1) + ": " + cibi[i]);
}

// stampo il primo elemento dell'array 
Console.WriteLine("Piatto preferito: " + cibi[0]);

// stampo l'ultimo elemento dell'array
Console.WriteLine("Piatto meno preferito: " + cibi[cibi.Length -1]);

