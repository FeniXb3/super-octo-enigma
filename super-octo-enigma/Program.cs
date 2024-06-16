﻿using System;

public class Program
{
	public static void Main()
	{
        Console.Clear();
		Player hero = new Player();
        Map map = new Map();
        map.Display();
		hero.Display();
        while(true)
        {
            Point nextPosition = hero.GetNextPosition();
            if (map.IsPositionCorrect(nextPosition))
            {
                hero.MoveTo(nextPosition);
                map.RedrawCellAt(hero.previousPosition);
                hero.Display();
            }
        }
	}
}

/*
Klasa Player

dane:
- pozycja
- zdrowie (aktualne/maksymalne)
- bazowy atak
- reprezentacja graficzna
- pancerz

akcje:
- poruszanie się
- atak
- podnoszenie przedmiotów
- obrywanie
- leczenie
- wyświetlenie na ekranie
- animacja

*/