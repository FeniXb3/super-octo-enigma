using System;
					
public class Program
{
	public static void Main()
	{
        Console.Clear();
		Player hero = new Player();
		hero.Display();
        while(true)
        {
            Point nextPosition = hero.GetNextPosition();
            hero.MoveTo(nextPosition);
            nextPosition.x = 32;
            hero.Display();
        }
       
	}
}

public class Point
{
    public int x;
    public int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class Player
{
	string visuals = "@";
    Point position = new Point(0, 0);
	
	public void Display()
	{
		Console.Write(visuals);
        Console.WriteLine($" at ({position.x}, {position.y})");
	}

    public void MoveTo(Point targetPoint)
    {
        // position = targetPoint;
        position.x = targetPoint.x;
        position.y = targetPoint.y;
    }
    
    public Point GetNextPosition()
    {
        // Point point = new Point();
        // point.x = 2;
        // point.y = 5;
        // Point point = new Point()
        // {
        //     x = 2,
        //     y = 5
        // };
        Point point = new Point(position.x, position.y);
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key == ConsoleKey.D)
        {
            point.x += 1;
        }
        
        return point;
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